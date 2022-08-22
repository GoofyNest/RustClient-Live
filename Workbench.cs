public class Workbench : StorageContainer // TypeDefIndex: 8488
{	private Option __menuOption_UseBench; // 0x3D0
	public const int blueprintSlot = 0;
	public const int experimentSlot = 1;
	public bool Static; // 0x428
	public int Workbenchlevel; // 0x42C
	public LootSpawn experimentalItems; // 0x430
	public GameObjectRef experimentStartEffect; // 0x438
	public GameObjectRef experimentSuccessEffect; // 0x440
	public ItemDefinition experimentResource; // 0x448
	public TechTreeData techTree; // 0x450

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.Description] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.Icon] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	public void UseBench(BasePlayer player) { }

	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	public void TryExperiment() { }

	public bool PlayerUnlockedThisTier() { }

	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	public int GetScrapForExperiment() { }

	public bool IsWorking() { }

	public void .ctor() { }

}

