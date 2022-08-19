public class RgbEffects : SingletonComponent<RgbEffects> // TypeDefIndex: 10705
{	// Fields
	[ClientVar] // RVA: 0x723C0 Offset: 0x717C0 VA: 0x1800723C0
	public static bool Enabled; // 0x0
	[ClientVar] // RVA: 0x73890 Offset: 0x72C90 VA: 0x180073890
	public static Vector3 ColorCorrection_SteelSeries; // 0x4
	[ClientVar] // RVA: 0x739F0 Offset: 0x72DF0 VA: 0x1800739F0
	public static Vector3 ColorCorrection_Razer; // 0x10
	[ClientVar] // RVA: 0x73A80 Offset: 0x72E80 VA: 0x180073A80
	public static float Brightness; // 0x1C
	public Color defaultColor; // 0x18
	public Color buildingPrivilegeColor; // 0x28
	public Color coldColor; // 0x38
	public Color hotColor; // 0x48
	public Color hurtColor; // 0x58
	public Color healedColor; // 0x68
	public Color irradiatedColor; // 0x78
	public Color comfortedColor; // 0x88
	private RgbController _controller; // 0x98
	private readonly Stopwatch _lastStaticSet; // 0xA0
	private Nullable<Color> _lastStatic; // 0xA8
	private readonly Stopwatch _lastPulse; // 0xC0
	private float _lastPulseDuration; // 0xC8

	// Methods

	// RVA: 0x4C2420 Offset: 0x4C1820 VA: 0x1804C2420
	public void OnEnable() { }

	// RVA: 0x4C2390 Offset: 0x4C1790 VA: 0x1804C2390
	public void OnDisable() { }

	// RVA: 0x4C2CB0 Offset: 0x4C20B0 VA: 0x1804C2CB0
	private void UpdateLighting() { }

	// RVA: 0x4C1BB0 Offset: 0x4C0FB0 VA: 0x1804C1BB0
	private void CopyColorCorrection() { }

	// RVA: 0x4C29D0 Offset: 0x4C1DD0 VA: 0x1804C29D0
	private void SetStaticColor(Color color, bool force = False) { }

	// RVA: 0x4C2570 Offset: 0x4C1970 VA: 0x1804C2570
	private void PulseColor(RgbColor color, float duration) { }

	// RVA: 0x4C1F20 Offset: 0x4C1320 VA: 0x1804C1F20
	private Color GetColor(RgbColor color) { }

	// RVA: 0x4C24A0 Offset: 0x4C18A0 VA: 0x1804C24A0
	private static Color PreprocessColor(Color color) { }

	// RVA: 0x4C2BB0 Offset: 0x4C1FB0 VA: 0x1804C2BB0
	public static void Static(RgbColor color) { }

	// RVA: 0x4C2740 Offset: 0x4C1B40 VA: 0x1804C2740
	public static void Pulse(RgbColor color, float duration = 0,5) { }

	// RVA: 0x4C1E30 Offset: 0x4C1230 VA: 0x1804C1E30
	public static void Event(RgbEventType type) { }

	// RVA: 0x4C1DA0 Offset: 0x4C11A0 VA: 0x1804C1DA0
	public static void DamagePulse(DamageType type) { }

	// RVA: 0x4C2030 Offset: 0x4C1430 VA: 0x1804C2030
	private static RgbColor GetCurrentBackground() { }

	// RVA: 0x4C2130 Offset: 0x4C1530 VA: 0x1804C2130
	private static Nullable<ValueTuple<RgbColor, float>> GetCurrentFlash() { }

	[ClientVar] // RVA: 0x73C30 Offset: 0x73030 VA: 0x180073C30
	[EditorBrowsableAttribute] // RVA: 0x73C30 Offset: 0x73030 VA: 0x180073C30
	// RVA: 0x4C1A90 Offset: 0x4C0E90 VA: 0x1804C1A90
	public static void ConVar_Static(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	[EditorBrowsableAttribute] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	// RVA: 0x4C1860 Offset: 0x4C0C60 VA: 0x1804C1860
	public static void ConVar_Pulse(ConsoleSystem.Arg args) { }

	// RVA: 0x4C34F0 Offset: 0x4C28F0 VA: 0x1804C34F0
	public void .ctor() { }

	// RVA: 0x4C3410 Offset: 0x4C2810 VA: 0x1804C3410
	private static void .cctor() { }

}

