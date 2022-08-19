public static class Noise3D // TypeDefIndex: 11547
{	// Fields
	private static bool ms_IsSupportedChecked; // 0x0
	private static bool ms_IsSupported; // 0x1
	private static Texture3D ms_NoiseTexture; // 0x8
	private const HideFlags kHideFlags = 61;
	private const int kMinShaderLevel = 35;

	// Properties
	public static bool isSupported { get; }
	public static bool isProperlyLoaded { get; }
	public static string isNotSupportedString { get; }

	// Methods

	// RVA: 0xAC4EE0 Offset: 0xAC42E0 VA: 0x180AC4EE0
	public static bool get_isSupported() { }

	// RVA: 0xAC4E50 Offset: 0xAC4250 VA: 0x180AC4E50
	public static bool get_isProperlyLoaded() { }

	// RVA: 0xAC4DD0 Offset: 0xAC41D0 VA: 0x180AC4DD0
	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x982E0 Offset: 0x976E0 VA: 0x1800982E0
	// RVA: 0xAC4D80 Offset: 0xAC4180 VA: 0x180AC4D80
	private static void OnStartUp() { }

	// RVA: 0xAC4600 Offset: 0xAC3A00 VA: 0x180AC4600
	public static void LoadIfNeeded() { }

	// RVA: 0xAC4A30 Offset: 0xAC3E30 VA: 0x180AC4A30
	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

