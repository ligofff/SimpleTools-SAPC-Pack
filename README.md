# Simple Tools SAPC Pack
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)


## About
Simple Tools SAPC Pack - A small library for Unity with several handy classes that can be conveniently serialized in the inspector.<br />
*SAPC - Serializable Actions, Providers and Conditions*

> [My Telegram channel](https://t.me/ligofff_blog) if you want more

## Overview

Writing code for games is not just coding the mechanics of specific game items, objects, or player skills.
Writing the code for a game should be like writing lots of functional Lego pieces that a game designer would later assemble into a game.

Are you programming an in-game teleporter? No need to just make an object with the "Teleport" function.<br />
Add an object that, when activated by the player, will call any function specified by the game designer.
And also, add a teleportation function that will not be tied to a teleporter, and will just move the selected object somewhere.

**Congratulations!** With much less code, you have allowed the game designer to make much more new mechanics in the game:
* The teleport you were asked to do
* Staff of teleportation that teleports the player when used
* A creature that teleports somewhere when scared
* And many more interesting teleportation mechanics

And in order to make it more convenient for you to use this approach to programming game mechanics, I wrote this small library.<br />
*(I actually wrote it while I was working on my [Delares](https://store.steampowered.com/app/1516130/Delares/) game)*

*The library uses Odin Inspector because I think it is used almost everywhere.<br />
But if this solution does not suit you, you can always write your own editor to select a function, or use other [options](https://github.com/mackysoft/Unity-SerializeReferenceExtensions).*

## Minimum Requirements
* Unity 2020 and above
* [**Odin Inspector**](https://odininspector.com/)
### Install via GIT URL

Go to ```Package Manager``` -> ```Add package from GIT url...``` -> Enter ```https://github.com/ligofff/SimpleTools-SAPC-Pack.git``` -> Click ```Add```

You will need to have Git installed and available in your system's PATH.

## Usage

In package you can find ```GameActions (Just invoke action)```, ```GameConditions (Returns true/false)``` and ```ObjectProviders (Returns objects)```. All of them are implemented in similar steps, so for example, we will consider the usage of GameAction.

**1) For use GameActions you need to make non-generic class of your context object type, since the Unity does not support the serialization of generics using [SerializeReference]**

For working with GameObjects you can make this:
```
public abstract class GameObject_GameActionBase : GameActionBase<GameObject> {}
```
**2) Then inherit from this class any actions that you want to serialize in the inspector**

Don't forget to mark the class as [Serializable]
```
[Serializable]
public class MoveGameobject_GameAction : GameObject_GameActionBase
{
    [SerializeField]
    private Vector3 moveFor = Vector3.zero;
    
    protected override void InvokeInternal(GameObject contextObject)
    {
        contextObject.transform.position += moveFor;
    }
}
```
This action just moves given GameObject on invoke.

**3) Introduce ```GameObject_GameActionBase``` field where you need and mark it as ```[SerializeReference]```**

```
[SerializeReference]
private GameObject_GameActionBase _action;

```

**4) And that is all!**

Now in inspector you can assign to this field any action what you need.

And from code you can do ```_action.Invoke(any gameobject);``` for invoke your action!

![image](https://user-images.githubusercontent.com/44195161/227803753-b433f7fc-9a1c-4653-800e-5b9d1762ce52.png)

*Also you can import package samples and see more usage examples*

## License

MIT License

Copyright (c) 2022 Ligofff

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
