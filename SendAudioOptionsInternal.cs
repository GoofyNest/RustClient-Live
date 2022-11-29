internal struct SendAudioOptionsInternal : ISettable<SendAudioOptions>, IDisposable // TypeDefIndex: 8707
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_Buffer; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Nullable<AudioBuffer> Buffer { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_Buffer(Nullable<AudioBuffer> value) { }

	public void Set(ref SendAudioOptions other) { }

	public void Set(ref Nullable<SendAudioOptions> other) { }

	public void Dispose() { }

}

