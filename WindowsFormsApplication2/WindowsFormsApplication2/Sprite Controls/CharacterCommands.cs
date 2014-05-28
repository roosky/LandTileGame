using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class CharacterCommands
    {
        public static void moveSprite(Keys K,PictureBox spriteToMove)
        {   

            if (spriteToMove.Location.Y < 500 && spriteToMove.Location.Y > 0)
            {
                if (K == Keys.W)
                {
                    spriteToMove.Location = new Point(spriteToMove.Location.X, spriteToMove.Location.Y - 50);
                }
                else if (K == Keys.S)
                {
                    spriteToMove.Location = new Point(spriteToMove.Location.X, spriteToMove.Location.Y + 50);
                }
            }
            if (spriteToMove.Location.Y == 0)
            {
                spriteToMove.Location = new Point(spriteToMove.Location.X,400);
            }
            
        }
    }
}
