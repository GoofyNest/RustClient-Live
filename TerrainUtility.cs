public static class TerrainUtility // TypeDefIndex: 4099
{	// Methods

	// RVA: 0x22BD7A0 Offset: 0x22BCBA0 VA: 0x1822BD7A0
	internal static bool HasValidTerrains() { }

	// RVA: 0x22BD3F0 Offset: 0x22BC7F0 VA: 0x1822BD3F0
	internal static void ClearConnectivity() { }

	// RVA: 0x22BD4B0 Offset: 0x22BC8B0 VA: 0x1822BD4B0
	internal static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22BD020 Offset: 0x22BC420 VA: 0x1822BD020
	public static void AutoConnect() { }

}

public class TerrainUtility.TerrainMap // TypeDefIndex: 4100
{	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x22BC4C0 Offset: 0x22BB8C0 VA: 0x1822BC4C0
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x22BC150 Offset: 0x22BB550 VA: 0x1822BC150
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22BBDB0 Offset: 0x22BB1B0 VA: 0x1822BBDB0
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22BCFB0 Offset: 0x22BC3B0 VA: 0x1822BCFB0
	public void .ctor() { }

	// RVA: 0x22BBBD0 Offset: 0x22BAFD0 VA: 0x1822BBBD0
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x22BC540 Offset: 0x22BB940 VA: 0x1822BC540
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x22BC670 Offset: 0x22BBA70 VA: 0x1822BC670
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x22BCE70 Offset: 0x22BC270 VA: 0x1822BCE70
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }

}

public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 4101
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1780DE0 Offset: 0x17801E0 VA: 0x181780DE0 Slot: 12
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public struct TerrainUtility.TerrainMap.TileCoord // TypeDefIndex: 4102
{	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int tileX, int tileZ) { }

}

public enum TerrainUtility.TerrainMap.ErrorCode // TypeDefIndex: 4103
{	// Fields
	public int value__; // 0x0
	public const TerrainUtility.TerrainMap.ErrorCode OK = 0;
	public const TerrainUtility.TerrainMap.ErrorCode Overlapping = 1;
	public const TerrainUtility.TerrainMap.ErrorCode SizeMismatch = 4;
	public const TerrainUtility.TerrainMap.ErrorCode EdgeAlignmentMismatch = 8;

}

private sealed class TerrainUtility.TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 4104
{	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22BE560 Offset: 0x22BD960 VA: 0x1822BE560
	internal bool <CreateFromPlacement>b__0(Terrain x) { }

}

public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 4105
{	// Methods

	// RVA: 0x22BBA90 Offset: 0x22BAE90 VA: 0x1822BBA90
	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_0 // TypeDefIndex: 4106
{	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_1 // TypeDefIndex: 4107
{	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22BE5B0 Offset: 0x22BD9B0 VA: 0x1822BE5B0
	internal bool <CollectTerrains>b__0(Terrain x) { }

}

