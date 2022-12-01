public class WaterSimulation // TypeDefIndex: 12381
{
	private const int MaxSolverResolution = 512;
	private WaterSystem water;
	private Camera camera;
	private int solverResolution;
	private float solverSizeInWorld;
	private float gravity;
	private float amplitude;
	private int solverButterflyCount;
	private Vector2 windDirection;
	private float windMagnitude;
	private RenderTexture displacementMap;
	private Vector4 displacementMapTexelSize;
	private RenderTexture normalFoldMap;
	private Material computeNormalFoldMat;
	private Material simulationMat;
	private Texture2D hTilde0Map;
	private Texture2D dispersionMap;
	private Texture2D butterflyMap;
	private RenderTexture hTilde_hMap;
	private RenderTexture hTilde_dxdzMap;
	private CommandBufferManager commandBufferManager;
	private CommandBufferDesc commandBufferDesc;
	private bool playing;
	private bool initialized;

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

public struct WaterSimulation.Butterfly // TypeDefIndex: 12382
{
	public int i;
	public int j;
	public float wr;
	public float wi;

}

