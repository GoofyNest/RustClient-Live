public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 600
{
// Namespace: System.Reflection.Emit
public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 600
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18C1400 Offset: 0x18C0800 VA: 0x1818C1400 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C1450 Offset: 0x18C0850 VA: 0x1818C1450 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C14D0 Offset: 0x18C08D0 VA: 0x1818C14D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C1320 Offset: 0x18C0720 VA: 0x1818C1320 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C14A0 Offset: 0x18C08A0 VA: 0x1818C14A0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C1520 Offset: 0x18C0920 VA: 0x1818C1520 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C1290 Offset: 0x18C0690 VA: 0x1818C1290 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C12C0 Offset: 0x18C06C0 VA: 0x1818C12C0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C12F0 Offset: 0x18C06F0 VA: 0x1818C12F0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C1370 Offset: 0x18C0770 VA: 0x1818C1370 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C13A0 Offset: 0x18C07A0 VA: 0x1818C13A0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C13D0 Offset: 0x18C07D0 VA: 0x1818C13D0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

