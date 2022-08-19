public abstract class MarshalByRefObject // TypeDefIndex: 371
{	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	protected void .ctor() { }

	// RVA: 0x166F620 Offset: 0x166EA20 VA: 0x18166F620
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x166F670 Offset: 0x166EA70 VA: 0x18166F670
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x166F580 Offset: 0x166E980 VA: 0x18166F580 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x166F5D0 Offset: 0x166E9D0 VA: 0x18166F5D0 Slot: 5
	public virtual object InitializeLifetimeService() { }

}

