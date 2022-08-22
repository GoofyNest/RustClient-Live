public class ExplosiveInformationPanel : ItemInformationPanel // TypeDefIndex: 11002
{	public ItemTextValue explosiveDmgDisplay; // 0x18
	public ItemTextValue lethalDmgDisplay; // 0x20
	public ItemTextValue throwDistanceDisplay; // 0x28
	public ItemTextValue projectileDistanceDisplay; // 0x30
	public ItemTextValue fuseLengthDisplay; // 0x38
	public ItemTextValue blastRadiusDisplay; // 0x40
	public Text unreliableText; // 0x48


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

