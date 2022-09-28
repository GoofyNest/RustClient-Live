internal struct UpdateSendingOptionsInternal : ISettable<UpdateSendingOptions>, IDisposable // TypeDefIndex: 8685
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private RTCAudioStatus m_AudioStatus; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public RTCAudioStatus AudioStatus { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_AudioStatus(RTCAudioStatus value) { }

	public void Set(ref UpdateSendingOptions other) { }

	public void Set(ref Nullable<UpdateSendingOptions> other) { }

	public void Dispose() { }

}

