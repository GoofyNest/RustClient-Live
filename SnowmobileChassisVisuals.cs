public class SnowmobileChassisVisuals : VehicleChassisVisuals<Snowmobile>, IClientComponent // TypeDefIndex: 11510
{
	[SerializeField]
	private Animator animator;
	[SerializeField]
	private SnowmobileAudio audioScript;
	[SerializeField]
	private SnowmobileChassisVisuals.TreadRenderer[] treadRenderers;
	[SerializeField]
	private float treadSpeedMultiplier;
	[SerializeField]
	private bool flipRightSkiExtension;
	[SerializeField]
	private Transform leftSki;
	[SerializeField]
	private Transform leftSkiPistonIn;
	[SerializeField]
	private Transform leftSkiPistonOut;
	[SerializeField]
	private Transform rightSki;
	[SerializeField]
	private Transform rightSkiPistonIn;
	[SerializeField]
	private Transform rightSkiPistonOut;
	[SerializeField]
	private float skiVisualAdjust;
	[SerializeField]
	private float treadVisualAdjust;
	[SerializeField]
	private float skiVisualMaxExtension;
	[SerializeField]
	private float treadVisualMaxExtension;
	[SerializeField]
	private float wheelSizeVisualMultiplier;
	private float treadExtension;
	private float treadPrevExtension;
	private Snowmobile snowmobile;
	private float treadRotation;
	private MaterialPropertyBlock mpb;
	private Vector4 savedST;
	private static int animTurn;
	private static int animSpeedometer;
	private static int animTachometer;
	private static int animFuel;
	private static int animTreadWheels;
	private int animNeedleShakeIndex;
	private int animEngineOnIndex;
	private float steerPercent;


	public override void Init(Snowmobile owner, VehicleChassisVisuals.ClientWheelData<Snowmobile>[] clientWheelData) { }

	protected override void PreWheelUpdateTick() { }

	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	protected override void StopAll() { }

	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, bool isOn, float steer, float dt) { }

	private void SetSuspensionExtension(Transform visualWheel, Vector3 restingLocalPos, float extension, float prevExtension, float maxVisualExtension, float updateSpeed, float dt, bool reverse) { }

	private void InitAnim() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class SnowmobileChassisVisuals.TreadRenderer // TypeDefIndex: 11511
{
	public Renderer renderer;
	public int materialIndex;


	public void .ctor() { }

}

