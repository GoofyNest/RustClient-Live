internal static class TypeExtensions // TypeDefIndex: 5976
{

	[ExtensionAttribute] 
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[ExtensionAttribute] 
	public static bool ContainsGenericParameters(Type type) { }

	[ExtensionAttribute] 
	public static bool IsInterface(Type type) { }

	[ExtensionAttribute] 
	public static bool IsGenericType(Type type) { }

	[ExtensionAttribute] 
	public static bool IsGenericTypeDefinition(Type type) { }

	[ExtensionAttribute] 
	public static Type BaseType(Type type) { }

	[ExtensionAttribute] 
	public static bool IsEnum(Type type) { }

	[ExtensionAttribute] 
	public static bool IsClass(Type type) { }

	[ExtensionAttribute] 
	public static bool IsSealed(Type type) { }

	[ExtensionAttribute] 
	public static bool IsAbstract(Type type) { }

	[ExtensionAttribute] 
	public static bool IsValueType(Type type) { }

	[ExtensionAttribute] 
	public static bool AssignableToTypeName(Type type, string fullTypeName, out Type match) { }

	[ExtensionAttribute] 
	public static bool AssignableToTypeName(Type type, string fullTypeName) { }

	[ExtensionAttribute] 
	public static bool ImplementInterface(Type type, Type interfaceType) { }

}

