public struct ParticipantStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8792
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <ParticipantId>k__BackingField;
	[CompilerGeneratedAttribute]
	private RTCParticipantStatus <ParticipantStatus>k__BackingField;
	[CompilerGeneratedAttribute]
	private ParticipantMetadata[] <ParticipantMetadata>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <ParticipantInBlocklist>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCParticipantStatus ParticipantStatus { get; set; }
	public ParticipantMetadata[] ParticipantMetadata { get; set; }
	public bool ParticipantInBlocklist { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_ParticipantId() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public RTCParticipantStatus get_ParticipantStatus() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantStatus(RTCParticipantStatus value) { }

	[CompilerGeneratedAttribute]
	public ParticipantMetadata[] get_ParticipantMetadata() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantMetadata(ParticipantMetadata[] value) { }

	[CompilerGeneratedAttribute]
	public bool get_ParticipantInBlocklist() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantInBlocklist(bool value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref ParticipantStatusChangedCallbackInfoInternal other) { }

}

