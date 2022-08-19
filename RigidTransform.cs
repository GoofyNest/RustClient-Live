public struct RigidTransform // TypeDefIndex: 7113
{	// Fields
	public quaternion rot; // 0x0
	public float3 pos; // 0x10
	public static readonly RigidTransform identity; // 0x0

	// Methods

	// RVA: 0x22A300 Offset: 0x229700 VA: 0x18022A300
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x239710 Offset: 0x238B10 VA: 0x180239710
	public bool Equals(RigidTransform x) { }

	// RVA: 0x2397B0 Offset: 0x238BB0 VA: 0x1802397B0 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x2398C0 Offset: 0x238CC0 VA: 0x1802398C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2398F0 Offset: 0x238CF0 VA: 0x1802398F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22A87C0 Offset: 0x22A7BC0 VA: 0x1822A87C0
	private static void .cctor() { }

}

