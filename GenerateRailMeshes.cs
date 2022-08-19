public class GenerateRailMeshes : ProceduralComponent // TypeDefIndex: 10489
{	// Fields
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = False;
	public Mesh RailMesh; // 0x28
	public Mesh[] RailMeshes; // 0x30
	public Material RailMaterial; // 0x38
	public PhysicMaterial RailPhysicMaterial; // 0x40

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC6C370 Offset: 0xC6B770 VA: 0x180C6C370 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC6C110 Offset: 0xC6B510 VA: 0x180C6C110
	private void AddTrackSpline(PathList rail) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

