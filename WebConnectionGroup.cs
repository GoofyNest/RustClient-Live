internal class WebConnectionGroup // TypeDefIndex: 3031
{	private ServicePoint sPoint; // 0x10
	private string name; // 0x18
	private LinkedList<WebConnectionGroup.ConnectionState> connections; // 0x20
	private Queue queue; // 0x28
	private bool closing; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler ConnectionClosed; // 0x38

	public string Name { get; }
	internal Queue Queue { get; }


	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_ConnectionClosed(EventHandler value) { }

	private void OnConnectionClosed() { }

	public void Close() { }

	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	public string get_Name() { }

	internal Queue get_Queue() { }

	internal bool TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }

}

private class WebConnectionGroup.ConnectionState : IWebConnectionState // TypeDefIndex: 3032
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WebConnection <Connection>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private WebConnectionGroup <Group>k__BackingField; // 0x18
	private bool busy; // 0x20
	private DateTime idleSince; // 0x28

	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Group(WebConnectionGroup value) { }

	public ServicePoint get_ServicePoint() { }

	public bool get_Busy() { }

	public DateTime get_IdleSince() { }

	public bool TrySetBusy() { }

	public void SetIdle() { }

	public void .ctor(WebConnectionGroup group) { }

}

