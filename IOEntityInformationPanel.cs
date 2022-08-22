public class IOEntityInformationPanel : ItemInformationPanel // TypeDefIndex: 11006
{	public ItemTextValue requiredPowerDisplay; // 0x18
	public ItemTextValue requiredFluidDisplay; // 0x20
	public ItemTextValue generatedPowerDisplay; // 0x28
	public ItemTextValue capacityDisplay; // 0x30
	public ItemTextValue chargeDisplay; // 0x38


	public IOEntity GetIOEntityToUse(ItemDefinition info) { }

	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

