public struct ParticipantUpdatedCallbackInfo : ICallbackInfo // TypeDefIndex: 8700
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
	private bool <Speaking>k__BackingField;
	[CompilerGeneratedAttribute]
	private RTCAudioStatus <AudioStatus>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Speaking { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }


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
	public bool get_Speaking() { }

	[CompilerGeneratedAttribute]
	public void set_Speaking(bool value) { }

	[CompilerGeneratedAttribute]
	public RTCAudioStatus get_AudioStatus() { }

	[CompilerGeneratedAttribute]
	public void set_AudioStatus(RTCAudioStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref ParticipantUpdatedCallbackInfoInternal other) { }

}

