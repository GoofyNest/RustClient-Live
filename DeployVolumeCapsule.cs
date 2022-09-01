public class DeployVolumeCapsule : DeployVolume // TypeDefIndex: 9850
{
	public Vector3 center; 
	public float radius; 
	public float height; 


	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1) { }

	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1) { }

	public void .ctor() { }

}

