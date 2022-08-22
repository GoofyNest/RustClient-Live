public class AtmosphereVolumeRenderer : MonoBehaviour // TypeDefIndex: 10640
{	public FogMode Mode; // 0x18
	public bool DistanceFog; // 0x1C
	public bool HeightFog; // 0x1D
	public AtmosphereVolume Volume; // 0x20
	private Camera targetCamera; // 0x28
	private CommandBufferManager commandBufferManager; // 0x30
	private CommandBufferDesc commandBufferDesc; // 0x38
	private Material fogMaterial; // 0x40
	private Vector4[] matrixArray; // 0x48
	private static Mesh volumeMesh; // 0x0
	private static HashSet<AtmosphereVolume> registeredVolumes; // 0x8
	private List<AtmosphereVolumeRenderer.CurrentVolumeEntry> currentVolumes; // 0x50

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

private struct AtmosphereVolumeRenderer.CurrentVolumeEntry // TypeDefIndex: 10641
{	public AtmosphereVolume volume; // 0x0
	public float distanceSqr; // 0x8


	public void .ctor(AtmosphereVolume volume, float distance) { }

}

private sealed class AtmosphereVolumeRenderer.<>c // TypeDefIndex: 10642
{	public static readonly AtmosphereVolumeRenderer.<>c <>9; // 0x0
	public static Comparison<AtmosphereVolumeRenderer.CurrentVolumeEntry> <>9__28_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y) { }

}

