public static class ColorUtilities // TypeDefIndex: 11881
{
	private const float logC_cut = 0,011361;
	private const float logC_a = 5,555556;
	private const float logC_b = 0,047996;
	private const float logC_c = 0,244161;
	private const float logC_d = 0,386036;
	private const float logC_e = 5,301883;
	private const float logC_f = 0,092819;


	public static float StandardIlluminantY(float x) { }

	public static Vector3 CIExyToLMS(float x, float y) { }

	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	public static Vector3 ColorToLift(Vector4 color) { }

	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	public static Vector3 ColorToGain(Vector4 color) { }

	public static float LogCToLinear(float x) { }

	public static float LinearToLogC(float x) { }

	public static uint ToHex(Color c) { }

	public static Color ToRGBA(uint hex) { }

}

