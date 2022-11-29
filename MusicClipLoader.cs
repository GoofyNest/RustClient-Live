public class MusicClipLoader // TypeDefIndex: 10729
{
	public List<MusicClipLoader.LoadedAudioClip> loadedClips; 
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; 
	public List<AudioClip> clipsToLoad; 
	public List<AudioClip> clipsToUnload; 


	public void Update() { }

	public void Refresh() { }

	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	public void .ctor() { }

}

public class MusicClipLoader.LoadedAudioClip // TypeDefIndex: 10730
{
	public AudioClip clip; 
	public float unloadTime; 


	public void .ctor() { }

}

