public class SubmarineSonar : FacepunchBehaviour // TypeDefIndex: 11675
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float range; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem sonarPS; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem blipPS; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SonarObject us; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color greenBlip; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color redBlip; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color whiteBlip; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SubmarineAudio submarineAudio; // 0x68
	private List<SubmarineSonar.SonarBlip> currentlyInRange; // 0x70
	private float rangeSqr; // 0x78
	private const float SWEEP_DURATION = 1;
	private TimeSince timeSinceLastRefresh; // 0x7C
	private float sonarAngle; // 0x80
	private int blipIndex; // 0x84
	private float scale; // 0x88
	private float blipSize; // 0x8C
	private Vector3 ourRefreshHeading; // 0x90
	private ParticleSystem.EmitParams emitParams; // 0x9C
	private const float MOONPOOL_MIN = 2;
	private const float MOONPOOL_MAX = 6;


	protected void Awake() { }

	public void UpdateTick() { }

	private float GetAngleChangeSinceRefresh() { }

	private void Refresh(List<SubmarineSonar.SonarBlip> extras) { }

	private Color GetBlipColour(SonarObject.SType type, float distance) { }

	private static float GetBlipScale(SonarObject.SType type, float distance) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <UpdateTick>g__GetCurrentBlipAngle|20_0(SubmarineSonar.SonarBlip nextBlip) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <UpdateTick>g__ShowBlip|20_1(SubmarineSonar.SonarBlip nextBlip, float nextAngle) { }

}

private struct SubmarineSonar.SonarBlip : IComparable<SubmarineSonar.SonarBlip> // TypeDefIndex: 11676
{	public readonly Color colour; // 0x0
	public readonly float dist; // 0x10
	public readonly float scale; // 0x14
	public float angle; // 0x18
	public bool orphan; // 0x1C


	public void .ctor(float dist, float angle, Color colour, float scale = 1) { }

	public int CompareTo(SubmarineSonar.SonarBlip other) { }

}

