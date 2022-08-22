public class SAMSite : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimDir; // 0x14


	public static void ResetToPool(SAMSite instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SAMSite instance) { }

	public SAMSite Copy() { }

	public static SAMSite Deserialize(Stream stream) { }

	public static SAMSite DeserializeLengthDelimited(Stream stream) { }

	public static SAMSite DeserializeLength(Stream stream, int length) { }

	public static SAMSite Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SAMSite previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SAMSite Deserialize(byte[] buffer, SAMSite instance, bool isDelta = False) { }

	public static SAMSite Deserialize(Stream stream, SAMSite instance, bool isDelta) { }

	public static SAMSite DeserializeLengthDelimited(Stream stream, SAMSite instance, bool isDelta) { }

	public static SAMSite DeserializeLength(Stream stream, int length, SAMSite instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SAMSite instance, SAMSite previous) { }

	public static void Serialize(Stream stream, SAMSite instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SAMSite instance) { }

	public static void SerializeLengthDelimited(Stream stream, SAMSite instance) { }

	public void .ctor() { }

}

public class SamSite : ContainerIOEntity // TypeDefIndex: 8441
{	private Option __menuOption_Menu_DisableDefenderMode; // 0x378
	private Option __menuOption_Menu_EnableDefenderMode; // 0x3D0
	public Animator pitchAnimator; // 0x428
	public GameObject yaw; // 0x430
	public GameObject pitch; // 0x438
	public GameObject gear; // 0x440
	public Transform eyePoint; // 0x448
	public float gearEpislonDegrees; // 0x450
	public float turnSpeed; // 0x454
	public float clientLerpSpeed; // 0x458
	public Vector3 currentAimDir; // 0x45C
	public Vector3 targetAimDir; // 0x468
	public float vehicleScanRadius; // 0x474
	public float missileScanRadius; // 0x478
	public GameObjectRef projectileTest; // 0x480
	public GameObjectRef muzzleFlashTest; // 0x488
	public bool staticRespawn; // 0x490
	public ItemDefinition ammoType; // 0x498
	public Transform[] tubes; // 0x4A0
	[ServerVar] // RVA: 0x81720 Offset: 0x80B20 VA: 0x180081720
	public static float staticrepairseconds; // 0x0
	public SoundDefinition yawMovementLoopDef; // 0x4A8
	public float yawGainLerp; // 0x4B0
	public float yawGainMovementSpeedMult; // 0x4B4
	public SoundDefinition pitchMovementLoopDef; // 0x4B8
	public float pitchGainLerp; // 0x4C0
	public float pitchGainMovementSpeedMult; // 0x4C4
	public int lowAmmoThreshold; // 0x4C8
	public BaseEntity.Flags Flag_DefenderMode; // 0x4CC
	private Sound yawMovementLoop; // 0x4D0
	private Sound pitchMovementLoop; // 0x4D8
	private SoundModulation.Modulator yawGainModulator; // 0x4E0
	private SoundModulation.Modulator pitchGainModulator; // 0x4E8
	private float previousYawAngle; // 0x4F0
	private float previousPitchAngle; // 0x4F4

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool IsPowered() { }

	public override int ConsumptionAmount() { }

	public bool IsInDefenderMode() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateClientTargetAimDir(Vector3 aimDir) { }

	public void SetClientAim(Vector3 aimDir) { }

	public void Update() { }

	private void UpdateSounds() { }

	protected override void DoClientDestroy() { }

	[BaseEntity.Menu] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.Description] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.Icon] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.ShowIf] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	private void Menu_EnableDefenderMode(BasePlayer player) { }

	private bool Menu_EnableDefenderMode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.Description] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.Icon] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.ShowIf] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	private void Menu_DisableDefenderMode(BasePlayer player) { }

	private bool Menu_DisableDefenderMode_ShowIf(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

