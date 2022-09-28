public class sedanAnimation : MonoBehaviour // TypeDefIndex: 9968
{
	public Transform[] frontAxles; 
	public Transform FL_shock; 
	public Transform FL_wheel; 
	public Transform FR_shock; 
	public Transform FR_wheel; 
	public Transform RL_shock; 
	public Transform RL_wheel; 
	public Transform RR_shock; 
	public Transform RR_wheel; 
	public WheelCollider FL_wheelCollider; 
	public WheelCollider FR_wheelCollider; 
	public WheelCollider RL_wheelCollider; 
	public WheelCollider RR_wheelCollider; 
	public Transform steeringWheel; 
	public float motorForceConstant; 
	public float brakeForceConstant; 
	public float brakePedal; 
	public float gasPedal; 
	public float steering; 
	private Rigidbody myRigidbody; 
	public float GasLerpTime; 
	public float SteeringLerpTime; 
	private float wheelSpinConstant; 
	private float shockRestingPosY; 
	private float shockDistance; 
	private float traceDistanceNeutralPoint; 


	private void Start() { }

	private void Update() { }

	private void InputPlayer() { }

	private void DoSteering() { }

	private void ApplyForceAtWheels() { }

	private void UpdateTireAnimation() { }

	private float GetShockHeightDelta(WheelCollider wheel) { }

	public void .ctor() { }

}

