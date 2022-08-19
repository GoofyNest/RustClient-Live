public class FreeableLootContainer : LootContainer // TypeDefIndex: 8393
{	// Fields
	private Option __menuOption_Menu_FreeCrate; // 0x418
	private const BaseEntity.Flags tiedDown = 65536;
	public Buoyancy buoyancy; // 0x470
	public GameObjectRef freedEffect; // 0x478
	private Rigidbody rb; // 0x480
	public uint skinOverride; // 0x488

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6F15E0 Offset: 0x6F09E0 VA: 0x1806F15E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F1B50 Offset: 0x6F0F50 VA: 0x1806F1B50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F1A10 Offset: 0x6F0E10 VA: 0x1806F1A10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6F1930 Offset: 0x6F0D30 VA: 0x1806F1930
	public Rigidbody GetRB() { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool IsTiedDown() { }

	// RVA: 0x6F1B00 Offset: 0x6F0F00 VA: 0x1806F1B00 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.Description] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.Icon] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	// RVA: 0x6F19D0 Offset: 0x6F0DD0 VA: 0x1806F19D0
	public void Menu_FreeCrate(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_FreeCrate_Start() { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	// RVA: 0x6F1B40 Offset: 0x6F0F40 VA: 0x1806F1B40
	public void .ctor() { }

}

