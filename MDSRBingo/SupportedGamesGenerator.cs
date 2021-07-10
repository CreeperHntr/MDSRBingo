using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MDSRBingo
{
    // Generator for offically supported games and their challenge lists
    class SupportedGamesGenerator
    {
        // Default filenames
        private static string d2016Filename = "Doom 2016.txt";
        private static string deNoDLCFilename = "Doom Eternal (No DLC).txt";
        private static string deWithDLCFilename = "Doom Eternal (With DLC).txt";

        // Doom 2016 challenges
        private static string[] d2016 =
        {
            "Collect all Doom figures",
            "Collect all ? Secrets in any level",
            "Collect all ? Secrets in 3 levels",
            "Collect all Elite Guards in any level",
            "Collect all Field Drones in any level",
            "Kill any boss",
            "Complete all Combat Rating in any level",
            "Complete any Rune Trial",
            "Complete all Rune Trials",
            "Complete all Rune Trials in any level",
            "Master any Rune",
            "Master any 3 Runes",
            "Fully master any weapon mod on any weapon",
            "Fully master both weapon mods on any weapon",
            "Fully upgrade Health",
            "Fully upgrade Armor",
            "Fully upgrade Ammo",
            "Fully upgrade any Praetor Suit Mod",
            "Fully upgrade the Charged Energy Shot on the Pistol",
            "Unlock any Classic Level",
            "Unlock all Classic Levels",
            "Complete any Classic Level",
            "Complete any 3 Classic Levels",
            "Chainsaw an Imp",
            "Chainsaw a Summoner",
            "Interact with any Powerup",
            "Interact with a Berserk",
            "Interact with a Quad Damage",
            "Interate with a Haste",
            "Interact with an Invulnerability",
            "Collect any interactable Codex",
            "Complete any level in Arcade Mode",
            "Complete 3 levels in Arcade Mode",
            "Die on UN",
            "Fistbump any Doom figure",
            "Kill the Cyber Demon",
            "Kill the Spider Mastermind",
            "Complete any level without the HUD",
            "Master Lock-On Burst on the Rocket Launcher",
            "Stagger the same demon 3 times",
            "Kill a Mancubus using only the Pistol",
            "Have a Lost Soul fly into you",
            "BFG any Mancubus or Cyber Mancubus",
            "Collect all Argent Cells",
            "Complete all challenges in a single level",
            "Complete all challenges in 5 levels"

        };

        // DE Base game specific challenges
        private static string[] deNoDLC =
        {
            "Die in UN",
            "Explode a barrel",
            "Full clear a honeycomb in any level",
            "Complete 1 level challenge",
            "Complete 3 level challenges in a single level",
            "Complete the Ripatorium for the first time",
            "Chainsaw an Imp",
            "Chainsaw a Mancubus",
            "Chainsaw a Cyber Mancubus",
            "Chainsaw any super heavy demon",
            "Use a Mastery Token",
            "Fully master any weapon mod",
            "Crucible any fodder demon",
            "Die from a barrel explosion",
            "Complete 1 secret encounter in any level",
            "Complete both secret encounters in any level",
            "Kill any fodder with the Unmaykr",
            "Kill a Mancubus with the Unmaykr",
            "Kill an Archville with the Unmaykr",
            "Collect all codicies in any level",
            "Blood Punch a Zombie",
            "Blood Punch an Imp",
            "Blood Punch any heavy demon",
            "Kill any boss",
            "Glory Kill an Archville",
            "Glory Kill a Marauder",
            "Glory Kill an Arachnotron",
            "Glory Kill a Baron of Hell",
            "Destroy any Buff Totem",
            "Glory Kill a Cacodemon",
            "Glory Kill a Cyber Mancubus",
            "Glory Kill a Pinky",
            "Kill any non-boss Doom Hunter",
            "Glory Kill a Gargoyle",
            "Glory Kill a Hell Knight",
            "Glory Kill a Mancubus",
            "Glory Kill a Pain Elemental",
            "Glory Kill a Spectre",
            "Glory Kill a Whiplash",
            "Complete any Slayer Gate",
            "Complete all 6 Slayer Gates",
            "Crucible a Zombie",
            "Crucible the Icon of Sin",
            "Complete a Ripatorium re-visit",
            "Collect any Cheat Code in any level",
            "Collect all Cheat Codes in the game",
            "Replay any level with any Cheat Code active",
            "Find any Dopefish in any level",
            "Complete any Master Level",
            "Collect any Rune",
            "Collect all Runes (Base Game Only)",
            "Collect 1 Praetor Suit token",
            "Collect all Praetor Suit tokens in any level",
            "Full clear Demonic Corruption in any level",
            "Collect all toys in any level",
            "Collect all music discs in any level",
            "Complete the secret Tyrant encounter in SGN",
            "Kill the Icon of Sin",
            "Stagger the same demon 3 times"
        };

        // TAG1 and TAG2 specific challenges
        private static string[] deDLC =
        {
            "Kill a Cursed Prowler after getting cursed",
            "Activate a Screecher",
            "Complete the 5 Marauder easter egg in World Spear",
            "Collect any Support Rune",
            "Complete any Wave 2 of any Escalation Encounter",
            "Have any fodder demon get possessed"
        };

        public static void GenerateDefaults()
        {
            if(!(Directory.Exists(Directory.GetCurrentDirectory() + "\\Supported Games")))
            {
                try
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Supported Games");

                    // Writes the default Doom 2016 Challenges
                    File.WriteAllLines(Directory.GetCurrentDirectory() + "\\Supported Games\\" + d2016Filename, d2016);

                    // Writes the default Doom Eternal without DLC challenges
                    File.WriteAllLines(Directory.GetCurrentDirectory() + "\\Supported Games\\" + deNoDLCFilename, deNoDLC);

                    // Writes the default Doom Eternal with DLC challenges
                    List<string> temp = new List<string>();
                    foreach(string line in deNoDLC) { temp.Add(line); }
                    foreach(string line in deDLC) { temp.Add(line); }
                    File.WriteAllLines(Directory.GetCurrentDirectory() + "\\Supported Games\\" + deWithDLCFilename, temp);
                }
                catch(IOException e)
                {
                    MessageBox.Show("There was an issue with generating the defaults.");
                }
            }
        }

    }
}
