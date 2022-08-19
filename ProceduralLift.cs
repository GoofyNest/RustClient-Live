public class ProceduralLift : BaseEntity // TypeDefIndex: 8432
{	// Fields
	private Option __menuOption_Menu_UseLift; // 0x168
	public float movementSpeed; // 0x1C0
	public float resetDelay; // 0x1C4
	public ProceduralLiftCabin cabin; // 0x1C8
	public ProceduralLiftStop[] stops; // 0x1D0
	public GameObjectRef triggerPrefab; // 0x1D8
	public string triggerBone; // 0x1E0
	private int floorIndex; // 0x1E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x988290 Offset: 0x987690 VA: 0x180988290 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x988DC0 Offset: 0x9881C0 VA: 0x180988DC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9887F0 Offset: 0x987BF0 VA: 0x1809887F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x988580 Offset: 0x987980 VA: 0x180988580 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Description] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Icon] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	// RVA: 0x988720 Offset: 0x987B20 VA: 0x180988720
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x988700 Offset: 0x987B00 VA: 0x180988700
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x9888E0 Offset: 0x987CE0 VA: 0x1809888E0
	private void ResetLift() { }

	// RVA: 0x988760 Offset: 0x987B60 VA: 0x180988760
	private void MoveToFloor(int floor) { }

	// RVA: 0x9888F0 Offset: 0x987CF0 VA: 0x1809888F0
	private void SnapToFloor(int floor) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void OnFinishedMoving() { }

	// RVA: 0x988A10 Offset: 0x987E10 VA: 0x180988A10
	protected void Update() { }

	// RVA: 0x988D50 Offset: 0x988150 VA: 0x180988D50
	public void .ctor() { }

}

