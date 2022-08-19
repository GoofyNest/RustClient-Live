public class QDQDOOQQOOQDD : MonoBehaviour // TypeDefIndex: 7280
{	// Fields
	private List<Vector3> ᙃ; // 0x18
	private float[,] ᙄ; // 0x20
	private float[] ᙅ; // 0x28
	private TerrainData 4AAAA; // 0x30
	public static float minx; // 0x0
	public static float minz; // 0x4
	public static float maxx; // 0x8
	public static float maxz; // 0xC
	public static Vector2 splatMapScale; // 0x10
	public static List<GameObject> surfaceObjects; // 0x18
	public static List<GameObject> tunnelObjects; // 0x20
	public static int crossingSurfacesStart; // 0x28
	public static int sideObjectSurfacesStart; // 0x2C
	public static List<GameObject> treeObjects; // 0x30
	public static List<GameObject> detailObjects; // 0x38

	// Methods

	// RVA: 0xB63660 Offset: 0xB62A60 VA: 0x180B63660
	public static void ODDCCODOOC(ERModularBase scr, Terrain terrain) { }

	// RVA: 0xB61B70 Offset: 0xB60F70 VA: 0x180B61B70
	public static void ODCQDDOQCD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float m_minx, float m_maxx, float m_minz, float m_maxz) { }

	// RVA: 0xB68350 Offset: 0xB67750 VA: 0x180B68350
	public static void OOCQDQCDOD(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint, RaycastHit hit) { }

	// RVA: 0xB5EAF0 Offset: 0xB5DEF0 VA: 0x180B5EAF0
	public static void GetHitPointInfoOld(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint) { }

	// RVA: 0xB6BC00 Offset: 0xB6B000 VA: 0x180B6BC00
	public static void OQOQCCCODC(ERModularBase scr, ref float minx, ref float minz, ref float maxx, ref float maxz, float splatmapScale) { }

	// RVA: 0xB64E70 Offset: 0xB64270 VA: 0x180B64E70
	public static void ODQODCQQCQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB67C30 Offset: 0xB67030 VA: 0x180B67C30
	public static void OOCDDQCCDD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB65A10 Offset: 0xB64E10 VA: 0x180B65A10
	public static void OOCDDOOCQC(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB5F5D0 Offset: 0xB5E9D0 VA: 0x180B5F5D0
	public static void OCCDDODDDD(ref bool[,] holes, float[,] heights, float height, ref List<ERCell> terrainScrHoles, Vector3 lp, Vector3 rp, Vector3 terrainPos, float stepx, float stepy, float tHeight, float size) { }

	// RVA: 0xB65730 Offset: 0xB64B30 VA: 0x180B65730
	public static bool ODQODDQCCD(float[,] heights, float height, int x, int y, float rHeight, float tHeight, float size, float terrainY) { }

	// RVA: 0xB64570 Offset: 0xB63970 VA: 0x180B64570
	public static void ODQCOCOQQD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB600F0 Offset: 0xB5F4F0 VA: 0x180B600F0
	public static float[,,] OCCODCQOCO(List<ERSplatmap> mapData, float[,,] trmap, int layers) { }

	// RVA: 0xB63AC0 Offset: 0xB62EC0 VA: 0x180B63AC0
	public static void ODODDDDCOQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB6E680 Offset: 0xB6DA80 VA: 0x180B6E680
	public static void OQQOQOQQQC(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB611C0 Offset: 0xB605C0 VA: 0x180B611C0
	public static void ODCOOQCCCD(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB69990 Offset: 0xB68D90 VA: 0x180B69990
	public static void OOQDOQDCOO(TerrainData terrainInfo, int layer, List<tPoint> points) { }

	// RVA: 0xB6B510 Offset: 0xB6A910 VA: 0x180B6B510
	public static List<tPoint> OQODQCQCCQ(ERModularBase scr, Terrain terrain, TerrainData terrainInfo, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6B2E0 Offset: 0xB6A6E0 VA: 0x180B6B2E0
	public static void OQCQDDOOCQ(ERTerrain tr, Terrain terrain) { }

	// RVA: 0xB69430 Offset: 0xB68830 VA: 0x180B69430
	public static void OOODOOOQCC(ERTerrain tr, Terrain terrain, float perc) { }

	// RVA: 0xB68E90 Offset: 0xB68290 VA: 0x180B68E90
	public static void OOOCCDQODO(GameObject go, int x, int y, ref List<ERSplatmap> instances, float[,,] trmap, int layers, Vector2 uvy) { }

	// RVA: 0xB6A3B0 Offset: 0xB697B0 VA: 0x180B6A3B0
	public static void OOQQQQDCCO(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0xB5E650 Offset: 0xB5DA50 VA: 0x180B5E650
	public static GameObject CreateMesh(Transform parent, List<Vector3> vecs, List<int> tris, int layer, ERModularRoad scr, string name) { }

	// RVA: 0xB60EA0 Offset: 0xB602A0 VA: 0x180B60EA0
	public static void OCCQODOQDD(ERTerrain terrain, string folder) { }

	// RVA: 0xB6B0F0 Offset: 0xB6A4F0 VA: 0x180B6B0F0
	public static void OQCOQDDCCC(ERTerrain terrain, string folder) { }

	// RVA: 0xB6A110 Offset: 0xB69510 VA: 0x180B6A110
	public static void OOQQOOOQOO(ERTerrain terrain, string folder) { }

	// RVA: 0xB61440 Offset: 0xB60840 VA: 0x180B61440
	public static void ODCOQQQCCO(ERTerrain terrain, string folder) { }

	// RVA: 0xB60C10 Offset: 0xB60010 VA: 0x180B60C10
	public static void OCCOODODOQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB5FEC0 Offset: 0xB5F2C0 VA: 0x180B5FEC0
	public static void OCCDQQCODQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB69720 Offset: 0xB68B20 VA: 0x180B69720
	public static void OOOOCQCDQQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB69B40 Offset: 0xB68F40 VA: 0x180B69B40
	public static void OOQOCCCCDD(ERTerrain terrain, string folder) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xB6E860 Offset: 0xB6DC60 VA: 0x180B6E860
	private static void .cctor() { }

}

