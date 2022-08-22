public class HairSetCollection : ScriptableObject // TypeDefIndex: 10735
{	public HairSetCollection.HairSetEntry[] Head; // 0x18
	public HairSetCollection.HairSetEntry[] Eyebrow; // 0x20
	public HairSetCollection.HairSetEntry[] Facial; // 0x28
	public HairSetCollection.HairSetEntry[] Armpit; // 0x30
	public HairSetCollection.HairSetEntry[] Pubic; // 0x38


	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	public int GetIndex(HairType hairType, float typeNum) { }

	public HairSetCollection.HairSetEntry Get(HairType hairType, float typeNum) { }

	public void .ctor() { }

}

public struct HairSetCollection.HairSetEntry // TypeDefIndex: 10736
{	public HairSet HairSet; // 0x0
	public GameObjectRef HairPrefab; // 0x8
	public HairDyeCollection HairDyeCollection; // 0x10

}

