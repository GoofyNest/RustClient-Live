public class ConsumableInformationPanel : ItemInformationPanel // TypeDefIndex: 10998
{	public ItemTextValue[] values; // 0x18
	public UIGenesDisplay Genes; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public Text LabelGenetics; // 0x30
	public GameObject GeneticsGameObject; // 0x38
	public ItemTextValue durationValue; // 0x40
	public ItemTextValue baitValue; // 0x48
	private GrowableGenes genes; // 0x50


	public override bool EligableForDisplay(ItemDefinition info) { }

	private void GetValues() { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	private void SetupGenes(Item item) { }

	public void .ctor() { }

}

