public class TerrainTexturing : TerrainExtension // TypeDefIndex: 10431
{	private const int MaxBasePyramidSize = 4096;
	private TextureCacheState pyramidCacheState; // 0x30
	private RenderTexture diffuseBasePyramidTexture; // 0x38
	private const int CoarseHeightDownscale = 1;
	private const int CoarseSlopeBlurPasses = 4;
	private const float CoarseSlopeBlurRadius = 1;
	private TextureCacheState coarseHeightSlopeCacheState; // 0x40
	private RenderTexture coarseHeightSlopeTexture; // 0x48
	private const int ShoreVectorDownscale = 3;
	private const int ShoreVectorBlurPasses = 0;
	private float terrainSize; // 0x50
	private int shoreMapSize; // 0x54
	private float[] shoreDistances; // 0x58
	private Vector3[] shoreVectors; // 0x60
	private Texture2D shoreVectorTexture; // 0x68
	public bool debugFoliageDisplacement; // 0x70
	private bool initialized; // 0x71
	private static TerrainTexturing instance; // 0x0
	private bool prevDebugFoliageDisplacement; // 0x72
	private int prevQuality; // 0x74
	private bool triggerUpdateGlobalParams; // 0x78
	private int[,] PID_Layer; // 0x80
	private static int PID_NaN; // 0x8
	private static int PID_Terrain_Control0; // 0xC
	private static int PID_Terrain_Control1; // 0x10
	private static int PID_Terrain_TextureArray0; // 0x14
	private static int PID_Terrain_TextureArray1; // 0x18
	private static int PID_Terrain_HeightSlope; // 0x1C
	private static int PID_Terrain_ShoreVector; // 0x20
	private static int PID_Terrain_Position; // 0x24
	private static int PID_Terrain_Size; // 0x28
	private static int PID_Terrain_RcpSize; // 0x2C
	private static int PID_Terrain_TexelSize; // 0x30
	private static int PID_Terrain_TexelSize0; // 0x34
	private static int PID_Terrain_TexelSize1; // 0x38
	private static int PID_TerrainParallax; // 0x3C
	private static int PID_TerrainPotatoDetailTexture; // 0x40
	private static int PID_TerrainPotatoDetailWorldUVScale; // 0x44
	private static int PID_PotatoDetailTexture; // 0x48
	private static int PID_PotatoDetailWorldUVScale; // 0x4C
	private static int PID_UVMIXMult; // 0x50
	private static int PID_UVMIXStart; // 0x54
	private static int PID_UVMIXDist; // 0x58
	private static int PID_LayerFallback_Albedo; // 0x5C
	private static int PID_LayerFallback_Metallic; // 0x60
	private static int PID_LayerFallback_Smoothness; // 0x64

	public RenderTexture DiffuseBasePyramidTexture { get; }
	public RenderTexture CoarseHeightSlopeTexture { get; }
	public int ShoreMapSize { get; }
	public Vector3[] ShoreMap { get; }
	public Texture2D ShoreVectorTexture { get; }
	public static TerrainTexturing Instance { get; }


	private void InitializeBasePyramid() { }

	private void ReleaseBasePyramid() { }

	private void UpdateBasePyramid() { }

	public RenderTexture get_DiffuseBasePyramidTexture() { }

	private RenderTexture CreateBasePyramidRT(string name, int size, bool linear) { }

	private void InitializeBasePyramidTexture() { }

	private void ReleaseBasePyramidTexture() { }

	private void CacheBasePyramidTexture() { }

	private void UpdateBasePyramidShaderConstants() { }

	private void UpdateBasePyramidTexture() { }

	private bool CheckLostBasePyramidTexture() { }

	private void InitializeCoarseHeightSlope() { }

	private void ReleaseCoarseHeightSlope() { }

	private void UpdateCoarseHeightSlope() { }

	public RenderTexture get_CoarseHeightSlopeTexture() { }

	private void InitializeCoarseHeightSlopeTexture() { }

	private void ReleaseCoarseHeightSlopeTexture() { }

	private void CacheCoarseHeightSlopeTexture() { }

	private void UpdateCoarseHeightSlopeTexture() { }

	private bool CheckLostCoarseHeightSlopeTexture() { }

