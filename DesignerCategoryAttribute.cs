public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 2693
{	// Fields
	private string category; // 0x10
	private string typeId; // 0x18
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x159C240 Offset: 0x159B640 VA: 0x18159C240
	public void .ctor() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string category) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Category() { }

	// RVA: 0x159C290 Offset: 0x159B690 VA: 0x18159C290 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x159BFC0 Offset: 0x159B3C0 VA: 0x18159BFC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x159C040 Offset: 0x159B440 VA: 0x18159C040 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x159C0C0 Offset: 0x159B4C0 VA: 0x18159C0C0
	private static void .cctor() { }

}

