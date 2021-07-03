using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MDSRBingo
{
    public partial class CreditsTab : Form
    {
        public CreditsTab()
        {
            InitializeComponent();
        }

        // MDSR Socials
        private void mdsrDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/rdAACjguxT");
        }

        private void mdsrTwitch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/ModernDOOMSpeedrunning");
        }

        private void mdsrYT_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/ModernDOOMSpeedrunning");
        }

        private void mdsrTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ModernDOOMSR");
        }

        // CreeperHntr Socials
        private void creeperTwitch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/creeperhntr");
        }

        private void creeperYT_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/creeperhntr");
        }

        private void creeperTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/CreeperHntr");
        }

        // Meta Socials
        private void metaTwitch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/meta_live");
        }

        private void metaYT_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/metaspeedruns");
        }

        private void metaTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ItsCamNotCan");
        }

        // Quarth234 Socials
        private void quarthTwitch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/quarth234");
        }

    }
}
