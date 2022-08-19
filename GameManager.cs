public class GameManager // TypeDefIndex: 9879
{	// Fields
	public static GameManager client; // 0x0
	internal PrefabPreProcess preProcessed; // 0x10
	internal PrefabPoolCollection pool; // 0x18
	private bool Clientside; // 0x20
	private bool Serverside; // 0x21

	// Methods

	// RVA: 0x6F3FB0 Offset: 0x6F33B0 VA: 0x1806F3FB0
	public void Reset() { }

	// RVA: 0x6F4300 Offset: 0x6F3700 VA: 0x1806F4300
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x6F3BE0 Offset: 0x6F2FE0 VA: 0x1806F3BE0
	public GameObject FindPrefab(uint prefabID) { }

	// RVA: 0x6F39D0 Offset: 0x6F2DD0 VA: 0x1806F39D0
	public GameObject FindPrefab(BaseEntity ent) { }

	// RVA: 0x6F3A70 Offset: 0x6F2E70 VA: 0x1806F3A70
	public GameObject FindPrefab(string strPrefab) { }

	// RVA: 0x6F3240 Offset: 0x6F2640 VA: 0x1806F3240
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, Vector3 scale, bool active = True) { }

	// RVA: 0x6F3170 Offset: 0x6F2570 VA: 0x1806F3170
	public GameObject CreatePrefab(string strPrefab, Vector3 pos, Quaternion rot, bool active = True) { }

	// RVA: 0x6F3350 Offset: 0x6F2750 VA: 0x1806F3350
	public GameObject CreatePrefab(string strPrefab, bool active = True) { }

	// RVA: 0x6F3480 Offset: 0x6F2880 VA: 0x1806F3480
	public GameObject CreatePrefab(string strPrefab, Transform parent, bool active = True) { }

	// RVA: 0x6F2F20 Offset: 0x6F2320 VA: 0x1806F2F20
	public BaseEntity CreateEntity(string strPrefab, Vector3 pos, Quaternion rot, bool startActive = True) { }

	// RVA: 0x6F3C70 Offset: 0x6F3070 VA: 0x1806F3C70
	private GameObject Instantiate(string strPrefab, Vector3 pos, Quaternion rot) { }

	// RVA: 0x6F38C0 Offset: 0x6F2CC0 VA: 0x1806F38C0
	public static void Destroy(Component component, float delay = 0) { }

	// RVA: 0x6F37B0 Offset: 0x6F2BB0 VA: 0x1806F37B0
	public static void Destroy(GameObject instance, float delay = 0) { }

	// RVA: 0x6F35C0 Offset: 0x6F29C0 VA: 0x1806F35C0
	public static void DestroyImmediate(Component component, bool allowDestroyingAssets = False) { }

	// RVA: 0x6F36D0 Offset: 0x6F2AD0 VA: 0x1806F36D0
	public static void DestroyImmediate(GameObject instance, bool allowDestroyingAssets = False) { }

	// RVA: 0x6F3FD0 Offset: 0x6F33D0 VA: 0x1806F3FD0
	public void Retire(GameObject instance) { }

	// RVA: 0x6F4210 Offset: 0x6F3610 VA: 0x1806F4210
	private static void .cctor() { }

}

