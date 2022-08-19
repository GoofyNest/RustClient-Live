internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 1162
{	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1482130 Offset: 0x1481530 VA: 0x181482130
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x14821E0 Offset: 0x14815E0 VA: 0x1814821E0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1481B10 Offset: 0x1480F10 VA: 0x181481B10 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x14813C0 Offset: 0x14807C0 VA: 0x1814813C0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1481260 Offset: 0x1480660 VA: 0x181481260
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1482270 Offset: 0x1481670 VA: 0x181482270 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1481770 Offset: 0x1480B70 VA: 0x181481770 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x1481A00 Offset: 0x1480E00 VA: 0x181481A00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1482060 Offset: 0x1481460 VA: 0x181482060
	private static void .cctor() { }

}

