public class MeleeWeaponInformationPanel : ItemInformationPanel // TypeDefIndex: 11039
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue attackRateDisplay; // 0x20
	public ItemStatValue attackSizeDisplay; // 0x28
	public ItemStatValue attackRangeDisplay; // 0x30
	public ItemStatValue oreGatherDisplay; // 0x38
	public ItemStatValue treeGatherDisplay; // 0x40
	public ItemStatValue fleshGatherDisplay; // 0x48

	// Methods

	// RVA: 0x958E70 Offset: 0x958270 VA: 0x180958E70 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x958F60 Offset: 0x958360 VA: 0x180958F60 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

