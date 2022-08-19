public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1250
{	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
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

	// Methods

	// RVA: 0x146E290 Offset: 0x146D690 VA: 0x18146E290
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x147A640 Offset: 0x1479A40 VA: 0x18147A640
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x147A2D0 Offset: 0x14796D0 VA: 0x18147A2D0
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x1479E60 Offset: 0x1479260 VA: 0x181479E60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1479A70 Offset: 0x1478E70 VA: 0x181479A70
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x147A710 Offset: 0x1479B10 VA: 0x18147A710 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x147A720 Offset: 0x1479B20 VA: 0x18147A720 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147A790 Offset: 0x1479B90 VA: 0x18147A790 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x147A910 Offset: 0x1479D10 VA: 0x18147A910 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x147A990 Offset: 0x1479D90 VA: 0x18147A990 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x147AA40 Offset: 0x1479E40 VA: 0x18147AA40 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x146E3C0 Offset: 0x146D7C0 VA: 0x18146E3C0 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x147AC60 Offset: 0x147A060 VA: 0x18147AC60 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x1479DE0 Offset: 0x14791E0 VA: 0x181479DE0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Uri(string value) { }

	// RVA: 0x1479DE0 Offset: 0x14791E0 VA: 0x181479DE0 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1479750 Offset: 0x1478B50 VA: 0x181479750 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x1479790 Offset: 0x1478B90 VA: 0x181479790 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

