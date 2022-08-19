public class FuelGenerator : ContainerIOEntity // TypeDefIndex: 8394
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0
	public int outputEnergy; // 0x428
	public float fuelPerSec; // 0x42C

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6F26A0 Offset: 0x6F1AA0 VA: 0x1806F26A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F2DA0 Offset: 0x6F21A0 VA: 0x1806F2DA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F2C90 Offset: 0x6F2090 VA: 0x1806F2C90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x6F2BC0 Offset: 0x6F1FC0 VA: 0x1806F2BC0 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 150
	public override int ConsumptionAmount() { }

	[BaseEntity.Menu] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.Description] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.Icon] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	// RVA: 0x6F2C40 Offset: 0x6F2040 VA: 0x1806F2C40
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6F2BD0 Offset: 0x6F1FD0 VA: 0x1806F2BD0
	public bool Menu_GeneratorOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.Description] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.Icon] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	// RVA: 0x6F2BF0 Offset: 0x6F1FF0 VA: 0x1806F2BF0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90
	public bool Menu_GeneratorOff_ShowIf(BasePlayer player) { }

	// RVA: 0x6F2D80 Offset: 0x6F2180 VA: 0x1806F2D80
	public void .ctor() { }

}

