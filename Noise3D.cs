public static class Noise3D // TypeDefIndex: 13355
{
	private static bool ms_IsSupportedChecked;
	private static bool ms_IsSupported;
	private static Texture3D ms_NoiseTexture;
	private const HideFlags kHideFlags = 61;
	private const int kMinShaderLevel = 35;

	public static bool isSupported { get; }
	public static bool isProperlyLoaded { get; }
	public static string isNotSupportedString { get; }


	public static bool get_isSupported() { }

	public static bool get_isProperlyLoaded() { }

	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute]
	private static void OnStartUp() { }

	public static void LoadIfNeeded() { }

	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	private static void .cctor() { }

}

