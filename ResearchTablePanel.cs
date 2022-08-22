public class ResearchTablePanel : LootPanel // TypeDefIndex: 11048
{	public Button researchButton; // 0x38
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

	public Item researchItem { get; }


	protected override void Awake() { }

	public override void Update() { }

	public void ResearchClicked() { }

	public Item get_researchItem() { }

	public bool IsResearching() { }

	public float ResearchTimeLeft() { }

	private void Refresh() { }

	private void UpdateResearchProgress() { }

	public void UpdateWorkbenchNotifications() { }

	public void .ctor() { }

}

