public class Rigidbody : Component // TypeDefIndex: 3925
{
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


	public Vector3 get_velocity() { }

	public void set_velocity(Vector3 value) { }

	public void set_angularVelocity(Vector3 value) { }

	public float get_drag() { }

	public void set_drag(float value) { }

	public float get_angularDrag() { }

	public void set_angularDrag(float value) { }

	public float get_mass() { }

	public void set_mass(float value) { }

	public bool get_useGravity() { }

	public void set_useGravity(bool value) { }

	public bool get_isKinematic() { }

	public void set_isKinematic(bool value) { }

	public void set_constraints(RigidbodyConstraints value) { }

	public CollisionDetectionMode get_collisionDetectionMode() { }

	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	public void set_centerOfMass(Vector3 value) { }

	public void set_detectCollisions(bool value) { }

	public void set_position(Vector3 value) { }

	public void set_interpolation(RigidbodyInterpolation value) { }

	public float get_sleepThreshold() { }

	public bool IsSleeping() { }

	public void WakeUp() { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocsAttribute] 
	public void AddForce(Vector3 force) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	public void .ctor() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	private void set_velocity_Injected(ref Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	private void set_centerOfMass_Injected(ref Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

}

