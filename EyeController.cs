public class EyeController : MonoBehaviour // TypeDefIndex: 9345
{	public const float MaxLookDot = 0,8;
	public bool debug; // 0x18
	public Transform LeftEye; // 0x20
	public Transform RightEye; // 0x28
	public Transform EyeTransform; // 0x30
	public Vector3 Fudge; // 0x38
	public Vector3 FlickerRange; // 0x44
	private Transform Focus; // 0x50
	private float FocusUpdateTime; // 0x58
	private Vector3 Flicker; // 0x5C
	private Vector3 FlickerTarget; // 0x68
	private float TimeToUpdateFlicker; // 0x74
	private float FlickerSpeed; // 0x78


	public void UpdateEyes() { }

	private void UpdateEye(Transform eye, Vector3 LookAt) { }

	private void UpdateFlicker() { }

	private void UpdateFocus(Vector3 defaultLookAtPos) { }

	public void .ctor() { }

}

