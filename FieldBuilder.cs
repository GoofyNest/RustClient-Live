public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 604
{
// Namespace: System.Reflection.Emit
public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 604
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18C3F20 Offset: 0x18C3320 VA: 0x1818C3F20 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x18C3F70 Offset: 0x18C3370 VA: 0x1818C3F70 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C3FF0 Offset: 0x18C33F0 VA: 0x1818C3FF0 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C4040 Offset: 0x18C3440 VA: 0x1818C4040 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C3E70 Offset: 0x18C3270 VA: 0x1818C3E70 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C3FC0 Offset: 0x18C33C0 VA: 0x1818C3FC0 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x18C4090 Offset: 0x18C3490 VA: 0x1818C4090 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C3E10 Offset: 0x18C3210 VA: 0x1818C3E10 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C3E40 Offset: 0x18C3240 VA: 0x1818C3E40 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C3EC0 Offset: 0x18C32C0 VA: 0x1818C3EC0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C3EF0 Offset: 0x18C32F0 VA: 0x1818C3EF0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

