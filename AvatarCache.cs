public class AvatarCache // TypeDefIndex: 5684
{	// Fields
	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; // 0x10
	private readonly Action<ulong, Texture2D> _loadAvatar; // 0x18

	// Methods

	// RVA: 0x22FAA20 Offset: 0x22F9E20 VA: 0x1822FAA20
	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	// RVA: 0x22FA7B0 Offset: 0x22F9BB0 VA: 0x1822FA7B0
	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5685
{	// Fields
	public readonly ulong UserId; // 0x0
	public readonly Texture2D Texture; // 0x8

	// Methods

	// RVA: 0x14B4A0 Offset: 0x14A8A0 VA: 0x18014B4A0
	public void .ctor(ulong userId, Texture2D texture) { }

}

