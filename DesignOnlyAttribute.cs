public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 2690
{	private bool isDesignOnly; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	public bool IsDesignOnly { get; }


	public void .ctor(bool isDesignOnly) { }

	public bool get_IsDesignOnly() { }

	public override bool IsDefaultAttribute() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

