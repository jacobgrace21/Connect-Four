using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connect_Four

{
    /// <summary>
    /// Public class for a player in connect 4
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gives the heuristic score of the player
        /// </summary>
        public int Score
        {
            get;
            set;
        }
        /// <summary>
        /// Gives the name, white or black, of the current player
        /// </summary>
        public String Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gives the image to be drawn for the player's piece
        /// </summary>
        public Image Picture
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor for the player object
        /// </summary>
        /// <param name="name">Name of the player to move</param>
        /// <param name="fn">File location that contains the picture of the piece to be drawn</param>
        public Player(string name, string fn)
        {
            Name = name;
            try
            {
                Picture = Image.FromFile(fn);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
