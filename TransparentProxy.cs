internal class TransparentProxy // TypeDefIndex: 1160
{
	public RealProxy _rp; 
	private RuntimeRemoteClassHandle _class; 
	private bool _custom_type_info; 

	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }


	internal RuntimeType GetProxyType() { }

	private bool get_IsContextBoundObject() { }

	private Context get_TargetContext() { }

	private bool InCurrentContext() { }

	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	public void .ctor() { }

}

