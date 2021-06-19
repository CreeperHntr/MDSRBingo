using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDSRBingo
{
    public partial class Form1 : Form
    {
        // list of files from the SupportedGames folder
        private string[] files;

        // array of the bingo board's Labels
        List<Label> bingoCells = new List<Label>();

        private int seed;

        public Form1()
        {
            InitializeComponent();
        }

        // when form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Label cell in this.bingoBoard.Controls)
            {
                cell.MouseClick += new MouseEventHandler(ClickOnCell);
                if (!(bingoBoard.GetRow(cell) == 2 && bingoBoard.GetColumn(cell) == 2))
                {
                    cell.Text = "";
                    bingoCells.Add(cell);
                }
            }

            // pulls supported games list and populates the game selector
            string path = Directory.GetCurrentDirectory() + "\\SupportedGames";
            files = Directory.GetFiles(path);
            foreach(string file in files) {
                string currentFile = Path.GetFileName(file);
                string[] split = currentFile.Split('.');
                gameSelector.Items.Add(split[0]);
            }
            gameSelector.SelectedIndex = 0;

        }

        // when user clicks on a bingo cell, update the color to match chosen color and turn transparent if misclicked
        public void ClickOnCell(object sender, MouseEventArgs e)
        {
            if(!(bingoBoard.GetRow((Label) sender) == 2 && bingoBoard.GetColumn((Label) sender) == 2))
            {
                Label label = (Label) sender;
                label.BackColor = label.BackColor == displayColor.BackColor ? Color.Transparent : displayColor.BackColor;
            }
            
        }

        // allows user to set bingo board color
        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = displayColor.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                displayColor.BackColor = MyDialog.Color;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if(!(inputSeedTB.Text == ""))
            {
                try
                {
                    int seed = Int32.Parse(inputSeedTB.Text);
                    GenerateBoard(seed);
                }
                catch(Exception f)
                {
                    MessageBox.Show("Invalid seed format");
                }
            }
            else
            {
                GenerateBoard();
            }
            inputSeedTB.Text = "";
        }

        // generates a bingo board with a random seed
        private void GenerateBoard()
        {
            string currentFile = null;
            foreach(string file in files)
            {
                if(file.Contains(gameSelector.Text))
                {
                    currentFile = file;
                }
            }

            // array of all challenges in the given file
            string[] text = File.ReadAllLines(currentFile);

            // checks to ensure chosen game has enough challenges to prevent the client from crashing
            if(text.Length < 24)
            {
                MessageBox.Show("There are not enough challenges in your currently selected game." +
                    "\nA minimum of 24 challenges is required.");
                return;
            }

            // theres probably a better way to do this
            Random genSeed = new Random();
            seed = genSeed.Next();

            Random rand = new Random(seed);

            currentSeed.Text = seed.ToString();

            List<string> currentChallenges = new List<string>();

            try
            {
                foreach (Label cell in bingoCells)
                {
                    string challenge = text[rand.Next(0, text.Length)];
                    while(currentChallenges.Contains(challenge))
                    {
                        challenge = text[rand.Next(0, text.Length)];
                    }
                    currentChallenges.Add(challenge);
                    cell.Text = challenge;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Your selected game does not have any challenges in its game file." +
                    "\n\nIf this is an officially supported game, please ensure all of the default challenges are in the games' challenges list." +
                    "\n\nIf this is a custom game, please ensure you saved your file when added.");
            }
        }

        // generates a bingo board with a fixed seed chosen by user
        private void GenerateBoard(int seed)
        {
            string currentFile = null;
            foreach (string file in files)
            {
                if (file.Contains(gameSelector.Text))
                {
                    currentFile = file;
                }
            }

            // array of all challenges in the given file
            string[] text = File.ReadAllLines(currentFile);

            // checks to ensure chosen game has enough challenges to prevent the client from crashing
            if (text.Length < 24)
            {
                MessageBox.Show("There are not enough challenges in your currently selected game." +
                    "\nA minimum of 24 challenges is required.");
                return;
            }

            Random rand = new Random(seed);

            currentSeed.Text = seed.ToString();

            List<string> currentChallenges = new List<string>();

            try
            {
                foreach (Label cell in bingoCells)
                {
                    string challenge = text[rand.Next(0, text.Length)];
                    while (currentChallenges.Contains(challenge))
                    {
                        challenge = text[rand.Next(0, text.Length)];
                    }
                    currentChallenges.Add(challenge);
                    cell.Text = challenge;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your selected game does not have any challenges in its game file." +
                    "\n\nIf this is an officially supported game, please ensure all of the default challenges are in the games' challenges list." +
                    "\n\nIf this is a custom game, please ensure you saved your file when added.");
            }
        }
    }

}
