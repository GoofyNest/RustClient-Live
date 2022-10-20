public class FootstepEffects : BaseFootstepEffect // TypeDefIndex: 11067
{
	public Transform leftFoot; 
	public Transform rightFoot; 
	public string footstepEffectName; 
	public string jumpStartEffectName; 
	public string jumpLandEffectName; 
	private bool lastWasLeft; 
	private bool lastWasStopped; 
	private BasePlayer player; 
	private bool isOnGround; 
	private Animator animator; 


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

