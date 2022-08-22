public class BucketVMFluidSim : MonoBehaviour // TypeDefIndex: 9328
{	public Animator waterbucketAnim; // 0x18
	public ParticleSystem waterPour; // 0x20
	public ParticleSystem waterTurbulence; // 0x28
	public ParticleSystem waterFill; // 0x30
	public float waterLevel; // 0x38
	public float targetWaterLevel; // 0x3C
	public AudioSource waterSpill; // 0x40
	private float PlayerEyePitch; // 0x48
	private float turb_forward; // 0x4C
	private float turb_side; // 0x50
	private Vector3 lastPosition; // 0x54
	protected Vector3 groundSpeedLast; // 0x60
	private Vector3 lastAngle; // 0x6C
	protected Vector3 vecAngleSpeedLast; // 0x78
	private Vector3 initialPosition; // 0x84


	private void Start() { }

	private void SetFillingFromWorld(bool isFilling) { }

	private void UpdateWaterLevel(float newLevel) { }

	private void Update() { }

	private void CalculateTurbulence() { }

	private void DoWaterTipping() { }

	public void AddWater(float waterAmount) { }

	private void DisableWaterSpillEffects() { }

	private void UpdateWaterLine() { }

	private float fsel(float c, float x, float y) { }

	private float RemapValClamped(float val, float A, float B, float C, float D) { }

	public void .ctor() { }

}

