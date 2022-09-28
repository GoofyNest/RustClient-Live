public static class WaterLevel // TypeDefIndex: 11729
{

	public static float Factor(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

	public static float Factor(Bounds bounds, BaseEntity forEntity) { }

	public static bool Test(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	public static float GetWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	public static float GetOverallWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	public static WaterLevel.WaterInfo GetBuoyancyWaterInfo(Vector3 pos, Vector2 posUV, float terrainHeight, float waterHeight, bool doDeepwaterChecks, BaseEntity forEntity) { }

	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	public static WaterLevel.WaterInfo GetWaterInfo(Bounds bounds, BaseEntity forEntity, bool waves = True) { }

	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 start, Vector3 end, float radius, BaseEntity forEntity, bool waves = True) { }

	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Bounds bounds, BaseEntity forEntity) { }

	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 pos, BaseEntity forEntity) { }

	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

}

public struct WaterLevel.WaterInfo // TypeDefIndex: 11730
{
	public bool isValid; 
	public float currentDepth; 
	public float overallDepth; 
	public float surfaceLevel; 

}

