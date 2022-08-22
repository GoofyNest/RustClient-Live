public class SnowmobileChassisVisuals : VehicleChassisVisuals<Snowmobile>, IClientComponent // TypeDefIndex: 9757
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Animator animator; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SnowmobileAudio audioScript; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SnowmobileChassisVisuals.TreadRenderer[] treadRenderers; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float treadSpeedMultiplier; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool flipRightSkiExtension; // 0x4C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftSki; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftSkiPistonIn; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftSkiPistonOut; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightSki; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightSkiPistonIn; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightSkiPistonOut; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float skiVisualAdjust; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float treadVisualAdjust; // 0x84
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float skiVisualMaxExtension; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float treadVisualMaxExtension; // 0x8C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float wheelSizeVisualMultiplier; // 0x90
	private float treadExtension; // 0x94
	private float treadPrevExtension; // 0x98
	private Snowmobile snowmobile; // 0xA0
	private float treadRotation; // 0xA8
	private MaterialPropertyBlock mpb; // 0xB0
	private Vector4 savedST; // 0xB8
	private static int animTurn; // 0x0
	private static int animSpeedometer; // 0x4
	private static int animTachometer; // 0x8
	private static int animFuel; // 0xC
	private static int animTreadWheels; // 0x10
	private int animNeedleShakeIndex; // 0xC8
	private int animEngineOnIndex; // 0xCC
	private float steerPercent; // 0xD0


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

private class SnowmobileChassisVisuals.TreadRenderer // TypeDefIndex: 9758
{	public Renderer renderer; // 0x10
	public int materialIndex; // 0x18


	public void .ctor() { }

}

