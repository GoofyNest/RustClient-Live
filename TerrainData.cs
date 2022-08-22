public sealed class TerrainData : Object // TypeDefIndex: 4093
{	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
	private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";
	private const string k_HeightmapPrefix = "GetHeightmap().";
	private const string k_DetailDatabasePrefix = "GetDetailDatabase().";
	private const string k_TreeDatabasePrefix = "GetTreeDatabase().";
	private const string k_SplatDatabasePrefix = "GetSplatDatabase().";
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MaximumDetailsPerRes; // 0x10
	internal static readonly int k_MinimumAlphamapResolution; // 0x14
	internal static readonly int k_MaximumAlphamapResolution; // 0x18
	internal static readonly int k_MinimumBaseMapResolution; // 0x1C
	internal static readonly int k_MaximumBaseMapResolution; // 0x20

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


	[StaticAccessorAttribute] // RVA: 0x7B180 Offset: 0x7A580 VA: 0x18007B180
	[ThreadSafeAttribute] // RVA: 0x7B180 Offset: 0x7A580 VA: 0x18007B180
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B350 Offset: 0x7A750 VA: 0x18007B350
	private static void Internal_Create(TerrainData terrainData) { }

	public int get_heightmapResolution() { }

	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B6F0 Offset: 0x7AAF0 VA: 0x18007B6F0
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B840 Offset: 0x7AC40 VA: 0x18007B840
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7B940 Offset: 0x7AD40 VA: 0x18007B940
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BA50 Offset: 0x7AE50 VA: 0x18007BA50
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BBA0 Offset: 0x7AFA0 VA: 0x18007BBA0
	public float GetHeight(int x, int y) { }

	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BCC0 Offset: 0x7B0C0 VA: 0x18007BCC0
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BD60 Offset: 0x7B160 VA: 0x18007BD60
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7BE00 Offset: 0x7B200 VA: 0x18007BE00
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7BF50 Offset: 0x7B350 VA: 0x18007BF50
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C260 Offset: 0x7B660 VA: 0x18007C260
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C320 Offset: 0x7B720 VA: 0x18007C320
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	public TreeInstance[] get_treeInstances() { }

	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C460 Offset: 0x7B860 VA: 0x18007C460
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C520 Offset: 0x7B920 VA: 0x18007C520
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C6F0 Offset: 0x7BAF0 VA: 0x18007C6F0
	public int get_alphamapLayers() { }

	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C810 Offset: 0x7BC10 VA: 0x18007C810
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	public int get_alphamapResolution() { }

	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CB90 Offset: 0x7BF90 VA: 0x18007CB90
	[NativeNameAttribute] // RVA: 0x7CB90 Offset: 0x7BF90 VA: 0x18007CB90
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CC30 Offset: 0x7C030 VA: 0x18007CC30
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private void set_Internal_alphamapResolution(int value) { }

	public int get_alphamapWidth() { }

	public int get_alphamapHeight() { }

	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	private void set_Internal_baseMapResolution(int value) { }

	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	public TerrainLayer[] get_terrainLayers() { }

	internal Terrain[] get_users() { }

	private static void .cctor() { }

	private void get_heightmapScale_Injected(out Vector3 ret) { }

	private void get_size_Injected(out Vector3 ret) { }

	private void set_size_Injected(ref Vector3 value) { }

	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

}

private enum TerrainData.BoundaryValueType // TypeDefIndex: 4094
{	public int value__; // 0x0
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

