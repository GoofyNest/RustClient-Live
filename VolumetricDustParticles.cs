public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 11552
{	// Fields
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float alpha; // 0x18
	[RangeAttribute] // RVA: 0xC1F90 Offset: 0xC1390 VA: 0x1800C1F90
	public float size; // 0x1C
	public VolumetricDustParticles.Direction direction; // 0x20
	public float speed; // 0x24
	public float density; // 0x28
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float spawnMaxDistance; // 0x2C
	public bool cullingEnabled; // 0x30
	public float cullingMaxDistance; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isCulled>k__BackingField; // 0x38
	public static bool isFeatureSupported; // 0x0
	private ParticleSystem m_Particles; // 0x40
	private ParticleSystemRenderer m_Renderer; // 0x48
	private static bool ms_NoMainCameraLogged; // 0x1
	private static Camera ms_MainCamera; // 0x8
	private VolumetricLightBeam m_Master; // 0x50

	// Properties
	public bool isCulled { get; set; }
	public bool particlesAreInstantiated { get; }
	public int particlesCurrentCount { get; }
	public int particlesMaxCount { get; }
	public Camera mainCamera { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	private void set_isCulled(bool value) { }

	// RVA: 0xADC370 Offset: 0xADB770 VA: 0x180ADC370
	public bool get_particlesAreInstantiated() { }

	// RVA: 0xADC3D0 Offset: 0xADB7D0 VA: 0x180ADC3D0
	public int get_particlesCurrentCount() { }

	// RVA: 0xADC460 Offset: 0xADB860 VA: 0x180ADC460
	public int get_particlesMaxCount() { }

	// RVA: 0xADC150 Offset: 0xADB550 VA: 0x180ADC150
	public Camera get_mainCamera() { }

	// RVA: 0xADBC30 Offset: 0xADB030 VA: 0x180ADBC30
	private void Start() { }

	// RVA: 0xADB170 Offset: 0xADA570 VA: 0x180ADB170
	private void InstantiateParticleSystem() { }

	// RVA: 0xADB460 Offset: 0xADA860 VA: 0x180ADB460
	private void OnEnable() { }

	// RVA: 0xADB470 Offset: 0xADA870 VA: 0x180ADB470
	private void SetActiveAndPlay() { }

	// RVA: 0xADB3D0 Offset: 0xADA7D0 VA: 0x180ADB3D0
	private void OnDisable() { }

	// RVA: 0xADB310 Offset: 0xADA710 VA: 0x180ADB310
	private void OnDestroy() { }

	// RVA: 0xADC070 Offset: 0xADB470 VA: 0x180ADC070
	private void Update() { }

	// RVA: 0xADB520 Offset: 0xADA920 VA: 0x180ADB520
	private void SetParticleProperties() { }

	// RVA: 0xADBCF0 Offset: 0xADB0F0 VA: 0x180ADBCF0
	private void UpdateCulling() { }

	// RVA: 0xADC110 Offset: 0xADB510 VA: 0x180ADC110
	public void .ctor() { }

	// RVA: 0xADC0A0 Offset: 0xADB4A0 VA: 0x180ADC0A0
	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 11553
{	// Fields
	public int value__; // 0x0
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

