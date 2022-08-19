public class AtmosphereVolumeRenderer : MonoBehaviour // TypeDefIndex: 10640
{	// Fields
	public FogMode Mode; // 0x18
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

	// Properties
	private static bool isSupported { get; }
	public Camera TargetCamera { get; }

	// Methods

	// RVA: 0x831C30 Offset: 0x831030 VA: 0x180831C30
	private static bool get_isSupported() { }

	// RVA: 0x831B90 Offset: 0x830F90 VA: 0x180831B90
	public Camera get_TargetCamera() { }

	// RVA: 0x82FB60 Offset: 0x82EF60 VA: 0x18082FB60
	public static void Clear() { }

	// RVA: 0x830550 Offset: 0x82F950 VA: 0x180830550
	public static void Register(AtmosphereVolume volume) { }

	// RVA: 0x831760 Offset: 0x830B60 VA: 0x180831760
	public static void Unregister(AtmosphereVolume volume) { }

	// RVA: 0x8304D0 Offset: 0x82F8D0 VA: 0x1808304D0
	private void OnEnable() { }

	// RVA: 0x830330 Offset: 0x82F730 VA: 0x180830330
	private void OnDisable() { }

	// RVA: 0x8319B0 Offset: 0x830DB0 VA: 0x1808319B0
	private void Update() { }

	// RVA: 0x82F720 Offset: 0x82EB20 VA: 0x18082F720
	private void CheckCommandBuffer() { }

	// RVA: 0x82F970 Offset: 0x82ED70 VA: 0x18082F970
	private void CleanupCommandBuffer() { }

	// RVA: 0x82F8A0 Offset: 0x82ECA0 VA: 0x18082F8A0
	private void CheckMaterials() { }

	// RVA: 0x82FA30 Offset: 0x82EE30 VA: 0x18082FA30
	private void CleanupMaterials() { }

	// RVA: 0x831870 Offset: 0x830C70 VA: 0x180831870
	private void UpdateVolumeMesh() { }

	// RVA: 0x82FF90 Offset: 0x82F390 VA: 0x18082FF90
	public void FindAndSortVolumes(Camera camera) { }

	// RVA: 0x831820 Offset: 0x830C20 VA: 0x180831820
	public void UpdateAtmosphere() { }

	// RVA: 0x830610 Offset: 0x82FA10 VA: 0x180830610
	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera) { }

	// RVA: 0x830E00 Offset: 0x830200 VA: 0x180830E00
	private bool SetGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x82FAE0 Offset: 0x82EEE0 VA: 0x18082FAE0
	private void ClearGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x82FC10 Offset: 0x82F010 VA: 0x18082FC10
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x831AF0 Offset: 0x830EF0 VA: 0x180831AF0
	public void .ctor() { }

	// RVA: 0x831A70 Offset: 0x830E70 VA: 0x180831A70
	private static void .cctor() { }

}

private struct AtmosphereVolumeRenderer.CurrentVolumeEntry // TypeDefIndex: 10641
{	// Fields
	public AtmosphereVolume volume; // 0x0
	public float distanceSqr; // 0x8

	// Methods

	// RVA: 0xF8FA0 Offset: 0xF83A0 VA: 0x1800F8FA0
	public void .ctor(AtmosphereVolume volume, float distance) { }

}

private sealed class AtmosphereVolumeRenderer.<>c // TypeDefIndex: 10642
{	// Fields
	public static readonly AtmosphereVolumeRenderer.<>c <>9; // 0x0
	public static Comparison<AtmosphereVolumeRenderer.CurrentVolumeEntry> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x83A980 Offset: 0x839D80 VA: 0x18083A980
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x83A960 Offset: 0x839D60 VA: 0x18083A960
	internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y) { }

}

