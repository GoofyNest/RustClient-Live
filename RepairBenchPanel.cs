public class RepairBenchPanel : LootPanel // TypeDefIndex: 11047
{
	public Text infoText; 
	public Button repairButton; 
	public Color gotColor; 
	public Color notGotColor; 
	public Translate.Phrase phraseEmpty; 
	public Translate.Phrase phraseNotRepairable; 
	public Translate.Phrase phraseRepairNotNeeded; 
	public Translate.Phrase phraseNoBlueprint; 
	public GameObject skinsPanel; 
	public GameObject changeSkinDialog; 
	public IconSkinPicker picker; 
	public GameObject attachmentSkinBlocker; 
	private Item _displayItem; 

	public Item item { get; }


	public void OnEnable() { }

	protected override void OnDisable() { }

	public override void Update() { }

	public Item get_item() { }

	public void UpdateAvailableSkins() { }

	public void SkinClicked() { }

	private void DisableAttachmentBlock() { }

	public void RepairClicked() { }

	public bool IsItemRepairable(ItemDefinition info) { }

	private string GetCostText() { }

	private void Refresh() { }

	public void UpdateSkinPanel() { }

	public void .ctor() { }

}

