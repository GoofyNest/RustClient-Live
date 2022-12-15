internal struct AddNotifyAudioBeforeRenderOptionsInternal : ISettable<AddNotifyAudioBeforeRenderOptions>, IDisposable // TypeDefIndex: 8645
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private int m_UnmixedAudio;

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public bool UnmixedAudio { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_UnmixedAudio(bool value) { }

	public void Set(ref AddNotifyAudioBeforeRenderOptions other) { }

	public void Set(ref Nullable<AddNotifyAudioBeforeRenderOptions> other) { }

	public void Dispose() { }

}

