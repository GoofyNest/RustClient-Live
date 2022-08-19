public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 2695
{	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private DesignerSerializationVisibility visibility; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0xB0C8A0 Offset: 0xB0BCA0 VA: 0x180B0C8A0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x159C300 Offset: 0x159B700 VA: 0x18159C300 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x159C380 Offset: 0x159B780 VA: 0x18159C380 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x159C3F0 Offset: 0x159B7F0 VA: 0x18159C3F0
	private static void .cctor() { }

}

