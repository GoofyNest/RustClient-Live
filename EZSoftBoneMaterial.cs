public class EZSoftBoneMaterial : ScriptableObject // TypeDefIndex: 7136
{	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float m_Damping; // 0x18
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[EZCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve m_DampingCurve; // 0x20
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float m_Stiffness; // 0x28
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[EZCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve m_StiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float m_Resistance; // 0x38
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[EZCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve m_ResistanceCurve; // 0x40
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float m_Slackness; // 0x48
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[EZCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve m_SlacknessCurve; // 0x50
	private static EZSoftBoneMaterial m_DefaultMaterial; // 0x0

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

