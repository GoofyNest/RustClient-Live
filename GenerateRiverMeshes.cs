public class GenerateRiverMeshes : ProceduralComponent // TypeDefIndex: 10500
{	public const float NormalSmoothing = 0,1;
	public const bool SnapToTerrain = True;
	public Mesh RiverMesh; // 0x28
	public Mesh[] RiverMeshes; // 0x30
	public Material RiverMaterial; // 0x38
	public PhysicMaterial RiverPhysicMaterial; // 0x40

	public override bool RunOnCache { get; }


	public override void Process(uint seed) { }

	public override bool get_RunOnCache() { }

	public void .ctor() { }

}

