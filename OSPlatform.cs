public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 1319
{	// Fields
	private readonly string _osPlatform; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly OSPlatform <Linux>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly OSPlatform <OSX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static readonly OSPlatform <Windows>k__BackingField; // 0x10

	// Properties
	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE63E0 Offset: 0xFE57E0 VA: 0x180FE63E0
	public static OSPlatform get_Linux() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE6440 Offset: 0xFE5840 VA: 0x180FE6440
	public static OSPlatform get_OSX() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE64A0 Offset: 0xFE58A0 VA: 0x180FE64A0
	public static OSPlatform get_Windows() { }

	// RVA: 0x14C5F0 Offset: 0x14B9F0 VA: 0x18014C5F0
	private void .ctor(string osPlatform) { }

	// RVA: 0x14C4E0 Offset: 0x14B8E0 VA: 0x18014C4E0 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x14C4E0 Offset: 0x14B8E0 VA: 0x18014C4E0
	internal bool Equals(string other) { }

	// RVA: 0x14C4F0 Offset: 0x14B8F0 VA: 0x18014C4F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C580 Offset: 0x14B980 VA: 0x18014C580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14C5A0 Offset: 0x14B9A0 VA: 0x18014C5A0 Slot: 3
	public override string ToString() { }

	// RVA: 0xFE6500 Offset: 0xFE5900 VA: 0x180FE6500
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0xFE6140 Offset: 0xFE5540 VA: 0x180FE6140
	private static void .cctor() { }

}

