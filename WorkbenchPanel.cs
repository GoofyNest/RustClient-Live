public class WorkbenchPanel : LootPanel, IInventoryChanged // TypeDefIndex: 11068
{	public Button experimentButton; // 0x38
	public Text timerText; // 0x40
	public Text costText; // 0x48
	public GameObject expermentCostParent; // 0x50
	public GameObject controlsParent; // 0x58
	public GameObject allUnlockedNotification; // 0x60
	public GameObject informationParent; // 0x68
	public GameObject cycleIcon; // 0x70
	public TechTreeDialog techTreeDialog; // 0x78
	private bool wasWorking; // 0x80


	public override void Update() { }

	private void OnEnable() { }

	protected override void OnDisable() { }

	public void ExperimentButtonClicked() { }

	public Workbench GetWorkbench() { }

	public bool CanAffordExperiment() { }

	public void Refresh() { }

	public void OnInventoryChanged() { }

	public bool IsWorking() { }

	public void .ctor() { }

}

