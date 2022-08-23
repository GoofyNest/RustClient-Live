public class CustomAttributeData // TypeDefIndex: 560
{	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }


	protected void .ctor() { }

	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	private void ResolveArguments() { }

	public virtual ConstructorInfo get_Constructor() { }

	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	public Type get_AttributeType() { }

	public override string ToString() { }

	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-CustomAttributeData.UnboxValues<object>
	|
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 561
{	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20


	public void .ctor() { }

}

