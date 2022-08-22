public class CollectableEasterEgg : BaseEntity // TypeDefIndex: 8374
{	private Option __menuOption_Menu_Pickup; // 0x168
	public Transform artwork; // 0x1C0
	public float bounceRange; // 0x1C8
	public float bounceSpeed; // 0x1CC
	public GameObjectRef pickupEffect; // 0x1D0
	public ItemDefinition itemToGive; // 0x1D8
	private float randOffset; // 0x1E0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void BasketPickup() { }

	public void DelayedPickup() { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.Description] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.Icon] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	public void Menu_Pickup(BasePlayer player) { }

	public void Menu_Pickup_Start() { }

	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

