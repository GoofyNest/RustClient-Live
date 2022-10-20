public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 10090
{
	private Option __menuOption_Menu_Pickup; 
	public GameObjectRef fizzleEffect; 
	public GameObject wickSpark; 
	public AudioSource wickSound; 
	public float dudChance; 
	[ItemSelector] 
	public ItemDefinition itemToGive; 
	private float explodeTime; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool IsWickBurning() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Pickup(BasePlayer player) { }

	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

