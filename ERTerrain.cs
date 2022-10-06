public class ERTerrain : MonoBehaviour // TypeDefIndex: 7286
{
	public List<Vector3> surfacevecs; 
	public float[] tdataFloat; 
	public TerrainData terrainData; 
	public int xStart; 
	public int zStart; 
	public GameObject roadSurface; 
	public Mesh surfaceMesh; 
	public MeshCollider surfaceCollider; 
	public List<ERTerrainData> terrainDataStored; 
	public List<ERTerrainChange> terrainChanges; 
	public List<ERTree> terrainTrees; 
	public List<List<tPoint>> detailInstancesOld; 
	public List<tPoint> detailInstances; 
	public List<int> detailInstanceStarts; 
	public List<GameObject> surfaceObjects; 
	public List<Vector3> terrainTestPoints; 
	public List<ERSplatmap> splatData; 
	public List<ERTreeInstance> addedTrees; 
	public List<ERCell> holes; 
	public List<ERTerrainData> terrainHeightsBackup; 
	public List<ERTree> terrainTreesBackup; 
	public List<tPoint> terrainDetailBackup; 
	public List<ERSplatmap> terrainSplatBackup; 
	public List<int> detailInstanceStartsBackUp; 
	public bool heightmapFlag; 
	public bool splatmapFlag; 
	public bool treeFlag; 
	public bool detailFlag; 
	public bool holesFlag; 
	public bool terrainDone; 
	public bool backupFlagNotification; 
	public bool ignore; 
	public GameObject backupObject; 
	public TerrainData terrain; 


	public void .ctor() { }

}

