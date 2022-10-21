public class Candle : BaseCombatEntity, ISplashable, IIgniteable // TypeDefIndex: 10073
{
	private Option __menuOption_Menu_Extinguish; 
	private Option __menuOption_Menu_Ignite; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Ignite(BasePlayer player) { }

	public bool Menu_Ignite_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Extinguish(BasePlayer player) { }

	public bool Menu_Extinguish_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

