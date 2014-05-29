using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Player
    {
        public Color playerColor;
        public Player(Color color)
        {
            playerColor = color;
        }

        public Color getColor()
        {
            return playerColor;
        }
    }
}
