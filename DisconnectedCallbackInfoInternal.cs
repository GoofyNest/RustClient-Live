internal struct DisconnectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DisconnectedCallbackInfo>, ISettable<DisconnectedCallbackInfo>, IDisposable // TypeDefIndex: 8758
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public void Set(ref DisconnectedCallbackInfo other) { }

	public void Set(ref Nullable<DisconnectedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out DisconnectedCallbackInfo output) { }

}

