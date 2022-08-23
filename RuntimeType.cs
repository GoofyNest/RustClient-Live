internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 292
{	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }


	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	private static void SplitName(string fullname, out string name, out string ns) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	internal void .ctor() { }

	internal bool IsSpecialSerializableType() { }

	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public override Module get_Module() { }

	internal RuntimeModule GetRuntimeModule() { }

	public override Assembly get_Assembly() { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	public override RuntimeTypeHandle get_TypeHandle() { }

	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override bool IsSubclassOf(Type type) { }

	public override bool IsAssignableFrom(Type c) { }

	public override bool IsEquivalentTo(Type other) { }

	public override Type get_BaseType() { }

	private RuntimeType GetBaseType() { }

	public override Type get_UnderlyingSystemType() { }

	protected override TypeAttributes GetAttributeFlagsImpl() { }

	protected override bool IsContextfulImpl() { }

	protected override bool IsByRefImpl() { }

	protected override bool IsPrimitiveImpl() { }

	protected override bool IsPointerImpl() { }

	protected override bool IsCOMObjectImpl() { }

	protected override bool IsValueTypeImpl() { }

	public override bool get_IsEnum() { }

	protected override bool HasElementTypeImpl() { }

	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	internal override bool get_IsSzArray() { }

	protected override bool IsArrayImpl() { }

	public override int GetArrayRank() { }

	public override Type GetElementType() { }

	public override string[] GetEnumNames() { }

	public override Array GetEnumValues() { }

	public override Type GetEnumUnderlyingType() { }

	public override bool IsEnumDefined(object value) { }

	public override string GetEnumName(object value) { }

	internal RuntimeType[] GetGenericArgumentsInternal() { }

	public override Type[] GetGenericArguments() { }

	public override Type MakeGenericType(Type[] instantiation) { }

	public override bool get_IsGenericTypeDefinition() { }

	public override bool get_IsGenericParameter() { }

	public override int get_GenericParameterPosition() { }

	public override Type GetGenericTypeDefinition() { }

	public override bool get_IsGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	public override bool Equals(object obj) { }

	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	public object Clone() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	internal override string FormatTypeName(bool serialization) { }

	public override MemberTypes get_MemberType() { }

	public override Type get_ReflectedType() { }

	public override int get_MetadataToken() { }

	private void CreateInstanceCheckThis() { }

	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	internal MonoCMethod GetDefaultConstructor() { }

	private string GetDefaultMemberName() { }

	internal RuntimeConstructorInfo GetSerializationCtor() { }

	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	private object CreateInstanceMono(bool nonPublic) { }

	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	private object TryConvertToType(object value, ref bool failed) { }

	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	private string GetCachedName(TypeNameKind kind) { }

	private Type make_array_type(int rank) { }

	public override Type MakeArrayType() { }

	public override Type MakeArrayType(int rank) { }

	private Type make_byref_type() { }

	public override Type MakeByRefType() { }

	private static Type MakePointerType(Type type) { }

	public override Type MakePointerType() { }

	public override bool get_ContainsGenericParameters() { }

	public override Type[] GetGenericParameterConstraints() { }

	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	private static Type MakeGenericType(Type gt, Type[] types) { }

	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	protected override TypeCode GetTypeCodeImpl() { }

	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	public override string ToString() { }

	private bool IsGenericCOMObjectImpl() { }

	private static object CreateInstanceInternal(Type type) { }

	public override MethodBase get_DeclaringMethod() { }

	internal string getFullName(bool full_name, bool assembly_qualified) { }

	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	private GenericParameterAttributes GetGenericParameterAttributes() { }

	private int GetGenericParameterPosition() { }

	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	public override Type[] GetInterfaces() { }

	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	public override string get_AssemblyQualifiedName() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override string get_Namespace() { }

	public override int GetHashCode() { }

	public override string get_FullName() { }

	private static void .cctor() { }

}

internal enum RuntimeType.MemberListType // TypeDefIndex: 293
{	public int value__; // 0x0
	public const RuntimeType.MemberListType All = 0;
	public const RuntimeType.MemberListType CaseSensitive = 1;
	public const RuntimeType.MemberListType CaseInsensitive = 2;
	public const RuntimeType.MemberListType HandleToInfo = 3;

}

private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 294
{	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	public T Item { get; }
	public int Count { get; }


	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>..ctor
	|-RuntimeType.ListBuilder<ConstructorInfo>..ctor
	|-RuntimeType.ListBuilder<EventInfo>..ctor
	|-RuntimeType.ListBuilder<FieldInfo>..ctor
	|-RuntimeType.ListBuilder<MethodInfo>..ctor
	|-RuntimeType.ListBuilder<PropertyInfo>..ctor
	|-RuntimeType.ListBuilder<Type>..ctor
	*/

	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>.ToArray
	|-RuntimeType.ListBuilder<ConstructorInfo>.ToArray
	|-RuntimeType.ListBuilder<EventInfo>.ToArray
	|-RuntimeType.ListBuilder<FieldInfo>.ToArray
	|-RuntimeType.ListBuilder<MethodInfo>.ToArray
	|-RuntimeType.ListBuilder<PropertyInfo>.ToArray
	|-RuntimeType.ListBuilder<Type>.ToArray
	*/

	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>.CopyTo
	|-RuntimeType.ListBuilder<ConstructorInfo>.CopyTo
	|-RuntimeType.ListBuilder<EventInfo>.CopyTo
	|-RuntimeType.ListBuilder<FieldInfo>.CopyTo
	|-RuntimeType.ListBuilder<MethodInfo>.CopyTo
	|-RuntimeType.ListBuilder<PropertyInfo>.CopyTo
	|-RuntimeType.ListBuilder<Type>.CopyTo
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>.get_Count
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Count
	|-RuntimeType.ListBuilder<EventInfo>.get_Count
	|-RuntimeType.ListBuilder<FieldInfo>.get_Count
	|-RuntimeType.ListBuilder<MethodInfo>.get_Count
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Count
	|-RuntimeType.ListBuilder<Type>.get_Count
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/

}

