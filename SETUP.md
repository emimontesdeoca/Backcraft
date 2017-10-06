<h1 align="center">Backcraft</h1>

<p align="center"><img src="http://i.imgur.com/nWswd3B.png" width="200px" height="200px" ></p>

<p align="center">
:open_file_folder: A backup tool for Minecraft players.
</p>

## Installation and usage 

### Prerequisites

In order to use this software you will need this two applications installed in your machine:

- [.NET Framework 4.5.2](https://www.microsoft.com/en-us/download/details.aspx?id=42642).
- [7zip](http://www.7-zip.org/download.html).
- [Minecraft](https://minecraft.net/es-es/).

### Get the latest release

Go to releases and get Backcraft's latest version. It's better for Backcraft and the user to place it in a separated folder, for example in the Desktop.

<p align="center"><img src="https://i.imgur.com/98LtZZn.png" ></p>
    
### First launch

For first launch, Backcraft will not load any settings and the default flow will start, it will create 2 folders:
- backups
- settings

<p align="center"><img src="https://i.imgur.com/2drQYvD.png" ></p>

## Set settings

Now that everything is up, Backcraft should be open and waiting for the settings to change, there are 2 kind of settings: Minecraft's settings like folder path, worlds saves, etc, and Backcraft's settings like logs, interval, etc.

### Minecraft settings

#### Miencraft's folder path
First of all the most important step after checking the Enable, is to save the Minecraft path, if Minecraf it's installed in the default path it will be autodetected but not saved, so you HAVE to save it.

<p align="center"><img src="https://i.imgur.com/oB1YOP5.png" ></p>

<b>Remember to click on the disk button to save!</b> If you don't save, you won't be able to make further steps!

#### Resource packs

Check the Resource packs checkbox and proceed to push the button to select which resource pack you want to backup:

<p align="center"><img src="https://i.imgur.com/hxTwj8T.png" ></p>

Then check which resource pack you want to save and close it. <b> If you reopen it without save it will not save!</b>

#### Worlds

Check the Worlds checkbox and proceed to push the button to select which worlds you want to backup:

<p align="center"><img src="https://i.imgur.com/hxTwj8T.png" ></p>

Then check which world you want to save and close it. <b> If you reopen it without save it will not save!</b>

#### Launcher profiles, options and screenshots

Check if you want to save the launcher profiles, options and screenshots:

<p align="center"><img src="https://i.imgur.com/PmdKmpG.png" ></p>

Then check which world you want to save and close it. <b> If you reopen it without save it will not save!</b>

### Backcraft settings

#### Logs

If you want to save logs, just check the Logs checkbox. 

<b>I strongly recomend you to save the logs, it's not only important for you to know what Backcraft is doing, but if you want to report  a bug, it would be good to the logs to check what is going on.</b>

#### Run at startup

Check if you want Backcraft to start when the session opens.

#### 7Zip

This is necessary for the backups to be done, if you have 7-zip already installed, it will autodetect it and place it on the textbox.

<p align="center"><img src="https://i.imgur.com/JF43QsR.png" ></p>

#### Backups

This is also necessary for the backups to be done, destination paths are needed for the final copy. Just push the settings button for the backups and search a folder where you want to save the backups, then push on the save and done.

<b>This won't be saved until you make the final save settings!</b>

<p align="center"><img src="https://i.imgur.com/FB6EjUM.png" ></p>

#### Backup interval

Time between backups, just scroll it to the interval you want.

#### Auto-Updater

Check the auto-updater to get notified when there are new releases. Backcraft will download it and reset to the new version with the same configuration files.

#### Finish

In the end, it should look like this, but this is not over since we still have to save everything!

<p align="center"><img src="https://i.imgur.com/HzUpfFs.png" ></p>

## Save settings and check files

Click on Save settings, this will save everything and create a few files, and the restart Backcraft.

### Files created

The files created are: 

```
Backcraft
│   Backcraft.exe
│   logs.txt 
│
└───backups
│   
└───config
    │   cfg.txt
    │   files.txt
    │   paths.txt
```

- logs.txt -> where logs are saved.
- config\cfg.txt -> where the settings are saved.
- config\files.txt -> where the files to backup with its MD5 is saved.
- config\paths.txt -> where the destination paths are saved.

### After restart

After this and every save, Backcraft will restart and load everything, if we didn't screw anything, settings should be loaded and everything that you check and put would be there again.

<p align="center"><img src="https://i.imgur.com/WTwqXrj.png" ></p>

### Check if everything is cool

You can check the config files by hand, but I do recommend to check the information dispplayed in Backcraft, to access it, push in the information button in the top right.

<p align="center"><img src="https://i.imgur.com/MMNZUq5.png" ></p>

#### Files

Navigate to files and you can see all the files that you wanted to backup right there, with its MD5. If you haven't backuped yet, it will not display any MD5.

<p align="center"><img src="https://i.imgur.com/0T0r6vk.png" ></p>

#### Logs

Navigate to Logs and you can see the logs.

<p align="center"><img src="https://i.imgur.com/ZEUfUn8.png" ></p>

## Done

Now you can make minimze Backcraft and start playing Minecraft or you can push Backup now and it will backup all your data instantly. This will be saved in your log and you can see that everything is saved and copied to your destination folder.

<p align="center"><img src="https://i.imgur.com/FfuT47a.png" ></p>

# Issues

If you have any issues with this documentation or a bug, feel free to open an issue in this repository, or you can let me know in my twitter @emimontesdeoca.
