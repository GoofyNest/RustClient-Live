internal struct UserLoginInfoInternal : IGettable<UserLoginInfo>, ISettable<UserLoginInfo>, IDisposable // TypeDefIndex: 9630
{
	private int m_ApiVersion; 
	private IntPtr m_DisplayName; 

	public Utf8String DisplayName { get; set; }


	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public void Set(ref UserLoginInfo other) { }

	public void Set(ref Nullable<UserLoginInfo> other) { }

	public void Dispose() { }

	public void Get(out UserLoginInfo output) { }

}

