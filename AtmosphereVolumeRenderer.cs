public class AtmosphereVolumeRenderer : MonoBehaviour // TypeDefIndex: 12391
{
	public FogMode Mode; 
	public bool DistanceFog; 
	public bool HeightFog; 
	public AtmosphereVolume Volume; 
	private Camera targetCamera; 
	private CommandBufferManager commandBufferManager; 
	private CommandBufferDesc commandBufferDesc; 
	private Material fogMaterial; 
	private Vector4[] matrixArray; 
	private static Mesh volumeMesh; 
	private static HashSet<AtmosphereVolume> registeredVolumes; 
	private List<AtmosphereVolumeRenderer.CurrentVolumeEntry> currentVolumes; 

	private static bool isSupported { get; }
	public Camera TargetCamera { get; }


	private static bool get_isSupported() { }

	public Camera get_TargetCamera() { }

	public static void Clear() { }

	public static void Register(AtmosphereVolume volume) { }

	public static void Unregister(AtmosphereVolume volume) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void CheckCommandBuffer() { }

	private void CleanupCommandBuffer() { }

	private void CheckMaterials() { }

	private void CleanupMaterials() { }

	private void UpdateVolumeMesh() { }

	public void FindAndSortVolumes(Camera camera) { }

	public void UpdateAtmosphere() { }

	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera) { }

	private bool SetGlobalShaderParams(CommandBuffer cb) { }

	private void ClearGlobalShaderParams(CommandBuffer cb) { }

	private void FillCommandBuffer(CommandBuffer cb) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct AtmosphereVolumeRenderer.CurrentVolumeEntry // TypeDefIndex: 12392
{
	public AtmosphereVolume volume; 
	public float distanceSqr; 


	public void .ctor(AtmosphereVolume volume, float distance) { }

}

private sealed class AtmosphereVolumeRenderer.<>c // TypeDefIndex: 12393
{
	public static readonly AtmosphereVolumeRenderer.<>c <>9; 
	public static Comparison<AtmosphereVolumeRenderer.CurrentVolumeEntry> <>9__28_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <FindAndSortVolumes>

}

