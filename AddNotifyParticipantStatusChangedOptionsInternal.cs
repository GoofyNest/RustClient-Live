internal struct AddNotifyParticipantStatusChangedOptionsInternal : ISettable<AddNotifyParticipantStatusChangedOptions>, IDisposable // TypeDefIndex: 8752
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void Set(ref AddNotifyParticipantStatusChangedOptions other) { }

	public void Set(ref Nullable<AddNotifyParticipantStatusChangedOptions> other) { }

	public void Dispose() { }

}

