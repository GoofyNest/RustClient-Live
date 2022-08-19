public class DescriptionAttribute : Attribute // TypeDefIndex: 2689
{	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x159B7E0 Offset: 0x159ABE0 VA: 0x18159B7E0
	public void .ctor() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string description) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public virtual string get_Description() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	protected string get_DescriptionValue() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x159B5C0 Offset: 0x159A9C0 VA: 0x18159B5C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159B690 Offset: 0x159AA90 VA: 0x18159B690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x159B6D0 Offset: 0x159AAD0 VA: 0x18159B6D0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x159B740 Offset: 0x159AB40 VA: 0x18159B740
	private static void .cctor() { }

}

