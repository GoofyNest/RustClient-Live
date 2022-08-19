public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1246
{	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x146E070 Offset: 0x146D470 VA: 0x18146E070
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1479180 Offset: 0x1478580 VA: 0x181479180
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x1478050 Offset: 0x1477450 VA: 0x181478050
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x1478620 Offset: 0x1477A20 VA: 0x181478620 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x1478220 Offset: 0x1477620 VA: 0x181478220 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14793F0 Offset: 0x14787F0 VA: 0x1814793F0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x1479470 Offset: 0x1478870 VA: 0x181479470 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x14794E0 Offset: 0x14788E0 VA: 0x1814794E0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1479510 Offset: 0x1478910 VA: 0x181479510 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x1479560 Offset: 0x1478960 VA: 0x181479560 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x146E260 Offset: 0x146D660 VA: 0x18146E260 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1478570 Offset: 0x1477970 VA: 0x181478570 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x14796E0 Offset: 0x1478AE0 VA: 0x1814796E0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 11
	public string get_Uri() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Uri(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x14781E0 Offset: 0x14775E0 VA: 0x1814781E0 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 23
	public virtual void Init() { }

	// RVA: 0x1478940 Offset: 0x1477D40 VA: 0x181478940
	public void ResolveMethod() { }

	// RVA: 0x1477E40 Offset: 0x1477240 VA: 0x181477E40
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x14784E0 Offset: 0x14778E0 VA: 0x1814784E0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x1479410 Offset: 0x1478810 VA: 0x181479410
	private Type[] get_GenericArguments() { }

}

