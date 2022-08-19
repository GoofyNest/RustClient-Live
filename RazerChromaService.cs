public class RazerChromaService : IRgbService // TypeDefIndex: 7713
{	// Fields
	private readonly object _syncRoot; // 0x10
	private Color _baseColor; // 0x18
	private Nullable<float> _pulseDuration; // 0x28
	private Color _pulseColor; // 0x30
	private readonly Stopwatch _pulseTimer; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsConnected>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <ColorCorrection>k__BackingField; // 0x4C

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }

	// Methods

	// RVA: 0x21BAB90 Offset: 0x21B9F90 VA: 0x1821BAB90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BAC60 Offset: 0x21BA060 VA: 0x1821BAC60 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BAC80 Offset: 0x21BA080 VA: 0x1821BAC80 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	// RVA: 0x21BA0E0 Offset: 0x21B94E0 VA: 0x1821BA0E0 Slot: 7
	public ValueTask Start() { }

	// RVA: 0x21BA6B0 Offset: 0x21B9AB0 VA: 0x1821BA6B0 Slot: 8
	public ValueTask Stop() { }

	// RVA: 0x21BAAC0 Offset: 0x21B9EC0 VA: 0x1821BAAC0 Slot: 9
	public ValueTask Update() { }

	// RVA: 0x21BA520 Offset: 0x21B9920 VA: 0x1821BA520 Slot: 10
	public void StaticColor(Color color) { }

	// RVA: 0x21B9B70 Offset: 0x21B8F70 VA: 0x1821B9B70 Slot: 11
	public void PulseColor(Color color, float duration) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public void Event(RgbEventType type) { }

	// RVA: 0x21B99E0 Offset: 0x21B8DE0 VA: 0x1821B99E0
	private void CalculateAndRenderColor() { }

	// RVA: 0x21B9D60 Offset: 0x21B9160 VA: 0x1821B9D60
	private static void SetColor(Color32 color) { }

	// RVA: 0x21B9B50 Offset: 0x21B8F50 VA: 0x1821B9B50
	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BA8F0 Offset: 0x21B9CF0 VA: 0x1821BA8F0
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BA860 Offset: 0x21B9C60 VA: 0x1821BA860
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

