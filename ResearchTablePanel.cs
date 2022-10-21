public class ResearchTablePanel : LootPanel // TypeDefIndex: 12795
{
	public Button researchButton; 
	public Text timerText; 
	public GameObject itemDescNoItem; 
	public GameObject itemDescTooBroken; 
	public GameObject itemDescNotResearchable; 
	public GameObject itemDescTooMany; 
	public GameObject itemTakeBlueprint; 
	public GameObject itemDescAlreadyResearched; 
	public Text successChanceText; 
	public ItemIcon scrapIcon; 
	public bool wasResearching; 
	public GameObject[] workbenchReqs; 
	private Item _researchItem; 

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

