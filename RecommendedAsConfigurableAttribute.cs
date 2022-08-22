public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 2739
{	private bool recommendedAsConfigurable; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	public bool RecommendedAsConfigurable { get; }


	public void .ctor(bool recommendedAsConfigurable) { }

	public bool get_RecommendedAsConfigurable() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

