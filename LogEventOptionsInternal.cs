internal struct LogEventOptionsInternal : ISettable<LogEventOptions>, IDisposable // TypeDefIndex: 9720
{
	private int m_ApiVersion; 
	private IntPtr m_ClientHandle; 
	private uint m_EventId; 
	private uint m_ParamsCount; 
	private IntPtr m_Params; 

	public IntPtr ClientHandle { set; }
	public uint EventId { set; }
	public LogEventParamPair[] Params { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_EventId(uint value) { }

	public void set_Params(LogEventParamPair[] value) { }

	public void Set(ref LogEventOptions other) { }

	public void Set(ref Nullable<LogEventOptions> other) { }

	public void Dispose() { }

}

