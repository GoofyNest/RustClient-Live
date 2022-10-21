internal struct OnMessageToClientCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToClientCallbackInfo>, ISettable<OnMessageToClientCallbackInfo>, IDisposable // TypeDefIndex: 9785
{
	private IntPtr m_ClientData; 
	private IntPtr m_ClientHandle; 
	private IntPtr m_MessageData; 
	private uint m_MessageDataSizeBytes; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> MessageData { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public IntPtr get_ClientHandle() { }

	public void set_ClientHandle(IntPtr value) { }

	public ArraySegment<byte> get_MessageData() { }

	public void set_MessageData(ArraySegment<byte> value) { }

	public void Set(ref OnMessageToClientCallbackInfo other) { }

	public void Set(ref Nullable<OnMessageToClientCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnMessageToClientCallbackInfo output) { }

}

