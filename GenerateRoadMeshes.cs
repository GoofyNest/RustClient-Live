public class GenerateRoadMeshes : ProceduralComponent // TypeDefIndex: 10525
{
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = True;
	public Mesh RoadMesh; 
	public Mesh[] RoadMeshes; 
	public Material RoadMaterial; 
	public Material RoadRingMaterial; 
	public PhysicMaterial RoadPhysicMaterial; 

	public override bool RunOnCache { get; }


	public override void Process(uint seed) { }

	public override bool get_RunOnCache() { }

	public void .ctor() { }

}

