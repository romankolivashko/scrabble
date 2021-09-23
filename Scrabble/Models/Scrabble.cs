using System.Collections.Generic;

namespace Scrabble
{
  public class Word
  {
    private static Dictionary<char, int> _dict = new Dictionary<char, int>()
      {
        {'A', 1},
        {'B', 3},
        {'C', 3},
        {'D', 2},
        {'E', 1},
        {'F', 4},
        {'G', 2},
        {'H', 4},
        {'I', 1},
        {'J', 8},
        {'K', 5},
        {'L', 1},
        {'M', 3},
        {'N', 1},
        {'O', 1},
        {'P', 3},
        {'Q', 10},
        {'R', 1},
        {'S', 1},
        {'T', 1},
        {'U', 1},
        {'V', 4},
        {'W', 4},
        {'X', 8},
        {'Y', 4},
        {'Z', 10},
    }; 

    public string Letters {get;}
    //constructor
    public Word(string letters)
    {
      //letters: "aaa"
      Letters = letters.ToUpper();
      //Letters = "AAA" (string)
      //Letters[0] = 'A' (char)
    }
    //business method to return score
    public int GetScore()
    {
      //dictionary: creating, adding, where to keep it, how to access it

      //JavaScript!! Letters.forEach((letter, i) => {console.log(letter)})
      
      //Letters (our string)
      int sum = 0;
      foreach(char letter in Letters) 
      //in foreach, letter is same as Letters[i] in a standard for loop
        {
          sum += Word._dict[letter];
        }
      return sum;

    //instance method: newWord.getScore();
    //static method: Word.getScore("hi");
    
    }
  }
}