public class WaterSimulation // TypeDefIndex: 10622
{	// Fields
	private const int MaxSolverResolution = 512;
	private WaterSystem water; // 0x10
	private Camera camera; // 0x18
	private int solverResolution; // 0x20
	private float solverSizeInWorld; // 0x24
	private float gravity; // 0x28
	private float amplitude; // 0x2C
	private int solverButterflyCount; // 0x30
	private Vector2 windDirection; // 0x34
	private float windMagnitude; // 0x3C
	private RenderTexture displacementMap; // 0x40
	private Vector4 displacementMapTexelSize; // 0x48
	private RenderTexture normalFoldMap; // 0x58
	private Material computeNormalFoldMat; // 0x60
	private Material simulationMat; // 0x68
	private Texture2D hTilde0Map; // 0x70
	private Texture2D dispersionMap; // 0x78
	private Texture2D butterflyMap; // 0x80
	private RenderTexture hTilde_hMap; // 0x88
	private RenderTexture hTilde_dxdzMap; // 0x90
	private CommandBufferManager commandBufferManager; // 0x98
	private CommandBufferDesc commandBufferDesc; // 0xA0
	private bool playing; // 0xA8
	private bool initialized; // 0xA9

	// Properties
	public Texture DisplacementMap { get; }
	public Vector4 DisplacementMapTexelSize { get; }
	public RenderTexture NormalFoldMap { get; }
	public bool IsPlaying { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Texture get_DisplacementMap() { }

	// RVA: 0xC1F280 Offset: 0xC1E680 VA: 0x180C1F280
	public Vector4 get_DisplacementMapTexelSize() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public RenderTexture get_NormalFoldMap() { }

	// RVA: 0x7E83F0 Offset: 0x7E77F0 VA: 0x1807E83F0
	public bool get_IsPlaying() { }

	// RVA: 0xC1F290 Offset: 0xC1E690 VA: 0x180C1F290
	public bool get_IsInitialized() { }

	// RVA: 0xC1E0A0 Offset: 0xC1D4A0 VA: 0x180C1E0A0
	public void Initialize(WaterSystem water, WaterRuntime runtime) { }

	// RVA: 0xC1D1E0 Offset: 0xC1C5E0 VA: 0x180C1D1E0
	public void Destroy() { }

	// RVA: 0xC1C6D0 Offset: 0xC1BAD0 VA: 0x180C1C6D0
	private void CheckCommandBuffer() { }

	// RVA: 0xC1CA30 Offset: 0xC1BE30 VA: 0x180C1CA30
	private void CleanupCommandBuffer() { }

	// RVA: 0xC1D4E0 Offset: 0xC1C8E0 VA: 0x180C1D4E0
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3C10 Offset: 0x5F3010 VA: 0x1805F3C10
	|-WaterSimulation.SafeDestroy<object>
	|-WaterSimulation.SafeDestroy<Material>
	|-WaterSimulation.SafeDestroy<RenderTexture>
	|-WaterSimulation.SafeDestroy<Texture2D>
	*/

	// RVA: 0xC1DBD0 Offset: 0xC1CFD0 VA: 0x180C1DBD0
	private void InitializeMaterials() { }

	// RVA: 0xC1D0D0 Offset: 0xC1C4D0 VA: 0x180C1D0D0
	private void DestroyMaterials() { }

	// RVA: 0xC1E4F0 Offset: 0xC1D8F0 VA: 0x180C1E4F0
	private int ReverseBits(int value, int bitCount) { }

	// RVA: 0xC1CB00 Offset: 0xC1BF00 VA: 0x180C1CB00
	private WaterSimulation.Butterfly[] CreateButterflyTable(int res, int numButterflies) { }

	// RVA: 0xC1CEA0 Offset: 0xC1C2A0 VA: 0x180C1CEA0
	private RenderTexture CreateRenderTexture(string name, int width, int height, RenderTextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC1CFD0 Offset: 0xC1C3D0 VA: 0x180C1CFD0
	private Texture2D CreateTexture(string name, int width, int height, TextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC1DCC0 Offset: 0xC1D0C0 VA: 0x180C1DCC0
	private void InitializeTextures() { }

	// RVA: 0xC1D120 Offset: 0xC1C520 VA: 0x180C1D120
	private void DestroyTextures() { }

	// RVA: 0xC1D770 Offset: 0xC1CB70 VA: 0x180C1D770
	private void InitializeFFT() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void DestroyFFT() { }

	// RVA: 0xC1C220 Offset: 0xC1B620 VA: 0x180C1C220
	private void BindMaterialProperties() { }

	// RVA: 0xC1C8B0 Offset: 0xC1BCB0 VA: 0x180C1C8B0
	public bool CheckLostData() { }

	// RVA: 0xC1EF60 Offset: 0xC1E360 VA: 0x180C1EF60
	private void UpdateSimulationParams() { }

	// RVA: 0xC1F210 Offset: 0xC1E610 VA: 0x180C1F210
	public void Update() { }

	// RVA: 0x95E750 Offset: 0x95DB50 VA: 0x18095E750
	public void Play() { }

	// RVA: 0xC1E9D0 Offset: 0xC1DDD0 VA: 0x180C1E9D0
	public void Stop() { }

	// RVA: 0xC1D3F0 Offset: 0xC1C7F0 VA: 0x180C1D3F0
	private float Dispersion(int n_prime, int m_prime) { }

	// RVA: 0xC1E2D0 Offset: 0xC1D6D0 VA: 0x180C1E2D0
	private float Phillips(int n_prime, int m_prime) { }

	// RVA: 0xC1D6C0 Offset: 0xC1CAC0 VA: 0x180C1D6C0
	private float Gauss() { }

	// RVA: 0xC1F2A0 Offset: 0xC1E6A0 VA: 0x180C1F2A0
	private Vector2 hTilde_0(int n_prime, int m_prime) { }

	// RVA: 0xC1D310 Offset: 0xC1C710 VA: 0x180C1D310
	private void Disperse(CommandBuffer cb) { }

	// RVA: 0xC1C3F0 Offset: 0xC1B7F0 VA: 0x180C1C3F0
	private void BlitOverride(CommandBuffer cb, RenderTexture source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0xC1E9E0 Offset: 0xC1DDE0 VA: 0x180C1E9E0
	private void Transform(CommandBuffer cb, RenderTexture data) { }

	// RVA: 0xC1F120 Offset: 0xC1E520 VA: 0x180C1F120
	private void UpdateTextures(CommandBuffer cb) { }

	// RVA: 0xC1E520 Offset: 0xC1D920 VA: 0x180C1E520
	public void ShowDebug() { }

	// RVA: 0xC1F250 Offset: 0xC1E650 VA: 0x180C1F250
	public void .ctor() { }

}

public struct WaterSimulation.Butterfly // TypeDefIndex: 10623
{	// Fields
	public int i; // 0x0
	public int j; // 0x4
	public float wr; // 0x8
	public float wi; // 0xC

}

