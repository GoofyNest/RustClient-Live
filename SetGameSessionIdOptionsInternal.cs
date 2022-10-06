internal struct SetGameSessionIdOptionsInternal : ISettable<SetGameSessionIdOptions>, IDisposable // TypeDefIndex: 9794
{
	private int m_ApiVersion; 
	private IntPtr m_GameSessionId; 

	public Utf8String GameSessionId { set; }


	public void set_GameSessionId(Utf8String value) { }

	public void Set(ref SetGameSessionIdOptions other) { }

	public void Set(ref Nullable<SetGameSessionIdOptions> other) { }

	public void Dispose() { }

}

