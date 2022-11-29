internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable // TypeDefIndex: 9596
{
	private int m_ApiVersion; 
	private IntPtr m_Credentials; 
	private IntPtr m_UserLoginInfo; 

	public Nullable<Credentials> Credentials { set; }
	public Nullable<UserLoginInfo> UserLoginInfo { set; }


	public void set_Credentials(Nullable<Credentials> value) { }

	public void set_UserLoginInfo(Nullable<UserLoginInfo> value) { }

	public void Set(ref LoginOptions other) { }

	public void Set(ref Nullable<LoginOptions> other) { }

	public void Dispose() { }

}

internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable // TypeDefIndex: 9673
{
	private int m_ApiVersion; 
	private IntPtr m_Credentials; 
	private AuthScopeFlags m_ScopeFlags; 

	public Nullable<Credentials> Credentials { set; }
	public AuthScopeFlags ScopeFlags { set; }


	public void set_Credentials(Nullable<Credentials> value) { }

	public void set_ScopeFlags(AuthScopeFlags value) { }

	public void Set(ref LoginOptions other) { }

	public void Set(ref Nullable<LoginOptions> other) { }

	public void Dispose() { }

}

