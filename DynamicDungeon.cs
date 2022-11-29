public class DynamicDungeon : BaseEntity, IMissionEntityListener // TypeDefIndex: 10563
{
	public Transform exitEntitySpawn; 
	public GameObjectRef exitEntity; 
	public string exitString; 
	public MonumentNavMesh monumentNavMesh; 
	private static List<DynamicDungeon> _dungeons; 
	public GameObjectRef portalPrefab; 
	public Transform portalSpawnPoint; 
	public BasePortal exitPortal; 
	public GameObjectRef doorPrefab; 
	public Transform doorSpawnPoint; 
	public Door doorInstance; 
	public static Vector3 nextDungeonPos; 
	public static Vector3 dungeonStartPoint; 
	public static float dungeonSpacing; 
	public SpawnGroup[] spawnGroups; 
	public bool AutoMergeAIZones; 


	public static void AddDungeon(DynamicDungeon newDungeon) { }

	public static void RemoveDungeon(DynamicDungeon dungeon) { }

	public static Vector3 GetNextDungeonPoint() { }

	public void .ctor() { }

	private static void .cctor() { }

}

