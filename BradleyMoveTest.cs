public class BradleyMoveTest : MonoBehaviour // TypeDefIndex: 10592
{
	public WheelCollider[] leftWheels;
	public WheelCollider[] rightWheels;
	public float moveForceMax;
	public float brakeForce;
	public float throttle;
	public float turnForce;
	public float sideStiffnessMax;
	public float sideStiffnessMin;
	public Transform centerOfMass;
	public float turning;
	public bool brake;
	public Rigidbody myRigidBody;
	public Vector3 destination;
	public float stoppingDist;
	public GameObject followTest;


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

