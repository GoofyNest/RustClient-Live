internal struct BeginPlayerSessionOptionsInternal : ISettable<BeginPlayerSessionOptions>, IDisposable // TypeDefIndex: 9046
{
	private int m_ApiVersion;
	private BeginPlayerSessionOptionsAccountIdInternal m_AccountId;
	private IntPtr m_DisplayName;
	private UserControllerType m_ControllerType;
	private IntPtr m_ServerIp;
	private IntPtr m_GameSessionId;

	public BeginPlayerSessionOptionsAccountId AccountId { set; }
	public Utf8String DisplayName { set; }
	public UserControllerType ControllerType { set; }
	public Utf8String ServerIp { set; }
	public Utf8String GameSessionId { set; }


	public void set_AccountId(BeginPlayerSessionOptionsAccountId value) { }

	public void set_DisplayName(Utf8String value) { }

	public void set_ControllerType(UserControllerType value) { }

	public void set_ServerIp(Utf8String value) { }

	public void set_GameSessionId(Utf8String value) { }

	public void Set(ref BeginPlayerSessionOptions other) { }

	public void Set(ref Nullable<BeginPlayerSessionOptions> other) { }

	public void Dispose() { }

}

