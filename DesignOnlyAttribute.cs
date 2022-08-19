public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{	// Fields
	private bool isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsDesignOnly() { }

	// RVA: 0x159B8C0 Offset: 0x159ACC0 VA: 0x18159B8C0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x159B840 Offset: 0x159AC40 VA: 0x18159B840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C3330 Offset: 0x13C2730 VA: 0x1813C3330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x159B940 Offset: 0x159AD40 VA: 0x18159B940
	private static void .cctor() { }

}

