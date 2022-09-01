public class EZSoftBoneMaterial : ScriptableObject // TypeDefIndex: 7137
{
	[SerializeField] 
	[RangeAttribute] 
	private float m_Damping; 
	[SerializeField] 
	[EZCurveRectAttribute] 
	private AnimationCurve m_DampingCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float m_Stiffness; 
	[SerializeField] 
	[EZCurveRectAttribute] 
	private AnimationCurve m_StiffnessCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float m_Resistance; 
	[SerializeField] 
	[EZCurveRectAttribute] 
	private AnimationCurve m_ResistanceCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float m_Slackness; 
	[SerializeField] 
	[EZCurveRectAttribute] 
	private AnimationCurve m_SlacknessCurve; 
	private static EZSoftBoneMaterial m_DefaultMaterial; 

	public float damping { get; set; }
	public AnimationCurve dampingCurve { get; }
	public float stiffness { get; set; }
	public AnimationCurve stiffnessCurve { get; }
	public float resistance { get; set; }
	public AnimationCurve resistanceCurve { get; }
	public float slackness { get; set; }
	public AnimationCurve slacknessCurve { get; }
	public static EZSoftBoneMaterial defaultMaterial { get; }


	public float get_damping() { }

	public void set_damping(float value) { }

	public AnimationCurve get_dampingCurve() { }

	public float get_stiffness() { }

	public void set_stiffness(float value) { }

	public AnimationCurve get_stiffnessCurve() { }

	public float get_resistance() { }

	public void set_resistance(float value) { }

	public AnimationCurve get_resistanceCurve() { }

	public float get_slackness() { }

	public void set_slackness(float value) { }

	public AnimationCurve get_slacknessCurve() { }

	public static EZSoftBoneMaterial get_defaultMaterial() { }

	public float GetDamping(float t) { }

	public float GetStiffness(float t) { }

	public float GetResistance(float t) { }

	public float GetSlackness(float t) { }

	public void .ctor() { }

}

