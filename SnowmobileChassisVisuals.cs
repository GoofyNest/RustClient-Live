public class SnowmobileChassisVisuals : VehicleChassisVisuals<Snowmobile>, IClientComponent // TypeDefIndex: 9757
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x5CBE90 Offset: 0x5CB290 VA: 0x1805CBE90 Slot: 4
	public override void Init(Snowmobile owner, VehicleChassisVisuals.ClientWheelData<Snowmobile>[] clientWheelData) { }

	// RVA: 0x5CCD70 Offset: 0x5CC170 VA: 0x1805CCD70 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x5CBFE0 Offset: 0x5CB3E0 VA: 0x1805CBFE0 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x5CCED0 Offset: 0x5CC2D0 VA: 0x1805CCED0 Slot: 8
	protected override void StopAll() { }

	// RVA: 0x5CD060 Offset: 0x5CC460 VA: 0x1805CD060 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x5CCD80 Offset: 0x5CC180 VA: 0x1805CCD80
	private void SetSuspensionExtension(Transform visualWheel, Vector3 restingLocalPos, float extension, float prevExtension, float maxVisualExtension, float updateSpeed, float dt, bool reverse) { }

	// RVA: 0x5CBE20 Offset: 0x5CB220 VA: 0x1805CBE20
	private void InitAnim() { }

	// RVA: 0x5CD700 Offset: 0x5CCB00 VA: 0x1805CD700
	public void .ctor() { }

	// RVA: 0x5CD640 Offset: 0x5CCA40 VA: 0x1805CD640
	private static void .cctor() { }

}

private class SnowmobileChassisVisuals.TreadRenderer // TypeDefIndex: 9758
{	// Fields
	public Renderer renderer; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

