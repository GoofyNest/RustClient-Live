internal struct RegisterPeerOptionsInternal : ISettable<RegisterPeerOptions>, IDisposable // TypeDefIndex: 9853
{
	private int m_ApiVersion;
	private IntPtr m_PeerHandle;
	private AntiCheatCommonClientType m_ClientType;
	private AntiCheatCommonClientPlatform m_ClientPlatform;
	private uint m_AuthenticationTimeout;
	private IntPtr m_AccountId_DEPRECATED;
	private IntPtr m_IpAddress;
	private IntPtr m_PeerProductUserId;

	public IntPtr PeerHandle { set; }
	public AntiCheatCommonClientType ClientType { set; }
	public AntiCheatCommonClientPlatform ClientPlatform { set; }
	public uint AuthenticationTimeout { set; }
	public Utf8String AccountId_DEPRECATED { set; }
	public Utf8String IpAddress { set; }
	public ProductUserId PeerProductUserId { set; }


	public void set_PeerHandle(IntPtr value) { }

	public void set_ClientType(AntiCheatCommonClientType value) { }

	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	public void set_AuthenticationTimeout(uint value) { }

	public void set_AccountId_DEPRECATED(Utf8String value) { }

	public void set_IpAddress(Utf8String value) { }

	public void set_PeerProductUserId(ProductUserId value) { }

	public void Set(ref RegisterPeerOptions other) { }

	public void Set(ref Nullable<RegisterPeerOptions> other) { }

	public void Dispose() { }

}

