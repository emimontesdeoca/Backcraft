<h1 align="center">Backcraft</h1>

<p align="center"><img src="http://i.imgur.com/nWswd3B.png" width="200px" height="200px" ></p>

<p align="center">
    <a href="https://travis-ci.com/emimontesdeoca/backcraft">
        <img src="https://travis-ci.com/emimontesdeoca/backcraft.svg?token=5YhKmMD39Y1MraUZWAap&branch=master"
             alt="build status">
    </a>
    <a href="https://github.com/emimontesdeoca/backcraft/releases">
        <img src="https://img.shields.io/badge/version-1.0-green.svg"
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

## Getting Started

Backcraft is a desktop app backup tool for Windows, designed 
to help you make backups of your Minecraft folder, which includes in-game configuration files, launcher options, worlds, screenshots, resource packs and more.

Archives are copied, compressed and labeled easily for you to restore them if there were a problem with your files, plus there is a log file where you can see what and when is the backup being done.

The configuration is very simple, select what you want to backup, the interval between backups, proceed to save and voila!

## Getting Started
### Prerequisites

In order to use this software you will need this two applications installed in your machine:

- .NET Framework 4.5.2
- 7zip (installed in its default path).
- Machine with administrators rights.

### Configuration files

After the first lunch, 2 folders with files will be created:

- data => configuration files
  - bsettings.txt => text file containing backcraft settings.
  - msettings.txt => text file containing Minecraft settings.
  - logs.txt => where logs are saved.
- backups => where backups are saved.
  - Backcraft_13-07-2017_20-32-44.7z (example)
  - Backcraft_13-07-2017_20-52-47.7z (example)

### Configuration

When open, there will be a few things to configure:

- Folder path to Minecraft folder.
- Checkboxes to select what you want to backup with a bit of explanation
- Enable the backup system.
- Enable the logs.
- Interval between backups.

Remember to save every step (saved in data/msettings.txt and data/bsettings.txt).

### Working

As the application opens, it will automatically read the settings that you putt before, and if Minecraft is open, it will instatly make a backup, in case it is not open it will try to look if Minecraft is open in 5 minutes, this is in case you have this application as a startup program and you are not playing. After the first backup that it will do it again depeding the interval that you selected.

Also there is a button in case you want to do an instant backup when you want. This will not affect the interval between automatic updates.

## Contributing

As a developer, if you feel like helping, any contribution is welcome.

And as user, if youy have any bug, issue, feature request or question, feel free to open a [ticket issue](https://github.com/emimontesdeoca/backcraft/issues).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
