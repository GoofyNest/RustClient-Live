public class LiquidContainer : ContainerIOEntity // TypeDefIndex: 8404
{	private Option __menuOption_MenuDrink; // 0x378
	public ItemDefinition defaultLiquid; // 0x3D0
	public int startingAmount; // 0x3D8
	public bool autofillOutputs; // 0x3DC
	public float autofillTickRate; // 0x3E0
	public int autofillTickAmount; // 0x3E4
	public int maxOutputFlow; // 0x3E8
	public ItemDefinition[] ValidItems; // 0x3F0

	public override bool HasMenuOptions { get; }
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool get_IsGravitySource() { }

	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	[BaseEntity.Menu] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.Description] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.Icon] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEA2D0 Offset: 0xE96D0 VA: 0x1800EA2D0
	public void MenuDrink(BasePlayer player) { }

	public virtual bool MenuDrink_ShowIf(BasePlayer player) { }

	public virtual bool DrinkEligable(BasePlayer player) { }

	public virtual bool CanDrainIntoVessel(BasePlayer player) { }

	public void .ctor() { }

}

