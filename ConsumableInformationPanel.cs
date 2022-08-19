public class ConsumableInformationPanel : ItemInformationPanel // TypeDefIndex: 10998
{	// Fields
	public ItemTextValue[] values; // 0x18
	public UIGenesDisplay Genes; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public Text LabelGenetics; // 0x30
	public GameObject GeneticsGameObject; // 0x38
	public ItemTextValue durationValue; // 0x40
	public ItemTextValue baitValue; // 0x48
	private GrowableGenes genes; // 0x50

	// Methods

	// RVA: 0x511950 Offset: 0x510D50 VA: 0x180511950 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x511B00 Offset: 0x510F00 VA: 0x180511B00
	private void GetValues() { }

	// RVA: 0x511B70 Offset: 0x510F70 VA: 0x180511B70 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x5124D0 Offset: 0x5118D0 VA: 0x1805124D0
	private void SetupGenes(Item item) { }

	// RVA: 0x512550 Offset: 0x511950 VA: 0x180512550
	public void .ctor() { }

}

