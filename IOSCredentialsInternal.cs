internal struct IOSCredentialsInternal : IGettable<IOSCredentials>, ISettable<IOSCredentials>, IDisposable // TypeDefIndex: 9717
{
	private int m_ApiVersion;
	private IntPtr m_Id;
	private IntPtr m_Token;
	private LoginCredentialType m_Type;
	private IntPtr m_SystemAuthCredentialsOptions;
	private ExternalCredentialType m_ExternalType;

	public Utf8String Id { get; set; }
	public Utf8String Token { get; set; }
	public LoginCredentialType Type { get; set; }
	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> SystemAuthCredentialsOptions { get; set; }
	public ExternalCredentialType ExternalType { get; set; }


	public Utf8String get_Id() { }

	public void set_Id(Utf8String value) { }

	public Utf8String get_Token() { }

	public void set_Token(Utf8String value) { }

	public LoginCredentialType get_Type() { }

	public void set_Type(LoginCredentialType value) { }

	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> get_SystemAuthCredentialsOptions() { }

	public void set_SystemAuthCredentialsOptions(Nullable<IOSCredentialsSystemAuthCredentialsOptions> value) { }

	public ExternalCredentialType get_ExternalType() { }

	public void set_ExternalType(ExternalCredentialType value) { }

	public void Set(ref IOSCredentials other) { }

	public void Set(ref Nullable<IOSCredentials> other) { }

	public void Dispose() { }

	public void Get(out IOSCredentials output) { }

}

