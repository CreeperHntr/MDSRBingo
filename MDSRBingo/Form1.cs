using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSRBingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Label space in this.bingoBoard.Controls)
            {
                space.MouseClick += new MouseEventHandler(ClickOnCell);
            }
        }

        public void ClickOnCell(object sender, MouseEventArgs e)
        {
            if(!(bingoBoard.GetRow((Label) sender) == 2 && bingoBoard.GetColumn((Label) sender) == 2))
            {
                Label label = (Label) sender;
                label.BackColor = label.BackColor == displayColor.BackColor ? Color.Transparent : displayColor.BackColor;
            }
            
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = displayColor.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                displayColor.BackColor = MyDialog.Color;
        }
    }

}
