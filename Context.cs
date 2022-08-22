public class Context // TypeDefIndex: 1171
{	private int domain_id; // 0x10
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

	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }


	private static void RegisterContext(Context ctx) { }

	private static void ReleaseContext(Context ctx) { }

	public void .ctor() { }

	protected override void Finalize() { }

	public static Context get_DefaultContext() { }

	public virtual int get_ContextID() { }

	public virtual IContextProperty[] get_ContextProperties() { }

	internal bool get_IsDefaultContext() { }

	internal bool get_NeedsContextSink() { }

	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	internal static bool get_HasGlobalDynamicSinks() { }

	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	internal bool get_HasDynamicSinks() { }

	internal bool get_HasExitSinks() { }

	public virtual IContextProperty GetProperty(string name) { }

	public virtual void SetProperty(IContextProperty prop) { }

	public virtual void Freeze() { }

	public override string ToString() { }

	internal IMessageSink GetServerContextSinkChain() { }

	internal IMessageSink GetClientContextSinkChain() { }

	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	internal static Context SwitchToContext(Context newContext) { }

	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	public void DoCallBack(CrossContextDelegate deleg) { }

	private LocalDataStore get_MyLocalStore() { }

	public static LocalDataStoreSlot AllocateDataSlot() { }

	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	public static void FreeNamedDataSlot(string name) { }

	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	public static object GetData(LocalDataStoreSlot slot) { }

	public static void SetData(LocalDataStoreSlot slot, object data) { }

	private static void .cctor() { }

}

