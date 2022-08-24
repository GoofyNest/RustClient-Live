public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 2739
{
	private bool recommendedAsConfigurable; 
	public static readonly RecommendedAsConfigurableAttribute No; 
	public static readonly RecommendedAsConfigurableAttribute Yes; 
	public static readonly RecommendedAsConfigurableAttribute Default; 

	public bool RecommendedAsConfigurable { get; }


	public void .ctor(bool recommendedAsConfigurable) { }

	public bool get_RecommendedAsConfigurable() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

