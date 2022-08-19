public class DudTimedExplosive : TimedExplosive, IIgniteable, ISplashable // TypeDefIndex: 8384
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x1B8
	public GameObjectRef fizzleEffect; // 0x210
	public GameObject wickSpark; // 0x218
	public AudioSource wickSound; // 0x220
	public float dudChance; // 0x228
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition itemToGive; // 0x230
	private float explodeTime; // 0x238

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAAE190 Offset: 0xAAD590 VA: 0x180AAE190 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAE950 Offset: 0xAADD50 VA: 0x180AAE950 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAE5A0 Offset: 0xAAD9A0 VA: 0x180AAE5A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	private bool IsWickBurning() { }

	// RVA: 0xAAE490 Offset: 0xAAD890 VA: 0x180AAE490 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAAE690 Offset: 0xAADA90 VA: 0x180AAE690
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDA260 Offset: 0xD9660 VA: 0x1800DA260
	[BaseEntity.Menu.Description] // RVA: 0xDA260 Offset: 0xD9660 VA: 0x1800DA260
	[BaseEntity.Menu.Icon] // RVA: 0xDA260 Offset: 0xD9660 VA: 0x1800DA260
	[BaseEntity.Menu.ShowIf] // RVA: 0xDA260 Offset: 0xD9660 VA: 0x1800DA260
	// RVA: 0xAAE560 Offset: 0xAAD960 VA: 0x180AAE560
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x5277F0 Offset: 0x526BF0 VA: 0x1805277F0
	public bool Menu_PickupDud_ShowIf(BasePlayer player) { }

	// RVA: 0xAAE930 Offset: 0xAADD30 VA: 0x180AAE930
	public void .ctor() { }

}

