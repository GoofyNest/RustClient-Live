public class SAMSite : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimDir; // 0x14

	// Methods

	// RVA: 0x1E01DF0 Offset: 0x1E011F0 VA: 0x181E01DF0
	public static void ResetToPool(SAMSite instance) { }

	// RVA: 0x1E01D70 Offset: 0x1E01170 VA: 0x181E01D70
	public void ResetToPool() { }

	// RVA: 0x1E01C40 Offset: 0x1E01040 VA: 0x181E01C40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB2EF0 Offset: 0x1DB22F0 VA: 0x181DB2EF0
	public void CopyTo(SAMSite instance) { }

	// RVA: 0x1E012C0 Offset: 0x1E006C0 VA: 0x181E012C0
	public SAMSite Copy() { }

	// RVA: 0x1E01BC0 Offset: 0x1E00FC0 VA: 0x181E01BC0
	public static SAMSite Deserialize(Stream stream) { }

	// RVA: 0x1E01330 Offset: 0x1E00730 VA: 0x181E01330
	public static SAMSite DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E017C0 Offset: 0x1E00BC0 VA: 0x181E017C0
	public static SAMSite DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E01AA0 Offset: 0x1E00EA0 VA: 0x181E01AA0
	public static SAMSite Deserialize(byte[] buffer) { }

	// RVA: 0x1E01D30 Offset: 0x1E01130 VA: 0x181E01D30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E023F0 Offset: 0x1E017F0 VA: 0x181E023F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E02410 Offset: 0x1E01810 VA: 0x181E02410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SAMSite previous) { }

	// RVA: 0x1E01D50 Offset: 0x1E01150 VA: 0x181E01D50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E01850 Offset: 0x1E00C50 VA: 0x181E01850
	public static SAMSite Deserialize(byte[] buffer, SAMSite instance, bool isDelta = False) { }

	// RVA: 0x1E01950 Offset: 0x1E00D50 VA: 0x181E01950
	public static SAMSite Deserialize(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E013B0 Offset: 0x1E007B0 VA: 0x181E013B0
	public static SAMSite DeserializeLengthDelimited(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E015D0 Offset: 0x1E009D0 VA: 0x181E015D0
	public static SAMSite DeserializeLength(Stream stream, int length, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E01E70 Offset: 0x1E01270 VA: 0x181E01E70
	public static void SerializeDelta(Stream stream, SAMSite instance, SAMSite previous) { }

	// RVA: 0x1E02270 Offset: 0x1E01670 VA: 0x181E02270
	public static void Serialize(Stream stream, SAMSite instance) { }

	// RVA: 0x1E023E0 Offset: 0x1E017E0 VA: 0x181E023E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E023F0 Offset: 0x1E017F0 VA: 0x181E023F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E02160 Offset: 0x1E01560 VA: 0x181E02160
	public static byte[] SerializeToBytes(SAMSite instance) { }

	// RVA: 0x1E020B0 Offset: 0x1E014B0 VA: 0x181E020B0
	public static void SerializeLengthDelimited(Stream stream, SAMSite instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SamSite : ContainerIOEntity // TypeDefIndex: 8441
{	// Fields
	private Option __menuOption_Menu_DisableDefenderMode; // 0x378
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x49AC30 Offset: 0x49A030 VA: 0x18049AC30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49C170 Offset: 0x49B570 VA: 0x18049C170 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x49B3F0 Offset: 0x49A7F0 VA: 0x18049B3F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49B200 Offset: 0x49A600 VA: 0x18049B200 Slot: 153
	public override bool IsPowered() { }

	// RVA: 0x49AAE0 Offset: 0x499EE0 VA: 0x18049AAE0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x49B1F0 Offset: 0x49A5F0 VA: 0x18049B1F0
	public bool IsInDefenderMode() { }

	// RVA: 0x49B220 Offset: 0x49A620 VA: 0x18049B220 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49B730 Offset: 0x49AB30 VA: 0x18049B730
	public void UpdateClientTargetAimDir(Vector3 aimDir) { }

	// RVA: 0x49B4E0 Offset: 0x49A8E0 VA: 0x18049B4E0
	public void SetClientAim(Vector3 aimDir) { }

	// RVA: 0x49BEB0 Offset: 0x49B2B0 VA: 0x18049BEB0
	public void Update() { }

	// RVA: 0x49B750 Offset: 0x49AB50 VA: 0x18049B750
	private void UpdateSounds() { }

	// RVA: 0x49AAF0 Offset: 0x499EF0 VA: 0x18049AAF0 Slot: 19
	protected override void DoClientDestroy() { }

	[BaseEntity.Menu] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.Description] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.Icon] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	[BaseEntity.Menu.ShowIf] // RVA: 0x81800 Offset: 0x80C00 VA: 0x180081800
	// RVA: 0x49B3A0 Offset: 0x49A7A0 VA: 0x18049B3A0
	private void Menu_EnableDefenderMode(BasePlayer player) { }

	// RVA: 0x49B340 Offset: 0x49A740 VA: 0x18049B340
	private bool Menu_EnableDefenderMode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.Description] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.Icon] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	[BaseEntity.Menu.ShowIf] // RVA: 0x81A10 Offset: 0x80E10 VA: 0x180081A10
	// RVA: 0x49B2F0 Offset: 0x49A6F0 VA: 0x18049B2F0
	private void Menu_DisableDefenderMode(BasePlayer player) { }

	// RVA: 0x49B2A0 Offset: 0x49A6A0 VA: 0x18049B2A0
	private bool Menu_DisableDefenderMode_ShowIf(BasePlayer player) { }

	// RVA: 0x49C060 Offset: 0x49B460 VA: 0x18049C060
	public void .ctor() { }

	// RVA: 0x49C020 Offset: 0x49B420 VA: 0x18049C020
	private static void .cctor() { }

}

