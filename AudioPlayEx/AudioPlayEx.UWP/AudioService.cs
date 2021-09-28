using System;
using Xamarin.Forms;
using AudioPlayEx.UWP;
using Windows.Media;
using AudioPlayEx.Native;
using Windows.Media.Playback;
using Windows.Media.Core;

[assembly: Dependency(typeof(AudioService))]
namespace AudioPlayEx.UWP
{
	public class AudioService: IAudio
	{
		MediaPlayer _player; 
		public AudioService ()
		{
			_player = new MediaPlayer();
		}

		public void StopMusic()
		{
			_player.Pause();
		}


		public void PlayAudioFile(string fileName)
		{
			_player.Source = Windows.Media.Core.MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/" + fileName));
			_player.Play();
		}
	}
}

