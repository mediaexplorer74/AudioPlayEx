using System;
using Xamarin.Forms;
using AudioPlayEx.Droid;
using Android.Media;
using Android.Content.Res;
using AudioPlayEx.Native;

[assembly: Dependency(typeof(AudioService))]
namespace AudioPlayEx.Droid
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

		public void PlayAudioFile(string fileName){
			
			var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
			
			_player.Prepared += (s, e) =>
			{
				_player.Start();
			};
			
			_player.SetDataSource(fd.FileDescriptor,fd.StartOffset,fd.Length);
			_player.Prepare();
		}
	}
}

