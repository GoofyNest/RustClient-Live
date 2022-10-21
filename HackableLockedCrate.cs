public class HackableLockedCrate : LootContainer // TypeDefIndex: 10103
{
	private Option __menuOption_Menu_Hack; 
	public const BaseEntity.Flags Flag_Hacking = 128;
	public const BaseEntity.Flags Flag_FullyHacked = 256;
	public Text timerText; 
	[ServerVar] 
	public static float requiredHackSeconds; 
	[ServerVar] 
	public static float decaySeconds; 
	public SoundPlayer hackProgressBeep; 
	private float hackSeconds; 
	public GameObjectRef shockEffect; 
	public GameObjectRef mapMarkerEntityPrefab; 
	public GameObjectRef landEffect; 
	public bool shouldDecay; 
	private int beepSeconds; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsBeingHacked() { }

	public bool IsFullyHacked() { }

	public override void DestroyShared() { }

	[BaseEntity.RPC_Client] 
	public void UpdateHackProgress(int totalSecondsComplete, int totalSecondsRequired) { }

	public override void PostNetworkUpdate() { }

	public void HackScreenUpdate() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Hack(BasePlayer player) { }

	public bool Menu_Hack_ShowIf(BasePlayer player) { }

	public override float GetExtrapolationTime() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

