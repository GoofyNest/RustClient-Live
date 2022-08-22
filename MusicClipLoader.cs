public class MusicClipLoader // TypeDefIndex: 9002
{	public List<MusicClipLoader.LoadedAudioClip> loadedClips; // 0x10
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; // 0x18
	public List<AudioClip> clipsToLoad; // 0x20
	public List<AudioClip> clipsToUnload; // 0x28


	public void Update() { }

	public void Refresh() { }

	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	public void .ctor() { }

}

public class MusicClipLoader.LoadedAudioClip // TypeDefIndex: 9003
{	public AudioClip clip; // 0x10
	public float unloadTime; // 0x18


	public void .ctor() { }

}

