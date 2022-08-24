public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 2693
{
	private string category; 
	private string typeId; 
	public static readonly DesignerCategoryAttribute Component; 
	public static readonly DesignerCategoryAttribute Default; 
	public static readonly DesignerCategoryAttribute Form; 
	public static readonly DesignerCategoryAttribute Generic; 

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

