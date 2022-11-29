internal struct BlockParticipantOptionsInternal : ISettable<BlockParticipantOptions>, IDisposable // TypeDefIndex: 8766
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_ParticipantId; 
	private int m_Blocked; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public bool Blocked { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_ParticipantId(ProductUserId value) { }

	public void set_Blocked(bool value) { }

	public void Set(ref BlockParticipantOptions other) { }

	public void Set(ref Nullable<BlockParticipantOptions> other) { }

	public void Dispose() { }

}

