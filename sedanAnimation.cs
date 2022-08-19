public class sedanAnimation : MonoBehaviour // TypeDefIndex: 8298
{	// Fields
	public Transform[] frontAxles; // 0x18
	public Transform FL_shock; // 0x20
	public Transform FL_wheel; // 0x28
	public Transform FR_shock; // 0x30
	public Transform FR_wheel; // 0x38
	public Transform RL_shock; // 0x40
	public Transform RL_wheel; // 0x48
	public Transform RR_shock; // 0x50
	public Transform RR_wheel; // 0x58
	public WheelCollider FL_wheelCollider; // 0x60
	public WheelCollider FR_wheelCollider; // 0x68
	public WheelCollider RL_wheelCollider; // 0x70
	public WheelCollider RR_wheelCollider; // 0x78
	public Transform steeringWheel; // 0x80
	public float motorForceConstant; // 0x88
	public float brakeForceConstant; // 0x8C
	public float brakePedal; // 0x90
	public float gasPedal; // 0x94
	public float steering; // 0x98
	private Rigidbody myRigidbody; // 0xA0
	public float GasLerpTime; // 0xA8
	public float SteeringLerpTime; // 0xAC
	private float wheelSpinConstant; // 0xB0
	private float shockRestingPosY; // 0xB4
	private float shockDistance; // 0xB8
	private float traceDistanceNeutralPoint; // 0xBC

	// Methods

	// RVA: 0x1A9BB90 Offset: 0x1A9AF90 VA: 0x181A9BB90
	private void Start() { }

	// RVA: 0x1A9C8F0 Offset: 0x1A9BCF0 VA: 0x181A9C8F0
	private void Update() { }

	// RVA: 0x1A9B8A0 Offset: 0x1A9ACA0 VA: 0x181A9B8A0
	private void InputPlayer() { }

	// RVA: 0x1A9B500 Offset: 0x1A9A900 VA: 0x181A9B500
	private void DoSteering() { }

	// RVA: 0x1A9B360 Offset: 0x1A9A760 VA: 0x181A9B360
	private void ApplyForceAtWheels() { }

	// RVA: 0x1A9BBE0 Offset: 0x1A9AFE0 VA: 0x181A9BBE0
	private void UpdateTireAnimation() { }

	// RVA: 0x1A9B550 Offset: 0x1A9A950 VA: 0x181A9B550
	private float GetShockHeightDelta(WheelCollider wheel) { }

	// RVA: 0x1A9C960 Offset: 0x1A9BD60 VA: 0x181A9C960
	public void .ctor() { }

}

