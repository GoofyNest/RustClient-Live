internal struct LogPlayerUseWeaponOptionsInternal : ISettable<LogPlayerUseWeaponOptions>, IDisposable // TypeDefIndex: 9778
{
	private int m_ApiVersion; 
	private IntPtr m_UseWeaponData; 

	public Nullable<LogPlayerUseWeaponData> UseWeaponData { set; }


	public void set_UseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	public void Set(ref LogPlayerUseWeaponOptions other) { }

	public void Set(ref Nullable<LogPlayerUseWeaponOptions> other) { }

	public void Dispose() { }

}

