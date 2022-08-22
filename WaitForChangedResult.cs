public struct WaitForChangedResult // TypeDefIndex: 2858
{	private WatcherChangeTypes changeType; // 0x0
	private string name; // 0x8
	private string oldName; // 0x10
	private bool timedOut; // 0x18

	public WatcherChangeTypes ChangeType { set; }
	public string Name { set; }
	public string OldName { set; }


	public void set_ChangeType(WatcherChangeTypes value) { }

	public void set_Name(string value) { }

	public void set_OldName(string value) { }

}

