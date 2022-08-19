public class Prefab : IComparable<Prefab> // TypeDefIndex: 9969
{	// Fields
	public uint ID; // 0x10
	public string Name; // 0x18
	public string Folder; // 0x20
	public GameObject Object; // 0x28
	public GameManager Manager; // 0x30
	public PrefabAttribute.Library Attribute; // 0x38
	public PrefabParameters Parameters; // 0x40

	// Properties
	public static PrefabAttribute.Library DefaultAttribute { get; }
	public static GameManager DefaultManager { get; }

	// Methods

	// RVA: 0x987050 Offset: 0x986450 VA: 0x180987050
	public void .ctor(string name, GameObject prefab, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x9872D0 Offset: 0x9866D0 VA: 0x1809872D0
	public static GameObject op_Implicit(Prefab prefab) { }

	// RVA: 0x986680 Offset: 0x985A80 VA: 0x180986680 Slot: 4
	public int CompareTo(Prefab that) { }

	// RVA: 0x985EC0 Offset: 0x9852C0 VA: 0x180985EC0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, TerrainAnchorMode mode, SpawnFilter filter) { }

	// RVA: 0x985DE0 Offset: 0x9851E0 VA: 0x180985DE0
	public bool ApplyTerrainAnchors(ref Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x985FB0 Offset: 0x9853B0 VA: 0x180985FB0
	public bool ApplyTerrainChecks(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9860B0 Offset: 0x9854B0 VA: 0x1809860B0
	public bool ApplyTerrainFilters(Vector3 pos, Quaternion rot, Vector3 scale, SpawnFilter filter) { }

	// RVA: 0x9861B0 Offset: 0x9855B0 VA: 0x1809861B0
	public void ApplyTerrainModifiers(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x9862A0 Offset: 0x9856A0 VA: 0x1809862A0
	public void ApplyTerrainPlacements(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x986390 Offset: 0x985790 VA: 0x180986390
	public bool ApplyWaterChecks(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x985C20 Offset: 0x985020 VA: 0x180985C20
	public void ApplyDecorComponents(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x9865E0 Offset: 0x9859E0 VA: 0x1809865E0
	public bool CheckEnvironmentVolumes(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	// RVA: 0x986480 Offset: 0x985880 VA: 0x180986480
	public bool CheckEnvironmentVolumesInsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x986530 Offset: 0x985930 VA: 0x180986530
	public bool CheckEnvironmentVolumesOutsideTerrain(Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	// RVA: 0x985CD0 Offset: 0x9850D0 VA: 0x180985CD0
	public void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x986FB0 Offset: 0x9863B0 VA: 0x180986FB0
	public GameObject Spawn(Transform transform, bool active = True) { }

	// RVA: 0x986FF0 Offset: 0x9863F0 VA: 0x180986FF0
	public GameObject Spawn(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x986F30 Offset: 0x986330 VA: 0x180986F30
	public GameObject Spawn(Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x986ED0 Offset: 0x9862D0 VA: 0x180986ED0
	public BaseEntity SpawnEntity(Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> Load<T>(uint id, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12594C0 Offset: 0x12588C0 VA: 0x1812594C0
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: 0x986D50 Offset: 0x986150 VA: 0x180986D50
	public static Prefab Load(uint id, GameManager manager, PrefabAttribute.Library attribute) { }

	// RVA: 0x986B90 Offset: 0x985F90 VA: 0x180986B90
	public static Prefab[] Load(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string folder, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12591D0 Offset: 0x12585D0 VA: 0x1812591D0
	|-Prefab.Load<DungeonBaseLink>
	|-Prefab.Load<DungeonBaseTransition>
	|-Prefab.Load<DungeonGridCell>
	|-Prefab.Load<DungeonGridLink>
	|-Prefab.Load<MonumentInfo>
	|-Prefab.Load<object>
	*/

	// RVA: -1 Offset: -1
	public static Prefab<T>[] Load<T>(string[] names, GameManager manager, PrefabAttribute.Library attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259240 Offset: 0x1258640 VA: 0x181259240
	|-Prefab.Load<object>
	*/

	// RVA: 0x986A60 Offset: 0x985E60 VA: 0x180986A60
	public static Prefab LoadRandom(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }

	// RVA: -1 Offset: -1
	public static Prefab<T> LoadRandom<T>(string folder, ref uint seed, GameManager manager, PrefabAttribute.Library attribute, bool useProbabilities = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259060 Offset: 0x1258460 VA: 0x181259060
	|-Prefab.LoadRandom<object>
	*/

	// RVA: 0x9871B0 Offset: 0x9865B0 VA: 0x1809871B0
	public static PrefabAttribute.Library get_DefaultAttribute() { }

	// RVA: 0x987270 Offset: 0x986670 VA: 0x180987270
	public static GameManager get_DefaultManager() { }

	// RVA: 0x9867C0 Offset: 0x985BC0 VA: 0x1809867C0
	private static string[] FindPrefabNames(string strPrefab, bool useProbabilities = False) { }

}

