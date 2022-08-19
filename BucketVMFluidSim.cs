public class BucketVMFluidSim : MonoBehaviour // TypeDefIndex: 9328
{	// Fields
	public Animator waterbucketAnim; // 0x18
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

	// Methods

	// RVA: 0x53BB60 Offset: 0x53AF60 VA: 0x18053BB60
	private void Start() { }

	// RVA: 0x53BB40 Offset: 0x53AF40 VA: 0x18053BB40
	private void SetFillingFromWorld(bool isFilling) { }

	// RVA: 0x53BBE0 Offset: 0x53AFE0 VA: 0x18053BBE0
	private void UpdateWaterLevel(float newLevel) { }

	// RVA: 0x53BE80 Offset: 0x53B280 VA: 0x18053BE80
	private void Update() { }

	// RVA: 0x53B4E0 Offset: 0x53A8E0 VA: 0x18053B4E0
	private void CalculateTurbulence() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void DoWaterTipping() { }

	// RVA: 0x53B450 Offset: 0x53A850 VA: 0x18053B450
	public void AddWater(float waterAmount) { }

	// RVA: 0x53B940 Offset: 0x53AD40 VA: 0x18053B940
	private void DisableWaterSpillEffects() { }

	// RVA: 0x53BBF0 Offset: 0x53AFF0 VA: 0x18053BBF0
	private void UpdateWaterLine() { }

	// RVA: 0x53BEF0 Offset: 0x53B2F0 VA: 0x18053BEF0
	private float fsel(float c, float x, float y) { }

	// RVA: 0x53BA60 Offset: 0x53AE60 VA: 0x18053BA60
	private float RemapValClamped(float val, float A, float B, float C, float D) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

