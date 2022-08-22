public abstract class RealProxy // TypeDefIndex: 1161
{	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	internal Identity ObjectIdentity { get; set; }


	protected void .ctor() { }

	protected void .ctor(Type classToProxy) { }

	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	private static Type InternalGetProxyType(object transparentProxy) { }

	public Type GetProxiedType() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal Identity get_ObjectIdentity() { }

	internal void set_ObjectIdentity(Identity value) { }

	public abstract IMessage Invoke(IMessage msg);

	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	internal virtual object InternalGetTransparentProxy(string className) { }

	public virtual object GetTransparentProxy() { }

	protected void AttachServer(MarshalByRefObject s) { }

	internal void SetTargetDomain(int domainId) { }

	internal object GetAppDomainTarget() { }

	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

}

