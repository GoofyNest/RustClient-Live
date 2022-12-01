public class SpriteAtlasManager // TypeDefIndex: 3581
{
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Action<string, Action<SpriteAtlas>> atlasRequested;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Action<SpriteAtlas> atlasRegistered;


	[RequiredByNativeCodeAttribute]
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute]
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute]
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	internal static void Register(SpriteAtlas spriteAtlas) { }

	private static void .cctor() { }

}

