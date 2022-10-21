public class HairSetCollection : ScriptableObject // TypeDefIndex: 12466
{
	public HairSetCollection.HairSetEntry[] Head; 
	public HairSetCollection.HairSetEntry[] Eyebrow; 
	public HairSetCollection.HairSetEntry[] Facial; 
	public HairSetCollection.HairSetEntry[] Armpit; 
	public HairSetCollection.HairSetEntry[] Pubic; 


	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	public int GetIndex(HairType hairType, float typeNum) { }

	public HairSetCollection.HairSetEntry Get(HairType hairType, float typeNum) { }

	public void .ctor() { }

}

public struct HairSetCollection.HairSetEntry // TypeDefIndex: 12467
{
	public HairSet HairSet; 
	public GameObjectRef HairPrefab; 
	public HairDyeCollection HairDyeCollection; 

}

