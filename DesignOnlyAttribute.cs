public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{
	private bool isDesignOnly; 
	public static readonly DesignOnlyAttribute Yes; 
	public static readonly DesignOnlyAttribute No; 
	public static readonly DesignOnlyAttribute Default; 

	public bool IsDesignOnly { get; }


	public void .ctor(bool isDesignOnly) { }

	public bool get_IsDesignOnly() { }

	public override bool IsDefaultAttribute() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

