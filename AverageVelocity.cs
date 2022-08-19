public class AverageVelocity // TypeDefIndex: 9116
{	// Fields
	private Vector3 pos; // 0x10
	private float time; // 0x1C
	private float lastEntry; // 0x20
	private float averageSpeed; // 0x24
	private Vector3 averageVelocity; // 0x28

	// Properties
	public float Speed { get; }
	public Vector3 Average { get; }

	// Methods

	// RVA: 0x7E8470 Offset: 0x7E7870 VA: 0x1807E8470
	public void Record(Vector3 newPos) { }

	// RVA: 0x7E8600 Offset: 0x7E7A00 VA: 0x1807E8600
	public float get_Speed() { }

	// RVA: 0x7E85E0 Offset: 0x7E79E0 VA: 0x1807E85E0
	public Vector3 get_Average() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

