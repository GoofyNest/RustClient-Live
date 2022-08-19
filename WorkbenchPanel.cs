public class WorkbenchPanel : LootPanel, IInventoryChanged // TypeDefIndex: 11068
{	// Fields
	public Button experimentButton; // 0x38
	public Text timerText; // 0x40
	public Text costText; // 0x48
	public GameObject expermentCostParent; // 0x50
	public GameObject controlsParent; // 0x58
	public GameObject allUnlockedNotification; // 0x60
	public GameObject informationParent; // 0x68
	public GameObject cycleIcon; // 0x70
	public TechTreeDialog techTreeDialog; // 0x78
	private bool wasWorking; // 0x80

	// Methods

	// RVA: 0x8A7520 Offset: 0x8A6920 VA: 0x1808A7520 Slot: 5
	public override void Update() { }

	// RVA: 0x8A7380 Offset: 0x8A6780 VA: 0x1808A7380
	private void OnEnable() { }

	// RVA: 0x8A72C0 Offset: 0x8A66C0 VA: 0x1808A72C0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x8A7070 Offset: 0x8A6470 VA: 0x1808A7070
	public void ExperimentButtonClicked() { }

	// RVA: 0x8A7160 Offset: 0x8A6560 VA: 0x1808A7160
	public Workbench GetWorkbench() { }

	// RVA: 0x8A6ED0 Offset: 0x8A62D0 VA: 0x1808A6ED0
	public bool CanAffordExperiment() { }

	// RVA: 0x8A7410 Offset: 0x8A6810 VA: 0x1808A7410
	public void Refresh() { }

	// RVA: 0x8A7400 Offset: 0x8A6800 VA: 0x1808A7400 Slot: 7
	public void OnInventoryChanged() { }

	// RVA: 0x8A71F0 Offset: 0x8A65F0 VA: 0x1808A71F0
	public bool IsWorking() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

