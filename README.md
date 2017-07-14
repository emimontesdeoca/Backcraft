<h1 align="center">Backcraft</h1>

<p align="center"><img src="http://i.imgur.com/nWswd3B.png" width="200px" height="200px" ></p>

<p align="center">
    <a href="https://travis-ci.com/emimontesdeoca/backcraft">
        <img src="https://travis-ci.com/emimontesdeoca/backcraft.svg?token=5YhKmMD39Y1MraUZWAap&branch=master"
             alt="build status">
    </a>
    <a href="https://github.com/emimontesdeoca/backcraft/releases">
        <img src="https://img.shields.io/badge/version-2.0-green.svg"
             alt="build status">
    </a>
    <a href="https://github.com/emimontesdeoca/backcraft/releases">
        <img src="https://img.shields.io/badge/Platform-Windows-blue.svg"
             alt="build status">
    </a>
    <a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UBYQDM59B3GCC">
        <img src="https://img.shields.io/badge/Donate-PayPal-green.svg"
             alt="Donate a coffee!">
    </a>
    <a href="LICENSE">
        <img src="https://img.shields.io/github/license/mashape/apistatus.svg"
             alt="Donate a coffee!">
    </a>
</p>

<p align="center">
:open_file_folder: A backup tool for Minecraft players.
</p>

<p align="center">
:computer: <strong>For releases click <a href="https://github.com/emimontesdeoca/Backcraft/releases">here</a>.</strong>
</p>

## About Backcraft

Backcraft is a desktop app backup tool for Windows, designed 
to help you make backups of your Minecraft folder, which includes in-game configuration files, launcher options, worlds, screenshots, resource packs and more.

Archives are copied, compressed and labeled easily for you to restore them if there were a problem with your files, plus there is a log file where you can see what, where and when the backup was made.

The configuration is very simple, select what you want to backup, the interval between backups, proceed to save and voila! Plus there if you set Backcraft to run at startup, it will open and hide in the system tray.

## Getting Started
### Prerequisites

In order to use this software you will need this two applications installed in your machine:

- [.NET Framework 4.5.2](https://www.microsoft.com/en-us/download/details.aspx?id=42642)
- [7zip](http://www.7-zip.org/download.html)
- Windows with administrators rights.

### Configuration files

After the first lunch, 2 folders with files will be created:

- data => configuration files
  - bsettings.txt => text file containing backcraft settings.
  - msettings.txt => text file containing Minecraft settings.
  - logs.txt => where logs are saved if enabled.
- backups => where backups are saved.
  - Backcraft_13-07-2017_20-32-44.7z (example)
  - Backcraft_13-07-2017_20-52-47.7z (example)

### Configuration

<img src="http://i.imgur.com/ZLv6HtS.png" align="right">

When open for the first time, there will be a few things to configure:

- Minecraft configuration
    - Folder path to Minecraft folder, if you didn't change anything, you can select "Default path".
    - A few checkboxes to select what do you want to backup from the Minecraft folder.
- Backcraft configuration
    - Checkbox to enable the backup system.
    - Checkbox to enable the logs, it will save logs for every backup.
    - Checkbox to enable Backcraft to run at startup.
    - Folder path to 7zip program, if you didn't change anything, you can select "Default path".
    - Folder path for the Backups, you can select any folder where you want to save the backups, if "Default path" is selected, they will be stored in "backups", located in the same folder as Backcraft.exe.
    - Interval for the time between backups.

<strong>Remember to save, the application will restart itself and will start minimized in the system tray.</strong>

Also there is a button if you want to make an instant backup, this action will not cancel the interval between automatic updated.

## How does it work

### Main flow
After the configuration is done, Backcraft will restart and load everything. After that it will look for Minecraft process <strong>("javaw.exe")</strong>:

- If it is opened, it will do a backup and will keep doing them depending on the interval that the user configured. 
- If it is not opened, it will look for it again every 5 minutes.

That is the main cycle of the application.

### Backups

<img src="http://i.imgur.com/SbT7MFl.png" align="right">
How the backups method works is:

- Copy all the folders that the user configured to the folder backups, which is located in the same folder that the backcraft.exe.
- Compress it with 7zip and move it to the destination folder.
- Delete the backup folder

Pretty simple, since all the hard work is being done by cmd commands, check [compression.cs](https://github.com/emimontesdeoca/Backcraft/blob/master/src/bs/compression.cs) for more details.

## Contributing

As a developer, if you feel like helping, any contribution is welcome.

And as user, if youy have any bug, issue, feature request or question, feel free to open a [ticket issue](https://github.com/emimontesdeoca/backcraft/issues).



## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
