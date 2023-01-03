/*
 * NewGameDialog.cs
 * Author: Jacob Grace
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    /// <summary>
    /// Class for the NewGameDialog form
    /// </summary>
    public partial class NewGameDialog : Form
    {
        /// <summary>
        /// Initializes the gui
        /// </summary>
        public NewGameDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property that returns true if there is a computer player
        /// </summary>
        public bool ComputerPlayer
        {
            get => !uxNoComputer.Checked;

        }
        /// <summary>
        /// Property that returns true if the computer moves first
        /// </summary>
        public bool ComputerFirst
        {
            get => uxComputerFirst.Checked;
        }

        /// <summary>
        /// Property to give the level of computer to play against
        /// </summary>
        public int Level
        {
            get => (int)uxUpDown.Value;
        }
    }
}
