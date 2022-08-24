public static class CustomAttributeExtensions // TypeDefIndex: 502
{

	[ExtensionAttribute] 
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[ExtensionAttribute] 
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] 
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	|-CustomAttributeExtensions.GetCustomAttribute<NeutralResourcesLanguageAttribute>
	*/

	[ExtensionAttribute] 
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-CustomAttributeExtensions.GetCustomAttribute<ButtonGroupAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<LabelAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<XmlTypeConvertorAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<RangeAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] 
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] 
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-CustomAttributeExtensions.GetCustomAttributes<OptionAttribute>
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

}

