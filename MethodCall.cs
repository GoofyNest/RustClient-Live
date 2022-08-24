public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1246
{
	private string _uri; 
	private string _typeName; 
	private string _methodName; 
	private object[] _args; 
	private Type[] _methodSignature; 
	private MethodBase _methodBase; 
	private LogicalCallContext _callContext; 
	private Identity _targetIdentity; 
	private Type[] _genericArguments; 
	protected IDictionary ExternalProperties; 
	protected IDictionary InternalProperties; 

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

