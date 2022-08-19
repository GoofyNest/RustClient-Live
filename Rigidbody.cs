public class Rigidbody : Component // TypeDefIndex: 3920
{	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public bool isKinematic { get; set; }
	public RigidbodyConstraints constraints { set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public Vector3 centerOfMass { set; }
	public bool detectCollisions { set; }
	public Vector3 position { set; }
	public RigidbodyInterpolation interpolation { set; }
	public float sleepThreshold { get; }

	// Methods

	// RVA: 0x2299420 Offset: 0x2298820 VA: 0x182299420
	public Vector3 get_velocity() { }

	// RVA: 0x2299940 Offset: 0x2298D40 VA: 0x182299940
	public void set_velocity(Vector3 value) { }

	// RVA: 0x2299510 Offset: 0x2298910 VA: 0x182299510
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x2299290 Offset: 0x2298690 VA: 0x182299290
	public float get_drag() { }

	// RVA: 0x22996D0 Offset: 0x2298AD0 VA: 0x1822996D0
	public void set_drag(float value) { }

	// RVA: 0x2299210 Offset: 0x2298610 VA: 0x182299210
	public float get_angularDrag() { }

	// RVA: 0x2299470 Offset: 0x2298870 VA: 0x182299470
	public void set_angularDrag(float value) { }

	// RVA: 0x2299310 Offset: 0x2298710 VA: 0x182299310
	public float get_mass() { }

	// RVA: 0x22997B0 Offset: 0x2298BB0 VA: 0x1822997B0
	public void set_mass(float value) { }

	// RVA: 0x2299390 Offset: 0x2298790 VA: 0x182299390
	public bool get_useGravity() { }

	// RVA: 0x22998A0 Offset: 0x2298CA0 VA: 0x1822998A0
	public void set_useGravity(bool value) { }

	// RVA: 0x22992D0 Offset: 0x22986D0 VA: 0x1822992D0
	public bool get_isKinematic() { }

	// RVA: 0x2299760 Offset: 0x2298B60 VA: 0x182299760
	public void set_isKinematic(bool value) { }

	// RVA: 0x2299640 Offset: 0x2298A40 VA: 0x182299640
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x2299250 Offset: 0x2298650 VA: 0x182299250
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x2299600 Offset: 0x2298A00 VA: 0x182299600
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x22995B0 Offset: 0x22989B0 VA: 0x1822995B0
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x2299680 Offset: 0x2298A80 VA: 0x182299680
	public void set_detectCollisions(bool value) { }

	// RVA: 0x2299850 Offset: 0x2298C50 VA: 0x182299850
	public void set_position(Vector3 value) { }

	// RVA: 0x2299720 Offset: 0x2298B20 VA: 0x182299720
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x2299350 Offset: 0x2298750 VA: 0x182299350
	public float get_sleepThreshold() { }

	// RVA: 0x2299190 Offset: 0x2298590 VA: 0x182299190
	public bool IsSleeping() { }

	// RVA: 0x22991D0 Offset: 0x22985D0 VA: 0x1822991D0
	public void WakeUp() { }

	// RVA: 0x2299070 Offset: 0x2298470 VA: 0x182299070
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2299020 Offset: 0x2298420 VA: 0x182299020
	public void AddForce(Vector3 force) { }

	// RVA: 0x2299130 Offset: 0x2298530 VA: 0x182299130
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x2298F50 Offset: 0x2298350 VA: 0x182298F50
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	public void .ctor() { }

	// RVA: 0x22993D0 Offset: 0x22987D0 VA: 0x1822993D0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x22998F0 Offset: 0x2298CF0 VA: 0x1822998F0
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x22994C0 Offset: 0x22988C0 VA: 0x1822994C0
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x2299560 Offset: 0x2298960 VA: 0x182299560
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x2299800 Offset: 0x2298C00 VA: 0x182299800
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2298FC0 Offset: 0x22983C0 VA: 0x182298FC0
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x22990D0 Offset: 0x22984D0 VA: 0x1822990D0
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x2298EE0 Offset: 0x22982E0 VA: 0x182298EE0
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

