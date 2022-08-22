public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1246
{	private string _uri; // 0x10
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


	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(CADMethodCallMessage msg) { }

	internal void .ctor() { }

	internal void CopyFrom(IMethodMessage call) { }

	internal virtual void InitMethodProperty(string key, object value) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public virtual IDictionary get_Properties() { }

	internal virtual void InitDictionary() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public void set_Uri(string value) { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	public object GetArg(int argNum) { }

	public virtual void Init() { }

	public void ResolveMethod() { }

	private Type CastTo(string clientType, Type serverType) { }

	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private Type[] get_GenericArguments() { }

}

