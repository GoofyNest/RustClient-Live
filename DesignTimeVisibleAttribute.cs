public sealed class DesignTimeVisibleAttribute : Attribute // TypeDefIndex: 2691
{
	private bool visible; 
	public static readonly DesignTimeVisibleAttribute Yes; 
	public static readonly DesignTimeVisibleAttribute No; 
	public static readonly DesignTimeVisibleAttribute Default; 

	public bool Visible { get; }


	public void .ctor(bool visible) { }

	public bool get_Visible() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

