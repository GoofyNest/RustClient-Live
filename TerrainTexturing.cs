public class TerrainTexturing : TerrainExtension // TypeDefIndex: 10431
{	// Fields
	private const int MaxBasePyramidSize = 4096;
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

	// Properties
	public RenderTexture DiffuseBasePyramidTexture { get; }
	public RenderTexture CoarseHeightSlopeTexture { get; }
	public int ShoreMapSize { get; }
	public Vector3[] ShoreMap { get; }
	public Texture2D ShoreVectorTexture { get; }
	public static TerrainTexturing Instance { get; }

	// Methods

	// RVA: 0x843500 Offset: 0x842900 VA: 0x180843500
	private void InitializeBasePyramid() { }

	// RVA: 0x843AB0 Offset: 0x842EB0 VA: 0x180843AB0
	private void ReleaseBasePyramid() { }

	// RVA: 0x843EF0 Offset: 0x8432F0 VA: 0x180843EF0
	private void UpdateBasePyramid() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public RenderTexture get_DiffuseBasePyramidTexture() { }

	// RVA: 0x8420A0 Offset: 0x8414A0 VA: 0x1808420A0
	private RenderTexture CreateBasePyramidRT(string name, int size, bool linear) { }

	// RVA: 0x8433B0 Offset: 0x8427B0 VA: 0x1808433B0
	private void InitializeBasePyramidTexture() { }

	// RVA: 0x843AB0 Offset: 0x842EB0 VA: 0x180843AB0
	private void ReleaseBasePyramidTexture() { }

	// RVA: 0x841440 Offset: 0x840840 VA: 0x180841440
	private void CacheBasePyramidTexture() { }

	// RVA: 0x843D20 Offset: 0x843120 VA: 0x180843D20
	private void UpdateBasePyramidShaderConstants() { }

	// RVA: 0x843D60 Offset: 0x843160 VA: 0x180843D60
	private void UpdateBasePyramidTexture() { }

	// RVA: 0x841F80 Offset: 0x841380 VA: 0x180841F80
	private bool CheckLostBasePyramidTexture() { }

	// RVA: 0x843680 Offset: 0x842A80 VA: 0x180843680
	private void InitializeCoarseHeightSlope() { }

	// RVA: 0x843AE0 Offset: 0x842EE0 VA: 0x180843AE0
	private void ReleaseCoarseHeightSlope() { }

	// RVA: 0x843F00 Offset: 0x843300 VA: 0x180843F00
	private void UpdateCoarseHeightSlope() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public RenderTexture get_CoarseHeightSlopeTexture() { }

	// RVA: 0x843510 Offset: 0x842910 VA: 0x180843510
	private void InitializeCoarseHeightSlopeTexture() { }

	// RVA: 0x843AE0 Offset: 0x842EE0 VA: 0x180843AE0
	private void ReleaseCoarseHeightSlopeTexture() { }

	// RVA: 0x841650 Offset: 0x840A50 VA: 0x180841650
	private void CacheCoarseHeightSlopeTexture() { }

	// RVA: 0x843F00 Offset: 0x843300 VA: 0x180843F00
	private void UpdateCoarseHeightSlopeTexture() { }

	// RVA: 0x842010 Offset: 0x841410 VA: 0x180842010
	private bool CheckLostCoarseHeightSlopeTexture() { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	public int get_ShoreMapSize() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Vector3[] get_ShoreMap() { }

	// RVA: 0x843690 Offset: 0x842A90 VA: 0x180843690
	private void InitializeShoreVector() { }

	// RVA: 0x8425C0 Offset: 0x8419C0 VA: 0x1808425C0
	private void GenerateShoreVector() { }

	// RVA: 0x843B30 Offset: 0x842F30 VA: 0x180843B30
	private void ReleaseShoreVector() { }

	// RVA: 0x8426A0 Offset: 0x841AA0 VA: 0x1808426A0
	private void GenerateShoreVector(out float[] distances, out Vector3[] vectors) { }

	// RVA: 0x842C90 Offset: 0x842090 VA: 0x180842C90
	public float GetCoarseDistanceToShore(Vector3 pos) { }

	// RVA: 0x842DE0 Offset: 0x8421E0 VA: 0x180842DE0
	public float GetCoarseDistanceToShore(Vector2 uv) { }

	// RVA: 0x842F30 Offset: 0x842330 VA: 0x180842F30
	public Vector3 GetCoarseVectorToShore(Vector3 pos) { }

	// RVA: 0x8430B0 Offset: 0x8424B0 VA: 0x1808430B0
	public Vector3 GetCoarseVectorToShore(Vector2 uv) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public Texture2D get_ShoreVectorTexture() { }

	// RVA: 0x8423F0 Offset: 0x8417F0 VA: 0x1808423F0
	private void GenerateShoreVectorTexture(int size) { }

	// RVA: 0x843AF0 Offset: 0x842EF0 VA: 0x180843AF0
	private void ReleaseShoreVectorTexture() { }

	// RVA: 0x8460D0 Offset: 0x8454D0 VA: 0x1808460D0
	public static TerrainTexturing get_Instance() { }

	// RVA: 0x841E80 Offset: 0x841280 VA: 0x180841E80
	private void CheckInstance() { }

	// RVA: 0x841430 Offset: 0x840830 VA: 0x180841430
	private void Awake() { }

	// RVA: 0x843C60 Offset: 0x843060 VA: 0x180843C60 Slot: 4
	public override void Setup() { }

	// RVA: 0x843920 Offset: 0x842D20 VA: 0x180843920 Slot: 5
	public override void PostSetup() { }

	// RVA: 0x843C70 Offset: 0x843070 VA: 0x180843C70
	private void Shutdown() { }

	// RVA: 0x841430 Offset: 0x840830 VA: 0x180841430
	private void OnEnable() { }

	// RVA: 0x8438B0 Offset: 0x842CB0 VA: 0x1808438B0
	private void OnDisable() { }

	// RVA: 0x8452D0 Offset: 0x8446D0 VA: 0x1808452D0
	private void Update() { }

	// RVA: 0x8421D0 Offset: 0x8415D0 VA: 0x1808421D0
	private Material CreateMaterial(string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T mat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDBC0 Offset: 0x5ECFC0 VA: 0x1805EDBC0
	|-TerrainTexturing.SafeDestroy<object>
	|-TerrainTexturing.SafeDestroy<Material>
	|-TerrainTexturing.SafeDestroy<Texture2D>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDC60 Offset: 0x5ED060 VA: 0x1805EDC60
	|-TerrainTexturing.SafeDispose<object>
	*/

	// RVA: 0x843BA0 Offset: 0x842FA0 VA: 0x180843BA0
	private void SafeDestroyRT(ref RenderTexture rtex) { }

	// RVA: 0x842250 Offset: 0x841650 VA: 0x180842250
	private Texture2D CreateTex(string name, int width, int height, TextureFormat format, bool mips, bool linear) { }

	// RVA: 0x842340 Offset: 0x841740 VA: 0x180842340
	private void DestroyTex(ref Texture2D tex) { }

	// RVA: 0x8454A0 Offset: 0x8448A0 VA: 0x1808454A0
	private void WarmupStrings() { }

	// RVA: 0x8440D0 Offset: 0x8434D0 VA: 0x1808440D0
	private void UpdateTerrainShaderConstants() { }

	// RVA: 0x844010 Offset: 0x843410 VA: 0x180844010
	private void UpdateFoliageDisplaceShaderConstants() { }

	// RVA: 0x844050 Offset: 0x843450 VA: 0x180844050
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0x844F60 Offset: 0x844360 VA: 0x180844F60
	private void UpdateTerrainToGlobal() { }

	// RVA: 0x843D10 Offset: 0x843110 VA: 0x180843D10
	public void TriggerUpdateGlobalParams() { }

	// RVA: 0x843D00 Offset: 0x843100 VA: 0x180843D00
	public void TriggerBasePyramidUpdate() { }

	// RVA: 0x8460B0 Offset: 0x8454B0 VA: 0x1808460B0
	public void .ctor() { }

	// RVA: 0x845DA0 Offset: 0x8451A0 VA: 0x180845DA0
	private static void .cctor() { }

}

private enum TerrainTexturing.LayerPropID // TypeDefIndex: 10432
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int block; // 0x10
	public int dstsize; // 0x14
	public int srcsize; // 0x18
	public float hscale_s; // 0x1C
	public float ny; // 0x20
	public float hscale; // 0x24
	public float hoffset; // 0x28
	public Color[] pixels; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_1 // TypeDefIndex: 10434
{	// Fields
	public Color32[] heightColors; // 0x10
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x853D70 Offset: 0x853170 VA: 0x180853D70
	internal void <CacheCoarseHeightSlopeTexture>b__0(int dz) { }

}

private sealed class TerrainTexturing.<>c__DisplayClass27_2 // TypeDefIndex: 10435
{	// Fields
	public short[] heights; // 0x10
	public int heightres; // 0x18
	public TerrainTexturing.<>c__DisplayClass27_0 CS$<>8__locals2; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8541A0 Offset: 0x8535A0 VA: 0x1808541A0
	internal void <CacheCoarseHeightSlopeTexture>b__1(int dz) { }

}

