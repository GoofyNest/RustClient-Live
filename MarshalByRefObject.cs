public abstract class MarshalByRefObject // TypeDefIndex: 371
{
	private object _identity; 

internal ServerIdentity ObjectIdentity { get; set; }


protected void .ctor() { }

internal ServerIdentity get_ObjectIdentity() { }

internal void set_ObjectIdentity(ServerIdentity value) { }

public virtual ObjRef CreateObjRef(Type requestedType) { }

public virtual object InitializeLifetimeService() { }

}

