internal static class StringBuilderCache // TypeDefIndex: 464
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x191A660 Offset: 0x1919A60 VA: 0x18191A660
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x191A800 Offset: 0x1919C00 VA: 0x18191A800
	public static void Release(StringBuilder sb) { }

	// RVA: 0x191A770 Offset: 0x1919B70 VA: 0x18191A770
	public static string GetStringAndRelease(StringBuilder sb) { }

}

