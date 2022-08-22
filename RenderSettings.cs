public sealed class RenderSettings : Object // TypeDefIndex: 3404
{	[NativePropertyAttribute] // RVA: 0x907F0 Offset: 0x8FBF0 VA: 0x1800907F0
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


	public static bool get_fog() { }

	public static float get_fogStartDistance() { }

	public static float get_fogEndDistance() { }

	public static FogMode get_fogMode() { }

	public static Color get_fogColor() { }

	public static void set_fogColor(Color value) { }

	public static float get_fogDensity() { }

	public static AmbientMode get_ambientMode() { }

	public static void set_ambientMode(AmbientMode value) { }

	public static Color get_ambientSkyColor() { }

	public static void set_ambientSkyColor(Color value) { }

	public static Color get_ambientEquatorColor() { }

	public static void set_ambientEquatorColor(Color value) { }

	public static Color get_ambientGroundColor() { }

	public static void set_ambientGroundColor(Color value) { }

	public static float get_ambientIntensity() { }

	public static void set_ambientIntensity(float value) { }

	public static Color get_ambientLight() { }

	public static void set_ambientLight(Color value) { }

	public static Material get_skybox() { }

	public static void set_skybox(Material value) { }

	public static SphericalHarmonicsL2 get_ambientProbe() { }

	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	public static Cubemap get_customReflection() { }

	public static float get_reflectionIntensity() { }

	public static void set_reflectionIntensity(float value) { }

	public static DefaultReflectionMode get_defaultReflectionMode() { }

	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	public static int get_defaultReflectionResolution() { }

	private static void get_fogColor_Injected(out Color ret) { }

	private static void set_fogColor_Injected(ref Color value) { }

	private static void get_ambientSkyColor_Injected(out Color ret) { }

	private static void set_ambientSkyColor_Injected(ref Color value) { }

	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	private static void get_ambientGroundColor_Injected(out Color ret) { }

	private static void set_ambientGroundColor_Injected(ref Color value) { }

	private static void get_ambientLight_Injected(out Color ret) { }

	private static void set_ambientLight_Injected(ref Color value) { }

	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }

}

