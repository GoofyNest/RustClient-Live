public class EyeController : MonoBehaviour // TypeDefIndex: 9345
{	// Fields
	public const float MaxLookDot = 0,8;
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

	// Methods

	// RVA: 0x8C4320 Offset: 0x8C3720 VA: 0x1808C4320
	public void UpdateEyes() { }

	// RVA: 0x8C4050 Offset: 0x8C3450 VA: 0x1808C4050
	private void UpdateEye(Transform eye, Vector3 LookAt) { }

	// RVA: 0x8C4680 Offset: 0x8C3A80 VA: 0x1808C4680
	private void UpdateFlicker() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void UpdateFocus(Vector3 defaultLookAtPos) { }

	// RVA: 0x8C48E0 Offset: 0x8C3CE0 VA: 0x1808C48E0
	public void .ctor() { }

}

