public class ProceduralDynamicDungeon : BaseEntity // TypeDefIndex: 10554
{
	public int gridResolution; 
	public float gridSpacing; 
	public bool[] grid; 
	public List<ProceduralDungeonCell> cellPrefabs; 
	public List<GameObjectRef> cellPrefabReferences; 
	public List<ProceduralDungeonCell> spawnedCells; 
	public EnvironmentVolume envVolume; 
	public MonumentNavMesh monumentNavMesh; 
	public GameObjectRef exitPortalPrefab; 
	private EntityRef<BasePortal> exitPortal; 
	public TriggerRadiation exitRadiation; 
	public uint seed; 
	public uint baseseed; 
	public ProceduralDungeonCell entranceHack; 


	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public override void InitShared() { }

	[ContextMenu] 
	[ExecuteInEditMode] 
	public void GenerateGrid() { }

	public ProceduralDungeonCell CellInstantiate(string path) { }

	public void RetireCell(GameObject cell) { }

	public void RetireAllCells() { }

	public bool CanSeeEntrance(int x, int y, ref List<int> checkedCells) { }

	public bool HasPathToEntrance(int x, int y) { }

	public bool CanFindEntrance(int x, int y) { }

	public bool IsEntrance(int x, int y) { }

	public int GetEntranceIndex() { }

	public void SetEntrance(int x, int y) { }

	public void SetGridState(int x, int y, bool state) { }

	public bool GetGridState(int x, int y) { }

	public int GetGridX(int index) { }

	public int GetGridY(int index) { }

	public int GetGridIndex(int x, int y) { }

	public void .ctor() { }

}

