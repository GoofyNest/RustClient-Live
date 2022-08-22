public class RepairBenchPanel : LootPanel // TypeDefIndex: 11047
{	public Text infoText; // 0x38
	public Button repairButton; // 0x40
	public Color gotColor; // 0x48
	public Color notGotColor; // 0x58
	public Translate.Phrase phraseEmpty; // 0x68
	public Translate.Phrase phraseNotRepairable; // 0x70
	public Translate.Phrase phraseRepairNotNeeded; // 0x78
	public Translate.Phrase phraseNoBlueprint; // 0x80
	public GameObject skinsPanel; // 0x88
	public GameObject changeSkinDialog; // 0x90
	public IconSkinPicker picker; // 0x98
	public GameObject attachmentSkinBlocker; // 0xA0
	private Item _displayItem; // 0xA8

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

