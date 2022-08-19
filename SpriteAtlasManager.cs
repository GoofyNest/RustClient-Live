public class SpriteAtlasManager // TypeDefIndex: 3578
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21745D0 Offset: 0x21739D0 VA: 0x1821745D0
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174730 Offset: 0x2173B30 VA: 0x182174730
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174830 Offset: 0x2173C30 VA: 0x182174830
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2174510 Offset: 0x2173910 VA: 0x182174510
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x2174590 Offset: 0x2173990 VA: 0x182174590
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x21746D0 Offset: 0x2173AD0 VA: 0x1821746D0
	private static void .cctor() { }

}

