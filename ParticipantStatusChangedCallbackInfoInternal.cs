internal struct ParticipantStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantStatusChangedCallbackInfo>, ISettable<ParticipantStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 8795
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_ParticipantId;
	private RTCParticipantStatus m_ParticipantStatus;
	private uint m_ParticipantMetadataCount;
	private IntPtr m_ParticipantMetadata;
	private int m_ParticipantInBlocklist;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCParticipantStatus ParticipantStatus { get; set; }
	public ParticipantMetadata[] ParticipantMetadata { get; set; }
	public bool ParticipantInBlocklist { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public ProductUserId get_ParticipantId() { }

	public void set_ParticipantId(ProductUserId value) { }

	public RTCParticipantStatus get_ParticipantStatus() { }

	public void set_ParticipantStatus(RTCParticipantStatus value) { }

	public ParticipantMetadata[] get_ParticipantMetadata() { }

	public void set_ParticipantMetadata(ParticipantMetadata[] value) { }

	public bool get_ParticipantInBlocklist() { }

	public void set_ParticipantInBlocklist(bool value) { }

	public void Set(ref ParticipantStatusChangedCallbackInfo other) { }

	public void Set(ref Nullable<ParticipantStatusChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ParticipantStatusChangedCallbackInfo output) { }

}

