public class LiquidWeapon : BaseLiquidVessel // TypeDefIndex: 8597
{	// Fields
	[HeaderAttribute] // RVA: 0xB0080 Offset: 0xAF480 VA: 0x1800B0080
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

	// Properties
	public float PressureFraction { get; }
	public float MinimumPressureFraction { get; }
	public float CurrentRange { get; }

	// Methods

	// RVA: 0x4F3630 Offset: 0x4F2A30 VA: 0x1804F3630 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F3DD0 Offset: 0x4F31D0 VA: 0x1804F3DD0
	public float get_PressureFraction() { }

	// RVA: 0x4F3DB0 Offset: 0x4F31B0 VA: 0x1804F3DB0
	public float get_MinimumPressureFraction() { }

	// RVA: 0x4F3D30 Offset: 0x4F3130 VA: 0x1804F3D30
	public float get_CurrentRange() { }

	// RVA: 0x4F3A60 Offset: 0x4F2E60 VA: 0x1804F3A60
	private void StartCooldown(float duration) { }

	// RVA: 0x4F2F40 Offset: 0x4F2340 VA: 0x1804F2F40
	private bool OnCooldown() { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	private bool Firing() { }

	// RVA: 0x4F3B80 Offset: 0x4F2F80 VA: 0x1804F3B80
	private void Update() { }

	// RVA: 0x4F3080 Offset: 0x4F2480 VA: 0x1804F3080 Slot: 163
	public override void OnEmptyPrimaryAttackPressed() { }

	// RVA: 0x4F3200 Offset: 0x4F2600 VA: 0x1804F3200 Slot: 162
	public override void OnPrimaryAttackPressed() { }

	// RVA: 0x4F3380 Offset: 0x4F2780 VA: 0x1804F3380 Slot: 164
	public override void OnPrimaryAttackReleased() { }

	// RVA: 0x4F3AB0 Offset: 0x4F2EB0 VA: 0x1804F3AB0
	private void StopFiringAnim() { }

	// RVA: 0x4F33D0 Offset: 0x4F27D0 VA: 0x1804F33D0 Slot: 166
	public override void OnReloadHeld() { }

	// RVA: 0x4F3400 Offset: 0x4F2800 VA: 0x1804F3400 Slot: 165
	public override void OnReloadPressed() { }

	// RVA: 0x4F29F0 Offset: 0x4F1DF0 VA: 0x1804F29F0
	private bool CanPump() { }

	// RVA: 0x4F2BD0 Offset: 0x4F1FD0 VA: 0x1804F2BD0
	private void DryFire() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 167
	public override void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0x4F2B00 Offset: 0x4F1F00 VA: 0x1804F2B00 Slot: 161
	public override void DoSendFilling(bool flag) { }

	// RVA: 0x4F3720 Offset: 0x4F2B20 VA: 0x1804F3720 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 160
	public override void CLThrow() { }

	// RVA: 0x4F30F0 Offset: 0x4F24F0 VA: 0x1804F30F0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4F3810 Offset: 0x4F2C10 VA: 0x1804F3810
	private void SetEmissionEffectActive(bool flag) { }

	// RVA: 0x4F2CC0 Offset: 0x4F20C0 VA: 0x1804F2CC0
	private LiquidWeaponEffects GetEmissionEffects() { }

	// RVA: 0x4F2F70 Offset: 0x4F2370 VA: 0x1804F2F70 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x4F2E10 Offset: 0x4F2210 VA: 0x1804F2E10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4F3CB0 Offset: 0x4F30B0 VA: 0x1804F3CB0
	public void .ctor() { }

}

