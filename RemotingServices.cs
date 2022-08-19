public static class RemotingServices // TypeDefIndex: 1143
{	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x14866A0 Offset: 0x1485AA0 VA: 0x1814866A0
	private static void .cctor() { }

	// RVA: 0x14853B0 Offset: 0x14847B0 VA: 0x1814853B0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x1484BE0 Offset: 0x1483FE0 VA: 0x181484BE0
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x1485450 Offset: 0x1484850 VA: 0x181485450
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x1484BF0 Offset: 0x1483FF0 VA: 0x181484BF0
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x1482380 Offset: 0x1481780 VA: 0x181482380
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x1482420 Offset: 0x1481820 VA: 0x181482420
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x1484B40 Offset: 0x1483F40 VA: 0x181484B40
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x14860C0 Offset: 0x14854C0 VA: 0x1814860C0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x1486120 Offset: 0x1485520 VA: 0x181486120
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x14854F0 Offset: 0x14848F0 VA: 0x1814854F0
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x14854A0 Offset: 0x14848A0 VA: 0x1814854A0
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x1485550 Offset: 0x1484950 VA: 0x181485550
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1484A70 Offset: 0x1483E70 VA: 0x181484A70
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x1483E40 Offset: 0x1483240 VA: 0x181483E40
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x1484000 Offset: 0x1483400 VA: 0x181484000
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x14834F0 Offset: 0x14828F0 VA: 0x1814834F0
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1484270 Offset: 0x1483670 VA: 0x181484270
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14853C0 Offset: 0x14847C0 VA: 0x1814853C0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1482790 Offset: 0x1481B90 VA: 0x181482790
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x14828F0 Offset: 0x1481CF0 VA: 0x1814828F0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x1482AD0 Offset: 0x1481ED0 VA: 0x181482AD0
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1482600 Offset: 0x1481A00 VA: 0x181482600
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x1483740 Offset: 0x1482B40 VA: 0x181483740
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x1485C50 Offset: 0x1485050 VA: 0x181485C50
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1484310 Offset: 0x1483710 VA: 0x181484310
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1483640 Offset: 0x1482A40 VA: 0x181483640
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x1482BC0 Offset: 0x1481FC0 VA: 0x181482BC0
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x14824D0 Offset: 0x14818D0 VA: 0x1814824D0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x1482CB0 Offset: 0x14820B0 VA: 0x181482CB0
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x1485A40 Offset: 0x1484E40 VA: 0x181485A40
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x1484960 Offset: 0x1483D60 VA: 0x181484960
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x1484AC0 Offset: 0x1483EC0 VA: 0x181484AC0
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x1485D60 Offset: 0x1485160 VA: 0x181485D60
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x1482DD0 Offset: 0x14821D0 VA: 0x181482DD0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x1485F00 Offset: 0x1485300 VA: 0x181485F00
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x14859F0 Offset: 0x1484DF0 VA: 0x1814859F0
	private static void RegisterInternalChannels() { }

	// RVA: 0x1483290 Offset: 0x1482690 VA: 0x181483290
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x1483AF0 Offset: 0x1482EF0 VA: 0x181483AF0
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x1486000 Offset: 0x1485400 VA: 0x181486000
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x14864B0 Offset: 0x14858B0 VA: 0x1814864B0
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1484200 Offset: 0x1483600 VA: 0x181484200
	private static string GetNormalizedUri(string uri) { }

}

private class RemotingServices.CACD // TypeDefIndex: 1144
{	// Fields
	public object d; // 0x10
	public object c; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

