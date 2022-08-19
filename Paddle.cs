public class Paddle : BaseMelee // TypeDefIndex: 9471
{	// Fields
	public float animPaddleCooldown; // 0x2E0
	public GameObjectRef kayakSeat; // 0x2E8
	public float animationLerpSpeed; // 0x2F0
	private static int param_Paddling; // 0x0
	private static int param_right; // 0x4
	private static int param_forward; // 0x8
	private Vector3 smoothedAnimDirection; // 0x2F4

	// Properties
	protected override bool CanAttack { get; }
	protected override bool CanThrow { get; }

	// Methods

	// RVA: 0xA4DD20 Offset: 0xA4D120 VA: 0x180A4DD20 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0xA4DD60 Offset: 0xA4D160 VA: 0x180A4DD60
	private bool IsPlayerOnKayak(BasePlayer p) { }

	// RVA: 0xA4DE20 Offset: 0xA4D220 VA: 0x180A4DE20 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA4E310 Offset: 0xA4D710 VA: 0x180A4E310 Slot: 161
	protected override bool get_CanAttack() { }

	// RVA: 0xA4E310 Offset: 0xA4D710 VA: 0x180A4E310 Slot: 162
	protected override bool get_CanThrow() { }

	// RVA: 0xA4E2F0 Offset: 0xA4D6F0 VA: 0x180A4E2F0
	public void .ctor() { }

	// RVA: 0xA4E270 Offset: 0xA4D670 VA: 0x180A4E270
	private static void .cctor() { }

}

