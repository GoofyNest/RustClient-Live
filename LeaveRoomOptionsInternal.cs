internal struct LeaveRoomOptionsInternal : ISettable<LeaveRoomOptions>, IDisposable // TypeDefIndex: 8768
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void Set(ref LeaveRoomOptions other) { }

	public void Set(ref Nullable<LeaveRoomOptions> other) { }

	public void Dispose() { }

}

