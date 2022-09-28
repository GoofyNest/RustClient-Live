public class CustomTimerSwitch : TimerSwitch // TypeDefIndex: 10048
{
	private Option __menuOption_Menu_SetTime; 
	public GameObjectRef timerPanelPrefab; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public void SendNewTime(float seconds) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetTime(BasePlayer player) { }

	public bool Menu_SetTime_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

