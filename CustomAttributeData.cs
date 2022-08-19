public class CustomAttributeData // TypeDefIndex: 560
{	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18C2820 Offset: 0x18C1C20 VA: 0x1818C2820
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x18C20C0 Offset: 0x18C14C0 VA: 0x1818C20C0
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x18C20D0 Offset: 0x18C14D0 VA: 0x1818C20D0
	private void ResolveArguments() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x18C28F0 Offset: 0x18C1CF0 VA: 0x1818C28F0 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x18C2910 Offset: 0x18C1D10 VA: 0x1818C2910 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x18C1C00 Offset: 0x18C1000 VA: 0x1818C1C00
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x18C1AE0 Offset: 0x18C0EE0 VA: 0x1818C1AE0
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x18C1BA0 Offset: 0x18C0FA0 VA: 0x1818C1BA0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x18C1B40 Offset: 0x18C0F40 VA: 0x1818C1B40
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0
	public Type get_AttributeType() { }

	// RVA: 0x18C2230 Offset: 0x18C1630 VA: 0x1818C2230 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9EB10 Offset: 0x1A9DF10 VA: 0x181A9EB10
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x1A9E8B0 Offset: 0x1A9DCB0 VA: 0x181A9E8B0
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1A9E9F0 Offset: 0x1A9DDF0 VA: 0x181A9E9F0
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x18C1670 Offset: 0x18C0A70 VA: 0x1818C1670 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C1CC0 Offset: 0x18C10C0 VA: 0x1818C1CC0 Slot: 2
	public override int GetHashCode() { }

}

private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 561
{	// Fields
	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

