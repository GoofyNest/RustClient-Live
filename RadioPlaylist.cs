public class RadioPlaylist : ScriptableObject // TypeDefIndex: 9453
{	// Fields
	public string Url; // 0x18
	public AudioClip[] Playlist; // 0x20
	public float PlaylistLength; // 0x28

	// Methods

	// RVA: 0x6A2560 Offset: 0x6A1960 VA: 0x1806A2560
	public void GetPlaylistPosition(TimeSpan timeOfDay, out AudioClip clip, out float playTime) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

