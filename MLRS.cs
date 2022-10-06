public class MLRS : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 targetPos; 
	public Vector3 curHitPos; 
	public uint rocketStorageID; 
	public uint dashboardStorageID; 
	public uint ammoCount; 


	public static void ResetToPool(MLRS instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MLRS instance) { }

	public MLRS Copy() { }

	public static MLRS Deserialize(Stream stream) { }

	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	public static MLRS DeserializeLength(Stream stream, int length) { }

	public static MLRS Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	public static void Serialize(Stream stream, MLRS instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MLRS instance) { }

	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	public void .ctor() { }

}

public class MLRS : BaseMountable // TypeDefIndex: 10117
{
	private Option __menuOption_Menu_Cannot_Fire_Rockets; 
	private Option __menuOption_Menu_Fire_Rockets; 
	private Option __menuOption_Menu_Open_Dashboard_Storage; 
	private Option __menuOption_Menu_Open_Rocket_Storage; 
	private Option __menuOption_Menu_SetTarget; 
	private float targetHRot; 
	private float targetVRot; 
	private Nullable<Vector3> hydraulicsBaseLocalPos; 
	private Vector3 hingeTargetLocalRot; 
	private TimeSince timeSinceLightChange; 
	private bool fullscreenMapOpen; 
	[HeaderAttribute] 
	[SerializeField] 
	private GameObjectRef rocketStoragePrefab; 
	[SerializeField] 
	private GameObjectRef dashboardStoragePrefab; 
	[HeaderAttribute] 
	[SerializeField] 
	private Transform hRotator; 
	[SerializeField] 
	private float hRotSpeed; 
	[SerializeField] 
	private Transform vRotator; 
	[SerializeField] 
	private float vRotSpeed; 
	[SerializeField] 
	[RangeAttribute] 
	private float vRotMax; 
	[SerializeField] 
	private Transform hydraulics; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	[SerializeField] 
	public float minRange; 
	[TooltipAttribute] 
	[SerializeField] 
	public float targetAreaRadius; 
	[SerializeField] 
	private GameObjectRef mlrsRocket; 
	[SerializeField] 
	public Transform firingPoint; 
	[SerializeField] 
	private MLRS.RocketTube[] rocketTubes; 
	[HeaderAttribute] 
	[SerializeField] 
	private GameObject screensChild; 
	[SerializeField] 
	private Transform leftHandGrip; 
	[SerializeField] 
	private Transform leftJoystick; 
	[SerializeField] 
	private Transform rightHandGrip; 
	[SerializeField] 
	private Transform rightJoystick; 
	[SerializeField] 
	private Transform controlKnobHeight; 
	[SerializeField] 
	private Transform controlKnobAngle; 
	[SerializeField] 
	private GameObjectRef uiDialogPrefab; 
	[SerializeField] 
	private Light fireButtonLight; 
	[SerializeField] 
	private GameObject brokenDownEffect; 
	[SerializeField] 
	private ParticleSystem topScreenShutdown; 
	[SerializeField] 
	private ParticleSystem bottomScreenShutdown; 
	[ServerVar] 
	public static float brokenDownMinutes; 
	[CompilerGeneratedAttribute] 
	private Vector3 <UserTargetHitPos>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <TrueHitPos>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <CurGravityMultiplier>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <RocketAmmoCount>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsRealigning>k__BackingField; 
	public const BaseEntity.Flags FLAG_FIRING_ROCKETS = 16384;
	public const BaseEntity.Flags FLAG_HAS_AIMING_MODULE = 65536;
	private EntityRef rocketStorageInstance; 
	private EntityRef dashboardStorageInstance; 
	private float rocketBaseGravity; 
	private float rocketSpeed; 
	[CompilerGeneratedAttribute] 
	private float <RocketDamageRadius>k__BackingField; 
	private bool isInitialLoad; 

	public override bool HasMenuOptions { get; }
	public Vector3 UserTargetHitPos { get; set; }
	public Vector3 TrueHitPos { get; set; }
	public bool HasAimingModule { get; }
	private bool CanBeUsed { get; }
	private bool CanFire { get; }
	private float HRotation { get; set; }
	private float VRotation { get; set; }
	public float CurGravityMultiplier { get; set; }
	public int RocketAmmoCount { get; set; }
	public bool IsRealigning { get; set; }
	public bool IsFiringRockets { get; }
	public float RocketDamageRadius { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected void LateUpdate() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void SendNewTargetHitPos(Vector3 worldPos) { }

	protected override bool HideMenuItems(BasePlayer player) { }

	private void PositionVisuals() { }

	private void ShowFullscreenMap() { }

	public void OnFullscreenMapClosed() { }

	private bool ShouldShowDashboardUI() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetTarget(BasePlayer player) { }

	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Fire_Rockets(BasePlayer player) { }

	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] 
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] 
	private void set_TrueHitPos(Vector3 value) { }

	public bool get_HasAimingModule() { }

	private bool get_CanBeUsed() { }

	private bool get_CanFire() { }

	private float get_HRotation() { }

	private void set_HRotation(float value) { }

	private float get_VRotation() { }

	private void set_VRotation(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] 
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] 
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] 
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] 
	private void set_IsRealigning(bool value) { }

	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] 
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] 
	private void set_RocketDamageRadius(float value) { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	private void SetUserTargetHitPos(Vector3 worldPos) { }

	private StorageContainer GetRocketContainer() { }

	private StorageContainer GetDashboardContainer() { }

	private void HitPosToRotation(Vector3 hitPos, out float hRot, out float vRot, out float g) { }

	private Vector3 GetAimToTarget(Vector3 targetPos, out float g) { }

	private static float ProjectileDistToSpeed(float x, float y, float angle, float g, float fallbackV) { }

	private static float ProjectileDistToGravity(float x, float y, float θ, float v) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class MLRS.RocketTube // TypeDefIndex: 10118
{
	public Vector3 firingOffset; 
	public Transform hinge; 
	public Renderer rocket; 


	public void .ctor() { }

}

private struct MLRS.TheoreticalProjectile // TypeDefIndex: 10119
{
	public Vector3 pos; 
	public Vector3 forward; 
	public float gravityMult; 


	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

