public class MusicClipLoader // TypeDefIndex: 9002
{	// Fields
	public List<MusicClipLoader.LoadedAudioClip> loadedClips; // 0x10
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; // 0x18
	public List<AudioClip> clipsToLoad; // 0x20
	public List<AudioClip> clipsToUnload; // 0x28

	// Methods

	// RVA: 0x7BBA80 Offset: 0x7BAE80 VA: 0x1807BBA80
	public void Update() { }

	// RVA: 0x7BB6F0 Offset: 0x7BAAF0 VA: 0x1807BB6F0
	public void Refresh() { }

	// RVA: 0x7BB670 Offset: 0x7BAA70 VA: 0x1807BB670
	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	// RVA: 0x7BBBD0 Offset: 0x7BAFD0 VA: 0x1807BBBD0
	public void .ctor() { }

}

public class MusicClipLoader.LoadedAudioClip // TypeDefIndex: 9003
{	// Fields
	public AudioClip clip; // 0x10
	public float unloadTime; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

