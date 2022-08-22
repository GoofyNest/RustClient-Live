public class Paddle : BaseMelee // TypeDefIndex: 9471
{	public float animPaddleCooldown; // 0x2E0
	public GameObjectRef kayakSeat; // 0x2E8
	public float animationLerpSpeed; // 0x2F0
	private static int param_Paddling; // 0x0
	private static int param_right; // 0x4
	private static int param_forward; // 0x8
	private Vector3 smoothedAnimDirection; // 0x2F4

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

