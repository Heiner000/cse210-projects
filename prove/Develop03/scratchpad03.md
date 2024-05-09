# Scripture Memorizer


## Review Program Specification

1. What does the program do?
- The program allows a user to select a scripture passage and when prompted, hide random words to assist in memorization. The program will hide more and more words until the passage is completely obscured.

2. What user inputs does it have?
- User inputs include blank input + enter key, & "quit" + enter key.
- The user will also input the scripture passage & scripture input.
- 

3. What output does it produce?
- The program will output the reference & passage w/ more and more words from the passage hidden as they progress.

4. How does the program end?
- The program ends when the user enters "quit" + enter button.
- Also when the passage has all words hidden + enter button.


## Step 1: Determine the classes

1. What are good candidates for classes in this program?
- some good candidates are Reference, Passage, and Word(s?).

2. What are the primary responsibilities of each class?
- Reference : Holds the scripture reference including book, chapter, and verse info.
- Scripture : Holds the reference & text of the scripture passage with all of the words; can also hide words & get the rendered display of the text.
- Words : Each word in the passage with a visible/hidden attribute

### Evaluate Design
- What would be the drawbacks of creating a **Hider** class instead of leaving that with Scripture and Word classes?
    - That reduces the encapsulation by showing some of the internal function of the program.
    - It also adds the dependency and increases the complexity and repetitiveness of the program. Now if we were to change something about either the Scripture or Word class, we'd likely have to update the Hider class as well.


## Step 2: Define class behaviors

1. For each class: What are the behaviors this class will have in order to fulfill its responsibilities? (what things should this class do?)
- Reference: get display text for reference
- Scripture: randomly hide words... get display text, check completely hidden status
- Words: hide/show word, check if word is hidden, get display text (either hidden or normal chars)

- Scripture
    - HideRandomWords( numberToHide : int ) : void
    - GetDisplayText() : string
    - IsCompletelyHidden() : bool
- Word
    - Hide() : void
    - Show() : void
    - IsHidden() : bool
    - GetDisplayText() : string
- Reference
    - GetDisplayText() : string
    - *possibly getters and setters*

### Evalate Design
- Scripture class's HideRandomWords method calls which other methods to work properly?
    - It would call Word's IsHidden & Hide
- What benefit does Reference class having it's own GetDisplayText method instead of having Scripture do it?
    - It's better encapsulated this way.


## Step 3: Define class attributes

1. What attributes does each class need to fulfill its behaviors? (What variables should it store?) What are these member variables data types?
    - Scripture
        - _reference : Reference
        - _words : List<Word>
    - Word
        - _text : string
        - _isHidden : bool
    - Reference
        - _book : string
        - _chapter : int
        - _verse : int
        - _endVerse : int

### Evaluate Design
- What's the benefit of Scripture contains a list of Word objects instead of just strings?
    - Using objects reduces redundancy and maintains independence. This way you can update the Word class without upsetting the Scripture's list. Also you're able to manipulate them easier since they will keep their methods and attributes as well.


## Step 4: Define constructors
1. What constructors should each class have? (what parameters should you pass in when creating an object of that type?)
    - Scripture ( Reference reference, string text )
    - Word ( string text )
    - Single Verse Reference ( string book, int chapter, int verse )
    - Multi Verse Reference ( string book, int chapter, int startVerse, int endVerse )
2. What other setup work is required?
    - Scripture : split the text into individual Word objects, add them to _words list.
    - Word : start w/ words visible by default
    - Reference : none

### Evaluate Design
- What's the benefit of passing the string of the verse text to the Scripture constructor rather than a List of Word objects?
    - It encapsulates the List of words by keeping it in the Scripture class and otherwise prevents accessibility directly.
    - Also makes it easier to update when things are encapsulated. Hides the complexity, maintains consistent experience when using the program.


## Review Design

| **Scripture** |
| --- |
| _reference : Reference |
| _words : List<Word> |
| --- |
| Scripture( Reference : Reference, text : string) |
|     |
| HideRandomWords( numberToHide : int ) : void |
| GetDisplayText() : string |
| IsCompletelyHidden() : bool |

| **Word** |
| --- |
| _text : string |
| _isHidden : bool |
| --- |
| Word( text : string ) |
|     |
| Hide() : void |
| Show() : void |
| isHidden() : bool |
| GetDisplayText() : string |

| **Reference** |
| --- |
| _book : string |
| _chapter : int |
| _verse : int |
| _endVerse : int |
| --- |
| Reference ( book : string, chapter : int, verse : int ) |
| Reference ( book : string, chapter : int, startVerse : int, endVerse : int )
|     |
| GetDisplayText() : string |

