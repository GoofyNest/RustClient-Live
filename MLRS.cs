public class MLRS : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6422
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 targetPos; // 0x14
	public Vector3 curHitPos; // 0x20
	public uint rocketStorageID; // 0x2C
	public uint dashboardStorageID; // 0x30
	public uint ammoCount; // 0x34

	// Methods

	// RVA: 0x1F22B10 Offset: 0x1F21F10 VA: 0x181F22B10
	public static void ResetToPool(MLRS instance) { }

	// RVA: 0x1F22A50 Offset: 0x1F21E50 VA: 0x181F22A50
	public void ResetToPool() { }

	// RVA: 0x1F226A0 Offset: 0x1F21AA0 VA: 0x181F226A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F21390 Offset: 0x1F20790 VA: 0x181F21390
	public void CopyTo(MLRS instance) { }

	// RVA: 0x1F213E0 Offset: 0x1F207E0 VA: 0x181F213E0
	public MLRS Copy() { }

	// RVA: 0x1F21B90 Offset: 0x1F20F90 VA: 0x181F21B90
	public static MLRS Deserialize(Stream stream) { }

	// RVA: 0x1F21480 Offset: 0x1F20880 VA: 0x181F21480
	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F21B00 Offset: 0x1F20F00 VA: 0x181F21B00
	public static MLRS DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F22060 Offset: 0x1F21460 VA: 0x181F22060
	public static MLRS Deserialize(byte[] buffer) { }

	// RVA: 0x1F227E0 Offset: 0x1F21BE0 VA: 0x181F227E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F234F0 Offset: 0x1F228F0 VA: 0x181F234F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F23510 Offset: 0x1F22910 VA: 0x181F23510 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	// RVA: 0x1F22A30 Offset: 0x1F21E30 VA: 0x181F22A30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F22390 Offset: 0x1F21790 VA: 0x181F22390
	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	// RVA: 0x1F21E10 Offset: 0x1F21210 VA: 0x181F21E10
	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F21500 Offset: 0x1F20900 VA: 0x181F21500
	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F21810 Offset: 0x1F20C10 VA: 0x181F21810
	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	// RVA: 0x1F22BD0 Offset: 0x1F21FD0 VA: 0x181F22BD0
	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	// RVA: 0x1F23230 Offset: 0x1F22630 VA: 0x181F23230
	public static void Serialize(Stream stream, MLRS instance) { }

	// RVA: 0x1F234E0 Offset: 0x1F228E0 VA: 0x181F234E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F234F0 Offset: 0x1F228F0 VA: 0x181F234F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F23120 Offset: 0x1F22520 VA: 0x181F23120
	public static byte[] SerializeToBytes(MLRS instance) { }

	// RVA: 0x1F23070 Offset: 0x1F22470 VA: 0x181F23070
	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MLRS : BaseMountable // TypeDefIndex: 8412
{	// Fields
	private Option __menuOption_Menu_Cannot_Fire_Rockets; // 0x320
	private Option __menuOption_Menu_Fire_Rockets; // 0x378
	private Option __menuOption_Menu_Open_Dashboard_Storage; // 0x3D0
	private Option __menuOption_Menu_Open_Rocket_Storage; // 0x428
	private Option __menuOption_Menu_SetTarget; // 0x480
	private float targetHRot; // 0x4D8
	private float targetVRot; // 0x4DC
	private Nullable<Vector3> hydraulicsBaseLocalPos; // 0x4E0
	private Vector3 hingeTargetLocalRot; // 0x4F0
	private TimeSince timeSinceLightChange; // 0x4FC
	private bool fullscreenMapOpen; // 0x500
	[HeaderAttribute] // RVA: 0xEE5F0 Offset: 0xED9F0 VA: 0x1800EE5F0
	[SerializeField] // RVA: 0xEE5F0 Offset: 0xED9F0 VA: 0x1800EE5F0
	private GameObjectRef rocketStoragePrefab; // 0x508
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef dashboardStoragePrefab; // 0x510
	[HeaderAttribute] // RVA: 0xEE880 Offset: 0xEDC80 VA: 0x1800EE880
	[SerializeField] // RVA: 0xEE880 Offset: 0xEDC80 VA: 0x1800EE880
	private Transform hRotator; // 0x518
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float hRotSpeed; // 0x520
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform vRotator; // 0x528
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float vRotSpeed; // 0x530
	[SerializeField] // RVA: 0xEEE30 Offset: 0xEE230 VA: 0x1800EEE30
	[RangeAttribute] // RVA: 0xEEE30 Offset: 0xEE230 VA: 0x1800EEE30
	private float vRotMax; // 0x534
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hydraulics; // 0x538
	[HeaderAttribute] // RVA: 0xEF190 Offset: 0xEE590 VA: 0x1800EF190
	[TooltipAttribute] // RVA: 0xEF190 Offset: 0xEE590 VA: 0x1800EF190
	[SerializeField] // RVA: 0xEF190 Offset: 0xEE590 VA: 0x1800EF190
	public float minRange; // 0x540
	[TooltipAttribute] // RVA: 0xEF590 Offset: 0xEE990 VA: 0x1800EF590
	[SerializeField] // RVA: 0xEF590 Offset: 0xEE990 VA: 0x1800EF590
	public float targetAreaRadius; // 0x544
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef mlrsRocket; // 0x548
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Transform firingPoint; // 0x550
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MLRS.RocketTube[] rocketTubes; // 0x558
	[HeaderAttribute] // RVA: 0xEFB30 Offset: 0xEEF30 VA: 0x1800EFB30
	[SerializeField] // RVA: 0xEFB30 Offset: 0xEEF30 VA: 0x1800EFB30
	private GameObject screensChild; // 0x560
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftHandGrip; // 0x568
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftJoystick; // 0x570
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightHandGrip; // 0x578
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightJoystick; // 0x580
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform controlKnobHeight; // 0x588
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform controlKnobAngle; // 0x590
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef uiDialogPrefab; // 0x598
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Light fireButtonLight; // 0x5A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject brokenDownEffect; // 0x5A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem topScreenShutdown; // 0x5B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem bottomScreenShutdown; // 0x5B8
	[ServerVar] // RVA: 0xF02F0 Offset: 0xEF6F0 VA: 0x1800F02F0
	public static float brokenDownMinutes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <UserTargetHitPos>k__BackingField; // 0x5C0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <TrueHitPos>k__BackingField; // 0x5CC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <CurGravityMultiplier>k__BackingField; // 0x5D8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <RocketAmmoCount>k__BackingField; // 0x5DC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsRealigning>k__BackingField; // 0x5E0
	public const BaseEntity.Flags FLAG_FIRING_ROCKETS = 16384;
	public const BaseEntity.Flags FLAG_HAS_AIMING_MODULE = 65536;
	private EntityRef rocketStorageInstance; // 0x5E8
	private EntityRef dashboardStorageInstance; // 0x5F8
	private float rocketBaseGravity; // 0x608
	private float rocketSpeed; // 0x60C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <RocketDamageRadius>k__BackingField; // 0x610
	private bool isInitialLoad; // 0x614

	// Properties
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

	// Methods

	// RVA: 0x56E5D0 Offset: 0x56D9D0 VA: 0x18056E5D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5714D0 Offset: 0x5708D0 VA: 0x1805714D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x570980 Offset: 0x56FD80 VA: 0x180570980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5706F0 Offset: 0x56FAF0 VA: 0x1805706F0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x56F4F0 Offset: 0x56E8F0 VA: 0x18056F4F0
	protected void LateUpdate() { }

	// RVA: 0x571170 Offset: 0x570570 VA: 0x180571170 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x571010 Offset: 0x570410 VA: 0x180571010
	public void SendNewTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x56F250 Offset: 0x56E650 VA: 0x18056F250 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x570A70 Offset: 0x56FE70 VA: 0x180570A70
	private void PositionVisuals() { }

	// RVA: 0x5705E0 Offset: 0x56F9E0 VA: 0x1805705E0
	private void ShowFullscreenMap() { }

	// RVA: 0x570970 Offset: 0x56FD70 VA: 0x180570970
	public void OnFullscreenMapClosed() { }

	// RVA: 0x571140 Offset: 0x570540 VA: 0x180571140
	private bool ShouldShowDashboardUI() { }

	[BaseEntity.Menu] // RVA: 0xF0B00 Offset: 0xEFF00 VA: 0x1800F0B00
	[BaseEntity.Menu.Description] // RVA: 0xF0B00 Offset: 0xEFF00 VA: 0x1800F0B00
	[BaseEntity.Menu.Icon] // RVA: 0xF0B00 Offset: 0xEFF00 VA: 0x1800F0B00
	[BaseEntity.Menu.ShowIf] // RVA: 0xF0B00 Offset: 0xEFF00 VA: 0x1800F0B00
	// RVA: 0x5705E0 Offset: 0x56F9E0 VA: 0x1805705E0
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x570480 Offset: 0x56F880 VA: 0x180570480
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6F360 Offset: 0x6E760 VA: 0x18006F360
	[BaseEntity.Menu.Description] // RVA: 0x6F360 Offset: 0x6E760 VA: 0x18006F360
	[BaseEntity.Menu.Icon] // RVA: 0x6F360 Offset: 0x6E760 VA: 0x18006F360
	[BaseEntity.Menu.ShowIf] // RVA: 0x6F360 Offset: 0x6E760 VA: 0x18006F360
	// RVA: 0x5701D0 Offset: 0x56F5D0 VA: 0x1805701D0
	public void Menu_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x5700B0 Offset: 0x56F4B0 VA: 0x1805700B0
	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FAF0 Offset: 0x6EEF0 VA: 0x18006FAF0
	[BaseEntity.Menu.Description] // RVA: 0x6FAF0 Offset: 0x6EEF0 VA: 0x18006FAF0
	[BaseEntity.Menu.Icon] // RVA: 0x6FAF0 Offset: 0x6EEF0 VA: 0x18006FAF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FAF0 Offset: 0x6EEF0 VA: 0x18006FAF0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x56FFA0 Offset: 0x56F3A0 VA: 0x18056FFA0
	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FF10 Offset: 0x6F310 VA: 0x18006FF10
	[BaseEntity.Menu.Description] // RVA: 0x6FF10 Offset: 0x6F310 VA: 0x18006FF10
	[BaseEntity.Menu.Icon] // RVA: 0x6FF10 Offset: 0x6F310 VA: 0x18006FF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FF10 Offset: 0x6F310 VA: 0x18006FF10
	// RVA: 0x570440 Offset: 0x56F840 VA: 0x180570440
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	// RVA: 0x570370 Offset: 0x56F770 VA: 0x180570370
	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x70150 Offset: 0x6F550 VA: 0x180070150
	[BaseEntity.Menu.Description] // RVA: 0x70150 Offset: 0x6F550 VA: 0x180070150
	[BaseEntity.Menu.Icon] // RVA: 0x70150 Offset: 0x6F550 VA: 0x180070150
	[BaseEntity.Menu.ShowIf] // RVA: 0x70150 Offset: 0x6F550 VA: 0x180070150
	// RVA: 0x570330 Offset: 0x56F730 VA: 0x180570330
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	// RVA: 0x570260 Offset: 0x56F660 VA: 0x180570260
	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571810 Offset: 0x570C10 VA: 0x180571810
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571940 Offset: 0x570D40 VA: 0x180571940
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5717F0 Offset: 0x570BF0 VA: 0x1805717F0
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571920 Offset: 0x570D20 VA: 0x180571920
	private void set_TrueHitPos(Vector3 value) { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool get_HasAimingModule() { }

	// RVA: 0x5713E0 Offset: 0x5707E0 VA: 0x1805713E0
	private bool get_CanBeUsed() { }

	// RVA: 0x571420 Offset: 0x570820 VA: 0x180571420
	private bool get_CanFire() { }

	// RVA: 0x571490 Offset: 0x570890 VA: 0x180571490
	private float get_HRotation() { }

	// RVA: 0x571870 Offset: 0x570C70 VA: 0x180571870
	private void set_HRotation(float value) { }

	// RVA: 0x571830 Offset: 0x570C30 VA: 0x180571830
	private float get_VRotation() { }

	// RVA: 0x571960 Offset: 0x570D60 VA: 0x180571960
	private void set_VRotation(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571480 Offset: 0x570880 VA: 0x180571480
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571860 Offset: 0x570C60 VA: 0x180571860
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5717D0 Offset: 0x570BD0 VA: 0x1805717D0
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571900 Offset: 0x570D00 VA: 0x180571900
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5717C0 Offset: 0x570BC0 VA: 0x1805717C0
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5718F0 Offset: 0x570CF0 VA: 0x1805718F0
	private void set_IsRealigning(bool value) { }

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5717E0 Offset: 0x570BE0 VA: 0x1805717E0
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x571910 Offset: 0x570D10 VA: 0x180571910
	private void set_RocketDamageRadius(float value) { }

	// RVA: 0x56F400 Offset: 0x56E800 VA: 0x18056F400 Slot: 28
	public override void InitShared() { }

	// RVA: 0x56FCA0 Offset: 0x56F0A0 VA: 0x18056FCA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x56E0F0 Offset: 0x56D4F0 VA: 0x18056E0F0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x571080 Offset: 0x570480 VA: 0x180571080
	private void SetUserTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x56F170 Offset: 0x56E570 VA: 0x18056F170
	private StorageContainer GetRocketContainer() { }

	// RVA: 0x56E4F0 Offset: 0x56D8F0 VA: 0x18056E4F0
	private StorageContainer GetDashboardContainer() { }

	// RVA: 0x56F2A0 Offset: 0x56E6A0 VA: 0x18056F2A0
	private void HitPosToRotation(Vector3 hitPos, out float hRot, out float vRot, out float g) { }

	// RVA: 0x56E110 Offset: 0x56D510 VA: 0x18056E110
	private Vector3 GetAimToTarget(Vector3 targetPos, out float g) { }

	// RVA: 0x570EF0 Offset: 0x5702F0 VA: 0x180570EF0
	private static float ProjectileDistToSpeed(float x, float y, float angle, float g, float fallbackV) { }

	// RVA: 0x570DC0 Offset: 0x5701C0 VA: 0x180570DC0
	private static float ProjectileDistToGravity(float x, float y, float θ, float v) { }

	// RVA: 0x571350 Offset: 0x570750 VA: 0x180571350
	public void .ctor() { }

	// RVA: 0x571310 Offset: 0x570710 VA: 0x180571310
	private static void .cctor() { }

}

public class MLRS.RocketTube // TypeDefIndex: 8413
{	// Fields
	public Vector3 firingOffset; // 0x10
	public Transform hinge; // 0x20
	public Renderer rocket; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct MLRS.TheoreticalProjectile // TypeDefIndex: 8414
{	// Fields
	public Vector3 pos; // 0x0
	public Vector3 forward; // 0xC
	public float gravityMult; // 0x18

	// Methods

	// RVA: 0xF2CC0 Offset: 0xF20C0 VA: 0x1800F2CC0
	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

