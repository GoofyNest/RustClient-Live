public class DeployVolumeCapsule : DeployVolume // TypeDefIndex: 9845
{	// Fields
	public Vector3 center; // 0xB0
	public float radius; // 0xBC
	public float height; // 0xC0

	// Methods

	// RVA: 0x9B2100 Offset: 0x9B1500 VA: 0x1809B2100 Slot: 8
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1) { }

	// RVA: 0x9B2610 Offset: 0x9B1A10 VA: 0x1809B2610
	public void .ctor() { }

}

