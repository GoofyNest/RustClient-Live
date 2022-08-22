public class GenerateRailMeshes : ProceduralComponent // TypeDefIndex: 10489
{	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = False;
	public Mesh RailMesh; // 0x28
	public Mesh[] RailMeshes; // 0x30
	public Material RailMaterial; // 0x38
	public PhysicMaterial RailPhysicMaterial; // 0x40

	public override bool RunOnCache { get; }


	public override void Process(uint seed) { }

	public override bool get_RunOnCache() { }

	private void AddTrackSpline(PathList rail) { }

	public void .ctor() { }

}

