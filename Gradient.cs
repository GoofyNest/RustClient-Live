public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xA9A40 Offset: 0xA8E40 VA: 0x1800A9A40
	// RVA: 0x18274E0 Offset: 0x18268E0 VA: 0x1818274E0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9B00 Offset: 0xA8F00 VA: 0x1800A9B00
	// RVA: 0x1827110 Offset: 0x1826510 VA: 0x181827110
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9B70 Offset: 0xA8F70 VA: 0x1800A9B70
	// RVA: 0x1827510 Offset: 0x1826910 VA: 0x181827510
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18275C0 Offset: 0x18269C0 VA: 0x1818275C0
	public void .ctor() { }

	// RVA: 0x1827430 Offset: 0x1826830 VA: 0x181827430 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9C70 Offset: 0xA9070 VA: 0x1800A9C70
	// RVA: 0x18273D0 Offset: 0x18267D0 VA: 0x1818273D0
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9CB0 Offset: 0xA90B0 VA: 0x1800A9CB0
	// RVA: 0x1827640 Offset: 0x1826A40 VA: 0x181827640
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xA9DD0 Offset: 0xA91D0 VA: 0x1800A9DD0
	// RVA: 0x1827600 Offset: 0x1826A00 VA: 0x181827600
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xA9EC0 Offset: 0xA92C0 VA: 0x1800A9EC0
	// RVA: 0x1827560 Offset: 0x1826960 VA: 0x181827560
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x1827150 Offset: 0x1826550 VA: 0x181827150 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18272B0 Offset: 0x18266B0 VA: 0x1818272B0 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x1817320 Offset: 0x1816720 VA: 0x181817320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1827370 Offset: 0x1826770 VA: 0x181827370
	private void Evaluate_Injected(float time, out Color ret) { }

}

