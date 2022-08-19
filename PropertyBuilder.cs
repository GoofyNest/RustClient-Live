public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
{
// Namespace: System.Reflection.Emit
public class ParameterBuilder // TypeDefIndex: 610

// Namespace: System.Reflection.Emit
public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18CF1D0 Offset: 0x18CE5D0 VA: 0x1818CF1D0 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18CF220 Offset: 0x18CE620 VA: 0x1818CF220 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18CF270 Offset: 0x18CE670 VA: 0x1818CF270 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18CF2C0 Offset: 0x18CE6C0 VA: 0x1818CF2C0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CF310 Offset: 0x18CE710 VA: 0x1818CF310 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CF360 Offset: 0x18CE760 VA: 0x1818CF360 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18CF0C0 Offset: 0x18CE4C0 VA: 0x1818CF0C0 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18CF3B0 Offset: 0x18CE7B0 VA: 0x1818CF3B0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CF000 Offset: 0x18CE400 VA: 0x1818CF000 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18CF030 Offset: 0x18CE430 VA: 0x1818CF030 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CF060 Offset: 0x18CE460 VA: 0x1818CF060 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CF090 Offset: 0x18CE490 VA: 0x1818CF090 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18CF110 Offset: 0x18CE510 VA: 0x1818CF110 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x18CF140 Offset: 0x18CE540 VA: 0x1818CF140 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18CF170 Offset: 0x18CE570 VA: 0x1818CF170 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CF1A0 Offset: 0x18CE5A0 VA: 0x1818CF1A0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

