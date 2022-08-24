public struct RigidTransform // TypeDefIndex: 7113
{
	public quaternion rot; 
	public float3 pos; 
	public static readonly RigidTransform identity; 


public void .ctor(quaternion rotation, float3 translation) { }

public bool Equals(RigidTransform x) { }

public override bool Equals(object x) { }

public override int GetHashCode() { }

public override string ToString() { }

private static void .cctor() { }

}

