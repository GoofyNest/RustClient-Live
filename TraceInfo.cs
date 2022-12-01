public struct TraceInfo // TypeDefIndex: 10996
{
	public bool valid;
	public float distance;
	public BaseEntity entity;
	public Vector3 point;
	public Vector3 normal;
	public Transform bone;
	public PhysicMaterial material;
	public uint partID;
	public Collider collider;


	public void UpdateHitTest(HitTest test) { }

	public uint BoneID() { }

	public uint MaterialID() { }

}

