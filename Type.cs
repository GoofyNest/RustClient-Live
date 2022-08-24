public abstract class Type : MemberInfo, _Type // TypeDefIndex: 322
{
	public static readonly MemberFilter FilterAttribute; 
	public static readonly MemberFilter FilterName; 
	public static readonly MemberFilter FilterNameIgnoreCase; 
	public static readonly object Missing; 
	public static readonly char Delimiter; 
	public static readonly Type[] EmptyTypes; 
	private static Binder defaultBinder; 
private const BindingFlags DefaultLookup = 28;
internal const BindingFlags DeclaredOnlyLookup = 62;
	internal RuntimeTypeHandle _impl; 

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


protected void .ctor() { }

public override MemberTypes get_MemberType() { }

public override Type get_DeclaringType() { }

public virtual MethodBase get_DeclaringMethod() { }

public override Type get_ReflectedType() { }

public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

public virtual Type MakePointerType() { }

public virtual Type MakeByRefType() { }

public virtual Type MakeArrayType() { }

public virtual Type MakeArrayType(int rank) { }

public static TypeCode GetTypeCode(Type type) { }

protected virtual TypeCode GetTypeCodeImpl() { }

public static Binder get_DefaultBinder() { }

private static void CreateBinder() { }

public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

public abstract override Module get_Module();

public abstract Assembly get_Assembly();

public virtual RuntimeTypeHandle get_TypeHandle() { }

public static RuntimeTypeHandle GetTypeHandle(object o) { }

public abstract string get_FullName();

public abstract string get_Namespace();

public abstract string get_AssemblyQualifiedName();

public virtual int GetArrayRank() { }

public abstract Type get_BaseType();

	[ComVisibleAttribute] 
public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] 
public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] 
public ConstructorInfo GetConstructor(Type[] types) { }

protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] 
public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] 
public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

public MethodInfo GetMethod(string name, Type[] types) { }

public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

public MethodInfo GetMethod(string name) { }

protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

public MethodInfo[] GetMethods() { }

public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

public FieldInfo GetField(string name) { }

public FieldInfo[] GetFields() { }

public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

public abstract Type[] GetInterfaces();

public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

public PropertyInfo GetProperty(string name, Type returnType) { }

public PropertyInfo GetProperty(string name) { }

protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

public PropertyInfo[] GetProperties() { }

public Type GetNestedType(string name) { }

public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

public MemberInfo[] GetMember(string name) { }

public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

public bool get_IsNested() { }

public TypeAttributes get_Attributes() { }

public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

public bool get_IsVisible() { }

public bool get_IsNotPublic() { }

public bool get_IsPublic() { }

public bool get_IsNestedPublic() { }

public bool get_IsNestedAssembly() { }

public bool get_IsExplicitLayout() { }

public bool get_IsClass() { }

public bool get_IsInterface() { }

public bool get_IsValueType() { }

public bool get_IsAbstract() { }

public bool get_IsSealed() { }

public virtual bool get_IsEnum() { }

public virtual bool get_IsSerializable() { }

public bool get_IsArray() { }

internal virtual bool get_IsSzArray() { }

public virtual bool get_IsGenericType() { }

public virtual bool get_IsGenericTypeDefinition() { }

public virtual bool get_IsGenericParameter() { }

public virtual int get_GenericParameterPosition() { }

public virtual bool get_ContainsGenericParameters() { }

public virtual Type[] GetGenericParameterConstraints() { }

public bool get_IsByRef() { }

public bool get_IsPointer() { }

public bool get_IsPrimitive() { }

public bool get_IsCOMObject() { }

public bool get_HasElementType() { }

public bool get_IsContextful() { }

public bool get_IsMarshalByRef() { }

protected virtual bool IsValueTypeImpl() { }

protected abstract TypeAttributes GetAttributeFlagsImpl();

protected abstract bool IsArrayImpl();

protected abstract bool IsByRefImpl();

protected abstract bool IsPointerImpl();

protected abstract bool IsPrimitiveImpl();

protected abstract bool IsCOMObjectImpl();

public virtual Type MakeGenericType(Type[] typeArguments) { }

protected virtual bool IsContextfulImpl() { }

protected virtual bool IsMarshalByRefImpl() { }

public abstract Type GetElementType();

public virtual Type[] GetGenericArguments() { }

public virtual Type GetGenericTypeDefinition() { }

protected abstract bool HasElementTypeImpl();

internal Type GetRootElementType() { }

public virtual string[] GetEnumNames() { }

public virtual Array GetEnumValues() { }

private Array GetEnumRawConstantValues() { }

private void GetEnumData(out string[] enumNames, out Array enumValues) { }

public virtual Type GetEnumUnderlyingType() { }

public virtual bool IsEnumDefined(object value) { }

public virtual string GetEnumName(object value) { }

private static int BinarySearch(Array array, object value) { }

internal static bool IsIntegerType(Type t) { }

public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] 
public virtual bool IsSubclassOf(Type c) { }

public virtual bool IsInstanceOfType(object o) { }

public virtual bool IsAssignableFrom(Type c) { }

public virtual bool IsEquivalentTo(Type other) { }

internal bool ImplementInterface(Type ifaceType) { }

internal string FormatTypeName() { }

internal virtual string FormatTypeName(bool serialization) { }

public override string ToString() { }

public override bool Equals(object o) { }

public virtual bool Equals(Type o) { }

public static bool op_Equality(Type left, Type right) { }

public static bool op_Inequality(Type left, Type right) { }

public override int GetHashCode() { }

public Type GetType() { }

private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

public static Type GetType(string typeName) { }

public static Type GetType(string typeName, bool throwOnError) { }

public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

private static Type internal_from_handle(IntPtr handle) { }

private static void .cctor() { }

}

