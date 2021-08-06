using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MDSRBingo
{
    public partial class SettingsTab : Form
    {

        public SettingsTab()
        {
            InitializeComponent();
        }

        
        private void SettingsTab_Load(object sender, EventArgs e)
        {
            // init for pulling settings from settings.json
            PopulateSettings();
        }

        // populates the current settings with the settings saved in settings.json
        private void PopulateSettings()
        {
            string jsonPath = Directory.GetCurrentDirectory() + "\\settings.json";
            string json = File.ReadAllText(jsonPath);
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            //MessageBox.Show(json);

            tileDisplayColor.BackColor = settings.tileColor;
            boardDisplayColor.BackColor = settings.boardColor;
            fontDisplayColor.BackColor = settings.fontColor;
        }

        private void tileColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            //MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = tileDisplayColor.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                tileDisplayColor.BackColor = MyDialog.Color;
        }

        private void boardColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            //MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = boardDisplayColor.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                boardDisplayColor.BackColor = MyDialog.Color;
        }

        private void fontColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            //MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = fontDisplayColor.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                fontDisplayColor.BackColor = MyDialog.Color;
        }

        // resets settings to default
        private void resetSettings_Click(object sender, EventArgs e)
        {
            var settings = Settings.Default();
            string path = Directory.GetCurrentDirectory() + "\\settings.json";
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(path, json);

            ApplyNewSettings(settings);

            tileDisplayColor.BackColor = settings.tileColor;
            boardDisplayColor.BackColor = settings.boardColor;
            fontDisplayColor.BackColor = settings.fontColor;

            MessageBox.Show("Settings have been reverted to default!");

            //TODO: deserialize json to update settings window after resetting
        }

        private void applySettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings { 
                tileColor = tileDisplayColor.BackColor,
                boardColor = boardDisplayColor.BackColor,
                fontColor = fontDisplayColor.BackColor
            };
            string path = Directory.GetCurrentDirectory() + "\\settings.json";
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(path, json);

            ApplyNewSettings(settings);

            MessageBox.Show("Settings have been updated!");
        }

        private void ApplyNewSettings(Settings settings)
        {
            List<Label> bingoCells = Form1.GetBingoCells();

            foreach (Label cell in bingoCells)
            {
                cell.ForeColor = settings.fontColor;
                if (cell.BackColor != settings.boardColor) { cell.BackColor = settings.boardColor; }
            }
        }
    }
}
