/*
 * Board.cs
 * Author: Jacob Grace
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four

{
    /// <summary>
    /// Class for the board 
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Gives the number of rows on the board
        /// </summary>
        public static readonly int Rows = 6;

        /// <summary>
        /// Gives the number of columns on the board
        /// </summary>
        public static readonly int Columns = 7;

        /// <summary>
        /// Amount of pieces needed for a potential win
        /// </summary>
        private static readonly int _winPieces = 3;

        /// <summary>
        /// Amount of cells on the board
        /// </summary>
        private static readonly int _cells = Rows * Columns;

        /// <summary>
        /// Field to give the value of the cells
        /// </summary>
        private static readonly int[,] _cellValues =
            {
                {3, 4, 5, 7, 5, 4, 3 },
                {4, 6, 8, 10, 8, 6, 4 },
                {5, 8, 11, 13, 11, 8, 5 },
                {5, 8, 11, 13, 11, 8, 5 },
                {4, 6, 8, 10, 8, 6, 4 },
                {3, 4, 5, 7, 5, 4, 3 }
            };

        /// <summary>
        /// Array giving the board with element[0] as the player
        /// </summary>
        private List<Player>[] _board = new List<Player>[Columns];

        /// <summary>
        /// Stack holding the past moves
        /// </summary>
        private Stack<int> _history = new Stack<int>();

        /// <summary>
        /// Gets the status of the game
        /// </summary>
        public GameStatus Status
        {
            get;
            private set;

        } = GameStatus.Unfinished;

        /// <summary>
        /// Property to keep track of the current player
        /// </summary>
        public Player CurrentPlayer
        {
            get;
            private set;
        } = new Player("Black", "../../pics/black-piece.png");

        /// <summary>
        /// Property to keep track of the other player
        /// </summary>
        public Player OtherPlayer
        {
            get;
            private set;
        } = new Player("White", "../../pics/white-piece.png");

        /// <summary>
        /// Keeps track of the amount of plays made 
        /// </summary>
        public int PlaysMade
        {
            get => _history.Count;
        }

        /// <summary>
        /// Constructor for the board 
        /// </summary>
        public Board()
        {
            for (int i = 0; i < _board.Length; i++)
            {
                _board[i] = new List<Player>();
            }
        }

        /// <summary>
        /// Swaps the current player with the other player
        /// </summary>
        private void SwapPlayers()
        {
            Player temp = CurrentPlayer;
            CurrentPlayer = OtherPlayer;
            OtherPlayer = temp;
        }

        /// <summary>
        /// Determines the length of a chain move
        /// </summary>
        /// <param name="row">Starting row</param>
        /// <param name="column">Starting column</param>
        /// <param name="player">Player who's pieces are to be examined</param>
        /// <param name="hor">Horizontal movement</param>
        /// <param name="vert">Vertical movement</param>
        /// <returns>Length of the sequence</returns>
        private int ChainLength(int row, int column, Player player, int hor, int vert)
        {
            int newRow = row + vert;
            int newColumn = column + hor;

            int count = 0;

            while (newRow >= 0 && newColumn < Columns && newColumn >= 0 && newRow < _board[newColumn].Count && _board[newColumn][newRow].Name == player.Name)
            {
                count++;
                newRow += vert;
                newColumn += hor;
            }
            return count;
        }

        /// <summary>
        /// Determines if a move is legal
        /// </summary>
        /// <param name="column">Column to check</param>
        /// <returns>Bool stating if the move is legal or not</returns>
        public bool IsLegalPlay(int column)
        {
            if (_board[column].Count < 6)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finds the amount of pieces in a specific column
        /// </summary>
        /// <param name="column">Column to find the amount in</param>
        /// <returns>Amount of pieces in a column</returns>
        public int ColumnHeight(int column)
        {
            return _board[column].Count;
        }

        /// <summary>
        /// Determines if a move will be a win
        /// </summary>
        /// <param name="row">Row to check</param>
        /// <param name="column">Column to check</param>
        /// <param name="player">Player to check</param>
        /// <returns></returns>
        public bool IsWinningLocation(int row, int column, Player player)
        {
            if (ChainLength(row, column, player, -1, 1) + ChainLength(row, column, player, 1, -1) >= 3 || ChainLength(row, column, player, 0, -1) >= 3
                || ChainLength(row, column, player, 1, 0) + ChainLength(row, column, player, -1, 0) >= 3 || ChainLength(row, column, player, 1, 1) + ChainLength(row, column, player, -1, -1) >= 3)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Makes a move and updates the board and the values
        /// </summary>
        /// <param name="column">Column to make a play on</param>
        public void Play(int column)
        {
            int row = _board[column].Count;
            CurrentPlayer.Score += _cellValues[_board[column].Count, column];
            _board[column].Add(CurrentPlayer);

            _history.Push(column);

            if (IsWinningLocation(row, column, CurrentPlayer))
            {
                Status = GameStatus.Won;

            }
            else if (_history.Count == _cells)
            {
                Status = GameStatus.Draw;
            }




            SwapPlayers();

        }
        /// <summary>
        /// Undoes a move
        /// </summary>
        /// <returns>Column the move was undone on</returns>
        public int Undo()
        {
            int column = _history.Pop();

            int row = _board[column].Count - 1;

            _board[column].RemoveAt(row);

            OtherPlayer.Score -= _cellValues[row, column];

            Status = GameStatus.Unfinished;

            SwapPlayers();


            return column;

        }
    }
}
