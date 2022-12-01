internal struct GetDesktopCrossplayStatusInfoInternal : IGettable<GetDesktopCrossplayStatusInfo>, ISettable<GetDesktopCrossplayStatusInfo>, IDisposable // TypeDefIndex: 9869
{
	private DesktopCrossplayStatus m_Status;
	private int m_ServiceInitResult;

	public DesktopCrossplayStatus Status { get; set; }
	public int ServiceInitResult { get; set; }


	public DesktopCrossplayStatus get_Status() { }

	public void set_Status(DesktopCrossplayStatus value) { }

	public int get_ServiceInitResult() { }

	public void set_ServiceInitResult(int value) { }

	public void Set(ref GetDesktopCrossplayStatusInfo other) { }

	public void Set(ref Nullable<GetDesktopCrossplayStatusInfo> other) { }

	public void Dispose() { }

	public void Get(out GetDesktopCrossplayStatusInfo output) { }

}

