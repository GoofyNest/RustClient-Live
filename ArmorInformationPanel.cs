public class ArmorInformationPanel : ItemInformationPanel // TypeDefIndex: 12743
{
	public ItemTextValue projectileDisplay; 
	public ItemTextValue meleeDisplay; 
	public ItemTextValue coldDisplay; 
	public ItemTextValue explosionDisplay; 
	public ItemTextValue radiationDisplay; 
	public ItemTextValue biteDisplay; 
	public ItemTextValue spacer; 
	public Text areaProtectionText; 
	public Translate.Phrase LegText; 
	public Translate.Phrase ChestText; 
	public Translate.Phrase HeadText; 
	public Translate.Phrase ChestLegsText; 
	public Translate.Phrase WholeBodyText; 
	public ItemTextValue eggVision; 


	public override bool EligableForDisplay(ItemDefinition info) { }

	public string ProtectionAreaText(ItemModWearable wearable) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

