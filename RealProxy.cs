public abstract class RealProxy // TypeDefIndex: 1161
{	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x12CBCA0 Offset: 0x12CB0A0 VA: 0x1812CBCA0
	protected void .ctor() { }

	// RVA: 0x147EF70 Offset: 0x147E370 VA: 0x18147EF70
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x147EF00 Offset: 0x147E300 VA: 0x18147EF00
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x147EDF0 Offset: 0x147E1F0 VA: 0x18147EDF0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x147DA30 Offset: 0x147CE30 VA: 0x18147DA30
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x147D870 Offset: 0x147CC70 VA: 0x18147D870
	public Type GetProxiedType() { }

	// RVA: 0x147D7F0 Offset: 0x147CBF0 VA: 0x18147D7F0 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x147DA50 Offset: 0x147CE50 VA: 0x18147DA50
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x147DA40 Offset: 0x147CE40 VA: 0x18147DA40 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x147D900 Offset: 0x147CD00 VA: 0x18147D900 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x147D6D0 Offset: 0x147CAD0 VA: 0x18147D6D0
	internal object GetAppDomainTarget() { }

	// RVA: 0x147E870 Offset: 0x147DC70 VA: 0x18147E870
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

}

