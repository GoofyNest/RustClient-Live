internal struct LogPlayerUseWeaponDataInternal : IGettable<LogPlayerUseWeaponData>, ISettable<LogPlayerUseWeaponData>, IDisposable // TypeDefIndex: 9790
{
	private IntPtr m_PlayerHandle;
	private IntPtr m_PlayerPosition;
	private IntPtr m_PlayerViewRotation;
	private int m_IsPlayerViewZoomed;
	private int m_IsMeleeAttack;
	private IntPtr m_WeaponName;

	public IntPtr PlayerHandle { get; set; }
	public Nullable<Vec3f> PlayerPosition { get; set; }
	public Nullable<Quat> PlayerViewRotation { get; set; }
	public bool IsPlayerViewZoomed { get; set; }
	public bool IsMeleeAttack { get; set; }
	public Utf8String WeaponName { get; set; }


	public IntPtr get_PlayerHandle() { }

	public void set_PlayerHandle(IntPtr value) { }

	public Nullable<Vec3f> get_PlayerPosition() { }

	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	public Nullable<Quat> get_PlayerViewRotation() { }

	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	public bool get_IsPlayerViewZoomed() { }

	public void set_IsPlayerViewZoomed(bool value) { }

	public bool get_IsMeleeAttack() { }

	public void set_IsMeleeAttack(bool value) { }

	public Utf8String get_WeaponName() { }

	public void set_WeaponName(Utf8String value) { }

	public void Set(ref LogPlayerUseWeaponData other) { }

	public void Set(ref Nullable<LogPlayerUseWeaponData> other) { }

	public void Dispose() { }

	public void Get(out LogPlayerUseWeaponData output) { }

}

