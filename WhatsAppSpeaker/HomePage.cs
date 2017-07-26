using System;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace WhatsAppSpeaker
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
			Entry entry1 = new Entry
			{
				Placeholder = "Introduce el texto a decir"
			};

			Button btn1 = new Button
			{
				Text = "Empezar a escuchar",
				Command = new Command(() =>
				{
                    var text = entry1.Text;
					CrossTextToSpeech.Current.Speak(text);
				})
			};

			StackLayout stk = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = { entry1, btn1 }
			};

			Content = stk;
        }
    }
}
