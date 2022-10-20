public class CoverageQueryFlare : BaseMonoBehaviour, IClientComponent, IOnParentDestroying, ILOD // TypeDefIndex: 10520
{
	public bool isDynamic; 
	public bool timeShimmer; 
	public bool positionalShimmer; 
	public bool rotate; 
	public float maxVisibleDistance; 
	public bool lightScaled; 
	public float dotMin; 
	public float dotMax; 
	public CoverageQueries.RadiusSpace coverageRadiusSpace; 
	public float coverageRadius; 
	public LODDistanceMode DistanceMode; 
	private const float tickRate = 0,03030303;
	private static MaterialPropertyBlock block; 
	private bool isCulled; 
	private bool isOccluded; 
	private int curlod; 
	private CoverageQueries.Query query; 
	private bool queryRegistered; 
	private float privateRand; 
	private bool force; 
	private LODCell cell; 
	private float currentDistance; 
	private Renderer flareRenderer; 
	private Renderer orbRenderer; 
	private float startColorMultiplier; 
	private float flareIntensity; 
	private float visibleFraction; 
	private bool destroying; 
	private readonly int VisibleFraction_DotMin_DotMax_Rotate; 
	private readonly int PShimmer_TShimmer_Seed_LightScale; 
	private readonly int ColorMultID; 
	private LODEnvironmentMode EnvironmentMode; 

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

