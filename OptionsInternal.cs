internal struct OptionsInternal : IGettable<Options>, ISettable<Options>, IDisposable // TypeDefIndex: 9367
{
	private int m_ApiVersion; 
	private IntPtr m_Type; 
	private IntegratedPlatformManagementFlags m_Flags; 
	private IntPtr m_InitOptions; 

	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public IntPtr InitOptions { get; set; }


	public Utf8String get_Type() { }

	public void set_Type(Utf8String value) { }

	public IntegratedPlatformManagementFlags get_Flags() { }

	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	public IntPtr get_InitOptions() { }

	public void set_InitOptions(IntPtr value) { }

	public void Set(ref Options other) { }

	public void Set(ref Nullable<Options> other) { }

	public void Dispose() { }

	public void Get(out Options output) { }

}

internal struct OptionsInternal : ISettable<Options>, IDisposable // TypeDefIndex: 9867
{
	private int m_ApiVersion; 
	private IntPtr m_Reserved; 
	private IntPtr m_ProductId; 
	private IntPtr m_SandboxId; 
	private ClientCredentialsInternal m_ClientCredentials; 
	private int m_IsServer; 
	private IntPtr m_EncryptionKey; 
	private IntPtr m_OverrideCountryCode; 
	private IntPtr m_OverrideLocaleCode; 
	private IntPtr m_DeploymentId; 
	private PlatformFlags m_Flags; 
	private IntPtr m_CacheDirectory; 
	private uint m_TickBudgetInMilliseconds; 
	private IntPtr m_RTCOptions; 
	private IntPtr m_IntegratedPlatformOptionsContainerHandle; 

	public IntPtr Reserved { set; }
	public Utf8String ProductId { set; }
	public Utf8String SandboxId { set; }
	public ClientCredentials ClientCredentials { set; }
	public bool IsServer { set; }
	public Utf8String EncryptionKey { set; }
	public Utf8String OverrideCountryCode { set; }
	public Utf8String OverrideLocaleCode { set; }
	public Utf8String DeploymentId { set; }
	public PlatformFlags Flags { set; }
	public Utf8String CacheDirectory { set; }
	public uint TickBudgetInMilliseconds { set; }
	public Nullable<RTCOptions> RTCOptions { set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { set; }


	public void set_Reserved(IntPtr value) { }

	public void set_ProductId(Utf8String value) { }

	public void set_SandboxId(Utf8String value) { }

	public void set_ClientCredentials(ClientCredentials value) { }

	public void set_IsServer(bool value) { }

	public void set_EncryptionKey(Utf8String value) { }

	public void set_OverrideCountryCode(Utf8String value) { }

	public void set_OverrideLocaleCode(Utf8String value) { }

	public void set_DeploymentId(Utf8String value) { }

	public void set_Flags(PlatformFlags value) { }

	public void set_CacheDirectory(Utf8String value) { }

	public void set_TickBudgetInMilliseconds(uint value) { }

	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	public void Set(ref Options other) { }

	public void Set(ref Nullable<Options> other) { }

	public void Dispose() { }

}

