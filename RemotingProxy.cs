internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 1162
{	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	public string TypeName { get; }


	internal void .ctor(Type type, ClientIdentity identity) { }

	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	public override IMessage Invoke(IMessage request) { }

	internal void AttachIdentity(Identity identity) { }

	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	public string get_TypeName() { }

	public bool CanCastTo(Type fromType, object o) { }

	protected override void Finalize() { }

	private static void .cctor() { }

}

