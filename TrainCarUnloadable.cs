public class TrainCarUnloadable : TrainCar // TypeDefIndex: 10193
{
	private Option __menuOption_Menu_Open;
	[HeaderAttribute]
	[SerializeField]
	private GameObjectRef storagePrefab;
	[SerializeField]
	private BoxCollider[] unloadingAreas;
	[SerializeField]
	private TrainCarFuelHatches fuelHatches;
	[SerializeField]
	private Transform orePlaneVisuals;
	[SerializeField]
	private Transform orePlaneColliderDetailed;
	[SerializeField]
	private Transform orePlaneColliderWorld;
	[SerializeField]
	[RangeAttribute]
	public float vacuumStretchPercent;
	[SerializeField]
	private ParticleSystemContainer unloadingFXContainer;
	[SerializeField]
	private ParticleSystem unloadingFX;
	public TrainCarUnloadable.WagonType wagonType;
	private int lootTypeIndex;
	private List<EntityRef<LootContainer>> lootContainers;
	private Vector3 _oreScale;
	private float animPercent;
	private float prevAnimTime;
	[ServerVar]
	public static float decayminutesafterunload;
	private List<MeshRenderer> orePlaneRenderers;
	private float clientOrePercentFull;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected override void OnChildAdded(BaseEntity child) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool IsEmpty() { }

	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public int GetFilledLootAmount() { }

	public void SetVisualOreLevel(float percent) { }

	private void AnimateUnload(float startPercent) { }

	private void UnloadAnimTick() { }

	private void EndUnloadAnim() { }

	public float GetOrePercent() { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	private void SetOreMat() { }

	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 10194
{
	public int value__;
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}

