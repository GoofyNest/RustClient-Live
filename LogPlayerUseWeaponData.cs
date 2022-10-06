public struct LogPlayerUseWeaponData // TypeDefIndex: 9775
{
	[CompilerGeneratedAttribute] 
	private IntPtr <PlayerHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Vec3f> <PlayerPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Quat> <PlayerViewRotation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsPlayerViewZoomed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsMeleeAttack>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <WeaponName>k__BackingField; 

	public IntPtr PlayerHandle { get; set; }
	public Nullable<Vec3f> PlayerPosition { get; set; }
	public Nullable<Quat> PlayerViewRotation { get; set; }
	public bool IsPlayerViewZoomed { get; set; }
	public bool IsMeleeAttack { get; set; }
	public Utf8String WeaponName { get; set; }


	[CompilerGeneratedAttribute] 
	public IntPtr get_PlayerHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_PlayerHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Vec3f> get_PlayerPosition() { }

	[CompilerGeneratedAttribute] 
	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Quat> get_PlayerViewRotation() { }

	[CompilerGeneratedAttribute] 
	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsPlayerViewZoomed() { }

	[CompilerGeneratedAttribute] 
	public void set_IsPlayerViewZoomed(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsMeleeAttack() { }

	[CompilerGeneratedAttribute] 
	public void set_IsMeleeAttack(bool value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_WeaponName() { }

	[CompilerGeneratedAttribute] 
	public void set_WeaponName(Utf8String value) { }

	internal void Set(ref LogPlayerUseWeaponDataInternal other) { }

}

