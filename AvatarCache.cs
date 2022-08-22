public class AvatarCache // TypeDefIndex: 5684
{	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; // 0x10
	private readonly Action<ulong, Texture2D> _loadAvatar; // 0x18


	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5685
{	public readonly ulong UserId; // 0x0
	public readonly Texture2D Texture; // 0x8


	public void .ctor(ulong userId, Texture2D texture) { }

}

