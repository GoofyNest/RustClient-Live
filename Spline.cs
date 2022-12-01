public sealed class Spline // TypeDefIndex: 13675
{
	public const int k_Precision = 128;
	public const float k_Step = 0,0078125;
	public AnimationCurve curve;
	[SerializeField]
	private bool m_Loop;
	[SerializeField]
	private float m_ZeroValue;
	[SerializeField]
	private float m_Range;
	private AnimationCurve m_InternalLoopingCurve;
	private int frameCount;
	public float[] cachedData;


	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	public void Cache(int frame) { }

	public float Evaluate(float t, int length) { }

	public float Evaluate(float t) { }

	public override int GetHashCode() { }

}

