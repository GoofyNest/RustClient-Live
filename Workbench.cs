public class Workbench : StorageContainer // TypeDefIndex: 8488
{	// Fields
	private Option __menuOption_UseBench; // 0x3D0
	public const int blueprintSlot = 0;
	public const int experimentSlot = 1;
	public bool Static; // 0x428
	public int Workbenchlevel; // 0x42C
	public LootSpawn experimentalItems; // 0x430
	public GameObjectRef experimentStartEffect; // 0x438
	public GameObjectRef experimentSuccessEffect; // 0x440
	public ItemDefinition experimentResource; // 0x448
	public TechTreeData techTree; // 0x450

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8A7640 Offset: 0x8A6A40 VA: 0x1808A7640 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8A7EE0 Offset: 0x8A72E0 VA: 0x1808A7EE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8A7A70 Offset: 0x8A6E70 VA: 0x1808A7A70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.Description] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.Icon] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D0A0 Offset: 0x9C4A0 VA: 0x18009D0A0
	// RVA: 0x8A7E40 Offset: 0x8A7240 VA: 0x1808A7E40
	public void UseBench(BasePlayer player) { }

	// RVA: 0x8A7A10 Offset: 0x8A6E10 VA: 0x1808A7A10
	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	// RVA: 0x8A7E00 Offset: 0x8A7200 VA: 0x1808A7E00
	public void TryExperiment() { }

	// RVA: 0x8A7B60 Offset: 0x8A6F60 VA: 0x1808A7B60
	public bool PlayerUnlockedThisTier() { }

	// RVA: 0x8A75F0 Offset: 0x8A69F0 VA: 0x1808A75F0
	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	// RVA: 0x8A7980 Offset: 0x8A6D80 VA: 0x1808A7980
	public int GetScrapForExperiment() { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool IsWorking() { }

	// RVA: 0x8A7E80 Offset: 0x8A7280 VA: 0x1808A7E80
	public void .ctor() { }

}

