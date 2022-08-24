public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 8333
{
	private Option __menuOption_SwitchOff; 
	private Option __menuOption_SwitchOn; 
	public BaseOven.TemperatureType temperature; 
	public BaseEntity.Menu.Option switchOnMenu; 
	public BaseEntity.Menu.Option switchOffMenu; 
	public ItemAmount[] startupContents; 
	public bool allowByproductCreation; 
	public ItemDefinition fuelType; 
	public bool canModFire; 
	public bool disabledBySplash; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchOn(BasePlayer player) { }

	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchOff(BasePlayer player) { }

	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public enum BaseOven.TemperatureType // TypeDefIndex: 8334
{
	public int value__; 
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

