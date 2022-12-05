public class BucketVMFluidSim : MonoBehaviour // TypeDefIndex: 11070
{
	public Animator waterbucketAnim;
	public ParticleSystem waterPour;
	public ParticleSystem waterTurbulence;
	public ParticleSystem waterFill;
	public float waterLevel;
	public float targetWaterLevel;
	public AudioSource waterSpill;
	private float PlayerEyePitch;
	private float turb_forward;
	private float turb_side;
	private Vector3 lastPosition;
	protected Vector3 groundSpeedLast;
	private Vector3 lastAngle;
	protected Vector3 vecAngleSpeedLast;
	private Vector3 initialPosition;


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

