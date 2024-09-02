# Jimm's Localization System
### (For the Unity Game Engine)
Hey there! This is my simple localization system. It works with txt files and it stores the selected language to PlayerPrefs.

Here's how it looks in unity:
![LocalizationExample](https://github.com/user-attachments/assets/22da294b-cf2f-4673-b50e-9253e641d0fd)

And here's a simple guide to correctly setting up the localization:
```
Language: English

KEY_1
Insert description here.

KEY_2
Insert yet another description here.
```
As you can see, each key corresponds to the text below it.

- You can name the keys anything you want. _(Make sure that the keys are the same in all your txt files!)_

- The first two lines shouldn't be changed. You can only change the language name.

- Each txt file corresponds to a different language.

You can even add more than 1 empty line between you key-value pairs to increase readability!
Like this:
```
Language: English

KEY_1
Insert description here.





KEY_2
A very spacious description
```
To demonstrate the localization, I've made a script called 'TMPLocalizer', which takes a TMP_Text reference and a key string. You can see it in the project itself.
