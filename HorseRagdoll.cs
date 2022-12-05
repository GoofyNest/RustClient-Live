public class HorseRagdoll : AnimalRagdoll // TypeDefIndex: 10660
{
	public GameObject mane;
	public GameObject woodArmor;
	public GameObject roadsignArmor;
	public HorseBreed overrideBreed;
	public GameObjectRef breedSource;
	private int breedIndex;
	private bool showHair;
	private bool showWoodArmor;
	private bool showRoadsignArmor;


	public void SetBreedIndex(int newIndex) { }

	public void SetShowHair(bool wants) { }

	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	public override void Init() { }

	public void UpdateVisuals() { }

	public void .ctor() { }

}

