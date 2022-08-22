public class FuelGenerator : ContainerIOEntity // TypeDefIndex: 8394
{	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0
	public int outputEnergy; // 0x428
	public float fuelPerSec; // 0x42C

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool IsRootEntity() { }

	public override int MaximalPowerOutput() { }

	public override int ConsumptionAmount() { }

	[BaseEntity.Menu] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.Description] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.Icon] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE04E0 Offset: 0xDF8E0 VA: 0x1800E04E0
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_GeneratorOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.Description] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.Icon] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE08F0 Offset: 0xDFCF0 VA: 0x1800E08F0
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_GeneratorOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

