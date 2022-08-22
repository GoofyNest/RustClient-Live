public class EyeBlink : MonoBehaviour // TypeDefIndex: 9344
{	public Transform LeftEye; // 0x18
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


	private void Start() { }

	public void LateUpdateBlink() { }

	public void CloseEyes() { }

	public void .ctor() { }

}

