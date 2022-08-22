public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 2693
{	private string category; // 0x10
	private string typeId; // 0x18
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18

	public string Category { get; }
	public override object TypeId { get; }


	public void .ctor() { }

	public void .ctor(string category) { }

	public string get_Category() { }

	public override object get_TypeId() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

