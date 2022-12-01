public class RazerChromaService : IRgbService // TypeDefIndex: 7729
{
	private readonly object _syncRoot;
	private Color _baseColor;
	private Nullable<float> _pulseDuration;
	private Color _pulseColor;
	private readonly Stopwatch _pulseTimer;
	[CompilerGeneratedAttribute]
	private bool <IsConnected>k__BackingField;
	[CompilerGeneratedAttribute]
	private Vector3 <ColorCorrection>k__BackingField;

	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }


	public void .ctor() { }

	[CompilerGeneratedAttribute]
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute]
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute]
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute]
	public void set_ColorCorrection(Vector3 value) { }

	public ValueTask Start() { }

	public ValueTask Stop() { }

	public ValueTask Update() { }

	public void StaticColor(Color color) { }

	public void PulseColor(Color color, float duration) { }

	public void Event(RgbEventType type) { }

	private void CalculateAndRenderColor() { }

	private static void SetColor(Color32 color) { }

	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute]
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute]
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

