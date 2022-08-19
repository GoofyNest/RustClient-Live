public static class ColorUtilities // TypeDefIndex: 11853
{	// Fields
	private const float logC_cut = 0,011361;
	private const float logC_a = 5,555556;
	private const float logC_b = 0,047996;
	private const float logC_c = 0,244161;
	private const float logC_d = 0,386036;
	private const float logC_e = 5,301883;
	private const float logC_f = 0,092819;

	// Methods

	// RVA: 0x9D6790 Offset: 0x9D5B90 VA: 0x1809D6790
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x9D6080 Offset: 0x9D5480 VA: 0x1809D6080
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x9D64A0 Offset: 0x9D58A0 VA: 0x1809D64A0
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x9D63C0 Offset: 0x9D57C0 VA: 0x1809D63C0
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x9D6210 Offset: 0x9D5610 VA: 0x1809D6210
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x9D6130 Offset: 0x9D5530 VA: 0x1809D6130
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x9D66E0 Offset: 0x9D5AE0 VA: 0x1809D66E0
	public static float LogCToLinear(float x) { }

	// RVA: 0x9D6640 Offset: 0x9D5A40 VA: 0x1809D6640
	public static float LinearToLogC(float x) { }

	// RVA: 0x9D67C0 Offset: 0x9D5BC0 VA: 0x1809D67C0
	public static uint ToHex(Color c) { }

	// RVA: 0x9D6820 Offset: 0x9D5C20 VA: 0x1809D6820
	public static Color ToRGBA(uint hex) { }

}

