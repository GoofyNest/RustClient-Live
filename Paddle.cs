public class Paddle : BaseMelee // TypeDefIndex: 11192
{
	public float animPaddleCooldown; 
	public GameObjectRef kayakSeat; 
	public float animationLerpSpeed; 
	private static int param_Paddling; 
	private static int param_right; 
	private static int param_forward; 
	private Vector3 smoothedAnimDirection; 

	protected override bool CanAttack { get; }
	protected override bool CanThrow { get; }


	public override AnimatorOverrideController GetHoldAnimations() { }

	private bool IsPlayerOnKayak(BasePlayer p) { }

	public override void OnInput() { }

	protected override bool get_CanAttack() { }

	protected override bool get_CanThrow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

