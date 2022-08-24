public class GenerateRiverMeshes : ProceduralComponent // TypeDefIndex: 10500
{
public const float NormalSmoothing = 0,1;
public const bool SnapToTerrain = True;
	public Mesh RiverMesh; 
	public Mesh[] RiverMeshes; 
	public Material RiverMaterial; 
	public PhysicMaterial RiverPhysicMaterial; 

public override bool RunOnCache { get; }


public override void Process(uint seed) { }

public override bool get_RunOnCache() { }

public void .ctor() { }

}

