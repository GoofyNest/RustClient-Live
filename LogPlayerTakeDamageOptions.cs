public struct LogPlayerTakeDamageOptions // TypeDefIndex: 9769
{
	[CompilerGeneratedAttribute] 
	private IntPtr <VictimPlayerHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Vec3f> <VictimPlayerPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Quat> <VictimPlayerViewRotation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IntPtr <AttackerPlayerHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Vec3f> <AttackerPlayerPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Quat> <AttackerPlayerViewRotation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsHitscanAttack>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <HasLineOfSight>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsCriticalHit>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <HitBoneId_DEPRECATED>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <DamageTaken>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <HealthRemaining>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonPlayerTakeDamageSource <DamageSource>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonPlayerTakeDamageType <DamageType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonPlayerTakeDamageResult <DamageResult>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<LogPlayerUseWeaponData> <PlayerUseWeaponData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <TimeSincePlayerUseWeaponMs>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Vec3f> <DamagePosition>k__BackingField; 

	public IntPtr VictimPlayerHandle { get; set; }
	public Nullable<Vec3f> VictimPlayerPosition { get; set; }
	public Nullable<Quat> VictimPlayerViewRotation { get; set; }
	public IntPtr AttackerPlayerHandle { get; set; }
	public Nullable<Vec3f> AttackerPlayerPosition { get; set; }
	public Nullable<Quat> AttackerPlayerViewRotation { get; set; }
	public bool IsHitscanAttack { get; set; }
	public bool HasLineOfSight { get; set; }
	public bool IsCriticalHit { get; set; }
	public uint HitBoneId_DEPRECATED { get; set; }
	public float DamageTaken { get; set; }
	public float HealthRemaining { get; set; }
	public AntiCheatCommonPlayerTakeDamageSource DamageSource { get; set; }
	public AntiCheatCommonPlayerTakeDamageType DamageType { get; set; }
	public AntiCheatCommonPlayerTakeDamageResult DamageResult { get; set; }
	public Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData { get; set; }
	public uint TimeSincePlayerUseWeaponMs { get; set; }
	public Nullable<Vec3f> DamagePosition { get; set; }


	[CompilerGeneratedAttribute] 
	public IntPtr get_VictimPlayerHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_VictimPlayerHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Vec3f> get_VictimPlayerPosition() { }

	[CompilerGeneratedAttribute] 
	public void set_VictimPlayerPosition(Nullable<Vec3f> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Quat> get_VictimPlayerViewRotation() { }

	[CompilerGeneratedAttribute] 
	public void set_VictimPlayerViewRotation(Nullable<Quat> value) { }

	[CompilerGeneratedAttribute] 
	public IntPtr get_AttackerPlayerHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_AttackerPlayerHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Vec3f> get_AttackerPlayerPosition() { }

	[CompilerGeneratedAttribute] 
	public void set_AttackerPlayerPosition(Nullable<Vec3f> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Quat> get_AttackerPlayerViewRotation() { }

	[CompilerGeneratedAttribute] 
	public void set_AttackerPlayerViewRotation(Nullable<Quat> value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsHitscanAttack() { }

	[CompilerGeneratedAttribute] 
	public void set_IsHitscanAttack(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_HasLineOfSight() { }

	[CompilerGeneratedAttribute] 
	public void set_HasLineOfSight(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsCriticalHit() { }

	[CompilerGeneratedAttribute] 
	public void set_IsCriticalHit(bool value) { }

	[CompilerGeneratedAttribute] 
	public uint get_HitBoneId_DEPRECATED() { }

	[CompilerGeneratedAttribute] 
	public void set_HitBoneId_DEPRECATED(uint value) { }

	[CompilerGeneratedAttribute] 
	public float get_DamageTaken() { }

	[CompilerGeneratedAttribute] 
	public void set_DamageTaken(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_HealthRemaining() { }

	[CompilerGeneratedAttribute] 
	public void set_HealthRemaining(float value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonPlayerTakeDamageSource get_DamageSource() { }

	[CompilerGeneratedAttribute] 
	public void set_DamageSource(AntiCheatCommonPlayerTakeDamageSource value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonPlayerTakeDamageType get_DamageType() { }

	[CompilerGeneratedAttribute] 
	public void set_DamageType(AntiCheatCommonPlayerTakeDamageType value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonPlayerTakeDamageResult get_DamageResult() { }

	[CompilerGeneratedAttribute] 
	public void set_DamageResult(AntiCheatCommonPlayerTakeDamageResult value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<LogPlayerUseWeaponData> get_PlayerUseWeaponData() { }

	[CompilerGeneratedAttribute] 
	public void set_PlayerUseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	[CompilerGeneratedAttribute] 
	public uint get_TimeSincePlayerUseWeaponMs() { }

	[CompilerGeneratedAttribute] 
	public void set_TimeSincePlayerUseWeaponMs(uint value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Vec3f> get_DamagePosition() { }

	[CompilerGeneratedAttribute] 
	public void set_DamagePosition(Nullable<Vec3f> value) { }

}

