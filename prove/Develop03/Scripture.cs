using System.Diagnostics.Metrics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private List<int> _randomNumbers = new List<int>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(text = word);
            _words.Add(newWord);
        }
       
    }

    public void HideRandomWords(int numberToHide)
    {
        int counter = 0;
        while (counter < numberToHide)
        {
            bool isInUse = false;
            Random random = new Random();
            int randomNumber = random.Next(0, _words.Count);

            foreach (int number in _randomNumbers)
            {
                if (randomNumber == number)
                {
                    isInUse = true;
                }
            }   
            if (!isInUse)
            {
                _randomNumbers.Add(randomNumber);
                _words[randomNumber].Hide();
                counter += 1;
            }

            int remainingWords = _words.Count - _randomNumbers.Count;
            if (remainingWords == 0)
            {
                break;
            }
            
        }    
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            string newText = word.GetDisplayText();
            text += newText;
            text += " ";
        }

        string referenceText = _reference.GetDisplayText();

        string scripture = referenceText + " " + text;
        
        return scripture;
    }

    public bool IsComplatelyHidden()
    {
        bool isComplatelyHidden = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                isComplatelyHidden = false;
            }
        }
        return isComplatelyHidden;
    }

}