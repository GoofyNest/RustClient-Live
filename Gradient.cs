public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3465
{
	internal IntPtr m_Ptr;

	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }


	[FreeFunctionAttribute]
	private static IntPtr Init() { }

	[FreeFunctionAttribute]
	private void Cleanup() { }

	[FreeFunctionAttribute]
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute]
	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute]
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute]
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute]
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	public override bool Equals(object o) { }

	public bool Equals(Gradient other) { }

	public override int GetHashCode() { }

	private void Evaluate_Injected(float time, out Color ret) { }

}

