internal struct SetParticipantHardMuteOptionsInternal : ISettable<SetParticipantHardMuteOptions>, IDisposable // TypeDefIndex: 8746
{
	private int m_ApiVersion; 
	private IntPtr m_RoomName; 
	private IntPtr m_TargetUserId; 
	private int m_Mute; 

	public Utf8String RoomName { set; }
	public ProductUserId TargetUserId { set; }
	public bool Mute { set; }


	public void set_RoomName(Utf8String value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void set_Mute(bool value) { }

	public void Set(ref SetParticipantHardMuteOptions other) { }

	public void Set(ref Nullable<SetParticipantHardMuteOptions> other) { }

	public void Dispose() { }

}

