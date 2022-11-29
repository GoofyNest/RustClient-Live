public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2> // TypeDefIndex: 3845
{
	private float shr0; 
	private float shr1; 
	private float shr2; 
	private float shr3; 
	private float shr4; 
	private float shr5; 
	private float shr6; 
	private float shr7; 
	private float shr8; 
	private float shg0; 
	private float shg1; 
	private float shg2; 
	private float shg3; 
	private float shg4; 
	private float shg5; 
	private float shg6; 
	private float shg7; 
	private float shg8; 
	private float shb0; 
	private float shb1; 
	private float shb2; 
	private float shb3; 
	private float shb4; 
	private float shb5; 
	private float shb6; 
	private float shb7; 
	private float shb8; 

	public float Item { get; }


	public void AddAmbientLight(Color color) { }

	public void AddDirectionalLight(Vector3 direction, Color color, float intensity) { }

	[FreeFunctionAttribute] 
	private static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color) { }

	public float get_Item(int rgb, int coefficient) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(SphericalHarmonicsL2 other) { }

	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	private static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, ref Color color) { }

	private static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, ref Vector3 direction, ref Color color) { }

}

