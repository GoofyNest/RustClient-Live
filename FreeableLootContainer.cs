public class FreeableLootContainer : LootContainer // TypeDefIndex: 8395
{
	private Option __menuOption_Menu_FreeCrate; 
	private const BaseEntity.Flags tiedDown = 65536;
	public Buoyancy buoyancy; 
	public GameObjectRef freedEffect; 
	private Rigidbody rb; 
	public uint skinOverride; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Rigidbody GetRB() { }

	public bool IsTiedDown() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_FreeCrate(BasePlayer player) { }

	public void Menu_FreeCrate_Start() { }

	public bool Menu_FreeCrate_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

