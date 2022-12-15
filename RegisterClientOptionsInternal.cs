internal struct RegisterClientOptionsInternal : ISettable<RegisterClientOptions>, IDisposable // TypeDefIndex: 9746
{
	private int m_ApiVersion;
	private IntPtr m_ClientHandle;
	private AntiCheatCommonClientType m_ClientType;
	private AntiCheatCommonClientPlatform m_ClientPlatform;
	private IntPtr m_AccountId;
	private IntPtr m_IpAddress;

	public IntPtr ClientHandle { set; }
	public AntiCheatCommonClientType ClientType { set; }
	public AntiCheatCommonClientPlatform ClientPlatform { set; }
	public Utf8String AccountId { set; }
	public Utf8String IpAddress { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_ClientType(AntiCheatCommonClientType value) { }

	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	public void set_AccountId(Utf8String value) { }

	public void set_IpAddress(Utf8String value) { }

	public void Set(ref RegisterClientOptions other) { }

	public void Set(ref Nullable<RegisterClientOptions> other) { }

	public void Dispose() { }

}

