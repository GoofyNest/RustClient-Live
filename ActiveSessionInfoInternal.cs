internal struct ActiveSessionInfoInternal : IGettable<ActiveSessionInfo>, ISettable<ActiveSessionInfo>, IDisposable // TypeDefIndex: 8457
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_LocalUserId; 
	private OnlineSessionState m_State; 
	private IntPtr m_SessionDetails; 

	public Utf8String SessionName { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public OnlineSessionState State { get; set; }
	public Nullable<SessionDetailsInfo> SessionDetails { get; set; }


	public Utf8String get_SessionName() { }

	public void set_SessionName(Utf8String value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public OnlineSessionState get_State() { }

	public void set_State(OnlineSessionState value) { }

	public Nullable<SessionDetailsInfo> get_SessionDetails() { }

	public void set_SessionDetails(Nullable<SessionDetailsInfo> value) { }

	public void Set(ref ActiveSessionInfo other) { }

	public void Set(ref Nullable<ActiveSessionInfo> other) { }

	public void Dispose() { }

	public void Get(out ActiveSessionInfo output) { }

}

