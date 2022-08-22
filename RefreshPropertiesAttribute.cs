public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	public RefreshProperties RefreshProperties { get; }


	public void .ctor(RefreshProperties refresh) { }

	public RefreshProperties get_RefreshProperties() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

