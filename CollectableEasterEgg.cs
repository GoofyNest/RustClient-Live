public class CollectableEasterEgg : BaseEntity // TypeDefIndex: 10081
{
	private Option __menuOption_Menu_Pickup; 
	public Transform artwork; 
	public float bounceRange; 
	public float bounceSpeed; 
	public GameObjectRef pickupEffect; 
	public ItemDefinition itemToGive; 
	private float randOffset; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void BasketPickup() { }

	public void DelayedPickup() { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Pickup(BasePlayer player) { }

	public void Menu_Pickup_Start() { }

	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

