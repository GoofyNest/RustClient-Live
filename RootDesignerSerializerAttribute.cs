public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 2788
{
	private bool reloadable; 
	private string serializerTypeName; 
	private string serializerBaseTypeName; 
	private string typeId; 

public override object TypeId { get; }


public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

public override object get_TypeId() { }

}

