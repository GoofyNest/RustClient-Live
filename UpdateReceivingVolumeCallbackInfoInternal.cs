internal struct UpdateReceivingVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingVolumeCallbackInfo>, ISettable<UpdateReceivingVolumeCallbackInfo>, IDisposable // TypeDefIndex: 8725
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private float m_Volume;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public float get_Volume() { }

	public void set_Volume(float value) { }

	public void Set(ref UpdateReceivingVolumeCallbackInfo other) { }

	public void Set(ref Nullable<UpdateReceivingVolumeCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UpdateReceivingVolumeCallbackInfo output) { }

}

