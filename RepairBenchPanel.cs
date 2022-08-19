public class RepairBenchPanel : LootPanel // TypeDefIndex: 11047
{	// Fields
	public Text infoText; // 0x38
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

	// Properties
	public Item item { get; }

	// Methods

	// RVA: 0x9319B0 Offset: 0x930DB0 VA: 0x1809319B0
	public void OnEnable() { }

	// RVA: 0x9318B0 Offset: 0x930CB0 VA: 0x1809318B0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x932180 Offset: 0x931580 VA: 0x180932180 Slot: 5
	public override void Update() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public Item get_item() { }

	// RVA: 0x931F20 Offset: 0x931320 VA: 0x180931F20
	public void UpdateAvailableSkins() { }

	// RVA: 0x931DE0 Offset: 0x9311E0 VA: 0x180931DE0
	public void SkinClicked() { }

	// RVA: 0x930FA0 Offset: 0x9303A0 VA: 0x180930FA0
	private void DisableAttachmentBlock() { }

	// RVA: 0x931D50 Offset: 0x931150 VA: 0x180931D50
	public void RepairClicked() { }

	// RVA: 0x931820 Offset: 0x930C20 VA: 0x180931820
	public bool IsItemRepairable(ItemDefinition info) { }

	// RVA: 0x930FD0 Offset: 0x9303D0 VA: 0x180930FD0
	private string GetCostText() { }

	// RVA: 0x931A60 Offset: 0x930E60 VA: 0x180931A60
	private void Refresh() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void UpdateSkinPanel() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

