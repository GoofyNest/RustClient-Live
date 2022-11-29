internal struct UpdateReceivingVolumeOptionsInternal : ISettable<UpdateReceivingVolumeOptions>, IDisposable // TypeDefIndex: 8725
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private float m_Volume; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public float Volume { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_Volume(float value) { }

	public void Set(ref UpdateReceivingVolumeOptions other) { }

	public void Set(ref Nullable<UpdateReceivingVolumeOptions> other) { }

	public void Dispose() { }

}

