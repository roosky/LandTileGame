using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Land
    {
        private int owner;
        private int strength;
        private List<Land> neighbors;

        private void addStrength(int amount)
        {
            strength = strength + amount;
        }

        private void setOwner(string ownerName)
        {
            if (ownerName == "Player")
            {
                owner = 1;
            }
        }

        private void setLandLocation(Button tile, string name, Player player)
        {
            tile.Text = name;
            
        }
    }
}
