internal struct UpdateReceivingOptionsInternal : ISettable<UpdateReceivingOptions>, IDisposable // TypeDefIndex: 8677
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_ParticipantId; 
	private int m_AudioEnabled; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public bool AudioEnabled { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_ParticipantId(ProductUserId value) { }

	public void set_AudioEnabled(bool value) { }

	public void Set(ref UpdateReceivingOptions other) { }

	public void Set(ref Nullable<UpdateReceivingOptions> other) { }

	public void Dispose() { }

}

