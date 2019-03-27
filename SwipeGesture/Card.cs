using System;
namespace SwipeGesture
{
    public class Card
    {
        public string Image { get; set; }
        public string Question { get; set; }
        public bool IsTrue { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsCorrect { get; set; }
        public Card(string image, string question, bool isTrue) 
        {
            Image = image;
            Question = question;
            IsTrue = isTrue;
            IsAnswered = false;
            IsCorrect = false;

        }
    }
}
