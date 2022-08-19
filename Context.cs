public class Context // TypeDefIndex: 1171
{	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private static void RegisterContext(Context ctx) { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1470590 Offset: 0x146F990 VA: 0x181470590
	public void .ctor() { }

	// RVA: 0x146F380 Offset: 0x146E780 VA: 0x18146F380 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1470670 Offset: 0x146FA70 VA: 0x181470670
	public static Context get_DefaultContext() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1470610 Offset: 0x146FA10 VA: 0x181470610 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1470840 Offset: 0x146FC40 VA: 0x181470840
	internal bool get_IsDefaultContext() { }

	// RVA: 0x14709F0 Offset: 0x146FDF0 VA: 0x1814709F0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x146FF40 Offset: 0x146F340 VA: 0x18146FF40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1470330 Offset: 0x146F730 VA: 0x181470330
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x146F820 Offset: 0x146EC20 VA: 0x18146F820
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x146FE00 Offset: 0x146F200 VA: 0x18146FE00
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1470790 Offset: 0x146FB90 VA: 0x181470790
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x146FD70 Offset: 0x146F170 VA: 0x18146FD70
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1470680 Offset: 0x146FA80 VA: 0x181470680
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x14706C0 Offset: 0x146FAC0 VA: 0x1814706C0
	internal bool get_HasExitSinks() { }

	// RVA: 0x146FA50 Offset: 0x146EE50 VA: 0x18146FA50 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x1470190 Offset: 0x146F590 VA: 0x181470190 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x146F4D0 Offset: 0x146E8D0 VA: 0x18146F4D0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x14702D0 Offset: 0x146F6D0 VA: 0x1814702D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x146FBC0 Offset: 0x146EFC0 VA: 0x18146FBC0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x146F650 Offset: 0x146EA50 VA: 0x18146F650
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x146F090 Offset: 0x146E490 VA: 0x18146F090
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x146E870 Offset: 0x146DC70 VA: 0x18146E870
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x14702C0 Offset: 0x146F6C0 VA: 0x1814702C0
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x146EA00 Offset: 0x146DE00 VA: 0x18146EA00
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x146F240 Offset: 0x146E640 VA: 0x18146F240
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1470850 Offset: 0x146FC50 VA: 0x181470850
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x146E780 Offset: 0x146DB80 VA: 0x18146E780
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x146E7F0 Offset: 0x146DBF0 VA: 0x18146E7F0
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x146F450 Offset: 0x146E850 VA: 0x18146F450
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x146F9D0 Offset: 0x146EDD0 VA: 0x18146F9D0
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x146F7E0 Offset: 0x146EBE0 VA: 0x18146F7E0
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1470140 Offset: 0x146F540 VA: 0x181470140
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1470530 Offset: 0x146F930 VA: 0x181470530
	private static void .cctor() { }

}

