public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 608
{	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18C7A60 Offset: 0x18C6E60 VA: 0x1818C7A60 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C7AB0 Offset: 0x18C6EB0 VA: 0x1818C7AB0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C7B30 Offset: 0x18C6F30 VA: 0x1818C7B30 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C79B0 Offset: 0x18C6DB0 VA: 0x1818C79B0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C7B00 Offset: 0x18C6F00 VA: 0x1818C7B00 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C7B80 Offset: 0x18C6F80 VA: 0x1818C7B80 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C78F0 Offset: 0x18C6CF0 VA: 0x1818C78F0 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18C7920 Offset: 0x18C6D20 VA: 0x1818C7920 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C7950 Offset: 0x18C6D50 VA: 0x1818C7950 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C7980 Offset: 0x18C6D80 VA: 0x1818C7980 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C7A00 Offset: 0x18C6E00 VA: 0x1818C7A00 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C7A30 Offset: 0x18C6E30 VA: 0x1818C7A30 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

