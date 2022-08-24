public class BurstClothMaterial : ScriptableObject // TypeDefIndex: 7312
{
	[SerializeField] 
	[RangeAttribute] 
	private float _damping; 
	[SerializeField] 
	[BurstClothCurveRectAttribute] 
	private AnimationCurve _dampingCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float _stiffness; 
	[SerializeField] 
	[BurstClothCurveRectAttribute] 
	private AnimationCurve _stiffnessCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float _resistance; 
	[SerializeField] 
	[BurstClothCurveRectAttribute] 
	private AnimationCurve _resistanceCurve; 
	[SerializeField] 
	[RangeAttribute] 
	private float _slackness; 
	[SerializeField] 
	[BurstClothCurveRectAttribute] 
	private AnimationCurve _slacknessCurve; 
	private static BurstClothMaterial _defaultMaterial; 

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

