public class DieselEngine : StorageContainer // TypeDefIndex: 8380
{	private Option __menuOption_Menu_EngineStartup; // 0x3D0
	private Option __menuOption_Menu_NoFuel; // 0x428
	public GameObjectRef rumbleEffect; // 0x480
	public Transform rumbleOrigin; // 0x488
	public const BaseEntity.Flags Flag_HasFuel = 512;
	public float runningTimePerFuelUnit; // 0x490
	private float cachedFuelTime; // 0x494
	private const float rumbleMaxDistSq = 100;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool HasFuel() { }

	public override bool ShouldShowLootMenus() { }

	public override void PostNetworkUpdate() { }

	public void Rumble() { }

	[BaseEntity.Menu] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.Description] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.Icon] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	public void Menu_EngineStartup(BasePlayer player) { }

	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Description] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	public void Menu_NoFuel(BasePlayer player) { }

	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

