public class TerrainTexturing : TerrainExtension // TypeDefIndex: 12148
{
	private const int MaxBasePyramidSize = 4096;
	private TextureCacheState pyramidCacheState; 
	private RenderTexture diffuseBasePyramidTexture; 
	private const int CoarseHeightDownscale = 1;
	private const int CoarseSlopeBlurPasses = 4;
	private const float CoarseSlopeBlurRadius = 1;
	private TextureCacheState coarseHeightSlopeCacheState; 
	private RenderTexture coarseHeightSlopeTexture; 
	private const int ShoreVectorDownscale = 3;
	private const int ShoreVectorBlurPasses = 0;
	private float terrainSize; 
	private int shoreMapSize; 
	private float[] shoreDistances; 
	private Vector3[] shoreVectors; 
	private Texture2D shoreVectorTexture; 
	public bool debugFoliageDisplacement; 
	private bool initialized; 
	private static TerrainTexturing instance; 
	private bool prevDebugFoliageDisplacement; 
	private int prevQuality; 
	private bool triggerUpdateGlobalParams; 
	private int[,] PID_Layer; 
	private static int PID_NaN; 
	private static int PID_Terrain_Control0; 
	private static int PID_Terrain_Control1; 
	private static int PID_Terrain_TextureArray0; 
	private static int PID_Terrain_TextureArray1; 
	private static int PID_Terrain_HeightSlope; 
	private static int PID_Terrain_ShoreVector; 
	private static int PID_Terrain_Position; 
	private static int PID_Terrain_Size; 
	private static int PID_Terrain_RcpSize; 
	private static int PID_Terrain_TexelSize; 
	private static int PID_Terrain_TexelSize0; 
	private static int PID_Terrain_TexelSize1; 
	private static int PID_TerrainParallax; 
	private static int PID_TerrainPotatoDetailTexture; 
	private static int PID_TerrainPotatoDetailWorldUVScale; 
	private static int PID_PotatoDetailTexture; 
	private static int PID_PotatoDetailWorldUVScale; 
	private static int PID_UVMIXMult; 
	private static int PID_UVMIXStart; 
	private static int PID_UVMIXDist; 
	private static int PID_LayerFallback_Albedo; 
	private static int PID_LayerFallback_Metallic; 
	private static int PID_LayerFallback_Smoothness; 

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
	|-TerrainTexturing.SafeDestroy<object>
	|-TerrainTexturing.SafeDestroy<Material>
	|-TerrainTexturing.SafeDestroy<Texture2D>
	*/

	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
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

private enum TerrainTexturing.LayerPropID // TypeDefIndex: 12149
{
	public int value__; 
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

private sealed class TerrainTexturing.<>c__DisplayClass27_0 // TypeDefIndex: 12150
{
	public int block; 
	public int dstsize; 
	public int srcsize; 
	public float hscale_s; 
	public float ny; 
	public float hscale; 
	public float hoffset; 
	public Color[] pixels; 


	public void .ctor() { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_1 // TypeDefIndex: 12151
{
	public Color32[] heightColors; 
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal void <CacheCoarseHeightSlopeTexture>b__0(int dz) { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_2 // TypeDefIndex: 12152
{
	public short[] heights; 
	public int heightres; 
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals2; 


	public void .ctor() { }

	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

