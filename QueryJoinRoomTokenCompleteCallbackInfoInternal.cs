internal struct QueryJoinRoomTokenCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryJoinRoomTokenCompleteCallbackInfo>, ISettable<QueryJoinRoomTokenCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8749
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_RoomName; 
	private IntPtr m_ClientBaseUrl; 
	private uint m_QueryId; 
	private uint m_TokenCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public uint QueryId { get; set; }
	public uint TokenCount { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public Utf8String get_ClientBaseUrl() { }

	public void set_ClientBaseUrl(Utf8String value) { }

	public uint get_QueryId() { }

	public void set_QueryId(uint value) { }

	public uint get_TokenCount() { }

	public void set_TokenCount(uint value) { }

	public void Set(ref QueryJoinRoomTokenCompleteCallbackInfo other) { }

	public void Set(ref Nullable<QueryJoinRoomTokenCompleteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryJoinRoomTokenCompleteCallbackInfo output) { }

}

