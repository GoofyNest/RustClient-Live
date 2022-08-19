public class CoverageQueryFlare : BaseMonoBehaviour, IClientComponent, IOnParentDestroying, ILOD // TypeDefIndex: 8810
{	// Fields
	public bool isDynamic; // 0x18
	public bool timeShimmer; // 0x19
	public bool positionalShimmer; // 0x1A
	public bool rotate; // 0x1B
	public float maxVisibleDistance; // 0x1C
	public bool lightScaled; // 0x20
	public float dotMin; // 0x24
	public float dotMax; // 0x28
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x2C
	public float coverageRadius; // 0x30
	public LODDistanceMode DistanceMode; // 0x34
	private const float tickRate = 0,03030303;
	private static MaterialPropertyBlock block; // 0x0
	private bool isCulled; // 0x38
	private bool isOccluded; // 0x39
	private int curlod; // 0x3C
	private CoverageQueries.Query query; // 0x40
	private bool queryRegistered; // 0x48
	private float privateRand; // 0x4C
	private bool force; // 0x50
	private LODCell cell; // 0x58
	private float currentDistance; // 0x60
	private Renderer flareRenderer; // 0x68
	private Renderer orbRenderer; // 0x70
	private float startColorMultiplier; // 0x78
	private float flareIntensity; // 0x7C
	private float visibleFraction; // 0x80
	private bool destroying; // 0x84
	private readonly int VisibleFraction_DotMin_DotMax_Rotate; // 0x88
	private readonly int PShimmer_TShimmer_Seed_LightScale; // 0x8C
	private readonly int ColorMultID; // 0x90
	private LODEnvironmentMode EnvironmentMode; // 0x94

	// Properties
	public float CurrentDistance { get; }

	// Methods

	// RVA: 0x51BCC0 Offset: 0x51B0C0 VA: 0x18051BCC0
	public float get_CurrentDistance() { }

	// RVA: 0x51AB00 Offset: 0x519F00 VA: 0x18051AB00
	private float GetDistance() { }

	// RVA: 0x51A810 Offset: 0x519C10 VA: 0x18051A810
	private void Awake() { }

	// RVA: 0x51AED0 Offset: 0x51A2D0 VA: 0x18051AED0
	private void OnEnable() { }

	// RVA: 0x51A960 Offset: 0x519D60 VA: 0x18051A960 Slot: 7
	public void ChangeLOD() { }

	// RVA: 0x51B0B0 Offset: 0x51A4B0 VA: 0x18051B0B0 Slot: 8
	public void RefreshLOD() { }

	// RVA: 0x51ABD0 Offset: 0x519FD0 VA: 0x18051ABD0
	private int GetLOD(float distance) { }

	// RVA: 0x51B560 Offset: 0x51A960 VA: 0x18051B560
	private void SetLOD(int newlod) { }

	// RVA: 0x51B6B0 Offset: 0x51AAB0 VA: 0x18051B6B0
	private void Show() { }

	// RVA: 0x51AD20 Offset: 0x51A120 VA: 0x18051AD20
	private void Hide() { }

	// RVA: 0x51B5E0 Offset: 0x51A9E0 VA: 0x18051B5E0
	private void ShowRenderers() { }

	// RVA: 0x51AC50 Offset: 0x51A050 VA: 0x18051AC50
	private void HideRenderers() { }

	// RVA: 0x51B080 Offset: 0x51A480 VA: 0x18051B080 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x51B790 Offset: 0x51AB90 VA: 0x18051B790
	public void Tick() { }

	// RVA: 0x51B940 Offset: 0x51AD40 VA: 0x18051B940
	private void UpdateMaterialProperties() { }

	// RVA: 0x51B1B0 Offset: 0x51A5B0 VA: 0x18051B1B0
	public float SampleVisibility() { }

	// RVA: 0x51B550 Offset: 0x51A950 VA: 0x18051B550
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x51B140 Offset: 0x51A540 VA: 0x18051B140
	private void RegisterCoverageQuery() { }

	// RVA: 0x51B820 Offset: 0x51AC20 VA: 0x18051B820
	private void UnRegisterCoverageQuery() { }

	// RVA: 0x51ADA0 Offset: 0x51A1A0 VA: 0x18051ADA0
	private void OnDisable() { }

	// RVA: 0x51BC20 Offset: 0x51B020 VA: 0x18051BC20
	public void .ctor() { }

}

