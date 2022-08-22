public class CoverageQueryFlare : BaseMonoBehaviour, IClientComponent, IOnParentDestroying, ILOD // TypeDefIndex: 8810
{	public bool isDynamic; // 0x18
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

	public float CurrentDistance { get; }


	public float get_CurrentDistance() { }

	private float GetDistance() { }

	private void Awake() { }

	private void OnEnable() { }

	public void ChangeLOD() { }

	public void RefreshLOD() { }

	private int GetLOD(float distance) { }

	private void SetLOD(int newlod) { }

	private void Show() { }

	private void Hide() { }

	private void ShowRenderers() { }

	private void HideRenderers() { }

	public void OnParentDestroying() { }

	public void Tick() { }

	private void UpdateMaterialProperties() { }

	public float SampleVisibility() { }

	public void SetFlareIntensity(float intensity) { }

	private void RegisterCoverageQuery() { }

	private void UnRegisterCoverageQuery() { }

	private void OnDisable() { }

	public void .ctor() { }

}

