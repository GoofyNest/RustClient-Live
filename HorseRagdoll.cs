public class HorseRagdoll : AnimalRagdoll // TypeDefIndex: 8928
{	// Fields
	public GameObject mane; // 0xA8
	public GameObject woodArmor; // 0xB0
	public GameObject roadsignArmor; // 0xB8
	public HorseBreed overrideBreed; // 0xC0
	public GameObjectRef breedSource; // 0xC8
	private int breedIndex; // 0xD0
	private bool showHair; // 0xD4
	private bool showWoodArmor; // 0xD5
	private bool showRoadsignArmor; // 0xD6

	// Methods

	// RVA: 0x75BD40 Offset: 0x75B140 VA: 0x18075BD40
	public void SetBreedIndex(int newIndex) { }

	// RVA: 0x75BD60 Offset: 0x75B160 VA: 0x18075BD60
	public void SetShowHair(bool wants) { }

	// RVA: 0x75BD50 Offset: 0x75B150 VA: 0x18075BD50
	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	// RVA: 0x75BB00 Offset: 0x75AF00 VA: 0x18075BB00 Slot: 7
	public override void Init() { }

	// RVA: 0x75BD70 Offset: 0x75B170 VA: 0x18075BD70
	public void UpdateVisuals() { }

	// RVA: 0x75BF60 Offset: 0x75B360 VA: 0x18075BF60
	public void .ctor() { }

}

