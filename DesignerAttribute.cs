public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2692
{
	private readonly string designerTypeName;
	private readonly string designerBaseTypeName;
	private string typeId;

	public override object TypeId { get; }


	public void .ctor(string designerTypeName) { }

	public void .ctor(string designerTypeName, Type designerBaseType) { }

	public override object get_TypeId() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

