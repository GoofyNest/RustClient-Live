public class GenerateRoadMeshes : ProceduralComponent // TypeDefIndex: 10514
{	// Fields
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = True;
	public Mesh RoadMesh; // 0x28
	public Mesh[] RoadMeshes; // 0x30
	public Material RoadMaterial; // 0x38
	public Material RoadRingMaterial; // 0x40
	public PhysicMaterial RoadPhysicMaterial; // 0x48

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC742D0 Offset: 0xC736D0 VA: 0x180C742D0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

