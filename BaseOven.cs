public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 8334
{
	private Option __menuOption_SwitchOff; 
	private Option __menuOption_SwitchOn; 
	private static Dictionary<float, HashSet<ItemDefinition>> _materialOutputCache; 
	public BaseOven.TemperatureType temperature; 
	public BaseEntity.Menu.Option switchOnMenu; 
	public BaseEntity.Menu.Option switchOffMenu; 
	public ItemAmount[] startupContents; 
	public bool allowByproductCreation; 
	public ItemDefinition fuelType; 
	public bool canModFire; 
	public bool disabledBySplash; 
	public int smeltSpeed; 
	public int fuelSlots; 
	public int inputSlots; 
	public int outputSlots; 

	public override bool HasMenuOptions { get; }
	private float cookingTemperature { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private float get_cookingTemperature() { }

	private bool IsBurnableItem(Item item) { }

	private bool IsBurnableByproduct(Item item) { }

	private bool IsMaterialInput(Item item) { }

	private bool IsMaterialOutput(Item item) { }

	private bool IsOutputItem(Item item) { }

	private void BuildMaterialOutputCache() { }

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

public enum BaseOven.TemperatureType // TypeDefIndex: 8335
{
	public int value__; 
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

private sealed class BaseOven.<>c // TypeDefIndex: 8336
{
	public static readonly BaseOven.<>c <>9; 
	public static Func<GameObject, BaseOven> <>9__27_0; 
	public static Func<BaseOven, bool> <>9__27_1; 
	public static Func<BaseOven, float> <>9__27_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal BaseOven <BuildMaterialOutputCache>b__27_0(GameObject x) { }

	internal bool <BuildMaterialOutputCache>b__27_1(BaseOven x) { }

	internal float <BuildMaterialOutputCache>b__27_2(BaseOven x) { }

}

