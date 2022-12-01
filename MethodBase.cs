public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 539
{
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
	[ComVisibleAttribute]
	public bool IsConstructor { get; }


	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	protected void .ctor() { }

	public static bool op_Equality(MethodBase left, MethodBase right) { }

	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	public abstract ParameterInfo[] GetParameters();

	public abstract MethodImplAttributes GetMethodImplementationFlags();

	public abstract RuntimeMethodHandle get_MethodHandle();

	public abstract MethodAttributes get_Attributes();

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute]
	public virtual Type[] GetGenericArguments() { }

	public virtual bool get_IsGenericMethodDefinition() { }

	public virtual bool get_ContainsGenericParameters() { }

	public virtual bool get_IsGenericMethod() { }

	public virtual bool get_IsSecurityCritical() { }

	[DebuggerStepThroughAttribute]
	[DebuggerHiddenAttribute]
	public object Invoke(object obj, object[] parameters) { }

	public bool get_IsPublic() { }

	public bool get_IsStatic() { }

	public bool get_IsVirtual() { }

	public bool get_IsAbstract() { }

	public bool get_IsConstructor() { }

	public virtual MethodBody GetMethodBody() { }

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	internal virtual string FormatNameAndSig(bool serialization) { }

	internal virtual Type[] GetParameterTypes() { }

	internal virtual ParameterInfo[] GetParametersInternal() { }

	internal virtual int GetParametersCount() { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	internal static MethodBody GetMethodBody(IntPtr handle) { }

	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

