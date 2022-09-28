internal struct VerifyUserAuthOptionsInternal : ISettable<VerifyUserAuthOptions>, IDisposable // TypeDefIndex: 9667
{
	private int m_ApiVersion; 
	private IntPtr m_AuthToken; 

	public Nullable<Token> AuthToken { set; }


	public void set_AuthToken(Nullable<Token> value) { }

	public void Set(ref VerifyUserAuthOptions other) { }

	public void Set(ref Nullable<VerifyUserAuthOptions> other) { }

	public void Dispose() { }

}

