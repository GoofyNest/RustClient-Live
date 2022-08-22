public class BradleyMoveTest : MonoBehaviour // TypeDefIndex: 8860
{	public WheelCollider[] leftWheels; // 0x18
	public WheelCollider[] rightWheels; // 0x20
	public float moveForceMax; // 0x28
	public float brakeForce; // 0x2C
	public float throttle; // 0x30
	public float turnForce; // 0x34
	public float sideStiffnessMax; // 0x38
	public float sideStiffnessMin; // 0x3C
	public Transform centerOfMass; // 0x40
	public float turning; // 0x48
	public bool brake; // 0x4C
	public Rigidbody myRigidBody; // 0x50
	public Vector3 destination; // 0x58
	public float stoppingDist; // 0x64
	public GameObject followTest; // 0x68


	public void Awake() { }

	public void Initialize() { }

	public void SetDestination(Vector3 dest) { }

	public void FixedUpdate() { }

	public void ApplyBrakes(float amount) { }

	public float GetMotorTorque(bool rightSide) { }

	public void SetMotorTorque(float newThrottle, bool rightSide, float torqueAmount) { }

	public void ApplyBrakeTorque(float amount, bool rightSide) { }

	public void AdjustFriction() { }

	public void .ctor() { }

}

