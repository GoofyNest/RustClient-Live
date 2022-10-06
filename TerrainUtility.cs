public static class TerrainUtility // TypeDefIndex: 4102
{

	internal static bool HasValidTerrains() { }

	internal static void ClearConnectivity() { }

	internal static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCodeAttribute] 
	public static void AutoConnect() { }

}

public class TerrainUtility.TerrainMap // TypeDefIndex: 4103
{
	private Vector3 m_patchSize; 
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; 
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; 


	public Terrain GetTerrain(int tileX, int tileZ) { }

	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	public void .ctor() { }

	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	private void ValidateTerrain(int tileX, int tileZ) { }

	private TerrainUtility.TerrainMap.ErrorCode Validate() { }

}

public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 4104
{

	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(Terrain terrain) { }

	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

public struct TerrainUtility.TerrainMap.TileCoord // TypeDefIndex: 4105
{
	public readonly int tileX; 
	public readonly int tileZ; 


	public void .ctor(int tileX, int tileZ) { }

}

public enum TerrainUtility.TerrainMap.ErrorCode // TypeDefIndex: 4106
{
	public int value__; 
	public const TerrainUtility.TerrainMap.ErrorCode OK = 0;
	public const TerrainUtility.TerrainMap.ErrorCode Overlapping = 1;
	public const TerrainUtility.TerrainMap.ErrorCode SizeMismatch = 4;
	public const TerrainUtility.TerrainMap.ErrorCode EdgeAlignmentMismatch = 8;

}

private sealed class TerrainUtility.TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 4107
{
	public int groupID; 


	public void .ctor() { }

	internal bool <CreateFromPlacement>b__0(Terrain x) { }

}

public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 4108
{

	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_0 // TypeDefIndex: 4109
{
	public bool onlyAutoConnectedTerrains; 


	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_1 // TypeDefIndex: 4110
{
	public Terrain t; 
	public TerrainUtility.<>c__DisplayClass4_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal bool <CollectTerrains>b__0(Terrain x) { }

}

