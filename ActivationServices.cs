internal class ActivationServices // TypeDefIndex: 1202
{
	private static IActivator _constructionActivator; 

	private static IActivator ConstructionActivator { get; }


	private static IActivator get_ConstructionActivator() { }

	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	public static object CreateProxyForType(Type type) { }

	public static object AllocateUninitializedClassInstance(Type type) { }

	public static void EnableProxyActivation(Type type, bool enable) { }

}

