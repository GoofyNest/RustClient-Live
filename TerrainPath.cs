public class TerrainPath : TerrainExtension // TypeDefIndex: 10427
{	internal List<PathList> Roads; // 0x30
	internal List<PathList> Rails; // 0x38
	internal List<PathList> Rivers; // 0x40
	internal List<PathList> Powerlines; // 0x48
	internal List<LandmarkInfo> Landmarks; // 0x50
	internal List<MonumentInfo> Monuments; // 0x58
	internal List<RiverInfo> RiverObjs; // 0x60
	internal List<LakeInfo> LakeObjs; // 0x68
	internal GameObject DungeonGridRoot; // 0x70
	internal List<DungeonGridInfo> DungeonGridEntrances; // 0x78
	internal List<DungeonGridCell> DungeonGridCells; // 0x80
	internal GameObject DungeonBaseRoot; // 0x88
	internal List<DungeonBaseInfo> DungeonBaseEntrances; // 0x90
	internal List<Vector3> OceanPatrolClose; // 0x98
	internal List<Vector3> OceanPatrolFar; // 0xA0
	private Dictionary<string, List<PowerlineNode>> wires; // 0xA8


	public override void PostSetup() { }

	public void Clear() { }

	public T FindClosest<T>(List<T> list, Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBBF0 Offset: 0xBDAFF0 VA: 0x180BDBBF0
	|-TerrainPath.FindClosest<DungeonBaseInfo>
	|-TerrainPath.FindClosest<DungeonGridInfo>
	|-TerrainPath.FindClosest<MonumentInfo>
	|-TerrainPath.FindClosest<object>
	*/

	public static int[,] CreatePowerlineCostmap(ref uint seed) { }

	public static int[,] CreateRoadCostmap(ref uint seed) { }

	public static int[,] CreateRailCostmap(ref uint seed) { }

	public static int[,] CreateBoatCostmap(float depth) { }

	public void AddWire(PowerlineNode node) { }

	public void CreateWires() { }

	private void CreateWire(string name, List<GameObject> objects, GameObjectRef wirePrefab) { }

	public MonumentInfo FindMonumentWithBoundsOverlap(Vector3 position) { }

	public void .ctor() { }

}

