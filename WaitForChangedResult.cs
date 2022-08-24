public struct WaitForChangedResult // TypeDefIndex: 2858
{
	private WatcherChangeTypes changeType; 
	private string name; 
	private string oldName; 
	private bool timedOut; 

	public WatcherChangeTypes ChangeType { set; }
	public string Name { set; }
	public string OldName { set; }


	public void set_ChangeType(WatcherChangeTypes value) { }

	public void set_Name(string value) { }

	public void set_OldName(string value) { }

}

