internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2688
{	// Fields
	private Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x159B530 Offset: 0x159A930 VA: 0x18159B530
	internal void .ctor(Type type) { }

	// RVA: 0x159B560 Offset: 0x159A960 VA: 0x18159B560
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x159B190 Offset: 0x159A590 VA: 0x18159B190 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x159B240 Offset: 0x159A640 VA: 0x18159B240 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x159B2D0 Offset: 0x159A6D0 VA: 0x18159B2D0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x159B360 Offset: 0x159A760 VA: 0x18159B360 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x159B3F0 Offset: 0x159A7F0 VA: 0x18159B3F0 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x159B490 Offset: 0x159A890 VA: 0x18159B490 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

