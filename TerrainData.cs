public sealed class TerrainData : Object // TypeDefIndex: 4093
{
private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";
private const string k_HeightmapPrefix = "GetHeightmap().";
private const string k_DetailDatabasePrefix = "GetDetailDatabase().";
private const string k_TreeDatabasePrefix = "GetTreeDatabase().";
private const string k_SplatDatabasePrefix = "GetSplatDatabase().";
	internal static readonly int k_MaximumResolution; 
	internal static readonly int k_MinimumDetailResolutionPerPatch; 
	internal static readonly int k_MaximumDetailResolutionPerPatch; 
	internal static readonly int k_MaximumDetailPatchCount; 
	internal static readonly int k_MaximumDetailsPerRes; 
	internal static readonly int k_MinimumAlphamapResolution; 
	internal static readonly int k_MaximumAlphamapResolution; 
	internal static readonly int k_MinimumBaseMapResolution; 
	internal static readonly int k_MaximumBaseMapResolution; 

public int heightmapResolution { get; set; }
private int internalHeightmapResolution { get; set; }
public Vector3 heightmapScale { get; }
public Vector3 size { get; set; }
public int detailResolution { get; }
public DetailPrototype[] detailPrototypes { get; }
public TreeInstance[] treeInstances { get; set; }
public int alphamapLayers { get; }
public int alphamapResolution { get; set; }
private int Internal_alphamapResolution { get; set; }
public int alphamapWidth { get; }
public int alphamapHeight { get; }
public int baseMapResolution { set; }
private int Internal_baseMapResolution { set; }
public TerrainLayer[] terrainLayers { get; }
internal Terrain[] users { get; }


	[StaticAccessorAttribute] 
	[ThreadSafeAttribute] 
private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

public void .ctor() { }

	[FreeFunctionAttribute] 
private static void Internal_Create(TerrainData terrainData) { }

public int get_heightmapResolution() { }

public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] 
private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] 
private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] 
public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] 
public Vector3 get_size() { }

	[NativeNameAttribute] 
public void set_size(Vector3 value) { }

	[NativeNameAttribute] 
public float GetHeight(int x, int y) { }

public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] 
private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] 
private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] 
public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] 
public int get_detailResolution() { }

	[FreeFunctionAttribute] 
public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] 
public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] 
private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

public TreeInstance[] get_treeInstances() { }

public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] 
private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] 
public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] 
public int get_alphamapLayers() { }

public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] 
private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

public int get_alphamapResolution() { }

public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] 
	[NativeNameAttribute] 
internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] 
private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] 
private void set_Internal_alphamapResolution(int value) { }

public int get_alphamapWidth() { }

public int get_alphamapHeight() { }

public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] 
private void set_Internal_baseMapResolution(int value) { }

public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] 
private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] 
public TerrainLayer[] get_terrainLayers() { }

internal Terrain[] get_users() { }

private static void .cctor() { }

private void get_heightmapScale_Injected(out Vector3 ret) { }

private void get_size_Injected(out Vector3 ret) { }

private void set_size_Injected(ref Vector3 value) { }

private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

}

private enum TerrainData.BoundaryValueType // TypeDefIndex: 4094
{
	public int value__; 
public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
public const TerrainData.BoundaryValueType MaxDetailsPerRes = 4;
public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;

}

