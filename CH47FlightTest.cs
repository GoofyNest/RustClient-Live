public class CH47FlightTest : MonoBehaviour // TypeDefIndex: 8854
{	// Fields
	public Rigidbody rigidBody; // 0x18
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

	// Methods

	// RVA: 0x70DB90 Offset: 0x70CF90 VA: 0x18070DB90
	public void Awake() { }

	// RVA: 0x70EA90 Offset: 0x70DE90 VA: 0x18070EA90
	public CH47FlightTest.HelicopterInputState_t GetHelicopterInputState() { }

	// RVA: 0x70E430 Offset: 0x70D830 VA: 0x18070E430
	public CH47FlightTest.HelicopterInputState_t GetAIInputState() { }

	// RVA: 0x70EBD0 Offset: 0x70DFD0 VA: 0x18070EBD0
	public float GetIdealAltitude() { }

	// RVA: 0x70DBF0 Offset: 0x70CFF0 VA: 0x18070DBF0
	public void FixedUpdate() { }

	// RVA: 0x70EC10 Offset: 0x70E010 VA: 0x18070EC10
	public void OnDrawGizmos() { }

	// RVA: 0x70F000 Offset: 0x70E400 VA: 0x18070F000
	public void .ctor() { }

	// RVA: 0x70EFC0 Offset: 0x70E3C0 VA: 0x18070EFC0
	private static void .cctor() { }

}

public struct CH47FlightTest.HelicopterInputState_t // TypeDefIndex: 8855
{	// Fields
	public float throttle; // 0x0
	public float roll; // 0x4
	public float yaw; // 0x8
	public float pitch; // 0xC

}

