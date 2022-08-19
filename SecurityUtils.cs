internal static class SecurityUtils // TypeDefIndex: 2565
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x14D12A0 Offset: 0x14D06A0 VA: 0x1814D12A0
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x14D16E0 Offset: 0x14D0AE0 VA: 0x1814D16E0
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x14D17B0 Offset: 0x14D0BB0 VA: 0x1814D17B0
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x14D17A0 Offset: 0x14D0BA0 VA: 0x1814D17A0
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x14D1410 Offset: 0x14D0810 VA: 0x1814D1410
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x14D1570 Offset: 0x14D0970 VA: 0x1814D1570
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x14D1200 Offset: 0x14D0600 VA: 0x1814D1200
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x14D12E0 Offset: 0x14D06E0 VA: 0x1814D12E0
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

