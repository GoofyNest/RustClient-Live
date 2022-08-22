public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9224
{	public Collider checkCollider; // 0x18
	private CoverageQueries.Query query; // 0x20
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x28
	public float coverageRadius; // 0x2C
	private float nextCPUSampleTime; // 0x30
	private float lastCPUSampleValue; // 0x34


	public void OnEnable() { }

	public void OnDisable() { }

	public float SampleVisibility() { }

	public void OnParentDestroying() { }

	public float SampleVisibilityCPU() { }

	public void .ctor() { }

}

