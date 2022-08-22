public class GenerateRoadMeshes : ProceduralComponent // TypeDefIndex: 10514
{	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = True;
	public Mesh RoadMesh; // 0x28
	public Mesh[] RoadMeshes; // 0x30
	public Material RoadMaterial; // 0x38
	public Material RoadRingMaterial; // 0x40
	public PhysicMaterial RoadPhysicMaterial; // 0x48

	public override bool RunOnCache { get; }


	public override void Process(uint seed) { }

	public override bool get_RunOnCache() { }

	public void .ctor() { }

}

