public class FuelGenerator : ContainerIOEntity // TypeDefIndex: 10100
{
	private Option __menuOption_Menu_TurnOff; 
	private Option __menuOption_Menu_TurnOn; 
	public int outputEnergy; 
	public float fuelPerSec; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool IsRootEntity() { }

	public override int MaximalPowerOutput() { }

	public override int ConsumptionAmount() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_GeneratorOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_GeneratorOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

