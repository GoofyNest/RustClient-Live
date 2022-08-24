public class TerrainPath : TerrainExtension // TypeDefIndex: 10427
{
	internal List<PathList> Roads; 
	internal List<PathList> Rails; 
	internal List<PathList> Rivers; 
	internal List<PathList> Powerlines; 
	internal List<LandmarkInfo> Landmarks; 
	internal List<MonumentInfo> Monuments; 
	internal List<RiverInfo> RiverObjs; 
	internal List<LakeInfo> LakeObjs; 
	internal GameObject DungeonGridRoot; 
	internal List<DungeonGridInfo> DungeonGridEntrances; 
	internal List<DungeonGridCell> DungeonGridCells; 
	internal GameObject DungeonBaseRoot; 
	internal List<DungeonBaseInfo> DungeonBaseEntrances; 
	internal List<Vector3> OceanPatrolClose; 
	internal List<Vector3> OceanPatrolFar; 
	private Dictionary<string, List<PowerlineNode>> wires; 


public override void PostSetup() { }

public void Clear() { }

public T FindClosest<T>(List<T> list, Vector3 pos) { }
/* GenericInstMethod :
|
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

