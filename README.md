# _C# Project Setup_


#### By _**Katlin Anderson**_

## Description

_A program program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

## Setup/Installation Requirements

* _Clone from GitHub_
* _$ dotnet restore
* _$ dotnet build
* _$ dotnet run

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| The program should compare a word with another word, and add 1 to a count if they match  | "cat", "cat" (I chose to use the example word used in the prompt) | 1 |
| The program should compare whether words match, regardless of case | "cat", "Cat" (This input with test for the word regardless of capitalization) | 1 |
| The program should compare whether words match, regardless of symbols | "cat", "cat." (This input will test for the word regardless of punctuation used in the overall sentence) | 1 |
| The program should recognize plural versions of most words that follow standard plural grammar rules | "cat", "cats" (This will recognize the same word, plural or singular)| 1 |
| The program should recognize plural versions of words that end in 'y' | "puppies", "puppy" (This will recognize the same word, plural or singular)| 1 |
| The program should compare a word to each word of a sentence, and count haw many times the word appears in the sentence | "cat", "Cat, the cat, plays with toys for cats and dogs, even though she is a cat, not a dog." (This input will test out case, symbols, and similar words) | 4 |

## Known Bugs

_No known bugs_

## Technologies Used

_C#_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Katlin Anderson_**
