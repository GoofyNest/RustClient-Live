public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1250
{
	private string _methodName; 
	private string _uri; 
	private string _typeName; 
	private MethodBase _methodBase; 
	private object _returnValue; 
	private Exception _exception; 
	private Type[] _methodSignature; 
	private ArgInfo _inArgInfo; 
	private object[] _args; 
	private object[] _outArgs; 
	private IMethodCallMessage _callMsg; 
	private LogicalCallContext _callContext; 
	private Identity _targetIdentity; 
	protected IDictionary ExternalProperties; 
	protected IDictionary InternalProperties; 

	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }


	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void InitMethodProperty(string key, object value) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public Exception get_Exception() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public object[] get_OutArgs() { }

	public virtual IDictionary get_Properties() { }

	public object get_ReturnValue() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public void set_Uri(string value) { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	public object GetArg(int argNum) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

