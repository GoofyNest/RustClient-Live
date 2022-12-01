public sealed class RenderSettings : Object // TypeDefIndex: 3405
{
	[NativePropertyAttribute]
	public static bool fog { get; }
	[NativePropertyAttribute]
	public static float fogStartDistance { get; }
	[NativePropertyAttribute]
	public static float fogEndDistance { get; }
	public static FogMode fogMode { get; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; set; }
	[NativePropertyAttribute]
	public static Color ambientLight { get; set; }
	[NativePropertyAttribute]
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

