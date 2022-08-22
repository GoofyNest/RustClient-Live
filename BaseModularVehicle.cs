public abstract class BaseModularVehicle : GroundVehicle, IPrefabPreProcess // TypeDefIndex: 8328
{	private Option __menuOption_Menu_Push; // 0x408
	protected bool clientInEditMode; // 0x460
	private LOD[] baseVehicleLODs; // 0x468
	private LOD[] combinedLODs; // 0x470
	private int[] maxRendererIndex; // 0x478
	[HeaderAttribute] // RVA: 0xB88F0 Offset: 0xB7CF0 VA: 0x1800B88F0
	[SerializeField] // RVA: 0xB88F0 Offset: 0xB7CF0 VA: 0x1800B88F0
	private List<ModularVehicleSocket> moduleSockets; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform centreOfMassTransform; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Transform waterSample; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LODGroup lodGroup; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField; // 0x4A0
	private float _mass; // 0x4A8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <TotalMass>k__BackingField; // 0x4AC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasInited>k__BackingField; // 0x4B0
	public const BaseEntity.Flags FLAG_KINEMATIC = 16384;
	private Dictionary<BaseVehicleModule, Action> moduleAddActions; // 0x4B8

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

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	public virtual void Menu_Push(BasePlayer player) { }

	public Vector3 get_CentreOfMass() { }

	public int get_NumAttachedModules() { }

	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	public int get_TotalSockets() { }

	public int get_NumFreeSockets() { }

	private float get_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_TotalMass(float value) { }

	public bool get_IsKinematic() { }

	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 8329
{	public BaseModularVehicle <>4__this; // 0x10
	public BaseVehicleModule module; // 0x18


	public void .ctor() { }

	internal void <OnChildAdded>b__0() { }

}

