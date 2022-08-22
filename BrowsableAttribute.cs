public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	public bool Browsable { get; }


	public void .ctor(bool browsable) { }

	public bool get_Browsable() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

