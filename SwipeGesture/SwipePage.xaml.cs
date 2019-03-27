using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace SwipeGesture
{
    public partial class SwipePage : ContentPage
    {
        int PageNumber;
        int CardNumber;
        List<Card> Cards;
        public SwipePage()
        {
            CardNumber = 1;
            PageNumber = 1;

            InitializeComponent();
            Cards = new List<Card>();
            Cards.Add(new Card("GeorgeWashington", "George Washington was the First US president", true));
            Cards.Add(new Card("Spaghetti", "Spaghetti comes from france", false));
            Cards.Add(new Card("Map", "There are 8 Continents", false));
            Cards.Add(new Card("Batman", "Batman's real name is Bruce Wayne", true));
            Cards.Add(new Card("CocaCola", "Coca-Cola contains more sugar than Pepsi", false));
            _label.Text = Cards[CardNumber].Question;
            True.IsVisible = false;
            False.IsVisible = false;
        }


        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    if(PageNumber < Cards.Count * 2)
                    {
                        PageNumber++;
                        if (PageNumber % 2 == 1)
                        {
                            CardNumber++;
                        }
                    } else {
                        Navigation.PushAsync
                    }
                    break;
                case SwipeDirection.Right:
                    if (PageNumber > 1)
                    {
                        PageNumber--;
                        if (PageNumber % 2 == 1)
                        {
                            CardNumber--;
                        }
                    }
                    break;
                case SwipeDirection.Up:
                    break;
                case SwipeDirection.Down:
                    break;
            }

            if(PageNumber % 2 == 0){
                True.IsVisible = true;
                False.IsVisible = true;
                _label.IsVisible = false;
            } else {
                _label.Text = Cards[CardNumber].Question;
                True.IsVisible = false;
                False.IsVisible = false;
                _label.IsVisible = true;

            }
        }
        void OnTrueButtonClicked(object sender, EventArgs e)
        {
            Cards[CardNumber].IsAnswered = true;
            if (Cards[CardNumber].IsTrue){
                Cards[CardNumber].IsCorrect = true;
            }

        }
        void OnFalseButtonClicked(object sender, EventArgs e)
        {

            Cards[CardNumber].IsAnswered = true;
            if (Cards[CardNumber].IsTrue)
            {
                Cards[CardNumber].IsCorrect = false;
            }
        }
    }
}
