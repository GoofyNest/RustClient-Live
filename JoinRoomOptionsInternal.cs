internal struct JoinRoomOptionsInternal : ISettable<JoinRoomOptions>, IDisposable // TypeDefIndex: 8777
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_ClientBaseUrl;
	private IntPtr m_ParticipantToken;
	private IntPtr m_ParticipantId;
	private JoinRoomFlags m_Flags;
	private int m_ManualAudioInputEnabled;
	private int m_ManualAudioOutputEnabled;

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Utf8String ClientBaseUrl { set; }
	public Utf8String ParticipantToken { set; }
	public ProductUserId ParticipantId { set; }
	public JoinRoomFlags Flags { set; }
	public bool ManualAudioInputEnabled { set; }
	public bool ManualAudioOutputEnabled { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_ClientBaseUrl(Utf8String value) { }

	public void set_ParticipantToken(Utf8String value) { }

	public void set_ParticipantId(ProductUserId value) { }

	public void set_Flags(JoinRoomFlags value) { }

	public void set_ManualAudioInputEnabled(bool value) { }

	public void set_ManualAudioOutputEnabled(bool value) { }

	public void Set(ref JoinRoomOptions other) { }

	public void Set(ref Nullable<JoinRoomOptions> other) { }

	public void Dispose() { }

}

