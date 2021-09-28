using AudioPlayEx.Native;
using System;

using Xamarin.Forms;

namespace AudioPlayEx
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Button
						{
							//Name = "Button1",
							Text = "Play Demo music",
							Command = new Command(() =>
								{
									DependencyService.Get<IAudio>().PlayAudioFile("demo.mp3");
								})
						}
						,
						new Button {
							//Name = "Button2",
							Text = "Stop music",
							Command = new Command(() =>
								{
									DependencyService.Get<IAudio>().StopMusic();
								})

						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

