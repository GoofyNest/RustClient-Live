public struct Keyframe // TypeDefIndex: 3351
{	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; }
	public float inTangent { set; }
	public float outTangent { set; }

	// Methods

	// RVA: 0x215930 Offset: 0x214D30 VA: 0x180215930
	public void .ctor(float time, float value) { }

	// RVA: 0x215950 Offset: 0x214D50 VA: 0x180215950
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_time() { }

	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280
	public void set_time(float value) { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_value() { }

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void set_inTangent(float value) { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_outTangent(float value) { }

}

