internal abstract class Identity // TypeDefIndex: 1133
{	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_ObjectUri() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_ObjectUri(string value) { }

	// RVA: 0x793940 Offset: 0x792D40 VA: 0x180793940
	public bool get_IsConnected() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_Disposed() { }

	// RVA: 0x80DB50 Offset: 0x80CF50 VA: 0x18080DB50
	public void set_Disposed(bool value) { }

	// RVA: 0x14729A0 Offset: 0x1471DA0 VA: 0x1814729A0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1472A60 Offset: 0x1471E60 VA: 0x181472A60
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1472880 Offset: 0x1471C80 VA: 0x181472880
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1472910 Offset: 0x1471D10 VA: 0x181472910
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

}

