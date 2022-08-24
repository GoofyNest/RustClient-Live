public class RgbEffects : SingletonComponent<RgbEffects> // TypeDefIndex: 10705
{
	[ClientVar] 
	public static bool Enabled; 
	[ClientVar] 
	public static Vector3 ColorCorrection_SteelSeries; 
	[ClientVar] 
	public static Vector3 ColorCorrection_Razer; 
	[ClientVar] 
	public static float Brightness; 
	public Color defaultColor; 
	public Color buildingPrivilegeColor; 
	public Color coldColor; 
	public Color hotColor; 
	public Color hurtColor; 
	public Color healedColor; 
	public Color irradiatedColor; 
	public Color comfortedColor; 
	private RgbController _controller; 
	private readonly Stopwatch _lastStaticSet; 
	private Nullable<Color> _lastStatic; 
	private readonly Stopwatch _lastPulse; 
	private float _lastPulseDuration; 


	public void OnEnable() { }

	public void OnDisable() { }

	private void UpdateLighting() { }

	private void CopyColorCorrection() { }

	private void SetStaticColor(Color color, bool force = False) { }

	private void PulseColor(RgbColor color, float duration) { }

	private Color GetColor(RgbColor color) { }

	private static Color PreprocessColor(Color color) { }

	public static void Static(RgbColor color) { }

	public static void Pulse(RgbColor color, float duration = 0,5) { }

	public static void Event(RgbEventType type) { }

	public static void DamagePulse(DamageType type) { }

	private static RgbColor GetCurrentBackground() { }

	private static Nullable<ValueTuple<RgbColor, float>> GetCurrentFlash() { }

	[ClientVar] 
	[EditorBrowsableAttribute] 
	public static void ConVar_Static(ConsoleSystem.Arg args) { }

	[ClientVar] 
	[EditorBrowsableAttribute] 
	public static void ConVar_Pulse(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

