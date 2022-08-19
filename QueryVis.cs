public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9224
{	// Fields
	public Collider checkCollider; // 0x18
	private CoverageQueries.Query query; // 0x20
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x28
	public float coverageRadius; // 0x2C
	private float nextCPUSampleTime; // 0x30
	private float lastCPUSampleValue; // 0x34

	// Methods

	// RVA: 0x69A3E0 Offset: 0x6997E0 VA: 0x18069A3E0
	public void OnEnable() { }

	// RVA: 0x69A3C0 Offset: 0x6997C0 VA: 0x18069A3C0
	public void OnDisable() { }

	// RVA: 0x69A8A0 Offset: 0x699CA0 VA: 0x18069A8A0
	public float SampleVisibility() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x69A530 Offset: 0x699930 VA: 0x18069A530
	public float SampleVisibilityCPU() { }

	// RVA: 0x69A9B0 Offset: 0x699DB0 VA: 0x18069A9B0
	public void .ctor() { }

}

