internal struct SessionModificationSetHostAddressOptionsInternal : ISettable<SessionModificationSetHostAddressOptions>, IDisposable // TypeDefIndex: 8578
{
	private int m_ApiVersion;
	private IntPtr m_HostAddress;

	public Utf8String HostAddress { set; }


	public void set_HostAddress(Utf8String value) { }

	public void Set(ref SessionModificationSetHostAddressOptions other) { }

	public void Set(ref Nullable<SessionModificationSetHostAddressOptions> other) { }

	public void Dispose() { }

}

