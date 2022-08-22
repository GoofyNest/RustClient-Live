public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 8333
{	private Option __menuOption_SwitchOff; // 0x3D0
	private Option __menuOption_SwitchOn; // 0x428
	public BaseOven.TemperatureType temperature; // 0x480
	public BaseEntity.Menu.Option switchOnMenu; // 0x488
	public BaseEntity.Menu.Option switchOffMenu; // 0x4A8
	public ItemAmount[] startupContents; // 0x4C8
	public bool allowByproductCreation; // 0x4D0
	public ItemDefinition fuelType; // 0x4D8
	public bool canModFire; // 0x4E0
	public bool disabledBySplash; // 0x4E1

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	public void SwitchOn(BasePlayer player) { }

	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	public void SwitchOff(BasePlayer player) { }

	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public enum BaseOven.TemperatureType // TypeDefIndex: 8334
{	public int value__; // 0x0
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

