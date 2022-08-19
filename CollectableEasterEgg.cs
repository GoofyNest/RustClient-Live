public class CollectableEasterEgg : BaseEntity // TypeDefIndex: 8374
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x168
	public Transform artwork; // 0x1C0
	public float bounceRange; // 0x1C8
	public float bounceSpeed; // 0x1CC
	public GameObjectRef pickupEffect; // 0x1D0
	public ItemDefinition itemToGive; // 0x1D8
	private float randOffset; // 0x1E0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5955A0 Offset: 0x5949A0 VA: 0x1805955A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x595C10 Offset: 0x595010 VA: 0x180595C10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x595950 Offset: 0x594D50 VA: 0x180595950 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5954B0 Offset: 0x5948B0 VA: 0x1805954B0
	public void BasketPickup() { }

	// RVA: 0x595560 Offset: 0x594960 VA: 0x180595560
	public void DelayedPickup() { }

	// RVA: 0x595520 Offset: 0x594920 VA: 0x180595520 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x595A40 Offset: 0x594E40 VA: 0x180595A40
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.Description] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.Icon] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5B60 Offset: 0xD4F60 VA: 0x1800D5B60
	// RVA: 0x595910 Offset: 0x594D10 VA: 0x180595910
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x5958D0 Offset: 0x594CD0 VA: 0x1805958D0
	public void Menu_Pickup_Start() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0x595BA0 Offset: 0x594FA0 VA: 0x180595BA0
	public void .ctor() { }

}

