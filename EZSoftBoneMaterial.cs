public class EZSoftBoneMaterial : ScriptableObject // TypeDefIndex: 7136
{	// Fields
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
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

	// Properties
	public float damping { get; set; }
	public AnimationCurve dampingCurve { get; }
	public float stiffness { get; set; }
	public AnimationCurve stiffnessCurve { get; }
	public float resistance { get; set; }
	public AnimationCurve resistanceCurve { get; }
	public float slackness { get; set; }
	public AnimationCurve slacknessCurve { get; }
	public static EZSoftBoneMaterial defaultMaterial { get; }

	// Methods

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_damping() { }

	// RVA: 0x228A480 Offset: 0x2289880 VA: 0x18228A480
	public void set_damping(float value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public AnimationCurve get_dampingCurve() { }

	// RVA: 0x93F110 Offset: 0x93E510 VA: 0x18093F110
	public float get_stiffness() { }

	// RVA: 0x228A5D0 Offset: 0x22899D0 VA: 0x18228A5D0
	public void set_stiffness(float value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public AnimationCurve get_stiffnessCurve() { }

	// RVA: 0x10B2CD0 Offset: 0x10B20D0 VA: 0x1810B2CD0
	public float get_resistance() { }

	// RVA: 0x228A4F0 Offset: 0x22898F0 VA: 0x18228A4F0
	public void set_resistance(float value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public AnimationCurve get_resistanceCurve() { }

	// RVA: 0x709DE0 Offset: 0x7091E0 VA: 0x180709DE0
	public float get_slackness() { }

	// RVA: 0x228A560 Offset: 0x2289960 VA: 0x18228A560
	public void set_slackness(float value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public AnimationCurve get_slacknessCurve() { }

	// RVA: 0x228A3B0 Offset: 0x22897B0 VA: 0x18228A3B0
	public static EZSoftBoneMaterial get_defaultMaterial() { }

	// RVA: 0x2233B10 Offset: 0x2232F10 VA: 0x182233B10
	public float GetDamping(float t) { }

	// RVA: 0x2233BD0 Offset: 0x2232FD0 VA: 0x182233BD0
	public float GetStiffness(float t) { }

	// RVA: 0x2233B50 Offset: 0x2232F50 VA: 0x182233B50
	public float GetResistance(float t) { }

	// RVA: 0x2233B90 Offset: 0x2232F90 VA: 0x182233B90
	public float GetSlackness(float t) { }

	// RVA: 0x2233C10 Offset: 0x2233010 VA: 0x182233C10
	public void .ctor() { }

}

