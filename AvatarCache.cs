public class AvatarCache // TypeDefIndex: 5685
{
	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; 
	private readonly Action<ulong, Texture2D> _loadAvatar; 


	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5686
{
	public readonly ulong UserId; 
	public readonly Texture2D Texture; 


	public void .ctor(ulong userId, Texture2D texture) { }

}

