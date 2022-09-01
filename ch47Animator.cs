public class ch47Animator : MonoBehaviour // TypeDefIndex: 8859
{
	public Animator animator; 
	public bool bottomDoorOpen; 
	public bool landingGearDown; 
	public bool leftDoorOpen; 
	public bool rightDoorOpen; 
	public bool rearDoorOpen; 
	public bool rearDoorExtensionOpen; 
	public Transform rearRotorBlade; 
	public Transform frontRotorBlade; 
	public float rotorBladeSpeed; 
	public float wheelTurnSpeed; 
	public float wheelTurnAngle; 
	public SkinnedMeshRenderer[] blurredRotorBlades; 
	public SkinnedMeshRenderer[] RotorBlades; 
	private bool blurredRotorBladesEnabled; 
	public float blurSpeedThreshold; 


	private void Start() { }

	public void SetDropDoorOpen(bool isOpen) { }

	private void Update() { }

	private void LateUpdate() { }

	private void EnableBlurredRotorBlades(bool enabled) { }

	public void .ctor() { }

}

