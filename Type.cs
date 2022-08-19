public abstract class Type : MemberInfo, _Type // TypeDefIndex: 322
{	// Fields
	public static readonly MemberFilter FilterAttribute; // 0x0
	public static readonly MemberFilter FilterName; // 0x8
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly char Delimiter; // 0x20
	public static readonly Type[] EmptyTypes; // 0x28
	private static Binder defaultBinder; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal const BindingFlags DeclaredOnlyLookup = 62;
	internal RuntimeTypeHandle _impl; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public static Binder DefaultBinder { get; }
	public abstract override Module Module { get; }
	public abstract Assembly Assembly { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract string FullName { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract Type BaseType { get; }
	public bool IsNested { get; }
	public TypeAttributes Attributes { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public bool IsVisible { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsNestedPublic { get; }
	public bool IsNestedAssembly { get; }
	public bool IsExplicitLayout { get; }
	public bool IsClass { get; }
	public bool IsInterface { get; }
	public bool IsValueType { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public virtual bool IsEnum { get; }
	public virtual bool IsSerializable { get; }
	public bool IsArray { get; }
	internal virtual bool IsSzArray { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public bool IsPrimitive { get; }
	public bool IsCOMObject { get; }
	public bool HasElementType { get; }
	public bool IsContextful { get; }
	public bool IsMarshalByRef { get; }
	public abstract Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

	// RVA: 0xE84F20 Offset: 0xE84320 VA: 0x180E84F20 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x213D4F0 Offset: 0x213C8F0 VA: 0x18213D4F0
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x213E820 Offset: 0x213DC20 VA: 0x18213E820 Slot: 18
	public virtual Type MakePointerType() { }

	// RVA: 0x213E760 Offset: 0x213DB60 VA: 0x18213E760 Slot: 19
	public virtual Type MakeByRefType() { }

	// RVA: 0x213E6C0 Offset: 0x213DAC0 VA: 0x18213E6C0 Slot: 20
	public virtual Type MakeArrayType() { }

	// RVA: 0x213E710 Offset: 0x213DB10 VA: 0x18213E710 Slot: 21
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x213CF40 Offset: 0x213C340 VA: 0x18213CF40
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x213CDE0 Offset: 0x213C1E0 VA: 0x18213CDE0 Slot: 22
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: 0x213EC60 Offset: 0x213E060 VA: 0x18213EC60
	public static Binder get_DefaultBinder() { }

	// RVA: 0x213AD80 Offset: 0x213A180 VA: 0x18213AD80
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly();

	// RVA: 0x213F5A0 Offset: 0x213E9A0 VA: 0x18213F5A0 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x213D020 Offset: 0x213C420 VA: 0x18213D020
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x213B1F0 Offset: 0x213A5F0 VA: 0x18213B1F0 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x213B510 Offset: 0x213A910 VA: 0x18213B510 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x213B3B0 Offset: 0x213A7B0 VA: 0x18213B3B0 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x213B260 Offset: 0x213A660 VA: 0x18213B260 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x213B670 Offset: 0x213AA70 VA: 0x18213B670 Slot: 35
	public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x213C5C0 Offset: 0x213B9C0 VA: 0x18213C5C0 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x213C420 Offset: 0x213B820 VA: 0x18213C420 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x213C770 Offset: 0x213BB70 VA: 0x18213C770 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x213C820 Offset: 0x213BC20 VA: 0x18213C820 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x213C8D0 Offset: 0x213BCD0 VA: 0x18213C8D0 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: 0x213C130 Offset: 0x213B530 VA: 0x18213C130 Slot: 45
	public FieldInfo GetField(string name) { }

	// RVA: 0x213C150 Offset: 0x213B550 VA: 0x18213C150 Slot: 46
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: 0x213AF40 Offset: 0x213A340 VA: 0x18213AF40 Slot: 49
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x213C9D0 Offset: 0x213BDD0 VA: 0x18213C9D0 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x213CBC0 Offset: 0x213BFC0 VA: 0x18213CBC0 Slot: 52
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x213CAC0 Offset: 0x213BEC0 VA: 0x18213CAC0 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x213CC70 Offset: 0x213C070 VA: 0x18213CC70 Slot: 54
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x213C930 Offset: 0x213BD30 VA: 0x18213C930 Slot: 55
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x213C910 Offset: 0x213BD10 VA: 0x18213C910 Slot: 58
	public PropertyInfo[] GetProperties() { }

	// RVA: 0x213C8F0 Offset: 0x213BCF0 VA: 0x18213C8F0 Slot: 59
	public Type GetNestedType(string name) { }

	// RVA: -1 Offset: -1 Slot: 60
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x213C3D0 Offset: 0x213B7D0 VA: 0x18213C3D0 Slot: 61
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x213C3F0 Offset: 0x213B7F0 VA: 0x18213C3F0 Slot: 62
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x213C360 Offset: 0x213B760 VA: 0x18213C360 Slot: 63
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x213F180 Offset: 0x213E580 VA: 0x18213F180
	public bool get_IsNested() { }

	// RVA: 0x213EAE0 Offset: 0x213DEE0 VA: 0x18213EAE0 Slot: 64
	public TypeAttributes get_Attributes() { }

	// RVA: 0x213EDD0 Offset: 0x213E1D0 VA: 0x18213EDD0 Slot: 65
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x213F3B0 Offset: 0x213E7B0 VA: 0x18213F3B0
	public bool get_IsVisible() { }

	// RVA: 0x213F1F0 Offset: 0x213E5F0 VA: 0x18213F1F0 Slot: 66
	public bool get_IsNotPublic() { }

	// RVA: 0x213F250 Offset: 0x213E650 VA: 0x18213F250 Slot: 67
	public bool get_IsPublic() { }

	// RVA: 0x213F160 Offset: 0x213E560 VA: 0x18213F160 Slot: 68
	public bool get_IsNestedPublic() { }

	// RVA: 0x213F130 Offset: 0x213E530 VA: 0x18213F130 Slot: 69
	public bool get_IsNestedAssembly() { }

	// RVA: 0x213F020 Offset: 0x213E420 VA: 0x18213F020 Slot: 70
	public bool get_IsExplicitLayout() { }

	// RVA: 0x213EF40 Offset: 0x213E340 VA: 0x18213EF40 Slot: 71
	public bool get_IsClass() { }

	// RVA: 0x213F040 Offset: 0x213E440 VA: 0x18213F040 Slot: 72
	public bool get_IsInterface() { }

	// RVA: 0x213F390 Offset: 0x213E790 VA: 0x18213F390 Slot: 73
	public bool get_IsValueType() { }

	// RVA: 0x213EEB0 Offset: 0x213E2B0 VA: 0x18213EEB0 Slot: 74
	public bool get_IsAbstract() { }

	// RVA: 0x213F270 Offset: 0x213E670 VA: 0x18213F270 Slot: 75
	public bool get_IsSealed() { }

	// RVA: 0x213EFB0 Offset: 0x213E3B0 VA: 0x18213EFB0 Slot: 76
	public virtual bool get_IsEnum() { }

	// RVA: 0x213F2A0 Offset: 0x213E6A0 VA: 0x18213F2A0 Slot: 77
	public virtual bool get_IsSerializable() { }

	// RVA: 0x213EEE0 Offset: 0x213E2E0 VA: 0x18213EEE0 Slot: 78
	public bool get_IsArray() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 79
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 80
	public virtual bool get_IsGenericType() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 81
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 82
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x213EE20 Offset: 0x213E220 VA: 0x18213EE20 Slot: 83
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x213EB00 Offset: 0x213DF00 VA: 0x18213EB00 Slot: 84
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x213C1E0 Offset: 0x213B5E0 VA: 0x18213C1E0 Slot: 85
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x213EF00 Offset: 0x213E300 VA: 0x18213EF00 Slot: 86
	public bool get_IsByRef() { }

	// RVA: 0x213F210 Offset: 0x213E610 VA: 0x18213F210 Slot: 87
	public bool get_IsPointer() { }

	// RVA: 0x213F230 Offset: 0x213E630 VA: 0x18213F230 Slot: 88
	public bool get_IsPrimitive() { }

	// RVA: 0x213EF20 Offset: 0x213E320 VA: 0x18213EF20 Slot: 89
	public bool get_IsCOMObject() { }

	// RVA: 0x213EE90 Offset: 0x213E290 VA: 0x18213EE90 Slot: 90
	public bool get_HasElementType() { }

	// RVA: 0x213EF90 Offset: 0x213E390 VA: 0x18213EF90 Slot: 91
	public bool get_IsContextful() { }

	// RVA: 0x213F110 Offset: 0x213E510 VA: 0x18213F110 Slot: 92
	public bool get_IsMarshalByRef() { }

	// RVA: 0x213E650 Offset: 0x213DA50 VA: 0x18213E650 Slot: 93
	protected virtual bool IsValueTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 94
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	// RVA: -1 Offset: -1 Slot: 95
	protected abstract bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 96
	protected abstract bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 97
	protected abstract bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 98
	protected abstract bool IsPrimitiveImpl();

	// RVA: -1 Offset: -1 Slot: 99
	protected abstract bool IsCOMObjectImpl();

	// RVA: 0x213E7B0 Offset: 0x213DBB0 VA: 0x18213E7B0 Slot: 100
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x213DA50 Offset: 0x213CE50 VA: 0x18213DA50 Slot: 101
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x213E4B0 Offset: 0x213D8B0 VA: 0x18213E4B0 Slot: 102
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetElementType();

	// RVA: 0x213C170 Offset: 0x213B570 VA: 0x18213C170 Slot: 104
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x213C290 Offset: 0x213B690 VA: 0x18213C290 Slot: 105
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x213CD80 Offset: 0x213C180 VA: 0x18213CD80
	internal Type GetRootElementType() { }

	// RVA: 0x213BE60 Offset: 0x213B260 VA: 0x18213BE60 Slot: 107
	public virtual string[] GetEnumNames() { }

	// RVA: 0x213C070 Offset: 0x213B470 VA: 0x18213C070 Slot: 108
	public virtual Array GetEnumValues() { }

	// RVA: 0x213BF20 Offset: 0x213B320 VA: 0x18213BF20
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x213B690 Offset: 0x213AA90 VA: 0x18213B690
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x213BF50 Offset: 0x213B350 VA: 0x18213BF50 Slot: 109
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x213DB20 Offset: 0x213CF20 VA: 0x18213DB20 Slot: 110
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x213BB40 Offset: 0x213AF40 VA: 0x18213BB40 Slot: 111
	public virtual string GetEnumName(object value) { }

	// RVA: 0x213AC50 Offset: 0x213A050 VA: 0x18213AC50
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x213E1F0 Offset: 0x213D5F0 VA: 0x18213E1F0
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x213E580 Offset: 0x213D980 VA: 0x18213E580 Slot: 113
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x213E1B0 Offset: 0x213D5B0 VA: 0x18213E1B0 Slot: 114
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x213D7B0 Offset: 0x213CBB0 VA: 0x18213D7B0 Slot: 115
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x213E150 Offset: 0x213D550 VA: 0x18213E150 Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x213D610 Offset: 0x213CA10 VA: 0x18213D610
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x213B180 Offset: 0x213A580 VA: 0x18213B180
	internal string FormatTypeName() { }

	// RVA: 0x213B1A0 Offset: 0x213A5A0 VA: 0x18213B1A0 Slot: 117
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x213E870 Offset: 0x213DC70 VA: 0x18213E870 Slot: 3
	public override string ToString() { }

	// RVA: 0x213AEB0 Offset: 0x213A2B0 VA: 0x18213AEB0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x213AE50 Offset: 0x213A250 VA: 0x18213AE50 Slot: 118
	public virtual bool Equals(Type o) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x129EBD0 Offset: 0x129DFD0 VA: 0x18129EBD0
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x213C300 Offset: 0x213B700 VA: 0x18213C300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10D7550 Offset: 0x10D6950 VA: 0x1810D7550 Slot: 119
	public Type GetType() { }

	// RVA: 0x213F600 Offset: 0x213EA00 VA: 0x18213F600
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213D330 Offset: 0x213C730 VA: 0x18213D330
	public static Type GetType(string typeName) { }

	// RVA: 0x213D2A0 Offset: 0x213C6A0 VA: 0x18213D2A0
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x213D110 Offset: 0x213C510 VA: 0x18213D110
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213CFB0 Offset: 0x213C3B0 VA: 0x18213CFB0
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x213F5F0 Offset: 0x213E9F0 VA: 0x18213F5F0
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x213E8C0 Offset: 0x213DCC0 VA: 0x18213E8C0
	private static void .cctor() { }

}

