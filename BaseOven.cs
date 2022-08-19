public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 8333
{	// Fields
	private Option __menuOption_SwitchOff; // 0x3D0
	private Option __menuOption_SwitchOn; // 0x428
	public BaseOven.TemperatureType temperature; // 0x480
	public BaseEntity.Menu.Option switchOnMenu; // 0x488
	public BaseEntity.Menu.Option switchOffMenu; // 0x4A8
	public ItemAmount[] startupContents; // 0x4C8
	public bool allowByproductCreation; // 0x4D0
	public ItemDefinition fuelType; // 0x4D8
	public bool canModFire; // 0x4E0
	public bool disabledBySplash; // 0x4E1

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA30150 Offset: 0xA2F550 VA: 0x180A30150 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA308D0 Offset: 0xA2FCD0 VA: 0x180A308D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA306C0 Offset: 0xA2FAC0 VA: 0x180A306C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA306A0 Offset: 0xA2FAA0 VA: 0x180A306A0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9CF0 Offset: 0xB90F0 VA: 0x1800B9CF0
	// RVA: 0xA30880 Offset: 0xA2FC80 VA: 0x180A30880
	public void SwitchOn(BasePlayer player) { }

	// RVA: 0xA30840 Offset: 0xA2FC40 VA: 0x180A30840 Slot: 155
	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	// RVA: 0xA307F0 Offset: 0xA2FBF0 VA: 0x180A307F0
	public void SwitchOff(BasePlayer player) { }

	// RVA: 0xA307B0 Offset: 0xA2FBB0 VA: 0x180A307B0 Slot: 156
	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA1A5E0 Offset: 0xA199E0 VA: 0x180A1A5E0
	public void .ctor() { }

}

public enum BaseOven.TemperatureType // TypeDefIndex: 8334
{	// Fields
	public int value__; // 0x0
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

