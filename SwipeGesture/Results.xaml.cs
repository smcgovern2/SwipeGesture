using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SwipeGesture
{
    public partial class Results : ContentPage
    {
        List<Card> Cards;
        public Results(List<Card> cards)
        {
            Cards = cards;

            InitializeComponent();


            _Score.Text = "You got " + Cards.Where(c => c.IsCorrect).Count() + "/" + Cards.Count + " Correct!" ;
        }
    }
}
