public sealed class TerrainData : Object // TypeDefIndex: 4093
{	// Fields
	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
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

	// Properties
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

	// Methods

	[StaticAccessorAttribute] // RVA: 0x7B180 Offset: 0x7A580 VA: 0x18007B180
	[ThreadSafeAttribute] // RVA: 0x7B180 Offset: 0x7A580 VA: 0x18007B180
	// RVA: 0x22B9F30 Offset: 0x22B9330 VA: 0x1822B9F30
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x22BAC50 Offset: 0x22BA050 VA: 0x1822BAC50
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x7B350 Offset: 0x7A750 VA: 0x18007B350
	// RVA: 0x22BA240 Offset: 0x22B9640 VA: 0x1822BA240
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x22BADF0 Offset: 0x22BA1F0 VA: 0x1822BADF0
	public int get_heightmapResolution() { }

	// RVA: 0x22BB7F0 Offset: 0x22BABF0 VA: 0x1822BB7F0
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	// RVA: 0x22BADF0 Offset: 0x22BA1F0 VA: 0x1822BADF0
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x7B6F0 Offset: 0x7AAF0 VA: 0x18007B6F0
	// RVA: 0x22BB960 Offset: 0x22BAD60 VA: 0x1822BB960
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7B840 Offset: 0x7AC40 VA: 0x18007B840
	// RVA: 0x22BAE80 Offset: 0x22BA280 VA: 0x1822BAE80
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x7B940 Offset: 0x7AD40 VA: 0x18007B940
	// RVA: 0x22BAF20 Offset: 0x22BA320 VA: 0x1822BAF20
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0x7BA50 Offset: 0x7AE50 VA: 0x18007BA50
	// RVA: 0x22BB9F0 Offset: 0x22BADF0 VA: 0x1822BB9F0
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0x7BBA0 Offset: 0x7AFA0 VA: 0x18007BBA0
	// RVA: 0x22B9FD0 Offset: 0x22B93D0 VA: 0x1822B9FD0
	public float GetHeight(int x, int y) { }

	// RVA: 0x22BA020 Offset: 0x22B9420 VA: 0x1822BA020
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7BCC0 Offset: 0x7B0C0 VA: 0x18007BCC0
	// RVA: 0x22BA2E0 Offset: 0x22B96E0 VA: 0x1822BA2E0
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x22BA6F0 Offset: 0x22B9AF0 VA: 0x1822BA6F0
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x7BD60 Offset: 0x7B160 VA: 0x18007BD60
	// RVA: 0x22BA440 Offset: 0x22B9840 VA: 0x1822BA440
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x7BE00 Offset: 0x7B200 VA: 0x18007BE00
	// RVA: 0x22BA1D0 Offset: 0x22B95D0 VA: 0x1822BA1D0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x7BF50 Offset: 0x7B350 VA: 0x18007BF50
	// RVA: 0x22BADB0 Offset: 0x22BA1B0 VA: 0x1822BADB0
	public int get_detailResolution() { }

	[FreeFunctionAttribute] // RVA: 0x7C010 Offset: 0x7B410 VA: 0x18007C010
	// RVA: 0x22BAD70 Offset: 0x22BA170 VA: 0x1822BAD70
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0x7C260 Offset: 0x7B660 VA: 0x18007C260
	// RVA: 0x22B9F70 Offset: 0x22B9370 VA: 0x1822B9F70
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x22BA630 Offset: 0x22B9A30 VA: 0x1822BA630
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0x7C320 Offset: 0x7B720 VA: 0x18007C320
	// RVA: 0x22BA3E0 Offset: 0x22B97E0 VA: 0x1822BA3E0
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x22BA340 Offset: 0x22B9740 VA: 0x1822BA340
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x22BBA40 Offset: 0x22BAE40 VA: 0x1822BBA40
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0x7C460 Offset: 0x7B860 VA: 0x18007C460
	// RVA: 0x22BA340 Offset: 0x22B9740 VA: 0x1822BA340
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0x7C520 Offset: 0x7B920 VA: 0x18007C520
	// RVA: 0x22BA9E0 Offset: 0x22B9DE0 VA: 0x1822BA9E0
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	[NativeNameAttribute] // RVA: 0x7C6F0 Offset: 0x7BAF0 VA: 0x18007C6F0
	// RVA: 0x22BAD30 Offset: 0x22BA130 VA: 0x1822BAD30
	public int get_alphamapLayers() { }

	// RVA: 0x22B9E60 Offset: 0x22B9260 VA: 0x1822B9E60
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x7C810 Offset: 0x7BC10 VA: 0x18007C810
	// RVA: 0x22BA280 Offset: 0x22B9680 VA: 0x1822BA280
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x22BACF0 Offset: 0x22BA0F0 VA: 0x1822BACF0
	public int get_alphamapResolution() { }

	// RVA: 0x22BB070 Offset: 0x22BA470 VA: 0x1822BB070
	public void set_alphamapResolution(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x7CB90 Offset: 0x7BF90 VA: 0x18007CB90
	[NativeNameAttribute] // RVA: 0x7CB90 Offset: 0x7BF90 VA: 0x18007CB90
	// RVA: 0x22B9E20 Offset: 0x22B9220 VA: 0x1822B9E20
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x7CC30 Offset: 0x7C030 VA: 0x18007CC30
	// RVA: 0x22BACF0 Offset: 0x22BA0F0 VA: 0x1822BACF0
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	// RVA: 0x22BAFF0 Offset: 0x22BA3F0 VA: 0x1822BAFF0
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x22BACF0 Offset: 0x22BA0F0 VA: 0x1822BACF0
	public int get_alphamapWidth() { }

	// RVA: 0x22BACF0 Offset: 0x22BA0F0 VA: 0x1822BACF0
	public int get_alphamapHeight() { }

	// RVA: 0x22BB430 Offset: 0x22BA830 VA: 0x1822BB430
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x22BB030 Offset: 0x22BA430 VA: 0x1822BB030
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x22BA4A0 Offset: 0x22B98A0 VA: 0x1822BA4A0
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	// RVA: 0x22BA380 Offset: 0x22B9780 VA: 0x1822BA380
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x7CF90 Offset: 0x7C390 VA: 0x18007CF90
	// RVA: 0x22BAF70 Offset: 0x22BA370 VA: 0x1822BAF70
	public TerrainLayer[] get_terrainLayers() { }

	// RVA: 0x22BAFB0 Offset: 0x22BA3B0 VA: 0x1822BAFB0
	internal Terrain[] get_users() { }

	// RVA: 0x22BAA40 Offset: 0x22B9E40 VA: 0x1822BAA40
	private static void .cctor() { }

	// RVA: 0x22BAE30 Offset: 0x22BA230 VA: 0x1822BAE30
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x22BAED0 Offset: 0x22BA2D0 VA: 0x1822BAED0
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x22BB9A0 Offset: 0x22BADA0 VA: 0x1822BB9A0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x22BA160 Offset: 0x22B9560 VA: 0x1822BA160
	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

}

private enum TerrainData.BoundaryValueType // TypeDefIndex: 4094
{	// Fields
	public int value__; // 0x0
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

