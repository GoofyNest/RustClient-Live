public class GenerateRiverMeshes : ProceduralComponent // TypeDefIndex: 10500
{	// Fields
	public const float NormalSmoothing = 0,1;
	public const bool SnapToTerrain = True;
	public Mesh RiverMesh; // 0x28
	public Mesh[] RiverMeshes; // 0x30
	public Material RiverMaterial; // 0x38
	public PhysicMaterial RiverPhysicMaterial; // 0x40

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC716B0 Offset: 0xC70AB0 VA: 0x180C716B0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

