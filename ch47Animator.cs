public class ch47Animator : MonoBehaviour // TypeDefIndex: 8856
{	// Fields
	public Animator animator; // 0x18
	public bool bottomDoorOpen; // 0x20
	public bool landingGearDown; // 0x21
	public bool leftDoorOpen; // 0x22
	public bool rightDoorOpen; // 0x23
	public bool rearDoorOpen; // 0x24
	public bool rearDoorExtensionOpen; // 0x25
	public Transform rearRotorBlade; // 0x28
	public Transform frontRotorBlade; // 0x30
	public float rotorBladeSpeed; // 0x38
	public float wheelTurnSpeed; // 0x3C
	public float wheelTurnAngle; // 0x40
	public SkinnedMeshRenderer[] blurredRotorBlades; // 0x48
	public SkinnedMeshRenderer[] RotorBlades; // 0x50
	private bool blurredRotorBladesEnabled; // 0x58
	public float blurSpeedThreshold; // 0x5C

	// Methods

	// RVA: 0x1A97F90 Offset: 0x1A97390 VA: 0x181A97F90
	private void Start() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void SetDropDoorOpen(bool isOpen) { }

	// RVA: 0x1A97FF0 Offset: 0x1A973F0 VA: 0x181A97FF0
	private void Update() { }

	// RVA: 0x1A97E20 Offset: 0x1A97220 VA: 0x181A97E20
	private void LateUpdate() { }

	// RVA: 0x1A97D40 Offset: 0x1A97140 VA: 0x181A97D40
	private void EnableBlurredRotorBlades(bool enabled) { }

	// RVA: 0x1A98160 Offset: 0x1A97560 VA: 0x181A98160
	public void .ctor() { }

}

