internal static class SecurityUtils // TypeDefIndex: 2565
{

	private static void DemandReflectionAccess(Type type) { }

	private static void DemandGrantSet(Assembly assembly) { }

	private static bool HasReflectionPermission(Type type) { }

	internal static object SecureCreateInstance(Type type) { }

	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	internal static object SecureCreateInstance(Type type, object[] args) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

