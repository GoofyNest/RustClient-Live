internal struct MonoAssemblyName // TypeDefIndex: 19
{	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBufferAttribute] // RVA: 0xE6D30 Offset: 0xE6130 VA: 0x1800E6D30
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48

}

public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 20
{	// Fields
	public byte FixedElementField; // 0x0

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 139
{	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string comment) { }

}

internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 140
{	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string comment) { }

}

internal class MonoTypeInfo // TypeDefIndex: 344
{	// Fields
	public string full_name; // 0x10
	public MonoCMethod default_ctor; // 0x18

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void .ctor() { }

}

internal class MonoAsyncCall // TypeDefIndex: 372
{	// Fields
	private object msg; // 0x10
	private IntPtr cb_method; // 0x18
	private object cb_target; // 0x20
	private object state; // 0x28
	private object res; // 0x30
	private object out_args; // 0x38

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void .ctor() { }

}

internal static class MonoCustomAttrs // TypeDefIndex: 373
{	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x16733E0 Offset: 0x16727E0 VA: 0x1816733E0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x1671E60 Offset: 0x1671260 VA: 0x181671E60
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x1672A90 Offset: 0x1671E90 VA: 0x181672A90
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x1672F60 Offset: 0x1672360 VA: 0x181672F60
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x1671BD0 Offset: 0x1670FD0 VA: 0x181671BD0
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x1671E70 Offset: 0x1671270 VA: 0x181671E70
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1672920 Offset: 0x1671D20 VA: 0x181672920
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x1671DB0 Offset: 0x16711B0 VA: 0x181671DB0
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x1671DC0 Offset: 0x16711C0 VA: 0x181671DC0
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x1673110 Offset: 0x1672510 VA: 0x181673110
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1673100 Offset: 0x1672500 VA: 0x181673100
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x16715A0 Offset: 0x16709A0 VA: 0x1816715A0
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x16713D0 Offset: 0x16707D0 VA: 0x1816713D0
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x16718B0 Offset: 0x1670CB0 VA: 0x1816718B0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x1673620 Offset: 0x1672A20 VA: 0x181673620
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x1673890 Offset: 0x1672C90 VA: 0x181673890
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x1673A00 Offset: 0x1672E00 VA: 0x181673A00
	private static void .cctor() { }

}

private class MonoCustomAttrs.AttributeInfo // TypeDefIndex: 374
{	// Fields
	private AttributeUsageAttribute _usage; // 0x10
	private int _inheritanceLevel; // 0x18

	// Properties
	public AttributeUsageAttribute Usage { get; }
	public int InheritanceLevel { get; }

	// Methods

	// RVA: 0x166BC00 Offset: 0x166B000 VA: 0x18166BC00
	public void .ctor(AttributeUsageAttribute usage, int inheritanceLevel) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public AttributeUsageAttribute get_Usage() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_InheritanceLevel() { }

}

internal sealed class MonoListItem // TypeDefIndex: 375
{	// Fields
	private MonoListItem next; // 0x10
	private object data; // 0x18

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void .ctor() { }

}

internal class MonoAssembly : RuntimeAssembly // TypeDefIndex: 573
{	// Methods

	// RVA: 0x18C8880 Offset: 0x18C7C80 VA: 0x1818C8880 Slot: 27
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C8610 Offset: 0x18C7A10 VA: 0x1818C8610 Slot: 28
	public override Module GetModule(string name) { }

	// RVA: 0x18C8870 Offset: 0x18C7C70 VA: 0x1818C8870 Slot: 29
	public override AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18C8760 Offset: 0x18C7B60 VA: 0x1818C8760 Slot: 30
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C10E0 Offset: 0x18C04E0 VA: 0x1818C10E0
	public void .ctor() { }

}

internal struct MonoEventInfo // TypeDefIndex: 574
{	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38

	// Methods

	// RVA: 0x18C9280 Offset: 0x18C8680 VA: 0x1818C9280
	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	// RVA: 0x18C9240 Offset: 0x18C8640 VA: 0x1818C9240
	internal static MonoEventInfo GetEventInfo(MonoEvent ev) { }

}

internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 576
{	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18C9290 Offset: 0x18C8690 VA: 0x1818C9290 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x18C9410 Offset: 0x18C8810 VA: 0x1818C9410 Slot: 19
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x18C94A0 Offset: 0x18C88A0 VA: 0x1818C94A0 Slot: 20
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x18C9630 Offset: 0x18C8A30 VA: 0x1818C9630 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C9690 Offset: 0x18C8A90 VA: 0x1818C9690 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C9660 Offset: 0x18C8A60 VA: 0x1818C9660 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C95B0 Offset: 0x18C89B0 VA: 0x1818C95B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C9530 Offset: 0x18C8930 VA: 0x1818C9530 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C93A0 Offset: 0x18C87A0 VA: 0x1818C93A0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C9320 Offset: 0x18C8720 VA: 0x1818C9320 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class MonoField : RtFieldInfo // TypeDefIndex: 579
{	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private Type ResolveType() { }

	// RVA: 0x18C9E00 Offset: 0x18C9200 VA: 0x1818C9E00 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C9860 Offset: 0x18C8C60 VA: 0x1818C9860
	private Type GetParentType(bool declaring) { }

	// RVA: 0x18C9E90 Offset: 0x18C9290 VA: 0x1818C9E90 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C9DF0 Offset: 0x18C91F0 VA: 0x1818C9DF0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C9A20 Offset: 0x18C8E20 VA: 0x1818C9A20 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C97E0 Offset: 0x18C8BE0 VA: 0x1818C97E0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C9760 Offset: 0x18C8B60 VA: 0x1818C9760 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9850 Offset: 0x18C8C50 VA: 0x1818C9850 Slot: 29
	internal override int GetFieldOffset() { }

	// RVA: 0x18C9880 Offset: 0x18C8C80 VA: 0x1818C9880
	private object GetValueInternal(object obj) { }

	// RVA: 0x18C9890 Offset: 0x18C8C90 VA: 0x1818C9890 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C9D90 Offset: 0x18C9190 VA: 0x1818C9D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1293800 Offset: 0x1292C00 VA: 0x181293800
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x18C9AA0 Offset: 0x18C8EA0 VA: 0x1818C9AA0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x18C9870 Offset: 0x18C8C70 VA: 0x1818C9870 Slot: 31
	public override object GetRawConstantValue() { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18C96C0 Offset: 0x18C8AC0 VA: 0x1818C96C0
	private void CheckGeneric() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal struct MonoMethodInfo // TypeDefIndex: 580
{	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x18C9FB0 Offset: 0x18C93B0 VA: 0x1818C9FB0
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x18C9EA0 Offset: 0x18C92A0 VA: 0x1818C9EA0
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x18C9F40 Offset: 0x18C9340 VA: 0x1818C9F40
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x18C9EE0 Offset: 0x18C92E0 VA: 0x1818C9EE0
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x18C9F80 Offset: 0x18C9380 VA: 0x1818C9F80
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x18C9EA0 Offset: 0x18C92A0 VA: 0x1818C9EA0
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x18C9EB0 Offset: 0x18C92B0 VA: 0x1818C9EB0
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x18C9F10 Offset: 0x18C9310 VA: 0x1818C9F10
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x18C9F70 Offset: 0x18C9370 VA: 0x1818C9F70
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x18C9F70 Offset: 0x18C9370 VA: 0x1818C9F70
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

}

internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 582
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x18CADD0 Offset: 0x18CA1D0 VA: 0x1818CADD0
	internal static string get_name(MethodBase method) { }

	// RVA: 0x18CADC0 Offset: 0x18CA1C0 VA: 0x1818CADC0
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x18CA2F0 Offset: 0x18C96F0 VA: 0x1818CA2F0 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CA300 Offset: 0x18C9700 VA: 0x1818CA300 Slot: 45
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x18CAD90 Offset: 0x18CA190 VA: 0x1818CAD90 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x18C8C30 Offset: 0x18C8030 VA: 0x1818C8C30 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CA4F0 Offset: 0x18C98F0 VA: 0x1818CA4F0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C8C90 Offset: 0x18C8090 VA: 0x1818C8C90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CA4C0 Offset: 0x18C98C0 VA: 0x1818CA4C0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CA740 Offset: 0x18C9B40 VA: 0x1818CA740
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18CA750 Offset: 0x18C9B50 VA: 0x1818CA750 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C9FC0 Offset: 0x18C93C0 VA: 0x1818C9FC0
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C9180 Offset: 0x18C8580 VA: 0x1818C9180 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C9190 Offset: 0x18C8590 VA: 0x1818C9190 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C9200 Offset: 0x18C8600 VA: 0x1818C9200 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C9230 Offset: 0x18C8630 VA: 0x1818C9230 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CA8E0 Offset: 0x18C9CE0 VA: 0x1818CA8E0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CA310 Offset: 0x18C9710 VA: 0x1818CA310 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CA380 Offset: 0x18C9780 VA: 0x1818CA380 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CA4B0 Offset: 0x18C98B0 VA: 0x1818CA4B0
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x18CA590 Offset: 0x18C9990 VA: 0x1818CA590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18CA970 Offset: 0x18C9D70 VA: 0x1818CA970 Slot: 43
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x18CA960 Offset: 0x18C9D60 VA: 0x1818CA960
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x18CA400 Offset: 0x18C9800 VA: 0x1818CA400 Slot: 24
	public override Type[] GetGenericArguments() { }

	// RVA: 0x18CA410 Offset: 0x18C9810 VA: 0x1818CA410
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x18CA420 Offset: 0x18C9820 VA: 0x1818CA420 Slot: 42
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CAD70 Offset: 0x18CA170 VA: 0x1818CAD70 Slot: 25
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x18CAD80 Offset: 0x18CA180 VA: 0x1818CAD80 Slot: 27
	public override bool get_IsGenericMethod() { }

	// RVA: 0x18CAC90 Offset: 0x18CA090 VA: 0x1818CAC90 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x18C8C20 Offset: 0x18C8020 VA: 0x1818C8C20 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 28
	public override bool get_IsSecurityCritical() { }

}

internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 584
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x18C8C30 Offset: 0x18C8030 VA: 0x1818C8C30 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C8C90 Offset: 0x18C8090 VA: 0x1818C8C90 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C8C90 Offset: 0x18C8090 VA: 0x1818C8C90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18C8C60 Offset: 0x18C8060 VA: 0x1818C8C60 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18C8CA0 Offset: 0x18C80A0 VA: 0x1818C8CA0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18C8DB0 Offset: 0x18C81B0 VA: 0x1818C8DB0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C8960 Offset: 0x18C7D60 VA: 0x1818C8960
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C8CB0 Offset: 0x18C80B0 VA: 0x1818C8CB0
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18C8D80 Offset: 0x18C8180 VA: 0x1818C8D80 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C9180 Offset: 0x18C8580 VA: 0x1818C9180 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C9190 Offset: 0x18C8590 VA: 0x1818C9190 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x18C91C0 Offset: 0x18C85C0 VA: 0x1818C91C0 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C9200 Offset: 0x18C8600 VA: 0x1818C9200 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C9230 Offset: 0x18C8630 VA: 0x1818C9230 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C8EE0 Offset: 0x18C82E0 VA: 0x1818C8EE0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C8BB0 Offset: 0x18C7FB0 VA: 0x1818C8BB0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C8B30 Offset: 0x18C7F30 VA: 0x1818C8B30 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C8C20 Offset: 0x18C8020 VA: 0x1818C8C20 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18C8F60 Offset: 0x18C8360 VA: 0x1818C8F60 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 28
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x18C9120 Offset: 0x18C8520 VA: 0x1818C9120
	public void .ctor() { }

}

internal class MonoModule : RuntimeModule // TypeDefIndex: 586
{	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 10
	public override Assembly get_Assembly() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 11
	public override string get_ScopeName() { }

	// RVA: 0x18CB150 Offset: 0x18CA550 VA: 0x1818CB150 Slot: 12
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120 Slot: 13
	public override bool IsResource() { }

	// RVA: 0x18CAE60 Offset: 0x18CA260 VA: 0x1818CAE60 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CADE0 Offset: 0x18CA1E0 VA: 0x1818CADE0 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CB070 Offset: 0x18CA470 VA: 0x1818CB070 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CAED0 Offset: 0x18CA2D0 VA: 0x1818CAED0 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CAFF0 Offset: 0x18CA3F0 VA: 0x1818CAFF0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x18CB0F0 Offset: 0x18CA4F0 VA: 0x1818CB0F0
	public void .ctor() { }

}

internal class MonoParameterInfo : RuntimeParameterInfo // TypeDefIndex: 588
{	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x18CB2F0 Offset: 0x18CA6F0 VA: 0x1818CB2F0
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x18CB3C0 Offset: 0x18CA7C0 VA: 0x1818CB3C0 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x18CB180 Offset: 0x18CA580 VA: 0x1818CB180 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CB1F0 Offset: 0x18CA5F0 VA: 0x1818CB1F0 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CB270 Offset: 0x18CA670 VA: 0x1818CB270 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

internal struct MonoPropertyInfo // TypeDefIndex: 589
{	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28

	// Methods

	// RVA: 0x18CB640 Offset: 0x18CAA40 VA: 0x1818CB640
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x18CB630 Offset: 0x18CAA30 VA: 0x1818CB630
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	internal static object get_default_value(MonoProperty prop) { }

}

internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 592
{	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18CB650 Offset: 0x18CAA50 VA: 0x1818CB650
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x18CC690 Offset: 0x18CBA90 VA: 0x1818CC690 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18CC6D0 Offset: 0x18CBAD0 VA: 0x1818CC6D0 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18CC720 Offset: 0x18CBB20 VA: 0x1818CC720 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18CC7F0 Offset: 0x18CBBF0 VA: 0x1818CC7F0 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18CC8D0 Offset: 0x18CBCD0 VA: 0x1818CC8D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CC770 Offset: 0x18CBB70 VA: 0x1818CC770 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CC7B0 Offset: 0x18CBBB0 VA: 0x1818CC7B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CBA10 Offset: 0x18CAE10 VA: 0x1818CBA10 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18CBCE0 Offset: 0x18CB0E0 VA: 0x1818CBCE0 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18CBD90 Offset: 0x18CB190 VA: 0x1818CBD90 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18CC150 Offset: 0x18CB550 VA: 0x1818CC150 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90 Slot: 33
	public override object GetConstantValue() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90 Slot: 34
	public override object GetRawConstantValue() { }

	// RVA: 0x18CC3E0 Offset: 0x18CB7E0 VA: 0x1818CC3E0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CBC80 Offset: 0x18CB080 VA: 0x1818CBC80 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CBC10 Offset: 0x18CB010 VA: 0x1818CBC10 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82120 Offset: 0xE81520 VA: 0x180E82120
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE821B0 Offset: 0xE815B0 VA: 0x180E821B0
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x18CB690 Offset: 0x18CAA90 VA: 0x1818CB690
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x18CC200 Offset: 0x18CB600 VA: 0x1818CC200 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x18CC240 Offset: 0x18CB640 VA: 0x1818CC240 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18CC450 Offset: 0x18CB850 VA: 0x1818CC450 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18CC070 Offset: 0x18CB470 VA: 0x1818CC070 Slot: 31
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18CC0E0 Offset: 0x18CB4E0 VA: 0x1818CC0E0 Slot: 32
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18C1C60 Offset: 0x18C1060 VA: 0x1818C1C60 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 593
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1336020 Offset: 0x1335420 VA: 0x181336020 Slot: 12
	public virtual object Invoke(object _this) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 594
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-MonoProperty.Getter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189A6F0 Offset: 0x1899AF0 VA: 0x18189A6F0
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/

}

private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 595
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4B9C0 Offset: 0xD4ADC0 VA: 0x180D4B9C0
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497020 Offset: 0x496420 VA: 0x180497020
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/

}

internal enum MonoFileType // TypeDefIndex: 674
{	// Fields
	public int value__; // 0x0
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;

}

internal static class MonoIO // TypeDefIndex: 675
{	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x1622AE0 Offset: 0x1621EE0 VA: 0x181622AE0
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x1622420 Offset: 0x1621820 VA: 0x181622420
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1621EF0 Offset: 0x16212F0 VA: 0x181621EF0
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1621F00 Offset: 0x1621300 VA: 0x181621F00
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1623260 Offset: 0x1622660 VA: 0x181623260
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x16231F0 Offset: 0x16225F0 VA: 0x1816231F0
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1622410 Offset: 0x1621810 VA: 0x181622410
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x1622F30 Offset: 0x1622330 VA: 0x181622F30
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x1622F40 Offset: 0x1622340 VA: 0x181622F40
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x1621E30 Offset: 0x1621230 VA: 0x181621E30
	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x1621E40 Offset: 0x1621240 VA: 0x181621E40
	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x1621F70 Offset: 0x1621370 VA: 0x181621F70
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x1621F80 Offset: 0x1621380 VA: 0x181621F80
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x1622BC0 Offset: 0x1621FC0 VA: 0x181622BC0
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x1622BD0 Offset: 0x1621FD0 VA: 0x181622BD0
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x1622DF0 Offset: 0x16221F0 VA: 0x181622DF0
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1622CD0 Offset: 0x16220D0 VA: 0x181622CD0
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x16223F0 Offset: 0x16217F0 VA: 0x1816223F0
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1622360 Offset: 0x1621760 VA: 0x181622360
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1622400 Offset: 0x1621800 VA: 0x181622400
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1622350 Offset: 0x1621750 VA: 0x181622350
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x1622290 Offset: 0x1621690 VA: 0x181622290
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x16220E0 Offset: 0x16214E0 VA: 0x1816220E0
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x1622000 Offset: 0x1621400 VA: 0x181622000
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x16221B0 Offset: 0x16215B0 VA: 0x1816221B0
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x1622C40 Offset: 0x1622040 VA: 0x181622C40
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1622C50 Offset: 0x1622050 VA: 0x181622C50
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1622FE0 Offset: 0x16223E0 VA: 0x181622FE0
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1622FF0 Offset: 0x16223F0 VA: 0x181622FF0
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1621E20 Offset: 0x1621220 VA: 0x181621E20
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x16231D0 Offset: 0x16225D0 VA: 0x1816231D0
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1623080 Offset: 0x1622480 VA: 0x181623080
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1623A30 Offset: 0x1622E30 VA: 0x181623A30
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1623A40 Offset: 0x1622E40 VA: 0x181623A40
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1623270 Offset: 0x1622670 VA: 0x181623270
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1623280 Offset: 0x1622680 VA: 0x181623280
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1622E00 Offset: 0x1622200 VA: 0x181622E00
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1622E10 Offset: 0x1622210 VA: 0x181622E10
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1623A20 Offset: 0x1622E20 VA: 0x181623A20
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x16238F0 Offset: 0x1622CF0 VA: 0x1816238F0
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x1623650 Offset: 0x1622A50 VA: 0x181623650
	private static bool SetFileTime(IntPtr handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x1623660 Offset: 0x1622A60 VA: 0x181623660
	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x16233C0 Offset: 0x16227C0 VA: 0x1816233C0
	public static bool SetCreationTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x16237B0 Offset: 0x1622BB0 VA: 0x1816237B0
	public static bool SetLastAccessTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1623850 Offset: 0x1622C50 VA: 0x181623850
	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1623460 Offset: 0x1622860 VA: 0x181623460
	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1623C30 Offset: 0x1623030 VA: 0x181623C30
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1623C20 Offset: 0x1623020 VA: 0x181623C20
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1623C10 Offset: 0x1623010 VA: 0x181623C10
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x1621FF0 Offset: 0x16213F0 VA: 0x181621FF0
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x1623C60 Offset: 0x1623060 VA: 0x181623C60
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x1623C40 Offset: 0x1623040 VA: 0x181623C40
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x1623C00 Offset: 0x1623000 VA: 0x181623C00
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x1623C50 Offset: 0x1623050 VA: 0x181623C50
	public static char get_PathSeparator() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	private static void DumpHandles() { }

	// RVA: 0x16231E0 Offset: 0x16225E0 VA: 0x1816231E0
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x1623B90 Offset: 0x1622F90 VA: 0x181623B90
	private static void .cctor() { }

}

internal enum MonoIOError // TypeDefIndex: 676
{	// Fields
	public int value__; // 0x0
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;

}

internal struct MonoIOStat // TypeDefIndex: 677
{	// Fields
	public FileAttributes fileAttributes; // 0x0
	public long Length; // 0x8
	public long CreationTime; // 0x10
	public long LastAccessTime; // 0x18
	public long LastWriteTime; // 0x20

}

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1252
{	// Fields
	private MonoMethod method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Type[] methodSignature; // 0x68
	private Identity identity; // 0x70
	internal static string CallContextKey; // 0x0
	internal static string UriKey; // 0x8

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x147B280 Offset: 0x147A680 VA: 0x18147B280
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x147B6C0 Offset: 0x147AAC0 VA: 0x18147B6C0
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x147B7C0 Offset: 0x147ABC0 VA: 0x18147B7C0
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x147B1C0 Offset: 0x147A5C0 VA: 0x18147B1C0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x147B940 Offset: 0x147AD40 VA: 0x18147B940
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x147BF80 Offset: 0x147B380 VA: 0x18147BF80 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x147BA60 Offset: 0x147AE60 VA: 0x18147BA60 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x147BB90 Offset: 0x147AF90 VA: 0x18147BB90 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x147BC10 Offset: 0x147B010 VA: 0x18147BC10 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x147C000 Offset: 0x147B400 VA: 0x18147C000 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x147B180 Offset: 0x147A580 VA: 0x18147B180 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x147BD70 Offset: 0x147B170 VA: 0x18147BD70 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x147BDE0 Offset: 0x147B1E0 VA: 0x18147BDE0 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x147BAA0 Offset: 0x147AEA0 VA: 0x18147BAA0
	internal CallType get_CallType() { }

	// RVA: 0x147B5D0 Offset: 0x147A9D0 VA: 0x18147B5D0
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x147B650 Offset: 0x147AA50 VA: 0x18147B650
	private static void .cctor() { }

}

public class MonoTlsConnectionInfo // TypeDefIndex: 1743
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13A3F40 Offset: 0x13A3340 VA: 0x1813A3F40
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1AB4190 Offset: 0x1AB3590 VA: 0x181AB4190
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1AB4110 Offset: 0x1AB3510 VA: 0x181AB4110 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum MonoSslPolicyErrors // TypeDefIndex: 1744
{	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;

}

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1745
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF64E0 Offset: 0xFF58E0 VA: 0x180FF64E0 Slot: 12
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1AB4070 Offset: 0x1AB3470 VA: 0x181AB4070 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1746
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF4240 Offset: 0xFF3640 VA: 0x180FF4240 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFF41F0 Offset: 0xFF35F0 VA: 0x180FF41F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

public abstract class MonoTlsProvider // TypeDefIndex: 1747
{	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown();

}

public static class MonoTlsProviderFactory // TypeDefIndex: 1748
{	// Methods

	// RVA: 0x1AB41A0 Offset: 0x1AB35A0 VA: 0x181AB41A0
	public static MonoTlsProvider GetProvider() { }

}

public sealed class MonoTlsSettings // TypeDefIndex: 1749
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private bool cloned; // 0x60
	private bool checkCertName; // 0x61
	private bool checkCertRevocationStatus; // 0x62
	private Nullable<bool> useServicePointManagerCallback; // 0x63
	private bool skipSystemValidators; // 0x65
	private bool callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] // RVA: 0x7F210 Offset: 0x7E610 VA: 0x18007F210
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1AB45F0 Offset: 0x1AB39F0 VA: 0x181AB45F0
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1AB4610 Offset: 0x1AB3A10 VA: 0x181AB4610
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1081440 Offset: 0x1080840 VA: 0x181081440
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD623A0 Offset: 0xD617A0 VA: 0x180D623A0
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1091460 Offset: 0x1090860 VA: 0x181091460
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF8AD20 Offset: 0xF8A120 VA: 0x180F8AD20
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1AB4600 Offset: 0x1AB3A00 VA: 0x181AB4600
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1AB43F0 Offset: 0x1AB37F0 VA: 0x181AB43F0
	public void .ctor() { }

	// RVA: 0x1AB4560 Offset: 0x1AB3960 VA: 0x181AB4560
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1AB4320 Offset: 0x1AB3720 VA: 0x181AB4320
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0x7F210 Offset: 0x7E610 VA: 0x18007F210
	// RVA: 0x1AB4220 Offset: 0x1AB3620 VA: 0x181AB4220
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1AB42C0 Offset: 0x1AB36C0 VA: 0x181AB42C0
	public MonoTlsSettings Clone() { }

	// RVA: 0x1AB4400 Offset: 0x1AB3800 VA: 0x181AB4400
	private void .ctor(MonoTlsSettings other) { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 1810
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2454
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor(Type t) { }

}

internal static class MonoTlsProviderFactory // TypeDefIndex: 2552
{	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MonoTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0x1213FB0 Offset: 0x12133B0 VA: 0x181213FB0
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x1214180 Offset: 0x1213580 VA: 0x181214180
	internal static void InitializeInternal() { }

	// RVA: 0x1214980 Offset: 0x1213D80 VA: 0x181214980
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1214530 Offset: 0x1213930 VA: 0x181214530
	private static void InitializeProviderRegistration() { }

	// RVA: 0x1213F30 Offset: 0x1213330 VA: 0x181213F30
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x12140F0 Offset: 0x12134F0 VA: 0x1812140F0
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x1214E80 Offset: 0x1214280 VA: 0x181214E80
	private static void .cctor() { }

}

internal class MonoTlsStream // TypeDefIndex: 2553
{	// Fields
	private readonly MonoTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private IMonoSslStream sslStream; // 0x30
	private WebExceptionStatus status; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CertificateValidationFailed>k__BackingField; // 0x3C

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal HttpWebRequest get_Request() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC45090 Offset: 0xC44490 VA: 0x180C45090
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86630 Offset: 0xE85A30 VA: 0x180E86630
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x1215520 Offset: 0x1214920 VA: 0x181215520
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0x1214FB0 Offset: 0x12143B0 VA: 0x181214FB0
	internal Stream CreateStream(byte[] buffer) { }

}

internal class MonoChunkStream // TypeDefIndex: 3014
{	// Fields
	internal WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkStream.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1342350 Offset: 0x1341750 VA: 0x181342350
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x13422A0 Offset: 0x13416A0 VA: 0x1813422A0
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1342140 Offset: 0x1341540 VA: 0x181342140
	public void ResetBuffer() { }

	// RVA: 0x13421F0 Offset: 0x13415F0 VA: 0x1813421F0
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x13420E0 Offset: 0x13414E0 VA: 0x1813420E0
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1341B70 Offset: 0x1340F70 VA: 0x181341B70
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1342270 Offset: 0x1341670 VA: 0x181342270
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1341690 Offset: 0x1340A90 VA: 0x181341690
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1342560 Offset: 0x1341960 VA: 0x181342560
	public bool get_WantMore() { }

	// RVA: 0x1342450 Offset: 0x1341850 VA: 0x181342450
	public bool get_DataAvailable() { }

	// RVA: 0x1342440 Offset: 0x1341840 VA: 0x181342440
	public int get_ChunkLeft() { }

	// RVA: 0x1341960 Offset: 0x1340D60 VA: 0x181341960
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13413D0 Offset: 0x13407D0 VA: 0x1813413D0
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13420F0 Offset: 0x13414F0 VA: 0x1813420F0
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1341A90 Offset: 0x1340E90 VA: 0x181341A90
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1341E20 Offset: 0x1341220 VA: 0x181341E20
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1342180 Offset: 0x1341580 VA: 0x181342180
	private static void ThrowProtocolViolation(string message) { }

}

private enum MonoChunkStream.State // TypeDefIndex: 3015
{	// Fields
	public int value__; // 0x0
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;

}

private class MonoChunkStream.Chunk // TypeDefIndex: 3016
{	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(byte[] chunk) { }

	// RVA: 0x132A470 Offset: 0x1329870 VA: 0x18132A470
	public int Read(byte[] buffer, int offset, int size) { }

}

public class MonoBehaviour : Behaviour // TypeDefIndex: 3518
{	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x18F1EA0 Offset: 0x18F12A0 VA: 0x1818F1EA0
	public bool IsInvoking() { }

	// RVA: 0x18F1E20 Offset: 0x18F1220 VA: 0x1818F1E20
	public void CancelInvoke() { }

	// RVA: 0x18F2030 Offset: 0x18F1430 VA: 0x1818F2030
	public void Invoke(string methodName, float time) { }

	// RVA: 0x18F1F50 Offset: 0x18F1350 VA: 0x1818F1F50
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x18F1DD0 Offset: 0x18F11D0 VA: 0x1818F1DD0
	public void CancelInvoke(string methodName) { }

	// RVA: 0x18F2090 Offset: 0x18F1490 VA: 0x1818F2090
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F22C0 Offset: 0x18F16C0 VA: 0x1818F22C0
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x18F23C0 Offset: 0x18F17C0 VA: 0x1818F23C0
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x18F21D0 Offset: 0x18F15D0 VA: 0x1818F21D0
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0xC18C0 Offset: 0xC0CC0 VA: 0x1800C18C0
	// RVA: 0x18F21D0 Offset: 0x18F15D0 VA: 0x1818F21D0
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x18F25B0 Offset: 0x18F19B0 VA: 0x1818F25B0
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x18F26F0 Offset: 0x18F1AF0 VA: 0x1818F26F0
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x18F26A0 Offset: 0x18F1AA0 VA: 0x1818F26A0
	public void StopCoroutine(string methodName) { }

	// RVA: 0x18F24D0 Offset: 0x18F18D0 VA: 0x1818F24D0
	public void StopAllCoroutines() { }

	// RVA: 0x18F27F0 Offset: 0x18F1BF0 VA: 0x1818F27F0
	public bool get_useGUILayout() { }

	// RVA: 0x18F2890 Offset: 0x18F1C90 VA: 0x1818F2890
	public void set_useGUILayout(bool value) { }

	// RVA: 0x18F2830 Offset: 0x18F1C30 VA: 0x1818F2830
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0xC1A30 Offset: 0xC0E30 VA: 0x1800C1A30
	// RVA: 0x18F1E20 Offset: 0x18F1220 VA: 0x1818F1E20
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xC1AC0 Offset: 0xC0EC0 VA: 0x1800C1AC0
	// RVA: 0x18F1EA0 Offset: 0x18F12A0 VA: 0x1818F1EA0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18F1EE0 Offset: 0x18F12E0 VA: 0x1818F1EE0
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18F1DD0 Offset: 0x18F11D0 VA: 0x1818F1DD0
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18F2090 Offset: 0x18F1490 VA: 0x1818F2090
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x18F20E0 Offset: 0x18F14E0 VA: 0x1818F20E0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x18F2170 Offset: 0x18F1570 VA: 0x1818F2170
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x18F2120 Offset: 0x18F1520 VA: 0x1818F2120
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x18F2560 Offset: 0x18F1960 VA: 0x1818F2560
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x18F2510 Offset: 0x18F1910 VA: 0x1818F2510
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x18F1E60 Offset: 0x18F1260 VA: 0x1818F1E60
	internal string GetScriptClassName() { }

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	public void .ctor() { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
{
// Namespace: System
[AttributeUsageAttribute] // RVA: 0x80ED0 Offset: 0x802D0 VA: 0x180080ED0
internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string comment) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 5256
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

internal static class Mono // TypeDefIndex: 6227
{	// Methods

	// RVA: 0x14ECEE0 Offset: 0x14EC2E0 VA: 0x1814ECEE0
	internal static void FixHttpsValidation() { }

}

private sealed class Mono.<>c // TypeDefIndex: 6228
{	// Fields
	public static readonly Mono.<>c <>9; // 0x0
	public static RemoteCertificateValidationCallback <>9__0_0; // 0x8

	// Methods

	// RVA: 0x14F4490 Offset: 0x14F3890 VA: 0x1814F4490
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	internal bool <FixHttpsValidation>b__0_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
{
// Namespace: EasyAntiCheat
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public abstract class MonoEncoding : Encoding // TypeDefIndex: 7373
{	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22A8190 Offset: 0x22A7590 VA: 0x1822A8190
	public void .ctor(int codePage) { }

	// RVA: 0x22A8160 Offset: 0x22A7560 VA: 0x1822A8160
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x22A81B0 Offset: 0x22A75B0 VA: 0x1822A81B0 Slot: 11
	public override int get_WindowsCodePage() { }

	// RVA: 0x22A7ED0 Offset: 0x22A72D0 VA: 0x1822A7ED0
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	// RVA: 0x22A7810 Offset: 0x22A6C10 VA: 0x1822A7810 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22A7C30 Offset: 0x22A7030 VA: 0x1822A7C30 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22A79A0 Offset: 0x22A6DA0 VA: 0x1822A79A0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22A7980 Offset: 0x22A6D80 VA: 0x1822A7980 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x22A7EB0 Offset: 0x22A72B0 VA: 0x1822A7EB0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract int GetByteCountImpl(char* chars, int charCount);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);

}

public abstract class MonoEncoder : Encoder // TypeDefIndex: 7374
{	// Fields
	private MonoEncoding encoding; // 0x20

	// Methods

	// RVA: 0x159B530 Offset: 0x159A930 VA: 0x18159B530
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x22A7350 Offset: 0x22A6750 VA: 0x1822A7350 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	// RVA: 0x22A74D0 Offset: 0x22A68D0 VA: 0x1822A74D0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	// RVA: 0x22A7750 Offset: 0x22A6B50 VA: 0x1822A7750 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22A7770 Offset: 0x22A6B70 VA: 0x1822A7770
	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

}

