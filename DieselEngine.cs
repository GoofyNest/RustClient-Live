public class DieselEngine : StorageContainer // TypeDefIndex: 10051
{
	private Option __menuOption_Menu_EngineStartup; 
	private Option __menuOption_Menu_NoFuel; 
	public GameObjectRef rumbleEffect; 
	public Transform rumbleOrigin; 
	public const BaseEntity.Flags Flag_HasFuel = 512;
	public float runningTimePerFuelUnit; 
	private float cachedFuelTime; 
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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_EngineStartup(BasePlayer player) { }

	public bool Menu_EngineStartup_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_NoFuel(BasePlayer player) { }

	public bool Menu_NoFuel_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

