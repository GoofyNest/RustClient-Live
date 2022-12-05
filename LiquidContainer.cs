public class LiquidContainer : ContainerIOEntity // TypeDefIndex: 10125
{
	private Option __menuOption_MenuDrink;
	public ItemDefinition defaultLiquid;
	public int startingAmount;
	public bool autofillOutputs;
	public float autofillTickRate;
	public int autofillTickAmount;
	public int maxOutputFlow;
	public ItemDefinition[] ValidItems;

	public override bool HasMenuOptions { get; }
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool get_IsGravitySource() { }

	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void MenuDrink(BasePlayer player) { }

	public virtual bool MenuDrink_ShowIf(BasePlayer player) { }

	public virtual bool DrinkEligable(BasePlayer player) { }

	public virtual bool CanDrainIntoVessel(BasePlayer player) { }

	public void .ctor() { }

}

