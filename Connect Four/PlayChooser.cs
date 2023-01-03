using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connect_Four
{
    /// <summary>
    /// Class for the algorithm on how to choose plays
    /// </summary>
    public static class PlayChooser
    {
        /// <summary>
        /// Gives the value for a win
        /// </summary>
        private static int _win = 1000000;

        /// <summary>
        /// Value of a cell that would be a win
        /// </summary>
        private static int _winningPlayValue = 100;
        /// <summary>
        /// Gives the value to use for the best play when no play is chosen
        /// </summary>
        private static int _noPlay = -1;

        /// <summary>
        /// Calculates the player's positional score
        /// </summary>
        /// <param name="player">Player's score to be calculated</param>
        /// <param name="board">Current board positon</param>
        /// <returns></returns>
        private static int PositionValue(Player player, Board board)
        {
            int playerScore = player.Score;
            for (int i = 0; i < Board.Columns; i++)
            {
                int height = board.ColumnHeight(i);
                if (i > 0)
                {
                    height = Math.Max(playerScore, board.ColumnHeight(i - 1)) + 1;
                }
                if (i < Board.Columns - 1)
                {
                    height = Math.Min(height, board.ColumnHeight(i + 1)) + 1;
                }
                playerScore = Math.Max(playerScore, Board.Rows);
                for (int j = board.ColumnHeight(i); j < height; j++)
                {
                    if (board.IsWinningLocation(j, i, player) == true)
                    {
                        playerScore += _winningPlayValue * (Board.Rows - (j - board.ColumnHeight(i)) - 1);
                        if (board.CurrentPlayer == player && board.ColumnHeight(i) == j)
                        {
                            return _win;
                        }
                    }

                }
            }
            return playerScore;
        }

        /// <summary>
        /// Finds the play to be made using the NegMax Algorithm
        /// </summary>
        /// <param name="board">Board position</param>
        /// <param name="depth">Depth to search</param>
        /// <param name="lower">Lower boundary of useful positon values</param>
        /// <param name="upper">Upper bound with useful position values</param>
        /// <param name="value">New position value</param>
        /// <returns>Best play found</returns>
        public static int FindPlay(Board board, int depth, int lower, int upper, out int value)
        {
            int bestPlay = _noPlay;
            if (board.Status == GameStatus.Won)
            {
                value = -_win;
                return bestPlay;
            }
            else if (board.Status == GameStatus.Draw)
            {
                value = 0;
                return bestPlay;
            }
            else
            {
                if (depth == 0)
                {
                    value = PositionValue(board.CurrentPlayer, board) - PositionValue(board.OtherPlayer, board);
                    return bestPlay;
                }
                else
                {
                    for (int i = 0; i < Board.Columns; i++)
                    {
                        if (board.IsLegalPlay(i))
                        {
                            board.Play(i);
                            FindPlay(board, depth - 1, -upper, -lower, out value);
                            board.Undo();
                            value = -value;
                            if (value > lower)
                            {
                                lower = value;
                                bestPlay = i;
                                if (lower >= upper)
                                {
                                    return bestPlay;
                                }
                            }

                        }
                    }
                    value = lower;
                }
                return bestPlay;
            }
        }
    }
}
