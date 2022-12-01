public struct JoinRoomOptions // TypeDefIndex: 8774
{
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <ClientBaseUrl>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <ParticipantToken>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <ParticipantId>k__BackingField;
	[CompilerGeneratedAttribute]
	private JoinRoomFlags <Flags>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <ManualAudioInputEnabled>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <ManualAudioOutputEnabled>k__BackingField;

	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public Utf8String ParticipantToken { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public JoinRoomFlags Flags { get; set; }
	public bool ManualAudioInputEnabled { get; set; }
	public bool ManualAudioOutputEnabled { get; set; }


	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_ClientBaseUrl() { }

	[CompilerGeneratedAttribute]
	public void set_ClientBaseUrl(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_ParticipantToken() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantToken(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_ParticipantId() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public JoinRoomFlags get_Flags() { }

	[CompilerGeneratedAttribute]
	public void set_Flags(JoinRoomFlags value) { }

	[CompilerGeneratedAttribute]
	public bool get_ManualAudioInputEnabled() { }

	[CompilerGeneratedAttribute]
	public void set_ManualAudioInputEnabled(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_ManualAudioOutputEnabled() { }

	[CompilerGeneratedAttribute]
	public void set_ManualAudioOutputEnabled(bool value) { }

}

