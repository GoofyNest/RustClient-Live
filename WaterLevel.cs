public static class WaterLevel // TypeDefIndex: 10054
{	// Methods

	// RVA: 0xC10A90 Offset: 0xC0FE90 VA: 0x180C10A90
	public static float Factor(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

	// RVA: 0xC10810 Offset: 0xC0FC10 VA: 0x180C10810
	public static float Factor(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC12C40 Offset: 0xC12040 VA: 0x180C12C40
	public static bool Test(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC11360 Offset: 0xC10760 VA: 0x180C11360
	public static float GetWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC11210 Offset: 0xC10610 VA: 0x180C11210
	public static float GetOverallWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC10C70 Offset: 0xC10070 VA: 0x180C10C70
	public static WaterLevel.WaterInfo GetBuoyancyWaterInfo(Vector3 pos, Vector2 posUV, float terrainHeight, float waterHeight, bool doDeepwaterChecks, BaseEntity forEntity) { }

	// RVA: 0xC116F0 Offset: 0xC10AF0 VA: 0x180C116F0
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC11D90 Offset: 0xC11190 VA: 0x180C11D90
	public static WaterLevel.WaterInfo GetWaterInfo(Bounds bounds, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC12400 Offset: 0xC11800 VA: 0x180C12400
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 start, Vector3 end, float radius, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC114A0 Offset: 0xC108A0 VA: 0x180C114A0
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC11550 Offset: 0xC10950 VA: 0x180C11550
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 pos, BaseEntity forEntity) { }

	// RVA: 0xC11600 Offset: 0xC10A00 VA: 0x180C11600
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

}

public struct WaterLevel.WaterInfo // TypeDefIndex: 10055
{	// Fields
	public bool isValid; // 0x0
	public float currentDepth; // 0x4
	public float overallDepth; // 0x8
	public float surfaceLevel; // 0xC

}

