public struct Keyframe // TypeDefIndex: 3351
{	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	public float time { get; set; }
	public float value { get; }
	public float inTangent { set; }
	public float outTangent { set; }


	public void .ctor(float time, float value) { }

	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	public float get_time() { }

	public void set_time(float value) { }

	public float get_value() { }

	public void set_inTangent(float value) { }

	public void set_outTangent(float value) { }

}

