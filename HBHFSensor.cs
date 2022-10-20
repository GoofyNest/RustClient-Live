public class HBHFSensor : BaseDetector // TypeDefIndex: 10103
{
	private Option __menuOption_Menu_ExcludeAuth; 
	private Option __menuOption_Menu_ExcludeOthers; 
	private Option __menuOption_Menu_IncludeAuth; 
	private Option __menuOption_Menu_IncludeOthers; 
	public GameObjectRef detectUp; 
	public GameObjectRef detectDown; 
	public const BaseEntity.Flags Flag_IncludeOthers = 256;
	public const BaseEntity.Flags Flag_IncludeAuthed = 512;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool ShouldIncludeAuthorized() { }

	public bool ShouldIncludeOthers() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_IncludeAuth(BasePlayer player) { }

	public bool Menu_IncludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_ExcludeAuth(BasePlayer player) { }

	public bool Menu_ExcludeAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_IncludeOthers(BasePlayer player) { }

	public bool Menu_IncludeOthers_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_ExcludeOthers(BasePlayer player) { }

	public bool Menu_ExcludeOthers_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

