internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 1236
{	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x1472340 Offset: 0x1471740 VA: 0x181472340
	public void .ctor() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1472390 Offset: 0x1471790 VA: 0x181472390 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x14723C0 Offset: 0x14717C0 VA: 0x1814723C0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 11
	public string get_Uri() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

}

