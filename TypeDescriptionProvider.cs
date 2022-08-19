public abstract class TypeDescriptionProvider // TypeDefIndex: 2755
{	// Fields
	private TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1734FC0 Offset: 0x17343C0 VA: 0x181734FC0 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x17350C0 Offset: 0x17344C0 VA: 0x1817350C0 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x17350E0 Offset: 0x17344E0 VA: 0x1817350E0 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1735180 Offset: 0x1734580 VA: 0x181735180 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1617D30 Offset: 0x1617130 VA: 0x181617D30
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x1735220 Offset: 0x1734620 VA: 0x181735220 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0xFE8B90 Offset: 0xFE7F90 VA: 0x180FE8B90
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x1735240 Offset: 0x1734640 VA: 0x181735240
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x17352D0 Offset: 0x17346D0 VA: 0x1817352D0 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 2756
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

