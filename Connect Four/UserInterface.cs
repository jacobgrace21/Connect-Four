using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Four;

namespace Connect_Four

{
    /// <summary>
    /// Class for the UserInterface
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Initializes the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            MakeUI();


        }

        /// <summary>
        /// Gives the font size to use on the buttons
        /// </summary>
        private static readonly int _font = 15;

        /// <summary>
        /// Gives the height of the buttons
        /// </summary>
        private static readonly int _height = 10;

        /// <summary>
        /// Gives the width and height of a piece
        /// </summary>
        private static readonly int _piece = 60;

        /// <summary>

        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        private static readonly Font _buttonFont = new Font(FontFamily.GenericSansSerif, _font, GraphicsUnit.Pixel);

        /// <summary>
        /// Gives the color for the columns
        /// </summary>
        private static readonly Color _color = Color.White;

        /// <summary>
        /// Current board
        /// </summary>
        private Board _board = new Board();

        /// <summary>
        /// Computer player if there is one, otherwise it is null
        /// </summary>
        private Player _computerPlayer;

        /// <summary>
        /// Makes a NewGameDialog to be used to start a new game
        /// </summary>
        private NewGameDialog _newGame = new NewGameDialog();


        private void MakeUI()
        {
            for (int i = 0; i < Board.Columns; i++)
            {
                Button newButton = new Button();
                newButton.Height = 60;
                newButton.Width = 60;
                newButton.Text = i.ToString();
                newButton.Font = _buttonFont;
                newButton.Margin = new Padding(5);
                newButton.Click += new EventHandler(uxButton_Click);
                uxButtonPanel.Controls.Add(newButton);
            }
            for (int j = 0; j < Board.Columns; j++)
            {
                FlowLayoutPanel newLabel = new FlowLayoutPanel();
                newLabel.Width = 60;
                newLabel.FlowDirection = FlowDirection.BottomUp;
                newLabel.Height = 360;
                newLabel.BackColor = Color.White;
                uxColumnPanel.Controls.Add(newLabel);
            }
            uxTextBox.Width = uxColumnPanel.Width;


        }


        /// <summary>
        /// Updates the status of the board
        /// </summary>
        public void UpdateStatus()
        {
            uxTextBox.Text = "Player's turn: " + _board.CurrentPlayer.Name;

            if (_board.Status == GameStatus.Won)
            {
                uxTextBox.Text = _board.OtherPlayer.Name + "Wins!";
                for (int i = 0; i < Board.Columns; i++)
                {
                    uxButtonPanel.Controls[i].Enabled = false;
                }

            }
            else if (_board.Status == GameStatus.Draw)
            {
                uxTextBox.Text = "It's a draw!";
            }
            Refresh();
        }
        /// <summary>
        /// Makes a play on a specific column
        /// </summary>
        /// <param name="column"></param>
        private void Play(int column)
        {
            Label label = new Label();
            label.Image = _board.CurrentPlayer.Picture;
            label.Size = new Size(_piece, _piece);
            uxColumnPanel.Controls[column].Controls.Add(label);
            _board.Play(column);
            if (!_board.IsLegalPlay(column))
            {
                uxButtonPanel.Controls[column].Enabled = false;
            }
            uxUndo.Enabled = true;
            UpdateStatus();
        }
        /// <summary>
        /// Makes a play for the computer if there is a computer player
        /// </summary>
        private void MakeComputerPlay()
        {
            int val = 0;
            int play = PlayChooser.FindPlay(_board, _newGame.Level, -int.MaxValue, int.MaxValue, out val);
            Play(play);
        }
        /// <summary>
        /// Clears the board
        /// </summary>
        private void ClearBoard()
        {
            for (int i = 0; i < Board.Columns; i++)
            {
                uxButtonPanel.Controls[i].Enabled = true;
                uxColumnPanel.Controls[i].Controls.Clear();
            }
            Update();
        }

        /// <summary>
        /// Makes a new game 
        /// </summary>
        /// <returns>Bool depending on if the game was made or not</returns>
        private bool NewGame()
        {
            _newGame.ShowDialog();
            if (_newGame.DialogResult == DialogResult.OK)
            {
                Board newBoard = new Board();
                _board = newBoard;
                ClearBoard();
                UpdateStatus();
                if (_newGame.ComputerPlayer)
                {
                    int level = _newGame.Level;
                    if (_newGame.ComputerPlayer)
                    {
                        _computerPlayer = _board.CurrentPlayer;
                        MakeComputerPlay();
                    }
                    else
                    {
                        _computerPlayer = null;
                        uxUndo.Enabled = false;
                        UpdateStatus();
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Undoes a single play
        /// </summary>
        private void Undo()
        {
            int col = _board.Undo();
            int row = uxColumnPanel.Controls[col].Controls.Count - 1;
            uxColumnPanel.Controls[col].Controls.RemoveAt(row);
        }


        /// <summary>
        /// Event handler for when a button is clicked to place a piece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_Click(Object sender, EventArgs e)
        {
            Button click = (Button)sender;
            Play(Int32.Parse(click.Text));
            if (_board.Status == GameStatus.Unfinished && _newGame.ComputerPlayer == true)
            {
                MakeComputerPlay();
            }
        }

        /// <summary>
        /// Handles the loading of the userinterface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            Visible = true;
            bool flag = NewGame();
            if (!flag)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles making a new game when the new game button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Handles a click on the undo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUndo_Click(object sender, EventArgs e)
        {
            Undo();
            for (int i = 0; i < Board.Columns; i++)
            {
                if (!_board.IsLegalPlay(i))
                {
                    uxButtonPanel.Controls[i].Enabled = false;
                }
                else
                {
                    uxButtonPanel.Controls[i].Enabled = true;

                }
            }
            if (_newGame.ComputerPlayer == false && _board.PlaysMade <= 0)
            {
                uxUndo.Enabled = false;
                if (_board.PlaysMade >= 1)
                {

                    uxUndo.Enabled = true;

                }
            }
            else
            {
                if (_board.CurrentPlayer == _computerPlayer)
                {
                    Undo();
                    if (_board.PlaysMade >= 1)
                    {

                        uxUndo.Enabled = true;

                    }
                    else
                    {
                        uxUndo.Enabled = false;
                    }
                }
            }
            uxTextBox.Text = "Player's turn: " + _board.CurrentPlayer.Name;
            UpdateStatus();
        }

        private void uxTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
