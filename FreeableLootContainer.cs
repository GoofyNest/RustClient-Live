public class FreeableLootContainer : LootContainer // TypeDefIndex: 8393
{	private Option __menuOption_Menu_FreeCrate; // 0x418
	private const BaseEntity.Flags tiedDown = 65536;
	public Buoyancy buoyancy; // 0x470
	public GameObjectRef freedEffect; // 0x478
	private Rigidbody rb; // 0x480
	public uint skinOverride; // 0x488

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Rigidbody GetRB() { }

	public bool IsTiedDown() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.Description] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.Icon] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0210 Offset: 0xDF610 VA: 0x1800E0210
	public void Menu_FreeCrate(BasePlayer player) { }

	public void Menu_FreeCrate_Start() { }

	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

