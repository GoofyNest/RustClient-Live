public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 356
{	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private MethodInfo method_info; // 0x48
	private MethodInfo original_method_info; // 0x50
	private DelegateData data; // 0x58
	private bool method_is_virtual; // 0x60

	public MethodInfo Method { get; }
	public object Target { get; }


	public MethodInfo get_Method() { }

	private MethodInfo GetVirtualMethod_internal() { }

	public object get_Target() { }

	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	private static bool arg_type_match(Type delArgType, Type argType) { }

	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	private static bool return_type_match(Type delReturnType, Type returnType) { }

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	public static Delegate CreateDelegate(Type type, object target, string method) { }

	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	public virtual object Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	protected virtual MethodInfo GetMethodImpl() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual Delegate[] GetInvocationList() { }

	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static Delegate Combine(Delegate[] delegates) { }

	protected virtual Delegate CombineImpl(Delegate d) { }

	public static Delegate Remove(Delegate source, Delegate value) { }

	protected virtual Delegate RemoveImpl(Delegate d) { }

	public static bool op_Equality(Delegate d1, Delegate d2) { }

	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

}

