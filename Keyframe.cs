public struct Keyframe // TypeDefIndex: 3351
{
	private float m_Time; 
	private float m_Value; 
	private float m_InTangent; 
	private float m_OutTangent; 
	private int m_WeightedMode; 
	private float m_InWeight; 
	private float m_OutWeight; 

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

