public class SubmarineDuo : BaseSubmarine // TypeDefIndex: 8458
{	// Fields
	private Option __menuOption_Menu_SwapSeats; // 0x6F8
	[HeaderAttribute] // RVA: 0x8E580 Offset: 0x8D980 VA: 0x18008E580
	[SerializeField] // RVA: 0x8E580 Offset: 0x8D980 VA: 0x18008E580
	private Transform steeringWheel; // 0x750
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform steeringWheelLeftGrip; // 0x758
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform steeringWheelRightGrip; // 0x760
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftPedal; // 0x768
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightPedal; // 0x770
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform driverLeftFoot; // 0x778
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform driverRightFoot; // 0x780
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform mphNeedle; // 0x788
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform fuelNeedle; // 0x790
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform waterDepthNeedle; // 0x798
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform ammoFlag; // 0x7A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SubmarineSonar sonar; // 0x7A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform torpedoTubeHatch; // 0x7B0
	private float smoothedSpeed; // 0x7B8
	private float flagLerp; // 0x7BC
	private SubmarineDuo.FlagState flagState; // 0x7C0
	private const float FLAG_DOWN_ANGLE = 0;
	private const float FLAG_UP_ANGLE = 90;
	private bool torpedoJustFired; // 0x7C4
	private SubmarineDuo.TorpedoDoorState torpedoDoorState; // 0x7C8
	private const float TORPEDO_DOOR_CLOSED_ANGLE = 0;
	private const float TORPEDO_DOOR_OPEN_ANGLE = 230;
	private const float TORPEDO_OPEN_SPEED = 1100;
	private const float TORPEDO_CLOSE_SPEED = 450;
	private Vector3 torpedoVec; // 0x7CC

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7A02B0 Offset: 0x79F6B0 VA: 0x1807A02B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A17C0 Offset: 0x7A0BC0 VA: 0x1807A17C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A0B40 Offset: 0x79FF40 VA: 0x1807A0B40 Slot: 197
	protected override bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A0910 Offset: 0x79FD10 VA: 0x1807A0910 Slot: 198
	protected override bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A1400 Offset: 0x7A0800 VA: 0x1807A1400 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7A0840 Offset: 0x79FC40 VA: 0x1807A0840 Slot: 199
	protected override void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	[BaseEntity.Menu.Description] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	[BaseEntity.Menu.Icon] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	[BaseEntity.Menu.ShowIf] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	// RVA: 0x7A07B0 Offset: 0x79FBB0 VA: 0x1807A07B0
	public void Menu_SwapSeats(BasePlayer player) { }

	// RVA: 0x7A0700 Offset: 0x79FB00 VA: 0x1807A0700
	public bool Menu_SwapSeats_ShowIf(BasePlayer player) { }

	// RVA: 0x7A05C0 Offset: 0x79F9C0 VA: 0x1807A05C0 Slot: 190
	protected override bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x7A1720 Offset: 0x7A0B20 VA: 0x1807A1720
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7A0860 Offset: 0x79FC60 VA: 0x1807A0860
	internal static Vector3 <UpdateInteriorVisuals>g__SetGauge|31_0(Vector3 localAngles, float amount, float maxReading, float maxDegrees, bool zAxis) { }

}

private enum SubmarineDuo.FlagState // TypeDefIndex: 8459
{	// Fields
	public int value__; // 0x0
	public const SubmarineDuo.FlagState Down = 0;
	public const SubmarineDuo.FlagState Up = 1;
	public const SubmarineDuo.FlagState MovingUp = 2;
	public const SubmarineDuo.FlagState MovingDown = 3;

}

private enum SubmarineDuo.TorpedoDoorState // TypeDefIndex: 8460
{	// Fields
	public int value__; // 0x0
	public const SubmarineDuo.TorpedoDoorState Closed = 0;
	public const SubmarineDuo.TorpedoDoorState Closing = 1;
	public const SubmarineDuo.TorpedoDoorState Opening = 2;

}

