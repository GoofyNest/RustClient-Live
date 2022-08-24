public class TrainCar : BaseVehicle, IGenericLerpTarget<TrainCar.TrainCarSnapshot>, ILerpInfo, ITrainCollidable, IPrefabPreProcess // TypeDefIndex: 8467
{
	private Option __menuOption_Menu_Uncouple; 
	private GenericLerp<TrainCar.TrainCarSnapshot> animInterp; 
	protected bool runningClientTick; 
	private Vector3 bogieRotation; 
	private Vector3 prevWheelRotation; 
	[HeaderAttribute] 
	[SerializeField] 
	private float corpseSeconds; 
	[SerializeField] 
	private TriggerTrainCollisions frontCollisionTrigger; 
	[SerializeField] 
	private TriggerTrainCollisions rearCollisionTrigger; 
	[SerializeField] 
	private float collisionDamageDivide; 
	[SerializeField] 
	private float derailCollisionForce; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerFront; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerRear; 
	[SerializeField] 
	private float hurtTriggerMinSpeed; 
	[SerializeField] 
	private Transform centreOfMassTransform; 
	[SerializeField] 
	private Transform frontBogiePivot; 
	[SerializeField] 
	private bool frontBogieCanRotate; 
	[SerializeField] 
	private Transform rearBogiePivot; 
	[SerializeField] 
	private bool rearBogieCanRotate; 
	[SerializeField] 
	private Transform[] wheelVisuals; 
	[SerializeField] 
	private float wheelRadius; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private GameObjectRef fxDestroyed; 
	[SerializeField] 
	protected TriggerParent platformParentTrigger; 
	public GameObjectRef collisionEffect; 
	public Transform frontCoupling; 
	public Transform frontCouplingPivot; 
	public Transform rearCoupling; 
	public Transform rearCouplingPivot; 
	[SerializeField] 
	private SoundDefinition coupleSound; 
	[SerializeField] 
	private SoundDefinition uncoupleSound; 
	[SerializeField] 
	private TrainCarAudio trainCarAudio; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private ParticleSystem frontCouplingChangedFx; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private ParticleSystem rearCouplingChangedFx; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private ParticleSystem newCouplingFX; 
	[SerializeField] 
	[ReadOnlyAttribute] 
	private Vector3 frontBogieLocalOffset; 
	[SerializeField] 
	[ReadOnlyAttribute] 
	private Vector3 rearBogieLocalOffset; 
	[ServerVar] 
	public static float population; 
	[ServerVar] 
	public static int wagons_per_engine; 
	[ServerVar] 
	public static float decayminutes; 
	[ReadOnlyAttribute] 
	public float DistFrontWheelToFrontCoupling; 
	[ReadOnlyAttribute] 
	public float DistFrontWheelToBackCoupling; 
	public TrainCouplingController coupling; 
	public TrainTrackSpline.TrackSelection localTrackSelection; 
	public const BaseEntity.Flags Flag_LinedUpToUnload = 1024;

	public override bool HasMenuOptions { get; }
	public TriggerTrainCollisions FrontCollisionTrigger { get; }
	public TriggerTrainCollisions RearCollisionTrigger { get; }
	public virtual TrainCar.TrainCarType CarType { get; }
	public bool LinedUpToUnload { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void StartClientTick() { }

	protected virtual void StopClientTick() { }

	protected virtual void TrainClientTick() { }

	protected virtual bool UpdateBraking(float forwardSpeed) { }

	private void InitAnimInterpolator() { }

	private void AddSnapshot(float time, float frontBogieYRot, float rearBogieYRot) { }

	private void UpdateWheelVisuals(Vector3 localVelocity, float frontBogieYRot, float rearBogieYRot) { }

	public void SetFrom(TrainCar.TrainCarSnapshot snapshot) { }

	public TrainCar.TrainCarSnapshot GetCurrentState() { }

	public void DebugInterpolationState(Interpolator.Segment<TrainCar.TrainCarSnapshot> segment, List<TrainCar.TrainCarSnapshot> entries) { }

	[BaseEntity.RPC_Client] 
	private void SetTrackSelection(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void BaseTrainUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Uncouple(BasePlayer player) { }

	public virtual bool Menu_Uncouple_ShowIf(BasePlayer player) { }

	public TriggerTrainCollisions get_FrontCollisionTrigger() { }

	public TriggerTrainCollisions get_RearCollisionTrigger() { }

	public virtual TrainCar.TrainCarType get_CarType() { }

	public bool get_LinedUpToUnload() { }

	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override float InheritedVelocityScale() { }

	protected virtual void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <UpdateWheelVisuals>g__SetBogieRotation|18_0(Transform pivot, float yAngle, bool canRotate) { }

}

public struct TrainCar.TrainCarSnapshot : ISnapshot<TrainCar.TrainCarSnapshot> // TypeDefIndex: 8468
{
	[CompilerGeneratedAttribute] 
	private float <Time>k__BackingField; 
	public float frontBogieY; 
	public float rearBogieY; 

	public float Time { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Time() { }

	[CompilerGeneratedAttribute] 
	public void set_Time(float value) { }

	public void .ctor(float time, float frontBogieY, float rearBogieY) { }

	public void MatchValuesTo(TrainCar.TrainCarSnapshot entry) { }

	public void Lerp(TrainCar.TrainCarSnapshot prev, TrainCar.TrainCarSnapshot next, float delta) { }

	public TrainCar.TrainCarSnapshot GetNew() { }

}

public enum TrainCar.TrainCarType // TypeDefIndex: 8469
{
	public int value__; 
	public const TrainCar.TrainCarType Wagon = 0;
	public const TrainCar.TrainCarType Engine = 1;

}

