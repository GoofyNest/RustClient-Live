internal class WebConnectionGroup // TypeDefIndex: 3031
{
	private ServicePoint sPoint;
	private string name;
	private LinkedList<WebConnectionGroup.ConnectionState> connections;
	private Queue queue;
	private bool closing;
	[CompilerGeneratedAttribute]
	private EventHandler ConnectionClosed;

	public string Name { get; }
	internal Queue Queue { get; }


	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute]
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute]
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
{
	[CompilerGeneratedAttribute]
	private WebConnection <Connection>k__BackingField;
	[CompilerGeneratedAttribute]
	private WebConnectionGroup <Group>k__BackingField;
	private bool busy;
	private DateTime idleSince;

	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }


	[CompilerGeneratedAttribute]
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute]
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute]
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute]
	private void set_Group(WebConnectionGroup value) { }

	public ServicePoint get_ServicePoint() { }

	public bool get_Busy() { }

	public DateTime get_IdleSince() { }

	public bool TrySetBusy() { }

	public void SetIdle() { }

	public void .ctor(WebConnectionGroup group) { }

}

