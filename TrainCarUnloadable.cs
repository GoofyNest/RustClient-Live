public class TrainCarUnloadable : TrainCar // TypeDefIndex: 8470
{	// Fields
	private Option __menuOption_Menu_Open; // 0x538
	[HeaderAttribute] // RVA: 0x93E90 Offset: 0x93290 VA: 0x180093E90
	[SerializeField] // RVA: 0x93E90 Offset: 0x93290 VA: 0x180093E90
	private GameObjectRef storagePrefab; // 0x590
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BoxCollider[] unloadingAreas; // 0x598
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainCarFuelHatches fuelHatches; // 0x5A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform orePlaneVisuals; // 0x5A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform orePlaneColliderDetailed; // 0x5B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform orePlaneColliderWorld; // 0x5B8
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	public float vacuumStretchPercent; // 0x5C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer unloadingFXContainer; // 0x5C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem unloadingFX; // 0x5D0
	public TrainCarUnloadable.WagonType wagonType; // 0x5D8
	private int lootTypeIndex; // 0x5DC
	private List<EntityRef<LootContainer>> lootContainers; // 0x5E0
	private Vector3 _oreScale; // 0x5E8
	private float animPercent; // 0x5F4
	private float prevAnimTime; // 0x5F8
	[ServerVar] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	public static float decayminutesafterunload; // 0x0
	private MeshRenderer[] orePlaneRenderers; // 0x600
	private float clientOrePercentFull; // 0x608

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x9EB890 Offset: 0x9EAC90 VA: 0x1809EB890 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9ED140 Offset: 0x9EC540 VA: 0x1809ED140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9EC020 Offset: 0x9EB420 VA: 0x1809EC020 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9EBEA0 Offset: 0x9EB2A0 VA: 0x1809EBEA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x9EBDB0 Offset: 0x9EB1B0 VA: 0x1809EBDB0 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0x9EBC10 Offset: 0x9EB010 VA: 0x1809EBC10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9EBBD0 Offset: 0x9EAFD0 VA: 0x1809EBBD0
	public bool IsEmpty() { }

	// RVA: 0x9ECF30 Offset: 0x9EC330 VA: 0x1809ECF30
	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0x9EB500 Offset: 0x9EA900 VA: 0x1809EB500 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x9EB790 Offset: 0x9EAB90 VA: 0x1809EB790
	public int GetFilledLootAmount() { }

	// RVA: 0x9ECDC0 Offset: 0x9EC1C0 VA: 0x1809ECDC0
	public void SetVisualOreLevel(float percent) { }

	// RVA: 0x9EB400 Offset: 0x9EA800 VA: 0x1809EB400
	private void AnimateUnload(float startPercent) { }

	// RVA: 0x9ECFA0 Offset: 0x9EC3A0 VA: 0x1809ECFA0
	private void UnloadAnimTick() { }

	// RVA: 0x9EB6C0 Offset: 0x9EAAC0 VA: 0x1809EB6C0
	private void EndUnloadAnim() { }

	// RVA: 0x9EBBA0 Offset: 0x9EAFA0 VA: 0x1809EBBA0
	public float GetOrePercent() { }

	// RVA: 0x9EB550 Offset: 0x9EA950 VA: 0x1809EB550 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9EB630 Offset: 0x9EAA30 VA: 0x1809EB630 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9ECC00 Offset: 0x9EC000 VA: 0x1809ECC00
	private void SetOreMat() { }

	// RVA: 0x9ECA20 Offset: 0x9EBE20 VA: 0x1809ECA20
	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Description] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Icon] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.ShowIf] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0x9EBD70 Offset: 0x9EB170 VA: 0x1809EBD70
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x9EBCA0 Offset: 0x9EB0A0 VA: 0x1809EBCA0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EC890 Offset: 0x9EBC90 VA: 0x1809EC890
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9EC9C0 Offset: 0x9EBDC0 VA: 0x1809EC9C0
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9ED060 Offset: 0x9EC460 VA: 0x1809ED060
	public void .ctor() { }

	// RVA: 0x9ED020 Offset: 0x9EC420 VA: 0x1809ED020
	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 8471
{	// Fields
	public int value__; // 0x0
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}

