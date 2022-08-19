public class TrainCar : BaseVehicle, IGenericLerpTarget<TrainCar.TrainCarSnapshot>, ILerpInfo, ITrainCollidable, IPrefabPreProcess // TypeDefIndex: 8467
{	// Fields
	private Option __menuOption_Menu_Uncouple; // 0x3B8
	private GenericLerp<TrainCar.TrainCarSnapshot> animInterp; // 0x410
	protected bool runningClientTick; // 0x418
	private Vector3 bogieRotation; // 0x41C
	private Vector3 prevWheelRotation; // 0x428
	[HeaderAttribute] // RVA: 0x90D40 Offset: 0x90140 VA: 0x180090D40
	[SerializeField] // RVA: 0x90D40 Offset: 0x90140 VA: 0x180090D40
	private float corpseSeconds; // 0x434
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerTrainCollisions frontCollisionTrigger; // 0x438
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerTrainCollisions rearCollisionTrigger; // 0x440
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float collisionDamageDivide; // 0x448
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float derailCollisionForce; // 0x44C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerFront; // 0x450
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerRear; // 0x458
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float hurtTriggerMinSpeed; // 0x460
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform centreOfMassTransform; // 0x468
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform frontBogiePivot; // 0x470
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool frontBogieCanRotate; // 0x478
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rearBogiePivot; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool rearBogieCanRotate; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform[] wheelVisuals; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float wheelRadius; // 0x498
	[FormerlySerializedAsAttribute] // RVA: 0x91990 Offset: 0x90D90 VA: 0x180091990
	[SerializeField] // RVA: 0x91990 Offset: 0x90D90 VA: 0x180091990
	private GameObjectRef fxDestroyed; // 0x4A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TriggerParent platformParentTrigger; // 0x4A8
	public GameObjectRef collisionEffect; // 0x4B0
	public Transform frontCoupling; // 0x4B8
	public Transform frontCouplingPivot; // 0x4C0
	public Transform rearCoupling; // 0x4C8
	public Transform rearCouplingPivot; // 0x4D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition coupleSound; // 0x4D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition uncoupleSound; // 0x4E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainCarAudio trainCarAudio; // 0x4E8
	[FormerlySerializedAsAttribute] // RVA: 0x92FB0 Offset: 0x923B0 VA: 0x180092FB0
	[SerializeField] // RVA: 0x92FB0 Offset: 0x923B0 VA: 0x180092FB0
	private ParticleSystem frontCouplingChangedFx; // 0x4F0
	[FormerlySerializedAsAttribute] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	[SerializeField] // RVA: 0x93140 Offset: 0x92540 VA: 0x180093140
	private ParticleSystem rearCouplingChangedFx; // 0x4F8
	[FormerlySerializedAsAttribute] // RVA: 0x932A0 Offset: 0x926A0 VA: 0x1800932A0
	[SerializeField] // RVA: 0x932A0 Offset: 0x926A0 VA: 0x1800932A0
	private ParticleSystem newCouplingFX; // 0x500
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[ReadOnlyAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private Vector3 frontBogieLocalOffset; // 0x508
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[ReadOnlyAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private Vector3 rearBogieLocalOffset; // 0x514
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x0
	[ServerVar] // RVA: 0x93590 Offset: 0x92990 VA: 0x180093590
	public static int wagons_per_engine; // 0x4
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static float decayminutes; // 0x8
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public float DistFrontWheelToFrontCoupling; // 0x520
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public float DistFrontWheelToBackCoupling; // 0x524
	public TrainCouplingController coupling; // 0x528
	public TrainTrackSpline.TrackSelection localTrackSelection; // 0x530
	public const BaseEntity.Flags Flag_LinedUpToUnload = 1024;

	// Properties
	public override bool HasMenuOptions { get; }
	public TriggerTrainCollisions FrontCollisionTrigger { get; }
	public TriggerTrainCollisions RearCollisionTrigger { get; }
	public virtual TrainCar.TrainCarType CarType { get; }
	public bool LinedUpToUnload { get; }

	// Methods

	// RVA: 0x9EDA80 Offset: 0x9ECE80 VA: 0x1809EDA80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9EF6E0 Offset: 0x9EEAE0 VA: 0x1809EF6E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9EE430 Offset: 0x9ED830 VA: 0x1809EE430 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9ED9C0 Offset: 0x9ECDC0 VA: 0x1809ED9C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9ED450 Offset: 0x9EC850 VA: 0x1809ED450 Slot: 199
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x9EF050 Offset: 0x9EE450 VA: 0x1809EF050
	private void StartClientTick() { }

	// RVA: 0x9EF160 Offset: 0x9EE560 VA: 0x1809EF160 Slot: 200
	protected virtual void StopClientTick() { }

	// RVA: 0x9EF200 Offset: 0x9EE600 VA: 0x1809EF200 Slot: 201
	protected virtual void TrainClientTick() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 202
	protected virtual bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0x9EDD90 Offset: 0x9ED190 VA: 0x1809EDD90
	private void InitAnimInterpolator() { }

	// RVA: 0x9ED200 Offset: 0x9EC600 VA: 0x1809ED200
	private void AddSnapshot(float time, float frontBogieYRot, float rearBogieYRot) { }

	// RVA: 0x9EF360 Offset: 0x9EE760 VA: 0x1809EF360
	private void UpdateWheelVisuals(Vector3 localVelocity, float frontBogieYRot, float rearBogieYRot) { }

	// RVA: 0x9EEF80 Offset: 0x9EE380 VA: 0x1809EEF80 Slot: 194
	public void SetFrom(TrainCar.TrainCarSnapshot snapshot) { }

	// RVA: 0x9EDA00 Offset: 0x9ECE00 VA: 0x1809EDA00 Slot: 195
	public TrainCar.TrainCarSnapshot GetCurrentState() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 196
	public void DebugInterpolationState(Interpolator.Segment<TrainCar.TrainCarSnapshot> segment, List<TrainCar.TrainCarSnapshot> entries) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EEFF0 Offset: 0x9EE3F0 VA: 0x1809EEFF0
	private void SetTrackSelection(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9ED3A0 Offset: 0x9EC7A0 VA: 0x1809ED3A0
	private void BaseTrainUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	[BaseEntity.Menu.Description] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	[BaseEntity.Menu.Icon] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	[BaseEntity.Menu.ShowIf] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	// RVA: 0x9EE2A0 Offset: 0x9ED6A0 VA: 0x1809EE2A0
	public void Menu_Uncouple(BasePlayer player) { }

	// RVA: 0x9EE110 Offset: 0x9ED510 VA: 0x1809EE110 Slot: 203
	public virtual bool Menu_Uncouple_ShowIf(BasePlayer player) { }

	// RVA: 0x9EF6D0 Offset: 0x9EEAD0 VA: 0x1809EF6D0
	public TriggerTrainCollisions get_FrontCollisionTrigger() { }

	// RVA: 0x9EF7B0 Offset: 0x9EEBB0 VA: 0x1809EF7B0
	public TriggerTrainCollisions get_RearCollisionTrigger() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 204
	public virtual TrainCar.TrainCarType get_CarType() { }

	// RVA: 0x7518E0 Offset: 0x750CE0 VA: 0x1807518E0
	public bool get_LinedUpToUnload() { }

	// RVA: 0x9EEC10 Offset: 0x9EE010 VA: 0x1809EEC10 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x9EDE20 Offset: 0x9ED220 VA: 0x1809EDE20 Slot: 28
	public override void InitShared() { }

	// RVA: 0x9EDF90 Offset: 0x9ED390 VA: 0x1809EDF90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9EE3D0 Offset: 0x9ED7D0 VA: 0x1809EE3D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 197
	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	// RVA: 0x72D8F0 Offset: 0x72CCF0 VA: 0x18072D8F0 Slot: 99
	public override float InheritedVelocityScale() { }

	// RVA: 0x9EF040 Offset: 0x9EE440 VA: 0x1809EF040 Slot: 205
	protected virtual void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0x9EF5F0 Offset: 0x9EE9F0 VA: 0x1809EF5F0
	public void .ctor() { }

	// RVA: 0x9EF590 Offset: 0x9EE990 VA: 0x1809EF590
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EF2A0 Offset: 0x9EE6A0 VA: 0x1809EF2A0
	private void <UpdateWheelVisuals>g__SetBogieRotation|18_0(Transform pivot, float yAngle, bool canRotate) { }

}

public struct TrainCar.TrainCarSnapshot : ISnapshot<TrainCar.TrainCarSnapshot> // TypeDefIndex: 8468
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Time>k__BackingField; // 0x0
	public float frontBogieY; // 0x4
	public float rearBogieY; // 0x8

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xFAFF0 Offset: 0xFA3F0 VA: 0x1800FAFF0
	public void .ctor(float time, float frontBogieY, float rearBogieY) { }

	// RVA: 0xFAFC0 Offset: 0xFA3C0 VA: 0x1800FAFC0 Slot: 6
	public void MatchValuesTo(TrainCar.TrainCarSnapshot entry) { }

	// RVA: 0xFAEE0 Offset: 0xFA2E0 VA: 0x1800FAEE0 Slot: 7
	public void Lerp(TrainCar.TrainCarSnapshot prev, TrainCar.TrainCarSnapshot next, float delta) { }

	// RVA: 0xFAED0 Offset: 0xFA2D0 VA: 0x1800FAED0 Slot: 8
	public TrainCar.TrainCarSnapshot GetNew() { }

}

public enum TrainCar.TrainCarType // TypeDefIndex: 8469
{	// Fields
	public int value__; // 0x0
	public const TrainCar.TrainCarType Wagon = 0;
	public const TrainCar.TrainCarType Engine = 1;

}

