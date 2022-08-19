internal class WebConnectionGroup // TypeDefIndex: 3031
{	// Fields
	private ServicePoint sPoint; // 0x10
	private string name; // 0x18
	private LinkedList<WebConnectionGroup.ConnectionState> connections; // 0x20
	private Queue queue; // 0x28
	private bool closing; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler ConnectionClosed; // 0x38

	// Properties
	public string Name { get; }
	internal Queue Queue { get; }

	// Methods

	// RVA: 0x117A430 Offset: 0x1179830 VA: 0x18117A430
	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x117A4F0 Offset: 0x11798F0 VA: 0x18117A4F0
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x117A590 Offset: 0x1179990 VA: 0x18117A590
	public void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0x1179C60 Offset: 0x1179060 VA: 0x181179C60
	private void OnConnectionClosed() { }

	// RVA: 0x1179530 Offset: 0x1178930 VA: 0x181179530
	public void Close() { }

	// RVA: 0x1179B80 Offset: 0x1178F80 VA: 0x181179B80
	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x1179C80 Offset: 0x1179080 VA: 0x181179C80
	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x11799D0 Offset: 0x1178DD0 VA: 0x1811799D0
	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	// RVA: 0x11797F0 Offset: 0x1178BF0 VA: 0x1811797F0
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Name() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal Queue get_Queue() { }

	// RVA: 0x1179F50 Offset: 0x1179350 VA: 0x181179F50
	internal bool TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }

}

private class WebConnectionGroup.ConnectionState : IWebConnectionState // TypeDefIndex: 3032
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WebConnection <Connection>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WebConnectionGroup <Group>k__BackingField; // 0x18
	private bool busy; // 0x20
	private DateTime idleSince; // 0x28

	// Properties
	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Group(WebConnectionGroup value) { }

	// RVA: 0xE51E50 Offset: 0xE51250 VA: 0x180E51E50 Slot: 7
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 8
	public bool get_Busy() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 9
	public DateTime get_IdleSince() { }

	// RVA: 0x1176020 Offset: 0x1175420 VA: 0x181176020 Slot: 5
	public bool TrySetBusy() { }

	// RVA: 0x1175F20 Offset: 0x1175320 VA: 0x181175F20 Slot: 6
	public void SetIdle() { }

	// RVA: 0x11761A0 Offset: 0x11755A0 VA: 0x1811761A0
	public void .ctor(WebConnectionGroup group) { }

}

