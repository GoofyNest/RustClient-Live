public class SpookySpeaker : BaseCombatEntity // TypeDefIndex: 10158
{
	private Option __menuOption_Menu_SoundOff; 
	private Option __menuOption_Menu_SoundOn; 
	public SoundPlayer soundPlayer; 
	public float soundSpacing; 
	public float soundSpacingRand; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void PlaySpookySound() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SoundOn(BasePlayer player) { }

	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SoundOff(BasePlayer player) { }

	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

