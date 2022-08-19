public class IOEntityInformationPanel : ItemInformationPanel // TypeDefIndex: 11006
{	// Fields
	public ItemTextValue requiredPowerDisplay; // 0x18
	public ItemTextValue requiredFluidDisplay; // 0x20
	public ItemTextValue generatedPowerDisplay; // 0x28
	public ItemTextValue capacityDisplay; // 0x30
	public ItemTextValue chargeDisplay; // 0x38

	// Methods

	// RVA: 0x806250 Offset: 0x805650 VA: 0x180806250
	public IOEntity GetIOEntityToUse(ItemDefinition info) { }

	// RVA: 0x8061D0 Offset: 0x8055D0 VA: 0x1808061D0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x806360 Offset: 0x805760 VA: 0x180806360 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

