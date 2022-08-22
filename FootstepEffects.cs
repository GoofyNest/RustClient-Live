public class FootstepEffects : BaseFootstepEffect // TypeDefIndex: 9348
{	public Transform leftFoot; // 0x30
	public Transform rightFoot; // 0x38
	public string footstepEffectName; // 0x40
	public string jumpStartEffectName; // 0x48
	public string jumpLandEffectName; // 0x50
	private bool lastWasLeft; // 0x58
	private bool lastWasStopped; // 0x59
	private BasePlayer player; // 0x60
	private bool isOnGround; // 0x68
	private Animator animator; // 0x70


	private void OnEnable() { }

	private void Update() { }

	private void LeftFoot(float fVolume) { }

	private void RightFoot(float fVolume) { }

	private void Footstep(Vector3 vFootPos, bool left, bool bIgnoreDistanceCheck = False) { }

	private void DoLandingEffect() { }

	private void DoJumpStartEffect() { }

	private void SetupPlayerFootstep(BasePlayer player, GameObject effect, bool left) { }

	public void .ctor() { }

}

