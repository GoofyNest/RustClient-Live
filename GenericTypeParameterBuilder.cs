public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 605
{	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x18C4C70 Offset: 0x18C4070 VA: 0x1818C4C70 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18C4C20 Offset: 0x18C4020 VA: 0x1818C4C20 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18C4CC0 Offset: 0x18C40C0 VA: 0x1818C4CC0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18C4D10 Offset: 0x18C4110 VA: 0x1818C4D10 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18C4D60 Offset: 0x18C4160 VA: 0x1818C4D60 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18C4DB0 Offset: 0x18C41B0 VA: 0x1818C4DB0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C4E00 Offset: 0x18C4200 VA: 0x1818C4E00 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C48A0 Offset: 0x18C3CA0 VA: 0x1818C48A0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18C4E50 Offset: 0x18C4250 VA: 0x1818C4E50 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C47B0 Offset: 0x18C3BB0 VA: 0x1818C47B0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C47E0 Offset: 0x18C3BE0 VA: 0x1818C47E0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18C4810 Offset: 0x18C3C10 VA: 0x1818C4810 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C4870 Offset: 0x18C3C70 VA: 0x1818C4870 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C4840 Offset: 0x18C3C40 VA: 0x1818C4840 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C48F0 Offset: 0x18C3CF0 VA: 0x1818C48F0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C4920 Offset: 0x18C3D20 VA: 0x1818C4920 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C4950 Offset: 0x18C3D50 VA: 0x1818C4950 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C4980 Offset: 0x18C3D80 VA: 0x1818C4980 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C49B0 Offset: 0x18C3DB0 VA: 0x1818C49B0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C49E0 Offset: 0x18C3DE0 VA: 0x1818C49E0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C4A10 Offset: 0x18C3E10 VA: 0x1818C4A10 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C4A40 Offset: 0x18C3E40 VA: 0x1818C4A40 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C4A70 Offset: 0x18C3E70 VA: 0x1818C4A70 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C4AA0 Offset: 0x18C3EA0 VA: 0x1818C4AA0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C4AD0 Offset: 0x18C3ED0 VA: 0x1818C4AD0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C4B00 Offset: 0x18C3F00 VA: 0x1818C4B00 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C4B30 Offset: 0x18C3F30 VA: 0x1818C4B30 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C4B60 Offset: 0x18C3F60 VA: 0x1818C4B60 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C4B90 Offset: 0x18C3F90 VA: 0x1818C4B90 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C4BC0 Offset: 0x18C3FC0 VA: 0x1818C4BC0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18C4BF0 Offset: 0x18C3FF0 VA: 0x1818C4BF0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

