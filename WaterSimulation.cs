public class WaterSimulation // TypeDefIndex: 10622
{	private const int MaxSolverResolution = 512;
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

	public Texture DisplacementMap { get; }
	public Vector4 DisplacementMapTexelSize { get; }
	public RenderTexture NormalFoldMap { get; }
	public bool IsPlaying { get; }
	public bool IsInitialized { get; }


	public Texture get_DisplacementMap() { }

	public Vector4 get_DisplacementMapTexelSize() { }

	public RenderTexture get_NormalFoldMap() { }

	public bool get_IsPlaying() { }

	public bool get_IsInitialized() { }

	public void Initialize(WaterSystem water, WaterRuntime runtime) { }

	public void Destroy() { }

	private void CheckCommandBuffer() { }

	private void CleanupCommandBuffer() { }

	private void FillCommandBuffer(CommandBuffer cb) { }

	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-WaterSimulation.SafeDestroy<object>
	|-WaterSimulation.SafeDestroy<Material>
	|-WaterSimulation.SafeDestroy<RenderTexture>
	|-WaterSimulation.SafeDestroy<Texture2D>
	*/

	private void InitializeMaterials() { }

	private void DestroyMaterials() { }

	private int ReverseBits(int value, int bitCount) { }

	private WaterSimulation.Butterfly[] CreateButterflyTable(int res, int numButterflies) { }

	private RenderTexture CreateRenderTexture(string name, int width, int height, RenderTextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	private Texture2D CreateTexture(string name, int width, int height, TextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	private void InitializeTextures() { }

	private void DestroyTextures() { }

	private void InitializeFFT() { }

	private void DestroyFFT() { }

	private void BindMaterialProperties() { }

	public bool CheckLostData() { }

	private void UpdateSimulationParams() { }

	public void Update() { }

	public void Play() { }

	public void Stop() { }

	private float Dispersion(int n_prime, int m_prime) { }

	private float Phillips(int n_prime, int m_prime) { }

	private float Gauss() { }

	private Vector2 hTilde_0(int n_prime, int m_prime) { }

	private void Disperse(CommandBuffer cb) { }

	private void BlitOverride(CommandBuffer cb, RenderTexture source, RenderTargetIdentifier destination, Material material, int pass) { }

	private void Transform(CommandBuffer cb, RenderTexture data) { }

	private void UpdateTextures(CommandBuffer cb) { }

	public void ShowDebug() { }

	public void .ctor() { }

}

public struct WaterSimulation.Butterfly // TypeDefIndex: 10623
{	public int i; // 0x0
	public int j; // 0x4
	public float wr; // 0x8
	public float wi; // 0xC

}

