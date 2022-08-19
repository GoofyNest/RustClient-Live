public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 539
{	// Properties
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsSecurityCritical { get; }
	public bool IsPublic { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsAbstract { get; }
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x18C7130 Offset: 0x18C6530 VA: 0x1818C7130
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18C7680 Offset: 0x18C6A80 VA: 0x1818C7680
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x18C78D0 Offset: 0x18C6CD0 VA: 0x1818C78D0
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x18C6790 Offset: 0x18C5B90 VA: 0x1818C6790 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10B2C20 Offset: 0x10B2020 VA: 0x1810B2C20 Slot: 17
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 23
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18C6FF0 Offset: 0x18C63F0 VA: 0x1818C6FF0 Slot: 24
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 25
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 26
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x18C75F0 Offset: 0x18C69F0 VA: 0x1818C75F0 Slot: 28
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18C74A0 Offset: 0x18C68A0 VA: 0x1818C74A0 Slot: 29
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x18C75C0 Offset: 0x18C69C0 VA: 0x1818C75C0 Slot: 30
	public bool get_IsPublic() { }

	// RVA: 0x18C7640 Offset: 0x18C6A40 VA: 0x1818C7640 Slot: 31
	public bool get_IsStatic() { }

	// RVA: 0x18C7660 Offset: 0x18C6A60 VA: 0x1818C7660 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x18C74E0 Offset: 0x18C68E0 VA: 0x1818C74E0 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x18C7510 Offset: 0x18C6910 VA: 0x1818C7510 Slot: 34
	public bool get_IsConstructor() { }

	// RVA: 0x18C7070 Offset: 0x18C6470 VA: 0x1818C7070 Slot: 35
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x18C6D10 Offset: 0x18C6110 VA: 0x1818C6D10
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x18C6EE0 Offset: 0x18C62E0 VA: 0x1818C6EE0 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18C7340 Offset: 0x18C6740 VA: 0x1818C7340 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x10B2C20 Offset: 0x10B2020 VA: 0x1810B2C20 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18C7470 Offset: 0x18C6870 VA: 0x1818C7470 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x18C70F0 Offset: 0x18C64F0 VA: 0x1818C70F0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x18C70E0 Offset: 0x18C64E0 VA: 0x1818C70E0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x18C7060 Offset: 0x18C6460 VA: 0x1818C7060
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x18C7060 Offset: 0x18C6460 VA: 0x1818C7060
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x18C70C0 Offset: 0x18C64C0 VA: 0x1818C70C0
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x18C70D0 Offset: 0x18C64D0 VA: 0x1818C70D0
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

