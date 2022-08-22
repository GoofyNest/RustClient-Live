public class DescriptionAttribute : Attribute // TypeDefIndex: 2689
{	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }


	public void .ctor() { }

	public void .ctor(string description) { }

	public virtual string get_Description() { }

	protected string get_DescriptionValue() { }

	protected void set_DescriptionValue(string value) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

