internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2707
{
// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2707
	// Fields
	private readonly ReflectPropertyDescriptor extenderInfo; // 0x88
	private readonly IExtenderProvider provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x159FEB0 Offset: 0x159F2B0 VA: 0x18159FEB0
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x15A00C0 Offset: 0x159F4C0 VA: 0x1815A00C0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15A0420 Offset: 0x159F820 VA: 0x1815A0420 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x15A0510 Offset: 0x159F910 VA: 0x1815A0510 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15A00F0 Offset: 0x159F4F0 VA: 0x1815A00F0 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x159FE10 Offset: 0x159F210 VA: 0x18159FE10 Slot: 17
	public override object GetValue(object comp) { }

	// RVA: 0x159FE40 Offset: 0x159F240 VA: 0x18159FE40 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x159FE80 Offset: 0x159F280 VA: 0x18159FE80 Slot: 20
	public override bool ShouldSerializeValue(object comp) { }

}

