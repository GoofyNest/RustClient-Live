public class SubmarineDuo : BaseSubmarine // TypeDefIndex: 10179
{
	private Option __menuOption_Menu_SwapSeats;
	[HeaderAttribute]
	[SerializeField]
	private Transform steeringWheel;
	[SerializeField]
	private Transform steeringWheelLeftGrip;
	[SerializeField]
	private Transform steeringWheelRightGrip;
	[SerializeField]
	private Transform leftPedal;
	[SerializeField]
	private Transform rightPedal;
	[SerializeField]
	private Transform driverLeftFoot;
	[SerializeField]
	private Transform driverRightFoot;
	[SerializeField]
	private Transform mphNeedle;
	[SerializeField]
	private Transform fuelNeedle;
	[SerializeField]
	private Transform waterDepthNeedle;
	[SerializeField]
	private Transform ammoFlag;
	[SerializeField]
	private SubmarineSonar sonar;
	[SerializeField]
	private Transform torpedoTubeHatch;
	private float smoothedSpeed;
	private float flagLerp;
	private SubmarineDuo.FlagState flagState;
	private const float FLAG_DOWN_ANGLE = 0;
	private const float FLAG_UP_ANGLE = 90;
	private bool torpedoJustFired;
	private SubmarineDuo.TorpedoDoorState torpedoDoorState;
	private const float TORPEDO_DOOR_CLOSED_ANGLE = 0;
	private const float TORPEDO_DOOR_OPEN_ANGLE = 230;
	private const float TORPEDO_OPEN_SPEED = 1100;
	private const float TORPEDO_CLOSE_SPEED = 450;
	private Vector3 torpedoVec;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	protected override bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	protected override bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	protected override void TorpedoFired() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_SwapSeats(BasePlayer player) { }

	public bool Menu_SwapSeats_ShowIf(BasePlayer player) { }

	protected override bool Menu_Occupied_ShowIf(BasePlayer player) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	internal static Vector3 <UpdateInteriorVisuals>g__SetGauge|31_0(Vector3 localAngles, float amount, float maxReading, float maxDegrees, bool zAxis) { }

}

private enum SubmarineDuo.FlagState // TypeDefIndex: 10180
{
	public int value__;
	public const SubmarineDuo.FlagState Down = 0;
	public const SubmarineDuo.FlagState Up = 1;
	public const SubmarineDuo.FlagState MovingUp = 2;
	public const SubmarineDuo.FlagState MovingDown = 3;

}

private enum SubmarineDuo.TorpedoDoorState // TypeDefIndex: 10181
{
	public int value__;
	public const SubmarineDuo.TorpedoDoorState Closed = 0;
	public const SubmarineDuo.TorpedoDoorState Closing = 1;
	public const SubmarineDuo.TorpedoDoorState Opening = 2;

}

