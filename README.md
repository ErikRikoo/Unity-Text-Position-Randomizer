# Text Position Randomizer - Unity
_A utility script to randomize character position in Text Mesh Pro_

## Motivation
THis is a utility script needed for a [game](https://www.deadsigns.fr/) I work on with a team.
We need some hand-written font so to add more variety and authenticity I wrote that asset.
## Installation
To install this package you can do one of this:
- Using Package Manager Window
    - Opening the Package Manager Window: Window > Package Manager
    - Wait for it to load
    - Click on the top left button `+` > Add package from git URL
    - Copy paste the [repository link](https://github.com/ErikRikoo/Unity-Text-Position-Randomizer.git)
    - Press enter

- Modifying manifest.json file
Add the following to your `manifest.json` file (which is under your project location in `Packages` folder)
```json
{
  "dependancies": {
    ...
    "com.rikoo.text-position-randomizer": "https://github.com/ErikRikoo/Unity-Text-Position-Randomizer.git",
    ...
  }
}
```

You can now use it and don't want to kill your designer/artist anymore. 

## Updating
Sometimes Unity has some hard time updating git dependencies so when you want to update the package, 
follow this steps:
- Go into `package-lock.json` file (same place that `manifest.json` one)
- It should look like this:
```json
{
  "dependencies": {
    ...
    "com.rikoo.text-position-randomizer": {
      "version": "https://github.com/ErikRikoo/Unity-Text-Position-Randomizer.git",
      "depth": 0,
      "source": "git",
      "dependencies": {},
      "hash": "hash-number-there"
    },
    ...
}
```
- Remove the _"com.rikoo.text-position-randomizer"_ and save the file
- Get back to Unity
- Let him refresh
- Package should be updated

## How does it work
To be able to use it, you just need to add the _TextPositionRandomizer_ script to a UI element which has a TextMeshPro
script on it.
It will then bind to it and you can change the parameters of the script:
- Cached Text is the text that will be displayed by the UI Element, it is initially filled with
the TMPro content
- Horizontal Range: You can tweak the min and max for the horizontal axis, the random horizontal offset will
be between min and max
- Vertical Range: Same but for the vertical range


## TODO
Nothing yet, but fell free to suggest !

## Suggestions
Feel free to suggest features by creating an issue, any idea is welcome !
