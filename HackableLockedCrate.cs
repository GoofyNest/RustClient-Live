public class HackableLockedCrate : LootContainer // TypeDefIndex: 8396
{	// Fields
	private Option __menuOption_Menu_Hack; // 0x418
	public const BaseEntity.Flags Flag_Hacking = 128;
	public const BaseEntity.Flags Flag_FullyHacked = 256;
	public Text timerText; // 0x470
	[ServerVar] // RVA: 0xE6380 Offset: 0xE5780 VA: 0x1800E6380
	public static float requiredHackSeconds; // 0x0
	[ServerVar] // RVA: 0xE6470 Offset: 0xE5870 VA: 0x1800E6470
	public static float decaySeconds; // 0x4
	public SoundPlayer hackProgressBeep; // 0x478
	private float hackSeconds; // 0x480
	public GameObjectRef shockEffect; // 0x488
	public GameObjectRef mapMarkerEntityPrefab; // 0x490
	public GameObjectRef landEffect; // 0x498
	public bool shouldDecay; // 0x4A0
	private int beepSeconds; // 0x4A4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x74CA80 Offset: 0x74BE80 VA: 0x18074CA80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x74D840 Offset: 0x74CC40 VA: 0x18074D840 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x74D190 Offset: 0x74C590 VA: 0x18074D190 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsBeingHacked() { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool IsFullyHacked() { }

	// RVA: 0x6D0C70 Offset: 0x6D0070 VA: 0x1806D0C70 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x74D710 Offset: 0x74CB10 VA: 0x18074D710
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	// RVA: 0x5CAB30 Offset: 0x5C9F30 VA: 0x1805CAB30 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x74CD90 Offset: 0x74C190 VA: 0x18074CD90
	public void HackScreenUpdate() { }

	// RVA: 0x74D660 Offset: 0x74CA60 VA: 0x18074D660 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.Description] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.Icon] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	// RVA: 0x74D150 Offset: 0x74C550 VA: 0x18074D150
	public void Menu_Hack(BasePlayer player) { }

	// RVA: 0x74D090 Offset: 0x74C490 VA: 0x18074D090
	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	// RVA: 0x74C9F0 Offset: 0x74BDF0 VA: 0x18074C9F0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x74C940 Offset: 0x74BD40 VA: 0x18074C940 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x74D830 Offset: 0x74CC30 VA: 0x18074D830
	public void .ctor() { }

	// RVA: 0x74D7E0 Offset: 0x74CBE0 VA: 0x18074D7E0
	private static void .cctor() { }

}

