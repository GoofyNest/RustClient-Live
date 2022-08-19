internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 292
{	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x129DFD0 Offset: 0x129D3D0 VA: 0x18129DFD0
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x129DC90 Offset: 0x129D090 VA: 0x18129DC90
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x129DED0 Offset: 0x129D2D0 VA: 0x18129DED0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1295A30 Offset: 0x1294E30 VA: 0x181295A30
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1295B70 Offset: 0x1294F70 VA: 0x181295B70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1295890 Offset: 0x1294C90 VA: 0x181295890
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1295230 Offset: 0x1294630 VA: 0x181295230
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1295910 Offset: 0x1294D10 VA: 0x181295910
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x12957E0 Offset: 0x1294BE0 VA: 0x1812957E0
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1295470 Offset: 0x1294870 VA: 0x181295470
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1295520 Offset: 0x1294920 VA: 0x181295520
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129E6D0 Offset: 0x129DAD0 VA: 0x18129E6D0
	internal void .ctor() { }

	// RVA: 0x129D2F0 Offset: 0x129C6F0 VA: 0x18129D2F0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x1298CB0 Offset: 0x12980B0 VA: 0x181298CB0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1296150 Offset: 0x1295550 VA: 0x181296150
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129A310 Offset: 0x1299710 VA: 0x18129A310
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x12973D0 Offset: 0x12967D0 VA: 0x1812973D0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1297B70 Offset: 0x1296F70 VA: 0x181297B70
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1299560 Offset: 0x1298960 VA: 0x181299560
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x12994D0 Offset: 0x12988D0 VA: 0x1812994D0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x1296910 Offset: 0x1295D10 VA: 0x181296910 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x129A290 Offset: 0x1299690 VA: 0x18129A290 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x12984D0 Offset: 0x12978D0 VA: 0x1812984D0 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1298F40 Offset: 0x1298340 VA: 0x181298F40 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x12964B0 Offset: 0x12958B0 VA: 0x1812964B0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129A5E0 Offset: 0x12999E0 VA: 0x18129A5E0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1297640 Offset: 0x1296A40 VA: 0x181297640 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1297DE0 Offset: 0x12971E0 VA: 0x181297DE0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1299870 Offset: 0x1298C70 VA: 0x181299870 Slot: 60
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1298910 Offset: 0x1297D10 VA: 0x181298910 Slot: 63
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x1293C20 Offset: 0x1293020 VA: 0x181293C20 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x1293C20 Offset: 0x1293020 VA: 0x181293C20
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1293BB0 Offset: 0x1292FB0 VA: 0x181293BB0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x1293BB0 Offset: 0x1292FB0 VA: 0x181293BB0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x691430 Offset: 0x690830 VA: 0x180691430 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1293F60 Offset: 0x1293360 VA: 0x181293F60 Slot: 114
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x129D3D0 Offset: 0x129C7D0 VA: 0x18129D3D0 Slot: 113
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x129BE90 Offset: 0x129B290 VA: 0x18129BE90 Slot: 115
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x129D230 Offset: 0x129C630 VA: 0x18129D230 Slot: 116
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x129E750 Offset: 0x129DB50 VA: 0x18129E750 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x1295EA0 Offset: 0x12952A0 VA: 0x181295EA0
	private RuntimeType GetBaseType() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1293BC0 Offset: 0x1292FC0 VA: 0x181293BC0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1293EB0 Offset: 0x12932B0 VA: 0x181293EB0 Slot: 101
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1293E90 Offset: 0x1293290 VA: 0x181293E90 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x1293FA0 Offset: 0x12933A0 VA: 0x181293FA0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1293F90 Offset: 0x1293390 VA: 0x181293F90 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x129D560 Offset: 0x129C960 VA: 0x18129D560 Slot: 93
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x129EAE0 Offset: 0x129DEE0 VA: 0x18129EAE0 Slot: 76
	public override bool get_IsEnum() { }

	// RVA: 0x1293E20 Offset: 0x1293220 VA: 0x181293E20 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x129E990 Offset: 0x129DD90 VA: 0x18129E990 Slot: 65
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1293FB0 Offset: 0x12933B0 VA: 0x181293FB0 Slot: 79
	internal override bool get_IsSzArray() { }

	// RVA: 0x1293E80 Offset: 0x1293280 VA: 0x181293E80 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x1295E10 Offset: 0x1295210 VA: 0x181295E10 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1293BE0 Offset: 0x1292FE0 VA: 0x181293BE0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x1297070 Offset: 0x1296470 VA: 0x181297070 Slot: 107
	public override string[] GetEnumNames() { }

	// RVA: 0x1297220 Offset: 0x1296620 VA: 0x181297220 Slot: 108
	public override Array GetEnumValues() { }

	// RVA: 0x1297160 Offset: 0x1296560 VA: 0x181297160 Slot: 109
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x129CCB0 Offset: 0x129C0B0 VA: 0x18129CCB0 Slot: 110
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1296E90 Offset: 0x1296290 VA: 0x181296E90 Slot: 111
	public override string GetEnumName(object value) { }

	// RVA: 0x1298560 Offset: 0x1297960 VA: 0x181298560
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x12985E0 Offset: 0x12979E0 VA: 0x1812985E0 Slot: 104
	public override Type[] GetGenericArguments() { }

	// RVA: 0x129D780 Offset: 0x129CB80 VA: 0x18129D780 Slot: 100
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1293F40 Offset: 0x1293340 VA: 0x181293F40 Slot: 81
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1293F50 Offset: 0x1293350 VA: 0x181293F50 Slot: 82
	public override bool get_IsGenericParameter() { }

	// RVA: 0x129EA50 Offset: 0x129DE50 VA: 0x18129EA50 Slot: 83
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1298790 Offset: 0x1297B90 VA: 0x181298790 Slot: 105
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1293E60 Offset: 0x1293260 VA: 0x181293E60 Slot: 80
	public override bool get_IsGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x129AAC0 Offset: 0x1299EC0 VA: 0x18129AAC0 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x129EBD0 Offset: 0x129DFD0 VA: 0x18129EBD0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 123
	public object Clone() { }

	// RVA: 0x1299F20 Offset: 0x1299320 VA: 0x181299F20 Slot: 122
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12969C0 Offset: 0x1295DC0 VA: 0x1812969C0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1296A70 Offset: 0x1295E70 VA: 0x181296A70 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x129CB40 Offset: 0x129BF40 VA: 0x18129CB40 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x12969B0 Offset: 0x1295DB0 VA: 0x1812969B0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1295C70 Offset: 0x1295070 VA: 0x181295C70 Slot: 117
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x129EB50 Offset: 0x129DF50 VA: 0x18129EB50 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x4BF560 Offset: 0x4BE960 VA: 0x1804BF560 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1293C10 Offset: 0x1293010 VA: 0x181293C10 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1294230 Offset: 0x1293630 VA: 0x181294230
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1294710 Offset: 0x1293B10 VA: 0x181294710
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1294470 Offset: 0x1293870 VA: 0x181294470
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x1296BE0 Offset: 0x1295FE0 VA: 0x181296BE0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1296DB0 Offset: 0x12961B0 VA: 0x181296DB0
	private string GetDefaultMemberName() { }

	// RVA: 0x129A850 Offset: 0x1299C50 VA: 0x18129A850
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x12951F0 Offset: 0x12945F0 VA: 0x1812951F0
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x1294F20 Offset: 0x1294320 VA: 0x181294F20
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x1294030 Offset: 0x1293430 VA: 0x181294030
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x129E120 Offset: 0x129D520 VA: 0x18129E120
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x129BF70 Offset: 0x129B370 VA: 0x18129BF70
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x12960D0 Offset: 0x12954D0 VA: 0x1812960D0
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x129EBB0 Offset: 0x129DFB0 VA: 0x18129EBB0
	private Type make_array_type(int rank) { }

	// RVA: 0x129D670 Offset: 0x129CA70 VA: 0x18129D670 Slot: 20
	public override Type MakeArrayType() { }

	// RVA: 0x129D680 Offset: 0x129CA80 VA: 0x18129D680 Slot: 21
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x129EBC0 Offset: 0x129DFC0 VA: 0x18129EBC0
	private Type make_byref_type() { }

	// RVA: 0x129D700 Offset: 0x129CB00 VA: 0x18129D700 Slot: 19
	public override Type MakeByRefType() { }

	// RVA: 0x129DC80 Offset: 0x129D080 VA: 0x18129DC80
	private static Type MakePointerType(Type type) { }

	// RVA: 0x129DC30 Offset: 0x129D030 VA: 0x18129DC30 Slot: 18
	public override Type MakePointerType() { }

	// RVA: 0x129E760 Offset: 0x129DB60 VA: 0x18129E760 Slot: 84
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x1298690 Offset: 0x1297A90 VA: 0x181298690 Slot: 85
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1294580 Offset: 0x1293980 VA: 0x181294580
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x129D770 Offset: 0x129CB70 VA: 0x18129D770
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x12994C0 Offset: 0x12988C0 VA: 0x1812994C0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x12991E0 Offset: 0x12985E0 VA: 0x1812991E0
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x129A280 Offset: 0x1299680 VA: 0x18129A280
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x12969A0 Offset: 0x1295DA0 VA: 0x1812969A0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x12966B0 Offset: 0x1295AB0 VA: 0x1812966B0
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1299FA0 Offset: 0x12993A0 VA: 0x181299FA0
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x129AA70 Offset: 0x1299E70 VA: 0x18129AA70 Slot: 22
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x129AA60 Offset: 0x1299E60 VA: 0x18129AA60
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x129E110 Offset: 0x129D510 VA: 0x18129E110 Slot: 3
	public override string ToString() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x1294F10 Offset: 0x1294310 VA: 0x181294F10
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90 Slot: 17
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x129E730 Offset: 0x129DB30 VA: 0x18129E730
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x12985D0 Offset: 0x12979D0 VA: 0x1812985D0
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1298650 Offset: 0x1297A50 VA: 0x181298650
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1298780 Offset: 0x1297B80 VA: 0x181298780
	private int GetGenericParameterPosition() { }

	// RVA: 0x1297B60 Offset: 0x1296F60 VA: 0x181297B60
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1298550 Offset: 0x1297950 VA: 0x181298550
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1298200 Offset: 0x1297600 VA: 0x181298200
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1297890 Offset: 0x1296C90 VA: 0x181297890
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1298900 Offset: 0x1297D00 VA: 0x181298900 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x1299F10 Offset: 0x1299310 VA: 0x181299F10
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1299BE0 Offset: 0x1298FE0 VA: 0x181299BE0
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x129E740 Offset: 0x129DB40 VA: 0x18129E740 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x129E880 Offset: 0x129DC80 VA: 0x18129E880 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x129EB90 Offset: 0x129DF90 VA: 0x18129EB90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x129EBA0 Offset: 0x129DFA0 VA: 0x18129EBA0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x1298820 Offset: 0x1297C20 VA: 0x181298820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x129E890 Offset: 0x129DC90 VA: 0x18129E890 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x129E3B0 Offset: 0x129D7B0 VA: 0x18129E3B0
	private static void .cctor() { }

}

