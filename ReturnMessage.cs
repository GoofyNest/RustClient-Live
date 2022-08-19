public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1258
{	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1487220 Offset: 0x1486620 VA: 0x181487220
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x1487150 Offset: 0x1486550 VA: 0x181487150
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x5310E0 Offset: 0x5304E0 VA: 0x1805310E0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x1487320 Offset: 0x1486720 VA: 0x181487320 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x1487390 Offset: 0x1486790 VA: 0x181487390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1487400 Offset: 0x1486800 VA: 0x181487400 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1487670 Offset: 0x1486A70 VA: 0x181487670 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x14876F0 Offset: 0x1486AF0 VA: 0x1814876F0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_Uri(string value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x126FE50 Offset: 0x126F250 VA: 0x18126FE50 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x1487590 Offset: 0x1486990 VA: 0x181487590 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

