public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 2724
{	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool listBindable; // 0x10
	private bool isDefault; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool listBindable) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_ListBindable() { }

	// RVA: 0x15A2D20 Offset: 0x15A2120 VA: 0x1815A2D20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15A2DA0 Offset: 0x15A21A0 VA: 0x1815A2DA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15A2E20 Offset: 0x15A2220 VA: 0x1815A2E20
	private static void .cctor() { }

}

