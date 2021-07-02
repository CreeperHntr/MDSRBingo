﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            // verifies that settings.json exists
            ValidateSettings();
            
            // gets necessary data for bingo board setup
            BingoBoardSetup();

        }

        // Known Issue: since json, if user malforms the data manually, there will be issues reading
        //              find a way to detect/ restructure if this happens
        // creates settings.json if does not exist and applies default settings
        private void ValidateSettings()
        {
            string path = Directory.GetCurrentDirectory() + "\\settings.json";

            if(File.Exists(path))
            {
                return;
            }

            // grabs default settings
            var settings = Settings.Default();

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(settings, options);
            File.WriteAllText(path, json);
        }

        // sets up the bingo board for use at runtime
        private void BingoBoardSetup()
        {
            // bingo board setup
            foreach (Label cell in this.bingoBoard.Controls)
            {
                cell.MouseClick += new MouseEventHandler(ClickOnCell);

                // this is for without a free space, see commented code below
                cell.Text = "";
                cell.BackColor = Color.Transparent;
                bingoCells.Add(cell);

                // uncomment this to readd free space (based on community reaction)
                /*if (!(bingoBoard.GetRow(cell) == 2 && bingoBoard.GetColumn(cell) == 2))
                {
                    cell.Text = "";
                    bingoCells.Add(cell);
                }*/
            }

            // pulls supported games list and populates the game selector
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\SupportedGames";
                files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string currentFile = Path.GetFileName(file);
                    string[] split = currentFile.Split('.');
                    gameSelector.Items.Add(split[0]);
                }
                gameSelector.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Could not find the SupportedGames folder in the current directory." +
                    "\n\nPlease ensure the SupportedGames folder is in the same diectory as MDSRBingo.exe.");
            }
        }

        // when user clicks on a bingo cell, update the color to match chosen color and turn transparent if misclicked
        public void ClickOnCell(object sender, MouseEventArgs e)
        {
            // this is for without a free space, see commented code below
            Label label = (Label)sender;
            label.BackColor = label.BackColor == displayColor.BackColor ? Color.Transparent : displayColor.BackColor;

            // uncomment this to readd free space (based on community reaction)
            /*if(!(bingoBoard.GetRow((Label) sender) == 2 && bingoBoard.GetColumn((Label) sender) == 2))
            {
                Label label = (Label) sender;
                label.BackColor = label.BackColor == displayColor.BackColor ? Color.Transparent : displayColor.BackColor;
            }*/

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

            foreach(Label cell in bingoCells) {
                if(!(cell.BackColor == Color.Transparent)) { cell.BackColor = displayColor.BackColor; }
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            foreach(Label cell in bingoCells) { cell.BackColor = Color.Transparent; }

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
            // make sure to change to 24 if community requests free space back
            if(text.Length < 25)
            {
                MessageBox.Show("There are not enough challenges in your currently selected game." +
                    "\nA minimum of 25 challenges is required.");
                return;
            }

            // theres probably a better way to do this
            Random genSeed = new Random();
            seed = genSeed.Next();
            
            // generates the bingo board with the pseduo-random seed
            GenerateBoard(seed);
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

        // opens the settings form for user to edit settings
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsTab settings = new SettingsTab();
            settings.ShowDialog();
        }
    }

}
