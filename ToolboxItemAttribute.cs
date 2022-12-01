public class ToolboxItemAttribute : Attribute // TypeDefIndex: 2776
{
	private string toolboxItemTypeName;
	public static readonly ToolboxItemAttribute Default;
	public static readonly ToolboxItemAttribute None;

	public string ToolboxItemTypeName { get; }


	public override bool IsDefaultAttribute() { }

	public void .ctor(bool defaultType) { }

	public void .ctor(string toolboxItemTypeName) { }

	public string get_ToolboxItemTypeName() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

