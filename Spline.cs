public sealed class Spline // TypeDefIndex: 11867
{	public const int k_Precision = 128;
	public const float k_Step = 0,0078125;
	public AnimationCurve curve; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Loop; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_ZeroValue; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Range; // 0x20
	private AnimationCurve m_InternalLoopingCurve; // 0x28
	private int frameCount; // 0x30
	public float[] cachedData; // 0x38


	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	public void Cache(int frame) { }

	public float Evaluate(float t, int length) { }

	public float Evaluate(float t) { }

	public override int GetHashCode() { }

}

