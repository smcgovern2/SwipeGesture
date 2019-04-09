using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SwipeGesture
{
    public partial class Results : ContentPage
    {
        public Results(List<Card> cards)
        {
            

            InitializeComponent();

            score.Text = "You got " + cards.Count(c => c.IsCorrect) + "/" + cards.Count + " Questions right";

        }
    }
}
