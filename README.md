## Word Counter
###author William Kinzig

_June 29th, 2018_

_This program checks how frequently a word appears in a given string._

#### OBJECTIVE

_OBJECTIVE: _Count instances of char that are in object.string
Your mission is to create a program that checks how frequently a word appears in a given string._

#### Setup/Installation Requirements

_None_

#### Known Bugs

_No known bugs._

#### Support and contact details

_William Kinzig email: billykinzig@gmail.com_

#### Technologies Used

_Created with Atom editor.  Use any browser to view._

#### License

_*No license required*_

_Copyright (c) 2018 **_William Kinzig**_

#### NAMING CONVENTIONS

_Solution Name: WordCounter.Solution_
_Project Name: WordCounter_
_Test Project Name: WordCounter.Tests_

#### ASSIGNMENT INSTRUCTIONS

_Create a class called RepeatCounter. This class should contain logic for counting how many times a word appears in a string of words_

_Do not use regular expressions in your logic._
_Use lists Array Char String methods_

_For test use multiple methods:_
_-one method to test whether the user's input is valid_
_-another for actually searching the string of words._

#### SPECS

-get word to count
Behavior		                 Input  Output
private string getting set  /    "cat"/"cat"


-get paragraph to check
Behavior		                 Input        Output
private string getting set  /    "cat is fat"/"cat is fat"


-put paragraph into an array
Behavior		                           Input          Output
Split _string sentence into an array  / "cat is orange"/array[1] == "is"


-count occurrences of given string in array
    -create loop to go through the array
    -create an int counter
    -increment counter by one every time for every occurrence of the word
    -return final counter result to user
Behavior		                                   Input  Output
String[] blah = new String[] {"cat", "is", "cat"}/ "cat" /  2
