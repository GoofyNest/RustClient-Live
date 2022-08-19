public static class CustomAttributeExtensions // TypeDefIndex: 502
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18C2940 Offset: 0x18C1D40 VA: 0x1818C2940
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18C2930 Offset: 0x18C1D30 VA: 0x1818C2930
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5080 Offset: 0xBD4480 VA: 0x180BD5080
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	|-CustomAttributeExtensions.GetCustomAttribute<NeutralResourcesLanguageAttribute>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4FC0 Offset: 0xBD43C0 VA: 0x180BD4FC0
	|-CustomAttributeExtensions.GetCustomAttribute<ButtonGroupAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<LabelAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<XmlTypeConvertorAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<RangeAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18C2950 Offset: 0x18C1D50 VA: 0x1818C2950
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA780 Offset: 0xCF9B80 VA: 0x180CFA780
	|-CustomAttributeExtensions.GetCustomAttributes<OptionAttribute>
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

}

