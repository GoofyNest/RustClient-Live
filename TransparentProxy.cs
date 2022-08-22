internal class TransparentProxy // TypeDefIndex: 1160
{	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

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

