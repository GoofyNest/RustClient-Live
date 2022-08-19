public class TerrainPath : TerrainExtension // TypeDefIndex: 10427
{	// Fields
	internal List<PathList> Roads; // 0x30
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

	// Methods

	// RVA: 0x114A1E0 Offset: 0x11495E0 VA: 0x18114A1E0 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x1148CA0 Offset: 0x11480A0 VA: 0x181148CA0
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T FindClosest<T>(List<T> list, Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBBF0 Offset: 0xBDAFF0 VA: 0x180BDBBF0
	|-TerrainPath.FindClosest<DungeonBaseInfo>
	|-TerrainPath.FindClosest<DungeonGridInfo>
	|-TerrainPath.FindClosest<MonumentInfo>
	|-TerrainPath.FindClosest<object>
	*/

	// RVA: 0x1148F70 Offset: 0x1148370 VA: 0x181148F70
	public static int[,] CreatePowerlineCostmap(ref uint seed) { }

	// RVA: 0x11495C0 Offset: 0x11489C0 VA: 0x1811495C0
	public static int[,] CreateRoadCostmap(ref uint seed) { }

	// RVA: 0x1149290 Offset: 0x1148690 VA: 0x181149290
	public static int[,] CreateRailCostmap(ref uint seed) { }

	// RVA: 0x1148D30 Offset: 0x1148130 VA: 0x181148D30
	public static int[,] CreateBoatCostmap(float depth) { }

	// RVA: 0x1148B70 Offset: 0x1147F70 VA: 0x181148B70
	public void AddWire(PowerlineNode node) { }

	// RVA: 0x1149A40 Offset: 0x1148E40 VA: 0x181149A40
	public void CreateWires() { }

	// RVA: 0x1149910 Offset: 0x1148D10 VA: 0x181149910
	private void CreateWire(string name, List<GameObject> objects, GameObjectRef wirePrefab) { }

	// RVA: 0x1149FA0 Offset: 0x11493A0 VA: 0x181149FA0
	public MonumentInfo FindMonumentWithBoundsOverlap(Vector3 position) { }

	// RVA: 0x114A620 Offset: 0x1149A20 VA: 0x18114A620
	public void .ctor() { }

}

