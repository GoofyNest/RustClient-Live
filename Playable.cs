public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x18F5910 Offset: 0x18F4D10 VA: 0x1818F5910
	public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19E2A0 Offset: 0x19D6A0 VA: 0x18019E2A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x217480 Offset: 0x216880 VA: 0x180217480 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x18F5860 Offset: 0x18F4C60 VA: 0x1818F5860
	private static void .cctor() { }

}

