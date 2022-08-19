public class SeedInformationPanel : ItemInformationPanel // TypeDefIndex: 11049
{	// Fields
	public ItemTextValue maxHarvestsDisplay; // 0x18
	public UIGenesDisplay GeneticsDisplay; // 0x20
	public Text TextUnknownGenetics; // 0x28
	public GameObject GeneticsGameObject; // 0x30
	public ItemStatValue WaterResilience; // 0x38
	public ItemStatValue GroundResilience; // 0x40
	public ItemStatValue LightResilience; // 0x48
	public ItemStatValue TemperatureResilience; // 0x50
	private GrowableGenes genes; // 0x58

	// Methods

	// RVA: 0x4A5050 Offset: 0x4A4450 VA: 0x1804A5050 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x4A5140 Offset: 0x4A4540 VA: 0x1804A5140 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4A5460 Offset: 0x4A4860 VA: 0x1804A5460
	public void .ctor() { }

}

