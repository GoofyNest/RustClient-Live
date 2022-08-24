internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 1162
{
	private static MethodInfo _cache_GetTypeMethod; 
	private static MethodInfo _cache_GetHashCodeMethod; 
	private IMessageSink _sink; 
	private bool _hasEnvoySink; 
	private ConstructionCall _ctorCall; 

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

