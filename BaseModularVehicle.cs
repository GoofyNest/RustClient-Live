public abstract class BaseModularVehicle : GroundVehicle, IPrefabPreProcess // TypeDefIndex: 10032
{
	private Option __menuOption_Menu_Push; 
	protected bool clientInEditMode; 
	private LOD[] baseVehicleLODs; 
	private LOD[] combinedLODs; 
	private int[] maxRendererIndex; 
	[HeaderAttribute] 
	[SerializeField] 
	private List<ModularVehicleSocket> moduleSockets; 
	[SerializeField] 
	private Transform centreOfMassTransform; 
	[SerializeField] 
	protected Transform waterSample; 
	[SerializeField] 
	private LODGroup lodGroup; 
	[CompilerGeneratedAttribute] 
	private readonly List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField; 
	private float _mass; 
	[CompilerGeneratedAttribute] 
	private float <TotalMass>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <HasInited>k__BackingField; 
	public const BaseEntity.Flags FLAG_KINEMATIC = 16384;
	private Dictionary<BaseVehicleModule, Action> moduleAddActions; 

	public override bool HasMenuOptions { get; }
	public Vector3 CentreOfMass { get; }
	public int NumAttachedModules { get; }
	public bool HasAnyModules { get; }
	public List<BaseVehicleModule> AttachedModuleEntities { get; }
	public int TotalSockets { get; }
	public int NumFreeSockets { get; }
	private float Mass { get; }
	public float TotalMass { get; set; }
	public bool IsKinematic { get; }
	public virtual bool IsLockable { get; }
	public bool HasInited { get; set; }
	private ItemDefinition AssociatedItemDef { get; }
	public bool IsEditableNow { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	protected override void GroundVehicleClientTick() { }

	protected override void OnClientTickStopped() { }

	protected override void ClientInit(Entity info) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn) { }

	protected abstract bool IsBraking();

	private void RefreshLODSets() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public virtual void Menu_Push(BasePlayer player) { }

	public Vector3 get_CentreOfMass() { }

	public int get_NumAttachedModules() { }

	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] 
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	public int get_TotalSockets() { }

	public int get_NumFreeSockets() { }

	private float get_Mass() { }

	[CompilerGeneratedAttribute] 
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] 
	private void set_TotalMass(float value) { }

	public bool get_IsKinematic() { }

	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] 
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] 
	private void set_HasInited(bool value) { }

	private ItemDefinition get_AssociatedItemDef() { }

	public bool get_IsEditableNow() { }

	public override void InitShared() { }

	public virtual bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index) { }

	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result) { }

	public ModularVehicleSocket GetSocket(int index) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	protected override void OnChildAdded(BaseEntity childEntity) { }

	protected override void OnChildRemoved(BaseEntity childEntity) { }

	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	private void RefreshModulesExcept(BaseVehicleModule ignoredModule) { }

	protected void .ctor() { }

}

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 10033
{
	public BaseModularVehicle <>4__this; 
	public BaseVehicleModule module; 


	public void .ctor() { }

	internal void <OnChildAdded>b__0() { }

}

