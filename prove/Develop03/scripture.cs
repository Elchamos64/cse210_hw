using System;
using System.Collections.Generic;
using System.Linq;

class Scripture {
    private string or_text;
    private List<Word> or_words;
    private string or_reference;


    public Scripture(){
        or_text = "";
        or_words = new List<Word>();
        or_reference = "";
    }


    public Scripture(string text, string reference) {
        or_text = text;
        or_reference = reference;
        or_words = new List<Word>();


        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray) {
            or_words.Add(new Word(word));
        }
    }


    public override string ToString() {
        List<string> or_displayWords = new List<string>();
        foreach (Word word in or_words) {
            or_displayWords.Add(word.hideOrShow());
        }
        return $"{or_reference}: {string.Join(" ", or_displayWords)}";
    }


    public bool AreAllWordsHidden() {
        return or_words.All(word => word.getHidden());
    }


    public void HideRandomWord() {
        Random random = new Random();
        int index;
        do {
            index = random.Next(or_words.Count);
        } while (or_words[index].getHidden());

        or_words[index].Hide();
    }
}