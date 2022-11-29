internal struct OnMessageToServerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToServerCallbackInfo>, ISettable<OnMessageToServerCallbackInfo>, IDisposable // TypeDefIndex: 9837
{
	private IntPtr m_ClientData; 
	private IntPtr m_MessageData; 
	private uint m_MessageDataSizeBytes; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ArraySegment<byte> MessageData { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ArraySegment<byte> get_MessageData() { }

	public void set_MessageData(ArraySegment<byte> value) { }

	public void Set(ref OnMessageToServerCallbackInfo other) { }

	public void Set(ref Nullable<OnMessageToServerCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnMessageToServerCallbackInfo output) { }

}

