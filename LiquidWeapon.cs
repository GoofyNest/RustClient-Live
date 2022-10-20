public class LiquidWeapon : BaseLiquidVessel // TypeDefIndex: 10305
{
	[HeaderAttribute] 
	public float FireRate; 
	public float MaxRange; 
	public int FireAmountML; 
	public int MaxPressure; 
	public int PressureLossPerTick; 
	public int PressureGainedPerPump; 
	public float MinDmgRadius; 
	public float MaxDmgRadius; 
	public float SplashRadius; 
	public GameObjectRef ImpactSplashEffect; 
	public AnimationCurve PowerCurve; 
	public List<DamageTypeEntry> Damage; 
	public LiquidWeaponEffects EntityWeaponEffects; 
	public bool RequiresPumping; 
	public bool AutoPump; 
	public bool WaitForFillAnim; 
	public bool UseFalloffCurve; 
	public AnimationCurve FalloffCurve; 
	public float PumpingBlockDuration; 
	public float StartFillingBlockDuration; 
	public float StopFillingBlockDuration; 
	private float cooldownTime; 
	private bool filling; 
	private LiquidWeaponEffects viewModelweaponEffects; 
	private int pressure; 

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

