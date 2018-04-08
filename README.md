# ScribeBot
![](https://i.imgur.com/nPWbUCM.png) 

ScribeBot is a scriptable automation system.

With a little knowledge of Lua, you can automate mundane tasks, create macros or even create a second bot.

![https://i.imgur.com/BMsHIQR.png](https://i.imgur.com/BMsHIQR.png)

## The Key Features
- Lua interpreter hooked to numerous APIs, interfaces and libraries that allow you to create robust automation systems.
- A decent (it's not that good) interface.
- Packaging system that creates and reads ScribeBot Package Files (.sbpack) which contain all the neccessary stuff related to a script (such as name, description, author etc).
- Workshop that allows you to download and run community-made packages with just one click.
- Built-in logging system.

## Planned Features
- Re-enable workshop (once I host it on my website, because github api calls have a limited rate).
- Incorporate Selenium to allow creation of web-based automations.
- Built-in manual that enlists all types, classes and methods exposed to lua environment.
- Gamepad support.
- Autoupdater.
- Ability to construct GUIs using Lua (besides input.showPrompt function that is already in)
- Simple Hotkey binding for macros.
- Package creator/editor.

## Important Notice
This program uses unmanaged code (see: https://msdn.microsoft.com/en-us/library/ms973872.aspx#manunman_topic6) and provides low-level functionality that if used improperly (intentionally or not) could affect system's security and reliability. 

**Only download scripts from trusted sources and check the code before you run it.**

## Usage
- Run ScribeBot.exe.
- Select from a list of packages (stored in /Data/Package).
- Check (or don't) the 'Asynchronous' option.
- Hit 'Run'.

## Writting for ScribeBot
There temporarily is no package editor, to create one follow steps below:
- Copy the "Test Package.sbpack" located in Data\Packages.
- Paste it into the same directory and rename to whatever you want it to be named.
- Open it with ZIP (ZIP2, ZIP7 or WinRar).
- Edit info.json and change "EntryPoint" to whatever you want your lua file to be called.
- Rename the lua file to the same thing.
- Open Lua file and start writting your script!

## Known bugs/odd behaviour
- If you don't check the 'Asynchronous' option, the script will run on the same thread as the interface - rendering it unusable until the script is done.
- If you check the 'Asynchronous' option, syntax errors might not be properly passed to the console (which isn't big of a deal, just get yourself a proper editor with a linter).

