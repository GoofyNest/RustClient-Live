public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 2775
{
	public static readonly RefreshPropertiesAttribute All; 
	public static readonly RefreshPropertiesAttribute Repaint; 
	public static readonly RefreshPropertiesAttribute Default; 
	private RefreshProperties refresh; 

	public RefreshProperties RefreshProperties { get; }


	public void .ctor(RefreshProperties refresh) { }

	public RefreshProperties get_RefreshProperties() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

