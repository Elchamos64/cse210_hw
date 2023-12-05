using System;

class Word {
    private string or_text; 
    private bool or_isHidden; 

    public Word(string text) {
        or_text = text;
        or_isHidden = false;
    }

    public void Hide() {
        or_isHidden = true;
    }

    public bool getHidden(){
        return or_isHidden;
    }


    public string hideOrShow() {
        if (or_isHidden) {
            return "_______";
        }
        return or_text;
    }
}