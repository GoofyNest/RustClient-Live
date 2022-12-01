internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantUpdatedCallbackInfo>, ISettable<ParticipantUpdatedCallbackInfo>, IDisposable // TypeDefIndex: 8701
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_ParticipantId;
	private int m_Speaking;
	private RTCAudioStatus m_AudioStatus;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Speaking { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public ProductUserId get_ParticipantId() { }

	public void set_ParticipantId(ProductUserId value) { }

	public bool get_Speaking() { }

	public void set_Speaking(bool value) { }

	public RTCAudioStatus get_AudioStatus() { }

	public void set_AudioStatus(RTCAudioStatus value) { }

	public void Set(ref ParticipantUpdatedCallbackInfo other) { }

	public void Set(ref Nullable<ParticipantUpdatedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ParticipantUpdatedCallbackInfo output) { }

}

