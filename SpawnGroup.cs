public class SpawnGroup : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10007
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public MonumentTier Tier; // 0x18
	public List<SpawnGroup.SpawnEntry> prefabs; // 0x20
	public int maxPopulation; // 0x28
	public int numToSpawnPerTickMin; // 0x2C
	public int numToSpawnPerTickMax; // 0x30
	public float respawnDelayMin; // 0x34
	public float respawnDelayMax; // 0x38
	public bool wantsInitialSpawn; // 0x3C
	public bool temporary; // 0x3D
	public bool forceInitialSpawn; // 0x3E
	public bool preventDuplicates; // 0x3F
	public BoxCollider setFreeIfMovedBeyond; // 0x40

	// Methods

	// RVA: 0xA790D0 Offset: 0xA784D0 VA: 0x180A790D0
	public void .ctor() { }

}

public class SpawnGroup.SpawnEntry // TypeDefIndex: 10008
{	// Fields
	public GameObjectRef prefab; // 0x10
	public int weight; // 0x18
	public bool mobile; // 0x1C

	// Methods

	// RVA: 0x83A450 Offset: 0x839850 VA: 0x18083A450
	public void .ctor() { }

}

