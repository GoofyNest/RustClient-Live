public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 10932
{
	public Collider checkCollider; 
	private CoverageQueries.Query query; 
	public CoverageQueries.RadiusSpace coverageRadiusSpace; 
	public float coverageRadius; 
	private float nextCPUSampleTime; 
	private float lastCPUSampleValue; 


	public void OnEnable() { }

	public void OnDisable() { }

	public float SampleVisibility() { }

	public void OnParentDestroying() { }

	public float SampleVisibilityCPU() { }

	public void .ctor() { }

}

