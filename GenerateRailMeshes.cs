public class GenerateRailMeshes : ProceduralComponent // TypeDefIndex: 10500
{
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = False;
	public Mesh RailMesh; 
	public Mesh[] RailMeshes; 
	public Material RailMaterial; 
	public PhysicMaterial RailPhysicMaterial; 

	public override bool RunOnCache { get; }


	public override void Process(uint seed) { }

	public override bool get_RunOnCache() { }

	private void AddTrackSpline(PathList rail) { }

	public void .ctor() { }

}

