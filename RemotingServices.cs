public static class RemotingServices // TypeDefIndex: 1143
{	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38


	private static void .cctor() { }

	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	public static bool IsTransparentProxy(object proxy) { }

	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static object Connect(Type classToProxy, string url, object data) { }

	public static Type GetServerTypeForUri(string URI) { }

	public static object Unmarshal(ObjRef objectRef) { }

	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static RealProxy GetRealProxy(object proxy) { }

	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	public static bool IsOneWay(MethodBase method) { }

	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	internal static Identity GetIdentityForUri(string uri) { }

	private static string RemoveAppNameFromUri(string uri) { }

	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	private static void RegisterServerIdentity(ServerIdentity identity) { }

	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	internal static byte[] SerializeCallData(object obj) { }

	internal static object DeserializeCallData(byte[] array) { }

	internal static byte[] SerializeExceptionData(Exception ex) { }

	private static void RegisterInternalChannels() { }

	internal static void DisposeIdentity(Identity ident) { }

	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	private static string GetNormalizedUri(string uri) { }

}

private class RemotingServices.CACD // TypeDefIndex: 1144
{	public object d; // 0x10
	public object c; // 0x18


	public void .ctor() { }

}

