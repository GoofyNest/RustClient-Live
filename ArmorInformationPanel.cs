public class ArmorInformationPanel : ItemInformationPanel // TypeDefIndex: 10980
{	public ItemTextValue projectileDisplay; // 0x18
	public ItemTextValue meleeDisplay; // 0x20
	public ItemTextValue coldDisplay; // 0x28
	public ItemTextValue explosionDisplay; // 0x30
	public ItemTextValue radiationDisplay; // 0x38
	public ItemTextValue biteDisplay; // 0x40
	public ItemTextValue spacer; // 0x48
	public Text areaProtectionText; // 0x50
	public Translate.Phrase LegText; // 0x58
	public Translate.Phrase ChestText; // 0x60
	public Translate.Phrase HeadText; // 0x68
	public Translate.Phrase ChestLegsText; // 0x70
	public Translate.Phrase WholeBodyText; // 0x78
	public ItemTextValue eggVision; // 0x80


	public override bool EligableForDisplay(ItemDefinition info) { }

	public string ProtectionAreaText(ItemModWearable wearable) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

