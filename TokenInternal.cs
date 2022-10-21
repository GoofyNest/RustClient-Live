internal struct TokenInternal : IGettable<Token>, ISettable<Token>, IDisposable // TypeDefIndex: 9694
{
	private int m_ApiVersion; 
	private IntPtr m_App; 
	private IntPtr m_ClientId; 
	private IntPtr m_AccountId; 
	private IntPtr m_AccessToken; 
	private double m_ExpiresIn; 
	private IntPtr m_ExpiresAt; 
	private AuthTokenType m_AuthType; 
	private IntPtr m_RefreshToken; 
	private double m_RefreshExpiresIn; 
	private IntPtr m_RefreshExpiresAt; 

	public Utf8String App { get; set; }
	public Utf8String ClientId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public Utf8String AccessToken { get; set; }
	public double ExpiresIn { get; set; }
	public Utf8String ExpiresAt { get; set; }
	public AuthTokenType AuthType { get; set; }
	public Utf8String RefreshToken { get; set; }
	public double RefreshExpiresIn { get; set; }
	public Utf8String RefreshExpiresAt { get; set; }


	public Utf8String get_App() { }

	public void set_App(Utf8String value) { }

	public Utf8String get_ClientId() { }

	public void set_ClientId(Utf8String value) { }

	public EpicAccountId get_AccountId() { }

	public void set_AccountId(EpicAccountId value) { }

	public Utf8String get_AccessToken() { }

	public void set_AccessToken(Utf8String value) { }

	public double get_ExpiresIn() { }

	public void set_ExpiresIn(double value) { }

	public Utf8String get_ExpiresAt() { }

	public void set_ExpiresAt(Utf8String value) { }

	public AuthTokenType get_AuthType() { }

	public void set_AuthType(AuthTokenType value) { }

	public Utf8String get_RefreshToken() { }

	public void set_RefreshToken(Utf8String value) { }

	public double get_RefreshExpiresIn() { }

	public void set_RefreshExpiresIn(double value) { }

	public Utf8String get_RefreshExpiresAt() { }

	public void set_RefreshExpiresAt(Utf8String value) { }

	public void Set(ref Token other) { }

	public void Set(ref Nullable<Token> other) { }

	public void Dispose() { }

	public void Get(out Token output) { }

}

