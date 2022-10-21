internal struct WindowsOptionsInternal : ISettable<WindowsOptions>, IDisposable // TypeDefIndex: 9874
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
	public Nullable<WindowsRTCOptions> RTCOptions { set; }
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

	public void set_RTCOptions(Nullable<WindowsRTCOptions> value) { }

	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	public void Set(ref WindowsOptions other) { }

	public void Set(ref Nullable<WindowsOptions> other) { }

	public void Dispose() { }

}

