public class SubmarineSonar : FacepunchBehaviour // TypeDefIndex: 13416
{
	[SerializeField] 
	private float range; 
	[SerializeField] 
	private ParticleSystem sonarPS; 
	[SerializeField] 
	private ParticleSystem blipPS; 
	[SerializeField] 
	private SonarObject us; 
	[SerializeField] 
	private Color greenBlip; 
	[SerializeField] 
	private Color redBlip; 
	[SerializeField] 
	private Color whiteBlip; 
	[SerializeField] 
	private SubmarineAudio submarineAudio; 
	private List<SubmarineSonar.SonarBlip> currentlyInRange; 
	private float rangeSqr; 
	private const float SWEEP_DURATION = 1;
	private TimeSince timeSinceLastRefresh; 
	private float sonarAngle; 
	private int blipIndex; 
	private float scale; 
	private float blipSize; 
	private Vector3 ourRefreshHeading; 
	private ParticleSystem.EmitParams emitParams; 
	private const float MOONPOOL_MIN = 2;
	private const float MOONPOOL_MAX = 6;


	protected void Awake() { }

	public void UpdateTick() { }

	private float GetAngleChangeSinceRefresh() { }

	private void Refresh(List<SubmarineSonar.SonarBlip> extras) { }

	private Color GetBlipColour(SonarObject.SType type, float distance) { }

	private static float GetBlipScale(SonarObject.SType type, float distance) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private float <UpdateTick>g__GetCurrentBlipAngle|20_0(SubmarineSonar.SonarBlip nextBlip) { }

	[CompilerGeneratedAttribute] 
	private void <UpdateTick>g__ShowBlip|20_1(SubmarineSonar.SonarBlip nextBlip, float nextAngle) { }

}

private struct SubmarineSonar.SonarBlip : IComparable<SubmarineSonar.SonarBlip> // TypeDefIndex: 13417
{
	public readonly Color colour; 
	public readonly float dist; 
	public readonly float scale; 
	public float angle; 
	public bool orphan; 


	public void .ctor(float dist, float angle, Color colour, float scale = 1) { }

	public int CompareTo(SubmarineSonar.SonarBlip other) { }

}

