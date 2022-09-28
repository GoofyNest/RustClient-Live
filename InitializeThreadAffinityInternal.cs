internal struct InitializeThreadAffinityInternal : IGettable<InitializeThreadAffinity>, ISettable<InitializeThreadAffinity>, IDisposable // TypeDefIndex: 9829
{
	private int m_ApiVersion; 
	private ulong m_NetworkWork; 
	private ulong m_StorageIo; 
	private ulong m_WebSocketIo; 
	private ulong m_P2PIo; 
	private ulong m_HttpRequestIo; 
	private ulong m_RTCIo; 

	public ulong NetworkWork { get; set; }
	public ulong StorageIo { get; set; }
	public ulong WebSocketIo { get; set; }
	public ulong P2PIo { get; set; }
	public ulong HttpRequestIo { get; set; }
	public ulong RTCIo { get; set; }


	public ulong get_NetworkWork() { }

	public void set_NetworkWork(ulong value) { }

	public ulong get_StorageIo() { }

	public void set_StorageIo(ulong value) { }

	public ulong get_WebSocketIo() { }

	public void set_WebSocketIo(ulong value) { }

	public ulong get_P2PIo() { }

	public void set_P2PIo(ulong value) { }

	public ulong get_HttpRequestIo() { }

	public void set_HttpRequestIo(ulong value) { }

	public ulong get_RTCIo() { }

	public void set_RTCIo(ulong value) { }

	public void Set(ref InitializeThreadAffinity other) { }

	public void Set(ref Nullable<InitializeThreadAffinity> other) { }

	public void Dispose() { }

	public void Get(out InitializeThreadAffinity output) { }

}

