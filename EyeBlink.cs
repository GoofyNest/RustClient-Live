public class EyeBlink : MonoBehaviour // TypeDefIndex: 9344
{	// Fields
	public Transform LeftEye; // 0x18
	public Transform LeftEyelid; // 0x20
	public Vector3 LeftEyeOffset; // 0x28
	public Transform RightEye; // 0x38
	public Transform RightEyelid; // 0x40
	public Vector3 RightEyeOffset; // 0x48
	public Vector3 ClosedEyelidPosition; // 0x54
	public Vector3 ClosedEyelidRotation; // 0x60
	public Vector2 TimeWithoutBlinking; // 0x6C
	public float BlinkSpeed; // 0x74
	public Vector3 LeftEyeInitial; // 0x78
	public Vector3 RightEyeInitial; // 0x84
	private TimeUntil BlinkCountdown; // 0x90

	// Methods

	// RVA: 0x8C3F50 Offset: 0x8C3350 VA: 0x1808C3F50
	private void Start() { }

	// RVA: 0x8C3B30 Offset: 0x8C2F30 VA: 0x1808C3B30
	public void LateUpdateBlink() { }

	// RVA: 0x8C39F0 Offset: 0x8C2DF0 VA: 0x1808C39F0
	public void CloseEyes() { }

	// RVA: 0x8C3F80 Offset: 0x8C3380 VA: 0x1808C3F80
	public void .ctor() { }

}

