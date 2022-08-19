public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2692
{	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x159BE20 Offset: 0x159B220 VA: 0x18159BE20
	public void .ctor(string designerTypeName) { }

	// RVA: 0x159BD60 Offset: 0x159B160 VA: 0x18159BD60
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x159BF10 Offset: 0x159B310 VA: 0x18159BF10 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x159BC50 Offset: 0x159B050 VA: 0x18159BC50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159BD00 Offset: 0x159B100 VA: 0x18159BD00 Slot: 2
	public override int GetHashCode() { }

}

