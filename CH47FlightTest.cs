public class CH47FlightTest : MonoBehaviour // TypeDefIndex: 8854
{	public Rigidbody rigidBody; // 0x18
	public float engineThrustMax; // 0x20
	public Vector3 torqueScale; // 0x24
	public Transform com; // 0x30
	public Transform[] GroundPoints; // 0x38
	public Transform[] GroundEffects; // 0x40
	public float currentThrottle; // 0x48
	public float avgThrust; // 0x4C
	public float liftDotMax; // 0x50
	public Transform AIMoveTarget; // 0x58
	private static float altitudeTolerance; // 0x0


	public void Awake() { }

	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	public float GetIdealAltitude() { }

	public void FixedUpdate() { }

	public void OnDrawGizmos() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 8855
{	public float throttle; // 0x0
	public float roll; // 0x4
	public float yaw; // 0x8
	public float pitch; // 0xC

}

