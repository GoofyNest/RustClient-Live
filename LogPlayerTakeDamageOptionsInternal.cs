internal struct LogPlayerTakeDamageOptionsInternal : ISettable<LogPlayerTakeDamageOptions>, IDisposable // TypeDefIndex: 9771
{
	private int m_ApiVersion; 
	private IntPtr m_VictimPlayerHandle; 
	private IntPtr m_VictimPlayerPosition; 
	private IntPtr m_VictimPlayerViewRotation; 
	private IntPtr m_AttackerPlayerHandle; 
	private IntPtr m_AttackerPlayerPosition; 
	private IntPtr m_AttackerPlayerViewRotation; 
	private int m_IsHitscanAttack; 
	private int m_HasLineOfSight; 
	private int m_IsCriticalHit; 
	private uint m_HitBoneId_DEPRECATED; 
	private float m_DamageTaken; 
	private float m_HealthRemaining; 
	private AntiCheatCommonPlayerTakeDamageSource m_DamageSource; 
	private AntiCheatCommonPlayerTakeDamageType m_DamageType; 
	private AntiCheatCommonPlayerTakeDamageResult m_DamageResult; 
	private IntPtr m_PlayerUseWeaponData; 
	private uint m_TimeSincePlayerUseWeaponMs; 
	private IntPtr m_DamagePosition; 

	public IntPtr VictimPlayerHandle { set; }
	public Nullable<Vec3f> VictimPlayerPosition { set; }
	public Nullable<Quat> VictimPlayerViewRotation { set; }
	public IntPtr AttackerPlayerHandle { set; }
	public Nullable<Vec3f> AttackerPlayerPosition { set; }
	public Nullable<Quat> AttackerPlayerViewRotation { set; }
	public bool IsHitscanAttack { set; }
	public bool HasLineOfSight { set; }
	public bool IsCriticalHit { set; }
	public uint HitBoneId_DEPRECATED { set; }
	public float DamageTaken { set; }
	public float HealthRemaining { set; }
	public AntiCheatCommonPlayerTakeDamageSource DamageSource { set; }
	public AntiCheatCommonPlayerTakeDamageType DamageType { set; }
	public AntiCheatCommonPlayerTakeDamageResult DamageResult { set; }
	public Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData { set; }
	public uint TimeSincePlayerUseWeaponMs { set; }
	public Nullable<Vec3f> DamagePosition { set; }


	public void set_VictimPlayerHandle(IntPtr value) { }

	public void set_VictimPlayerPosition(Nullable<Vec3f> value) { }

	public void set_VictimPlayerViewRotation(Nullable<Quat> value) { }

	public void set_AttackerPlayerHandle(IntPtr value) { }

	public void set_AttackerPlayerPosition(Nullable<Vec3f> value) { }

	public void set_AttackerPlayerViewRotation(Nullable<Quat> value) { }

	public void set_IsHitscanAttack(bool value) { }

	public void set_HasLineOfSight(bool value) { }

	public void set_IsCriticalHit(bool value) { }

	public void set_HitBoneId_DEPRECATED(uint value) { }

	public void set_DamageTaken(float value) { }

	public void set_HealthRemaining(float value) { }

	public void set_DamageSource(AntiCheatCommonPlayerTakeDamageSource value) { }

	public void set_DamageType(AntiCheatCommonPlayerTakeDamageType value) { }

	public void set_DamageResult(AntiCheatCommonPlayerTakeDamageResult value) { }

	public void set_PlayerUseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	public void set_TimeSincePlayerUseWeaponMs(uint value) { }

	public void set_DamagePosition(Nullable<Vec3f> value) { }

	public void Set(ref LogPlayerTakeDamageOptions other) { }

	public void Set(ref Nullable<LogPlayerTakeDamageOptions> other) { }

	public void Dispose() { }

}

