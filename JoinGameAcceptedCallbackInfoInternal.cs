internal struct JoinGameAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinGameAcceptedCallbackInfo>, ISettable<JoinGameAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 8824
{
	private IntPtr m_ClientData; 
	private IntPtr m_JoinInfo; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private ulong m_UiEventId; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String JoinInfo { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public ulong UiEventId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_JoinInfo() { }

	public void set_JoinInfo(Utf8String value) { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_TargetUserId() { }

	public void set_TargetUserId(EpicAccountId value) { }

	public ulong get_UiEventId() { }

	public void set_UiEventId(ulong value) { }

	public void Set(ref JoinGameAcceptedCallbackInfo other) { }

	public void Set(ref Nullable<JoinGameAcceptedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out JoinGameAcceptedCallbackInfo output) { }

}

