public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3872
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x18F56A0 Offset: 0x18F4AA0 VA: 0x1818F56A0
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x2170F0 Offset: 0x2164F0 VA: 0x1802170F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F5710 Offset: 0x18F4B10 VA: 0x1818F5710
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x2172B0 Offset: 0x2166B0 VA: 0x1802172B0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217210 Offset: 0x216610 VA: 0x180217210 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x18F5350 Offset: 0x18F4750 VA: 0x1818F5350
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x18F5660 Offset: 0x18F4A60 VA: 0x1818F5660
	private static void .cctor() { }

}

