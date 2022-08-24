public class Context // TypeDefIndex: 1171
{
	private int domain_id; 
	private int context_id; 
	private UIntPtr static_data; 
	private UIntPtr data; 
	[ContextStaticAttribute] 
	private static object[] local_slots; 
	private static IMessageSink default_server_context_sink; 
	private IMessageSink server_context_sink_chain; 
	private IMessageSink client_context_sink_chain; 
	private List<IContextProperty> context_properties; 
	private static int global_count; 
	private LocalDataStoreHolder _localDataStore; 
	private static LocalDataStoreMgr _localDataStoreMgr; 
	private static DynamicPropertyCollection global_dynamic_properties; 
	private DynamicPropertyCollection context_dynamic_properties; 
	private ContextCallbackObject callback_object; 

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