internal enum RuntimeType.MemberListType // TypeDefIndex: 293
{	// Fields
	public int value__; // 0x0
	public const RuntimeType.MemberListType All = 0;
	public const RuntimeType.MemberListType CaseSensitive = 1;
	public const RuntimeType.MemberListType CaseInsensitive = 2;
	public const RuntimeType.MemberListType HandleToInfo = 3;

}

private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 294
{	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E33B0 Offset: 0x1E27B0 VA: 0x1801E33B0
	|-RuntimeType.ListBuilder<object>..ctor
	|-RuntimeType.ListBuilder<ConstructorInfo>..ctor
	|-RuntimeType.ListBuilder<EventInfo>..ctor
	|-RuntimeType.ListBuilder<FieldInfo>..ctor
	|-RuntimeType.ListBuilder<MethodInfo>..ctor
	|-RuntimeType.ListBuilder<PropertyInfo>..ctor
	|-RuntimeType.ListBuilder<Type>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E33F0 Offset: 0x1E27F0 VA: 0x1801E33F0
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E33A0 Offset: 0x1E27A0 VA: 0x1801E33A0
	|-RuntimeType.ListBuilder<object>.ToArray
	|-RuntimeType.ListBuilder<ConstructorInfo>.ToArray
	|-RuntimeType.ListBuilder<EventInfo>.ToArray
	|-RuntimeType.ListBuilder<FieldInfo>.ToArray
	|-RuntimeType.ListBuilder<MethodInfo>.ToArray
	|-RuntimeType.ListBuilder<PropertyInfo>.ToArray
	|-RuntimeType.ListBuilder<Type>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32E0 Offset: 0x1E26E0 VA: 0x1801E32E0
	|-RuntimeType.ListBuilder<object>.CopyTo
	|-RuntimeType.ListBuilder<ConstructorInfo>.CopyTo
	|-RuntimeType.ListBuilder<EventInfo>.CopyTo
	|-RuntimeType.ListBuilder<FieldInfo>.CopyTo
	|-RuntimeType.ListBuilder<MethodInfo>.CopyTo
	|-RuntimeType.ListBuilder<PropertyInfo>.CopyTo
	|-RuntimeType.ListBuilder<Type>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	|-RuntimeType.ListBuilder<object>.get_Count
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Count
	|-RuntimeType.ListBuilder<EventInfo>.get_Count
	|-RuntimeType.ListBuilder<FieldInfo>.get_Count
	|-RuntimeType.ListBuilder<MethodInfo>.get_Count
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Count
	|-RuntimeType.ListBuilder<Type>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32D0 Offset: 0x1E26D0 VA: 0x1801E32D0
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/

}

