public sealed class RenderSettings : Object // TypeDefIndex: 3404
{	// Properties
	[NativePropertyAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
	public static bool fog { get; }
	[NativePropertyAttribute] // RVA: 0x90930 Offset: 0x8FD30 VA: 0x180090930
	public static float fogStartDistance { get; }
	[NativePropertyAttribute] // RVA: 0x90A90 Offset: 0x8FE90 VA: 0x180090A90
	public static float fogEndDistance { get; }
	public static FogMode fogMode { get; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; set; }
	[NativePropertyAttribute] // RVA: 0x90CE0 Offset: 0x900E0 VA: 0x180090CE0
	public static Color ambientLight { get; set; }
	[NativePropertyAttribute] // RVA: 0x90E30 Offset: 0x90230 VA: 0x180090E30
	public static Material skybox { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; set; }
	public static Cubemap customReflection { get; }
	public static float reflectionIntensity { get; set; }
	public static DefaultReflectionMode defaultReflectionMode { get; set; }
	public static int defaultReflectionResolution { get; }

	// Methods

	// RVA: 0x19AAB30 Offset: 0x19A9F30 VA: 0x1819AAB30
	public static bool get_fog() { }

	// RVA: 0x19AAB00 Offset: 0x19A9F00 VA: 0x1819AAB00
	public static float get_fogStartDistance() { }

	// RVA: 0x19AAAA0 Offset: 0x19A9EA0 VA: 0x1819AAAA0
	public static float get_fogEndDistance() { }

	// RVA: 0x19AAAD0 Offset: 0x19A9ED0 VA: 0x1819AAAD0
	public static FogMode get_fogMode() { }

	// RVA: 0x19AAA30 Offset: 0x19A9E30 VA: 0x1819AAA30
	public static Color get_fogColor() { }

	// RVA: 0x19AAF40 Offset: 0x19AA340 VA: 0x1819AAF40
	public static void set_fogColor(Color value) { }

	// RVA: 0x19AAA70 Offset: 0x19A9E70 VA: 0x1819AAA70
	public static float get_fogDensity() { }

	// RVA: 0x19AA810 Offset: 0x19A9C10 VA: 0x1819AA810
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x19AAD80 Offset: 0x19AA180 VA: 0x1819AAD80
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x19AA920 Offset: 0x19A9D20 VA: 0x1819AA920
	public static Color get_ambientSkyColor() { }

	// RVA: 0x19AAE80 Offset: 0x19AA280 VA: 0x1819AAE80
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x19AA6A0 Offset: 0x19A9AA0 VA: 0x1819AA6A0
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x19AAC00 Offset: 0x19AA000 VA: 0x1819AAC00
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x19AA720 Offset: 0x19A9B20 VA: 0x1819AA720
	public static Color get_ambientGroundColor() { }

	// RVA: 0x19AAC80 Offset: 0x19AA080 VA: 0x1819AAC80
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x19AA760 Offset: 0x19A9B60 VA: 0x1819AA760
	public static float get_ambientIntensity() { }

	// RVA: 0x19AACC0 Offset: 0x19AA0C0 VA: 0x1819AACC0
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x19AA7D0 Offset: 0x19A9BD0 VA: 0x1819AA7D0
	public static Color get_ambientLight() { }

	// RVA: 0x19AAD40 Offset: 0x19AA140 VA: 0x1819AAD40
	public static void set_ambientLight(Color value) { }

	// RVA: 0x19AAB90 Offset: 0x19A9F90 VA: 0x1819AAB90
	public static Material get_skybox() { }

	// RVA: 0x19AAFC0 Offset: 0x19AA3C0 VA: 0x1819AAFC0
	public static void set_skybox(Material value) { }

	// RVA: 0x19AA880 Offset: 0x19A9C80 VA: 0x1819AA880
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x19AAE00 Offset: 0x19AA200 VA: 0x1819AAE00
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x19AA960 Offset: 0x19A9D60 VA: 0x1819AA960
	public static Cubemap get_customReflection() { }

	// RVA: 0x19AAB60 Offset: 0x19A9F60 VA: 0x1819AAB60
	public static float get_reflectionIntensity() { }

	// RVA: 0x19AAF80 Offset: 0x19AA380 VA: 0x1819AAF80
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x19AA990 Offset: 0x19A9D90 VA: 0x1819AA990
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x19AAEC0 Offset: 0x19AA2C0 VA: 0x1819AAEC0
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x19AA9C0 Offset: 0x19A9DC0 VA: 0x1819AA9C0
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x19AA9F0 Offset: 0x19A9DF0 VA: 0x1819AA9F0
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x19AAF00 Offset: 0x19AA300 VA: 0x1819AAF00
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x19AA8E0 Offset: 0x19A9CE0 VA: 0x1819AA8E0
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x19AAE40 Offset: 0x19AA240 VA: 0x1819AAE40
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x19AA660 Offset: 0x19A9A60 VA: 0x1819AA660
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x19AABC0 Offset: 0x19A9FC0 VA: 0x1819AABC0
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x19AA6E0 Offset: 0x19A9AE0 VA: 0x1819AA6E0
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x19AAC40 Offset: 0x19AA040 VA: 0x1819AAC40
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x19AA790 Offset: 0x19A9B90 VA: 0x1819AA790
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x19AAD00 Offset: 0x19AA100 VA: 0x1819AAD00
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x19AA840 Offset: 0x19A9C40 VA: 0x1819AA840
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x19AADC0 Offset: 0x19AA1C0 VA: 0x1819AADC0
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

