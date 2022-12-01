internal struct SessionSearchSetSessionIdOptionsInternal : ISettable<SessionSearchSetSessionIdOptions>, IDisposable // TypeDefIndex: 8603
{
	private int m_ApiVersion;
	private IntPtr m_SessionId;

	public Utf8String SessionId { set; }


	public void set_SessionId(Utf8String value) { }

	public void Set(ref SessionSearchSetSessionIdOptions other) { }

	public void Set(ref Nullable<SessionSearchSetSessionIdOptions> other) { }

	public void Dispose() { }

}

