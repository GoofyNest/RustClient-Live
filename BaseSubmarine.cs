public class BaseSubmarine : BaseVehicle, IEngineControllerUser, IEntity, IAirSupply // TypeDefIndex: 8349
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x3B8
	private Option __menuOption_Menu_ItemStorage; // 0x410
	private Option __menuOption_Menu_Push; // 0x468
	private Option __menuOption_Menu_TorpedoStorage; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <PropPercentVelocity>k__BackingField; // 0x518
	private bool runningClientTick; // 0x51C
	private bool playedDiveBubbles; // 0x51D
	private bool playedWindowFilm; // 0x51E
	private float baseAlphaInside; // 0x520
	private float baseAlphaOutside; // 0x524
	[HeaderAttribute] // RVA: 0xC6090 Offset: 0xC5490 VA: 0x1800C6090
	[SerializeField] // RVA: 0xC6090 Offset: 0xC5490 VA: 0x1800C6090
	private Transform centreOfMassTransform; // 0x528
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Buoyancy buoyancy; // 0x530
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float maxRudderAngle; // 0x538
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rudderVisualTransform; // 0x540
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rudderDetailedColliderTransform; // 0x548
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform propellerTransform; // 0x550
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float timeUntilAutoSurface; // 0x558
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer[] interiorRenderers; // 0x560
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SonarObject sonarObject; // 0x568
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers; // 0x570
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef fuelStoragePrefab; // 0x578
	[HeaderAttribute] // RVA: 0xC6880 Offset: 0xC5C80 VA: 0x1800C6880
	[SerializeField] // RVA: 0xC6880 Offset: 0xC5C80 VA: 0x1800C6880
	private float engineKW; // 0x580
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float turnPower; // 0x584
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineStartupTime; // 0x588
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef itemStoragePrefab; // 0x590
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float depthChangeTargetSpeed; // 0x598
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float idleFuelPerSec; // 0x59C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxFuelPerSec; // 0x5A0
	[FormerlySerializedAsAttribute] // RVA: 0xC6CB0 Offset: 0xC60B0 VA: 0x1800C6CB0
	[SerializeField] // RVA: 0xC6CB0 Offset: 0xC60B0 VA: 0x1800C6CB0
	private bool internalAccessStorage; // 0x5A4
	[HeaderAttribute] // RVA: 0xC6E10 Offset: 0xC6210 VA: 0x1800C6E10
	[SerializeField] // RVA: 0xC6E10 Offset: 0xC6210 VA: 0x1800C6E10
	private GameObjectRef torpedoStoragePrefab; // 0x5A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform torpedoFiringPoint; // 0x5B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxFireRate; // 0x5B8
	[HeaderAttribute] // RVA: 0xC8730 Offset: 0xC7B30 VA: 0x1800C8730
	[SerializeField] // RVA: 0xC8730 Offset: 0xC7B30 VA: 0x1800C8730
	protected SubmarineAudio submarineAudio; // 0x5C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxTorpedoFire; // 0x5C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject internalFXContainer; // 0x5D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject internalOnFXContainer; // 0x5D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxIntAmbientBubbleLoop; // 0x5E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxIntInitialDiveBubbles; // 0x5E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxIntWaterDropSpray; // 0x5F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxIntWindowFilm; // 0x5F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxIntMediumDamage; // 0x600
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxIntHeavyDamage; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject externalFXContainer; // 0x610
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject externalOnFXContainer; // 0x618
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtAmbientBubbleLoop; // 0x620
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtInitialDiveBubbles; // 0x628
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtAboveWaterEngineThrustForward; // 0x630
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtAboveWaterEngineThrustReverse; // 0x638
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtUnderWaterEngineThrustForward; // 0x640
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs; // 0x648
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtUnderWaterEngineThrustReverse; // 0x650
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs; // 0x658
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtBowWave; // 0x660
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem fxExtWakeEffect; // 0x668
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef aboveWatercollisionEffect; // 0x670
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef underWatercollisionEffect; // 0x678
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VolumetricLightBeam spotlightVolumetrics; // 0x680
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float mountedAlphaInside; // 0x688
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float mountedAlphaOutside; // 0x68C
	[ServerVar] // RVA: 0xCA180 Offset: 0xC9580 VA: 0x1800CA180
	public static float outsidedecayminutes; // 0x0
	[ServerVar] // RVA: 0xCA1C0 Offset: 0xC95C0 VA: 0x1800CA1C0
	public static float deepwaterdecayminutes; // 0x4
	[ServerVar] // RVA: 0xCA290 Offset: 0xC9690 VA: 0x1800CA290
	public static float oxygenminutes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Velocity>k__BackingField; // 0x690
	public const BaseEntity.Flags Flag_Ammo = 16384;
	private float _throttle; // 0x69C
	private float _rudder; // 0x6A0
	private float _upDown; // 0x6A4
	private float _oxygen; // 0x6A8
	protected VehicleEngineController<BaseSubmarine> engineController; // 0x6B0
	protected float cachedFuelAmount; // 0x6B8
	protected Vector3 steerAngle; // 0x6BC
	protected float waterSurfaceY; // 0x6C8
	protected float curSubDepthY; // 0x6CC
	private EntityRef<StorageContainer> torpedoStorageInstance; // 0x6D0
	private EntityRef<StorageContainer> itemStorageInstance; // 0x6E0
	private int waterLayerMask; // 0x6F0

	// Properties
	public override bool HasMenuOptions { get; }
	public float PropPercentVelocity { get; set; }
	public ItemModGiveOxygen.AirSupplyType AirType { get; }
	public VehicleEngineController.EngineState<BaseSubmarine> EngineState { get; }
	public Vector3 Velocity { get; set; }
	public bool LightsAreOn { get; }
	public bool HasAmmo { get; }
	public float ThrottleInput { get; set; }
	public float RudderInput { get; set; }
	public float UpDownInput { get; set; }
	public float Oxygen { get; set; }
	protected float PhysicalRudderAngle { get; }
	protected bool IsInWater { get; }
	protected bool IsSurfaced { get; }

	// Methods

	// RVA: 0x90D4D0 Offset: 0x90C8D0 VA: 0x18090D4D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x910F10 Offset: 0x910310 VA: 0x180910F10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x90EB80 Offset: 0x90DF80 VA: 0x18090EB80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9111B0 Offset: 0x9105B0 VA: 0x1809111B0
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9112E0 Offset: 0x9106E0 VA: 0x1809112E0
	private void set_PropPercentVelocity(float value) { }

	// RVA: 0x90D2A0 Offset: 0x90C6A0 VA: 0x18090D2A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x90D140 Offset: 0x90C540 VA: 0x18090D140
	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5CDEC0 Offset: 0x5CD2C0 VA: 0x1805CDEC0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x90E900 Offset: 0x90DD00 VA: 0x18090E900 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x90F9D0 Offset: 0x90EDD0 VA: 0x18090F9D0
	private void StartClientTick() { }

	// RVA: 0x90FA60 Offset: 0x90EE60 VA: 0x18090FA60
	private void StopClientTick() { }

	// RVA: 0x90FB40 Offset: 0x90EF40 VA: 0x18090FB40
	protected void SubmarineClientTick() { }

	// RVA: 0x9106D0 Offset: 0x90FAD0 VA: 0x1809106D0 Slot: 197
	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x910050 Offset: 0x90F450 VA: 0x180910050 Slot: 198
	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x90CEE0 Offset: 0x90C2E0 VA: 0x18090CEE0
	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x90E320 Offset: 0x90D720 VA: 0x18090E320
	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x910020 Offset: 0x90F420 VA: 0x180910020 Slot: 199
	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	// RVA: 0x90E640 Offset: 0x90DA40 VA: 0x18090E640
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x90E570 Offset: 0x90D970 VA: 0x18090E570
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA5F0 Offset: 0xC99F0 VA: 0x1800CA5F0
	[BaseEntity.Menu.Description] // RVA: 0xCA5F0 Offset: 0xC99F0 VA: 0x1800CA5F0
	[BaseEntity.Menu.Icon] // RVA: 0xCA5F0 Offset: 0xC99F0 VA: 0x1800CA5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA5F0 Offset: 0xC99F0 VA: 0x1800CA5F0
	// RVA: 0x90E8C0 Offset: 0x90DCC0 VA: 0x18090E8C0
	public void Menu_TorpedoStorage(BasePlayer player) { }

	// RVA: 0x90E7D0 Offset: 0x90DBD0 VA: 0x18090E7D0
	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA9E0 Offset: 0xC9DE0 VA: 0x1800CA9E0
	[BaseEntity.Menu.Description] // RVA: 0xCA9E0 Offset: 0xC9DE0 VA: 0x1800CA9E0
	[BaseEntity.Menu.Icon] // RVA: 0xCA9E0 Offset: 0xC9DE0 VA: 0x1800CA9E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA9E0 Offset: 0xC9DE0 VA: 0x1800CA9E0
	// RVA: 0x90E750 Offset: 0x90DB50 VA: 0x18090E750
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x90E680 Offset: 0x90DA80 VA: 0x18090E680
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	// RVA: 0x90E790 Offset: 0x90DB90 VA: 0x18090E790 Slot: 200
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90FEC0 Offset: 0x90F2C0 VA: 0x18090FEC0
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90D3B0 Offset: 0x90C7B0 VA: 0x18090D3B0
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x764390 Offset: 0x763790 VA: 0x180764390
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90FFF0 Offset: 0x90F3F0 VA: 0x18090FFF0
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 195
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x910EC0 Offset: 0x9102C0 VA: 0x180910EC0
	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x911240 Offset: 0x910640 VA: 0x180911240
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x911470 Offset: 0x910870 VA: 0x180911470
	private void set_Velocity(Vector3 value) { }

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool get_LightsAreOn() { }

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool get_HasAmmo() { }

	// RVA: 0x9111D0 Offset: 0x9105D0 VA: 0x1809111D0
	public float get_ThrottleInput() { }

	// RVA: 0x911370 Offset: 0x910770 VA: 0x180911370
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x9111C0 Offset: 0x9105C0 VA: 0x1809111C0
	public float get_RudderInput() { }

	// RVA: 0x9112F0 Offset: 0x9106F0 VA: 0x1809112F0
	protected void set_RudderInput(float value) { }

	// RVA: 0x911230 Offset: 0x910630 VA: 0x180911230
	public float get_UpDownInput() { }

	// RVA: 0x9113F0 Offset: 0x9107F0 VA: 0x1809113F0
	protected void set_UpDownInput(float value) { }

	// RVA: 0x90CED0 Offset: 0x90C2D0 VA: 0x18090CED0
	public float get_Oxygen() { }

	// RVA: 0x911260 Offset: 0x910660 VA: 0x180911260
	protected void set_Oxygen(float value) { }

	// RVA: 0x911160 Offset: 0x910560 VA: 0x180911160
	protected float get_PhysicalRudderAngle() { }

	// RVA: 0x911120 Offset: 0x910520 VA: 0x180911120
	protected bool get_IsInWater() { }

	// RVA: 0x911140 Offset: 0x910540 VA: 0x180911140
	protected bool get_IsSurfaced() { }

	// RVA: 0x90E1B0 Offset: 0x90D5B0 VA: 0x18090E1B0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x90E3E0 Offset: 0x90D7E0 VA: 0x18090E3E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x90E9F0 Offset: 0x90DDF0 VA: 0x18090E9F0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x90CED0 Offset: 0x90C2D0 VA: 0x18090CED0 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x90D4C0 Offset: 0x90C8C0 VA: 0x18090D4C0
	public float GetFuelAmount() { }

	// RVA: 0x90DE80 Offset: 0x90D280 VA: 0x18090DE80
	public float GetSpeed() { }

	// RVA: 0x90CFB0 Offset: 0x90C3B0 VA: 0x18090CFB0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x90D3E0 Offset: 0x90C7E0 VA: 0x18090D3E0 Slot: 196
	public float GetAirTimeRemaining() { }

	// RVA: 0x90D0B0 Offset: 0x90C4B0 VA: 0x18090D0B0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x910BD0 Offset: 0x90FFD0 VA: 0x180910BD0
	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	// RVA: 0x90D080 Offset: 0x90C480 VA: 0x18090D080
	private bool CanMount(BasePlayer player) { }

	// RVA: 0x910D70 Offset: 0x910170 VA: 0x180910D70
	private void UpdateWaterInfo() { }

	// RVA: 0x90DF70 Offset: 0x90D370 VA: 0x18090DF70
	private float GetWaterSurfaceY() { }

	// RVA: 0x910E30 Offset: 0x910230 VA: 0x180910E30
	public void .ctor() { }

	// RVA: 0x910DD0 Offset: 0x9101D0 VA: 0x180910DD0
	private static void .cctor() { }

}

public class BaseSubmarine.ParentTriggerInfo // TypeDefIndex: 8350
{	// Fields
	public TriggerParent trigger; // 0x10
	public Transform triggerWaterLevel; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

