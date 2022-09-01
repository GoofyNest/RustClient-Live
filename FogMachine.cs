public class FogMachine : StorageContainer // TypeDefIndex: 8281
{
	public const BaseEntity.Flags FogFieldOn = 65536;
	public const BaseEntity.Flags MotionMode = 32768;
	public const BaseEntity.Flags Emitting = 16384;
	public const BaseEntity.Flags Flag_HasJuice = 2048;
	public float fogLength; 
	public float nozzleBlastDuration; 
	private Option __menuOption_Menu_FogOff; 
	private Option __menuOption_Menu_MotionOff; 
	private Option __menuOption_Menu_MotionOn; 
	private Option __menuOption_Menu_TurnOn; 

	public override bool HasMenuOptions { get; }


	public bool IsEmitting() { }

	public bool HasJuice() { }

	public virtual bool MotionModeEnabled() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_FogOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_FogOff(BasePlayer player) { }

	public bool Menu_FogOff_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MotionOn(BasePlayer player) { }

	public bool Menu_MotionOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MotionOff(BasePlayer player) { }

	public bool Menu_MotionOff_ShowIf(BasePlayer player) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

