public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	internal IntPtr m_Ptr; // 0x10

	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }


	[FreeFunctionAttribute] // RVA: 0xA9A40 Offset: 0xA8E40 VA: 0x1800A9A40
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9B00 Offset: 0xA8F00 VA: 0x1800A9B00
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9B70 Offset: 0xA8F70 VA: 0x1800A9B70
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9C70 Offset: 0xA9070 VA: 0x1800A9C70
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9CB0 Offset: 0xA90B0 VA: 0x1800A9CB0
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xA9DD0 Offset: 0xA91D0 VA: 0x1800A9DD0
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xA9EC0 Offset: 0xA92C0 VA: 0x1800A9EC0
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	public override bool Equals(object o) { }

	public bool Equals(Gradient other) { }

	public override int GetHashCode() { }

	private void Evaluate_Injected(float time, out Color ret) { }

}

