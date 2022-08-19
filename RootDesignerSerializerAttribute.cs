public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{	// Fields
	private bool reloadable; // 0x10
	private string serializerTypeName; // 0x18
	private string serializerBaseTypeName; // 0x20
	private string typeId; // 0x28

	// Properties
	public override object TypeId { get; }

	// Methods

	// RVA: 0x15B17A0 Offset: 0x15B0BA0 VA: 0x1815B17A0
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x15B1800 Offset: 0x15B0C00 VA: 0x1815B1800 Slot: 4
	public override object get_TypeId() { }

}

