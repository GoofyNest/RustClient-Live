public abstract class RealProxy // TypeDefIndex: 1161
{
	private Type class_to_proxy; 
	internal Context _targetContext; 
	internal MarshalByRefObject _server; 
	private int _targetDomainId; 
	internal string _targetUri; 
	internal Identity _objectIdentity; 
	private object _objTP; 
	private object _stubData; 

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

