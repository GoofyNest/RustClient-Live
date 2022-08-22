public struct RigidTransform // TypeDefIndex: 7113
{	public quaternion rot; // 0x0
	public float3 pos; // 0x10
	public static readonly RigidTransform identity; // 0x0


	public void .ctor(quaternion rotation, float3 translation) { }

	public bool Equals(RigidTransform x) { }

	public override bool Equals(object x) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private static void .cctor() { }

}

