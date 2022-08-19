public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 613
{
// Namespace: System.Reflection.Emit
public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 613
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x18D29F0 Offset: 0x18D1DF0 VA: 0x1818D29F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18D29A0 Offset: 0x18D1DA0 VA: 0x1818D29A0 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18D2A40 Offset: 0x18D1E40 VA: 0x1818D2A40 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18D2A90 Offset: 0x18D1E90 VA: 0x1818D2A90 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18D2AE0 Offset: 0x18D1EE0 VA: 0x1818D2AE0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D2B30 Offset: 0x18D1F30 VA: 0x1818D2B30 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D2B80 Offset: 0x18D1F80 VA: 0x1818D2B80 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18D2620 Offset: 0x18D1A20 VA: 0x1818D2620 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18D2BD0 Offset: 0x18D1FD0 VA: 0x1818D2BD0 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18D2530 Offset: 0x18D1930 VA: 0x1818D2530 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18D2560 Offset: 0x18D1960 VA: 0x1818D2560 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18D2590 Offset: 0x18D1990 VA: 0x1818D2590 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18D25C0 Offset: 0x18D19C0 VA: 0x1818D25C0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D25F0 Offset: 0x18D19F0 VA: 0x1818D25F0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D2670 Offset: 0x18D1A70 VA: 0x1818D2670 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D26A0 Offset: 0x18D1AA0 VA: 0x1818D26A0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D26D0 Offset: 0x18D1AD0 VA: 0x1818D26D0 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18D2700 Offset: 0x18D1B00 VA: 0x1818D2700 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18D2730 Offset: 0x18D1B30 VA: 0x1818D2730 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D2760 Offset: 0x18D1B60 VA: 0x1818D2760 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18D2790 Offset: 0x18D1B90 VA: 0x1818D2790 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D27C0 Offset: 0x18D1BC0 VA: 0x1818D27C0 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18D27F0 Offset: 0x18D1BF0 VA: 0x1818D27F0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D2820 Offset: 0x18D1C20 VA: 0x1818D2820 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18D2850 Offset: 0x18D1C50 VA: 0x1818D2850 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18D2880 Offset: 0x18D1C80 VA: 0x1818D2880 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18D28B0 Offset: 0x18D1CB0 VA: 0x1818D28B0 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18D28E0 Offset: 0x18D1CE0 VA: 0x1818D28E0 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18D2910 Offset: 0x18D1D10 VA: 0x1818D2910 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D2940 Offset: 0x18D1D40 VA: 0x1818D2940 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18D2970 Offset: 0x18D1D70 VA: 0x1818D2970 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

