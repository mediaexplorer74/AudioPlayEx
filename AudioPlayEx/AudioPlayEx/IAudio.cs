using System;

namespace AudioPlayEx.Native
{
	public interface IAudio
	{
		void PlayAudioFile(string fileName);
		void StopMusic();
	}
}

