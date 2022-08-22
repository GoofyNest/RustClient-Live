public class HorseRagdoll : AnimalRagdoll // TypeDefIndex: 8928
{	public GameObject mane; // 0xA8
	public GameObject woodArmor; // 0xB0
	public GameObject roadsignArmor; // 0xB8
	public HorseBreed overrideBreed; // 0xC0
	public GameObjectRef breedSource; // 0xC8
	private int breedIndex; // 0xD0
	private bool showHair; // 0xD4
	private bool showWoodArmor; // 0xD5
	private bool showRoadsignArmor; // 0xD6


	public void SetBreedIndex(int newIndex) { }

	public void SetShowHair(bool wants) { }

	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	public override void Init() { }

	public void UpdateVisuals() { }

	public void .ctor() { }

}

