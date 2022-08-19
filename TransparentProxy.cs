internal class TransparentProxy // TypeDefIndex: 1160
{	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x1488F90 Offset: 0x1488390 VA: 0x181488F90
	internal RuntimeType GetProxyType() { }

	// RVA: 0x14897A0 Offset: 0x1488BA0 VA: 0x1814897A0
	private bool get_IsContextBoundObject() { }

	// RVA: 0x4CEC00 Offset: 0x4CE000 VA: 0x1804CEC00
	private Context get_TargetContext() { }

	// RVA: 0x1489050 Offset: 0x1488450 VA: 0x181489050
	private bool InCurrentContext() { }

	// RVA: 0x1489150 Offset: 0x1488550 VA: 0x181489150
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x1489470 Offset: 0x1488870 VA: 0x181489470
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

