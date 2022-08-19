public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0xB0C8A0 Offset: 0xB0BCA0 VA: 0x180B0C8A0
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x172E770 Offset: 0x172DB70 VA: 0x18172E770 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x172E800 Offset: 0x172DC00 VA: 0x18172E800 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x172E870 Offset: 0x172DC70 VA: 0x18172E870
	private static void .cctor() { }

}

