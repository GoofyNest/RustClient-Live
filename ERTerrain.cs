public class ERTerrain : MonoBehaviour // TypeDefIndex: 7279
{	public List<Vector3> surfacevecs; // 0x18
	public float[] tdataFloat; // 0x20
	public TerrainData terrainData; // 0x28
	public int xStart; // 0x30
	public int zStart; // 0x34
	public GameObject roadSurface; // 0x38
	public Mesh surfaceMesh; // 0x40
	public MeshCollider surfaceCollider; // 0x48
	public List<ERTerrainData> terrainDataStored; // 0x50
	public List<ERTerrainChange> terrainChanges; // 0x58
	public List<ERTree> terrainTrees; // 0x60
	public List<List<tPoint>> detailInstancesOld; // 0x68
	public List<tPoint> detailInstances; // 0x70
	public List<int> detailInstanceStarts; // 0x78
	public List<GameObject> surfaceObjects; // 0x80
	public List<Vector3> terrainTestPoints; // 0x88
	public List<ERSplatmap> splatData; // 0x90
	public List<ERTreeInstance> addedTrees; // 0x98
	public List<ERCell> holes; // 0xA0
	public List<ERTerrainData> terrainHeightsBackup; // 0xA8
	public List<ERTree> terrainTreesBackup; // 0xB0
	public List<tPoint> terrainDetailBackup; // 0xB8
	public List<ERSplatmap> terrainSplatBackup; // 0xC0
	public List<int> detailInstanceStartsBackUp; // 0xC8
	public bool heightmapFlag; // 0xD0
	public bool splatmapFlag; // 0xD1
	public bool treeFlag; // 0xD2
	public bool detailFlag; // 0xD3
	public bool holesFlag; // 0xD4
	public bool terrainDone; // 0xD5
	public bool backupFlagNotification; // 0xD6
	public bool ignore; // 0xD7
	public GameObject backupObject; // 0xD8
	public TerrainData terrain; // 0xE0


	public void .ctor() { }

}

