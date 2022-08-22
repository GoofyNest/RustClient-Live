public class SeedInformationPanel : ItemInformationPanel // TypeDefIndex: 11049
{	public ItemTextValue maxHarvestsDisplay; // 0x18
	public UIGenesDisplay GeneticsDisplay; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public GameObject GeneticsGameObject; // 0x30
	public ItemStatValue WaterResilience; // 0x38
	public ItemStatValue GroundResilience; // 0x40
	public ItemStatValue LightResilience; // 0x48
	public ItemStatValue TemperatureResilience; // 0x50
	private GrowableGenes genes; // 0x58


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

