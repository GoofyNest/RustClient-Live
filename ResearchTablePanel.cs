public class ResearchTablePanel : LootPanel // TypeDefIndex: 11048
{	// Fields
	public Button researchButton; // 0x38
	public Text timerText; // 0x40
	public GameObject itemDescNoItem; // 0x48
	public GameObject itemDescTooBroken; // 0x50
	public GameObject itemDescNotResearchable; // 0x58
	public GameObject itemDescTooMany; // 0x60
	public GameObject itemTakeBlueprint; // 0x68
	public GameObject itemDescAlreadyResearched; // 0x70
	public Text successChanceText; // 0x78
	public ItemIcon scrapIcon; // 0x80
	public bool wasResearching; // 0x88
	public GameObject[] workbenchReqs; // 0x90
	private Item _researchItem; // 0x98

	// Properties
	public Item researchItem { get; }

	// Methods

	// RVA: 0x9337F0 Offset: 0x932BF0 VA: 0x1809337F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x934330 Offset: 0x933730 VA: 0x180934330 Slot: 5
	public override void Update() { }

	// RVA: 0x933D90 Offset: 0x933190 VA: 0x180933D90
	public void ResearchClicked() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public Item get_researchItem() { }

	// RVA: 0x933810 Offset: 0x932C10 VA: 0x180933810
	public bool IsResearching() { }

	// RVA: 0x933E20 Offset: 0x933220 VA: 0x180933E20
	public float ResearchTimeLeft() { }

	// RVA: 0x9338E0 Offset: 0x932CE0 VA: 0x1809338E0
	private void Refresh() { }

	// RVA: 0x933F70 Offset: 0x933370 VA: 0x180933F70
	private void UpdateResearchProgress() { }

	// RVA: 0x934100 Offset: 0x933500 VA: 0x180934100
	public void UpdateWorkbenchNotifications() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

