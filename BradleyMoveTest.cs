public class BradleyMoveTest : MonoBehaviour // TypeDefIndex: 8860
{	// Fields
	public WheelCollider[] leftWheels; // 0x18
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

	// Methods

	// RVA: 0x53A610 Offset: 0x539A10 VA: 0x18053A610
	public void Awake() { }

	// RVA: 0x53A610 Offset: 0x539A10 VA: 0x18053A610
	public void Initialize() { }

	// RVA: 0x53AE10 Offset: 0x53A210 VA: 0x18053AE10
	public void SetDestination(Vector3 dest) { }

	// RVA: 0x53A6A0 Offset: 0x539AA0 VA: 0x18053A6A0
	public void FixedUpdate() { }

	// RVA: 0x53A530 Offset: 0x539930 VA: 0x18053A530
	public void ApplyBrakes(float amount) { }

	// RVA: 0x53AD70 Offset: 0x53A170 VA: 0x18053AD70
	public float GetMotorTorque(bool rightSide) { }

	// RVA: 0x53AE20 Offset: 0x53A220 VA: 0x18053AE20
	public void SetMotorTorque(float newThrottle, bool rightSide, float torqueAmount) { }

	// RVA: 0x53A4A0 Offset: 0x5398A0 VA: 0x18053A4A0
	public void ApplyBrakeTorque(float amount, bool rightSide) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void AdjustFriction() { }

	// RVA: 0x53AF10 Offset: 0x53A310 VA: 0x18053AF10
	public void .ctor() { }

}

