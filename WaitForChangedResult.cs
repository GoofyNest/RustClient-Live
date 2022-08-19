public struct WaitForChangedResult // TypeDefIndex: 2858
{	// Fields
	private WatcherChangeTypes changeType; // 0x0
	private string name; // 0x8
	private string oldName; // 0x10
	private bool timedOut; // 0x18

	// Properties
	public WatcherChangeTypes ChangeType { set; }
	public string Name { set; }
	public string OldName { set; }

	// Methods

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_ChangeType(WatcherChangeTypes value) { }

	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_Name(string value) { }

	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_OldName(string value) { }

}

