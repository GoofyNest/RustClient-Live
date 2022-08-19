public class HairSetCollection : ScriptableObject // TypeDefIndex: 10735
{	// Fields
	public HairSetCollection.HairSetEntry[] Head; // 0x18
	public HairSetCollection.HairSetEntry[] Eyebrow; // 0x20
	public HairSetCollection.HairSetEntry[] Facial; // 0x28
	public HairSetCollection.HairSetEntry[] Armpit; // 0x30
	public HairSetCollection.HairSetEntry[] Pubic; // 0x38

	// Methods

	// RVA: 0x74E310 Offset: 0x74D710 VA: 0x18074E310
	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	// RVA: 0x74E280 Offset: 0x74D680 VA: 0x18074E280
	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	// RVA: 0x74E1C0 Offset: 0x74D5C0 VA: 0x18074E1C0
	public int GetIndex(HairType hairType, float typeNum) { }

	// RVA: 0x74E350 Offset: 0x74D750 VA: 0x18074E350
	public HairSetCollection.HairSetEntry Get(HairType hairType, float typeNum) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public struct HairSetCollection.HairSetEntry // TypeDefIndex: 10736
{	// Fields
	public HairSet HairSet; // 0x0
	public GameObjectRef HairPrefab; // 0x8
	public HairDyeCollection HairDyeCollection; // 0x10

}