	public int get_ShoreMapSize() { }

	public Vector3[] get_ShoreMap() { }

	private void InitializeShoreVector() { }

	private void GenerateShoreVector() { }

	private void ReleaseShoreVector() { }

	private void GenerateShoreVector(out float[] distances, out Vector3[] vectors) { }

	public float GetCoarseDistanceToShore(Vector3 pos) { }

	public float GetCoarseDistanceToShore(Vector2 uv) { }

	public Vector3 GetCoarseVectorToShore(Vector3 pos) { }

	public Vector3 GetCoarseVectorToShore(Vector2 uv) { }

	public Texture2D get_ShoreVectorTexture() { }

	private void GenerateShoreVectorTexture(int size) { }

	private void ReleaseShoreVectorTexture() { }

	public static TerrainTexturing get_Instance() { }

	private void CheckInstance() { }

	private void Awake() { }

	public override void Setup() { }

	public override void PostSetup() { }

	private void Shutdown() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private Material CreateMaterial(string name) { }

	private void SafeDestroy<T>(ref T mat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDBC0 Offset: 0x5ECFC0 VA: 0x1805EDBC0
	|-TerrainTexturing.SafeDestroy<object>
	|-TerrainTexturing.SafeDestroy<Material>
	|-TerrainTexturing.SafeDestroy<Texture2D>
	*/

	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDC60 Offset: 0x5ED060 VA: 0x1805EDC60
	|-TerrainTexturing.SafeDispose<object>
	*/

	private void SafeDestroyRT(ref RenderTexture rtex) { }

	private Texture2D CreateTex(string name, int width, int height, TextureFormat format, bool mips, bool linear) { }

	private void DestroyTex(ref Texture2D tex) { }

	private void WarmupStrings() { }

	private void UpdateTerrainShaderConstants() { }

	private void UpdateFoliageDisplaceShaderConstants() { }

	private void UpdateGlobalShaderConstants() { }

	private void UpdateTerrainToGlobal() { }

	public void TriggerUpdateGlobalParams() { }

	public void TriggerBasePyramidUpdate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private enum TerrainTexturing.LayerPropID // TypeDefIndex: 10432
{	public int value__; // 0x0
	public const TerrainTexturing.LayerPropID UVMIX = 0;
	public const TerrainTexturing.LayerPropID AridColor = 1;
	public const TerrainTexturing.LayerPropID TemperateColor = 2;
	public const TerrainTexturing.LayerPropID TundraColor = 3;
	public const TerrainTexturing.LayerPropID ArcticColor = 4;
	public const TerrainTexturing.LayerPropID AridOverlayColor = 5;
	public const TerrainTexturing.LayerPropID TemperateOverlayColor = 6;
	public const TerrainTexturing.LayerPropID TundraOverlayColor = 7;
	public const TerrainTexturing.LayerPropID ArcticOverlayColor = 8;
	public const TerrainTexturing.LayerPropID AridOverlayParam = 9;
	public const TerrainTexturing.LayerPropID TemperateOverlayParam = 10;
	public const TerrainTexturing.LayerPropID TundraOverlayParam = 11;
	public const TerrainTexturing.LayerPropID ArcticOverlayParam = 12;
	public const TerrainTexturing.LayerPropID Metallic = 13;
	public const TerrainTexturing.LayerPropID Factor = 14;
	public const TerrainTexturing.LayerPropID Falloff = 15;
	public const TerrainTexturing.LayerPropID COUNT = 16;

}

private sealed class TerrainTexturing.<>c__DisplayClass27_0 // TypeDefIndex: 10433
{	public int block; // 0x10
	public int dstsize; // 0x14
	public int srcsize; // 0x18
	public float hscale_s; // 0x1C
	public float ny; // 0x20
	public float hscale; // 0x24
	public float hoffset; // 0x28
	public Color[] pixels; // 0x30


	public void .ctor() { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_1 // TypeDefIndex: 10434
{	public Color32[] heightColors; // 0x10
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <CacheCoarseHeightSlopeTexture>b__0(int dz) { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_2 // TypeDefIndex: 10435
{	public short[] heights; // 0x10
	public int heightres; // 0x18
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals2; // 0x20


	public void .ctor() { }

	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

