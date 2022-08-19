public class LiquidContainer : ContainerIOEntity // TypeDefIndex: 8404
{	// Fields
	private Option __menuOption_MenuDrink; // 0x378
	public ItemDefinition defaultLiquid; // 0x3D0
	public int startingAmount; // 0x3D8
	public bool autofillOutputs; // 0x3DC
	public float autofillTickRate; // 0x3E0
	public int autofillTickAmount; // 0x3E4
	public int maxOutputFlow; // 0x3E8
	public ItemDefinition[] ValidItems; // 0x3F0

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x4F0280 Offset: 0x4EF680 VA: 0x1804F0280 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4F07C0 Offset: 0x4EFBC0 VA: 0x1804F07C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x4F0660 Offset: 0x4EFA60 VA: 0x1804F0660 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x4F0780 Offset: 0x4EFB80 VA: 0x1804F0780 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	[BaseEntity.Menu] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.Description] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.Icon] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	// RVA: 0x4F0620 Offset: 0x4EFA20 VA: 0x1804F0620
	public void MenuDrink(BasePlayer player) { }

	// RVA: 0x4F05A0 Offset: 0x4EF9A0 VA: 0x1804F05A0 Slot: 167
	public virtual bool MenuDrink_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 168
	public virtual bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 169
	public virtual bool CanDrainIntoVessel(BasePlayer player) { }

	// RVA: 0x4F0750 Offset: 0x4EFB50 VA: 0x1804F0750
	public void .ctor() { }

}

