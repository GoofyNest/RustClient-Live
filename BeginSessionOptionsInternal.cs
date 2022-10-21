internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable // TypeDefIndex: 9717
{
	private int m_ApiVersion; 
	private uint m_RegisterTimeoutSeconds; 
	private IntPtr m_ServerName; 
	private int m_EnableGameplayData; 
	private IntPtr m_LocalUserId; 

	public uint RegisterTimeoutSeconds { set; }
	public Utf8String ServerName { set; }
	public bool EnableGameplayData { set; }
	public ProductUserId LocalUserId { set; }


	public void set_RegisterTimeoutSeconds(uint value) { }

	public void set_ServerName(Utf8String value) { }

	public void set_EnableGameplayData(bool value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref BeginSessionOptions other) { }

	public void Set(ref Nullable<BeginSessionOptions> other) { }

	public void Dispose() { }

}

internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable // TypeDefIndex: 9814
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private AntiCheatClientMode m_Mode; 

	public ProductUserId LocalUserId { set; }
	public AntiCheatClientMode Mode { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Mode(AntiCheatClientMode value) { }

	public void Set(ref BeginSessionOptions other) { }

	public void Set(ref Nullable<BeginSessionOptions> other) { }

	public void Dispose() { }

}

