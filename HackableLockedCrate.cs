public class HackableLockedCrate : LootContainer // TypeDefIndex: 8396
{	private Option __menuOption_Menu_Hack; // 0x418
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsBeingHacked() { }

	public bool IsFullyHacked() { }

	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	public override void PostNetworkUpdate() { }

	public void HackScreenUpdate() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.Description] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.Icon] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE66E0 Offset: 0xE5AE0 VA: 0x1800E66E0
	public void Menu_Hack(BasePlayer player) { }

	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	public override float GetExtrapolationTime() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

