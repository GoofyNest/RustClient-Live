public class Workbench : StorageContainer // TypeDefIndex: 10206
{
	private Option __menuOption_UseBench; 
	public const int blueprintSlot = 0;
	public const int experimentSlot = 1;
	public bool Static; 
	public int Workbenchlevel; 
	public LootSpawn experimentalItems; 
	public GameObjectRef experimentStartEffect; 
	public GameObjectRef experimentSuccessEffect; 
	public ItemDefinition experimentResource; 
	public TechTreeData techTree; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void UseBench(BasePlayer player) { }

	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	public void TryExperiment() { }

	public bool PlayerUnlockedThisTier() { }

	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	public int GetScrapForExperiment() { }

	public bool IsWorking() { }

	public void .ctor() { }

}

