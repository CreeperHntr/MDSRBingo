# MDSRBingo

MDSR Bingo is a simple speedrun bingo challenge mode. It was developed under the Modern Doom Speedrunning (MDSR) umbrella of tools for speedrunning.

MDSR Bingo currently has official support for Doom 2016 and Doom Eternal with and without DLC. Official VFR support will be coming in the future.
If you wish to play custom bingo boards, please read the "Custom Bingo Boards" section below.

## ***How to Play:***
Run MDSRBingo.exe, select your game from the dropdown menu, and click generate. If you wish to use a seed, type the seed in the seed field before clicking generate. Please note, seeds may only be integer values.

## ***User Settings:***
If you wish to change the color of the board, clicked tiles, and font, you may do so from the settings button. If you wish to manually edit your settings, you may do so from the 'settings.json' file generated on first time launch. All three (3) fields accept RGB values. If 'settings.json' becomes malformed due to manual errors, you may safely delete the 'settings.json' file and re-launch MDSRBingo.exe to regenerate it with the default values.

## ***Custom Bingo Boards:***

MDSR Bingo has support for custom, user created bingo boards for any game. If you wish to use this feature, create a text file with the name of the game and add it to the 'SupportedGames' directory. Make sure there is only one (1) bingo challenge per line and that there are at least 25 challenges in total. If you have any issues adding your custom game, please verify that formatting is correct.
