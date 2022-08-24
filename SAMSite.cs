public class SAMSite : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 aimDir; 


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
{
	private Option __menuOption_Menu_DisableDefenderMode; 
	private Option __menuOption_Menu_EnableDefenderMode; 
	public Animator pitchAnimator; 
	public GameObject yaw; 
	public GameObject pitch; 
	public GameObject gear; 
	public Transform eyePoint; 
	public float gearEpislonDegrees; 
	public float turnSpeed; 
	public float clientLerpSpeed; 
	public Vector3 currentAimDir; 
	public Vector3 targetAimDir; 
	public float vehicleScanRadius; 
	public float missileScanRadius; 
	public GameObjectRef projectileTest; 
	public GameObjectRef muzzleFlashTest; 
	public bool staticRespawn; 
	public ItemDefinition ammoType; 
	public Transform[] tubes; 
	[ServerVar] 
	public static float staticrepairseconds; 
	public SoundDefinition yawMovementLoopDef; 
	public float yawGainLerp; 
	public float yawGainMovementSpeedMult; 
	public SoundDefinition pitchMovementLoopDef; 
	public float pitchGainLerp; 
	public float pitchGainMovementSpeedMult; 
	public int lowAmmoThreshold; 
	public BaseEntity.Flags Flag_DefenderMode; 
	private Sound yawMovementLoop; 
	private Sound pitchMovementLoop; 
	private SoundModulation.Modulator yawGainModulator; 
	private SoundModulation.Modulator pitchGainModulator; 
	private float previousYawAngle; 
	private float previousPitchAngle; 

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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	private void Menu_EnableDefenderMode(BasePlayer player) { }

	private bool Menu_EnableDefenderMode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	private void Menu_DisableDefenderMode(BasePlayer player) { }

	private bool Menu_DisableDefenderMode_ShowIf(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

