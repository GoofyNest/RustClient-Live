public class BurstClothMaterial : ScriptableObject // TypeDefIndex: 7312
{	// Fields
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float _damping; // 0x18
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[BurstClothCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve _dampingCurve; // 0x20
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float _stiffness; // 0x28
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[BurstClothCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve _stiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float _resistance; // 0x38
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[BurstClothCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve _resistanceCurve; // 0x40
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float _slackness; // 0x48
	[SerializeField] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	[BurstClothCurveRectAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	private AnimationCurve _slacknessCurve; // 0x50
	private static BurstClothMaterial _defaultMaterial; // 0x0

	// Properties
	public float Damping { get; set; }
	public AnimationCurve DampingCurve { get; }
	public float Stiffness { get; set; }
	public AnimationCurve StiffnessCurve { get; }
	public float Resistance { get; set; }
	public AnimationCurve ResistanceCurve { get; }
	public float Slackness { get; set; }
	public AnimationCurve SlacknessCurve { get; }
	public static BurstClothMaterial DefaultMaterial { get; }

	// Methods

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_Damping() { }

	// RVA: 0x2233DD0 Offset: 0x22331D0 VA: 0x182233DD0
	public void set_Damping(float value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public AnimationCurve get_DampingCurve() { }

	// RVA: 0x93F110 Offset: 0x93E510 VA: 0x18093F110
	public float get_Stiffness() { }

	// RVA: 0x2233F20 Offset: 0x2233320 VA: 0x182233F20
	public void set_Stiffness(float value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public AnimationCurve get_StiffnessCurve() { }

	// RVA: 0x10B2CD0 Offset: 0x10B20D0 VA: 0x1810B2CD0
	public float get_Resistance() { }

	// RVA: 0x2233E40 Offset: 0x2233240 VA: 0x182233E40
	public void set_Resistance(float value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public AnimationCurve get_ResistanceCurve() { }

	// RVA: 0x709DE0 Offset: 0x7091E0 VA: 0x180709DE0
	public float get_Slackness() { }

	// RVA: 0x2233EB0 Offset: 0x22332B0 VA: 0x182233EB0
	public void set_Slackness(float value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public AnimationCurve get_SlacknessCurve() { }

	// RVA: 0x2233D00 Offset: 0x2233100 VA: 0x182233D00
	public static BurstClothMaterial get_DefaultMaterial() { }

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

