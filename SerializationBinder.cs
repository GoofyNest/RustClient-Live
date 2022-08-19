public abstract class SerializationBinder // TypeDefIndex: 1053
{	// Methods

	// RVA: 0x129FF20 Offset: 0x129F320 VA: 0x18129FF20 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

