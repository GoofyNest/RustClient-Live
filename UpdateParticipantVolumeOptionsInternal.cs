internal struct UpdateParticipantVolumeOptionsInternal : ISettable<UpdateParticipantVolumeOptions>, IDisposable // TypeDefIndex: 8717
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_ParticipantId; 
	private float m_Volume; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public float Volume { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_ParticipantId(ProductUserId value) { }

	public void set_Volume(float value) { }

	public void Set(ref UpdateParticipantVolumeOptions other) { }

	public void Set(ref Nullable<UpdateParticipantVolumeOptions> other) { }

	public void Dispose() { }

}

