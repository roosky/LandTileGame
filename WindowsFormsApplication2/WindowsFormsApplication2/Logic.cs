using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    internal class Logic
    {
        #region Constructors and Destructors

        public Logic()
        {
            _playerTiles = new Dictionary<string, int>();
        }

        #endregion

        #region Public Methods

        public static void PlayerScore()
        {
        }

        #endregion

        #region Methods

        private void addOrUpdateTile(Dictionary<string, int> dict, string key, int value)
        {
            if (dict.ContainsKey(key))
            {
                value = value + 1;
            }
            else
            {
                dict.Add(key, value);
            }
        }

        #endregion

        #region Fields

        private readonly Dictionary<string, int> _playerTiles;

        #endregion
    }
}