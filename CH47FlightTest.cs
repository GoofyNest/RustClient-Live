public class CH47FlightTest : MonoBehaviour // TypeDefIndex: 10526
{
	public Rigidbody rigidBody; 
	public float engineThrustMax; 
	public Vector3 torqueScale; 
	public Transform com; 
	public Transform[] GroundPoints; 
	public Transform[] GroundEffects; 
	public float currentThrottle; 
	public float avgThrust; 
	public float liftDotMax; 
	public Transform AIMoveTarget; 
	private static float altitudeTolerance; 


	public void Awake() { }

	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	public float GetIdealAltitude() { }

	public void FixedUpdate() { }

	public void OnDrawGizmos() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 10527
{
	public float throttle; 
	public float roll; 
	public float yaw; 
	public float pitch; 

}

