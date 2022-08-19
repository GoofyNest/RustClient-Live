internal class ActivationServices // TypeDefIndex: 1202
{	// Fields
	private static IActivator _constructionActivator; // 0x13248

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0xFD6430 Offset: 0xFD5830 VA: 0x180FD6430
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0xFD5490 Offset: 0xFD4890 VA: 0x180FD5490
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0xFD6370 Offset: 0xFD5770 VA: 0x180FD6370
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFD5640 Offset: 0xFD4A40 VA: 0x180FD5640
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0xFD5E20 Offset: 0xFD5220 VA: 0x180FD5E20
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFD6200 Offset: 0xFD5600 VA: 0x180FD6200
	public static object CreateProxyForType(Type type) { }

	// RVA: 0xFD5630 Offset: 0xFD4A30 VA: 0x180FD5630
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0xFD6360 Offset: 0xFD5760 VA: 0x180FD6360
	public static void EnableProxyActivation(Type type, bool enable) { }

}

