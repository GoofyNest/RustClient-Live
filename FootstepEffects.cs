public class FootstepEffects : BaseFootstepEffect // TypeDefIndex: 9348
{	// Fields
	public Transform leftFoot; // 0x30
	public Transform rightFoot; // 0x38
	public string footstepEffectName; // 0x40
	public string jumpStartEffectName; // 0x48
	public string jumpLandEffectName; // 0x50
	private bool lastWasLeft; // 0x58
	private bool lastWasStopped; // 0x59
	private BasePlayer player; // 0x60
	private bool isOnGround; // 0x68
	private Animator animator; // 0x70

	// Methods

	// RVA: 0x6EDFA0 Offset: 0x6ED3A0 VA: 0x1806EDFA0
	private void OnEnable() { }

	// RVA: 0x6EE550 Offset: 0x6ED950 VA: 0x1806EE550
	private void Update() { }

	// RVA: 0x6EDD10 Offset: 0x6ED110 VA: 0x1806EDD10
	private void LeftFoot(float fVolume) { }

	// RVA: 0x6EE0F0 Offset: 0x6ED4F0 VA: 0x1806EE0F0
	private void RightFoot(float fVolume) { }

	// RVA: 0x6ED860 Offset: 0x6ECC60 VA: 0x1806ED860
	private void Footstep(Vector3 vFootPos, bool left, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0x6ED680 Offset: 0x6ECA80 VA: 0x1806ED680
	private void DoLandingEffect() { }

	// RVA: 0x6ED4A0 Offset: 0x6EC8A0 VA: 0x1806ED4A0
	private void DoJumpStartEffect() { }

	// RVA: 0x6EE370 Offset: 0x6ED770 VA: 0x1806EE370
	private void SetupPlayerFootstep(BasePlayer player, GameObject effect, bool left) { }

	// RVA: 0x6EE6F0 Offset: 0x6EDAF0 VA: 0x1806EE6F0
	public void .ctor() { }

}

