using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MDSRBingo
{
    public class Settings
    {
        public Color tileColor { get; set; }
        public Color boardColor { get; set; }
        public Color fontColor { get; set; }


        public static Settings Default()
        {
            var settings = new Settings
            {
                tileColor = Color.Red,
                boardColor = Color.White,
                fontColor = Color.Black
            };

            return settings;
        }
    }
}
