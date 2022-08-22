public class BurstClothMaterial : ScriptableObject // TypeDefIndex: 7312
{	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
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

	public float Damping { get; set; }
	public AnimationCurve DampingCurve { get; }
	public float Stiffness { get; set; }
	public AnimationCurve StiffnessCurve { get; }
	public float Resistance { get; set; }
	public AnimationCurve ResistanceCurve { get; }
	public float Slackness { get; set; }
	public AnimationCurve SlacknessCurve { get; }
	public static BurstClothMaterial DefaultMaterial { get; }


	public float get_Damping() { }

	public void set_Damping(float value) { }

	public AnimationCurve get_DampingCurve() { }

	public float get_Stiffness() { }

	public void set_Stiffness(float value) { }

	public AnimationCurve get_StiffnessCurve() { }

	public float get_Resistance() { }

	public void set_Resistance(float value) { }

	public AnimationCurve get_ResistanceCurve() { }

	public float get_Slackness() { }

	public void set_Slackness(float value) { }

	public AnimationCurve get_SlacknessCurve() { }

	public static BurstClothMaterial get_DefaultMaterial() { }

	public float GetDamping(float t) { }

	public float GetStiffness(float t) { }

	public float GetResistance(float t) { }

	public float GetSlackness(float t) { }

	public void .ctor() { }

}

