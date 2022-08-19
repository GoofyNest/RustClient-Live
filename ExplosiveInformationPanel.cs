public class ExplosiveInformationPanel : ItemInformationPanel // TypeDefIndex: 11002
{	// Fields
	public ItemTextValue explosiveDmgDisplay; // 0x18
	public ItemTextValue lethalDmgDisplay; // 0x20
	public ItemTextValue throwDistanceDisplay; // 0x28
	public ItemTextValue projectileDistanceDisplay; // 0x30
	public ItemTextValue fuseLengthDisplay; // 0x38
	public ItemTextValue blastRadiusDisplay; // 0x40
	public Text unreliableText; // 0x48

	// Methods

	// RVA: 0x8C2E30 Offset: 0x8C2230 VA: 0x1808C2E30 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8C30B0 Offset: 0x8C24B0 VA: 0x1808C30B0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

