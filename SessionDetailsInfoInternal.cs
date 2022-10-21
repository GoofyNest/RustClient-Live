internal struct SessionDetailsInfoInternal : IGettable<SessionDetailsInfo>, ISettable<SessionDetailsInfo>, IDisposable // TypeDefIndex: 8550
{
	private int m_ApiVersion; 
	private IntPtr m_SessionId; 
	private IntPtr m_HostAddress; 
	private uint m_NumOpenPublicConnections; 
	private IntPtr m_Settings; 

	public Utf8String SessionId { get; set; }
	public Utf8String HostAddress { get; set; }
	public uint NumOpenPublicConnections { get; set; }
	public Nullable<SessionDetailsSettings> Settings { get; set; }


	public Utf8String get_SessionId() { }

	public void set_SessionId(Utf8String value) { }

	public Utf8String get_HostAddress() { }

	public void set_HostAddress(Utf8String value) { }

	public uint get_NumOpenPublicConnections() { }

	public void set_NumOpenPublicConnections(uint value) { }

	public Nullable<SessionDetailsSettings> get_Settings() { }

	public void set_Settings(Nullable<SessionDetailsSettings> value) { }

	public void Set(ref SessionDetailsInfo other) { }

	public void Set(ref Nullable<SessionDetailsInfo> other) { }

	public void Dispose() { }

	public void Get(out SessionDetailsInfo output) { }

}

