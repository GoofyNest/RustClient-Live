public class DieselEngine : StorageContainer // TypeDefIndex: 8380
{	// Fields
	private Option __menuOption_Menu_EngineStartup; // 0x3D0
	private Option __menuOption_Menu_NoFuel; // 0x428
	public GameObjectRef rumbleEffect; // 0x480
	public Transform rumbleOrigin; // 0x488
	public const BaseEntity.Flags Flag_HasFuel = 512;
	public float runningTimePerFuelUnit; // 0x490
	private float cachedFuelTime; // 0x494
	private const float rumbleMaxDistSq = 100;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x9C3CF0 Offset: 0x9C30F0 VA: 0x1809C3CF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9C49B0 Offset: 0x9C3DB0 VA: 0x1809C49B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9C4510 Offset: 0x9C3910 VA: 0x1809C4510 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9C4330 Offset: 0x9C3730 VA: 0x1809C4330 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0
	public bool HasFuel() { }

	// RVA: 0x9C4750 Offset: 0x9C3B50 VA: 0x1809C4750 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x5CAB30 Offset: 0x5C9F30 VA: 0x1805CAB30 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x9C4600 Offset: 0x9C3A00 VA: 0x1809C4600
	public void Rumble() { }

	[BaseEntity.Menu] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.Description] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.Icon] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8920 Offset: 0xD7D20 VA: 0x1800D8920
	// RVA: 0x9C4420 Offset: 0x9C3820 VA: 0x1809C4420
	public void Menu_EngineStartup(BasePlayer player) { }

	// RVA: 0x9C4390 Offset: 0x9C3790 VA: 0x1809C4390
	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Description] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.Icon] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8AD0 Offset: 0xD7ED0 VA: 0x1800D8AD0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_NoFuel(BasePlayer player) { }

	// RVA: 0x9C4470 Offset: 0x9C3870 VA: 0x1809C4470
	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	// RVA: 0x9C4950 Offset: 0x9C3D50 VA: 0x1809C4950
	public void .ctor() { }

}

