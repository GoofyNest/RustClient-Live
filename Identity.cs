internal abstract class Identity // TypeDefIndex: 1133
{
	protected string _objectUri; 
	protected IMessageSink _channelSink; 
	protected IMessageSink _envoySink; 
	private DynamicPropertyCollection _clientDynamicProperties; 
	private DynamicPropertyCollection _serverDynamicProperties; 
	protected ObjRef _objRef; 
	private bool _disposed; 

	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }


	public void .ctor(string objectUri) { }

	public abstract ObjRef CreateObjRef(Type requestedType);

	public IMessageSink get_ChannelSink() { }

	public void set_ChannelSink(IMessageSink value) { }

	public IMessageSink get_EnvoySink() { }

	public string get_ObjectUri() { }

	public void set_ObjectUri(string value) { }

	public bool get_IsConnected() { }

	public bool get_Disposed() { }

	public void set_Disposed(bool value) { }

	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	public bool get_HasServerDynamicSinks() { }

	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

}

