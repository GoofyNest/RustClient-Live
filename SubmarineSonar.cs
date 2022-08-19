public class SubmarineSonar : FacepunchBehaviour // TypeDefIndex: 11675
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x5DCE80 Offset: 0x5DC280 VA: 0x1805DCE80
	protected void Awake() { }

	// RVA: 0x5DDA40 Offset: 0x5DCE40 VA: 0x1805DDA40
	public void UpdateTick() { }

	// RVA: 0x5DCF30 Offset: 0x5DC330 VA: 0x1805DCF30
	private float GetAngleChangeSinceRefresh() { }

	// RVA: 0x5DD230 Offset: 0x5DC630 VA: 0x1805DD230
	private void Refresh(List<SubmarineSonar.SonarBlip> extras) { }

	// RVA: 0x5DD030 Offset: 0x5DC430 VA: 0x1805DD030
	private Color GetBlipColour(SonarObject.SType type, float distance) { }

	// RVA: 0x5DD160 Offset: 0x5DC560 VA: 0x1805DD160
	private static float GetBlipScale(SonarObject.SType type, float distance) { }

	// RVA: 0x5DDDC0 Offset: 0x5DD1C0 VA: 0x1805DDDC0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DD710 Offset: 0x5DCB10 VA: 0x1805DD710
	private float <UpdateTick>g__GetCurrentBlipAngle|20_0(SubmarineSonar.SonarBlip nextBlip) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DD840 Offset: 0x5DCC40 VA: 0x1805DD840
	private void <UpdateTick>g__ShowBlip|20_1(SubmarineSonar.SonarBlip nextBlip, float nextAngle) { }

}

private struct SubmarineSonar.SonarBlip : IComparable<SubmarineSonar.SonarBlip> // TypeDefIndex: 11676
{	// Fields
	public readonly Color colour; // 0x0
	public readonly float dist; // 0x10
	public readonly float scale; // 0x14
	public float angle; // 0x18
	public bool orphan; // 0x1C

	// Methods

	// RVA: 0xF35E0 Offset: 0xF29E0 VA: 0x1800F35E0
	public void .ctor(float dist, float angle, Color colour, float scale = 1) { }

	// RVA: 0xF35C0 Offset: 0xF29C0 VA: 0x1800F35C0 Slot: 4
	public int CompareTo(SubmarineSonar.SonarBlip other) { }

}

