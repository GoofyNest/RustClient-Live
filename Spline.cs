public sealed class Spline // TypeDefIndex: 11867
{	// Fields
	public const int k_Precision = 128;
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

	// Methods

	// RVA: 0x11DAFD0 Offset: 0x11DA3D0 VA: 0x1811DAFD0
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x11DAC30 Offset: 0x11DA030 VA: 0x1811DAC30
	public void Cache(int frame) { }

	// RVA: 0x11DAF60 Offset: 0x11DA360 VA: 0x1811DAF60
	public float Evaluate(float t, int length) { }

	// RVA: 0x11DAEF0 Offset: 0x11DA2F0 VA: 0x1811DAEF0
	public float Evaluate(float t) { }

	// RVA: 0x11DAFA0 Offset: 0x11DA3A0 VA: 0x1811DAFA0 Slot: 2
	public override int GetHashCode() { }

}

