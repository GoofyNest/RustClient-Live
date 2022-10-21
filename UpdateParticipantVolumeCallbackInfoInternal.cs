internal struct UpdateParticipantVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateParticipantVolumeCallbackInfo>, ISettable<UpdateParticipantVolumeCallbackInfo>, IDisposable // TypeDefIndex: 8706
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_ParticipantId; 
	private float m_Volume; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
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

	public ProductUserId get_ParticipantId() { }

	public void set_ParticipantId(ProductUserId value) { }

	public float get_Volume() { }

	public void set_Volume(float value) { }

	public void Set(ref UpdateParticipantVolumeCallbackInfo other) { }

	public void Set(ref Nullable<UpdateParticipantVolumeCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UpdateParticipantVolumeCallbackInfo output) { }

}

