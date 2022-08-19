public class LootPanelEngine : LootPanel // TypeDefIndex: 11029
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image engineImage; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ItemIcon[] icons; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject warning; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText hp; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText power; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText acceleration; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText topSpeed; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText fuelEconomy; // 0x70

	// Methods

	// RVA: 0x504480 Offset: 0x503880 VA: 0x180504480
	protected void OnEnable() { }

	// RVA: 0x504920 Offset: 0x503D20 VA: 0x180504920 Slot: 5
	public override void Update() { }

	// RVA: 0x503F50 Offset: 0x503350 VA: 0x180503F50
	public EngineStorage GetEngineStorage() { }

	// RVA: 0x5045C0 Offset: 0x5039C0 VA: 0x1805045C0
	private void RefreshStats(EngineStorage engineBayStorage) { }

	// RVA: 0x503FE0 Offset: 0x5033E0 VA: 0x180503FE0
	public void OnDroppedOnEngine(BaseEventData data) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

