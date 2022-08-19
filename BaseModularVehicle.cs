public abstract class BaseModularVehicle : GroundVehicle, IPrefabPreProcess // TypeDefIndex: 8328
{	// Fields
	private Option __menuOption_Menu_Push; // 0x408
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

	// Properties
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

	// Methods

	// RVA: 0xA25BC0 Offset: 0xA24FC0 VA: 0x180A25BC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA27F20 Offset: 0xA27320 VA: 0x180A27F20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA25F50 Offset: 0xA25350 VA: 0x180A25F50 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0xA26CA0 Offset: 0xA260A0 VA: 0x180A26CA0 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0xA259F0 Offset: 0xA24DF0 VA: 0x180A259F0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA27CF0 Offset: 0xA270F0 VA: 0x180A27CF0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA26D50 Offset: 0xA26150 VA: 0x180A26D50 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA25A80 Offset: 0xA24E80 VA: 0x180A25A80 Slot: 203
	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn) { }

	// RVA: -1 Offset: -1 Slot: 204
	protected abstract bool IsBraking();

	// RVA: 0xA26E70 Offset: 0xA26270 VA: 0x180A26E70
	private void RefreshLODSets() { }

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	// RVA: 0xA26320 Offset: 0xA25720 VA: 0x180A26320 Slot: 205
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0xA27E80 Offset: 0xA27280 VA: 0x180A27E80
	public Vector3 get_CentreOfMass() { }

	// RVA: 0xA280A0 Offset: 0xA274A0 VA: 0x180A280A0
	public int get_NumAttachedModules() { }

	// RVA: 0xA27EC0 Offset: 0xA272C0 VA: 0x180A27EC0
	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA27E70 Offset: 0xA27270 VA: 0x180A27E70
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	// RVA: 0xA281D0 Offset: 0xA275D0 VA: 0x180A281D0
	public int get_TotalSockets() { }

	// RVA: 0xA280E0 Offset: 0xA274E0 VA: 0x180A280E0
	public int get_NumFreeSockets() { }

	// RVA: 0xA28000 Offset: 0xA27400 VA: 0x180A28000
	private float get_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA281C0 Offset: 0xA275C0 VA: 0x180A281C0
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA28220 Offset: 0xA27620 VA: 0x180A28220
	private void set_TotalMass(float value) { }

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool get_IsKinematic() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 206
	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA27F10 Offset: 0xA27310 VA: 0x180A27F10
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA28210 Offset: 0xA27610 VA: 0x180A28210
	private void set_HasInited(bool value) { }

	// RVA: 0x778790 Offset: 0x777B90 VA: 0x180778790
	private ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0xA27FF0 Offset: 0xA273F0 VA: 0x180A27FF0
	public bool get_IsEditableNow() { }

	// RVA: 0xA26010 Offset: 0xA25410 VA: 0x180A26010 Slot: 28
	public override void InitShared() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 207
	public virtual bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0xA27920 Offset: 0xA26D20 VA: 0x180A27920
	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index) { }

	// RVA: 0xA25990 Offset: 0xA24D90 VA: 0x180A25990
	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA27900 Offset: 0xA26D00 VA: 0x180A27900
	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA27B30 Offset: 0xA26F30 VA: 0x180A27B30
	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result) { }

	// RVA: 0xA25EE0 Offset: 0xA252E0 VA: 0x180A25EE0
	public ModularVehicleSocket GetSocket(int index) { }

	// RVA: 0xA26230 Offset: 0xA25630 VA: 0x180A26230 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA259B0 Offset: 0xA24DB0 VA: 0x180A259B0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xA26AC0 Offset: 0xA25EC0 VA: 0x180A26AC0 Slot: 22
	protected override void OnChildAdded(BaseEntity childEntity) { }

	// RVA: 0xA26C00 Offset: 0xA26000 VA: 0x180A26C00 Slot: 23
	protected override void OnChildRemoved(BaseEntity childEntity) { }

	// RVA: 0xA26360 Offset: 0xA25760 VA: 0x180A26360 Slot: 208
	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0xA26930 Offset: 0xA25D30 VA: 0x180A26930 Slot: 209
	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0xA277B0 Offset: 0xA26BB0 VA: 0x180A277B0
	private void RefreshModulesExcept(BaseVehicleModule ignoredModule) { }

	// RVA: 0xA27DC0 Offset: 0xA271C0 VA: 0x180A27DC0
	protected void .ctor() { }

}

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 8329
{	// Fields
	public BaseModularVehicle <>4__this; // 0x10
	public BaseVehicleModule module; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA33240 Offset: 0xA32640 VA: 0x180A33240
	internal void <OnChildAdded>b__0() { }

}

