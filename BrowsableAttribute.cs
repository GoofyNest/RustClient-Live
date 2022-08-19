public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x15995F0 Offset: 0x15989F0 VA: 0x1815995F0
	public void .ctor(bool browsable) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_Browsable() { }

	// RVA: 0x1599440 Offset: 0x1598840 VA: 0x181599440 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C3330 Offset: 0x13C2730 VA: 0x1813C3330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15994C0 Offset: 0x15988C0 VA: 0x1815994C0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1599530 Offset: 0x1598930 VA: 0x181599530
	private static void .cctor() { }

}

