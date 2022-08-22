public class LiquidWeapon : BaseLiquidVessel // TypeDefIndex: 8597
{	[HeaderAttribute] // RVA: 0xB0080 Offset: 0xAF480 VA: 0x1800B0080
	public float FireRate; // 0x2F8
	public float MaxRange; // 0x2FC
	public int FireAmountML; // 0x300
	public int MaxPressure; // 0x304
	public int PressureLossPerTick; // 0x308
	public int PressureGainedPerPump; // 0x30C
	public float MinDmgRadius; // 0x310
	public float MaxDmgRadius; // 0x314
	public float SplashRadius; // 0x318
	public GameObjectRef ImpactSplashEffect; // 0x320
	public AnimationCurve PowerCurve; // 0x328
	public List<DamageTypeEntry> Damage; // 0x330
	public LiquidWeaponEffects EntityWeaponEffects; // 0x338
	public bool RequiresPumping; // 0x340
	public bool AutoPump; // 0x341
	public bool WaitForFillAnim; // 0x342
	public bool UseFalloffCurve; // 0x343
	public AnimationCurve FalloffCurve; // 0x348
	public float PumpingBlockDuration; // 0x350
	public float StartFillingBlockDuration; // 0x354
	public float StopFillingBlockDuration; // 0x358
	private float cooldownTime; // 0x35C
	private bool filling; // 0x360
	private LiquidWeaponEffects viewModelweaponEffects; // 0x368
	private int pressure; // 0x370

	public float PressureFraction { get; }
	public float MinimumPressureFraction { get; }
	public float CurrentRange { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public float get_PressureFraction() { }

	public float get_MinimumPressureFraction() { }

	public float get_CurrentRange() { }

	private void StartCooldown(float duration) { }

	private bool OnCooldown() { }

	private bool Firing() { }

	private void Update() { }

	public override void OnEmptyPrimaryAttackPressed() { }

	public override void OnPrimaryAttackPressed() { }

	public override void OnPrimaryAttackReleased() { }

	private void StopFiringAnim() { }

	public override void OnReloadHeld() { }

	public override void OnReloadPressed() { }

	private bool CanPump() { }

	private void DryFire() { }

	public override void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	public override void DoSendFilling(bool flag) { }

	public override void OnViewmodelEvent(string name) { }

	public override void CLThrow() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void SetEmissionEffectActive(bool flag) { }

	private LiquidWeaponEffects GetEmissionEffects() { }

	public override void OnDeploy() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

