public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{	private bool reloadable; // 0x10
	private string serializerTypeName; // 0x18
	private string serializerBaseTypeName; // 0x20
	private string typeId; // 0x28

	public override object TypeId { get; }


	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	public override object get_TypeId() { }

}

