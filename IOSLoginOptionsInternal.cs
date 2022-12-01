internal struct IOSLoginOptionsInternal : ISettable<IOSLoginOptions>, IDisposable // TypeDefIndex: 9719
{
	private int m_ApiVersion;
	private IntPtr m_Credentials;
	private AuthScopeFlags m_ScopeFlags;

	public Nullable<IOSCredentials> Credentials { set; }
	public AuthScopeFlags ScopeFlags { set; }


	public void set_Credentials(Nullable<IOSCredentials> value) { }

	public void set_ScopeFlags(AuthScopeFlags value) { }

	public void Set(ref IOSLoginOptions other) { }

	public void Set(ref Nullable<IOSLoginOptions> other) { }

	public void Dispose() { }

}

