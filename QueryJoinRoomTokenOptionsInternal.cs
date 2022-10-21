internal struct QueryJoinRoomTokenOptionsInternal : ISettable<QueryJoinRoomTokenOptions>, IDisposable // TypeDefIndex: 8742
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_RoomName; 
	private IntPtr m_TargetUserIds; 
	private uint m_TargetUserIdsCount; 
	private IntPtr m_TargetUserIpAddresses; 

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId[] TargetUserIds { set; }
	public Utf8String TargetUserIpAddresses { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_TargetUserIds(ProductUserId[] value) { }

	public void set_TargetUserIpAddresses(Utf8String value) { }

	public void Set(ref QueryJoinRoomTokenOptions other) { }

	public void Set(ref Nullable<QueryJoinRoomTokenOptions> other) { }

	public void Dispose() { }

}

