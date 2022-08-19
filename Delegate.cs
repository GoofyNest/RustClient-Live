public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 356
{	// Fields
	private IntPtr method_ptr; // 0x10
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

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x829900 Offset: 0x828D00 VA: 0x180829900
	public MethodInfo get_Method() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public object get_Target() { }

	// RVA: 0xD6C500 Offset: 0xD6B900 VA: 0x180D6C500
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0xD6E0A0 Offset: 0xD6D4A0 VA: 0x180D6E0A0
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0xD6E250 Offset: 0xD6D650 VA: 0x180D6E250
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0xD6E410 Offset: 0xD6D810 VA: 0x180D6E410
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0xD6C510 Offset: 0xD6B910 VA: 0x180D6C510
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD6C630 Offset: 0xD6BA30 VA: 0x180D6C630
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0xD6C530 Offset: 0xD6B930 VA: 0x180D6C530
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD6D2E0 Offset: 0xD6C6E0 VA: 0x180D6D2E0
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD6D2B0 Offset: 0xD6C6B0 VA: 0x180D6D2B0
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0xD6C550 Offset: 0xD6B950 VA: 0x180D6C550
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0xD6D5F0 Offset: 0xD6C9F0 VA: 0x180D6D5F0
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD6D310 Offset: 0xD6C710 VA: 0x180D6D310
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD6D1B0 Offset: 0xD6C5B0 VA: 0x180D6D1B0
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0xD6D0B0 Offset: 0xD6C4B0 VA: 0x180D6D0B0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD6CFC0 Offset: 0xD6C3C0 VA: 0x180D6CFC0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 6
	public virtual object Clone() { }

	// RVA: 0xD6D430 Offset: 0xD6C830 VA: 0x180D6D430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD6DA30 Offset: 0xD6CE30 VA: 0x180D6DA30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xD6DB70 Offset: 0xD6CF70 VA: 0x180D6DB70 Slot: 7
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0xD6DC60 Offset: 0xD6D060 VA: 0x180D6DC60 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD6DAC0 Offset: 0xD6CEC0 VA: 0x180D6DAC0 Slot: 9
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0xD6C320 Offset: 0xD6B720 VA: 0x180D6C320
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0xD6C100 Offset: 0xD6B500 VA: 0x180D6C100
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0xD6C090 Offset: 0xD6B490 VA: 0x180D6C090 Slot: 10
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0xD6DED0 Offset: 0xD6D2D0 VA: 0x180D6DED0
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0xD6DEA0 Offset: 0xD6D2A0 VA: 0x180D6DEA0 Slot: 11
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0xD6E3E0 Offset: 0xD6D7E0 VA: 0x180D6E3E0
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0xD6C4F0 Offset: 0xD6B8F0 VA: 0x180D6C4F0
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD6C070 Offset: 0xD6B470 VA: 0x180D6C070
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

}

