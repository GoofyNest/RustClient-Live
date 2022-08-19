public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 211
{	// Fields
	private static readonly char[] enumSeperatorCharArray; // 0x12F2F
	private const string enumSeperator = ", ";

	// Methods

	// RVA: 0x10D0A50 Offset: 0x10CFE50 VA: 0x1810D0A50
	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	// RVA: 0x10D1A00 Offset: 0x10D0E00 VA: 0x1810D1A00
	private static string InternalFormattedHexString(object value) { }

	// RVA: 0x10D1850 Offset: 0x10D0C50 VA: 0x1810D1850
	private static string InternalFormat(RuntimeType eT, object value) { }

	// RVA: 0x10D1450 Offset: 0x10D0850 VA: 0x1810D1450
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	// RVA: 0x10D46E0 Offset: 0x10D3AE0 VA: 0x1810D46E0
	internal static ulong ToUInt64(object value) { }

	// RVA: 0x10D1440 Offset: 0x10D0840 VA: 0x1810D1440
	private static int InternalCompareTo(object o1, object o2) { }

	// RVA: 0x10D1EC0 Offset: 0x10D12C0 VA: 0x1810D1EC0
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	// RVA: 0x10D0BC0 Offset: 0x10CFFC0 VA: 0x1810D0BC0
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	// RVA: 0x10D1430 Offset: 0x10D0830 VA: 0x1810D1430
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA470 Offset: 0xBE9870 VA: 0x180BEA470
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA4F0 Offset: 0xBE98F0 VA: 0x180BEA4F0
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D2010 Offset: 0x10D1410 VA: 0x1810D2010
	public static object Parse(Type enumType, string value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D2150 Offset: 0x10D1550 VA: 0x1810D2150
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	// RVA: 0x10D4880 Offset: 0x10D3C80 VA: 0x1810D4880
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D1140 Offset: 0x10D0540 VA: 0x1810D1140
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D1200 Offset: 0x10D0600 VA: 0x1810D1200
	public static Array GetValues(Type enumType) { }

	// RVA: 0x10D1ED0 Offset: 0x10D12D0 VA: 0x1810D1ED0
	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D0BE0 Offset: 0x10CFFE0 VA: 0x1810D0BE0
	public static string GetName(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D0CA0 Offset: 0x10D00A0 VA: 0x1810D0CA0
	public static string[] GetNames(Type enumType) { }

	// RVA: 0x10D1E50 Offset: 0x10D1250 VA: 0x1810D1E50
	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D3CD0 Offset: 0x10D30D0 VA: 0x1810D3CD0
	public static object ToObject(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D1F50 Offset: 0x10D1350 VA: 0x1810D1F50
	public static bool IsDefined(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D0270 Offset: 0x10CF670 VA: 0x1810D0270
	public static string Format(Type enumType, object value, string format) { }

	// RVA: 0x10D11F0 Offset: 0x10D05F0 VA: 0x1810D11F0
	private object get_value() { }

	// RVA: 0x10D11F0 Offset: 0x10D05F0 VA: 0x1810D11F0
	internal object GetValue() { }

	// RVA: 0x10D1F40 Offset: 0x10D1340 VA: 0x1810D1F40
	private bool InternalHasFlag(Enum flags) { }

	// RVA: 0x10D0BD0 Offset: 0x10CFFD0 VA: 0x1810D0BD0
	private int get_hashcode() { }

	// RVA: 0x10D0260 Offset: 0x10CF660 VA: 0x1810D0260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10D0BD0 Offset: 0x10CFFD0 VA: 0x1810D0BD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10D4620 Offset: 0x10D3A20 VA: 0x1810D4620 Slot: 3
	public override string ToString() { }

	[ObsoleteAttribute] // RVA: 0x79F30 Offset: 0x79330 VA: 0x180079F30
	// RVA: 0x10D4610 Offset: 0x10D3A10 VA: 0x1810D4610 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x10D0090 Offset: 0x10CF490 VA: 0x1810D0090 Slot: 4
	public int CompareTo(object target) { }

	// RVA: 0x10D43E0 Offset: 0x10D37E0 VA: 0x1810D43E0
	public string ToString(string format) { }

	[ObsoleteAttribute] // RVA: 0x7A0E0 Offset: 0x794E0 VA: 0x18007A0E0
	// RVA: 0xD81B90 Offset: 0xD80F90 VA: 0x180D81B90 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x10D12B0 Offset: 0x10D06B0 VA: 0x1810D12B0
	public bool HasFlag(Enum flag) { }

	// RVA: 0x10D0D50 Offset: 0x10D0150 VA: 0x1810D0D50 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x10D2260 Offset: 0x10D1660 VA: 0x1810D2260 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x10D23A0 Offset: 0x10D17A0 VA: 0x1810D23A0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x10D2840 Offset: 0x10D1C40 VA: 0x1810D2840 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x10D2300 Offset: 0x10D1700 VA: 0x1810D2300 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x10D2660 Offset: 0x10D1A60 VA: 0x1810D2660 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x10D2A00 Offset: 0x10D1E00 VA: 0x1810D2A00 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10D2700 Offset: 0x10D1B00 VA: 0x1810D2700 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x10D2AA0 Offset: 0x10D1EA0 VA: 0x1810D2AA0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10D27A0 Offset: 0x10D1BA0 VA: 0x1810D27A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10D2B40 Offset: 0x10D1F40 VA: 0x1810D2B40 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x10D28E0 Offset: 0x10D1CE0 VA: 0x1810D28E0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10D25C0 Offset: 0x10D19C0 VA: 0x1810D25C0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10D2510 Offset: 0x10D1910 VA: 0x1810D2510 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x10D2440 Offset: 0x10D1840 VA: 0x1810D2440 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10D2980 Offset: 0x10D1D80 VA: 0x1810D2980 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[ComVisibleAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	[CLSCompliantAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	// RVA: 0x10D41F0 Offset: 0x10D35F0 VA: 0x1810D41F0
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D3540 Offset: 0x10D2940 VA: 0x1810D3540
	public static object ToObject(Type enumType, short value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D3910 Offset: 0x10D2D10 VA: 0x1810D3910
	public static object ToObject(Type enumType, int value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D2FA0 Offset: 0x10D23A0 VA: 0x1810D2FA0
	public static object ToObject(Type enumType, byte value) { }

	[ComVisibleAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	[CLSCompliantAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	// RVA: 0x10D3360 Offset: 0x10D2760 VA: 0x1810D3360
	public static object ToObject(Type enumType, ushort value) { }

	[ComVisibleAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	[CLSCompliantAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	// RVA: 0x10D2DC0 Offset: 0x10D21C0 VA: 0x1810D2DC0
	public static object ToObject(Type enumType, uint value) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x10D3AF0 Offset: 0x10D2EF0 VA: 0x1810D3AF0
	public static object ToObject(Type enumType, long value) { }

	[ComVisibleAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	[CLSCompliantAttribute] // RVA: 0x7A200 Offset: 0x79600 VA: 0x18007A200
	// RVA: 0x10D3180 Offset: 0x10D2580 VA: 0x1810D3180
	public static object ToObject(Type enumType, ulong value) { }

	// RVA: 0x10D3730 Offset: 0x10D2B30 VA: 0x1810D3730
	private static object ToObject(Type enumType, char value) { }

	// RVA: 0x10D2BE0 Offset: 0x10D1FE0 VA: 0x1810D2BE0
	private static object ToObject(Type enumType, bool value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

	// RVA: 0x10D5040 Offset: 0x10D4440 VA: 0x1810D5040
	private static void .cctor() { }

}

private enum Enum.ParseFailureKind // TypeDefIndex: 212
{	// Fields
	public int value__; // 0x0
	public const Enum.ParseFailureKind None = 0;
	public const Enum.ParseFailureKind Argument = 1;
	public const Enum.ParseFailureKind ArgumentNull = 2;
	public const Enum.ParseFailureKind ArgumentWithParameter = 3;
	public const Enum.ParseFailureKind UnhandledException = 4;

}

private struct Enum.EnumResult // TypeDefIndex: 213
{	// Fields
	internal object parsedEnum; // 0x0
	internal bool canThrow; // 0x8
	internal Enum.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal string m_failureParameter; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal Exception m_innerException; // 0x28

	// Methods

	// RVA: 0x19F260 Offset: 0x19E660 VA: 0x18019F260
	internal void Init(bool canMethodThrow) { }

	// RVA: 0x19F2E0 Offset: 0x19E6E0 VA: 0x18019F2E0
	internal void SetFailure(Exception unhandledException) { }

	// RVA: 0x19F300 Offset: 0x19E700 VA: 0x18019F300
	internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter) { }

	// RVA: 0x19F2D0 Offset: 0x19E6D0 VA: 0x18019F2D0
	internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x19F250 Offset: 0x19E650 VA: 0x18019F250
	internal Exception GetEnumParseException() { }

}

private class Enum.ValuesAndNames // TypeDefIndex: 214
{	// Fields
	public ulong[] Values; // 0x10
	public string[] Names; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(ulong[] values, string[] names) { }

}

public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 602
{
// Namespace: System.Reflection.Emit
public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 602
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x18C3790 Offset: 0x18C2B90 VA: 0x1818C3790 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18C3740 Offset: 0x18C2B40 VA: 0x1818C3740 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18C37E0 Offset: 0x18C2BE0 VA: 0x1818C37E0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18C3830 Offset: 0x18C2C30 VA: 0x1818C3830 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18C3880 Offset: 0x18C2C80 VA: 0x1818C3880 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18C38D0 Offset: 0x18C2CD0 VA: 0x1818C38D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C3920 Offset: 0x18C2D20 VA: 0x1818C3920 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C33C0 Offset: 0x18C27C0 VA: 0x1818C33C0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18C3970 Offset: 0x18C2D70 VA: 0x1818C3970 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C32D0 Offset: 0x18C26D0 VA: 0x1818C32D0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C3300 Offset: 0x18C2700 VA: 0x1818C3300 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18C3330 Offset: 0x18C2730 VA: 0x1818C3330 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C3390 Offset: 0x18C2790 VA: 0x1818C3390 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C3360 Offset: 0x18C2760 VA: 0x1818C3360 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C3410 Offset: 0x18C2810 VA: 0x1818C3410 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C3440 Offset: 0x18C2840 VA: 0x1818C3440 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C3470 Offset: 0x18C2870 VA: 0x1818C3470 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C34A0 Offset: 0x18C28A0 VA: 0x1818C34A0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C34D0 Offset: 0x18C28D0 VA: 0x1818C34D0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C3500 Offset: 0x18C2900 VA: 0x1818C3500 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C3530 Offset: 0x18C2930 VA: 0x1818C3530 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C3560 Offset: 0x18C2960 VA: 0x1818C3560 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C3590 Offset: 0x18C2990 VA: 0x1818C3590 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C35C0 Offset: 0x18C29C0 VA: 0x1818C35C0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C35F0 Offset: 0x18C29F0 VA: 0x1818C35F0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C3620 Offset: 0x18C2A20 VA: 0x1818C3620 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C3650 Offset: 0x18C2A50 VA: 0x1818C3650 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C3680 Offset: 0x18C2A80 VA: 0x1818C3680 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C36B0 Offset: 0x18C2AB0 VA: 0x1818C36B0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C36E0 Offset: 0x18C2AE0 VA: 0x1818C36E0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18C3710 Offset: 0x18C2B10 VA: 0x1818C3710 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

internal static class EnumHelper<UnderlyingType> // TypeDefIndex: 1511
{
// Namespace: System.Diagnostics.Tracing
internal static class EnumHelper<UnderlyingType> // TypeDefIndex: 1511
	// Fields
	private static readonly MethodInfo IdentityInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static UnderlyingType Cast<ValueType>(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9EC30 Offset: 0x1A9E030 VA: 0x181A9EC30
	|-EnumHelper<byte>.Cast<bool>
	|-EnumHelper<byte>.Cast<byte>
	|-EnumHelper<byte>.Cast<sbyte>
	|-EnumHelper<short>.Cast<bool>
	|-EnumHelper<short>.Cast<byte>
	|-EnumHelper<short>.Cast<sbyte>
	|-EnumHelper<int>.Cast<bool>
	|-EnumHelper<int>.Cast<byte>
	|-EnumHelper<int>.Cast<sbyte>
	|-EnumHelper<long>.Cast<bool>
	|-EnumHelper<long>.Cast<byte>
	|-EnumHelper<long>.Cast<sbyte>
	|-EnumHelper<sbyte>.Cast<bool>
	|-EnumHelper<sbyte>.Cast<byte>
	|-EnumHelper<sbyte>.Cast<sbyte>
	|-EnumHelper<ushort>.Cast<bool>
	|-EnumHelper<ushort>.Cast<byte>
	|-EnumHelper<ushort>.Cast<sbyte>
	|-EnumHelper<uint>.Cast<bool>
	|-EnumHelper<uint>.Cast<byte>
	|-EnumHelper<uint>.Cast<sbyte>
	|-EnumHelper<ulong>.Cast<bool>
	|-EnumHelper<ulong>.Cast<byte>
	|-EnumHelper<ulong>.Cast<sbyte>
	|
	|-RVA: 0x1A9ED00 Offset: 0x1A9E100 VA: 0x181A9ED00
	|-EnumHelper<byte>.Cast<char>
	|-EnumHelper<byte>.Cast<short>
	|-EnumHelper<byte>.Cast<ushort>
	|-EnumHelper<short>.Cast<char>
	|-EnumHelper<short>.Cast<short>
	|-EnumHelper<short>.Cast<ushort>
	|-EnumHelper<int>.Cast<char>
	|-EnumHelper<int>.Cast<short>
	|-EnumHelper<int>.Cast<ushort>
	|-EnumHelper<long>.Cast<char>
	|-EnumHelper<long>.Cast<short>
	|-EnumHelper<long>.Cast<ushort>
	|-EnumHelper<sbyte>.Cast<char>
	|-EnumHelper<sbyte>.Cast<short>
	|-EnumHelper<sbyte>.Cast<ushort>
	|-EnumHelper<ushort>.Cast<char>
	|-EnumHelper<ushort>.Cast<short>
	|-EnumHelper<ushort>.Cast<ushort>
	|-EnumHelper<uint>.Cast<char>
	|-EnumHelper<uint>.Cast<short>
	|-EnumHelper<uint>.Cast<ushort>
	|-EnumHelper<ulong>.Cast<char>
	|-EnumHelper<ulong>.Cast<short>
	|-EnumHelper<ulong>.Cast<ushort>
	|
	|-RVA: 0x1A9EDD0 Offset: 0x1A9E1D0 VA: 0x181A9EDD0
	|-EnumHelper<byte>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<byte>.Cast<DateTimeOffset>
	|-EnumHelper<byte>.Cast<Decimal>
	|-EnumHelper<byte>.Cast<Guid>
	|-EnumHelper<short>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<short>.Cast<DateTimeOffset>
	|-EnumHelper<short>.Cast<Decimal>
	|-EnumHelper<short>.Cast<Guid>
	|-EnumHelper<int>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<int>.Cast<DateTimeOffset>
	|-EnumHelper<int>.Cast<Decimal>
	|-EnumHelper<int>.Cast<Guid>
	|-EnumHelper<long>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<long>.Cast<DateTimeOffset>
	|-EnumHelper<long>.Cast<Decimal>
	|-EnumHelper<long>.Cast<Guid>
	|-EnumHelper<sbyte>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<sbyte>.Cast<DateTimeOffset>
	|-EnumHelper<sbyte>.Cast<Decimal>
	|-EnumHelper<sbyte>.Cast<Guid>
	|-EnumHelper<ushort>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<ushort>.Cast<DateTimeOffset>
	|-EnumHelper<ushort>.Cast<Decimal>
	|-EnumHelper<ushort>.Cast<Guid>
	|-EnumHelper<uint>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<uint>.Cast<DateTimeOffset>
	|-EnumHelper<uint>.Cast<Decimal>
	|-EnumHelper<uint>.Cast<Guid>
	|-EnumHelper<ulong>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<ulong>.Cast<DateTimeOffset>
	|-EnumHelper<ulong>.Cast<Decimal>
	|-EnumHelper<ulong>.Cast<Guid>
	|
	|-RVA: 0x1A9EEA0 Offset: 0x1A9E2A0 VA: 0x181A9EEA0
	|-EnumHelper<byte>.Cast<DateTime>
	|-EnumHelper<byte>.Cast<TimeSpan>
	|-EnumHelper<short>.Cast<DateTime>
	|-EnumHelper<short>.Cast<TimeSpan>
	|-EnumHelper<int>.Cast<DateTime>
	|-EnumHelper<int>.Cast<TimeSpan>
	|-EnumHelper<long>.Cast<DateTime>
	|-EnumHelper<long>.Cast<TimeSpan>
	|-EnumHelper<sbyte>.Cast<DateTime>
	|-EnumHelper<sbyte>.Cast<TimeSpan>
	|-EnumHelper<ushort>.Cast<DateTime>
	|-EnumHelper<ushort>.Cast<TimeSpan>
	|-EnumHelper<uint>.Cast<DateTime>
	|-EnumHelper<uint>.Cast<TimeSpan>
	|-EnumHelper<ulong>.Cast<DateTime>
	|-EnumHelper<ulong>.Cast<TimeSpan>
	|
	|-RVA: 0x1A9F040 Offset: 0x1A9E440 VA: 0x181A9F040
	|-EnumHelper<byte>.Cast<EmptyStruct>
	|-EnumHelper<short>.Cast<EmptyStruct>
	|-EnumHelper<int>.Cast<EmptyStruct>
	|-EnumHelper<long>.Cast<EmptyStruct>
	|-EnumHelper<sbyte>.Cast<EmptyStruct>
	|-EnumHelper<ushort>.Cast<EmptyStruct>
	|-EnumHelper<uint>.Cast<EmptyStruct>
	|-EnumHelper<ulong>.Cast<EmptyStruct>
	|
	|-RVA: 0x1A9EF70 Offset: 0x1A9E370 VA: 0x181A9EF70
	|-EnumHelper<byte>.Cast<double>
	|-EnumHelper<byte>.Cast<float>
	|-EnumHelper<short>.Cast<double>
	|-EnumHelper<short>.Cast<float>
	|-EnumHelper<int>.Cast<double>
	|-EnumHelper<int>.Cast<float>
	|-EnumHelper<long>.Cast<double>
	|-EnumHelper<long>.Cast<float>
	|-EnumHelper<sbyte>.Cast<double>
	|-EnumHelper<sbyte>.Cast<float>
	|-EnumHelper<ushort>.Cast<double>
	|-EnumHelper<ushort>.Cast<float>
	|-EnumHelper<uint>.Cast<double>
	|-EnumHelper<uint>.Cast<float>
	|-EnumHelper<ulong>.Cast<double>
	|-EnumHelper<ulong>.Cast<float>
	|
	|-RVA: 0x1A9F110 Offset: 0x1A9E510 VA: 0x181A9F110
	|-EnumHelper<byte>.Cast<int>
	|-EnumHelper<byte>.Cast<uint>
	|-EnumHelper<short>.Cast<int>
	|-EnumHelper<short>.Cast<uint>
	|-EnumHelper<int>.Cast<int>
	|-EnumHelper<int>.Cast<uint>
	|-EnumHelper<long>.Cast<int>
	|-EnumHelper<long>.Cast<uint>
	|-EnumHelper<sbyte>.Cast<int>
	|-EnumHelper<sbyte>.Cast<uint>
	|-EnumHelper<ushort>.Cast<int>
	|-EnumHelper<ushort>.Cast<uint>
	|-EnumHelper<uint>.Cast<int>
	|-EnumHelper<uint>.Cast<uint>
	|-EnumHelper<ulong>.Cast<int>
	|-EnumHelper<ulong>.Cast<uint>
	|
	|-RVA: 0x1A9F1E0 Offset: 0x1A9E5E0 VA: 0x181A9F1E0
	|-EnumHelper<byte>.Cast<long>
	|-EnumHelper<byte>.Cast<IntPtr>
	|-EnumHelper<byte>.Cast<object>
	|-EnumHelper<byte>.Cast<ulong>
	|-EnumHelper<byte>.Cast<UIntPtr>
	|-EnumHelper<short>.Cast<long>
	|-EnumHelper<short>.Cast<IntPtr>
	|-EnumHelper<short>.Cast<object>
	|-EnumHelper<short>.Cast<ulong>
	|-EnumHelper<short>.Cast<UIntPtr>
	|-EnumHelper<int>.Cast<long>
	|-EnumHelper<int>.Cast<IntPtr>
	|-EnumHelper<int>.Cast<object>
	|-EnumHelper<int>.Cast<ulong>
	|-EnumHelper<int>.Cast<UIntPtr>
	|-EnumHelper<long>.Cast<long>
	|-EnumHelper<long>.Cast<IntPtr>
	|-EnumHelper<long>.Cast<object>
	|-EnumHelper<long>.Cast<ulong>
	|-EnumHelper<long>.Cast<UIntPtr>
	|-EnumHelper<object>.Cast<object>
	|-EnumHelper<sbyte>.Cast<long>
	|-EnumHelper<sbyte>.Cast<IntPtr>
	|-EnumHelper<sbyte>.Cast<object>
	|-EnumHelper<sbyte>.Cast<ulong>
	|-EnumHelper<sbyte>.Cast<UIntPtr>
	|-EnumHelper<ushort>.Cast<long>
	|-EnumHelper<ushort>.Cast<IntPtr>
	|-EnumHelper<ushort>.Cast<object>
	|-EnumHelper<ushort>.Cast<ulong>
	|-EnumHelper<ushort>.Cast<UIntPtr>
	|-EnumHelper<uint>.Cast<long>
	|-EnumHelper<uint>.Cast<IntPtr>
	|-EnumHelper<uint>.Cast<object>
	|-EnumHelper<uint>.Cast<ulong>
	|-EnumHelper<uint>.Cast<UIntPtr>
	|-EnumHelper<ulong>.Cast<long>
	|-EnumHelper<ulong>.Cast<IntPtr>
	|-EnumHelper<ulong>.Cast<object>
	|-EnumHelper<ulong>.Cast<ulong>
	|-EnumHelper<ulong>.Cast<UIntPtr>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212DF30 Offset: 0x212D330 VA: 0x18212DF30
	|-EnumHelper<byte>..cctor
	|
	|-RVA: 0x212DA30 Offset: 0x212CE30 VA: 0x18212DA30
	|-EnumHelper<short>..cctor
	|
	|-RVA: 0x212DB30 Offset: 0x212CF30 VA: 0x18212DB30
	|-EnumHelper<int>..cctor
	|
	|-RVA: 0x212DC30 Offset: 0x212D030 VA: 0x18212DC30
	|-EnumHelper<long>..cctor
	|
	|-RVA: 0x212DD30 Offset: 0x212D130 VA: 0x18212DD30
	|-EnumHelper<object>..cctor
	|
	|-RVA: 0x212E130 Offset: 0x212D530 VA: 0x18212E130
	|-EnumHelper<sbyte>..cctor
	|
	|-RVA: 0x212E030 Offset: 0x212D430 VA: 0x18212E030
	|-EnumHelper<ushort>..cctor
	|
	|-RVA: 0x212D930 Offset: 0x212CD30 VA: 0x18212D930
	|-EnumHelper<uint>..cctor
	|
	|-RVA: 0x212DE30 Offset: 0x212D230 VA: 0x18212DE30
	|-EnumHelper<ulong>..cctor
	*/

}

private sealed class EnumHelper.Transformer<UnderlyingType, ValueType> : MulticastDelegate // TypeDefIndex: 1512
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-EnumHelper.Transformer<byte, bool>..ctor
	|-EnumHelper.Transformer<byte, byte>..ctor
	|-EnumHelper.Transformer<byte, char>..ctor
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<byte, DateTime>..ctor
	|-EnumHelper.Transformer<byte, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<byte, Decimal>..ctor
	|-EnumHelper.Transformer<byte, EmptyStruct>..ctor
	|-EnumHelper.Transformer<byte, double>..ctor
	|-EnumHelper.Transformer<byte, Guid>..ctor
	|-EnumHelper.Transformer<byte, short>..ctor
	|-EnumHelper.Transformer<byte, int>..ctor
	|-EnumHelper.Transformer<byte, long>..ctor
	|-EnumHelper.Transformer<byte, IntPtr>..ctor
	|-EnumHelper.Transformer<byte, object>..ctor
	|-EnumHelper.Transformer<byte, sbyte>..ctor
	|-EnumHelper.Transformer<byte, float>..ctor
	|-EnumHelper.Transformer<byte, TimeSpan>..ctor
	|-EnumHelper.Transformer<byte, ushort>..ctor
	|-EnumHelper.Transformer<byte, uint>..ctor
	|-EnumHelper.Transformer<byte, ulong>..ctor
	|-EnumHelper.Transformer<byte, UIntPtr>..ctor
	|-EnumHelper.Transformer<short, bool>..ctor
	|-EnumHelper.Transformer<short, byte>..ctor
	|-EnumHelper.Transformer<short, char>..ctor
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<short, DateTime>..ctor
	|-EnumHelper.Transformer<short, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<short, Decimal>..ctor
	|-EnumHelper.Transformer<short, EmptyStruct>..ctor
	|-EnumHelper.Transformer<short, double>..ctor
	|-EnumHelper.Transformer<short, Guid>..ctor
	|-EnumHelper.Transformer<short, short>..ctor
	|-EnumHelper.Transformer<short, int>..ctor
	|-EnumHelper.Transformer<short, long>..ctor
	|-EnumHelper.Transformer<short, IntPtr>..ctor
	|-EnumHelper.Transformer<short, object>..ctor
	|-EnumHelper.Transformer<short, sbyte>..ctor
	|-EnumHelper.Transformer<short, float>..ctor
	|-EnumHelper.Transformer<short, TimeSpan>..ctor
	|-EnumHelper.Transformer<short, ushort>..ctor
	|-EnumHelper.Transformer<short, uint>..ctor
	|-EnumHelper.Transformer<short, ulong>..ctor
	|-EnumHelper.Transformer<short, UIntPtr>..ctor
	|-EnumHelper.Transformer<int, bool>..ctor
	|-EnumHelper.Transformer<int, byte>..ctor
	|-EnumHelper.Transformer<int, char>..ctor
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<int, DateTime>..ctor
	|-EnumHelper.Transformer<int, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<int, Decimal>..ctor
	|-EnumHelper.Transformer<int, EmptyStruct>..ctor
	|-EnumHelper.Transformer<int, double>..ctor
	|-EnumHelper.Transformer<int, Guid>..ctor
	|-EnumHelper.Transformer<int, short>..ctor
	|-EnumHelper.Transformer<int, int>..ctor
	|-EnumHelper.Transformer<int, long>..ctor
	|-EnumHelper.Transformer<int, IntPtr>..ctor
	|-EnumHelper.Transformer<int, object>..ctor
	|-EnumHelper.Transformer<int, sbyte>..ctor
	|-EnumHelper.Transformer<int, float>..ctor
	|-EnumHelper.Transformer<int, TimeSpan>..ctor
	|-EnumHelper.Transformer<int, ushort>..ctor
	|-EnumHelper.Transformer<int, uint>..ctor
	|-EnumHelper.Transformer<int, ulong>..ctor
	|-EnumHelper.Transformer<int, UIntPtr>..ctor
	|-EnumHelper.Transformer<long, bool>..ctor
	|-EnumHelper.Transformer<long, byte>..ctor
	|-EnumHelper.Transformer<long, char>..ctor
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<long, DateTime>..ctor
	|-EnumHelper.Transformer<long, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<long, Decimal>..ctor
	|-EnumHelper.Transformer<long, EmptyStruct>..ctor
	|-EnumHelper.Transformer<long, double>..ctor
	|-EnumHelper.Transformer<long, Guid>..ctor
	|-EnumHelper.Transformer<long, short>..ctor
	|-EnumHelper.Transformer<long, int>..ctor
	|-EnumHelper.Transformer<long, long>..ctor
	|-EnumHelper.Transformer<long, IntPtr>..ctor
	|-EnumHelper.Transformer<long, object>..ctor
	|-EnumHelper.Transformer<long, sbyte>..ctor
	|-EnumHelper.Transformer<long, float>..ctor
	|-EnumHelper.Transformer<long, TimeSpan>..ctor
	|-EnumHelper.Transformer<long, ushort>..ctor
	|-EnumHelper.Transformer<long, uint>..ctor
	|-EnumHelper.Transformer<long, ulong>..ctor
	|-EnumHelper.Transformer<long, UIntPtr>..ctor
	|-EnumHelper.Transformer<object, object>..ctor
	|-EnumHelper.Transformer<sbyte, bool>..ctor
	|-EnumHelper.Transformer<sbyte, byte>..ctor
	|-EnumHelper.Transformer<sbyte, char>..ctor
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<sbyte, DateTime>..ctor
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<sbyte, Decimal>..ctor
	|-EnumHelper.Transformer<sbyte, EmptyStruct>..ctor
	|-EnumHelper.Transformer<sbyte, double>..ctor
	|-EnumHelper.Transformer<sbyte, Guid>..ctor
	|-EnumHelper.Transformer<sbyte, short>..ctor
	|-EnumHelper.Transformer<sbyte, int>..ctor
	|-EnumHelper.Transformer<sbyte, long>..ctor
	|-EnumHelper.Transformer<sbyte, IntPtr>..ctor
	|-EnumHelper.Transformer<sbyte, object>..ctor
	|-EnumHelper.Transformer<sbyte, sbyte>..ctor
	|-EnumHelper.Transformer<sbyte, float>..ctor
	|-EnumHelper.Transformer<sbyte, TimeSpan>..ctor
	|-EnumHelper.Transformer<sbyte, ushort>..ctor
	|-EnumHelper.Transformer<sbyte, uint>..ctor
	|-EnumHelper.Transformer<sbyte, ulong>..ctor
	|-EnumHelper.Transformer<sbyte, UIntPtr>..ctor
	|-EnumHelper.Transformer<ushort, bool>..ctor
	|-EnumHelper.Transformer<ushort, byte>..ctor
	|-EnumHelper.Transformer<ushort, char>..ctor
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<ushort, DateTime>..ctor
	|-EnumHelper.Transformer<ushort, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<ushort, Decimal>..ctor
	|-EnumHelper.Transformer<ushort, EmptyStruct>..ctor
	|-EnumHelper.Transformer<ushort, double>..ctor
	|-EnumHelper.Transformer<ushort, Guid>..ctor
	|-EnumHelper.Transformer<ushort, short>..ctor
	|-EnumHelper.Transformer<ushort, int>..ctor
	|-EnumHelper.Transformer<ushort, long>..ctor
	|-EnumHelper.Transformer<ushort, IntPtr>..ctor
	|-EnumHelper.Transformer<ushort, object>..ctor
	|-EnumHelper.Transformer<ushort, sbyte>..ctor
	|-EnumHelper.Transformer<ushort, float>..ctor
	|-EnumHelper.Transformer<ushort, TimeSpan>..ctor
	|-EnumHelper.Transformer<ushort, ushort>..ctor
	|-EnumHelper.Transformer<ushort, uint>..ctor
	|-EnumHelper.Transformer<ushort, ulong>..ctor
	|-EnumHelper.Transformer<ushort, UIntPtr>..ctor
	|-EnumHelper.Transformer<uint, bool>..ctor
	|-EnumHelper.Transformer<uint, byte>..ctor
	|-EnumHelper.Transformer<uint, char>..ctor
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<uint, DateTime>..ctor
	|-EnumHelper.Transformer<uint, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<uint, Decimal>..ctor
	|-EnumHelper.Transformer<uint, EmptyStruct>..ctor
	|-EnumHelper.Transformer<uint, double>..ctor
	|-EnumHelper.Transformer<uint, Guid>..ctor
	|-EnumHelper.Transformer<uint, short>..ctor
	|-EnumHelper.Transformer<uint, int>..ctor
	|-EnumHelper.Transformer<uint, long>..ctor
	|-EnumHelper.Transformer<uint, IntPtr>..ctor
	|-EnumHelper.Transformer<uint, object>..ctor
	|-EnumHelper.Transformer<uint, sbyte>..ctor
	|-EnumHelper.Transformer<uint, float>..ctor
	|-EnumHelper.Transformer<uint, TimeSpan>..ctor
	|-EnumHelper.Transformer<uint, ushort>..ctor
	|-EnumHelper.Transformer<uint, uint>..ctor
	|-EnumHelper.Transformer<uint, ulong>..ctor
	|-EnumHelper.Transformer<uint, UIntPtr>..ctor
	|-EnumHelper.Transformer<ulong, bool>..ctor
	|-EnumHelper.Transformer<ulong, byte>..ctor
	|-EnumHelper.Transformer<ulong, char>..ctor
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<ulong, DateTime>..ctor
	|-EnumHelper.Transformer<ulong, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<ulong, Decimal>..ctor
	|-EnumHelper.Transformer<ulong, EmptyStruct>..ctor
	|-EnumHelper.Transformer<ulong, double>..ctor
	|-EnumHelper.Transformer<ulong, Guid>..ctor
	|-EnumHelper.Transformer<ulong, short>..ctor
	|-EnumHelper.Transformer<ulong, int>..ctor
	|-EnumHelper.Transformer<ulong, long>..ctor
	|-EnumHelper.Transformer<ulong, IntPtr>..ctor
	|-EnumHelper.Transformer<ulong, object>..ctor
	|-EnumHelper.Transformer<ulong, sbyte>..ctor
	|-EnumHelper.Transformer<ulong, float>..ctor
	|-EnumHelper.Transformer<ulong, TimeSpan>..ctor
	|-EnumHelper.Transformer<ulong, ushort>..ctor
	|-EnumHelper.Transformer<ulong, uint>..ctor
	|-EnumHelper.Transformer<ulong, ulong>..ctor
	|-EnumHelper.Transformer<ulong, UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual UnderlyingType Invoke(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189E6A0 Offset: 0x189DAA0 VA: 0x18189E6A0
	|-EnumHelper.Transformer<byte, bool>.Invoke
	|-EnumHelper.Transformer<byte, byte>.Invoke
	|-EnumHelper.Transformer<byte, sbyte>.Invoke
	|-EnumHelper.Transformer<sbyte, bool>.Invoke
	|-EnumHelper.Transformer<sbyte, byte>.Invoke
	|-EnumHelper.Transformer<sbyte, sbyte>.Invoke
	|
	|-RVA: 0x18A0FE0 Offset: 0x18A03E0 VA: 0x1818A0FE0
	|-EnumHelper.Transformer<byte, char>.Invoke
	|-EnumHelper.Transformer<byte, short>.Invoke
	|-EnumHelper.Transformer<byte, ushort>.Invoke
	|-EnumHelper.Transformer<sbyte, char>.Invoke
	|-EnumHelper.Transformer<sbyte, short>.Invoke
	|-EnumHelper.Transformer<sbyte, ushort>.Invoke
	|
	|-RVA: 0x16CD280 Offset: 0x16CC680 VA: 0x1816CD280
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<byte, Decimal>.Invoke
	|-EnumHelper.Transformer<byte, Guid>.Invoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<sbyte, Decimal>.Invoke
	|-EnumHelper.Transformer<sbyte, Guid>.Invoke
	|
	|-RVA: 0x16CD5C0 Offset: 0x16CC9C0 VA: 0x1816CD5C0
	|-EnumHelper.Transformer<byte, DateTime>.Invoke
	|-EnumHelper.Transformer<byte, TimeSpan>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTime>.Invoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.Invoke
	|
	|-RVA: 0x18A2F60 Offset: 0x18A2360 VA: 0x1818A2F60
	|-EnumHelper.Transformer<byte, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.Invoke
	|
	|-RVA: 0x18A1B20 Offset: 0x18A0F20 VA: 0x1818A1B20
	|-EnumHelper.Transformer<byte, double>.Invoke
	|-EnumHelper.Transformer<sbyte, double>.Invoke
	|
	|-RVA: 0x1468840 Offset: 0x1467C40 VA: 0x181468840
	|-EnumHelper.Transformer<byte, int>.Invoke
	|-EnumHelper.Transformer<byte, uint>.Invoke
	|-EnumHelper.Transformer<sbyte, int>.Invoke
	|-EnumHelper.Transformer<sbyte, uint>.Invoke
	|
	|-RVA: 0x1B112D0 Offset: 0x1B106D0 VA: 0x181B112D0
	|-EnumHelper.Transformer<byte, long>.Invoke
	|-EnumHelper.Transformer<byte, IntPtr>.Invoke
	|-EnumHelper.Transformer<byte, ulong>.Invoke
	|-EnumHelper.Transformer<byte, UIntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, long>.Invoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, ulong>.Invoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.Invoke
	|
	|-RVA: 0x1780DE0 Offset: 0x17801E0 VA: 0x181780DE0
	|-EnumHelper.Transformer<byte, object>.Invoke
	|-EnumHelper.Transformer<sbyte, object>.Invoke
	|
	|-RVA: 0x189F660 Offset: 0x189EA60 VA: 0x18189F660
	|-EnumHelper.Transformer<byte, float>.Invoke
	|-EnumHelper.Transformer<sbyte, float>.Invoke
	|
	|-RVA: 0x1B11AC0 Offset: 0x1B10EC0 VA: 0x181B11AC0
	|-EnumHelper.Transformer<short, bool>.Invoke
	|-EnumHelper.Transformer<short, byte>.Invoke
	|-EnumHelper.Transformer<short, sbyte>.Invoke
	|-EnumHelper.Transformer<ushort, bool>.Invoke
	|-EnumHelper.Transformer<ushort, byte>.Invoke
	|-EnumHelper.Transformer<ushort, sbyte>.Invoke
	|
	|-RVA: 0x1B139D0 Offset: 0x1B12DD0 VA: 0x181B139D0
	|-EnumHelper.Transformer<short, char>.Invoke
	|-EnumHelper.Transformer<short, short>.Invoke
	|-EnumHelper.Transformer<short, ushort>.Invoke
	|-EnumHelper.Transformer<ushort, char>.Invoke
	|-EnumHelper.Transformer<ushort, short>.Invoke
	|-EnumHelper.Transformer<ushort, ushort>.Invoke
	|
	|-RVA: 0x1B13090 Offset: 0x1B12490 VA: 0x181B13090
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<short, Decimal>.Invoke
	|-EnumHelper.Transformer<short, Guid>.Invoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ushort, Decimal>.Invoke
	|-EnumHelper.Transformer<ushort, Guid>.Invoke
	|
	|-RVA: 0x1B133D0 Offset: 0x1B127D0 VA: 0x181B133D0
	|-EnumHelper.Transformer<short, DateTime>.Invoke
	|-EnumHelper.Transformer<short, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ushort, DateTime>.Invoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.Invoke
	|
	|-RVA: 0x1B142E0 Offset: 0x1B136E0 VA: 0x181B142E0
	|-EnumHelper.Transformer<short, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B10DC0 Offset: 0x1B101C0 VA: 0x181B10DC0
	|-EnumHelper.Transformer<short, double>.Invoke
	|-EnumHelper.Transformer<ushort, double>.Invoke
	|
	|-RVA: 0x1B10310 Offset: 0x1B0F710 VA: 0x181B10310
	|-EnumHelper.Transformer<short, int>.Invoke
	|-EnumHelper.Transformer<short, uint>.Invoke
	|-EnumHelper.Transformer<ushort, int>.Invoke
	|-EnumHelper.Transformer<ushort, uint>.Invoke
	|
	|-RVA: 0x1B12100 Offset: 0x1B11500 VA: 0x181B12100
	|-EnumHelper.Transformer<short, long>.Invoke
	|-EnumHelper.Transformer<short, IntPtr>.Invoke
	|-EnumHelper.Transformer<short, ulong>.Invoke
	|-EnumHelper.Transformer<short, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, long>.Invoke
	|-EnumHelper.Transformer<ushort, IntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, ulong>.Invoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.Invoke
	|
	|-RVA: 0x1B12900 Offset: 0x1B11D00 VA: 0x181B12900
	|-EnumHelper.Transformer<short, object>.Invoke
	|-EnumHelper.Transformer<ushort, object>.Invoke
	|
	|-RVA: 0x1B145E0 Offset: 0x1B139E0 VA: 0x181B145E0
	|-EnumHelper.Transformer<short, float>.Invoke
	|-EnumHelper.Transformer<ushort, float>.Invoke
	|
	|-RVA: 0x1B12D90 Offset: 0x1B12190 VA: 0x181B12D90
	|-EnumHelper.Transformer<int, bool>.Invoke
	|-EnumHelper.Transformer<int, byte>.Invoke
	|-EnumHelper.Transformer<int, sbyte>.Invoke
	|-EnumHelper.Transformer<uint, bool>.Invoke
	|-EnumHelper.Transformer<uint, byte>.Invoke
	|-EnumHelper.Transformer<uint, sbyte>.Invoke
	|
	|-RVA: 0x1B12600 Offset: 0x1B11A00 VA: 0x181B12600
	|-EnumHelper.Transformer<int, char>.Invoke
	|-EnumHelper.Transformer<int, short>.Invoke
	|-EnumHelper.Transformer<int, ushort>.Invoke
	|-EnumHelper.Transformer<uint, char>.Invoke
	|-EnumHelper.Transformer<uint, short>.Invoke
	|-EnumHelper.Transformer<uint, ushort>.Invoke
	|
	|-RVA: 0x1B11DC0 Offset: 0x1B111C0 VA: 0x181B11DC0
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<int, Decimal>.Invoke
	|-EnumHelper.Transformer<int, Guid>.Invoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<uint, Decimal>.Invoke
	|-EnumHelper.Transformer<uint, Guid>.Invoke
	|
	|-RVA: 0x1B136D0 Offset: 0x1B12AD0 VA: 0x181B136D0
	|-EnumHelper.Transformer<int, DateTime>.Invoke
	|-EnumHelper.Transformer<int, TimeSpan>.Invoke
	|-EnumHelper.Transformer<uint, DateTime>.Invoke
	|-EnumHelper.Transformer<uint, TimeSpan>.Invoke
	|
	|-RVA: 0x1B13CD0 Offset: 0x1B130D0 VA: 0x181B13CD0
	|-EnumHelper.Transformer<int, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B13FD0 Offset: 0x1B133D0 VA: 0x181B13FD0
	|-EnumHelper.Transformer<int, double>.Invoke
	|-EnumHelper.Transformer<uint, double>.Invoke
	|
	|-RVA: 0x19F5610 Offset: 0x19F4A10 VA: 0x1819F5610
	|-EnumHelper.Transformer<int, int>.Invoke
	|-EnumHelper.Transformer<int, uint>.Invoke
	|-EnumHelper.Transformer<uint, int>.Invoke
	|-EnumHelper.Transformer<uint, uint>.Invoke
	|
	|-RVA: 0x1B110D0 Offset: 0x1B104D0 VA: 0x181B110D0
	|-EnumHelper.Transformer<int, long>.Invoke
	|-EnumHelper.Transformer<int, IntPtr>.Invoke
	|-EnumHelper.Transformer<int, ulong>.Invoke
	|-EnumHelper.Transformer<int, UIntPtr>.Invoke
	|-EnumHelper.Transformer<uint, long>.Invoke
	|-EnumHelper.Transformer<uint, IntPtr>.Invoke
	|-EnumHelper.Transformer<uint, ulong>.Invoke
	|-EnumHelper.Transformer<uint, UIntPtr>.Invoke
	|
	|-RVA: 0x1B10940 Offset: 0x1B0FD40 VA: 0x181B10940
	|-EnumHelper.Transformer<int, object>.Invoke
	|-EnumHelper.Transformer<uint, object>.Invoke
	|
	|-RVA: 0x1B117D0 Offset: 0x1B10BD0 VA: 0x181B117D0
	|-EnumHelper.Transformer<int, float>.Invoke
	|-EnumHelper.Transformer<uint, float>.Invoke
	|
	|-RVA: 0x1B12300 Offset: 0x1B11700 VA: 0x181B12300
	|-EnumHelper.Transformer<long, bool>.Invoke
	|-EnumHelper.Transformer<long, byte>.Invoke
	|-EnumHelper.Transformer<long, sbyte>.Invoke
	|-EnumHelper.Transformer<ulong, bool>.Invoke
	|-EnumHelper.Transformer<ulong, byte>.Invoke
	|-EnumHelper.Transformer<ulong, sbyte>.Invoke
	|
	|-RVA: 0x1B114D0 Offset: 0x1B108D0 VA: 0x181B114D0
	|-EnumHelper.Transformer<long, char>.Invoke
	|-EnumHelper.Transformer<long, short>.Invoke
	|-EnumHelper.Transformer<long, ushort>.Invoke
	|-EnumHelper.Transformer<ulong, char>.Invoke
	|-EnumHelper.Transformer<ulong, short>.Invoke
	|-EnumHelper.Transformer<ulong, ushort>.Invoke
	|
	|-RVA: 0x1B10600 Offset: 0x1B0FA00 VA: 0x181B10600
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<long, Decimal>.Invoke
	|-EnumHelper.Transformer<long, Guid>.Invoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ulong, Decimal>.Invoke
	|-EnumHelper.Transformer<ulong, Guid>.Invoke
	|
	|-RVA: 0x19F7FE0 Offset: 0x19F73E0 VA: 0x1819F7FE0
	|-EnumHelper.Transformer<long, DateTime>.Invoke
	|-EnumHelper.Transformer<long, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ulong, DateTime>.Invoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.Invoke
	|
	|-RVA: 0x1B90530 Offset: 0x1B8F930 VA: 0x181B90530
	|-EnumHelper.Transformer<long, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.Invoke
	|
	|-RVA: 0x20C26F0 Offset: 0x20C1AF0 VA: 0x1820C26F0
	|-EnumHelper.Transformer<long, double>.Invoke
	|-EnumHelper.Transformer<ulong, double>.Invoke
	|
	|-RVA: 0x20C2400 Offset: 0x20C1800 VA: 0x1820C2400
	|-EnumHelper.Transformer<long, int>.Invoke
	|-EnumHelper.Transformer<long, uint>.Invoke
	|-EnumHelper.Transformer<ulong, int>.Invoke
	|-EnumHelper.Transformer<ulong, uint>.Invoke
	|
	|-RVA: 0x20C2A00 Offset: 0x20C1E00 VA: 0x1820C2A00
	|-EnumHelper.Transformer<long, long>.Invoke
	|-EnumHelper.Transformer<long, IntPtr>.Invoke
	|-EnumHelper.Transformer<long, ulong>.Invoke
	|-EnumHelper.Transformer<long, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, long>.Invoke
	|-EnumHelper.Transformer<ulong, IntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, ulong>.Invoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.Invoke
	|
	|-RVA: 0x1336020 Offset: 0x1335420 VA: 0x181336020
	|-EnumHelper.Transformer<long, object>.Invoke
	|-EnumHelper.Transformer<object, object>.Invoke
	|-EnumHelper.Transformer<ulong, object>.Invoke
	|
	|-RVA: 0x20C2C00 Offset: 0x20C2000 VA: 0x1820C2C00
	|-EnumHelper.Transformer<long, float>.Invoke
	|-EnumHelper.Transformer<ulong, float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0F010 Offset: 0x1B0E410 VA: 0x181B0F010
	|-EnumHelper.Transformer<byte, bool>.BeginInvoke
	|
	|-RVA: 0x1B0E210 Offset: 0x1B0D610 VA: 0x181B0E210
	|-EnumHelper.Transformer<byte, byte>.BeginInvoke
	|
	|-RVA: 0x1B0F710 Offset: 0x1B0EB10 VA: 0x181B0F710
	|-EnumHelper.Transformer<byte, char>.BeginInvoke
	|
	|-RVA: 0x1B10090 Offset: 0x1B0F490 VA: 0x181B10090
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B10210 Offset: 0x1B0F610 VA: 0x181B10210
	|-EnumHelper.Transformer<byte, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B10190 Offset: 0x1B0F590 VA: 0x181B10190
	|-EnumHelper.Transformer<byte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B0FC90 Offset: 0x1B0F090 VA: 0x181B0FC90
	|-EnumHelper.Transformer<byte, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B0F210 Offset: 0x1B0E610 VA: 0x181B0F210
	|-EnumHelper.Transformer<byte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B0FD90 Offset: 0x1B0F190 VA: 0x181B0FD90
	|-EnumHelper.Transformer<byte, double>.BeginInvoke
	|
	|-RVA: 0x1B0E990 Offset: 0x1B0DD90 VA: 0x181B0E990
	|-EnumHelper.Transformer<byte, Guid>.BeginInvoke
	|
	|-RVA: 0x1B0F990 Offset: 0x1B0ED90 VA: 0x181B0F990
	|-EnumHelper.Transformer<byte, short>.BeginInvoke
	|
	|-RVA: 0x1B0EA90 Offset: 0x1B0DE90 VA: 0x181B0EA90
	|-EnumHelper.Transformer<byte, int>.BeginInvoke
	|
	|-RVA: 0x1B0FE90 Offset: 0x1B0F290 VA: 0x181B0FE90
	|-EnumHelper.Transformer<byte, long>.BeginInvoke
	|
	|-RVA: 0x1B0ED90 Offset: 0x1B0E190 VA: 0x181B0ED90
	|-EnumHelper.Transformer<byte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-EnumHelper.Transformer<byte, object>.BeginInvoke
	|-EnumHelper.Transformer<short, object>.BeginInvoke
	|-EnumHelper.Transformer<int, object>.BeginInvoke
	|-EnumHelper.Transformer<long, object>.BeginInvoke
	|-EnumHelper.Transformer<object, object>.BeginInvoke
	|-EnumHelper.Transformer<sbyte, object>.BeginInvoke
	|-EnumHelper.Transformer<ushort, object>.BeginInvoke
	|-EnumHelper.Transformer<uint, object>.BeginInvoke
	|-EnumHelper.Transformer<ulong, object>.BeginInvoke
	|
	|-RVA: 0x1B0FA90 Offset: 0x1B0EE90 VA: 0x181B0FA90
	|-EnumHelper.Transformer<byte, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B0F510 Offset: 0x1B0E910 VA: 0x181B0F510
	|-EnumHelper.Transformer<byte, float>.BeginInvoke
	|
	|-RVA: 0x1B0FF90 Offset: 0x1B0F390 VA: 0x181B0FF90
	|-EnumHelper.Transformer<byte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B0E390 Offset: 0x1B0D790 VA: 0x181B0E390
	|-EnumHelper.Transformer<byte, ushort>.BeginInvoke
	|
	|-RVA: 0x1B0FB10 Offset: 0x1B0EF10 VA: 0x181B0FB10
	|-EnumHelper.Transformer<byte, uint>.BeginInvoke
	|
	|-RVA: 0x1B0EB90 Offset: 0x1B0DF90 VA: 0x181B0EB90
	|-EnumHelper.Transformer<byte, ulong>.BeginInvoke
	|
	|-RVA: 0x1B0E090 Offset: 0x1B0D490 VA: 0x181B0E090
	|-EnumHelper.Transformer<byte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B0F790 Offset: 0x1B0EB90 VA: 0x181B0F790
	|-EnumHelper.Transformer<short, bool>.BeginInvoke
	|
	|-RVA: 0x1B0F590 Offset: 0x1B0E990 VA: 0x181B0F590
	|-EnumHelper.Transformer<short, byte>.BeginInvoke
	|
	|-RVA: 0x1B0E810 Offset: 0x1B0DC10 VA: 0x181B0E810
	|-EnumHelper.Transformer<short, char>.BeginInvoke
	|
	|-RVA: 0x1B0E490 Offset: 0x1B0D890 VA: 0x181B0E490
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B0E010 Offset: 0x1B0D410 VA: 0x181B0E010
	|-EnumHelper.Transformer<short, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B0EF90 Offset: 0x1B0E390 VA: 0x181B0EF90
	|-EnumHelper.Transformer<short, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B0E290 Offset: 0x1B0D690 VA: 0x181B0E290
	|-EnumHelper.Transformer<short, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B0FC10 Offset: 0x1B0F010 VA: 0x181B0FC10
	|-EnumHelper.Transformer<short, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B0EF10 Offset: 0x1B0E310 VA: 0x181B0EF10
	|-EnumHelper.Transformer<short, double>.BeginInvoke
	|
	|-RVA: 0x1B0E790 Offset: 0x1B0DB90 VA: 0x181B0E790
	|-EnumHelper.Transformer<short, Guid>.BeginInvoke
	|
	|-RVA: 0x1B0E590 Offset: 0x1B0D990 VA: 0x181B0E590
	|-EnumHelper.Transformer<short, short>.BeginInvoke
	|
	|-RVA: 0x1B0E410 Offset: 0x1B0D810 VA: 0x181B0E410
	|-EnumHelper.Transformer<short, int>.BeginInvoke
	|
	|-RVA: 0x1B0E710 Offset: 0x1B0DB10 VA: 0x181B0E710
	|-EnumHelper.Transformer<short, long>.BeginInvoke
	|
	|-RVA: 0x1B0E310 Offset: 0x1B0D710 VA: 0x181B0E310
	|-EnumHelper.Transformer<short, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B0E510 Offset: 0x1B0D910 VA: 0x181B0E510
	|-EnumHelper.Transformer<short, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B10290 Offset: 0x1B0F690 VA: 0x181B10290
	|-EnumHelper.Transformer<short, float>.BeginInvoke
	|
	|-RVA: 0x1B10010 Offset: 0x1B0F410 VA: 0x181B10010
	|-EnumHelper.Transformer<short, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B0E910 Offset: 0x1B0DD10 VA: 0x181B0E910
	|-EnumHelper.Transformer<short, ushort>.BeginInvoke
	|
	|-RVA: 0x1B0EC90 Offset: 0x1B0E090 VA: 0x181B0EC90
	|-EnumHelper.Transformer<short, uint>.BeginInvoke
	|
	|-RVA: 0x1B0F610 Offset: 0x1B0EA10 VA: 0x181B0F610
	|-EnumHelper.Transformer<short, ulong>.BeginInvoke
	|
	|-RVA: 0x1B0EE90 Offset: 0x1B0E290 VA: 0x181B0EE90
	|-EnumHelper.Transformer<short, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B0FF10 Offset: 0x1B0F310 VA: 0x181B0FF10
	|-EnumHelper.Transformer<int, bool>.BeginInvoke
	|
	|-RVA: 0x1B0E890 Offset: 0x1B0DC90 VA: 0x181B0E890
	|-EnumHelper.Transformer<int, byte>.BeginInvoke
	|
	|-RVA: 0x1B0EB10 Offset: 0x1B0DF10 VA: 0x181B0EB10
	|-EnumHelper.Transformer<int, char>.BeginInvoke
	|
	|-RVA: 0x1B0F090 Offset: 0x1B0E490 VA: 0x181B0F090
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B0F110 Offset: 0x1B0E510 VA: 0x181B0F110
	|-EnumHelper.Transformer<int, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B0F410 Offset: 0x1B0E810 VA: 0x181B0F410
	|-EnumHelper.Transformer<int, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B0F290 Offset: 0x1B0E690 VA: 0x181B0F290
	|-EnumHelper.Transformer<int, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B0FB90 Offset: 0x1B0EF90 VA: 0x181B0FB90
	|-EnumHelper.Transformer<int, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B0EE10 Offset: 0x1B0E210 VA: 0x181B0EE10
	|-EnumHelper.Transformer<int, double>.BeginInvoke
	|
	|-RVA: 0x1B10110 Offset: 0x1B0F510 VA: 0x181B10110
	|-EnumHelper.Transformer<int, Guid>.BeginInvoke
	|
	|-RVA: 0x1B0F490 Offset: 0x1B0E890 VA: 0x181B0F490
	|-EnumHelper.Transformer<int, short>.BeginInvoke
	|
	|-RVA: 0x1B0FE10 Offset: 0x1B0F210 VA: 0x181B0FE10
	|-EnumHelper.Transformer<int, int>.BeginInvoke
	|
	|-RVA: 0x1B0F890 Offset: 0x1B0EC90 VA: 0x181B0F890
	|-EnumHelper.Transformer<int, long>.BeginInvoke
	|
	|-RVA: 0x1B0FA10 Offset: 0x1B0EE10 VA: 0x181B0FA10
	|-EnumHelper.Transformer<int, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B0E610 Offset: 0x1B0DA10 VA: 0x181B0E610
	|-EnumHelper.Transformer<int, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B0E110 Offset: 0x1B0D510 VA: 0x181B0E110
	|-EnumHelper.Transformer<int, float>.BeginInvoke
	|
	|-RVA: 0x1B0F690 Offset: 0x1B0EA90 VA: 0x181B0F690
	|-EnumHelper.Transformer<int, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B0EA10 Offset: 0x1B0DE10 VA: 0x181B0EA10
	|-EnumHelper.Transformer<int, ushort>.BeginInvoke
	|
	|-RVA: 0x1B0F390 Offset: 0x1B0E790 VA: 0x181B0F390
	|-EnumHelper.Transformer<int, uint>.BeginInvoke
	|
	|-RVA: 0x1B0E190 Offset: 0x1B0D590 VA: 0x181B0E190
	|-EnumHelper.Transformer<int, ulong>.BeginInvoke
	|
	|-RVA: 0x1B0F190 Offset: 0x1B0E590 VA: 0x181B0F190
	|-EnumHelper.Transformer<int, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B0EC10 Offset: 0x1B0E010 VA: 0x181B0EC10
	|-EnumHelper.Transformer<long, bool>.BeginInvoke
	|
	|-RVA: 0x1B0F810 Offset: 0x1B0EC10 VA: 0x181B0F810
	|-EnumHelper.Transformer<long, byte>.BeginInvoke
	|
	|-RVA: 0x1B0E690 Offset: 0x1B0DA90 VA: 0x181B0E690
	|-EnumHelper.Transformer<long, char>.BeginInvoke
	|
	|-RVA: 0x1B0F310 Offset: 0x1B0E710 VA: 0x181B0F310
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B0FD10 Offset: 0x1B0F110 VA: 0x181B0FD10
	|-EnumHelper.Transformer<long, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B0F910 Offset: 0x1B0ED10 VA: 0x181B0F910
	|-EnumHelper.Transformer<long, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B0ED10 Offset: 0x1B0E110 VA: 0x181B0ED10
	|-EnumHelper.Transformer<long, Decimal>.BeginInvoke
	|
	|-RVA: 0x2136A00 Offset: 0x2135E00 VA: 0x182136A00
	|-EnumHelper.Transformer<long, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x2136B00 Offset: 0x2135F00 VA: 0x182136B00
	|-EnumHelper.Transformer<long, double>.BeginInvoke
	|
	|-RVA: 0x2134C80 Offset: 0x2134080 VA: 0x182134C80
	|-EnumHelper.Transformer<long, Guid>.BeginInvoke
	|
	|-RVA: 0x2136380 Offset: 0x2135780 VA: 0x182136380
	|-EnumHelper.Transformer<long, short>.BeginInvoke
	|
	|-RVA: 0x2135980 Offset: 0x2134D80 VA: 0x182135980
	|-EnumHelper.Transformer<long, int>.BeginInvoke
	|
	|-RVA: 0x2136000 Offset: 0x2135400 VA: 0x182136000
	|-EnumHelper.Transformer<long, long>.BeginInvoke
	|
	|-RVA: 0x2135C00 Offset: 0x2135000 VA: 0x182135C00
	|-EnumHelper.Transformer<long, IntPtr>.BeginInvoke
	|
	|-RVA: 0x2136700 Offset: 0x2135B00 VA: 0x182136700
	|-EnumHelper.Transformer<long, sbyte>.BeginInvoke
	|
	|-RVA: 0x2135880 Offset: 0x2134C80 VA: 0x182135880
	|-EnumHelper.Transformer<long, float>.BeginInvoke
	|
	|-RVA: 0x2137A80 Offset: 0x2136E80 VA: 0x182137A80
	|-EnumHelper.Transformer<long, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x2135300 Offset: 0x2134700 VA: 0x182135300
	|-EnumHelper.Transformer<long, ushort>.BeginInvoke
	|
	|-RVA: 0x2136B80 Offset: 0x2135F80 VA: 0x182136B80
	|-EnumHelper.Transformer<long, uint>.BeginInvoke
	|
	|-RVA: 0x2135B80 Offset: 0x2134F80 VA: 0x182135B80
	|-EnumHelper.Transformer<long, ulong>.BeginInvoke
	|
	|-RVA: 0x2136D80 Offset: 0x2136180 VA: 0x182136D80
	|-EnumHelper.Transformer<long, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x2135100 Offset: 0x2134500 VA: 0x182135100
	|-EnumHelper.Transformer<sbyte, bool>.BeginInvoke
	|
	|-RVA: 0x2135900 Offset: 0x2134D00 VA: 0x182135900
	|-EnumHelper.Transformer<sbyte, byte>.BeginInvoke
	|
	|-RVA: 0x2135480 Offset: 0x2134880 VA: 0x182135480
	|-EnumHelper.Transformer<sbyte, char>.BeginInvoke
	|
	|-RVA: 0x2137100 Offset: 0x2136500 VA: 0x182137100
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2136780 Offset: 0x2135B80 VA: 0x182136780
	|-EnumHelper.Transformer<sbyte, DateTime>.BeginInvoke
	|
	|-RVA: 0x2135000 Offset: 0x2134400 VA: 0x182135000
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x2135A80 Offset: 0x2134E80 VA: 0x182135A80
	|-EnumHelper.Transformer<sbyte, Decimal>.BeginInvoke
	|
	|-RVA: 0x2134B80 Offset: 0x2133F80 VA: 0x182134B80
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x2137180 Offset: 0x2136580 VA: 0x182137180
	|-EnumHelper.Transformer<sbyte, double>.BeginInvoke
	|
	|-RVA: 0x2137200 Offset: 0x2136600 VA: 0x182137200
	|-EnumHelper.Transformer<sbyte, Guid>.BeginInvoke
	|
	|-RVA: 0x2135800 Offset: 0x2134C00 VA: 0x182135800
	|-EnumHelper.Transformer<sbyte, short>.BeginInvoke
	|
	|-RVA: 0x2136900 Offset: 0x2135D00 VA: 0x182136900
	|-EnumHelper.Transformer<sbyte, int>.BeginInvoke
	|
	|-RVA: 0x2136F80 Offset: 0x2136380 VA: 0x182136F80
	|-EnumHelper.Transformer<sbyte, long>.BeginInvoke
	|
	|-RVA: 0x2136100 Offset: 0x2135500 VA: 0x182136100
	|-EnumHelper.Transformer<sbyte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x2136E80 Offset: 0x2136280 VA: 0x182136E80
	|-EnumHelper.Transformer<sbyte, sbyte>.BeginInvoke
	|
	|-RVA: 0x2136800 Offset: 0x2135C00 VA: 0x182136800
	|-EnumHelper.Transformer<sbyte, float>.BeginInvoke
	|
	|-RVA: 0x2136200 Offset: 0x2135600 VA: 0x182136200
	|-EnumHelper.Transformer<sbyte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x2137980 Offset: 0x2136D80 VA: 0x182137980
	|-EnumHelper.Transformer<sbyte, ushort>.BeginInvoke
	|
	|-RVA: 0x2134E80 Offset: 0x2134280 VA: 0x182134E80
	|-EnumHelper.Transformer<sbyte, uint>.BeginInvoke
	|
	|-RVA: 0x2134C00 Offset: 0x2134000 VA: 0x182134C00
	|-EnumHelper.Transformer<sbyte, ulong>.BeginInvoke
	|
	|-RVA: 0x2134A00 Offset: 0x2133E00 VA: 0x182134A00
	|-EnumHelper.Transformer<sbyte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x2136680 Offset: 0x2135A80 VA: 0x182136680
	|-EnumHelper.Transformer<ushort, bool>.BeginInvoke
	|
	|-RVA: 0x2135D80 Offset: 0x2135180 VA: 0x182135D80
	|-EnumHelper.Transformer<ushort, byte>.BeginInvoke
	|
	|-RVA: 0x2136500 Offset: 0x2135900 VA: 0x182136500
	|-EnumHelper.Transformer<ushort, char>.BeginInvoke
	|
	|-RVA: 0x2135E00 Offset: 0x2135200 VA: 0x182135E00
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2135280 Offset: 0x2134680 VA: 0x182135280
	|-EnumHelper.Transformer<ushort, DateTime>.BeginInvoke
	|
	|-RVA: 0x2134F80 Offset: 0x2134380 VA: 0x182134F80
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x2135F00 Offset: 0x2135300 VA: 0x182135F00
	|-EnumHelper.Transformer<ushort, Decimal>.BeginInvoke
	|
	|-RVA: 0x2134D80 Offset: 0x2134180 VA: 0x182134D80
	|-EnumHelper.Transformer<ushort, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x2136280 Offset: 0x2135680 VA: 0x182136280
	|-EnumHelper.Transformer<ushort, double>.BeginInvoke
	|
	|-RVA: 0x2134A80 Offset: 0x2133E80 VA: 0x182134A80
	|-EnumHelper.Transformer<ushort, Guid>.BeginInvoke
	|
	|-RVA: 0x2136880 Offset: 0x2135C80 VA: 0x182136880
	|-EnumHelper.Transformer<ushort, short>.BeginInvoke
	|
	|-RVA: 0x2137780 Offset: 0x2136B80 VA: 0x182137780
	|-EnumHelper.Transformer<ushort, int>.BeginInvoke
	|
	|-RVA: 0x2135580 Offset: 0x2134980 VA: 0x182135580
	|-EnumHelper.Transformer<ushort, long>.BeginInvoke
	|
	|-RVA: 0x2134B00 Offset: 0x2133F00 VA: 0x182134B00
	|-EnumHelper.Transformer<ushort, IntPtr>.BeginInvoke
	|
	|-RVA: 0x2136D00 Offset: 0x2136100 VA: 0x182136D00
	|-EnumHelper.Transformer<ushort, sbyte>.BeginInvoke
	|
	|-RVA: 0x2135500 Offset: 0x2134900 VA: 0x182135500
	|-EnumHelper.Transformer<ushort, float>.BeginInvoke
	|
	|-RVA: 0x2135F80 Offset: 0x2135380 VA: 0x182135F80
	|-EnumHelper.Transformer<ushort, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x2137300 Offset: 0x2136700 VA: 0x182137300
	|-EnumHelper.Transformer<ushort, ushort>.BeginInvoke
	|
	|-RVA: 0x2136080 Offset: 0x2135480 VA: 0x182136080
	|-EnumHelper.Transformer<ushort, uint>.BeginInvoke
	|
	|-RVA: 0x2135400 Offset: 0x2134800 VA: 0x182135400
	|-EnumHelper.Transformer<ushort, ulong>.BeginInvoke
	|
	|-RVA: 0x2135D00 Offset: 0x2135100 VA: 0x182135D00
	|-EnumHelper.Transformer<ushort, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x2136600 Offset: 0x2135A00 VA: 0x182136600
	|-EnumHelper.Transformer<uint, bool>.BeginInvoke
	|
	|-RVA: 0x2136180 Offset: 0x2135580 VA: 0x182136180
	|-EnumHelper.Transformer<uint, byte>.BeginInvoke
	|
	|-RVA: 0x2137580 Offset: 0x2136980 VA: 0x182137580
	|-EnumHelper.Transformer<uint, char>.BeginInvoke
	|
	|-RVA: 0x2136480 Offset: 0x2135880 VA: 0x182136480
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2135180 Offset: 0x2134580 VA: 0x182135180
	|-EnumHelper.Transformer<uint, DateTime>.BeginInvoke
	|
	|-RVA: 0x2135380 Offset: 0x2134780 VA: 0x182135380
	|-EnumHelper.Transformer<uint, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x2135680 Offset: 0x2134A80 VA: 0x182135680
	|-EnumHelper.Transformer<uint, Decimal>.BeginInvoke
	|
	|-RVA: 0x2136C00 Offset: 0x2136000 VA: 0x182136C00
	|-EnumHelper.Transformer<uint, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x2134E00 Offset: 0x2134200 VA: 0x182134E00
	|-EnumHelper.Transformer<uint, double>.BeginInvoke
	|
	|-RVA: 0x2137000 Offset: 0x2136400 VA: 0x182137000
	|-EnumHelper.Transformer<uint, Guid>.BeginInvoke
	|
	|-RVA: 0x2135C80 Offset: 0x2135080 VA: 0x182135C80
	|-EnumHelper.Transformer<uint, short>.BeginInvoke
	|
	|-RVA: 0x2135780 Offset: 0x2134B80 VA: 0x182135780
	|-EnumHelper.Transformer<uint, int>.BeginInvoke
	|
	|-RVA: 0x2137600 Offset: 0x2136A00 VA: 0x182137600
	|-EnumHelper.Transformer<uint, long>.BeginInvoke
	|
	|-RVA: 0x2137380 Offset: 0x2136780 VA: 0x182137380
	|-EnumHelper.Transformer<uint, IntPtr>.BeginInvoke
	|
	|-RVA: 0x2137900 Offset: 0x2136D00 VA: 0x182137900
	|-EnumHelper.Transformer<uint, sbyte>.BeginInvoke
	|
	|-RVA: 0x2136400 Offset: 0x2135800 VA: 0x182136400
	|-EnumHelper.Transformer<uint, float>.BeginInvoke
	|
	|-RVA: 0x2137A00 Offset: 0x2136E00 VA: 0x182137A00
	|-EnumHelper.Transformer<uint, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x2135E80 Offset: 0x2135280 VA: 0x182135E80
	|-EnumHelper.Transformer<uint, ushort>.BeginInvoke
	|
	|-RVA: 0x2137700 Offset: 0x2136B00 VA: 0x182137700
	|-EnumHelper.Transformer<uint, uint>.BeginInvoke
	|
	|-RVA: 0x2136F00 Offset: 0x2136300 VA: 0x182136F00
	|-EnumHelper.Transformer<uint, ulong>.BeginInvoke
	|
	|-RVA: 0x2137680 Offset: 0x2136A80 VA: 0x182137680
	|-EnumHelper.Transformer<uint, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x2137400 Offset: 0x2136800 VA: 0x182137400
	|-EnumHelper.Transformer<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x2137500 Offset: 0x2136900 VA: 0x182137500
	|-EnumHelper.Transformer<ulong, byte>.BeginInvoke
	|
	|-RVA: 0x2137880 Offset: 0x2136C80 VA: 0x182137880
	|-EnumHelper.Transformer<ulong, char>.BeginInvoke
	|
	|-RVA: 0x2136A80 Offset: 0x2135E80 VA: 0x182136A80
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2136300 Offset: 0x2135700 VA: 0x182136300
	|-EnumHelper.Transformer<ulong, DateTime>.BeginInvoke
	|
	|-RVA: 0x2134F00 Offset: 0x2134300 VA: 0x182134F00
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x2135700 Offset: 0x2134B00 VA: 0x182135700
	|-EnumHelper.Transformer<ulong, Decimal>.BeginInvoke
	|
	|-RVA: 0x2136580 Offset: 0x2135980 VA: 0x182136580
	|-EnumHelper.Transformer<ulong, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x2135B00 Offset: 0x2134F00 VA: 0x182135B00
	|-EnumHelper.Transformer<ulong, double>.BeginInvoke
	|
	|-RVA: 0x2135200 Offset: 0x2134600 VA: 0x182135200
	|-EnumHelper.Transformer<ulong, Guid>.BeginInvoke
	|
	|-RVA: 0x2137280 Offset: 0x2136680 VA: 0x182137280
	|-EnumHelper.Transformer<ulong, short>.BeginInvoke
	|
	|-RVA: 0x2135600 Offset: 0x2134A00 VA: 0x182135600
	|-EnumHelper.Transformer<ulong, int>.BeginInvoke
	|
	|-RVA: 0x2135A00 Offset: 0x2134E00 VA: 0x182135A00
	|-EnumHelper.Transformer<ulong, long>.BeginInvoke
	|
	|-RVA: 0x2136E00 Offset: 0x2136200 VA: 0x182136E00
	|-EnumHelper.Transformer<ulong, IntPtr>.BeginInvoke
	|
	|-RVA: 0x2134D00 Offset: 0x2134100 VA: 0x182134D00
	|-EnumHelper.Transformer<ulong, sbyte>.BeginInvoke
	|
	|-RVA: 0x2136C80 Offset: 0x2136080 VA: 0x182136C80
	|-EnumHelper.Transformer<ulong, float>.BeginInvoke
	|
	|-RVA: 0x2137480 Offset: 0x2136880 VA: 0x182137480
	|-EnumHelper.Transformer<ulong, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x2137800 Offset: 0x2136C00 VA: 0x182137800
	|-EnumHelper.Transformer<ulong, ushort>.BeginInvoke
	|
	|-RVA: 0x2135080 Offset: 0x2134480 VA: 0x182135080
	|-EnumHelper.Transformer<ulong, uint>.BeginInvoke
	|
	|-RVA: 0x2136980 Offset: 0x2135D80 VA: 0x182136980
	|-EnumHelper.Transformer<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x2137080 Offset: 0x2136480 VA: 0x182137080
	|-EnumHelper.Transformer<ulong, UIntPtr>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual UnderlyingType EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100
	|-EnumHelper.Transformer<byte, bool>.EndInvoke
	|-EnumHelper.Transformer<byte, byte>.EndInvoke
	|-EnumHelper.Transformer<byte, char>.EndInvoke
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<byte, DateTime>.EndInvoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<byte, Decimal>.EndInvoke
	|-EnumHelper.Transformer<byte, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<byte, double>.EndInvoke
	|-EnumHelper.Transformer<byte, Guid>.EndInvoke
	|-EnumHelper.Transformer<byte, short>.EndInvoke
	|-EnumHelper.Transformer<byte, int>.EndInvoke
	|-EnumHelper.Transformer<byte, long>.EndInvoke
	|-EnumHelper.Transformer<byte, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<byte, object>.EndInvoke
	|-EnumHelper.Transformer<byte, sbyte>.EndInvoke
	|-EnumHelper.Transformer<byte, float>.EndInvoke
	|-EnumHelper.Transformer<byte, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<byte, ushort>.EndInvoke
	|-EnumHelper.Transformer<byte, uint>.EndInvoke
	|-EnumHelper.Transformer<byte, ulong>.EndInvoke
	|-EnumHelper.Transformer<byte, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<sbyte, bool>.EndInvoke
	|-EnumHelper.Transformer<sbyte, byte>.EndInvoke
	|-EnumHelper.Transformer<sbyte, char>.EndInvoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<sbyte, DateTime>.EndInvoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<sbyte, Decimal>.EndInvoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<sbyte, double>.EndInvoke
	|-EnumHelper.Transformer<sbyte, Guid>.EndInvoke
	|-EnumHelper.Transformer<sbyte, short>.EndInvoke
	|-EnumHelper.Transformer<sbyte, int>.EndInvoke
	|-EnumHelper.Transformer<sbyte, long>.EndInvoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<sbyte, object>.EndInvoke
	|-EnumHelper.Transformer<sbyte, sbyte>.EndInvoke
	|-EnumHelper.Transformer<sbyte, float>.EndInvoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<sbyte, ushort>.EndInvoke
	|-EnumHelper.Transformer<sbyte, uint>.EndInvoke
	|-EnumHelper.Transformer<sbyte, ulong>.EndInvoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.EndInvoke
	|
	|-RVA: 0xD92880 Offset: 0xD91C80 VA: 0x180D92880
	|-EnumHelper.Transformer<short, bool>.EndInvoke
	|-EnumHelper.Transformer<short, byte>.EndInvoke
	|-EnumHelper.Transformer<short, char>.EndInvoke
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<short, DateTime>.EndInvoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<short, Decimal>.EndInvoke
	|-EnumHelper.Transformer<short, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<short, double>.EndInvoke
	|-EnumHelper.Transformer<short, Guid>.EndInvoke
	|-EnumHelper.Transformer<short, short>.EndInvoke
	|-EnumHelper.Transformer<short, int>.EndInvoke
	|-EnumHelper.Transformer<short, long>.EndInvoke
	|-EnumHelper.Transformer<short, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<short, object>.EndInvoke
	|-EnumHelper.Transformer<short, sbyte>.EndInvoke
	|-EnumHelper.Transformer<short, float>.EndInvoke
	|-EnumHelper.Transformer<short, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<short, ushort>.EndInvoke
	|-EnumHelper.Transformer<short, uint>.EndInvoke
	|-EnumHelper.Transformer<short, ulong>.EndInvoke
	|-EnumHelper.Transformer<short, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<ushort, bool>.EndInvoke
	|-EnumHelper.Transformer<ushort, byte>.EndInvoke
	|-EnumHelper.Transformer<ushort, char>.EndInvoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<ushort, DateTime>.EndInvoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<ushort, Decimal>.EndInvoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<ushort, double>.EndInvoke
	|-EnumHelper.Transformer<ushort, Guid>.EndInvoke
	|-EnumHelper.Transformer<ushort, short>.EndInvoke
	|-EnumHelper.Transformer<ushort, int>.EndInvoke
	|-EnumHelper.Transformer<ushort, long>.EndInvoke
	|-EnumHelper.Transformer<ushort, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<ushort, object>.EndInvoke
	|-EnumHelper.Transformer<ushort, sbyte>.EndInvoke
	|-EnumHelper.Transformer<ushort, float>.EndInvoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<ushort, ushort>.EndInvoke
	|-EnumHelper.Transformer<ushort, uint>.EndInvoke
	|-EnumHelper.Transformer<ushort, ulong>.EndInvoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.EndInvoke
	|
	|-RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0
	|-EnumHelper.Transformer<int, bool>.EndInvoke
	|-EnumHelper.Transformer<int, byte>.EndInvoke
	|-EnumHelper.Transformer<int, char>.EndInvoke
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<int, DateTime>.EndInvoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<int, Decimal>.EndInvoke
	|-EnumHelper.Transformer<int, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<int, double>.EndInvoke
	|-EnumHelper.Transformer<int, Guid>.EndInvoke
	|-EnumHelper.Transformer<int, short>.EndInvoke
	|-EnumHelper.Transformer<int, int>.EndInvoke
	|-EnumHelper.Transformer<int, long>.EndInvoke
	|-EnumHelper.Transformer<int, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<int, object>.EndInvoke
	|-EnumHelper.Transformer<int, sbyte>.EndInvoke
	|-EnumHelper.Transformer<int, float>.EndInvoke
	|-EnumHelper.Transformer<int, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<int, ushort>.EndInvoke
	|-EnumHelper.Transformer<int, uint>.EndInvoke
	|-EnumHelper.Transformer<int, ulong>.EndInvoke
	|-EnumHelper.Transformer<int, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<uint, bool>.EndInvoke
	|-EnumHelper.Transformer<uint, byte>.EndInvoke
	|-EnumHelper.Transformer<uint, char>.EndInvoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<uint, DateTime>.EndInvoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<uint, Decimal>.EndInvoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<uint, double>.EndInvoke
	|-EnumHelper.Transformer<uint, Guid>.EndInvoke
	|-EnumHelper.Transformer<uint, short>.EndInvoke
	|-EnumHelper.Transformer<uint, int>.EndInvoke
	|-EnumHelper.Transformer<uint, long>.EndInvoke
	|-EnumHelper.Transformer<uint, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<uint, object>.EndInvoke
	|-EnumHelper.Transformer<uint, sbyte>.EndInvoke
	|-EnumHelper.Transformer<uint, float>.EndInvoke
	|-EnumHelper.Transformer<uint, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<uint, ushort>.EndInvoke
	|-EnumHelper.Transformer<uint, uint>.EndInvoke
	|-EnumHelper.Transformer<uint, ulong>.EndInvoke
	|-EnumHelper.Transformer<uint, UIntPtr>.EndInvoke
	|
	|-RVA: 0x121BE10 Offset: 0x121B210 VA: 0x18121BE10
	|-EnumHelper.Transformer<long, bool>.EndInvoke
	|-EnumHelper.Transformer<long, byte>.EndInvoke
	|-EnumHelper.Transformer<long, char>.EndInvoke
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<long, DateTime>.EndInvoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<long, Decimal>.EndInvoke
	|-EnumHelper.Transformer<long, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<long, double>.EndInvoke
	|-EnumHelper.Transformer<long, Guid>.EndInvoke
	|-EnumHelper.Transformer<long, short>.EndInvoke
	|-EnumHelper.Transformer<long, int>.EndInvoke
	|-EnumHelper.Transformer<long, long>.EndInvoke
	|-EnumHelper.Transformer<long, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<long, object>.EndInvoke
	|-EnumHelper.Transformer<long, sbyte>.EndInvoke
	|-EnumHelper.Transformer<long, float>.EndInvoke
	|-EnumHelper.Transformer<long, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<long, ushort>.EndInvoke
	|-EnumHelper.Transformer<long, uint>.EndInvoke
	|-EnumHelper.Transformer<long, ulong>.EndInvoke
	|-EnumHelper.Transformer<long, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<ulong, bool>.EndInvoke
	|-EnumHelper.Transformer<ulong, byte>.EndInvoke
	|-EnumHelper.Transformer<ulong, char>.EndInvoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<ulong, DateTime>.EndInvoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<ulong, Decimal>.EndInvoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<ulong, double>.EndInvoke
	|-EnumHelper.Transformer<ulong, Guid>.EndInvoke
	|-EnumHelper.Transformer<ulong, short>.EndInvoke
	|-EnumHelper.Transformer<ulong, int>.EndInvoke
	|-EnumHelper.Transformer<ulong, long>.EndInvoke
	|-EnumHelper.Transformer<ulong, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<ulong, object>.EndInvoke
	|-EnumHelper.Transformer<ulong, sbyte>.EndInvoke
	|-EnumHelper.Transformer<ulong, float>.EndInvoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<ulong, ushort>.EndInvoke
	|-EnumHelper.Transformer<ulong, uint>.EndInvoke
	|-EnumHelper.Transformer<ulong, ulong>.EndInvoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.EndInvoke
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-EnumHelper.Transformer<object, object>.EndInvoke
	*/

}

private static class EnumHelper.Caster<UnderlyingType, ValueType> // TypeDefIndex: 1513
{	// Fields
	public static readonly EnumHelper.Transformer<UnderlyingType, ValueType> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AF6490 Offset: 0x1AF5890 VA: 0x181AF6490
	|-EnumHelper.Caster<byte, bool>..cctor
	|
	|-RVA: 0x1AF1840 Offset: 0x1AF0C40 VA: 0x181AF1840
	|-EnumHelper.Caster<byte, byte>..cctor
	|
	|-RVA: 0x1AFAC40 Offset: 0x1AFA040 VA: 0x181AFAC40
	|-EnumHelper.Caster<byte, char>..cctor
	|
	|-RVA: 0x1AFEF50 Offset: 0x1AFE350 VA: 0x181AFEF50
	|-EnumHelper.Caster<byte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AF8BE0 Offset: 0x1AF7FE0 VA: 0x181AF8BE0
	|-EnumHelper.Caster<byte, DateTime>..cctor
	|
	|-RVA: 0x1B00D60 Offset: 0x1B00160 VA: 0x181B00D60
	|-EnumHelper.Caster<byte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B05510 Offset: 0x1B04910 VA: 0x181B05510
	|-EnumHelper.Caster<byte, Decimal>..cctor
	|
	|-RVA: 0x1AF9770 Offset: 0x1AF8B70 VA: 0x181AF9770
	|-EnumHelper.Caster<byte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B08C90 Offset: 0x1B08090 VA: 0x181B08C90
	|-EnumHelper.Caster<byte, double>..cctor
	|
	|-RVA: 0x1B09820 Offset: 0x1B08C20 VA: 0x181B09820
	|-EnumHelper.Caster<byte, Guid>..cctor
	|
	|-RVA: 0x1AF13A0 Offset: 0x1AF07A0 VA: 0x181AF13A0
	|-EnumHelper.Caster<byte, short>..cctor
	|
	|-RVA: 0x1AF66E0 Offset: 0x1AF5AE0 VA: 0x181AF66E0
	|-EnumHelper.Caster<byte, int>..cctor
	|
	|-RVA: 0x1AF8E30 Offset: 0x1AF8230 VA: 0x181AF8E30
	|-EnumHelper.Caster<byte, long>..cctor
	|
	|-RVA: 0x1AFE170 Offset: 0x1AFD570 VA: 0x181AFE170
	|-EnumHelper.Caster<byte, IntPtr>..cctor
	|
	|-RVA: 0x1B08A40 Offset: 0x1B07E40 VA: 0x181B08A40
	|-EnumHelper.Caster<byte, object>..cctor
	|
	|-RVA: 0x1B01B40 Offset: 0x1B00F40 VA: 0x181B01B40
	|-EnumHelper.Caster<byte, sbyte>..cctor
	|
	|-RVA: 0x1AFD140 Offset: 0x1AFC540 VA: 0x181AFD140
	|-EnumHelper.Caster<byte, float>..cctor
	|
	|-RVA: 0x1AF4B20 Offset: 0x1AF3F20 VA: 0x181AF4B20
	|-EnumHelper.Caster<byte, TimeSpan>..cctor
	|
	|-RVA: 0x1AF6240 Offset: 0x1AF5640 VA: 0x181AF6240
	|-EnumHelper.Caster<byte, ushort>..cctor
	|
	|-RVA: 0x1AF8990 Offset: 0x1AF7D90 VA: 0x181AF8990
	|-EnumHelper.Caster<byte, uint>..cctor
	|
	|-RVA: 0x1B062F0 Offset: 0x1B056F0 VA: 0x181B062F0
	|-EnumHelper.Caster<byte, ulong>..cctor
	|
	|-RVA: 0x1AF74C0 Offset: 0x1AF68C0 VA: 0x181AF74C0
	|-EnumHelper.Caster<byte, UIntPtr>..cctor
	|
	|-RVA: 0x1B07C60 Offset: 0x1B07060 VA: 0x181B07C60
	|-EnumHelper.Caster<short, bool>..cctor
	|
	|-RVA: 0x1AF2AC0 Offset: 0x1AF1EC0 VA: 0x181AF2AC0
	|-EnumHelper.Caster<short, byte>..cctor
	|
	|-RVA: 0x1AF2620 Offset: 0x1AF1A20 VA: 0x181AF2620
	|-EnumHelper.Caster<short, char>..cctor
	|
	|-RVA: 0x1AFBEC0 Offset: 0x1AFB2C0 VA: 0x181AFBEC0
	|-EnumHelper.Caster<short, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFB580 Offset: 0x1AFA980 VA: 0x181AFB580
	|-EnumHelper.Caster<short, DateTime>..cctor
	|
	|-RVA: 0x1B016A0 Offset: 0x1B00AA0 VA: 0x181B016A0
	|-EnumHelper.Caster<short, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AF56B0 Offset: 0x1AF4AB0 VA: 0x181AF56B0
	|-EnumHelper.Caster<short, Decimal>..cctor
	|
	|-RVA: 0x1B059B0 Offset: 0x1B04DB0 VA: 0x181B059B0
	|-EnumHelper.Caster<short, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF4680 Offset: 0x1AF3A80 VA: 0x181AF4680
	|-EnumHelper.Caster<short, double>..cctor
	|
	|-RVA: 0x1B008C0 Offset: 0x1AFFCC0 VA: 0x181B008C0
	|-EnumHelper.Caster<short, Guid>..cctor
	|
	|-RVA: 0x1AFFF80 Offset: 0x1AFF380 VA: 0x181AFFF80
	|-EnumHelper.Caster<short, short>..cctor
	|
	|-RVA: 0x1AFAE90 Offset: 0x1AFA290 VA: 0x181AFAE90
	|-EnumHelper.Caster<short, int>..cctor
	|
	|-RVA: 0x1AF7710 Offset: 0x1AF6B10 VA: 0x181AF7710
	|-EnumHelper.Caster<short, long>..cctor
	|
	|-RVA: 0x1B026D0 Offset: 0x1B01AD0 VA: 0x181B026D0
	|-EnumHelper.Caster<short, IntPtr>..cctor
	|
	|-RVA: 0x1AFC360 Offset: 0x1AFB760 VA: 0x181AFC360
	|-EnumHelper.Caster<short, object>..cctor
	|
	|-RVA: 0x1AFDA80 Offset: 0x1AFCE80 VA: 0x181AFDA80
	|-EnumHelper.Caster<short, sbyte>..cctor
	|
	|-RVA: 0x1B03BA0 Offset: 0x1B02FA0 VA: 0x181B03BA0
	|-EnumHelper.Caster<short, float>..cctor
	|
	|-RVA: 0x1B03950 Offset: 0x1B02D50 VA: 0x181B03950
	|-EnumHelper.Caster<short, TimeSpan>..cctor
	|
	|-RVA: 0x1B070D0 Offset: 0x1B064D0 VA: 0x181B070D0
	|-EnumHelper.Caster<short, ushort>..cctor
	|
	|-RVA: 0x1AF5FF0 Offset: 0x1AF53F0 VA: 0x181AF5FF0
	|-EnumHelper.Caster<short, uint>..cctor
	|
	|-RVA: 0x1AF8050 Offset: 0x1AF7450 VA: 0x181AF8050
	|-EnumHelper.Caster<short, ulong>..cctor
	|
	|-RVA: 0x1B04040 Offset: 0x1B03440 VA: 0x181B04040
	|-EnumHelper.Caster<short, UIntPtr>..cctor
	|
	|-RVA: 0x1AF0370 Offset: 0x1AEF770 VA: 0x181AF0370
	|-EnumHelper.Caster<int, bool>..cctor
	|
	|-RVA: 0x1AF3650 Offset: 0x1AF2A50 VA: 0x181AF3650
	|-EnumHelper.Caster<int, byte>..cctor
	|
	|-RVA: 0x1AF31B0 Offset: 0x1AF25B0 VA: 0x181AF31B0
	|-EnumHelper.Caster<int, char>..cctor
	|
	|-RVA: 0x1B04BD0 Offset: 0x1B03FD0 VA: 0x181B04BD0
	|-EnumHelper.Caster<int, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B02480 Offset: 0x1B01880 VA: 0x181B02480
	|-EnumHelper.Caster<int, DateTime>..cctor
	|
	|-RVA: 0x1AF92D0 Offset: 0x1AF86D0 VA: 0x181AF92D0
	|-EnumHelper.Caster<int, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFEAB0 Offset: 0x1AFDEB0 VA: 0x181AFEAB0
	|-EnumHelper.Caster<int, Decimal>..cctor
	|
	|-RVA: 0x1B00670 Offset: 0x1AFFA70 VA: 0x181B00670
	|-EnumHelper.Caster<int, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF41E0 Offset: 0x1AF35E0 VA: 0x181AF41E0
	|-EnumHelper.Caster<int, double>..cctor
	|
	|-RVA: 0x1AF0CB0 Offset: 0x1AF00B0 VA: 0x181AF0CB0
	|-EnumHelper.Caster<int, Guid>..cctor
	|
	|-RVA: 0x1AF7BB0 Offset: 0x1AF6FB0 VA: 0x181AF7BB0
	|-EnumHelper.Caster<int, short>..cctor
	|
	|-RVA: 0x1AF2870 Offset: 0x1AF1C70 VA: 0x181AF2870
	|-EnumHelper.Caster<int, int>..cctor
	|
	|-RVA: 0x1B05070 Offset: 0x1B04470 VA: 0x181B05070
	|-EnumHelper.Caster<int, long>..cctor
	|
	|-RVA: 0x1AF0A60 Offset: 0x1AEFE60 VA: 0x181AF0A60
	|-EnumHelper.Caster<int, IntPtr>..cctor
	|
	|-RVA: 0x1B05760 Offset: 0x1B04B60 VA: 0x181B05760
	|-EnumHelper.Caster<int, object>..cctor
	|
	|-RVA: 0x1B03260 Offset: 0x1B02660 VA: 0x181B03260
	|-EnumHelper.Caster<int, sbyte>..cctor
	|
	|-RVA: 0x1AF5900 Offset: 0x1AF4D00 VA: 0x181AF5900
	|-EnumHelper.Caster<int, float>..cctor
	|
	|-RVA: 0x1B00FB0 Offset: 0x1B003B0 VA: 0x181B00FB0
	|-EnumHelper.Caster<int, TimeSpan>..cctor
	|
	|-RVA: 0x1B087F0 Offset: 0x1B07BF0 VA: 0x181B087F0
	|-EnumHelper.Caster<int, ushort>..cctor
	|
	|-RVA: 0x1AFB7D0 Offset: 0x1AFABD0 VA: 0x181AFB7D0
	|-EnumHelper.Caster<int, uint>..cctor
	|
	|-RVA: 0x1AF2F60 Offset: 0x1AF2360 VA: 0x181AF2F60
	|-EnumHelper.Caster<int, ulong>..cctor
	|
	|-RVA: 0x1B02920 Offset: 0x1B01D20 VA: 0x181B02920
	|-EnumHelper.Caster<int, UIntPtr>..cctor
	|
	|-RVA: 0x1AFE610 Offset: 0x1AFDA10 VA: 0x181AFE610
	|-EnumHelper.Caster<long, bool>..cctor
	|
	|-RVA: 0x1AFA300 Offset: 0x1AF9700 VA: 0x181AFA300
	|-EnumHelper.Caster<long, byte>..cctor
	|
	|-RVA: 0x1AFDCD0 Offset: 0x1AFD0D0 VA: 0x181AFDCD0
	|-EnumHelper.Caster<long, char>..cctor
	|
	|-RVA: 0x1AF38A0 Offset: 0x1AF2CA0 VA: 0x181AF38A0
	|-EnumHelper.Caster<long, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AF4D70 Offset: 0x1AF4170 VA: 0x181AF4D70
	|-EnumHelper.Caster<long, DateTime>..cctor
	|
	|-RVA: 0x1AFC110 Offset: 0x1AFB510 VA: 0x181AFC110
	|-EnumHelper.Caster<long, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFA550 Offset: 0x1AF9950 VA: 0x181AFA550
	|-EnumHelper.Caster<long, Decimal>..cctor
	|
	|-RVA: 0x1B034B0 Offset: 0x1B028B0 VA: 0x181B034B0
	|-EnumHelper.Caster<long, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF0F00 Offset: 0x1AF0300 VA: 0x181AF0F00
	|-EnumHelper.Caster<long, double>..cctor
	|
	|-RVA: 0x1AF99C0 Offset: 0x1AF8DC0 VA: 0x181AF99C0
	|-EnumHelper.Caster<long, Guid>..cctor
	|
	|-RVA: 0x1B04980 Offset: 0x1B03D80 VA: 0x181B04980
	|-EnumHelper.Caster<long, short>..cctor
	|
	|-RVA: 0x1AFA9F0 Offset: 0x1AF9DF0 VA: 0x181AFA9F0
	|-EnumHelper.Caster<long, int>..cctor
	|
	|-RVA: 0x1AF84F0 Offset: 0x1AF78F0 VA: 0x181AF84F0
	|-EnumHelper.Caster<long, long>..cctor
	|
	|-RVA: 0x1B095D0 Offset: 0x1B089D0 VA: 0x181B095D0
	|-EnumHelper.Caster<long, IntPtr>..cctor
	|
	|-RVA: 0x1AF3400 Offset: 0x1AF2800 VA: 0x181AF3400
	|-EnumHelper.Caster<long, object>..cctor
	|
	|-RVA: 0x1B06540 Offset: 0x1B05940 VA: 0x181B06540
	|-EnumHelper.Caster<long, sbyte>..cctor
	|
	|-RVA: 0x1AF3D40 Offset: 0x1AF3140 VA: 0x181AF3D40
	|-EnumHelper.Caster<long, float>..cctor
	|
	|-RVA: 0x1AF1F30 Offset: 0x1AF1330 VA: 0x181AF1F30
	|-EnumHelper.Caster<long, TimeSpan>..cctor
	|
	|-RVA: 0x1AFFD30 Offset: 0x1AFF130 VA: 0x181AFFD30
	|-EnumHelper.Caster<long, ushort>..cctor
	|
	|-RVA: 0x1AFCCA0 Offset: 0x1AFC0A0 VA: 0x181AFCCA0
	|-EnumHelper.Caster<long, uint>..cctor
	|
	|-RVA: 0x1B07EB0 Offset: 0x1B072B0 VA: 0x181B07EB0
	|-EnumHelper.Caster<long, ulong>..cctor
	|
	|-RVA: 0x1AFD390 Offset: 0x1AFC790 VA: 0x181AFD390
	|-EnumHelper.Caster<long, UIntPtr>..cctor
	|
	|-RVA: 0x1B00420 Offset: 0x1AFF820 VA: 0x181B00420
	|-EnumHelper.Caster<object, object>..cctor
	|
	|-RVA: 0x1AF5B50 Offset: 0x1AF4F50 VA: 0x181AF5B50
	|-EnumHelper.Caster<sbyte, bool>..cctor
	|
	|-RVA: 0x1B09130 Offset: 0x1B08530 VA: 0x181B09130
	|-EnumHelper.Caster<sbyte, byte>..cctor
	|
	|-RVA: 0x1AF1CE0 Offset: 0x1AF10E0 VA: 0x181AF1CE0
	|-EnumHelper.Caster<sbyte, char>..cctor
	|
	|-RVA: 0x1B04E20 Offset: 0x1B04220 VA: 0x181B04E20
	|-EnumHelper.Caster<sbyte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AF5460 Offset: 0x1AF4860 VA: 0x181AF5460
	|-EnumHelper.Caster<sbyte, DateTime>..cctor
	|
	|-RVA: 0x1AF6930 Offset: 0x1AF5D30 VA: 0x181AF6930
	|-EnumHelper.Caster<sbyte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AF7020 Offset: 0x1AF6420 VA: 0x181AF7020
	|-EnumHelper.Caster<sbyte, Decimal>..cctor
	|
	|-RVA: 0x1AF1150 Offset: 0x1AF0550 VA: 0x181AF1150
	|-EnumHelper.Caster<sbyte, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFE3C0 Offset: 0x1AFD7C0 VA: 0x181AFE3C0
	|-EnumHelper.Caster<sbyte, double>..cctor
	|
	|-RVA: 0x1AFF3F0 Offset: 0x1AFE7F0 VA: 0x181AFF3F0
	|-EnumHelper.Caster<sbyte, Guid>..cctor
	|
	|-RVA: 0x1B044E0 Offset: 0x1B038E0 VA: 0x181B044E0
	|-EnumHelper.Caster<sbyte, short>..cctor
	|
	|-RVA: 0x1B06C30 Offset: 0x1B06030 VA: 0x181B06C30
	|-EnumHelper.Caster<sbyte, int>..cctor
	|
	|-RVA: 0x1AF7E00 Offset: 0x1AF7200 VA: 0x181AF7E00
	|-EnumHelper.Caster<sbyte, long>..cctor
	|
	|-RVA: 0x1B04290 Offset: 0x1B03690 VA: 0x181B04290
	|-EnumHelper.Caster<sbyte, IntPtr>..cctor
	|
	|-RVA: 0x1AFF1A0 Offset: 0x1AFE5A0 VA: 0x181AFF1A0
	|-EnumHelper.Caster<sbyte, object>..cctor
	|
	|-RVA: 0x1B07320 Offset: 0x1B06720 VA: 0x181B07320
	|-EnumHelper.Caster<sbyte, sbyte>..cctor
	|
	|-RVA: 0x1B02230 Offset: 0x1B01630 VA: 0x181B02230
	|-EnumHelper.Caster<sbyte, float>..cctor
	|
	|-RVA: 0x1AFB0E0 Offset: 0x1AFA4E0 VA: 0x181AFB0E0
	|-EnumHelper.Caster<sbyte, TimeSpan>..cctor
	|
	|-RVA: 0x1AF4FC0 Offset: 0x1AF43C0 VA: 0x181AF4FC0
	|-EnumHelper.Caster<sbyte, ushort>..cctor
	|
	|-RVA: 0x1B052C0 Offset: 0x1B046C0 VA: 0x181B052C0
	|-EnumHelper.Caster<sbyte, uint>..cctor
	|
	|-RVA: 0x1AFF640 Offset: 0x1AFEA40 VA: 0x181AFF640
	|-EnumHelper.Caster<sbyte, ulong>..cctor
	|
	|-RVA: 0x1AF2180 Offset: 0x1AF1580 VA: 0x181AF2180
	|-EnumHelper.Caster<sbyte, UIntPtr>..cctor
	|
	|-RVA: 0x1B03700 Offset: 0x1B02B00 VA: 0x181B03700
	|-EnumHelper.Caster<ushort, bool>..cctor
	|
	|-RVA: 0x1B01200 Offset: 0x1B00600 VA: 0x181B01200
	|-EnumHelper.Caster<ushort, byte>..cctor
	|
	|-RVA: 0x1AFBC70 Offset: 0x1AFB070 VA: 0x181AFBC70
	|-EnumHelper.Caster<ushort, char>..cctor
	|
	|-RVA: 0x1B01D90 Offset: 0x1B01190 VA: 0x181B01D90
	|-EnumHelper.Caster<ushort, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B08350 Offset: 0x1B07750 VA: 0x181B08350
	|-EnumHelper.Caster<ushort, DateTime>..cctor
	|
	|-RVA: 0x1B05C00 Offset: 0x1B05000 VA: 0x181B05C00
	|-EnumHelper.Caster<ushort, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B06790 Offset: 0x1B05B90 VA: 0x181B06790
	|-EnumHelper.Caster<ushort, Decimal>..cctor
	|
	|-RVA: 0x1AF7960 Offset: 0x1AF6D60 VA: 0x181AF7960
	|-EnumHelper.Caster<ushort, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFCA50 Offset: 0x1AFBE50 VA: 0x181AFCA50
	|-EnumHelper.Caster<ushort, double>..cctor
	|
	|-RVA: 0x1AFC800 Offset: 0x1AFBC00 VA: 0x181AFC800
	|-EnumHelper.Caster<ushort, Guid>..cctor
	|
	|-RVA: 0x1AFFAE0 Offset: 0x1AFEEE0 VA: 0x181AFFAE0
	|-EnumHelper.Caster<ushort, short>..cctor
	|
	|-RVA: 0x1B02DC0 Offset: 0x1B021C0 VA: 0x181B02DC0
	|-EnumHelper.Caster<ushort, int>..cctor
	|
	|-RVA: 0x1AFBA20 Offset: 0x1AFAE20 VA: 0x181AFBA20
	|-EnumHelper.Caster<ushort, long>..cctor
	|
	|-RVA: 0x1AFC5B0 Offset: 0x1AFB9B0 VA: 0x181AFC5B0
	|-EnumHelper.Caster<ushort, IntPtr>..cctor
	|
	|-RVA: 0x1B00B10 Offset: 0x1AFFF10 VA: 0x181B00B10
	|-EnumHelper.Caster<ushort, object>..cctor
	|
	|-RVA: 0x1B018F0 Offset: 0x1B00CF0 VA: 0x181B018F0
	|-EnumHelper.Caster<ushort, sbyte>..cctor
	|
	|-RVA: 0x1AF9E60 Offset: 0x1AF9260 VA: 0x181AF9E60
	|-EnumHelper.Caster<ushort, float>..cctor
	|
	|-RVA: 0x1B04730 Offset: 0x1B03B30 VA: 0x181B04730
	|-EnumHelper.Caster<ushort, TimeSpan>..cctor
	|
	|-RVA: 0x1AF82A0 Offset: 0x1AF76A0 VA: 0x181AF82A0
	|-EnumHelper.Caster<ushort, ushort>..cctor
	|
	|-RVA: 0x1AF6B80 Offset: 0x1AF5F80 VA: 0x181AF6B80
	|-EnumHelper.Caster<ushort, uint>..cctor
	|
	|-RVA: 0x1B001D0 Offset: 0x1AFF5D0 VA: 0x181B001D0
	|-EnumHelper.Caster<ushort, ulong>..cctor
	|
	|-RVA: 0x1AFD830 Offset: 0x1AFCC30 VA: 0x181AFD830
	|-EnumHelper.Caster<ushort, UIntPtr>..cctor
	|
	|-RVA: 0x1AF05C0 Offset: 0x1AEF9C0 VA: 0x181AF05C0
	|-EnumHelper.Caster<uint, bool>..cctor
	|
	|-RVA: 0x1AF7270 Offset: 0x1AF6670 VA: 0x181AF7270
	|-EnumHelper.Caster<uint, byte>..cctor
	|
	|-RVA: 0x1AF3F90 Offset: 0x1AF3390 VA: 0x181AF3F90
	|-EnumHelper.Caster<uint, char>..cctor
	|
	|-RVA: 0x1AFED00 Offset: 0x1AFE100 VA: 0x181AFED00
	|-EnumHelper.Caster<uint, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B09A70 Offset: 0x1B08E70 VA: 0x181B09A70
	|-EnumHelper.Caster<uint, DateTime>..cctor
	|
	|-RVA: 0x1B069E0 Offset: 0x1B05DE0 VA: 0x181B069E0
	|-EnumHelper.Caster<uint, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AF9C10 Offset: 0x1AF9010 VA: 0x181AF9C10
	|-EnumHelper.Caster<uint, Decimal>..cctor
	|
	|-RVA: 0x1B09380 Offset: 0x1B08780 VA: 0x181B09380
	|-EnumHelper.Caster<uint, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA0B0 Offset: 0x1AF94B0 VA: 0x181AFA0B0
	|-EnumHelper.Caster<uint, double>..cctor
	|
	|-RVA: 0x1AF9080 Offset: 0x1AF8480 VA: 0x181AF9080
	|-EnumHelper.Caster<uint, Guid>..cctor
	|
	|-RVA: 0x1AF15F0 Offset: 0x1AF09F0 VA: 0x181AF15F0
	|-EnumHelper.Caster<uint, short>..cctor
	|
	|-RVA: 0x1AF5210 Offset: 0x1AF4610 VA: 0x181AF5210
	|-EnumHelper.Caster<uint, int>..cctor
	|
	|-RVA: 0x1AFA7A0 Offset: 0x1AF9BA0 VA: 0x181AFA7A0
	|-EnumHelper.Caster<uint, long>..cctor
	|
	|-RVA: 0x1AFE860 Offset: 0x1AFDC60 VA: 0x181AFE860
	|-EnumHelper.Caster<uint, IntPtr>..cctor
	|
	|-RVA: 0x1B060A0 Offset: 0x1B054A0 VA: 0x181B060A0
	|-EnumHelper.Caster<uint, object>..cctor
	|
	|-RVA: 0x1AF23D0 Offset: 0x1AF17D0 VA: 0x181AF23D0
	|-EnumHelper.Caster<uint, sbyte>..cctor
	|
	|-RVA: 0x1B08100 Offset: 0x1B07500 VA: 0x181B08100
	|-EnumHelper.Caster<uint, float>..cctor
	|
	|-RVA: 0x1AF4430 Offset: 0x1AF3830 VA: 0x181AF4430
	|-EnumHelper.Caster<uint, TimeSpan>..cctor
	|
	|-RVA: 0x1AF8740 Offset: 0x1AF7B40 VA: 0x181AF8740
	|-EnumHelper.Caster<uint, ushort>..cctor
	|
	|-RVA: 0x1AF0810 Offset: 0x1AEFC10 VA: 0x181AF0810
	|-EnumHelper.Caster<uint, uint>..cctor
	|
	|-RVA: 0x1AF1A90 Offset: 0x1AF0E90 VA: 0x181AF1A90
	|-EnumHelper.Caster<uint, ulong>..cctor
	|
	|-RVA: 0x1AF48D0 Offset: 0x1AF3CD0 VA: 0x181AF48D0
	|-EnumHelper.Caster<uint, UIntPtr>..cctor
	|
	|-RVA: 0x1B07A10 Offset: 0x1B06E10 VA: 0x181B07A10
	|-EnumHelper.Caster<ulong, bool>..cctor
	|
	|-RVA: 0x1B05E50 Offset: 0x1B05250 VA: 0x181B05E50
	|-EnumHelper.Caster<ulong, byte>..cctor
	|
	|-RVA: 0x1B07570 Offset: 0x1B06970 VA: 0x181B07570
	|-EnumHelper.Caster<ulong, char>..cctor
	|
	|-RVA: 0x1B02B70 Offset: 0x1B01F70 VA: 0x181B02B70
	|-EnumHelper.Caster<ulong, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AF9520 Offset: 0x1AF8920 VA: 0x181AF9520
	|-EnumHelper.Caster<ulong, DateTime>..cctor
	|
	|-RVA: 0x1B01FE0 Offset: 0x1B013E0 VA: 0x181B01FE0
	|-EnumHelper.Caster<ulong, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFF890 Offset: 0x1AFEC90 VA: 0x181AFF890
	|-EnumHelper.Caster<ulong, Decimal>..cctor
	|
	|-RVA: 0x1AF2D10 Offset: 0x1AF2110 VA: 0x181AF2D10
	|-EnumHelper.Caster<ulong, EmptyStruct>..cctor
	|
	|-RVA: 0x1B06E80 Offset: 0x1B06280 VA: 0x181B06E80
	|-EnumHelper.Caster<ulong, double>..cctor
	|
	|-RVA: 0x1AF3AF0 Offset: 0x1AF2EF0 VA: 0x181AF3AF0
	|-EnumHelper.Caster<ulong, Guid>..cctor
	|
	|-RVA: 0x1B03DF0 Offset: 0x1B031F0 VA: 0x181B03DF0
	|-EnumHelper.Caster<ulong, short>..cctor
	|
	|-RVA: 0x1B077C0 Offset: 0x1B06BC0 VA: 0x181B077C0
	|-EnumHelper.Caster<ulong, int>..cctor
	|
	|-RVA: 0x1AF6DD0 Offset: 0x1AF61D0 VA: 0x181AF6DD0
	|-EnumHelper.Caster<ulong, long>..cctor
	|
	|-RVA: 0x1B01450 Offset: 0x1B00850 VA: 0x181B01450
	|-EnumHelper.Caster<ulong, IntPtr>..cctor
	|
	|-RVA: 0x1AFD5E0 Offset: 0x1AFC9E0 VA: 0x181AFD5E0
	|-EnumHelper.Caster<ulong, object>..cctor
	|
	|-RVA: 0x1B08EE0 Offset: 0x1B082E0 VA: 0x181B08EE0
	|-EnumHelper.Caster<ulong, sbyte>..cctor
	|
	|-RVA: 0x1AF5DA0 Offset: 0x1AF51A0 VA: 0x181AF5DA0
	|-EnumHelper.Caster<ulong, float>..cctor
	|
	|-RVA: 0x1AFB330 Offset: 0x1AFA730 VA: 0x181AFB330
	|-EnumHelper.Caster<ulong, TimeSpan>..cctor
	|
	|-RVA: 0x1AFDF20 Offset: 0x1AFD320 VA: 0x181AFDF20
	|-EnumHelper.Caster<ulong, ushort>..cctor
	|
	|-RVA: 0x1B03010 Offset: 0x1B02410 VA: 0x181B03010
	|-EnumHelper.Caster<ulong, uint>..cctor
	|
	|-RVA: 0x1B085A0 Offset: 0x1B079A0 VA: 0x181B085A0
	|-EnumHelper.Caster<ulong, ulong>..cctor
	|
	|-RVA: 0x1AFCEF0 Offset: 0x1AFC2F0 VA: 0x181AFCEF0
	|-EnumHelper.Caster<ulong, UIntPtr>..cctor
	*/

}

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> // TypeDefIndex: 1514
{	// Fields
	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B48C40 Offset: 0x1B48040 VA: 0x181B48C40
	|-EnumerableTypeInfo<object, object>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B48920 Offset: 0x1B47D20 VA: 0x181B48920
	|-EnumerableTypeInfo<object, object>.WriteData
	*/

}

internal sealed class EnumByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1560
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0D440 Offset: 0x1B0C840 VA: 0x181B0D440
	|-EnumByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B0D710 Offset: 0x1B0CB10 VA: 0x181B0D710
	|-EnumByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B0D680 Offset: 0x1B0CA80 VA: 0x181B0D680
	|-EnumByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B0D950 Offset: 0x1B0CD50 VA: 0x181B0D950
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B0DA70 Offset: 0x1B0CE70 VA: 0x181B0DA70
	|-EnumByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B0D830 Offset: 0x1B0CC30 VA: 0x181B0D830
	|-EnumByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B0D7A0 Offset: 0x1B0CBA0 VA: 0x181B0D7A0
	|-EnumByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B0DB00 Offset: 0x1B0CF00 VA: 0x181B0DB00
	|-EnumByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B0D8C0 Offset: 0x1B0CCC0 VA: 0x181B0D8C0
	|-EnumByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B0D4D0 Offset: 0x1B0C8D0 VA: 0x181B0D4D0
	|-EnumByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B0DB90 Offset: 0x1B0CF90 VA: 0x181B0DB90
	|-EnumByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B0DEF0 Offset: 0x1B0D2F0 VA: 0x181B0DEF0
	|-EnumByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B0DE60 Offset: 0x1B0D260 VA: 0x181B0DE60
	|-EnumByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B0DDD0 Offset: 0x1B0D1D0 VA: 0x181B0DDD0
	|-EnumByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B0D3B0 Offset: 0x1B0C7B0 VA: 0x181B0D3B0
	|-EnumByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B0DCB0 Offset: 0x1B0D0B0 VA: 0x181B0DCB0
	|-EnumByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B0D560 Offset: 0x1B0C960 VA: 0x181B0D560
	|-EnumByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B0DC20 Offset: 0x1B0D020 VA: 0x181B0DC20
	|-EnumByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B0D5F0 Offset: 0x1B0C9F0 VA: 0x181B0D5F0
	|-EnumByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B0DD40 Offset: 0x1B0D140 VA: 0x181B0DD40
	|-EnumByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B0DF80 Offset: 0x1B0D380 VA: 0x181B0DF80
	|-EnumByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B0D9E0 Offset: 0x1B0CDE0 VA: 0x181B0D9E0
	|-EnumByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0C7D0 Offset: 0x1B0BBD0 VA: 0x181B0C7D0
	|-EnumByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B0CEA0 Offset: 0x1B0C2A0 VA: 0x181B0CEA0
	|-EnumByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B0C910 Offset: 0x1B0BD10 VA: 0x181B0C910
	|-EnumByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x1B0C680 Offset: 0x1B0BA80 VA: 0x181B0C680
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B0CCD0 Offset: 0x1B0C0D0 VA: 0x181B0CCD0
	|-EnumByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B0C5D0 Offset: 0x1B0B9D0 VA: 0x181B0C5D0
	|-EnumByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B0CB80 Offset: 0x1B0BF80 VA: 0x181B0CB80
	|-EnumByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B0CAE0 Offset: 0x1B0BEE0 VA: 0x181B0CAE0
	|-EnumByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B0C9B0 Offset: 0x1B0BDB0 VA: 0x181B0C9B0
	|-EnumByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x1B0CF40 Offset: 0x1B0C340 VA: 0x181B0CF40
	|-EnumByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B0C870 Offset: 0x1B0BC70 VA: 0x181B0C870
	|-EnumByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x1B0CA50 Offset: 0x1B0BE50 VA: 0x181B0CA50
	|-EnumByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x1B0D270 Offset: 0x1B0C670 VA: 0x181B0D270
	|-EnumByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x1B0D310 Offset: 0x1B0C710 VA: 0x181B0D310
	|-EnumByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B0D1D0 Offset: 0x1B0C5D0 VA: 0x181B0D1D0
	|-EnumByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x1B0C730 Offset: 0x1B0BB30 VA: 0x181B0C730
	|-EnumByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B0D090 Offset: 0x1B0C490 VA: 0x181B0D090
	|-EnumByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x1B0CFF0 Offset: 0x1B0C3F0 VA: 0x181B0CFF0
	|-EnumByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B0CE00 Offset: 0x1B0C200 VA: 0x181B0CE00
	|-EnumByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B0CD70 Offset: 0x1B0C170 VA: 0x181B0CD70
	|-EnumByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B0D130 Offset: 0x1B0C530 VA: 0x181B0D130
	|-EnumByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B0CC30 Offset: 0x1B0C030 VA: 0x181B0CC30
	|-EnumByteTypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumByteTypeInfo<bool>.GetData
	|-EnumByteTypeInfo<byte>.GetData
	|-EnumByteTypeInfo<char>.GetData
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumByteTypeInfo<DateTime>.GetData
	|-EnumByteTypeInfo<DateTimeOffset>.GetData
	|-EnumByteTypeInfo<Decimal>.GetData
	|-EnumByteTypeInfo<EmptyStruct>.GetData
	|-EnumByteTypeInfo<double>.GetData
	|-EnumByteTypeInfo<Guid>.GetData
	|-EnumByteTypeInfo<short>.GetData
	|-EnumByteTypeInfo<int>.GetData
	|-EnumByteTypeInfo<long>.GetData
	|-EnumByteTypeInfo<IntPtr>.GetData
	|-EnumByteTypeInfo<object>.GetData
	|-EnumByteTypeInfo<sbyte>.GetData
	|-EnumByteTypeInfo<float>.GetData
	|-EnumByteTypeInfo<TimeSpan>.GetData
	|-EnumByteTypeInfo<ushort>.GetData
	|-EnumByteTypeInfo<uint>.GetData
	|-EnumByteTypeInfo<ulong>.GetData
	|-EnumByteTypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumByteTypeInfo<bool>..ctor
	|-EnumByteTypeInfo<byte>..ctor
	|-EnumByteTypeInfo<char>..ctor
	|-EnumByteTypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumByteTypeInfo<DateTime>..ctor
	|-EnumByteTypeInfo<DateTimeOffset>..ctor
	|-EnumByteTypeInfo<Decimal>..ctor
	|-EnumByteTypeInfo<EmptyStruct>..ctor
	|-EnumByteTypeInfo<double>..ctor
	|-EnumByteTypeInfo<Guid>..ctor
	|-EnumByteTypeInfo<short>..ctor
	|-EnumByteTypeInfo<int>..ctor
	|-EnumByteTypeInfo<long>..ctor
	|-EnumByteTypeInfo<IntPtr>..ctor
	|-EnumByteTypeInfo<object>..ctor
	|-EnumByteTypeInfo<sbyte>..ctor
	|-EnumByteTypeInfo<float>..ctor
	|-EnumByteTypeInfo<TimeSpan>..ctor
	|-EnumByteTypeInfo<ushort>..ctor
	|-EnumByteTypeInfo<uint>..ctor
	|-EnumByteTypeInfo<ulong>..ctor
	|-EnumByteTypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumSByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1561
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2133FE0 Offset: 0x21333E0 VA: 0x182133FE0
	|-EnumSByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2134220 Offset: 0x2133620 VA: 0x182134220
	|-EnumSByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2134580 Offset: 0x2133980 VA: 0x182134580
	|-EnumSByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2134340 Offset: 0x2133740 VA: 0x182134340
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2134610 Offset: 0x2133A10 VA: 0x182134610
	|-EnumSByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2133F50 Offset: 0x2133350 VA: 0x182133F50
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2134970 Offset: 0x2133D70 VA: 0x182134970
	|-EnumSByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2134730 Offset: 0x2133B30 VA: 0x182134730
	|-EnumSByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2133E30 Offset: 0x2133230 VA: 0x182133E30
	|-EnumSByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x21346A0 Offset: 0x2133AA0 VA: 0x1821346A0
	|-EnumSByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x21347C0 Offset: 0x2133BC0 VA: 0x1821347C0
	|-EnumSByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2134070 Offset: 0x2133470 VA: 0x182134070
	|-EnumSByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x21343D0 Offset: 0x21337D0 VA: 0x1821343D0
	|-EnumSByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2133EC0 Offset: 0x21332C0 VA: 0x182133EC0
	|-EnumSByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x21342B0 Offset: 0x21336B0 VA: 0x1821342B0
	|-EnumSByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2134460 Offset: 0x2133860 VA: 0x182134460
	|-EnumSByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x21344F0 Offset: 0x21338F0 VA: 0x1821344F0
	|-EnumSByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x21348E0 Offset: 0x2133CE0 VA: 0x1821348E0
	|-EnumSByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2134850 Offset: 0x2133C50 VA: 0x182134850
	|-EnumSByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2134100 Offset: 0x2133500 VA: 0x182134100
	|-EnumSByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2134190 Offset: 0x2133590 VA: 0x182134190
	|-EnumSByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B439D0 Offset: 0x1B42DD0 VA: 0x181B439D0
	|-EnumSByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2133B00 Offset: 0x2132F00 VA: 0x182133B00
	|-EnumSByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x2133CF0 Offset: 0x21330F0 VA: 0x182133CF0
	|-EnumSByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x2133400 Offset: 0x2132800 VA: 0x182133400
	|-EnumSByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x2133690 Offset: 0x2132A90 VA: 0x182133690
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2133BA0 Offset: 0x2132FA0 VA: 0x182133BA0
	|-EnumSByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2133C40 Offset: 0x2133040 VA: 0x182133C40
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2133540 Offset: 0x2132940 VA: 0x182133540
	|-EnumSByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x21335F0 Offset: 0x21329F0 VA: 0x1821335F0
	|-EnumSByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2133A60 Offset: 0x2132E60 VA: 0x182133A60
	|-EnumSByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x2133880 Offset: 0x2132C80 VA: 0x182133880
	|-EnumSByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2133930 Offset: 0x2132D30 VA: 0x182133930
	|-EnumSByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x2133230 Offset: 0x2132630 VA: 0x182133230
	|-EnumSByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x2133360 Offset: 0x2132760 VA: 0x182133360
	|-EnumSByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x2133740 Offset: 0x2132B40 VA: 0x182133740
	|-EnumSByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x21332C0 Offset: 0x21326C0 VA: 0x1821332C0
	|-EnumSByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x2133190 Offset: 0x2132590 VA: 0x182133190
	|-EnumSByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2133D90 Offset: 0x2133190 VA: 0x182133D90
	|-EnumSByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x21330F0 Offset: 0x21324F0 VA: 0x1821330F0
	|-EnumSByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x21337E0 Offset: 0x2132BE0 VA: 0x1821337E0
	|-EnumSByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x21339D0 Offset: 0x2132DD0 VA: 0x1821339D0
	|-EnumSByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x21334A0 Offset: 0x21328A0 VA: 0x1821334A0
	|-EnumSByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B43930 Offset: 0x1B42D30 VA: 0x181B43930
	|-EnumSByteTypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumSByteTypeInfo<bool>.GetData
	|-EnumSByteTypeInfo<byte>.GetData
	|-EnumSByteTypeInfo<char>.GetData
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumSByteTypeInfo<DateTime>.GetData
	|-EnumSByteTypeInfo<DateTimeOffset>.GetData
	|-EnumSByteTypeInfo<Decimal>.GetData
	|-EnumSByteTypeInfo<EmptyStruct>.GetData
	|-EnumSByteTypeInfo<double>.GetData
	|-EnumSByteTypeInfo<Guid>.GetData
	|-EnumSByteTypeInfo<short>.GetData
	|-EnumSByteTypeInfo<int>.GetData
	|-EnumSByteTypeInfo<long>.GetData
	|-EnumSByteTypeInfo<IntPtr>.GetData
	|-EnumSByteTypeInfo<object>.GetData
	|-EnumSByteTypeInfo<sbyte>.GetData
	|-EnumSByteTypeInfo<float>.GetData
	|-EnumSByteTypeInfo<TimeSpan>.GetData
	|-EnumSByteTypeInfo<ushort>.GetData
	|-EnumSByteTypeInfo<uint>.GetData
	|-EnumSByteTypeInfo<ulong>.GetData
	|-EnumSByteTypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumSByteTypeInfo<bool>..ctor
	|-EnumSByteTypeInfo<byte>..ctor
	|-EnumSByteTypeInfo<char>..ctor
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumSByteTypeInfo<DateTime>..ctor
	|-EnumSByteTypeInfo<DateTimeOffset>..ctor
	|-EnumSByteTypeInfo<Decimal>..ctor
	|-EnumSByteTypeInfo<EmptyStruct>..ctor
	|-EnumSByteTypeInfo<double>..ctor
	|-EnumSByteTypeInfo<Guid>..ctor
	|-EnumSByteTypeInfo<short>..ctor
	|-EnumSByteTypeInfo<int>..ctor
	|-EnumSByteTypeInfo<long>..ctor
	|-EnumSByteTypeInfo<IntPtr>..ctor
	|-EnumSByteTypeInfo<object>..ctor
	|-EnumSByteTypeInfo<sbyte>..ctor
	|-EnumSByteTypeInfo<float>..ctor
	|-EnumSByteTypeInfo<TimeSpan>..ctor
	|-EnumSByteTypeInfo<ushort>..ctor
	|-EnumSByteTypeInfo<uint>..ctor
	|-EnumSByteTypeInfo<ulong>..ctor
	|-EnumSByteTypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt16TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1562
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212F640 Offset: 0x212EA40 VA: 0x18212F640
	|-EnumInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x212F2E0 Offset: 0x212E6E0 VA: 0x18212F2E0
	|-EnumInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x212F880 Offset: 0x212EC80 VA: 0x18212F880
	|-EnumInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x212F400 Offset: 0x212E800 VA: 0x18212F400
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x212FA30 Offset: 0x212EE30 VA: 0x18212FA30
	|-EnumInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x212F910 Offset: 0x212ED10 VA: 0x18212F910
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x212F010 Offset: 0x212E410 VA: 0x18212F010
	|-EnumInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x212FBE0 Offset: 0x212EFE0 VA: 0x18212FBE0
	|-EnumInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x212F250 Offset: 0x212E650 VA: 0x18212F250
	|-EnumInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x212FB50 Offset: 0x212EF50 VA: 0x18212FB50
	|-EnumInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x212F6D0 Offset: 0x212EAD0 VA: 0x18212F6D0
	|-EnumInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x212F9A0 Offset: 0x212EDA0 VA: 0x18212F9A0
	|-EnumInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x212FAC0 Offset: 0x212EEC0 VA: 0x18212FAC0
	|-EnumInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x212F0A0 Offset: 0x212E4A0 VA: 0x18212F0A0
	|-EnumInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x212F7F0 Offset: 0x212EBF0 VA: 0x18212F7F0
	|-EnumInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x212F1C0 Offset: 0x212E5C0 VA: 0x18212F1C0
	|-EnumInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x212F520 Offset: 0x212E920 VA: 0x18212F520
	|-EnumInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x212F5B0 Offset: 0x212E9B0 VA: 0x18212F5B0
	|-EnumInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x212F490 Offset: 0x212E890 VA: 0x18212F490
	|-EnumInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x212F130 Offset: 0x212E530 VA: 0x18212F130
	|-EnumInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x212F760 Offset: 0x212EB60 VA: 0x18212F760
	|-EnumInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x212F370 Offset: 0x212E770 VA: 0x18212F370
	|-EnumInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212E2C0 Offset: 0x212D6C0 VA: 0x18212E2C0
	|-EnumInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x212E400 Offset: 0x212D800 VA: 0x18212E400
	|-EnumInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x212EAF0 Offset: 0x212DEF0 VA: 0x18212EAF0
	|-EnumInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x212EE20 Offset: 0x212E220 VA: 0x18212EE20
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x212E540 Offset: 0x212D940 VA: 0x18212E540
	|-EnumInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x212E680 Offset: 0x212DA80 VA: 0x18212E680
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x212EB90 Offset: 0x212DF90 VA: 0x18212EB90
	|-EnumInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x212E9B0 Offset: 0x212DDB0 VA: 0x18212E9B0
	|-EnumInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x212E730 Offset: 0x212DB30 VA: 0x18212E730
	|-EnumInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x212EC40 Offset: 0x212E040 VA: 0x18212EC40
	|-EnumInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x212E7D0 Offset: 0x212DBD0 VA: 0x18212E7D0
	|-EnumInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x212E230 Offset: 0x212D630 VA: 0x18212E230
	|-EnumInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x212EED0 Offset: 0x212E2D0 VA: 0x18212EED0
	|-EnumInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x212E870 Offset: 0x212DC70 VA: 0x18212E870
	|-EnumInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x212E4A0 Offset: 0x212D8A0 VA: 0x18212E4A0
	|-EnumInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x212EF70 Offset: 0x212E370 VA: 0x18212EF70
	|-EnumInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x212E5E0 Offset: 0x212D9E0 VA: 0x18212E5E0
	|-EnumInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x212EA50 Offset: 0x212DE50 VA: 0x18212EA50
	|-EnumInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x212ECF0 Offset: 0x212E0F0 VA: 0x18212ECF0
	|-EnumInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x212ED90 Offset: 0x212E190 VA: 0x18212ED90
	|-EnumInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x212E360 Offset: 0x212D760 VA: 0x18212E360
	|-EnumInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x212E910 Offset: 0x212DD10 VA: 0x18212E910
	|-EnumInt16TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumInt16TypeInfo<bool>.GetData
	|-EnumInt16TypeInfo<byte>.GetData
	|-EnumInt16TypeInfo<char>.GetData
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt16TypeInfo<DateTime>.GetData
	|-EnumInt16TypeInfo<DateTimeOffset>.GetData
	|-EnumInt16TypeInfo<Decimal>.GetData
	|-EnumInt16TypeInfo<EmptyStruct>.GetData
	|-EnumInt16TypeInfo<double>.GetData
	|-EnumInt16TypeInfo<Guid>.GetData
	|-EnumInt16TypeInfo<short>.GetData
	|-EnumInt16TypeInfo<int>.GetData
	|-EnumInt16TypeInfo<long>.GetData
	|-EnumInt16TypeInfo<IntPtr>.GetData
	|-EnumInt16TypeInfo<object>.GetData
	|-EnumInt16TypeInfo<sbyte>.GetData
	|-EnumInt16TypeInfo<float>.GetData
	|-EnumInt16TypeInfo<TimeSpan>.GetData
	|-EnumInt16TypeInfo<ushort>.GetData
	|-EnumInt16TypeInfo<uint>.GetData
	|-EnumInt16TypeInfo<ulong>.GetData
	|-EnumInt16TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumInt16TypeInfo<bool>..ctor
	|-EnumInt16TypeInfo<byte>..ctor
	|-EnumInt16TypeInfo<char>..ctor
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt16TypeInfo<DateTime>..ctor
	|-EnumInt16TypeInfo<DateTimeOffset>..ctor
	|-EnumInt16TypeInfo<Decimal>..ctor
	|-EnumInt16TypeInfo<EmptyStruct>..ctor
	|-EnumInt16TypeInfo<double>..ctor
	|-EnumInt16TypeInfo<Guid>..ctor
	|-EnumInt16TypeInfo<short>..ctor
	|-EnumInt16TypeInfo<int>..ctor
	|-EnumInt16TypeInfo<long>..ctor
	|-EnumInt16TypeInfo<IntPtr>..ctor
	|-EnumInt16TypeInfo<object>..ctor
	|-EnumInt16TypeInfo<sbyte>..ctor
	|-EnumInt16TypeInfo<float>..ctor
	|-EnumInt16TypeInfo<TimeSpan>..ctor
	|-EnumInt16TypeInfo<ushort>..ctor
	|-EnumInt16TypeInfo<uint>..ctor
	|-EnumInt16TypeInfo<ulong>..ctor
	|-EnumInt16TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt16TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1563
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B44D50 Offset: 0x1B44150 VA: 0x181B44D50
	|-EnumUInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B44E70 Offset: 0x1B44270 VA: 0x181B44E70
	|-EnumUInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B45260 Offset: 0x1B44660 VA: 0x181B45260
	|-EnumUInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B45140 Offset: 0x1B44540 VA: 0x181B45140
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B44F00 Offset: 0x1B44300 VA: 0x181B44F00
	|-EnumUInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B44C30 Offset: 0x1B44030 VA: 0x181B44C30
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B45380 Offset: 0x1B44780 VA: 0x181B45380
	|-EnumUInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B45020 Offset: 0x1B44420 VA: 0x181B45020
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B448D0 Offset: 0x1B43CD0 VA: 0x181B448D0
	|-EnumUInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B44B10 Offset: 0x1B43F10 VA: 0x181B44B10
	|-EnumUInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B44960 Offset: 0x1B43D60 VA: 0x181B44960
	|-EnumUInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B44F90 Offset: 0x1B44390 VA: 0x181B44F90
	|-EnumUInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B44840 Offset: 0x1B43C40 VA: 0x181B44840
	|-EnumUInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B449F0 Offset: 0x1B43DF0 VA: 0x181B449F0
	|-EnumUInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B451D0 Offset: 0x1B445D0 VA: 0x181B451D0
	|-EnumUInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B44A80 Offset: 0x1B43E80 VA: 0x181B44A80
	|-EnumUInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B45410 Offset: 0x1B44810 VA: 0x181B45410
	|-EnumUInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B44BA0 Offset: 0x1B43FA0 VA: 0x181B44BA0
	|-EnumUInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B44DE0 Offset: 0x1B441E0 VA: 0x181B44DE0
	|-EnumUInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B44CC0 Offset: 0x1B440C0 VA: 0x181B44CC0
	|-EnumUInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B452F0 Offset: 0x1B446F0 VA: 0x181B452F0
	|-EnumUInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B450B0 Offset: 0x1B444B0 VA: 0x181B450B0
	|-EnumUInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B44320 Offset: 0x1B43720 VA: 0x181B44320
	|-EnumUInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B43ED0 Offset: 0x1B432D0 VA: 0x181B43ED0
	|-EnumUInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B43E30 Offset: 0x1B43230 VA: 0x181B43E30
	|-EnumUInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B446F0 Offset: 0x1B43AF0 VA: 0x181B446F0
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B440B0 Offset: 0x1B434B0 VA: 0x181B440B0
	|-EnumUInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B443C0 Offset: 0x1B437C0 VA: 0x181B443C0
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B43BA0 Offset: 0x1B42FA0 VA: 0x181B43BA0
	|-EnumUInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B43A60 Offset: 0x1B42E60 VA: 0x181B43A60
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B44010 Offset: 0x1B43410 VA: 0x181B44010
	|-EnumUInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B44510 Offset: 0x1B43910 VA: 0x181B44510
	|-EnumUInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B43F70 Offset: 0x1B43370 VA: 0x181B43F70
	|-EnumUInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B445C0 Offset: 0x1B439C0 VA: 0x181B445C0
	|-EnumUInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B43C50 Offset: 0x1B43050 VA: 0x181B43C50
	|-EnumUInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B43D90 Offset: 0x1B43190 VA: 0x181B43D90
	|-EnumUInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B44470 Offset: 0x1B43870 VA: 0x181B44470
	|-EnumUInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B44280 Offset: 0x1B43680 VA: 0x181B44280
	|-EnumUInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B447A0 Offset: 0x1B43BA0 VA: 0x181B447A0
	|-EnumUInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B43CF0 Offset: 0x1B430F0 VA: 0x181B43CF0
	|-EnumUInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B44650 Offset: 0x1B43A50 VA: 0x181B44650
	|-EnumUInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B44150 Offset: 0x1B43550 VA: 0x181B44150
	|-EnumUInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B441E0 Offset: 0x1B435E0 VA: 0x181B441E0
	|-EnumUInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B43B00 Offset: 0x1B42F00 VA: 0x181B43B00
	|-EnumUInt16TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumUInt16TypeInfo<bool>.GetData
	|-EnumUInt16TypeInfo<byte>.GetData
	|-EnumUInt16TypeInfo<char>.GetData
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt16TypeInfo<DateTime>.GetData
	|-EnumUInt16TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt16TypeInfo<Decimal>.GetData
	|-EnumUInt16TypeInfo<EmptyStruct>.GetData
	|-EnumUInt16TypeInfo<double>.GetData
	|-EnumUInt16TypeInfo<Guid>.GetData
	|-EnumUInt16TypeInfo<short>.GetData
	|-EnumUInt16TypeInfo<int>.GetData
	|-EnumUInt16TypeInfo<long>.GetData
	|-EnumUInt16TypeInfo<IntPtr>.GetData
	|-EnumUInt16TypeInfo<object>.GetData
	|-EnumUInt16TypeInfo<sbyte>.GetData
	|-EnumUInt16TypeInfo<float>.GetData
	|-EnumUInt16TypeInfo<TimeSpan>.GetData
	|-EnumUInt16TypeInfo<ushort>.GetData
	|-EnumUInt16TypeInfo<uint>.GetData
	|-EnumUInt16TypeInfo<ulong>.GetData
	|-EnumUInt16TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumUInt16TypeInfo<bool>..ctor
	|-EnumUInt16TypeInfo<byte>..ctor
	|-EnumUInt16TypeInfo<char>..ctor
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt16TypeInfo<DateTime>..ctor
	|-EnumUInt16TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt16TypeInfo<Decimal>..ctor
	|-EnumUInt16TypeInfo<EmptyStruct>..ctor
	|-EnumUInt16TypeInfo<double>..ctor
	|-EnumUInt16TypeInfo<Guid>..ctor
	|-EnumUInt16TypeInfo<short>..ctor
	|-EnumUInt16TypeInfo<int>..ctor
	|-EnumUInt16TypeInfo<long>..ctor
	|-EnumUInt16TypeInfo<IntPtr>..ctor
	|-EnumUInt16TypeInfo<object>..ctor
	|-EnumUInt16TypeInfo<sbyte>..ctor
	|-EnumUInt16TypeInfo<float>..ctor
	|-EnumUInt16TypeInfo<TimeSpan>..ctor
	|-EnumUInt16TypeInfo<ushort>..ctor
	|-EnumUInt16TypeInfo<uint>..ctor
	|-EnumUInt16TypeInfo<ulong>..ctor
	|-EnumUInt16TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt32TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1564
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2131470 Offset: 0x2130870 VA: 0x182131470
	|-EnumInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2131620 Offset: 0x2130A20 VA: 0x182131620
	|-EnumInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x21312C0 Offset: 0x21306C0 VA: 0x1821312C0
	|-EnumInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2131080 Offset: 0x2130480 VA: 0x182131080
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2130C00 Offset: 0x2130000 VA: 0x182130C00
	|-EnumInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2130ED0 Offset: 0x21302D0 VA: 0x182130ED0
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2130D20 Offset: 0x2130120 VA: 0x182130D20
	|-EnumInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2131110 Offset: 0x2130510 VA: 0x182131110
	|-EnumInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2130F60 Offset: 0x2130360 VA: 0x182130F60
	|-EnumInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2130AE0 Offset: 0x212FEE0 VA: 0x182130AE0
	|-EnumInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2130DB0 Offset: 0x21301B0 VA: 0x182130DB0
	|-EnumInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2130FF0 Offset: 0x21303F0 VA: 0x182130FF0
	|-EnumInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2130B70 Offset: 0x212FF70 VA: 0x182130B70
	|-EnumInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2130C90 Offset: 0x2130090 VA: 0x182130C90
	|-EnumInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2131500 Offset: 0x2130900 VA: 0x182131500
	|-EnumInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x21313E0 Offset: 0x21307E0 VA: 0x1821313E0
	|-EnumInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2131230 Offset: 0x2130630 VA: 0x182131230
	|-EnumInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2130A50 Offset: 0x212FE50 VA: 0x182130A50
	|-EnumInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x21311A0 Offset: 0x21305A0 VA: 0x1821311A0
	|-EnumInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2131350 Offset: 0x2130750 VA: 0x182131350
	|-EnumInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2130E40 Offset: 0x2130240 VA: 0x182130E40
	|-EnumInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2131590 Offset: 0x2130990 VA: 0x182131590
	|-EnumInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x212FC70 Offset: 0x212F070 VA: 0x18212FC70
	|-EnumInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x21309B0 Offset: 0x212FDB0 VA: 0x1821309B0
	|-EnumInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2130910 Offset: 0x212FD10 VA: 0x182130910
	|-EnumInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x212FDB0 Offset: 0x212F1B0 VA: 0x18212FDB0
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2130380 Offset: 0x212F780 VA: 0x182130380
	|-EnumInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2130190 Offset: 0x212F590 VA: 0x182130190
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x212FE60 Offset: 0x212F260 VA: 0x18212FE60
	|-EnumInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2130420 Offset: 0x212F820 VA: 0x182130420
	|-EnumInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x212FF10 Offset: 0x212F310 VA: 0x18212FF10
	|-EnumInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x2130730 Offset: 0x212FB30 VA: 0x182130730
	|-EnumInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x212FFB0 Offset: 0x212F3B0 VA: 0x18212FFB0
	|-EnumInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x2130880 Offset: 0x212FC80 VA: 0x182130880
	|-EnumInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x2130050 Offset: 0x212F450 VA: 0x182130050
	|-EnumInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x21307E0 Offset: 0x212FBE0 VA: 0x1821307E0
	|-EnumInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2130600 Offset: 0x212FA00 VA: 0x182130600
	|-EnumInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x212FD10 Offset: 0x212F110 VA: 0x18212FD10
	|-EnumInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x21302E0 Offset: 0x212F6E0 VA: 0x1821302E0
	|-EnumInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x21304C0 Offset: 0x212F8C0 VA: 0x1821304C0
	|-EnumInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2130560 Offset: 0x212F960 VA: 0x182130560
	|-EnumInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x21306A0 Offset: 0x212FAA0 VA: 0x1821306A0
	|-EnumInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2130240 Offset: 0x212F640 VA: 0x182130240
	|-EnumInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x21300F0 Offset: 0x212F4F0 VA: 0x1821300F0
	|-EnumInt32TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumInt32TypeInfo<bool>.GetData
	|-EnumInt32TypeInfo<byte>.GetData
	|-EnumInt32TypeInfo<char>.GetData
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt32TypeInfo<DateTime>.GetData
	|-EnumInt32TypeInfo<DateTimeOffset>.GetData
	|-EnumInt32TypeInfo<Decimal>.GetData
	|-EnumInt32TypeInfo<EmptyStruct>.GetData
	|-EnumInt32TypeInfo<double>.GetData
	|-EnumInt32TypeInfo<Guid>.GetData
	|-EnumInt32TypeInfo<short>.GetData
	|-EnumInt32TypeInfo<int>.GetData
	|-EnumInt32TypeInfo<long>.GetData
	|-EnumInt32TypeInfo<IntPtr>.GetData
	|-EnumInt32TypeInfo<object>.GetData
	|-EnumInt32TypeInfo<sbyte>.GetData
	|-EnumInt32TypeInfo<float>.GetData
	|-EnumInt32TypeInfo<TimeSpan>.GetData
	|-EnumInt32TypeInfo<ushort>.GetData
	|-EnumInt32TypeInfo<uint>.GetData
	|-EnumInt32TypeInfo<ulong>.GetData
	|-EnumInt32TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumInt32TypeInfo<bool>..ctor
	|-EnumInt32TypeInfo<byte>..ctor
	|-EnumInt32TypeInfo<char>..ctor
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt32TypeInfo<DateTime>..ctor
	|-EnumInt32TypeInfo<DateTimeOffset>..ctor
	|-EnumInt32TypeInfo<Decimal>..ctor
	|-EnumInt32TypeInfo<EmptyStruct>..ctor
	|-EnumInt32TypeInfo<double>..ctor
	|-EnumInt32TypeInfo<Guid>..ctor
	|-EnumInt32TypeInfo<short>..ctor
	|-EnumInt32TypeInfo<int>..ctor
	|-EnumInt32TypeInfo<long>..ctor
	|-EnumInt32TypeInfo<IntPtr>..ctor
	|-EnumInt32TypeInfo<object>..ctor
	|-EnumInt32TypeInfo<sbyte>..ctor
	|-EnumInt32TypeInfo<float>..ctor
	|-EnumInt32TypeInfo<TimeSpan>..ctor
	|-EnumInt32TypeInfo<ushort>..ctor
	|-EnumInt32TypeInfo<uint>..ctor
	|-EnumInt32TypeInfo<ulong>..ctor
	|-EnumInt32TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt32TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1565
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B46AF0 Offset: 0x1B45EF0 VA: 0x181B46AF0
	|-EnumUInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B46310 Offset: 0x1B45710 VA: 0x181B46310
	|-EnumUInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B46820 Offset: 0x1B45C20 VA: 0x181B46820
	|-EnumUInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B46790 Offset: 0x1B45B90 VA: 0x181B46790
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B46940 Offset: 0x1B45D40 VA: 0x181B46940
	|-EnumUInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B46430 Offset: 0x1B45830 VA: 0x181B46430
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B46280 Offset: 0x1B45680 VA: 0x181B46280
	|-EnumUInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B463A0 Offset: 0x1B457A0 VA: 0x181B463A0
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B46D30 Offset: 0x1B46130 VA: 0x181B46D30
	|-EnumUInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B46700 Offset: 0x1B45B00 VA: 0x181B46700
	|-EnumUInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B469D0 Offset: 0x1B45DD0 VA: 0x181B469D0
	|-EnumUInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B46C10 Offset: 0x1B46010 VA: 0x181B46C10
	|-EnumUInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B46B80 Offset: 0x1B45F80 VA: 0x181B46B80
	|-EnumUInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B46670 Offset: 0x1B45A70 VA: 0x181B46670
	|-EnumUInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B46550 Offset: 0x1B45950 VA: 0x181B46550
	|-EnumUInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B46E50 Offset: 0x1B46250 VA: 0x181B46E50
	|-EnumUInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B468B0 Offset: 0x1B45CB0 VA: 0x181B468B0
	|-EnumUInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B46CA0 Offset: 0x1B460A0 VA: 0x181B46CA0
	|-EnumUInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B465E0 Offset: 0x1B459E0 VA: 0x181B465E0
	|-EnumUInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B46DC0 Offset: 0x1B461C0 VA: 0x181B46DC0
	|-EnumUInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B464C0 Offset: 0x1B458C0 VA: 0x181B464C0
	|-EnumUInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B46A60 Offset: 0x1B45E60 VA: 0x181B46A60
	|-EnumUInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B45EB0 Offset: 0x1B452B0 VA: 0x181B45EB0
	|-EnumUInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B45B70 Offset: 0x1B44F70 VA: 0x181B45B70
	|-EnumUInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B458E0 Offset: 0x1B44CE0 VA: 0x181B458E0
	|-EnumUInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B45E00 Offset: 0x1B45200 VA: 0x181B45E00
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B454A0 Offset: 0x1B448A0 VA: 0x181B454A0
	|-EnumUInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B46090 Offset: 0x1B45490 VA: 0x181B46090
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B45D50 Offset: 0x1B45150 VA: 0x181B45D50
	|-EnumUInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B45700 Offset: 0x1B44B00 VA: 0x181B45700
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B45F50 Offset: 0x1B45350 VA: 0x181B45F50
	|-EnumUInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B45980 Offset: 0x1B44D80 VA: 0x181B45980
	|-EnumUInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B45540 Offset: 0x1B44940 VA: 0x181B45540
	|-EnumUInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B45670 Offset: 0x1B44A70 VA: 0x181B45670
	|-EnumUInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B45A30 Offset: 0x1B44E30 VA: 0x181B45A30
	|-EnumUInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B46140 Offset: 0x1B45540 VA: 0x181B46140
	|-EnumUInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B45FF0 Offset: 0x1B453F0 VA: 0x181B45FF0
	|-EnumUInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B45840 Offset: 0x1B44C40 VA: 0x181B45840
	|-EnumUInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B45AD0 Offset: 0x1B44ED0 VA: 0x181B45AD0
	|-EnumUInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B461E0 Offset: 0x1B455E0 VA: 0x181B461E0
	|-EnumUInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B457A0 Offset: 0x1B44BA0 VA: 0x181B457A0
	|-EnumUInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B455E0 Offset: 0x1B449E0 VA: 0x181B455E0
	|-EnumUInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B45C10 Offset: 0x1B45010 VA: 0x181B45C10
	|-EnumUInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B45CB0 Offset: 0x1B450B0 VA: 0x181B45CB0
	|-EnumUInt32TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumUInt32TypeInfo<bool>.GetData
	|-EnumUInt32TypeInfo<byte>.GetData
	|-EnumUInt32TypeInfo<char>.GetData
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt32TypeInfo<DateTime>.GetData
	|-EnumUInt32TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt32TypeInfo<Decimal>.GetData
	|-EnumUInt32TypeInfo<EmptyStruct>.GetData
	|-EnumUInt32TypeInfo<double>.GetData
	|-EnumUInt32TypeInfo<Guid>.GetData
	|-EnumUInt32TypeInfo<short>.GetData
	|-EnumUInt32TypeInfo<int>.GetData
	|-EnumUInt32TypeInfo<long>.GetData
	|-EnumUInt32TypeInfo<IntPtr>.GetData
	|-EnumUInt32TypeInfo<object>.GetData
	|-EnumUInt32TypeInfo<sbyte>.GetData
	|-EnumUInt32TypeInfo<float>.GetData
	|-EnumUInt32TypeInfo<TimeSpan>.GetData
	|-EnumUInt32TypeInfo<ushort>.GetData
	|-EnumUInt32TypeInfo<uint>.GetData
	|-EnumUInt32TypeInfo<ulong>.GetData
	|-EnumUInt32TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumUInt32TypeInfo<bool>..ctor
	|-EnumUInt32TypeInfo<byte>..ctor
	|-EnumUInt32TypeInfo<char>..ctor
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt32TypeInfo<DateTime>..ctor
	|-EnumUInt32TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt32TypeInfo<Decimal>..ctor
	|-EnumUInt32TypeInfo<EmptyStruct>..ctor
	|-EnumUInt32TypeInfo<double>..ctor
	|-EnumUInt32TypeInfo<Guid>..ctor
	|-EnumUInt32TypeInfo<short>..ctor
	|-EnumUInt32TypeInfo<int>..ctor
	|-EnumUInt32TypeInfo<long>..ctor
	|-EnumUInt32TypeInfo<IntPtr>..ctor
	|-EnumUInt32TypeInfo<object>..ctor
	|-EnumUInt32TypeInfo<sbyte>..ctor
	|-EnumUInt32TypeInfo<float>..ctor
	|-EnumUInt32TypeInfo<TimeSpan>..ctor
	|-EnumUInt32TypeInfo<ushort>..ctor
	|-EnumUInt32TypeInfo<uint>..ctor
	|-EnumUInt32TypeInfo<ulong>..ctor
	|-EnumUInt32TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt64TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1566
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21326D0 Offset: 0x2131AD0 VA: 0x1821326D0
	|-EnumInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2132A30 Offset: 0x2131E30 VA: 0x182132A30
	|-EnumInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2132BE0 Offset: 0x2131FE0 VA: 0x182132BE0
	|-EnumInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x21329A0 Offset: 0x2131DA0 VA: 0x1821329A0
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2132760 Offset: 0x2131B60 VA: 0x182132760
	|-EnumInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2132F40 Offset: 0x2132340 VA: 0x182132F40
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2132640 Offset: 0x2131A40 VA: 0x182132640
	|-EnumInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2132520 Offset: 0x2131920 VA: 0x182132520
	|-EnumInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2132910 Offset: 0x2131D10 VA: 0x182132910
	|-EnumInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2132AC0 Offset: 0x2131EC0 VA: 0x182132AC0
	|-EnumInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2132D00 Offset: 0x2132100 VA: 0x182132D00
	|-EnumInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2132490 Offset: 0x2131890 VA: 0x182132490
	|-EnumInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2132880 Offset: 0x2131C80 VA: 0x182132880
	|-EnumInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2132FD0 Offset: 0x21323D0 VA: 0x182132FD0
	|-EnumInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2132C70 Offset: 0x2132070 VA: 0x182132C70
	|-EnumInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2132D90 Offset: 0x2132190 VA: 0x182132D90
	|-EnumInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x21327F0 Offset: 0x2131BF0 VA: 0x1821327F0
	|-EnumInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2133060 Offset: 0x2132460 VA: 0x182133060
	|-EnumInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2132EB0 Offset: 0x21322B0 VA: 0x182132EB0
	|-EnumInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x21325B0 Offset: 0x21319B0 VA: 0x1821325B0
	|-EnumInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2132E20 Offset: 0x2132220 VA: 0x182132E20
	|-EnumInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2132B50 Offset: 0x2131F50 VA: 0x182132B50
	|-EnumInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2132200 Offset: 0x2131600 VA: 0x182132200
	|-EnumInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x21319F0 Offset: 0x2130DF0 VA: 0x1821319F0
	|-EnumInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2131EF0 Offset: 0x21312F0 VA: 0x182131EF0
	|-EnumInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x2132340 Offset: 0x2131740 VA: 0x182132340
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2131A90 Offset: 0x2130E90 VA: 0x182131A90
	|-EnumInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2131940 Offset: 0x2130D40 VA: 0x182131940
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2131D00 Offset: 0x2131100 VA: 0x182131D00
	|-EnumInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2131800 Offset: 0x2130C00 VA: 0x182131800
	|-EnumInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x21323F0 Offset: 0x21317F0 VA: 0x1821323F0
	|-EnumInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x2131750 Offset: 0x2130B50 VA: 0x182131750
	|-EnumInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x21320C0 Offset: 0x21314C0 VA: 0x1821320C0
	|-EnumInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x2131F90 Offset: 0x2131390 VA: 0x182131F90
	|-EnumInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x2131C60 Offset: 0x2131060 VA: 0x182131C60
	|-EnumInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x2132020 Offset: 0x2131420 VA: 0x182132020
	|-EnumInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x21316B0 Offset: 0x2130AB0 VA: 0x1821316B0
	|-EnumInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x2132160 Offset: 0x2131560 VA: 0x182132160
	|-EnumInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x21322A0 Offset: 0x21316A0 VA: 0x1821322A0
	|-EnumInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x21318A0 Offset: 0x2130CA0 VA: 0x1821318A0
	|-EnumInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2131E50 Offset: 0x2131250 VA: 0x182131E50
	|-EnumInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2131BD0 Offset: 0x2130FD0 VA: 0x182131BD0
	|-EnumInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2131B30 Offset: 0x2130F30 VA: 0x182131B30
	|-EnumInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2131DB0 Offset: 0x21311B0 VA: 0x182131DB0
	|-EnumInt64TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumInt64TypeInfo<bool>.GetData
	|-EnumInt64TypeInfo<byte>.GetData
	|-EnumInt64TypeInfo<char>.GetData
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt64TypeInfo<DateTime>.GetData
	|-EnumInt64TypeInfo<DateTimeOffset>.GetData
	|-EnumInt64TypeInfo<Decimal>.GetData
	|-EnumInt64TypeInfo<EmptyStruct>.GetData
	|-EnumInt64TypeInfo<double>.GetData
	|-EnumInt64TypeInfo<Guid>.GetData
	|-EnumInt64TypeInfo<short>.GetData
	|-EnumInt64TypeInfo<int>.GetData
	|-EnumInt64TypeInfo<long>.GetData
	|-EnumInt64TypeInfo<IntPtr>.GetData
	|-EnumInt64TypeInfo<object>.GetData
	|-EnumInt64TypeInfo<sbyte>.GetData
	|-EnumInt64TypeInfo<float>.GetData
	|-EnumInt64TypeInfo<TimeSpan>.GetData
	|-EnumInt64TypeInfo<ushort>.GetData
	|-EnumInt64TypeInfo<uint>.GetData
	|-EnumInt64TypeInfo<ulong>.GetData
	|-EnumInt64TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumInt64TypeInfo<bool>..ctor
	|-EnumInt64TypeInfo<byte>..ctor
	|-EnumInt64TypeInfo<char>..ctor
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt64TypeInfo<DateTime>..ctor
	|-EnumInt64TypeInfo<DateTimeOffset>..ctor
	|-EnumInt64TypeInfo<Decimal>..ctor
	|-EnumInt64TypeInfo<EmptyStruct>..ctor
	|-EnumInt64TypeInfo<double>..ctor
	|-EnumInt64TypeInfo<Guid>..ctor
	|-EnumInt64TypeInfo<short>..ctor
	|-EnumInt64TypeInfo<int>..ctor
	|-EnumInt64TypeInfo<long>..ctor
	|-EnumInt64TypeInfo<IntPtr>..ctor
	|-EnumInt64TypeInfo<object>..ctor
	|-EnumInt64TypeInfo<sbyte>..ctor
	|-EnumInt64TypeInfo<float>..ctor
	|-EnumInt64TypeInfo<TimeSpan>..ctor
	|-EnumInt64TypeInfo<ushort>..ctor
	|-EnumInt64TypeInfo<uint>..ctor
	|-EnumInt64TypeInfo<ulong>..ctor
	|-EnumInt64TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt64TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1567
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B48800 Offset: 0x1B47C00 VA: 0x181B48800
	|-EnumUInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B481D0 Offset: 0x1B475D0 VA: 0x181B481D0
	|-EnumUInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B47F00 Offset: 0x1B47300 VA: 0x181B47F00
	|-EnumUInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B48650 Offset: 0x1B47A50 VA: 0x181B48650
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B486E0 Offset: 0x1B47AE0 VA: 0x181B486E0
	|-EnumUInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B48020 Offset: 0x1B47420 VA: 0x181B48020
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B47DE0 Offset: 0x1B471E0 VA: 0x181B47DE0
	|-EnumUInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B47E70 Offset: 0x1B47270 VA: 0x181B47E70
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B485C0 Offset: 0x1B479C0 VA: 0x181B485C0
	|-EnumUInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B48140 Offset: 0x1B47540 VA: 0x181B48140
	|-EnumUInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B48530 Offset: 0x1B47930 VA: 0x181B48530
	|-EnumUInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B48380 Offset: 0x1B47780 VA: 0x181B48380
	|-EnumUInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B48890 Offset: 0x1B47C90 VA: 0x181B48890
	|-EnumUInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B484A0 Offset: 0x1B478A0 VA: 0x181B484A0
	|-EnumUInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B47CC0 Offset: 0x1B470C0 VA: 0x181B47CC0
	|-EnumUInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B47F90 Offset: 0x1B47390 VA: 0x181B47F90
	|-EnumUInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B48770 Offset: 0x1B47B70 VA: 0x181B48770
	|-EnumUInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B48410 Offset: 0x1B47810 VA: 0x181B48410
	|-EnumUInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B48260 Offset: 0x1B47660 VA: 0x181B48260
	|-EnumUInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B480B0 Offset: 0x1B474B0 VA: 0x181B480B0
	|-EnumUInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B47D50 Offset: 0x1B47150 VA: 0x181B47D50
	|-EnumUInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B482F0 Offset: 0x1B476F0 VA: 0x181B482F0
	|-EnumUInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B47160 Offset: 0x1B46560 VA: 0x181B47160
	|-EnumUInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B47350 Offset: 0x1B46750 VA: 0x181B47350
	|-EnumUInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B470C0 Offset: 0x1B464C0 VA: 0x181B470C0
	|-EnumUInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B47970 Offset: 0x1B46D70 VA: 0x181B47970
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B478D0 Offset: 0x1B46CD0 VA: 0x181B478D0
	|-EnumUInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B47200 Offset: 0x1B46600 VA: 0x181B47200
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B47B70 Offset: 0x1B46F70 VA: 0x181B47B70
	|-EnumUInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B47830 Offset: 0x1B46C30 VA: 0x181B47830
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B47660 Offset: 0x1B46A60 VA: 0x181B47660
	|-EnumUInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B47A20 Offset: 0x1B46E20 VA: 0x181B47A20
	|-EnumUInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B472B0 Offset: 0x1B466B0 VA: 0x181B472B0
	|-EnumUInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B47530 Offset: 0x1B46930 VA: 0x181B47530
	|-EnumUInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B473F0 Offset: 0x1B467F0 VA: 0x181B473F0
	|-EnumUInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B47C20 Offset: 0x1B47020 VA: 0x181B47C20
	|-EnumUInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B47AD0 Offset: 0x1B46ED0 VA: 0x181B47AD0
	|-EnumUInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B47490 Offset: 0x1B46890 VA: 0x181B47490
	|-EnumUInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B47020 Offset: 0x1B46420 VA: 0x181B47020
	|-EnumUInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B475C0 Offset: 0x1B469C0 VA: 0x181B475C0
	|-EnumUInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B47700 Offset: 0x1B46B00 VA: 0x181B47700
	|-EnumUInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B477A0 Offset: 0x1B46BA0 VA: 0x181B477A0
	|-EnumUInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B46EE0 Offset: 0x1B462E0 VA: 0x181B46EE0
	|-EnumUInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B46F80 Offset: 0x1B46380 VA: 0x181B46F80
	|-EnumUInt64TypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	|-EnumUInt64TypeInfo<bool>.GetData
	|-EnumUInt64TypeInfo<byte>.GetData
	|-EnumUInt64TypeInfo<char>.GetData
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt64TypeInfo<DateTime>.GetData
	|-EnumUInt64TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt64TypeInfo<Decimal>.GetData
	|-EnumUInt64TypeInfo<EmptyStruct>.GetData
	|-EnumUInt64TypeInfo<double>.GetData
	|-EnumUInt64TypeInfo<Guid>.GetData
	|-EnumUInt64TypeInfo<short>.GetData
	|-EnumUInt64TypeInfo<int>.GetData
	|-EnumUInt64TypeInfo<long>.GetData
	|-EnumUInt64TypeInfo<IntPtr>.GetData
	|-EnumUInt64TypeInfo<object>.GetData
	|-EnumUInt64TypeInfo<sbyte>.GetData
	|-EnumUInt64TypeInfo<float>.GetData
	|-EnumUInt64TypeInfo<TimeSpan>.GetData
	|-EnumUInt64TypeInfo<ushort>.GetData
	|-EnumUInt64TypeInfo<uint>.GetData
	|-EnumUInt64TypeInfo<ulong>.GetData
	|-EnumUInt64TypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-EnumUInt64TypeInfo<bool>..ctor
	|-EnumUInt64TypeInfo<byte>..ctor
	|-EnumUInt64TypeInfo<char>..ctor
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt64TypeInfo<DateTime>..ctor
	|-EnumUInt64TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt64TypeInfo<Decimal>..ctor
	|-EnumUInt64TypeInfo<EmptyStruct>..ctor
	|-EnumUInt64TypeInfo<double>..ctor
	|-EnumUInt64TypeInfo<Guid>..ctor
	|-EnumUInt64TypeInfo<short>..ctor
	|-EnumUInt64TypeInfo<int>..ctor
	|-EnumUInt64TypeInfo<long>..ctor
	|-EnumUInt64TypeInfo<IntPtr>..ctor
	|-EnumUInt64TypeInfo<object>..ctor
	|-EnumUInt64TypeInfo<sbyte>..ctor
	|-EnumUInt64TypeInfo<float>..ctor
	|-EnumUInt64TypeInfo<TimeSpan>..ctor
	|-EnumUInt64TypeInfo<ushort>..ctor
	|-EnumUInt64TypeInfo<uint>..ctor
	|-EnumUInt64TypeInfo<ulong>..ctor
	|-EnumUInt64TypeInfo<UIntPtr>..ctor
	*/

}

internal class EnumMap : ObjectMap // TypeDefIndex: 2130
{	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x10FB2A0 Offset: 0x10FA6A0 VA: 0x1810FB2A0
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsFlags() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string[] get_EnumNames() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string[] get_XmlNames() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public long[] get_Values() { }

	// RVA: 0x10FAF40 Offset: 0x10FA340 VA: 0x1810FAF40
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x10FAC50 Offset: 0x10FA050 VA: 0x1810FAC50
	public string GetEnumName(string typeName, string xmlName) { }

}

public class EnumMap.EnumMapMember // TypeDefIndex: 2131
{	// Fields
	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly long _value; // 0x20

	// Properties
	public string XmlName { get; }
	public string EnumName { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x10FABF0 Offset: 0x10F9FF0 VA: 0x1810FABF0
	public void .ctor(string xmlName, string enumName, long value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_XmlName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_EnumName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public long get_Value() { }

}

public class EnumConverter : TypeConverter // TypeDefIndex: 2701
{	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x159E400 Offset: 0x159D800 VA: 0x18159E400
	public void .ctor(Type type) { }

	// RVA: 0x159CB90 Offset: 0x159BF90 VA: 0x18159CB90 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x159CC80 Offset: 0x159C080 VA: 0x18159CC80 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x159E470 Offset: 0x159D870 VA: 0x18159E470 Slot: 16
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x159CD70 Offset: 0x159C170 VA: 0x18159CD70 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x159D1D0 Offset: 0x159C5D0 VA: 0x18159D1D0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x159DFE0 Offset: 0x159D3E0 VA: 0x18159DFE0 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x159DF50 Offset: 0x159D350 VA: 0x18159DF50 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x159E390 Offset: 0x159D790 VA: 0x18159E390 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

}

public static class Enumerable // TypeDefIndex: 3198
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6400 Offset: 0x4B5800 VA: 0x1804B6400
	|-Enumerable.Where<BaseNetworkable>
	|-Enumerable.Where<ConsoleSystem.Command>
	|-Enumerable.Where<ConstructionGrade>
	|-Enumerable.Where<CraftingQueueIcon>
	|-Enumerable.Where<Input.Button>
	|-Enumerable.Where<GameManifest.PrefabProperties>
	|-Enumerable.Where<GenerateDungeonGrid.PathNode>
	|-Enumerable.Where<GeneratePowerlineLayout.PathNode>
	|-Enumerable.Where<GenerateRoadLayout.PathNode>
	|-Enumerable.Where<IPlayerInfo>
	|-Enumerable.Where<IPlayerItem>
	|-Enumerable.Where<IPlayerItemDefinition>
	|-Enumerable.Where<Item>
	|-Enumerable.Where<ItemBlueprint>
	|-Enumerable.Where<ItemDefinition>
	|-Enumerable.Where<ItemModWearable>
	|-Enumerable.Where<TrackChunk>
	|-Enumerable.Where<ITempoMapValuesCache>
	|-Enumerable.Where<ValueChange<TimeSignature>>
	|-Enumerable.Where<PieMenu.MenuOption>
	|-Enumerable.Where<Prefab>
	|-Enumerable.Where<ProjectileWeaponMod>
	|-Enumerable.Where<PathData>
	|-Enumerable.Where<PrefabData>
	|-Enumerable.Where<SteamInventoryItem>
	|-Enumerable.Where<Skinnable>
	|-Enumerable.Where<InventoryRecipe[]>
	|-Enumerable.Where<FileInfo>
	|-Enumerable.Where<ConstructorInfo>
	|-Enumerable.Where<FieldInfo>
	|-Enumerable.Where<MemberInfo>
	|-Enumerable.Where<PropertyInfo>
	|-Enumerable.Where<string>
	|-Enumerable.Where<Type>
	|-Enumerable.Where<Collider>
	|-Enumerable.Where<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Where<Object>
	|-Enumerable.Where<Renderer>
	|-Enumerable.Where<Transform>
	|-Enumerable.Where<Toggle>
	|-Enumerable.Where<WeatherPreset>
	|-Enumerable.Where<object>
	|
	|-RVA: 0x4B3F70 Offset: 0x4B3370 VA: 0x1804B3F70
	|-Enumerable.Where<SkeletonDefinition.Bone>
	|
	|-RVA: 0x4B6C70 Offset: 0x4B6070 VA: 0x1804B6C70
	|-Enumerable.Where<GameStat.Stat>
	|
	|-RVA: 0x4B69A0 Offset: 0x4B5DA0 VA: 0x1804B69A0
	|-Enumerable.Where<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x4B5B90 Offset: 0x4B4F90 VA: 0x1804B5B90
	|-Enumerable.Where<ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0x4B5E60 Offset: 0x4B5260 VA: 0x1804B5E60
	|-Enumerable.Where<Option>
	|
	|-RVA: 0x4B66D0 Offset: 0x4B5AD0 VA: 0x1804B66D0
	|-Enumerable.Where<ServerInfo>
	|
	|-RVA: 0x4B6130 Offset: 0x4B5530 VA: 0x1804B6130
	|-Enumerable.Where<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x4B4D80 Offset: 0x4B4180 VA: 0x1804B4D80
	|-Enumerable.Where<InventoryItem>
	|
	|-RVA: 0x4B4510 Offset: 0x4B3910 VA: 0x1804B4510
	|-Enumerable.Where<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x4B5050 Offset: 0x4B4450 VA: 0x1804B5050
	|-Enumerable.Where<InventoryRecipe>
	|
	|-RVA: 0x4B4240 Offset: 0x4B3640 VA: 0x1804B4240
	|-Enumerable.Where<char>
	|
	|-RVA: 0x4B5320 Offset: 0x4B4720 VA: 0x1804B5320
	|-Enumerable.Where<KeyValuePair<string, AssetBundle>>
	|-Enumerable.Where<KeyValuePair<Type, PostProcessBundle>>
	|-Enumerable.Where<KeyValuePair<object, object>>
	|
	|-RVA: 0x4B55F0 Offset: 0x4B49F0 VA: 0x1804B55F0
	|-Enumerable.Where<KeyValuePair<uint, FileStorage.CacheData>>
	|-Enumerable.Where<KeyValuePair<uint, object>>
	|
	|-RVA: 0x4B58C0 Offset: 0x4B4CC0 VA: 0x1804B58C0
	|-Enumerable.Where<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|
	|-RVA: 0x4B4AB0 Offset: 0x4B3EB0 VA: 0x1804B4AB0
	|-Enumerable.Where<int>
	|
	|-RVA: 0x4B47E0 Offset: 0x4B3BE0 VA: 0x1804B47E0
	|-Enumerable.Where<KeyCode>
	|-Enumerable.Where<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC69D30 Offset: 0xC69130 VA: 0x180C69D30
	|-Enumerable.Select<BaseNetworkable, Debugging.EntityInfo>
	|-Enumerable.Select<object, Debugging.EntityInfo>
	|
	|-RVA: 0x4B2F60 Offset: 0x4B2360 VA: 0x1804B2F60
	|-Enumerable.Select<BaseViewModel, string>
	|-Enumerable.Select<Input.Button, string>
	|-Enumerable.Select<Manifest.ServerDesc, string>
	|-Enumerable.Select<GameManifest.PrefabProperties, string>
	|-Enumerable.Select<IPlayerInfo, string>
	|-Enumerable.Select<ItemDefinition, ItemModWearable>
	|-Enumerable.Select<TrackChunk, EventsCollection>
	|-Enumerable.Select<JsonProperty, string>
	|-Enumerable.Select<PathData, PathList>
	|-Enumerable.Select<SteamItemDefinition, InventoryDef>
	|-Enumerable.Select<SteamInventoryItem, Task<IPlayerInventory>>
	|-Enumerable.Select<Skinnable, string>
	|-Enumerable.Select<InventoryDef, IPlayerItemDefinition>
	|-Enumerable.Select<InventoryDef, SteamItemDefinition>
	|-Enumerable.Select<InventoryDef, InventoryRecipe[]>
	|-Enumerable.Select<InventoryDef, string>
	|-Enumerable.Select<StackFrame, Report.StackTrace.StackFrame>
	|-Enumerable.Select<IGrouping<uint, BaseNetworkable>, BaseNetworkable>
	|-Enumerable.Select<IGrouping<AssetBundle, string>, LoadAssetsResult>
	|-Enumerable.Select<object, Type>
	|-Enumerable.Select<FieldInfo, ParameterOverride>
	|-Enumerable.Select<ParameterInfo, Type>
	|-Enumerable.Select<EnumMemberAttribute, string>
	|-Enumerable.Select<string, Report.StackTrace.StackFrame>
	|-Enumerable.Select<string, string>
	|-Enumerable.Select<string, Match>
	|-Enumerable.Select<Match, string>
	|-Enumerable.Select<GameObject, ItemBlueprint>
	|-Enumerable.Select<GameObject, ItemDefinition>
	|-Enumerable.Select<Toggle, SteamInventoryItem>
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0xC653C0 Offset: 0xC647C0 VA: 0x180C653C0
	|-Enumerable.Select<SkeletonDefinition.Bone, GameObject>
	|-Enumerable.Select<SkeletonDefinition.Bone, Transform>
	|-Enumerable.Select<SkeletonDefinition.Bone, object>
	|
	|-RVA: 0xC6AED0 Offset: 0xC6A2D0 VA: 0x180C6AED0
	|-Enumerable.Select<GenerateDungeonGrid.PathNode, PathFinder.Point>
	|-Enumerable.Select<GeneratePowerlineLayout.PathNode, PathFinder.Point>
	|-Enumerable.Select<GenerateRoadLayout.PathNode, PathFinder.Point>
	|-Enumerable.Select<object, PathFinder.Point>
	|
	|-RVA: 0x4B23A0 Offset: 0x4B17A0 VA: 0x1804B23A0
	|-Enumerable.Select<ItemBlueprint, int>
	|-Enumerable.Select<EventsCollection, int>
	|-Enumerable.Select<object, int>
	|
	|-RVA: 0xC69A40 Offset: 0xC68E40 VA: 0x180C69A40
	|-Enumerable.Select<PlayerItemRecipe, IPlayerItemDefinition>
	|-Enumerable.Select<PlayerItemRecipe, object>
	|
	|-RVA: 0xC6A8F0 Offset: 0xC69CF0 VA: 0x180C6A8F0
	|-Enumerable.Select<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>
	|-Enumerable.Select<object, ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0xC69170 Offset: 0xC68570 VA: 0x180C69170
	|-Enumerable.Select<ProjectileWeaponMod.Modifier, float>
	|
	|-RVA: 0xC6A310 Offset: 0xC69710 VA: 0x180C6A310
	|-Enumerable.Select<SteamItem, InventoryItem>
	|-Enumerable.Select<object, InventoryItem>
	|
	|-RVA: 0xC69460 Offset: 0xC68860 VA: 0x180C69460
	|-Enumerable.Select<Option, Option>
	|
	|-RVA: 0xC6ABE0 Offset: 0xC69FE0 VA: 0x180C6ABE0
	|-Enumerable.Select<OptionAttribute, Option>
	|-Enumerable.Select<object, Option>
	|
	|-RVA: 0x4B1DC0 Offset: 0x4B11C0 VA: 0x1804B1DC0
	|-Enumerable.Select<ServerBrowserTag, bool>
	|-Enumerable.Select<object, bool>
	|
	|-RVA: 0xC6B4B0 Offset: 0xC6A8B0 VA: 0x180C6B4B0
	|-Enumerable.Select<ServerInfo, string>
	|-Enumerable.Select<ServerInfo, object>
	|
	|-RVA: 0xC64AF0 Offset: 0xC63EF0 VA: 0x180C64AF0
	|-Enumerable.Select<Achievement, <>f__AnonymousType0<string, string, bool>>
	|-Enumerable.Select<Achievement, object>
	|
	|-RVA: 0xC67700 Offset: 0xC66B00 VA: 0x180C67700
	|-Enumerable.Select<InventoryDefId, InventoryDef>
	|-Enumerable.Select<InventoryDefId, object>
	|
	|-RVA: 0xC6B7A0 Offset: 0xC6ABA0 VA: 0x180C6B7A0
	|-Enumerable.Select<ServerInfo, ServerInfo>
	|
	|-RVA: 0xC65F80 Offset: 0xC65380 VA: 0x180C65F80
	|-Enumerable.Select<Friend, SteamPlayer>
	|-Enumerable.Select<Friend, object>
	|
	|-RVA: 0xC67FD0 Offset: 0xC673D0 VA: 0x180C67FD0
	|-Enumerable.Select<InventoryItem, SteamItem>
	|-Enumerable.Select<InventoryItem, object>
	|
	|-RVA: 0xC67CE0 Offset: 0xC670E0 VA: 0x180C67CE0
	|-Enumerable.Select<InventoryItem, InventoryItemId>
	|
	|-RVA: 0xC682C0 Offset: 0xC676C0 VA: 0x180C682C0
	|-Enumerable.Select<InventoryItem, uint>
	|
	|-RVA: 0xC64DE0 Offset: 0xC641E0 VA: 0x180C64DE0
	|-Enumerable.Select<InventoryItem.Amount, InventoryItemId>
	|
	|-RVA: 0xC650D0 Offset: 0xC644D0 VA: 0x180C650D0
	|-Enumerable.Select<InventoryItem.Amount, uint>
	|
	|-RVA: 0xC685B0 Offset: 0xC679B0 VA: 0x180C685B0
	|-Enumerable.Select<InventoryRecipe, PlayerItemRecipe>
	|
	|-RVA: 0xC66560 Offset: 0xC65960 VA: 0x180C66560
	|-Enumerable.Select<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xC66850 Offset: 0xC65C50 VA: 0x180C66850
	|-Enumerable.Select<InventoryRecipe.Ingredient, string>
	|-Enumerable.Select<InventoryRecipe.Ingredient, object>
	|
	|-RVA: 0xC688A0 Offset: 0xC67CA0 VA: 0x180C688A0
	|-Enumerable.Select<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0xC68E80 Offset: 0xC68280 VA: 0x180C68E80
	|-Enumerable.Select<KeyValuePair<uint, FileStorage.CacheData>, uint>
	|-Enumerable.Select<KeyValuePair<uint, object>, uint>
	|
	|-RVA: 0xC68B90 Offset: 0xC67F90 VA: 0x180C68B90
	|-Enumerable.Select<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>
	|-Enumerable.Select<KeyValuePair<uint, object>, object>
	|
	|-RVA: 0xC66E30 Offset: 0xC66230 VA: 0x180C66E30
	|-Enumerable.Select<int, FourBitNumber>
	|
	|-RVA: 0xC67410 Offset: 0xC66810 VA: 0x180C67410
	|-Enumerable.Select<int, SevenBitNumber>
	|
	|-RVA: 0xC67120 Offset: 0xC66520 VA: 0x180C67120
	|-Enumerable.Select<int, int>
	|
	|-RVA: 0x4B2980 Offset: 0x4B1D80 VA: 0x1804B2980
	|-Enumerable.Select<IGrouping<string, Transform>, KeyValuePair<Transform, int>>
	|-Enumerable.Select<object, KeyValuePair<object, int>>
	|
	|-RVA: 0x4B2C70 Offset: 0x4B2070 VA: 0x1804B2C70
	|-Enumerable.Select<IGrouping<Vector2Int, Resolution>, Resolution>
	|-Enumerable.Select<object, Resolution>
	|
	|-RVA: 0xC6A020 Offset: 0xC69420 VA: 0x180C6A020
	|-Enumerable.Select<string, InventoryRecipe.Ingredient>
	|-Enumerable.Select<object, InventoryRecipe.Ingredient>
	|
	|-RVA: 0xC6A600 Offset: 0xC69A00 VA: 0x180C6A600
	|-Enumerable.Select<string, InventoryRecipe>
	|-Enumerable.Select<object, InventoryRecipe>
	|
	|-RVA: 0x4B20B0 Offset: 0x4B14B0 VA: 0x1804B20B0
	|-Enumerable.Select<string, KeyCode>
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0xC66B40 Offset: 0xC65F40 VA: 0x180C66B40
	|-Enumerable.Select<KeyCode, string>
	|-Enumerable.Select<Int32Enum, object>
	|
	|-RVA: 0xC656B0 Offset: 0xC64AB0 VA: 0x180C656B0
	|-Enumerable.Select<BurstCloth.Chain, int>
	|
	|-RVA: 0xC659A0 Offset: 0xC64DA0 VA: 0x180C659A0
	|-Enumerable.Select<WeightedStringList.Container, float>
	|
	|-RVA: 0xC66270 Offset: 0xC65670 VA: 0x180C66270
	|-Enumerable.Select<PlayerItemRecipe.Ingredient, int>
	|
	|-RVA: 0xC6B1C0 Offset: 0xC6A5C0 VA: 0x180C6B1C0
	|-Enumerable.Select<ServerInfo, int>
	|
	|-RVA: 0xC69750 Offset: 0xC68B50 VA: 0x180C69750
	|-Enumerable.Select<SkinnedMultiMesh.Part, long>
	|
	|-RVA: 0xC679F0 Offset: 0xC66DF0 VA: 0x180C679F0
	|-Enumerable.Select<InventoryItem, int>
	|
	|-RVA: 0xC65C90 Offset: 0xC65090 VA: 0x180C65C90
	|-Enumerable.Select<DictionaryEntry, KeyValuePair<object, object>>
	|
	|-RVA: 0x4B2690 Offset: 0x4B1A90 VA: 0x1804B2690
	|-Enumerable.Select<object, long>
	|
	|-RVA: 0x4B3250 Offset: 0x4B2650 VA: 0x1804B3250
	|-Enumerable.Select<object, float>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14BD0 Offset: 0x1B13FD0 VA: 0x181B14BD0
	|-Enumerable.CombinePredicates<Debugging.EntityInfo>
	|-Enumerable.CombinePredicates<SkeletonDefinition.Bone>
	|-Enumerable.CombinePredicates<GameStat.Stat>
	|-Enumerable.CombinePredicates<ItemSkinDirectory.Skin>
	|-Enumerable.CombinePredicates<FourBitNumber>
	|-Enumerable.CombinePredicates<SevenBitNumber>
	|-Enumerable.CombinePredicates<PathFinder.Point>
	|-Enumerable.CombinePredicates<PlayerItemRecipe.Ingredient>
	|-Enumerable.CombinePredicates<PlayerItemRecipe>
	|-Enumerable.CombinePredicates<ProjectileWeaponMod.Modifier>
	|-Enumerable.CombinePredicates<Option>
	|-Enumerable.CombinePredicates<ServerInfo>
	|-Enumerable.CombinePredicates<SkinnedMultiMesh.Part>
	|-Enumerable.CombinePredicates<InventoryItemId>
	|-Enumerable.CombinePredicates<InventoryItem>
	|-Enumerable.CombinePredicates<InventoryRecipe.Ingredient>
	|-Enumerable.CombinePredicates<InventoryRecipe>
	|-Enumerable.CombinePredicates<bool>
	|-Enumerable.CombinePredicates<char>
	|-Enumerable.CombinePredicates<KeyValuePair<object, int>>
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<uint, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|-Enumerable.CombinePredicates<int>
	|-Enumerable.CombinePredicates<Int32Enum>
	|-Enumerable.CombinePredicates<long>
	|-Enumerable.CombinePredicates<object>
	|-Enumerable.CombinePredicates<float>
	|-Enumerable.CombinePredicates<uint>
	|-Enumerable.CombinePredicates<Resolution>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1173980 Offset: 0x1172D80 VA: 0x181173980
	|-Enumerable.CombineSelectors<BurstCloth.Chain, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, FourBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Option, Option>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, bool, bool>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, int, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, long, long>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Option>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryItem>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, bool>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Int32Enum>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, long>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, object>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, float>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Resolution>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, float, float>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Resolution, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Option, Option>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, bool, bool>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, int, int>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, long, long>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Option>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryItem>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, bool>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, int>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Int32Enum>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, long>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, object>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, float>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, float, float>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Resolution, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, FourBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, int>
	|-Enumerable.CombineSelectors<Option, Option, Option>
	|-Enumerable.CombineSelectors<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<ServerInfo, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<ServerInfo, Option, Option>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<ServerInfo, bool, bool>
	|-Enumerable.CombineSelectors<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<ServerInfo, int, FourBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, int, int>
	|-Enumerable.CombineSelectors<ServerInfo, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<ServerInfo, long, long>
	|-Enumerable.CombineSelectors<ServerInfo, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<ServerInfo, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<ServerInfo, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<ServerInfo, object, Option>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryItem>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<ServerInfo, object, bool>
	|-Enumerable.CombineSelectors<ServerInfo, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<ServerInfo, object, int>
	|-Enumerable.CombineSelectors<ServerInfo, object, Int32Enum>
	|-Enumerable.CombineSelectors<ServerInfo, object, long>
	|-Enumerable.CombineSelectors<ServerInfo, object, object>
	|-Enumerable.CombineSelectors<ServerInfo, object, float>
	|-Enumerable.CombineSelectors<ServerInfo, object, Resolution>
	|-Enumerable.CombineSelectors<ServerInfo, float, float>
	|-Enumerable.CombineSelectors<ServerInfo, Resolution, Resolution>
	|-Enumerable.CombineSelectors<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Achievement, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Achievement, Option, Option>
	|-Enumerable.CombineSelectors<Achievement, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Achievement, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Achievement, bool, bool>
	|-Enumerable.CombineSelectors<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Achievement, int, int>
	|-Enumerable.CombineSelectors<Achievement, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Achievement, long, long>
	|-Enumerable.CombineSelectors<Achievement, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Achievement, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Achievement, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Achievement, object, Option>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryItem>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Achievement, object, bool>
	|-Enumerable.CombineSelectors<Achievement, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Achievement, object, int>
	|-Enumerable.CombineSelectors<Achievement, object, Int32Enum>
	|-Enumerable.CombineSelectors<Achievement, object, long>
	|-Enumerable.CombineSelectors<Achievement, object, object>
	|-Enumerable.CombineSelectors<Achievement, object, float>
	|-Enumerable.CombineSelectors<Achievement, object, Resolution>
	|-Enumerable.CombineSelectors<Achievement, float, float>
	|-Enumerable.CombineSelectors<Achievement, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryDefId, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryDefId, Option, Option>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryDefId, bool, bool>
	|-Enumerable.CombineSelectors<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryDefId, int, int>
	|-Enumerable.CombineSelectors<InventoryDefId, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryDefId, long, long>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryDefId, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryDefId, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Option>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryDefId, object, bool>
	|-Enumerable.CombineSelectors<InventoryDefId, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryDefId, object, int>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryDefId, object, long>
	|-Enumerable.CombineSelectors<InventoryDefId, object, object>
	|-Enumerable.CombineSelectors<InventoryDefId, object, float>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryDefId, float, float>
	|-Enumerable.CombineSelectors<InventoryDefId, Resolution, Resolution>
	|-Enumerable.CombineSelectors<ServerInfo, ServerInfo, int>
	|-Enumerable.CombineSelectors<ServerInfo, ServerInfo, object>
	|-Enumerable.CombineSelectors<ServerInfo, int, int>
	|-Enumerable.CombineSelectors<ServerInfo, object, object>
	|-Enumerable.CombineSelectors<Friend, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Friend, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Friend, Option, Option>
	|-Enumerable.CombineSelectors<Friend, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Friend, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Friend, bool, bool>
	|-Enumerable.CombineSelectors<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Friend, int, int>
	|-Enumerable.CombineSelectors<Friend, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Friend, long, long>
	|-Enumerable.CombineSelectors<Friend, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Friend, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Friend, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Friend, object, Option>
	|-Enumerable.CombineSelectors<Friend, object, InventoryItem>
	|-Enumerable.CombineSelectors<Friend, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Friend, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Friend, object, bool>
	|-Enumerable.CombineSelectors<Friend, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Friend, object, int>
	|-Enumerable.CombineSelectors<Friend, object, Int32Enum>
	|-Enumerable.CombineSelectors<Friend, object, long>
	|-Enumerable.CombineSelectors<Friend, object, object>
	|-Enumerable.CombineSelectors<Friend, object, float>
	|-Enumerable.CombineSelectors<Friend, object, Resolution>
	|-Enumerable.CombineSelectors<Friend, float, float>
	|-Enumerable.CombineSelectors<Friend, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryItem, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryItem, Option, Option>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryItem, bool, bool>
	|-Enumerable.CombineSelectors<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryItem, int, FourBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, int, int>
	|-Enumerable.CombineSelectors<InventoryItem, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryItem, long, long>
	|-Enumerable.CombineSelectors<InventoryItem, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryItem, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryItem, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryItem, object, Option>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryItem, object, bool>
	|-Enumerable.CombineSelectors<InventoryItem, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryItem, object, int>
	|-Enumerable.CombineSelectors<InventoryItem, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryItem, object, long>
	|-Enumerable.CombineSelectors<InventoryItem, object, object>
	|-Enumerable.CombineSelectors<InventoryItem, object, float>
	|-Enumerable.CombineSelectors<InventoryItem, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryItem, float, float>
	|-Enumerable.CombineSelectors<InventoryItem, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryRecipe, PlayerItemRecipe, object>
	|-Enumerable.CombineSelectors<InventoryRecipe, object, object>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Option, Option>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, bool, bool>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, int, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, long, long>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Option>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, bool>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, long>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, object>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, float>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, float, float>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Resolution, Resolution>
	|-Enumerable.CombineSelectors<DictionaryEntry, KeyValuePair<object, object>, object>
	|-Enumerable.CombineSelectors<DictionaryEntry, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Option, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, bool, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, int, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, long, long>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, long>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, float, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Resolution, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Option, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, bool, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, int, int>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, long, long>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, long>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, float, float>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Resolution, Resolution>
	|-Enumerable.CombineSelectors<int, int, FourBitNumber>
	|-Enumerable.CombineSelectors<int, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<int, int, int>
	|-Enumerable.CombineSelectors<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Int32Enum, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Int32Enum, Option, Option>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Int32Enum, bool, bool>
	|-Enumerable.CombineSelectors<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Int32Enum, int, int>
	|-Enumerable.CombineSelectors<Int32Enum, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, long, long>
	|-Enumerable.CombineSelectors<Int32Enum, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Int32Enum, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Int32Enum, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Int32Enum, object, Option>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryItem>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Int32Enum, object, bool>
	|-Enumerable.CombineSelectors<Int32Enum, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Int32Enum, object, int>
	|-Enumerable.CombineSelectors<Int32Enum, object, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, object, long>
	|-Enumerable.CombineSelectors<Int32Enum, object, object>
	|-Enumerable.CombineSelectors<Int32Enum, object, float>
	|-Enumerable.CombineSelectors<Int32Enum, object, Resolution>
	|-Enumerable.CombineSelectors<Int32Enum, float, float>
	|-Enumerable.CombineSelectors<Int32Enum, Resolution, Resolution>
	|-Enumerable.CombineSelectors<object, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<object, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<object, PlayerItemRecipe, PlayerItemRecipe>
	|-Enumerable.CombineSelectors<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, ProjectileWeaponMod.Modifier, float>
	|-Enumerable.CombineSelectors<object, Option, Option>
	|-Enumerable.CombineSelectors<object, InventoryItemId, InventoryItemId>
	|-Enumerable.CombineSelectors<object, InventoryItem, InventoryItemId>
	|-Enumerable.CombineSelectors<object, InventoryItem, int>
	|-Enumerable.CombineSelectors<object, InventoryItem, object>
	|-Enumerable.CombineSelectors<object, InventoryItem, uint>
	|-Enumerable.CombineSelectors<object, InventoryRecipe, PlayerItemRecipe>
	|-Enumerable.CombineSelectors<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, InventoryRecipe.Ingredient, object>
	|-Enumerable.CombineSelectors<object, int, FourBitNumber>
	|-Enumerable.CombineSelectors<object, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<object, int, int>
	|-Enumerable.CombineSelectors<object, Int32Enum, object>
	|-Enumerable.CombineSelectors<object, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<object, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<object, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<object, object, Option>
	|-Enumerable.CombineSelectors<object, object, InventoryItem>
	|-Enumerable.CombineSelectors<object, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<object, object, bool>
	|-Enumerable.CombineSelectors<object, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<object, object, int>
	|-Enumerable.CombineSelectors<object, object, Int32Enum>
	|-Enumerable.CombineSelectors<object, object, long>
	|-Enumerable.CombineSelectors<object, object, object>
	|-Enumerable.CombineSelectors<object, object, float>
	|-Enumerable.CombineSelectors<object, object, Resolution>
	|-Enumerable.CombineSelectors<object, uint, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1C80 Offset: 0x4B1080 VA: 0x1804B1C80
	|-Enumerable.SelectMany<SteamInventoryItem, PlayerItemRecipe>
	|-Enumerable.SelectMany<object, PlayerItemRecipe>
	|
	|-RVA: 0x4B1BE0 Offset: 0x4B0FE0 VA: 0x1804B1BE0
	|-Enumerable.SelectMany<InventoryRecipe[], InventoryRecipe>
	|-Enumerable.SelectMany<object, InventoryRecipe>
	|
	|-RVA: 0x4B1B40 Offset: 0x4B0F40 VA: 0x1804B1B40
	|-Enumerable.SelectMany<byte[], byte>
	|-Enumerable.SelectMany<object, byte>
	|
	|-RVA: 0x4B1D20 Offset: 0x4B1120 VA: 0x1804B1D20
	|-Enumerable.SelectMany<Assembly, Type>
	|-Enumerable.SelectMany<Type, MemberInfo>
	|-Enumerable.SelectMany<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC2060 Offset: 0xC1460 VA: 0x1800C2060
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1AA0 Offset: 0x4B0EA0 VA: 0x1804B1AA0
	|-Enumerable.SelectManyIterator<object, PlayerItemRecipe>
	|
	|-RVA: 0x4B1A00 Offset: 0x4B0E00 VA: 0x1804B1A00
	|-Enumerable.SelectManyIterator<object, InventoryRecipe>
	|
	|-RVA: 0x4B0E90 Offset: 0x4B0290 VA: 0x1804B0E90
	|-Enumerable.SelectManyIterator<object, byte>
	|
	|-RVA: 0x4B0F30 Offset: 0x4B0330 VA: 0x1804B0F30
	|-Enumerable.SelectManyIterator<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3C30 Offset: 0x4B3030 VA: 0x1804B3C30
	|-Enumerable.Take<ConsoleSystem.Command>
	|-Enumerable.Take<ItemBlueprint>
	|-Enumerable.Take<ItemDefinition>
	|-Enumerable.Take<ItemModWearable>
	|-Enumerable.Take<string>
	|-Enumerable.Take<object>
	|
	|-RVA: 0x4B3BB0 Offset: 0x4B2FB0 VA: 0x1804B3BB0
	|-Enumerable.Take<Option>
	|
	|-RVA: 0x4B3B30 Offset: 0x4B2F30 VA: 0x1804B3B30
	|-Enumerable.Take<InventoryItem>
	|
	|-RVA: 0x4B3A30 Offset: 0x4B2E30 VA: 0x1804B3A30
	|-Enumerable.Take<byte>
	|
	|-RVA: 0x4B3AB0 Offset: 0x4B2EB0 VA: 0x1804B3AB0
	|-Enumerable.Take<double>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC35A0 Offset: 0xC29A0 VA: 0x1800C35A0
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3900 Offset: 0x4B2D00 VA: 0x1804B3900
	|-Enumerable.TakeIterator<Option>
	|-Enumerable.TakeIterator<InventoryItem>
	|
	|-RVA: 0x4B37E0 Offset: 0x4B2BE0 VA: 0x1804B37E0
	|-Enumerable.TakeIterator<byte>
	|
	|-RVA: 0x4B3870 Offset: 0x4B2C70 VA: 0x1804B3870
	|-Enumerable.TakeIterator<double>
	|-Enumerable.TakeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3990 Offset: 0x4B2D90 VA: 0x1804B3990
	|-Enumerable.TakeWhile<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.TakeWhile<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC3810 Offset: 0xC2C10 VA: 0x1800C3810
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0F30 Offset: 0x4B0330 VA: 0x1804B0F30
	|-Enumerable.TakeWhileIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B36E0 Offset: 0x4B2AE0 VA: 0x1804B36E0
	|-Enumerable.Skip<double>
	|
	|-RVA: 0x4B3760 Offset: 0x4B2B60 VA: 0x1804B3760
	|-Enumerable.Skip<string>
	|-Enumerable.Skip<object>
	|
	|-RVA: 0x4B3660 Offset: 0x4B2A60 VA: 0x1804B3660
	|-Enumerable.Skip<byte>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC4D20 Offset: 0xC4120 VA: 0x1800C4D20
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3540 Offset: 0x4B2940 VA: 0x1804B3540
	|-Enumerable.SkipIterator<byte>
	|
	|-RVA: 0x4B35D0 Offset: 0x4B29D0 VA: 0x1804B35D0
	|-Enumerable.SkipIterator<double>
	|-Enumerable.SkipIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F4D0 Offset: 0xE7E8D0 VA: 0x180E7F4D0
	|-Enumerable.OrderBy<BaseViewModel, string>
	|-Enumerable.OrderBy<ConstructionGrade, BuildingGrade.Enum>
	|-Enumerable.OrderBy<Demos.DemoInfo, DateTime>
	|-Enumerable.OrderBy<Demos.DemoInfo, string>
	|-Enumerable.OrderBy<Demos.DemoInfo, TimeSpan>
	|-Enumerable.OrderBy<AccountNotice, bool>
	|-Enumerable.OrderBy<Hero, Guid>
	|-Enumerable.OrderBy<HitboxDefinition, int>
	|-Enumerable.OrderBy<ItemDefinition, float>
	|-Enumerable.OrderBy<ItemDefinition, string>
	|-Enumerable.OrderBy<ItemIcon, int>
	|-Enumerable.OrderBy<ItemModWearable, Guid>
	|-Enumerable.OrderBy<MusicTheme, float>
	|-Enumerable.OrderBy<JsonProperty, int>
	|-Enumerable.OrderBy<PieMenu.MenuOption, int>
	|-Enumerable.OrderBy<ServerInfo, int>
	|-Enumerable.OrderBy<ServerInfo, string>
	|-Enumerable.OrderBy<ServerInfo, uint>
	|-Enumerable.OrderBy<double, double>
	|-Enumerable.OrderBy<IGrouping<ItemCategory, ItemDefinition>, ItemCategory>
	|-Enumerable.OrderBy<object, string>
	|-Enumerable.OrderBy<FieldInfo, int>
	|-Enumerable.OrderBy<string, Guid>
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<KerningPair, uint>
	|-Enumerable.OrderBy<TMP_Character, uint>
	|-Enumerable.OrderBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<Glyph, uint>
	|-Enumerable.OrderBy<Transform, object>
	|-Enumerable.OrderBy<Demos.DemoInfo, object>
	|-Enumerable.OrderBy<ServerInfo, object>
	|-Enumerable.OrderBy<object, bool>
	|-Enumerable.OrderBy<object, Guid>
	|-Enumerable.OrderBy<object, int>
	|-Enumerable.OrderBy<object, Int32Enum>
	|-Enumerable.OrderBy<object, object>
	|-Enumerable.OrderBy<object, float>
	|-Enumerable.OrderBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F550 Offset: 0xE7E950 VA: 0x180E7F550
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F450 Offset: 0xE7E850 VA: 0x180E7F450
	|-Enumerable.OrderByDescending<Demos.DemoInfo, DateTime>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, string>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, TimeSpan>
	|-Enumerable.OrderByDescending<GenerateDungeonBase.DungeonSegment, float>
	|-Enumerable.OrderByDescending<IPlayerInfo, int>
	|-Enumerable.OrderByDescending<IPlayerItem, DateTimeOffset>
	|-Enumerable.OrderByDescending<ItemBlueprint, bool>
	|-Enumerable.OrderByDescending<Prefab<DungeonGridLink>, int>
	|-Enumerable.OrderByDescending<ServerInfo, int>
	|-Enumerable.OrderByDescending<ServerInfo, string>
	|-Enumerable.OrderByDescending<ServerInfo, uint>
	|-Enumerable.OrderByDescending<Item, DateTime>
	|-Enumerable.OrderByDescending<KeyValuePair<IPAddress, int>, int>
	|-Enumerable.OrderByDescending<KeyValuePair<string, Stats.Node>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Type, Pool.ICollection>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Type, long>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Transform, int>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Animator>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Collider>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, LODGroup>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Rigidbody>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Transform>, int>
	|-Enumerable.OrderByDescending<IGrouping<Type, Object>, int>
	|-Enumerable.OrderByDescending<IGrouping<uint, BaseNetworkable>, int>
	|-Enumerable.OrderByDescending<Resolution, int>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, object>
	|-Enumerable.OrderByDescending<ServerInfo, object>
	|-Enumerable.OrderByDescending<KeyValuePair<object, int>, int>
	|-Enumerable.OrderByDescending<KeyValuePair<object, long>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<object, object>, long>
	|-Enumerable.OrderByDescending<object, bool>
	|-Enumerable.OrderByDescending<object, DateTimeOffset>
	|-Enumerable.OrderByDescending<object, int>
	|-Enumerable.OrderByDescending<object, object>
	|-Enumerable.OrderByDescending<object, float>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FB00 Offset: 0xE7EF00 VA: 0x180E7FB00
	|-Enumerable.ThenBy<IPlayerInfo, string>
	|-Enumerable.ThenBy<object, object>
	|
	|-RVA: 0xE7F9F0 Offset: 0xE7EDF0 VA: 0x180E7F9F0
	|-Enumerable.ThenBy<ItemBlueprint, Rarity>
	|-Enumerable.ThenBy<object, Int32Enum>
	|
	|-RVA: 0xE7FB80 Offset: 0xE7EF80 VA: 0x180E7FB80
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F750 Offset: 0xE7EB50 VA: 0x180E7F750
	|-Enumerable.ThenByDescending<AccountNotice, DateTime>
	|-Enumerable.ThenByDescending<object, DateTime>
	|
	|-RVA: 0xE7F860 Offset: 0xE7EC60 VA: 0x180E7F860
	|-Enumerable.ThenByDescending<ItemBlueprint, int>
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0xE7F640 Offset: 0xE7EA40 VA: 0x180E7F640
	|-Enumerable.ThenByDescending<Resolution, int>
	|
	|-RVA: 0xE7F970 Offset: 0xE7ED70 VA: 0x180E7F970
	|-Enumerable.ThenByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA8F0 Offset: 0xCF9CF0 VA: 0x180CFA8F0
	|-Enumerable.GroupBy<BaseNetworkable, uint>
	|-Enumerable.GroupBy<IPlayerInfo, string>
	|-Enumerable.GroupBy<ItemDefinition, ItemCategory>
	|-Enumerable.GroupBy<PrefabData, string>
	|-Enumerable.GroupBy<InventoryDef, InventoryDefId>
	|-Enumerable.GroupBy<InventoryItem, InventoryDefId>
	|-Enumerable.GroupBy<MemberInfo, string>
	|-Enumerable.GroupBy<string, AssetBundle>
	|-Enumerable.GroupBy<Animator, string>
	|-Enumerable.GroupBy<Collider, string>
	|-Enumerable.GroupBy<LODGroup, string>
	|-Enumerable.GroupBy<Object, Type>
	|-Enumerable.GroupBy<Resolution, Vector2Int>
	|-Enumerable.GroupBy<Rigidbody, string>
	|-Enumerable.GroupBy<Transform, string>
	|-Enumerable.GroupBy<object, InventoryDefId>
	|-Enumerable.GroupBy<object, Int32Enum>
	|-Enumerable.GroupBy<object, object>
	|-Enumerable.GroupBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0FD0 Offset: 0x4B03D0 VA: 0x1804B0FD0
	|-Enumerable.Concat<byte>
	|
	|-RVA: 0x4B1070 Offset: 0x4B0470 VA: 0x1804B1070
	|-Enumerable.Concat<long>
	|
	|-RVA: 0x4B1110 Offset: 0x4B0510 VA: 0x1804B1110
	|-Enumerable.Concat<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5420 Offset: 0xC4820 VA: 0x1800C5420
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E90 Offset: 0x4B0290 VA: 0x1804B0E90
	|-Enumerable.ConcatIterator<byte>
	|
	|-RVA: 0x4B0F30 Offset: 0x4B0330 VA: 0x1804B0F30
	|-Enumerable.ConcatIterator<long>
	|-Enumerable.ConcatIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B7000 Offset: 0x4B6400 VA: 0x1804B7000
	|-Enumerable.Zip<object, long, object>
	|
	|-RVA: 0x4B70D0 Offset: 0x4B64D0 VA: 0x1804B70D0
	|-Enumerable.Zip<object, object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5620 Offset: 0xC4A20 VA: 0x1800C5620
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6F40 Offset: 0x4B6340 VA: 0x1804B6F40
	|-Enumerable.ZipIterator<object, long, object>
	|-Enumerable.ZipIterator<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1370 Offset: 0x4B0770 VA: 0x1804B1370
	|-Enumerable.Distinct<IPlayerItemDefinition>
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0x4B13E0 Offset: 0x4B07E0 VA: 0x1804B13E0
	|-Enumerable.Distinct<ServerInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B12F0 Offset: 0x4B06F0 VA: 0x1804B12F0
	|-Enumerable.Distinct<string>
	|-Enumerable.Distinct<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5980 Offset: 0xC4D80 VA: 0x1800C5980
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1250 Offset: 0x4B0650 VA: 0x1804B1250
	|-Enumerable.DistinctIterator<ServerInfo>
	|
	|-RVA: 0x4B11B0 Offset: 0x4B05B0 VA: 0x1804B11B0
	|-Enumerable.DistinctIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3ED0 Offset: 0x4B32D0 VA: 0x1804B3ED0
	|-Enumerable.Union<Attribute>
	|-Enumerable.Union<object>
	|
	|-RVA: 0x4B3E30 Offset: 0x4B3230 VA: 0x1804B3E30
	|-Enumerable.Union<char>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5A80 Offset: 0xC4E80 VA: 0x1800C5A80
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3CB0 Offset: 0x4B30B0 VA: 0x1804B3CB0
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x4B3D70 Offset: 0x4B3170 VA: 0x1804B3D70
	|-Enumerable.UnionIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1670 Offset: 0x4B0A70 VA: 0x1804B1670
	|-Enumerable.Except<float>
	|
	|-RVA: 0x4B1710 Offset: 0x4B0B10 VA: 0x1804B1710
	|-Enumerable.Except<Vector2>
	|
	|-RVA: 0x4B15D0 Offset: 0x4B09D0 VA: 0x1804B15D0
	|-Enumerable.Except<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5CC0 Offset: 0xC50C0 VA: 0x1800C5CC0
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1450 Offset: 0x4B0850 VA: 0x1804B1450
	|-Enumerable.ExceptIterator<object>
	|
	|-RVA: 0x4B1510 Offset: 0x4B0910 VA: 0x1804B1510
	|-Enumerable.ExceptIterator<float>
	|-Enumerable.ExceptIterator<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1990 Offset: 0x4B0D90 VA: 0x1804B1990
	|-Enumerable.Reverse<PathList>
	|-Enumerable.Reverse<string>
	|-Enumerable.Reverse<object>
	|
	|-RVA: 0x4B18B0 Offset: 0x4B0CB0 VA: 0x1804B18B0
	|-Enumerable.Reverse<char>
	|
	|-RVA: 0x4B1920 Offset: 0x4B0D20 VA: 0x1804B1920
	|-Enumerable.Reverse<long>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5F90 Offset: 0xC5390 VA: 0x1800C5F90
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17B0 Offset: 0x4B0BB0 VA: 0x1804B17B0
	|-Enumerable.ReverseIterator<char>
	|
	|-RVA: 0x4B1830 Offset: 0x4B0C30 VA: 0x1804B1830
	|-Enumerable.ReverseIterator<long>
	|-Enumerable.ReverseIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEC7E0 Offset: 0xBEBBE0 VA: 0x180BEC7E0
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|-Enumerable.SequenceEqual<bool>
	|-Enumerable.SequenceEqual<object>
	|-Enumerable.SequenceEqual<string>
	|-Enumerable.SequenceEqual<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBECB60 Offset: 0xBEBF60 VA: 0x180BECB60
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xBEC7F0 Offset: 0xBEBBF0 VA: 0x180BEC7F0
	|-Enumerable.SequenceEqual<bool>
	|
	|-RVA: 0xBECEB0 Offset: 0xBEC2B0 VA: 0x180BECEB0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xBED210 Offset: 0xBEC610 VA: 0x180BED210
	|-Enumerable.SequenceEqual<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-Enumerable.AsEnumerable<Demos.DemoInfo>
	|-Enumerable.AsEnumerable<PathList>
	|-Enumerable.AsEnumerable<ServerInfo>
	|-Enumerable.AsEnumerable<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9060 Offset: 0x14A8460 VA: 0x1814A9060
	|-Enumerable.ToArray<<>f__AnonymousType0<string, string, bool>>
	|-Enumerable.ToArray<BasePlayer>
	|-Enumerable.ToArray<BaseViewModel>
	|-Enumerable.ToArray<ConsoleSystem.Command>
	|-Enumerable.ToArray<Report.StackTrace.StackFrame>
	|-Enumerable.ToArray<IPlayerInfo>
	|-Enumerable.ToArray<IPlayerItem>
	|-Enumerable.ToArray<IPlayerItemDefinition>
	|-Enumerable.ToArray<ItemDefinition>
	|-Enumerable.ToArray<ItemModWearable>
	|-Enumerable.ToArray<EventsCollection>
	|-Enumerable.ToArray<JsonConverter>
	|-Enumerable.ToArray<PieMenu.MenuOption>
	|-Enumerable.ToArray<Prefab>
	|-Enumerable.ToArray<Prefab<DungeonGridLink>>
	|-Enumerable.ToArray<Indexer.Entity>
	|-Enumerable.ToArray<SteamInventoryItem>
	|-Enumerable.ToArray<InventoryDef>
	|-Enumerable.ToArray<Attribute>
	|-Enumerable.ToArray<FileInfo>
	|-Enumerable.ToArray<string>
	|-Enumerable.ToArray<Type>
	|-Enumerable.ToArray<Behaviour>
	|-Enumerable.ToArray<GameObject>
	|-Enumerable.ToArray<Renderer>
	|-Enumerable.ToArray<Transform>
	|-Enumerable.ToArray<WeatherPreset>
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x14A88E0 Offset: 0x14A7CE0 VA: 0x1814A88E0
	|-Enumerable.ToArray<Debugging.EntityInfo>
	|
	|-RVA: 0x14A9240 Offset: 0x14A8640 VA: 0x1814A9240
	|-Enumerable.ToArray<GameStat.Stat>
	|
	|-RVA: 0x14A91A0 Offset: 0x14A85A0 VA: 0x1814A91A0
	|-Enumerable.ToArray<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x14A8980 Offset: 0x14A7D80 VA: 0x1814A8980
	|-Enumerable.ToArray<FourBitNumber>
	|
	|-RVA: 0x14A9100 Offset: 0x14A8500 VA: 0x1814A9100
	|-Enumerable.ToArray<SevenBitNumber>
	|
	|-RVA: 0x14A8F20 Offset: 0x14A8320 VA: 0x1814A8F20
	|-Enumerable.ToArray<Option>
	|
	|-RVA: 0x14A8FC0 Offset: 0x14A83C0 VA: 0x1814A8FC0
	|-Enumerable.ToArray<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x14A8C00 Offset: 0x14A8000 VA: 0x1814A8C00
	|-Enumerable.ToArray<InventoryDefId>
	|
	|-RVA: 0x14A8CA0 Offset: 0x14A80A0 VA: 0x1814A8CA0
	|-Enumerable.ToArray<InventoryItemId>
	|
	|-RVA: 0x14A8D40 Offset: 0x14A8140 VA: 0x1814A8D40
	|-Enumerable.ToArray<InventoryItem>
	|
	|-RVA: 0x14A8A20 Offset: 0x14A7E20 VA: 0x1814A8A20
	|-Enumerable.ToArray<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x14A8DE0 Offset: 0x14A81E0 VA: 0x1814A8DE0
	|-Enumerable.ToArray<InventoryRecipe>
	|
	|-RVA: 0x14A8E80 Offset: 0x14A8280 VA: 0x1814A8E80
	|-Enumerable.ToArray<Item>
	|
	|-RVA: 0x14A87A0 Offset: 0x14A7BA0 VA: 0x1814A87A0
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x14A8840 Offset: 0x14A7C40 VA: 0x1814A8840
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x14A8B60 Offset: 0x14A7F60 VA: 0x1814A8B60
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x14A92E0 Offset: 0x14A86E0 VA: 0x1814A92E0
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x14A8AC0 Offset: 0x14A7EC0 VA: 0x1814A8AC0
	|-Enumerable.ToArray<KeyCode>
	|-Enumerable.ToArray<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7AF0 Offset: 0x12A6EF0 VA: 0x1812A7AF0
	|-Enumerable.ToList<Chat.MuteEntry>
	|
	|-RVA: 0x12A7C30 Offset: 0x12A7030 VA: 0x1812A7C30
	|-Enumerable.ToList<GenerateDungeonBase.DungeonSegment>
	|-Enumerable.ToList<IPlayerItemDefinition>
	|-Enumerable.ToList<Item>
	|-Enumerable.ToList<ItemBlueprint>
	|-Enumerable.ToList<ItemDefinition>
	|-Enumerable.ToList<ItemIcon>
	|-Enumerable.ToList<LoadAssetsResult>
	|-Enumerable.ToList<ValueChange<TimeSignature>>
	|-Enumerable.ToList<MusicTheme>
	|-Enumerable.ToList<JsonWriter.State[]>
	|-Enumerable.ToList<JsonProperty>
	|-Enumerable.ToList<PieMenu.MenuOption>
	|-Enumerable.ToList<PrefabData>
	|-Enumerable.ToList<SteamItem>
	|-Enumerable.ToList<SteamItemDefinition>
	|-Enumerable.ToList<SkeletonProperties.BoneProperty>
	|-Enumerable.ToList<ConstructorInfo>
	|-Enumerable.ToList<MemberInfo>
	|-Enumerable.ToList<string>
	|-Enumerable.ToList<KerningPair>
	|-Enumerable.ToList<TMP_Character>
	|-Enumerable.ToList<TMP_GlyphPairAdjustmentRecord>
	|-Enumerable.ToList<Component>
	|-Enumerable.ToList<ParameterOverride>
	|-Enumerable.ToList<PostProcessBundle>
	|-Enumerable.ToList<Shader>
	|-Enumerable.ToList<Glyph>
	|-Enumerable.ToList<Transform>
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x12A7A50 Offset: 0x12A6E50 VA: 0x1812A7A50
	|-Enumerable.ToList<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0x12A7CD0 Offset: 0x12A70D0 VA: 0x1812A7CD0
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12A7D70 Offset: 0x12A7170 VA: 0x1812A7D70
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12A79B0 Offset: 0x12A6DB0 VA: 0x1812A79B0
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x12A7E10 Offset: 0x12A7210 VA: 0x1812A7E10
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x12A7B90 Offset: 0x12A6F90 VA: 0x1812A7B90
	|-Enumerable.ToList<Resolution>
	|
	|-RVA: 0x12A7EB0 Offset: 0x12A72B0 VA: 0x1812A7EB0
	|-Enumerable.ToList<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1565B20 Offset: 0x1564F20 VA: 0x181565B20
	|-Enumerable.ToDictionary<Input.Button, string>
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5F20 Offset: 0xDF5320 VA: 0x180DF5F20
	|-Enumerable.ToDictionary<JsonProperty, JsonProperty, JsonSerializerInternalReader.PropertyPresence>
	|-Enumerable.ToDictionary<Indexer.Entity, uint, Indexer.Entity>
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|-Enumerable.ToDictionary<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId, uint>
	|-Enumerable.ToDictionary<IGrouping<string, IPlayerInfo>, string, string>
	|-Enumerable.ToDictionary<TechTreeData.NodeInstance, int, TechTreeData.NodeInstance>
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|-Enumerable.ToDictionary<object, int, object>
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|-Enumerable.ToDictionary<object, object, object>
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15658A0 Offset: 0x1564CA0 VA: 0x1815658A0
	|-Enumerable.ToDictionary<IGrouping<string, PrefabData>, string, List<PrefabData>>
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x1564DF0 Offset: 0x15641F0 VA: 0x181564DF0
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|
	|-RVA: 0x15653B0 Offset: 0x15647B0 VA: 0x1815653B0
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|
	|-RVA: 0x1565130 Offset: 0x1564530 VA: 0x181565130
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x1565620 Offset: 0x1564A20 VA: 0x181565620
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1565B80 Offset: 0x1564F80 VA: 0x181565B80
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC64A80 Offset: 0xC63E80 VA: 0x180C64A80
	|-Enumerable.OfType<TrackChunk>
	|-Enumerable.OfType<Behaviour>
	|-Enumerable.OfType<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC6450 Offset: 0xC5850 VA: 0x1800C6450
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1830 Offset: 0x4B0C30 VA: 0x1804B1830
	|-Enumerable.OfTypeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC649E0 Offset: 0xC63DE0 VA: 0x180C649E0
	|-Enumerable.Cast<ProjectileWeaponMod>
	|-Enumerable.Cast<SteamItem>
	|-Enumerable.Cast<SteamItemDefinition>
	|-Enumerable.Cast<Attribute>
	|-Enumerable.Cast<FieldInfo>
	|-Enumerable.Cast<MemberInfo>
	|-Enumerable.Cast<EnumMemberAttribute>
	|-Enumerable.Cast<Match>
	|-Enumerable.Cast<Component>
	|-Enumerable.Cast<Transform>
	|-Enumerable.Cast<object>
	|
	|-RVA: 0xC646C0 Offset: 0xC63AC0 VA: 0x180C646C0
	|-Enumerable.Cast<bool>
	|
	|-RVA: 0xC64760 Offset: 0xC63B60 VA: 0x180C64760
	|-Enumerable.Cast<byte>
	|
	|-RVA: 0xC64800 Offset: 0xC63C00 VA: 0x180C64800
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0xC648A0 Offset: 0xC63CA0 VA: 0x180C648A0
	|-Enumerable.Cast<short>
	|
	|-RVA: 0xC64940 Offset: 0xC63D40 VA: 0x180C64940
	|-Enumerable.Cast<int>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC6570 Offset: 0xC5970 VA: 0x1800C6570
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17B0 Offset: 0x4B0BB0 VA: 0x1804B17B0
	|-Enumerable.CastIterator<bool>
	|-Enumerable.CastIterator<byte>
	|-Enumerable.CastIterator<short>
	|-Enumerable.CastIterator<int>
	|
	|-RVA: 0xC64640 Offset: 0xC63A40 VA: 0x180C64640
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x4B1830 Offset: 0x4B0C30 VA: 0x1804B1830
	|-Enumerable.CastIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A7610 Offset: 0x14A6A10 VA: 0x1814A7610
	|-Enumerable.First<BaseNetworkable>
	|-Enumerable.First<ItemDefinition>
	|-Enumerable.First<SteamInventoryItem>
	|-Enumerable.First<ConstructorInfo>
	|-Enumerable.First<MemberInfo>
	|-Enumerable.First<string>
	|-Enumerable.First<Animator>
	|-Enumerable.First<Object>
	|-Enumerable.First<Transform>
	|-Enumerable.First<object>
	|
	|-RVA: 0x14A6360 Offset: 0x14A5760 VA: 0x1814A6360
	|-Enumerable.First<InventoryItem>
	|
	|-RVA: 0x14A6690 Offset: 0x14A5A90 VA: 0x1814A6690
	|-Enumerable.First<Item>
	|
	|-RVA: 0x14A70C0 Offset: 0x14A64C0 VA: 0x1814A70C0
	|-Enumerable.First<Resolution>
	|
	|-RVA: 0x14A6070 Offset: 0x14A5470 VA: 0x1814A6070
	|-Enumerable.First<byte>
	|
	|-RVA: 0x14A6B30 Offset: 0x14A5F30 VA: 0x1814A6B30
	|-Enumerable.First<KeyValuePair<long, object>>
	|
	|-RVA: 0x14A6E50 Offset: 0x14A6250 VA: 0x1814A6E50
	|-Enumerable.First<KeyValuePair<object, object>>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A7420 Offset: 0x14A6820 VA: 0x1814A7420
	|-Enumerable.First<Dropdown.OptionData>
	|-Enumerable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A58F0 Offset: 0x14A4CF0 VA: 0x1814A58F0
	|-Enumerable.FirstOrDefault<CraftingQueueIcon>
	|-Enumerable.FirstOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.FirstOrDefault<ProjectileWeaponMod>
	|-Enumerable.FirstOrDefault<SocketHandle>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x14A4DC0 Offset: 0x14A41C0 VA: 0x1814A4DC0
	|-Enumerable.FirstOrDefault<SkeletonDefinition.Bone>
	|
	|-RVA: 0x14A5B00 Offset: 0x14A4F00 VA: 0x1814A5B00
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x14A5110 Offset: 0x14A4510 VA: 0x1814A5110
	|-Enumerable.FirstOrDefault<InventoryRecipe>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A5720 Offset: 0x14A4B20 VA: 0x1814A5720
	|-Enumerable.FirstOrDefault<Input.Button>
	|-Enumerable.FirstOrDefault<IPlayerItemDefinition>
	|-Enumerable.FirstOrDefault<Skinnable>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Match>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x14A5DC0 Offset: 0x14A51C0 VA: 0x1814A5DC0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x14A5450 Offset: 0x14A4850 VA: 0x1814A5450
	|-Enumerable.FirstOrDefault<PetCommandList.PetCommandDesc>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A7D50 Offset: 0x14A7150 VA: 0x1814A7D50
	|-Enumerable.Last<string>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A7830 Offset: 0x14A6C30 VA: 0x1814A7830
	|-Enumerable.LastOrDefault<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.LastOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A7B30 Offset: 0x14A6F30 VA: 0x1814A7B30
	|-Enumerable.LastOrDefault<MemberInfo>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A8520 Offset: 0x14A7920 VA: 0x1814A8520
	|-Enumerable.Single<MemberInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A8070 Offset: 0x14A7470 VA: 0x1814A8070
	|-Enumerable.SingleOrDefault<MemberInfo>
	|-Enumerable.SingleOrDefault<string>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A82D0 Offset: 0x14A76D0 VA: 0x1814A82D0
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4880 Offset: 0x14A3C80 VA: 0x1814A4880
	|-Enumerable.ElementAt<KeyValuePair<string, JSONNode>>
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x14A4B40 Offset: 0x14A3F40 VA: 0x1814A4B40
	|-Enumerable.ElementAt<string>
	|-Enumerable.ElementAt<object>
	*/

	// RVA: 0x2224BA0 Offset: 0x2223FA0 VA: 0x182224BA0
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachineAttribute] // RVA: 0xC72A0 Offset: 0xC66A0 VA: 0x1800C72A0
	// RVA: 0x2224B20 Offset: 0x2223F20 VA: 0x182224B20
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4978A0 Offset: 0x496CA0 VA: 0x1804978A0
	|-Enumerable.Empty<ItemBlueprint>
	|-Enumerable.Empty<byte>
	|-Enumerable.Empty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEB250 Offset: 0xBEA650 VA: 0x180BEB250
	|-Enumerable.Any<PlayerItemRecipe>
	|
	|-RVA: 0xBEAD00 Offset: 0xBEA100 VA: 0x180BEAD00
	|-Enumerable.Any<KeyValuePair<long, object>>
	|
	|-RVA: 0xBEAE70 Offset: 0xBEA270 VA: 0x180BEAE70
	|-Enumerable.Any<KeyValuePair<object, object>>
	|
	|-RVA: 0xBEB3C0 Offset: 0xBEA7C0 VA: 0x180BEB3C0
	|-Enumerable.Any<FileInfo>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|
	|-RVA: 0xBEB700 Offset: 0xBEAB00 VA: 0x180BEB700
	|-Enumerable.Any<float>
	|
	|-RVA: 0xBEB870 Offset: 0xBEAC70 VA: 0x180BEB870
	|-Enumerable.Any<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEB530 Offset: 0xBEA930 VA: 0x180BEB530
	|-Enumerable.Any<BaseEntity>
	|-Enumerable.Any<CardPlayerData>
	|-Enumerable.Any<Manifest.Administrator>
	|-Enumerable.Any<IPlayerInfo>
	|-Enumerable.Any<IPlayerItem>
	|-Enumerable.Any<Item>
	|-Enumerable.Any<LoadAssetsResult>
	|-Enumerable.Any<ProjectileWeaponMod>
	|-Enumerable.Any<PlayerNameID>
	|-Enumerable.Any<SteamInventoryItem>
	|-Enumerable.Any<byte[]>
	|-Enumerable.Any<object>
	|-Enumerable.Any<string>
	|-Enumerable.Any<Type>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Any<Wearable>
	|
	|-RVA: 0xBEAFE0 Offset: 0xBEA3E0 VA: 0x180BEAFE0
	|-Enumerable.Any<SkinnedMultiMesh.Part>
	|
	|-RVA: 0xBEA810 Offset: 0xBE9C10 VA: 0x180BEA810
	|-Enumerable.Any<InventoryItem.Amount>
	|
	|-RVA: 0xBEAA90 Offset: 0xBE9E90 VA: 0x180BEAA90
	|-Enumerable.Any<InventoryRecipe.Ingredient>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA640 Offset: 0xBE9A40 VA: 0x180BEA640
	|-Enumerable.All<AchievementGroup.AchievementItem>
	|-Enumerable.All<JsonSerializerInternalReader.CreatorPropertyContext>
	|-Enumerable.All<SteamInventoryItem>
	|-Enumerable.All<SkeletonProperties.BoneProperty>
	|-Enumerable.All<object>
	|-Enumerable.All<Collider>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7EC40 Offset: 0xE7E040 VA: 0x180E7EC40
	|-Enumerable.Count<BaseNetworkable>
	|-Enumerable.Count<CraftingQueueIcon>
	|-Enumerable.Count<AccountNotice>
	|-Enumerable.Count<GameSetup>
	|-Enumerable.Count<PieMenu.MenuOption>
	|-Enumerable.Count<SteamInventoryItem>
	|-Enumerable.Count<InventoryDef>
	|-Enumerable.Count<object>
	|-Enumerable.Count<MemberInfo>
	|-Enumerable.Count<string>
	|-Enumerable.Count<Animator>
	|-Enumerable.Count<BoxCollider>
	|-Enumerable.Count<CapsuleCollider>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<LODGroup>
	|-Enumerable.Count<MeshCollider>
	|-Enumerable.Count<Object>
	|-Enumerable.Count<Rigidbody>
	|-Enumerable.Count<SphereCollider>
	|-Enumerable.Count<Transform>
	|
	|-RVA: 0xE7F030 Offset: 0xE7E430 VA: 0x180E7F030
	|-Enumerable.Count<ServerInfo>
	|
	|-RVA: 0xE7EA40 Offset: 0xE7DE40 VA: 0x180E7EA40
	|-Enumerable.Count<InventoryItem>
	|
	|-RVA: 0xE7E840 Offset: 0xE7DC40 VA: 0x180E7E840
	|-Enumerable.Count<int>
	|
	|-RVA: 0xE7F230 Offset: 0xE7E630 VA: 0x180E7F230
	|-Enumerable.Count<float>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7E3D0 Offset: 0xE7D7D0 VA: 0x180E7E3D0
	|-Enumerable.Count<RCon.BannedAddresses>
	|
	|-RVA: 0xE7E650 Offset: 0xE7DA50 VA: 0x180E7E650
	|-Enumerable.Count<bool>
	|
	|-RVA: 0xE7EE40 Offset: 0xE7E240 VA: 0x180E7EE40
	|-Enumerable.Count<object>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<Renderer>
	|-Enumerable.Count<Rigidbody>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEBDB0 Offset: 0xBEB1B0 VA: 0x180BEBDB0
	|-Enumerable.Contains<TempoMapLine>
	|-Enumerable.Contains<int>
	|-Enumerable.Contains<Int32Enum>
	|-Enumerable.Contains<GraphicsDeviceType>
	|
	|-RVA: 0xBEC470 Offset: 0xBEB870 VA: 0x180BEC470
	|-Enumerable.Contains<MeshPaintableSource>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Component>
	|-Enumerable.Contains<Material>
	|-Enumerable.Contains<Renderer>
	|
	|-RVA: 0xBEB9E0 Offset: 0xBEADE0 VA: 0x180BEB9E0
	|-Enumerable.Contains<char>
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEBAF0 Offset: 0xBEAEF0 VA: 0x180BEBAF0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0xBEC060 Offset: 0xBEB460 VA: 0x180BEC060
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xBEBE60 Offset: 0xBEB260 VA: 0x180BEBE60
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xBEC260 Offset: 0xBEB660 VA: 0x180BEC260
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xBEC520 Offset: 0xBEB920 VA: 0x180BEC520
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2225010 Offset: 0x2224410 VA: 0x182225010
	public static int Sum(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2224E10 Offset: 0x2224210 VA: 0x182224E10
	public static long Sum(IEnumerable<long> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2224C60 Offset: 0x2224060 VA: 0x182224C60
	public static float Sum(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F5E0 Offset: 0xE7E9E0 VA: 0x180E7F5E0
	|-Enumerable.Sum<BurstCloth.Chain>
	|-Enumerable.Sum<IPlayerItem>
	|-Enumerable.Sum<IPlayerItemDefinition>
	|-Enumerable.Sum<Item>
	|-Enumerable.Sum<LoadAssetsResult>
	|-Enumerable.Sum<EventsCollection>
	|-Enumerable.Sum<PlayerItemRecipe.Ingredient>
	|-Enumerable.Sum<ServerInfo>
	|-Enumerable.Sum<InventoryItem>
	|-Enumerable.Sum<byte[]>
	|-Enumerable.Sum<object>
	|-Enumerable.Sum<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static long Sum<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F620 Offset: 0xE7EA20 VA: 0x180E7F620
	|-Enumerable.Sum<SkinnedMultiMesh.Part>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F600 Offset: 0xE7EA00 VA: 0x180E7F600
	|-Enumerable.Sum<WeightedStringList.Container>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22248F0 Offset: 0x2223CF0 VA: 0x1822248F0
	public static float Min(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2224520 Offset: 0x2223920 VA: 0x182224520
	public static int Max(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2224710 Offset: 0x2223B10 VA: 0x182224710
	public static float Max(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7F430 Offset: 0xE7E830 VA: 0x180E7F430
	|-Enumerable.Max<DungeonBaseInfo>
	|-Enumerable.Max<EZSoftBone.BoneChain>
	|-Enumerable.Max<BurstCloth.Chain>
	|-Enumerable.Max<object>
	|-Enumerable.Max<FieldInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22240E0 Offset: 0x22234E0 VA: 0x1822240E0
	public static float Average(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22242D0 Offset: 0x22236D0 VA: 0x1822242D0
	public static double Average(IEnumerable<double> source) { }

}

private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3199
{	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DE2C0 Offset: 0x19DD6C0 VA: 0x1819DE2C0
	|-Enumerable.Iterator<Debugging.EntityInfo>..ctor
	|-Enumerable.Iterator<BurstCloth.Chain>..ctor
	|-Enumerable.Iterator<SkeletonDefinition.Bone>..ctor
	|-Enumerable.Iterator<WeightedStringList.Container>..ctor
	|-Enumerable.Iterator<GameStat.Stat>..ctor
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.Iterator<FourBitNumber>..ctor
	|-Enumerable.Iterator<SevenBitNumber>..ctor
	|-Enumerable.Iterator<PathFinder.Point>..ctor
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.Iterator<PlayerItemRecipe>..ctor
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.Iterator<Option>..ctor
	|-Enumerable.Iterator<ServerInfo>..ctor
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.Iterator<Achievement>..ctor
	|-Enumerable.Iterator<InventoryDefId>..ctor
	|-Enumerable.Iterator<InventoryItemId>..ctor
	|-Enumerable.Iterator<ServerInfo>..ctor
	|-Enumerable.Iterator<Friend>..ctor
	|-Enumerable.Iterator<InventoryItem.Amount>..ctor
	|-Enumerable.Iterator<InventoryItem>..ctor
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.Iterator<InventoryRecipe>..ctor
	|-Enumerable.Iterator<bool>..ctor
	|-Enumerable.Iterator<char>..ctor
	|-Enumerable.Iterator<DictionaryEntry>..ctor
	|-Enumerable.Iterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.Iterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-Enumerable.Iterator<int>..ctor
	|-Enumerable.Iterator<Int32Enum>..ctor
	|-Enumerable.Iterator<long>..ctor
	|-Enumerable.Iterator<object>..ctor
	|-Enumerable.Iterator<float>..ctor
	|-Enumerable.Iterator<uint>..ctor
	|-Enumerable.Iterator<Resolution>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0
	|-Enumerable.Iterator<Debugging.EntityInfo>.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.Iterator<BurstCloth.Chain>.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<Achievement>.get_Current
	|-Enumerable.Iterator<InventoryItemId>.get_Current
	|-Enumerable.Iterator<Friend>.get_Current
	|-Enumerable.Iterator<long>.get_Current
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x171F0E0 Offset: 0x171E4E0 VA: 0x18171F0E0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.get_Current
	|
	|-RVA: 0x1768250 Offset: 0x1767650 VA: 0x181768250
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.get_Current
	|-Enumerable.Iterator<Option>.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.get_Current
	|-Enumerable.Iterator<InventoryItem>.get_Current
	|
	|-RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	|-Enumerable.Iterator<FourBitNumber>.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.get_Current
	|-Enumerable.Iterator<bool>.get_Current
	|
	|-RVA: 0x12C7E00 Offset: 0x12C7200 VA: 0x1812C7E00
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|
	|-RVA: 0xDE7070 Offset: 0xDE6470 VA: 0x180DE7070
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|
	|-RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	|-Enumerable.Iterator<InventoryDefId>.get_Current
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x11222B0 Offset: 0x11216B0 VA: 0x1811222B0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|
	|-RVA: 0x1393AF0 Offset: 0x1392EF0 VA: 0x181393AF0
	|-Enumerable.Iterator<char>.get_Current
	|
	|-RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	|-Enumerable.Iterator<float>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DD050 Offset: 0x19DC450 VA: 0x1819DD050
	|-Enumerable.Iterator<Debugging.EntityInfo>.Dispose
	|-Enumerable.Iterator<WeightedStringList.Container>.Dispose
	|-Enumerable.Iterator<GameStat.Stat>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe>.Dispose
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19DD080 Offset: 0x19DC480 VA: 0x1819DD080
	|-Enumerable.Iterator<BurstCloth.Chain>.Dispose
	|-Enumerable.Iterator<PathFinder.Point>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<Achievement>.Dispose
	|-Enumerable.Iterator<InventoryItemId>.Dispose
	|-Enumerable.Iterator<Friend>.Dispose
	|-Enumerable.Iterator<long>.Dispose
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x19DD0E0 Offset: 0x19DC4E0 VA: 0x1819DD0E0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.Dispose
	|-Enumerable.Iterator<InventoryItem.Amount>.Dispose
	|
	|-RVA: 0x19DD0B0 Offset: 0x19DC4B0 VA: 0x1819DD0B0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.Dispose
	|-Enumerable.Iterator<Option>.Dispose
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.Dispose
	|-Enumerable.Iterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19DD130 Offset: 0x19DC530 VA: 0x1819DD130
	|-Enumerable.Iterator<FourBitNumber>.Dispose
	|-Enumerable.Iterator<SevenBitNumber>.Dispose
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x19DD090 Offset: 0x19DC490 VA: 0x1819DD090
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|
	|-RVA: 0x19DD100 Offset: 0x19DC500 VA: 0x1819DD100
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19DD040 Offset: 0x19DC440 VA: 0x1819DD040
	|-Enumerable.Iterator<InventoryDefId>.Dispose
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x19DD060 Offset: 0x19DC460 VA: 0x1819DD060
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<InventoryRecipe>.Dispose
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19DD0D0 Offset: 0x19DC4D0 VA: 0x1819DD0D0
	|-Enumerable.Iterator<char>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DD140 Offset: 0x19DC540 VA: 0x1819DD140
	|-Enumerable.Iterator<Debugging.EntityInfo>.GetEnumerator
	|-Enumerable.Iterator<BurstCloth.Chain>.GetEnumerator
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.GetEnumerator
	|-Enumerable.Iterator<WeightedStringList.Container>.GetEnumerator
	|-Enumerable.Iterator<GameStat.Stat>.GetEnumerator
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.GetEnumerator
	|-Enumerable.Iterator<FourBitNumber>.GetEnumerator
	|-Enumerable.Iterator<SevenBitNumber>.GetEnumerator
	|-Enumerable.Iterator<PathFinder.Point>.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe>.GetEnumerator
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.GetEnumerator
	|-Enumerable.Iterator<Option>.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.GetEnumerator
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.GetEnumerator
	|-Enumerable.Iterator<Achievement>.GetEnumerator
	|-Enumerable.Iterator<InventoryDefId>.GetEnumerator
	|-Enumerable.Iterator<InventoryItemId>.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.GetEnumerator
	|-Enumerable.Iterator<Friend>.GetEnumerator
	|-Enumerable.Iterator<InventoryItem.Amount>.GetEnumerator
	|-Enumerable.Iterator<InventoryItem>.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe>.GetEnumerator
	|-Enumerable.Iterator<bool>.GetEnumerator
	|-Enumerable.Iterator<char>.GetEnumerator
	|-Enumerable.Iterator<DictionaryEntry>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, int>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.GetEnumerator
	|-Enumerable.Iterator<int>.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|-Enumerable.Iterator<long>.GetEnumerator
	|-Enumerable.Iterator<object>.GetEnumerator
	|-Enumerable.Iterator<float>.GetEnumerator
	|-Enumerable.Iterator<uint>.GetEnumerator
	|-Enumerable.Iterator<Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DDE20 Offset: 0x19DD220 VA: 0x1819DDE20
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DDE90 Offset: 0x19DD290 VA: 0x1819DDE90
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE1E0 Offset: 0x19DD5E0 VA: 0x1819DE1E0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DDEF0 Offset: 0x19DD2F0 VA: 0x1819DDEF0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE180 Offset: 0x19DD580 VA: 0x1819DE180
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE100 Offset: 0x19DD500 VA: 0x1819DE100
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DDF70 Offset: 0x19DD370 VA: 0x1819DDF70
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE0A0 Offset: 0x19DD4A0 VA: 0x1819DE0A0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DDDA0 Offset: 0x19DD1A0 VA: 0x1819DDDA0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE260 Offset: 0x19DD660 VA: 0x1819DE260
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19BAB30 Offset: 0x19B9F30 VA: 0x1819BAB30
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DE030 Offset: 0x19DD430 VA: 0x1819DE030
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BBD0 Offset: 0x175AFD0 VA: 0x18175BBD0
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<float>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DDBC0 Offset: 0x19DCFC0 VA: 0x1819DDBC0
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDC60 Offset: 0x19DD060 VA: 0x1819DDC60
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD8A0 Offset: 0x19DCCA0 VA: 0x1819DD8A0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD3A0 Offset: 0x19DC7A0 VA: 0x1819DD3A0
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD8F0 Offset: 0x19DCCF0 VA: 0x1819DD8F0
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD2B0 Offset: 0x19DC6B0 VA: 0x1819DD2B0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDD00 Offset: 0x19DD100 VA: 0x1819DDD00
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD490 Offset: 0x19DC890 VA: 0x1819DD490
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD300 Offset: 0x19DC700 VA: 0x1819DD300
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDC10 Offset: 0x19DD010 VA: 0x1819DDC10
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD670 Offset: 0x19DCA70 VA: 0x1819DD670
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD5D0 Offset: 0x19DC9D0 VA: 0x1819DD5D0
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD760 Offset: 0x19DCB60 VA: 0x1819DD760
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD440 Offset: 0x19DC840 VA: 0x1819DD440
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD710 Offset: 0x19DCB10 VA: 0x1819DD710
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD1C0 Offset: 0x19DC5C0 VA: 0x1819DD1C0
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDB70 Offset: 0x19DCF70 VA: 0x1819DDB70
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD990 Offset: 0x19DCD90 VA: 0x1819DD990
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDD50 Offset: 0x19DD150 VA: 0x1819DDD50
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDA80 Offset: 0x19DCE80 VA: 0x1819DDA80
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDCB0 Offset: 0x19DD0B0 VA: 0x1819DDCB0
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD850 Offset: 0x19DCC50 VA: 0x1819DD850
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDAD0 Offset: 0x19DCED0 VA: 0x1819DDAD0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD940 Offset: 0x19DCD40 VA: 0x1819DD940
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD6C0 Offset: 0x19DCAC0 VA: 0x1819DD6C0
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD9E0 Offset: 0x19DCDE0 VA: 0x1819DD9E0
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD350 Offset: 0x19DC750 VA: 0x1819DD350
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD620 Offset: 0x19DCA20 VA: 0x1819DD620
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD530 Offset: 0x19DC930 VA: 0x1819DD530
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD260 Offset: 0x19DC660 VA: 0x1819DD260
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDB20 Offset: 0x19DCF20 VA: 0x1819DDB20
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD210 Offset: 0x19DC610 VA: 0x1819DD210
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD800 Offset: 0x19DCC00 VA: 0x1819DD800
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD580 Offset: 0x19DC980 VA: 0x1819DD580
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD3F0 Offset: 0x19DC7F0 VA: 0x1819DD3F0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD4E0 Offset: 0x19DC8E0 VA: 0x1819DD4E0
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DDA30 Offset: 0x19DCE30 VA: 0x1819DDA30
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DD7B0 Offset: 0x19DCBB0 VA: 0x1819DD7B0
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.Reset
	*/

}

private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3200
{	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169F0B0 Offset: 0x169E4B0 VA: 0x18169F0B0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>..ctor
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|
	|-RVA: 0x16A0910 Offset: 0x169FD10 VA: 0x1816A0910
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A0980 Offset: 0x169FD80 VA: 0x1816A0980
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereEnumerableIterator<Option>..ctor
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItem>..ctor
	|
	|-RVA: 0x169F120 Offset: 0x169E520 VA: 0x18169F120
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>..ctor
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>..ctor
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>..ctor
	|-Enumerable.WhereEnumerableIterator<bool>..ctor
	|-Enumerable.WhereEnumerableIterator<char>..ctor
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|-Enumerable.WhereEnumerableIterator<long>..ctor
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|-Enumerable.WhereEnumerableIterator<float>..ctor
	|-Enumerable.WhereEnumerableIterator<uint>..ctor
	|
	|-RVA: 0x16A09F0 Offset: 0x169FDF0 VA: 0x1816A09F0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A08A0 Offset: 0x169FCA0 VA: 0x1816A08A0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169E9B0 Offset: 0x169DDB0 VA: 0x18169E9B0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Clone
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|
	|-RVA: 0x169F210 Offset: 0x169E610 VA: 0x18169F210
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x169F190 Offset: 0x169E590 VA: 0x18169F190
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereEnumerableIterator<Option>.Clone
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Clone
	|
	|-RVA: 0x169EA30 Offset: 0x169DE30 VA: 0x18169EA30
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Clone
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Clone
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Clone
	|-Enumerable.WhereEnumerableIterator<bool>.Clone
	|-Enumerable.WhereEnumerableIterator<char>.Clone
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|-Enumerable.WhereEnumerableIterator<long>.Clone
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|-Enumerable.WhereEnumerableIterator<float>.Clone
	|-Enumerable.WhereEnumerableIterator<uint>.Clone
	|
	|-RVA: 0x169F290 Offset: 0x169E690 VA: 0x18169F290
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Clone
	|
	|-RVA: 0x169F320 Offset: 0x169E720 VA: 0x18169F320
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5E50 Offset: 0x19E5250 VA: 0x1819E5E50
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19E6990 Offset: 0x19E5D90 VA: 0x1819E6990
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Dispose
	|
	|-RVA: 0x19E6000 Offset: 0x19E5400 VA: 0x1819E6000
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Dispose
	|
	|-RVA: 0x19E5CA0 Offset: 0x19E50A0 VA: 0x1819E5CA0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Dispose
	|
	|-RVA: 0x19E5B80 Offset: 0x19E4F80 VA: 0x1819E5B80
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Dispose
	|
	|-RVA: 0x19E6360 Offset: 0x19E5760 VA: 0x1819E6360
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Dispose
	|
	|-RVA: 0x19E5C10 Offset: 0x19E5010 VA: 0x1819E5C10
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Dispose
	|
	|-RVA: 0x19E6120 Offset: 0x19E5520 VA: 0x1819E6120
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19E5F70 Offset: 0x19E5370 VA: 0x1819E5F70
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x19E5AF0 Offset: 0x19E4EF0 VA: 0x1819E5AF0
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19E6240 Offset: 0x19E5640 VA: 0x1819E6240
	|-Enumerable.WhereEnumerableIterator<Option>.Dispose
	|
	|-RVA: 0x19E6870 Offset: 0x19E5C70 VA: 0x1819E6870
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19E5A60 Offset: 0x19E4E60 VA: 0x1819E5A60
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Dispose
	|
	|-RVA: 0x19E63F0 Offset: 0x19E57F0 VA: 0x1819E63F0
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Dispose
	|
	|-RVA: 0x19E6510 Offset: 0x19E5910 VA: 0x1819E6510
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19E67E0 Offset: 0x19E5BE0 VA: 0x1819E67E0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19E5D30 Offset: 0x19E5130 VA: 0x1819E5D30
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Dispose
	|
	|-RVA: 0x19E5EE0 Offset: 0x19E52E0 VA: 0x1819E5EE0
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x19E66C0 Offset: 0x19E5AC0 VA: 0x1819E66C0
	|-Enumerable.WhereEnumerableIterator<char>.Dispose
	|
	|-RVA: 0x19E5DC0 Offset: 0x19E51C0 VA: 0x1819E5DC0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19E6630 Offset: 0x19E5A30 VA: 0x1819E6630
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x19E62D0 Offset: 0x19E56D0 VA: 0x1819E62D0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19E6480 Offset: 0x19E5880 VA: 0x1819E6480
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19E61B0 Offset: 0x19E55B0 VA: 0x1819E61B0
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x19E6900 Offset: 0x19E5D00 VA: 0x1819E6900
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x19E6090 Offset: 0x19E5490 VA: 0x1819E6090
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x19E6750 Offset: 0x19E5B50 VA: 0x1819E6750
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x19E65A0 Offset: 0x19E59A0 VA: 0x1819E65A0
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x169EAB0 Offset: 0x169DEB0 VA: 0x18169EAB0
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0x169EB40 Offset: 0x169DF40 VA: 0x18169EB40
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E8740 Offset: 0x19E7B40 VA: 0x1819E8740
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19E8920 Offset: 0x19E7D20 VA: 0x1819E8920
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19E71C0 Offset: 0x19E65C0 VA: 0x1819E71C0
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.MoveNext
	|
	|-RVA: 0x19E9BF0 Offset: 0x19E8FF0 VA: 0x1819E9BF0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.MoveNext
	|
	|-RVA: 0x19E9850 Offset: 0x19E8C50 VA: 0x1819E9850
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.MoveNext
	|
	|-RVA: 0x19E76A0 Offset: 0x19E6AA0 VA: 0x1819E76A0
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19E7E20 Offset: 0x19E7220 VA: 0x1819E7E20
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19E7860 Offset: 0x19E6C60 VA: 0x1819E7860
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19E8380 Offset: 0x19E7780 VA: 0x1819E8380
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19E7C40 Offset: 0x19E7040 VA: 0x1819E7C40
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19E6C50 Offset: 0x19E6050 VA: 0x1819E6C50
	|-Enumerable.WhereEnumerableIterator<Option>.MoveNext
	|
	|-RVA: 0x19E73A0 Offset: 0x19E67A0 VA: 0x1819E73A0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19E8150 Offset: 0x19E7550 VA: 0x1819E8150
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19E93D0 Offset: 0x19E87D0 VA: 0x1819E93D0
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.MoveNext
	|
	|-RVA: 0x19E6A20 Offset: 0x19E5E20 VA: 0x1819E6A20
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19E7A20 Offset: 0x19E6E20 VA: 0x1819E7A20
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19E8B70 Offset: 0x19E7F70 VA: 0x1819E8B70
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19E9590 Offset: 0x19E8990 VA: 0x1819E9590
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x19E96F0 Offset: 0x19E8AF0 VA: 0x1819E96F0
	|-Enumerable.WhereEnumerableIterator<char>.MoveNext
	|
	|-RVA: 0x19E8560 Offset: 0x19E7960 VA: 0x1819E8560
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19E6FE0 Offset: 0x19E63E0 VA: 0x1819E6FE0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19E9A10 Offset: 0x19E8E10 VA: 0x1819E9A10
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19E8EF0 Offset: 0x19E82F0 VA: 0x1819E8EF0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19E9270 Offset: 0x19E8670 VA: 0x1819E9270
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x19E6E80 Offset: 0x19E6280 VA: 0x1819E6E80
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19E8D90 Offset: 0x19E8190 VA: 0x1819E8D90
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x19E7FE0 Offset: 0x19E73E0 VA: 0x1819E7FE0
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x19E9110 Offset: 0x19E8510 VA: 0x1819E9110
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x169EDB0 Offset: 0x169E1B0 VA: 0x18169EDB0
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0x169EBD0 Offset: 0x169DFD0 VA: 0x18169EBD0
	|-Enumerable.WhereEnumerableIterator<Resolution>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BD60 Offset: 0xC6B160 VA: 0x180C6BD60
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC6BA90 Offset: 0xC6AE90 VA: 0x180C6BA90
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereEnumerableIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereEnumerableIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereEnumerableIterator<int>.Select<int>
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereEnumerableIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereEnumerableIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereEnumerableIterator<object>.Select<bool>
	|-Enumerable.WhereEnumerableIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereEnumerableIterator<object>.Select<long>
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<float>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Resolution>
	|
	|-RVA: 0xC6BCD0 Offset: 0xC6B0D0 VA: 0x180C6BCD0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC6BC40 Offset: 0xC6B040 VA: 0x180C6BC40
	|-Enumerable.WhereEnumerableIterator<Option>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6BBB0 Offset: 0xC6AFB0 VA: 0x180C6BBB0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BB20 Offset: 0xC6AF20 VA: 0x180C6BB20
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169F010 Offset: 0x169E410 VA: 0x18169F010
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Where
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|
	|-RVA: 0x19E9EC0 Offset: 0x19E92C0 VA: 0x1819E9EC0
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19E9E20 Offset: 0x19E9220 VA: 0x1819E9E20
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereEnumerableIterator<Option>.Where
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Where
	|
	|-RVA: 0x169EF70 Offset: 0x169E370 VA: 0x18169EF70
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Where
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Where
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Where
	|-Enumerable.WhereEnumerableIterator<bool>.Where
	|-Enumerable.WhereEnumerableIterator<char>.Where
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|-Enumerable.WhereEnumerableIterator<long>.Where
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|-Enumerable.WhereEnumerableIterator<float>.Where
	|-Enumerable.WhereEnumerableIterator<uint>.Where
	|
	|-RVA: 0x19E9F60 Offset: 0x19E9360 VA: 0x1819E9F60
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Where
	|
	|-RVA: 0x19EA000 Offset: 0x19E9400 VA: 0x1819EA000
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	*/

}

private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3201
{	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0910 Offset: 0x169FD10 VA: 0x1816A0910
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x169F0B0 Offset: 0x169E4B0 VA: 0x18169F0B0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A0980 Offset: 0x169FD80 VA: 0x1816A0980
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereArrayIterator<Option>..ctor
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereArrayIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A09F0 Offset: 0x169FDF0 VA: 0x1816A09F0
	|-Enumerable.WhereArrayIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A08A0 Offset: 0x169FCA0 VA: 0x1816A08A0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereArrayIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x169F120 Offset: 0x169E520 VA: 0x18169F120
	|-Enumerable.WhereArrayIterator<char>..ctor
	|-Enumerable.WhereArrayIterator<int>..ctor
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169F210 Offset: 0x169E610 VA: 0x18169F210
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x169E9B0 Offset: 0x169DDB0 VA: 0x18169E9B0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x169F190 Offset: 0x169E590 VA: 0x18169F190
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereArrayIterator<Option>.Clone
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereArrayIterator<InventoryItem>.Clone
	|
	|-RVA: 0x169F290 Offset: 0x169E690 VA: 0x18169F290
	|-Enumerable.WhereArrayIterator<ServerInfo>.Clone
	|
	|-RVA: 0x169F320 Offset: 0x169E720 VA: 0x18169F320
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x169EA30 Offset: 0x169DE30 VA: 0x18169EA30
	|-Enumerable.WhereArrayIterator<char>.Clone
	|-Enumerable.WhereArrayIterator<int>.Clone
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E4E10 Offset: 0x19E4210 VA: 0x1819E4E10
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19E4D30 Offset: 0x19E4130 VA: 0x1819E4D30
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19E4C30 Offset: 0x19E4030 VA: 0x1819E4C30
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereArrayIterator<Option>.MoveNext
	|
	|-RVA: 0x19E55B0 Offset: 0x19E49B0 VA: 0x1819E55B0
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19E4A40 Offset: 0x19E3E40 VA: 0x1819E4A40
	|-Enumerable.WhereArrayIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19E5210 Offset: 0x19E4610 VA: 0x1819E5210
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19E5010 Offset: 0x19E4410 VA: 0x1819E5010
	|-Enumerable.WhereArrayIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19E5110 Offset: 0x19E4510 VA: 0x1819E5110
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19E54B0 Offset: 0x19E48B0 VA: 0x1819E54B0
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19E4980 Offset: 0x19E3D80 VA: 0x1819E4980
	|-Enumerable.WhereArrayIterator<char>.MoveNext
	|
	|-RVA: 0x19E53D0 Offset: 0x19E47D0 VA: 0x1819E53D0
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19E5310 Offset: 0x19E4710 VA: 0x1819E5310
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19E4F40 Offset: 0x19E4340 VA: 0x1819E4F40
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BD60 Offset: 0xC6B160 VA: 0x180C6BD60
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC6BCD0 Offset: 0xC6B0D0 VA: 0x180C6BCD0
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC6BC40 Offset: 0xC6B040 VA: 0x180C6BC40
	|-Enumerable.WhereArrayIterator<Option>.Select<Option>
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6BBB0 Offset: 0xC6AFB0 VA: 0x180C6BBB0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BB20 Offset: 0xC6AF20 VA: 0x180C6BB20
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC6BA90 Offset: 0xC6AE90 VA: 0x180C6BA90
	|-Enumerable.WhereArrayIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereArrayIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereArrayIterator<int>.Select<int>
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereArrayIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereArrayIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereArrayIterator<object>.Select<Option>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereArrayIterator<object>.Select<bool>
	|-Enumerable.WhereArrayIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|-Enumerable.WhereArrayIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereArrayIterator<object>.Select<long>
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<float>
	|-Enumerable.WhereArrayIterator<object>.Select<Resolution>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E5880 Offset: 0x19E4C80 VA: 0x1819E5880
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19E57E0 Offset: 0x19E4BE0 VA: 0x1819E57E0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Where
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x19E56A0 Offset: 0x19E4AA0 VA: 0x1819E56A0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereArrayIterator<Option>.Where
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereArrayIterator<InventoryItem>.Where
	|
	|-RVA: 0x19E5920 Offset: 0x19E4D20 VA: 0x1819E5920
	|-Enumerable.WhereArrayIterator<ServerInfo>.Where
	|
	|-RVA: 0x19E59C0 Offset: 0x19E4DC0 VA: 0x1819E59C0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x19E5740 Offset: 0x19E4B40 VA: 0x1819E5740
	|-Enumerable.WhereArrayIterator<char>.Where
	|-Enumerable.WhereArrayIterator<int>.Where
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|-Enumerable.WhereArrayIterator<object>.Where
	*/

}

private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3202
{	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0910 Offset: 0x169FD10 VA: 0x1816A0910
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x169F0B0 Offset: 0x169E4B0 VA: 0x18169F0B0
	|-Enumerable.WhereListIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A0980 Offset: 0x169FD80 VA: 0x1816A0980
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereListIterator<Option>..ctor
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereListIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A09F0 Offset: 0x169FDF0 VA: 0x1816A09F0
	|-Enumerable.WhereListIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A08A0 Offset: 0x169FCA0 VA: 0x1816A08A0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereListIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x169F120 Offset: 0x169E520 VA: 0x18169F120
	|-Enumerable.WhereListIterator<char>..ctor
	|-Enumerable.WhereListIterator<int>..ctor
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169F210 Offset: 0x169E610 VA: 0x18169F210
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x169E9B0 Offset: 0x169DDB0 VA: 0x18169E9B0
	|-Enumerable.WhereListIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x169F190 Offset: 0x169E590 VA: 0x18169F190
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereListIterator<Option>.Clone
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereListIterator<InventoryItem>.Clone
	|
	|-RVA: 0x169F290 Offset: 0x169E690 VA: 0x18169F290
	|-Enumerable.WhereListIterator<ServerInfo>.Clone
	|
	|-RVA: 0x169F320 Offset: 0x169E720 VA: 0x18169F320
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereListIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x169EA30 Offset: 0x169DE30 VA: 0x18169EA30
	|-Enumerable.WhereListIterator<char>.Clone
	|-Enumerable.WhereListIterator<int>.Clone
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169F3A0 Offset: 0x169E7A0 VA: 0x18169F3A0
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x169F520 Offset: 0x169E920 VA: 0x18169F520
	|-Enumerable.WhereListIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x169F8B0 Offset: 0x169ECB0 VA: 0x18169F8B0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereListIterator<Option>.MoveNext
	|
	|-RVA: 0x169F640 Offset: 0x169EA40 VA: 0x18169F640
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x169FA00 Offset: 0x169EE00 VA: 0x18169FA00
	|-Enumerable.WhereListIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x16A0290 Offset: 0x169F690 VA: 0x1816A0290
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x169F760 Offset: 0x169EB60 VA: 0x18169F760
	|-Enumerable.WhereListIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x169FEB0 Offset: 0x169F2B0 VA: 0x18169FEB0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x16A0130 Offset: 0x169F530 VA: 0x1816A0130
	|-Enumerable.WhereListIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A03E0 Offset: 0x169F7E0 VA: 0x1816A03E0
	|-Enumerable.WhereListIterator<char>.MoveNext
	|
	|-RVA: 0x16A0010 Offset: 0x169F410 VA: 0x1816A0010
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x169FDB0 Offset: 0x169F1B0 VA: 0x18169FDB0
	|-Enumerable.WhereListIterator<int>.MoveNext
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x169FCA0 Offset: 0x169F0A0 VA: 0x18169FCA0
	|-Enumerable.WhereListIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BD60 Offset: 0xC6B160 VA: 0x180C6BD60
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC6BCD0 Offset: 0xC6B0D0 VA: 0x180C6BCD0
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC6BC40 Offset: 0xC6B040 VA: 0x180C6BC40
	|-Enumerable.WhereListIterator<Option>.Select<Option>
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6BBB0 Offset: 0xC6AFB0 VA: 0x180C6BBB0
	|-Enumerable.WhereListIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereListIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BB20 Offset: 0xC6AF20 VA: 0x180C6BB20
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereListIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC6BA90 Offset: 0xC6AE90 VA: 0x180C6BA90
	|-Enumerable.WhereListIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereListIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereListIterator<int>.Select<int>
	|-Enumerable.WhereListIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereListIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereListIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereListIterator<object>.Select<Option>
	|-Enumerable.WhereListIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereListIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereListIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereListIterator<object>.Select<bool>
	|-Enumerable.WhereListIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereListIterator<object>.Select<int>
	|-Enumerable.WhereListIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereListIterator<object>.Select<long>
	|-Enumerable.WhereListIterator<object>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<float>
	|-Enumerable.WhereListIterator<object>.Select<Resolution>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0800 Offset: 0x169FC00 VA: 0x1816A0800
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x16A04E0 Offset: 0x169F8E0 VA: 0x1816A04E0
	|-Enumerable.WhereListIterator<GameStat.Stat>.Where
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x16A0580 Offset: 0x169F980 VA: 0x1816A0580
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereListIterator<Option>.Where
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereListIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A0760 Offset: 0x169FB60 VA: 0x1816A0760
	|-Enumerable.WhereListIterator<ServerInfo>.Where
	|
	|-RVA: 0x16A06C0 Offset: 0x169FAC0 VA: 0x1816A06C0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereListIterator<InventoryRecipe>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x16A0620 Offset: 0x169FA20 VA: 0x1816A0620
	|-Enumerable.WhereListIterator<char>.Where
	|-Enumerable.WhereListIterator<int>.Where
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|-Enumerable.WhereListIterator<object>.Where
	*/

}

private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3203
{	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A5CC0 Offset: 0x16A50C0 VA: 0x1816A5CC0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>..ctor
	|
	|-RVA: 0x16A5D50 Offset: 0x16A5150 VA: 0x1816A5D50
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A5E70 Offset: 0x16A5270 VA: 0x1816A5E70
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A5DE0 Offset: 0x16A51E0 VA: 0x1816A5DE0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A5F00 Offset: 0x16A5300 VA: 0x1816A5F00
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0BA0 Offset: 0x169FFA0 VA: 0x1816A0BA0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Clone
	|
	|-RVA: 0x16A0A60 Offset: 0x169FE60 VA: 0x1816A0A60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A0B00 Offset: 0x169FF00 VA: 0x1816A0B00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A0C40 Offset: 0x16A0040 VA: 0x1816A0C40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A0CE0 Offset: 0x16A00E0 VA: 0x1816A0CE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDA70 Offset: 0x19CCE70 VA: 0x1819CDA70
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Dispose
	|
	|-RVA: 0x19CD560 Offset: 0x19CC960 VA: 0x1819CD560
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Dispose
	|
	|-RVA: 0x19CD440 Offset: 0x19CC840 VA: 0x1819CD440
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Dispose
	|
	|-RVA: 0x19CDB90 Offset: 0x19CCF90 VA: 0x1819CDB90
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19CDC20 Offset: 0x19CD020 VA: 0x1819CDC20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Dispose
	|
	|-RVA: 0x19CDB00 Offset: 0x19CCF00 VA: 0x1819CDB00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19CD710 Offset: 0x19CCB10 VA: 0x1819CD710
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Dispose
	|
	|-RVA: 0x19CD8C0 Offset: 0x19CCCC0 VA: 0x1819CD8C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Dispose
	|
	|-RVA: 0x19CD830 Offset: 0x19CCC30 VA: 0x1819CD830
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19CD4D0 Offset: 0x19CC8D0 VA: 0x1819CD4D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Dispose
	|
	|-RVA: 0x19CD7A0 Offset: 0x19CCBA0 VA: 0x1819CD7A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Dispose
	|
	|-RVA: 0x19CD3B0 Offset: 0x19CC7B0 VA: 0x1819CD3B0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19CD5F0 Offset: 0x19CC9F0 VA: 0x1819CD5F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Dispose
	|
	|-RVA: 0x19CD680 Offset: 0x19CCA80 VA: 0x1819CD680
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Dispose
	|
	|-RVA: 0x19CD9E0 Offset: 0x19CCDE0 VA: 0x1819CD9E0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Dispose
	|
	|-RVA: 0x19CD950 Offset: 0x19CCD50 VA: 0x1819CD950
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Dispose
	|
	|-RVA: 0x1A13B80 Offset: 0x1A12F80 VA: 0x181A13B80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Dispose
	|
	|-RVA: 0x1A14F30 Offset: 0x1A14330 VA: 0x181A14F30
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Dispose
	|
	|-RVA: 0x1A14BD0 Offset: 0x1A13FD0 VA: 0x181A14BD0
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Dispose
	|
	|-RVA: 0x1A12E90 Offset: 0x1A12290 VA: 0x181A12E90
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A14120 Offset: 0x1A13520 VA: 0x181A14120
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A14FC0 Offset: 0x1A143C0 VA: 0x181A14FC0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A11C90 Offset: 0x1A11090 VA: 0x181A11C90
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Dispose
	|
	|-RVA: 0x1A14090 Offset: 0x1A13490 VA: 0x181A14090
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Dispose
	|
	|-RVA: 0x1A12CE0 Offset: 0x1A120E0 VA: 0x181A12CE0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A131F0 Offset: 0x1A125F0 VA: 0x181A131F0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A13310 Offset: 0x1A12710 VA: 0x181A13310
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Dispose
	|
	|-RVA: 0x1A14EA0 Offset: 0x1A142A0 VA: 0x181A14EA0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A146C0 Offset: 0x1A13AC0 VA: 0x181A146C0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Dispose
	|
	|-RVA: 0x1A12F20 Offset: 0x1A12320 VA: 0x181A12F20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Dispose
	|
	|-RVA: 0x1A13280 Offset: 0x1A12680 VA: 0x181A13280
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Dispose
	|
	|-RVA: 0x1A139D0 Offset: 0x1A12DD0 VA: 0x181A139D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Dispose
	|
	|-RVA: 0x1A11D20 Offset: 0x1A11120 VA: 0x181A11D20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Dispose
	|
	|-RVA: 0x1A13820 Offset: 0x1A12C20 VA: 0x181A13820
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Dispose
	|
	|-RVA: 0x1A12860 Offset: 0x1A11C60 VA: 0x181A12860
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A141B0 Offset: 0x1A135B0 VA: 0x181A141B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A14480 Offset: 0x1A13880 VA: 0x181A14480
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A12AA0 Offset: 0x1A11EA0 VA: 0x181A12AA0
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Dispose
	|
	|-RVA: 0x1A11F60 Offset: 0x1A11360 VA: 0x181A11F60
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Dispose
	|
	|-RVA: 0x1A13E50 Offset: 0x1A13250 VA: 0x181A13E50
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A13C10 Offset: 0x1A13010 VA: 0x181A13C10
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A12BC0 Offset: 0x1A11FC0 VA: 0x181A12BC0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A145A0 Offset: 0x1A139A0 VA: 0x181A145A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A12980 Offset: 0x1A11D80 VA: 0x181A12980
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A14240 Offset: 0x1A13640 VA: 0x181A14240
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Dispose
	|
	|-RVA: 0x1A13EE0 Offset: 0x1A132E0 VA: 0x181A13EE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Dispose
	|
	|-RVA: 0x1A11DB0 Offset: 0x1A111B0 VA: 0x181A11DB0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A11FF0 Offset: 0x1A113F0 VA: 0x181A11FF0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A13550 Offset: 0x1A12950 VA: 0x181A13550
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Dispose
	|
	|-RVA: 0x1A12350 Offset: 0x1A11750 VA: 0x181A12350
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A13CA0 Offset: 0x1A130A0 VA: 0x181A13CA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A13040 Offset: 0x1A12440 VA: 0x181A13040
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Dispose
	|
	|-RVA: 0x1A127D0 Offset: 0x1A11BD0 VA: 0x181A127D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Dispose
	|
	|-RVA: 0x1A13700 Offset: 0x1A12B00 VA: 0x181A13700
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A11B70 Offset: 0x1A10F70 VA: 0x181A11B70
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Dispose
	|
	|-RVA: 0x1A11A50 Offset: 0x1A10E50 VA: 0x181A11A50
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Dispose
	|
	|-RVA: 0x1A128F0 Offset: 0x1A11CF0 VA: 0x181A128F0
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Dispose
	|
	|-RVA: 0x1A12470 Offset: 0x1A11870 VA: 0x181A12470
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A12C50 Offset: 0x1A12050 VA: 0x181A12C50
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A119C0 Offset: 0x1A10DC0 VA: 0x181A119C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A12B30 Offset: 0x1A11F30 VA: 0x181A12B30
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Dispose
	|
	|-RVA: 0x1A134C0 Offset: 0x1A128C0 VA: 0x181A134C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Dispose
	|
	|-RVA: 0x1A13AF0 Offset: 0x1A12EF0 VA: 0x181A13AF0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A14750 Offset: 0x1A13B50 VA: 0x181A14750
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A12E00 Offset: 0x1A12200 VA: 0x181A12E00
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Dispose
	|
	|-RVA: 0x1A123E0 Offset: 0x1A117E0 VA: 0x181A123E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A11810 Offset: 0x1A10C10 VA: 0x181A11810
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Dispose
	|
	|-RVA: 0x1A133A0 Offset: 0x1A127A0 VA: 0x181A133A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Dispose
	|
	|-RVA: 0x1A13430 Offset: 0x1A12830 VA: 0x181A13430
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Dispose
	|
	|-RVA: 0x1A11C00 Offset: 0x1A11000 VA: 0x181A11C00
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Dispose
	|
	|-RVA: 0x1A14990 Offset: 0x1A13D90 VA: 0x181A14990
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Dispose
	|
	|-RVA: 0x1A143F0 Offset: 0x1A137F0 VA: 0x181A143F0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Dispose
	|
	|-RVA: 0x1A14C60 Offset: 0x1A14060 VA: 0x181A14C60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A11E40 Offset: 0x1A11240 VA: 0x181A11E40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A14510 Offset: 0x1A13910 VA: 0x181A14510
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A14900 Offset: 0x1A13D00 VA: 0x181A14900
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Dispose
	|
	|-RVA: 0x1A14A20 Offset: 0x1A13E20 VA: 0x181A14A20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Dispose
	|
	|-RVA: 0x1A13DC0 Offset: 0x1A131C0 VA: 0x181A13DC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A12500 Offset: 0x1A11900 VA: 0x181A12500
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A11AE0 Offset: 0x1A10EE0 VA: 0x181A11AE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Dispose
	|
	|-RVA: 0x1A142D0 Offset: 0x1A136D0 VA: 0x181A142D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A13D30 Offset: 0x1A13130 VA: 0x181A13D30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Dispose
	|
	|-RVA: 0x1A14870 Offset: 0x1A13C70 VA: 0x181A14870
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Dispose
	|
	|-RVA: 0x1A13A60 Offset: 0x1A12E60 VA: 0x181A13A60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Dispose
	|
	|-RVA: 0x1A118A0 Offset: 0x1A10CA0 VA: 0x181A118A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Dispose
	|
	|-RVA: 0x1A12A10 Offset: 0x1A11E10 VA: 0x181A12A10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Dispose
	|
	|-RVA: 0x1A12D70 Offset: 0x1A12170 VA: 0x181A12D70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Dispose
	|
	|-RVA: 0x1A14AB0 Offset: 0x1A13EB0 VA: 0x181A14AB0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Dispose
	|
	|-RVA: 0x1A13940 Offset: 0x1A12D40 VA: 0x181A13940
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A11930 Offset: 0x1A10D30 VA: 0x181A11930
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A12590 Offset: 0x1A11990 VA: 0x181A12590
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A12080 Offset: 0x1A11480 VA: 0x181A12080
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A14B40 Offset: 0x1A13F40 VA: 0x181A14B40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A138B0 Offset: 0x1A12CB0 VA: 0x181A138B0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Dispose
	|
	|-RVA: 0x1A147E0 Offset: 0x1A13BE0 VA: 0x181A147E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Dispose
	|
	|-RVA: 0x1A12230 Offset: 0x1A11630 VA: 0x181A12230
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A13790 Offset: 0x1A12B90 VA: 0x181A13790
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A122C0 Offset: 0x1A116C0 VA: 0x181A122C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Dispose
	|
	|-RVA: 0x1A14E10 Offset: 0x1A14210 VA: 0x181A14E10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A13F70 Offset: 0x1A13370 VA: 0x181A13F70
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Dispose
	|
	|-RVA: 0x1A13670 Offset: 0x1A12A70 VA: 0x181A13670
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Dispose
	|
	|-RVA: 0x1A121A0 Offset: 0x1A115A0 VA: 0x181A121A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Dispose
	|
	|-RVA: 0x1A135E0 Offset: 0x1A129E0 VA: 0x181A135E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Dispose
	|
	|-RVA: 0x1A12FB0 Offset: 0x1A123B0 VA: 0x181A12FB0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Dispose
	|
	|-RVA: 0x1A13160 Offset: 0x1A12560 VA: 0x181A13160
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Dispose
	|
	|-RVA: 0x1A14CF0 Offset: 0x1A140F0 VA: 0x181A14CF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A126B0 Offset: 0x1A11AB0 VA: 0x181A126B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A14630 Offset: 0x1A13A30 VA: 0x181A14630
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A11ED0 Offset: 0x1A112D0 VA: 0x181A11ED0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A11780 Offset: 0x1A10B80 VA: 0x181A11780
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A14360 Offset: 0x1A13760 VA: 0x181A14360
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Dispose
	|
	|-RVA: 0x1A12620 Offset: 0x1A11A20 VA: 0x181A12620
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A12110 Offset: 0x1A11510 VA: 0x181A12110
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Dispose
	|
	|-RVA: 0x1A130D0 Offset: 0x1A124D0 VA: 0x181A130D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A12740 Offset: 0x1A11B40 VA: 0x181A12740
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A14000 Offset: 0x1A13400 VA: 0x181A14000
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Dispose
	|
	|-RVA: 0x1A14D80 Offset: 0x1A14180 VA: 0x181A14D80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A24F80 Offset: 0x1A24380 VA: 0x181A24F80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Dispose
	|
	|-RVA: 0x1A22B80 Offset: 0x1A21F80 VA: 0x181A22B80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Dispose
	|
	|-RVA: 0x1A22CA0 Offset: 0x1A220A0 VA: 0x181A22CA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Dispose
	|
	|-RVA: 0x1A21FB0 Offset: 0x1A213B0 VA: 0x181A21FB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Dispose
	|
	|-RVA: 0x1A24200 Offset: 0x1A23600 VA: 0x181A24200
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Dispose
	|
	|-RVA: 0x1A22790 Offset: 0x1A21B90 VA: 0x181A22790
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Dispose
	|
	|-RVA: 0x1A23000 Offset: 0x1A22400 VA: 0x181A23000
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Dispose
	|
	|-RVA: 0x1A231B0 Offset: 0x1A225B0 VA: 0x181A231B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A25400 Offset: 0x1A24800 VA: 0x181A25400
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Dispose
	|
	|-RVA: 0x1A23F30 Offset: 0x1A23330 VA: 0x181A23F30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A247A0 Offset: 0x1A23BA0 VA: 0x181A247A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Dispose
	|
	|-RVA: 0x1A223A0 Offset: 0x1A217A0 VA: 0x181A223A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A22AF0 Offset: 0x1A21EF0 VA: 0x181A22AF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A251C0 Offset: 0x1A245C0 VA: 0x181A251C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A25010 Offset: 0x1A24410 VA: 0x181A25010
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A24B00 Offset: 0x1A23F00 VA: 0x181A24B00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Dispose
	|
	|-RVA: 0x1A243B0 Offset: 0x1A237B0 VA: 0x181A243B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Dispose
	|
	|-RVA: 0x1A245F0 Offset: 0x1A239F0 VA: 0x181A245F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A229D0 Offset: 0x1A21DD0 VA: 0x181A229D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A22160 Offset: 0x1A21560 VA: 0x181A22160
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Dispose
	|
	|-RVA: 0x1A22940 Offset: 0x1A21D40 VA: 0x181A22940
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A24710 Offset: 0x1A23B10 VA: 0x181A24710
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A23C60 Offset: 0x1A23060 VA: 0x181A23C60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Dispose
	|
	|-RVA: 0x1A250A0 Offset: 0x1A244A0 VA: 0x181A250A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Dispose
	|
	|-RVA: 0x1A23B40 Offset: 0x1A22F40 VA: 0x181A23B40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Dispose
	|
	|-RVA: 0x1A24B90 Offset: 0x1A23F90 VA: 0x181A24B90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Dispose
	|
	|-RVA: 0x1A225E0 Offset: 0x1A219E0 VA: 0x181A225E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Dispose
	|
	|-RVA: 0x1A240E0 Offset: 0x1A234E0 VA: 0x181A240E0
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1A228B0 Offset: 0x1A21CB0 VA: 0x181A228B0
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Dispose
	|
	|-RVA: 0x1A21D70 Offset: 0x1A21170 VA: 0x181A21D70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A23A20 Offset: 0x1A22E20 VA: 0x181A23A20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A21F20 Offset: 0x1A21320 VA: 0x181A21F20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A224C0 Offset: 0x1A218C0 VA: 0x181A224C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Dispose
	|
	|-RVA: 0x1A23E10 Offset: 0x1A23210 VA: 0x181A23E10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A235A0 Offset: 0x1A229A0 VA: 0x181A235A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A23EA0 Offset: 0x1A232A0 VA: 0x181A23EA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A23240 Offset: 0x1A22640 VA: 0x181A23240
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Dispose
	|
	|-RVA: 0x1A24560 Offset: 0x1A23960 VA: 0x181A24560
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A25370 Offset: 0x1A24770 VA: 0x181A25370
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x1A22DC0 Offset: 0x1A221C0 VA: 0x181A22DC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A21E90 Offset: 0x1A21290 VA: 0x181A21E90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Dispose
	|
	|-RVA: 0x1A22550 Offset: 0x1A21950 VA: 0x181A22550
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x1A24C20 Offset: 0x1A24020 VA: 0x181A24C20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x1A22430 Offset: 0x1A21830 VA: 0x181A22430
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A22EE0 Offset: 0x1A222E0 VA: 0x181A22EE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A249E0 Offset: 0x1A23DE0 VA: 0x181A249E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A22280 Offset: 0x1A21680 VA: 0x181A22280
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A24DD0 Offset: 0x1A241D0 VA: 0x181A24DD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Dispose
	|
	|-RVA: 0x1A252E0 Offset: 0x1A246E0 VA: 0x181A252E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A23CF0 Offset: 0x1A230F0 VA: 0x181A23CF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A24E60 Offset: 0x1A24260 VA: 0x181A24E60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A24320 Offset: 0x1A23720 VA: 0x181A24320
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Dispose
	|
	|-RVA: 0x1A22E50 Offset: 0x1A22250 VA: 0x181A22E50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A221F0 Offset: 0x1A215F0 VA: 0x181A221F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Dispose
	|
	|-RVA: 0x1A23FC0 Offset: 0x1A233C0 VA: 0x181A23FC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A22700 Offset: 0x1A21B00 VA: 0x181A22700
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Dispose
	|
	|-RVA: 0x1A24CB0 Offset: 0x1A240B0 VA: 0x181A24CB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Dispose
	|
	|-RVA: 0x1A22670 Offset: 0x1A21A70 VA: 0x181A22670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Dispose
	|
	|-RVA: 0x1A22820 Offset: 0x1A21C20 VA: 0x181A22820
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Dispose
	|
	|-RVA: 0x1A237E0 Offset: 0x1A22BE0 VA: 0x181A237E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A24A70 Offset: 0x1A23E70 VA: 0x181A24A70
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A244D0 Offset: 0x1A238D0 VA: 0x181A244D0
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A23AB0 Offset: 0x1A22EB0 VA: 0x181A23AB0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x1A23BD0 Offset: 0x1A22FD0 VA: 0x181A23BD0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A25250 Offset: 0x1A24650 VA: 0x181A25250
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A236C0 Offset: 0x1A22AC0 VA: 0x181A236C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A23630 Offset: 0x1A22A30 VA: 0x181A23630
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Dispose
	|
	|-RVA: 0x1A23900 Offset: 0x1A22D00 VA: 0x181A23900
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Dispose
	|
	|-RVA: 0x1A23990 Offset: 0x1A22D90 VA: 0x181A23990
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A23120 Offset: 0x1A22520 VA: 0x181A23120
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A22F70 Offset: 0x1A22370 VA: 0x181A22F70
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x1A24440 Offset: 0x1A23840 VA: 0x181A24440
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A24EF0 Offset: 0x1A242F0 VA: 0x181A24EF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x1A24680 Offset: 0x1A23A80 VA: 0x181A24680
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x1A24D40 Offset: 0x1A24140 VA: 0x181A24D40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x1A233F0 Offset: 0x1A227F0 VA: 0x181A233F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x1A23750 Offset: 0x1A22B50 VA: 0x181A23750
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x1A220D0 Offset: 0x1A214D0 VA: 0x181A220D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Dispose
	|
	|-RVA: 0x1A23870 Offset: 0x1A22C70 VA: 0x181A23870
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A23480 Offset: 0x1A22880 VA: 0x181A23480
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A24050 Offset: 0x1A23450 VA: 0x181A24050
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A22A60 Offset: 0x1A21E60 VA: 0x181A22A60
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A22040 Offset: 0x1A21440 VA: 0x181A22040
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A21CE0 Offset: 0x1A210E0 VA: 0x181A21CE0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A25130 Offset: 0x1A24530 VA: 0x181A25130
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A21E00 Offset: 0x1A21200 VA: 0x181A21E00
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Dispose
	|
	|-RVA: 0x1A23510 Offset: 0x1A22910 VA: 0x181A23510
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A22310 Offset: 0x1A21710 VA: 0x181A22310
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Dispose
	|
	|-RVA: 0x1A22C10 Offset: 0x1A22010 VA: 0x181A22C10
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A22D30 Offset: 0x1A22130 VA: 0x181A22D30
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A248C0 Offset: 0x1A23CC0 VA: 0x181A248C0
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x1A23D80 Offset: 0x1A23180 VA: 0x181A23D80
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A232D0 Offset: 0x1A226D0 VA: 0x181A232D0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x1A24170 Offset: 0x1A23570 VA: 0x181A24170
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x1A23360 Offset: 0x1A22760 VA: 0x181A23360
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x1A23090 Offset: 0x1A22490 VA: 0x181A23090
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1A24830 Offset: 0x1A23C30 VA: 0x181A24830
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x1A24950 Offset: 0x1A23D50 VA: 0x181A24950
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0x1A24290 Offset: 0x1A23690 VA: 0x181A24290
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE410 Offset: 0x19CD810 VA: 0x1819CE410
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|
	|-RVA: 0x19CECE0 Offset: 0x19CE0E0 VA: 0x1819CECE0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19CF0C0 Offset: 0x19CE4C0 VA: 0x1819CF0C0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.MoveNext
	|
	|-RVA: 0x19CF240 Offset: 0x19CE640 VA: 0x1819CF240
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19CDF30 Offset: 0x19CD330 VA: 0x1819CDF30
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19CEA70 Offset: 0x19CDE70 VA: 0x1819CEA70
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19CF980 Offset: 0x19CED80 VA: 0x1819CF980
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x19CE590 Offset: 0x19CD990 VA: 0x1819CE590
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x19CE190 Offset: 0x19CD590 VA: 0x1819CE190
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19CDCB0 Offset: 0x19CD0B0 VA: 0x1819CDCB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19CF4B0 Offset: 0x19CE8B0 VA: 0x1819CF4B0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x19CF710 Offset: 0x19CEB10 VA: 0x1819CF710
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19CEE60 Offset: 0x19CE260 VA: 0x1819CEE60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.MoveNext
	|
	|-RVA: 0x19CFC00 Offset: 0x19CF000 VA: 0x1819CFC00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x19CE810 Offset: 0x19CDC10 VA: 0x1819CE810
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x19CFE60 Offset: 0x19CF260 VA: 0x1819CFE60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x1A1FFF0 Offset: 0x1A1F3F0 VA: 0x181A1FFF0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x1A176F0 Offset: 0x1A16AF0 VA: 0x181A176F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1A1A210 Offset: 0x1A19610 VA: 0x181A1A210
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.MoveNext
	|
	|-RVA: 0x1A20980 Offset: 0x1A1FD80 VA: 0x181A20980
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1D900 Offset: 0x1A1CD00 VA: 0x181A1D900
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A169F0 Offset: 0x1A15DF0 VA: 0x181A169F0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1C540 Offset: 0x1A1B940 VA: 0x181A1C540
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.MoveNext
	|
	|-RVA: 0x1A19C40 Offset: 0x1A19040 VA: 0x181A19C40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1E550 Offset: 0x1A1D950 VA: 0x181A1E550
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1F940 Offset: 0x1A1ED40 VA: 0x181A1F940
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1C330 Offset: 0x1A1B730 VA: 0x181A1C330
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.MoveNext
	|
	|-RVA: 0x1A1EEF0 Offset: 0x1A1E2F0 VA: 0x181A1EEF0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1A000 Offset: 0x1A19400 VA: 0x181A1A000
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.MoveNext
	|
	|-RVA: 0x1A1A420 Offset: 0x1A19820 VA: 0x181A1A420
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1CE70 Offset: 0x1A1C270 VA: 0x181A1CE70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.MoveNext
	|
	|-RVA: 0x1A174D0 Offset: 0x1A168D0 VA: 0x181A174D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.MoveNext
	|
	|-RVA: 0x1A1FDE0 Offset: 0x1A1F1E0 VA: 0x181A1FDE0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.MoveNext
	|
	|-RVA: 0x1A1B0E0 Offset: 0x1A1A4E0 VA: 0x181A1B0E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.MoveNext
	|
	|-RVA: 0x1A1E0B0 Offset: 0x1A1D4B0 VA: 0x181A1E0B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F7C0 Offset: 0x1A1EBC0 VA: 0x181A1F7C0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1AA90 Offset: 0x1A19E90 VA: 0x181A1AA90
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A15F70 Offset: 0x1A15370 VA: 0x181A15F70
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1A1DB10 Offset: 0x1A1CF10 VA: 0x181A1DB10
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x1A155A0 Offset: 0x1A149A0 VA: 0x181A155A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A16470 Offset: 0x1A15870 VA: 0x181A16470
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A21750 Offset: 0x1A20B50 VA: 0x181A21750
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A21250 Offset: 0x1A20650 VA: 0x181A21250
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A21A10 Offset: 0x1A20E10 VA: 0x181A21A10
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1BA80 Offset: 0x1A1AE80 VA: 0x181A1BA80
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1A19140 Offset: 0x1A18540 VA: 0x181A19140
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1A7B0 Offset: 0x1A19BB0 VA: 0x181A1A7B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A16190 Offset: 0x1A15590 VA: 0x181A16190
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A16730 Offset: 0x1A15B30 VA: 0x181A16730
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x1A17C80 Offset: 0x1A17080 VA: 0x181A17C80
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A18960 Offset: 0x1A17D60 VA: 0x181A18960
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A20D30 Offset: 0x1A20130 VA: 0x181A20D30
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1F2C0 Offset: 0x1A1E6C0 VA: 0x181A1F2C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x1A1BEE0 Offset: 0x1A1B2E0 VA: 0x181A1BEE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A1B640 Offset: 0x1A1AA40 VA: 0x181A1B640
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1A1E790 Offset: 0x1A1DB90 VA: 0x181A1E790
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x1A1C900 Offset: 0x1A1BD00 VA: 0x181A1C900
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1A1DD70 Offset: 0x1A1D170 VA: 0x181A1DD70
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1D220 Offset: 0x1A1C620 VA: 0x181A1D220
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1C770 Offset: 0x1A1BB70 VA: 0x181A1C770
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1B300 Offset: 0x1A1A700 VA: 0x181A1B300
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1A1AC10 Offset: 0x1A1A010 VA: 0x181A1AC10
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1D080 Offset: 0x1A1C480 VA: 0x181A1D080
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A180D0 Offset: 0x1A174D0 VA: 0x181A180D0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A20800 Offset: 0x1A1FC00 VA: 0x181A20800
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1A17AE0 Offset: 0x1A16EE0 VA: 0x181A17AE0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1ED70 Offset: 0x1A1E170 VA: 0x181A1ED70
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.MoveNext
	|
	|-RVA: 0x1A17960 Offset: 0x1A16D60 VA: 0x181A17960
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1D780 Offset: 0x1A1CB80 VA: 0x181A1D780
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1A1AF50 Offset: 0x1A1A350 VA: 0x181A1AF50
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1A15410 Offset: 0x1A14810 VA: 0x181A15410
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1A1CB40 Offset: 0x1A1BF40 VA: 0x181A1CB40
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1A17000 Offset: 0x1A16400 VA: 0x181A17000
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1A630 Offset: 0x1A19A30 VA: 0x181A1A630
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A18270 Offset: 0x1A17670 VA: 0x181A18270
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1F120 Offset: 0x1A1E520 VA: 0x181A1F120
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x1A17190 Offset: 0x1A16590 VA: 0x181A17190
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A20270 Offset: 0x1A1F670 VA: 0x181A20270
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A17330 Offset: 0x1A16730 VA: 0x181A17330
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A19AC0 Offset: 0x1A18EC0 VA: 0x181A19AC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1A19420 Offset: 0x1A18820 VA: 0x181A19420
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A18400 Offset: 0x1A17800 VA: 0x181A18400
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.MoveNext
	|
	|-RVA: 0x1A15290 Offset: 0x1A14690 VA: 0x181A15290
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1BD60 Offset: 0x1A1B160 VA: 0x181A1BD60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1A20410 Offset: 0x1A1F810 VA: 0x181A20410
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1A1B900 Offset: 0x1A1AD00 VA: 0x181A1B900
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x1A1E230 Offset: 0x1A1D630 VA: 0x181A1E230
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1A15C40 Offset: 0x1A15040 VA: 0x181A15C40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1A195B0 Offset: 0x1A189B0 VA: 0x181A195B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A18C20 Offset: 0x1A18020 VA: 0x181A18C20
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A1B4A0 Offset: 0x1A1A8A0 VA: 0x181A1B4A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A20BB0 Offset: 0x1A1FFB0 VA: 0x181A20BB0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A15870 Offset: 0x1A14C70 VA: 0x181A15870
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1DF10 Offset: 0x1A1D310 VA: 0x181A1DF10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1A1ADB0 Offset: 0x1A1A1B0 VA: 0x181A1ADB0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A16C10 Offset: 0x1A16010 VA: 0x181A16C10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A187C0 Offset: 0x1A17BC0 VA: 0x181A187C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1EBF0 Offset: 0x1A1DFF0 VA: 0x181A1EBF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1A1CCD0 Offset: 0x1A1C0D0 VA: 0x181A1CCD0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D3A0 Offset: 0x1A1C7A0 VA: 0x181A1D3A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.MoveNext
	|
	|-RVA: 0x1A1C1B0 Offset: 0x1A1B5B0 VA: 0x181A1C1B0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A17F50 Offset: 0x1A17350 VA: 0x181A17F50
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1A19E70 Offset: 0x1A19270 VA: 0x181A19E70
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1A1EA60 Offset: 0x1A1DE60 VA: 0x181A1EA60
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x1A1E3C0 Offset: 0x1A1D7C0 VA: 0x181A1E3C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1A18EF0 Offset: 0x1A182F0 VA: 0x181A18EF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A15A00 Offset: 0x1A14E00 VA: 0x181A15A00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A18580 Offset: 0x1A17980 VA: 0x181A18580
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F580 Offset: 0x1A1E980 VA: 0x181A1F580
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A16DB0 Offset: 0x1A161B0 VA: 0x181A16DB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A20FF0 Offset: 0x1A203F0 VA: 0x181A20FF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1A15050 Offset: 0x1A14450 VA: 0x181A15050
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A1D520 Offset: 0x1A1C920 VA: 0x181A1D520
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A205A0 Offset: 0x1A1F9A0 VA: 0x181A205A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1FB80 Offset: 0x1A1EF80 VA: 0x181A1FB80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A21510 Offset: 0x1A20910 VA: 0x181A21510
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x1A19870 Offset: 0x1A18C70 VA: 0x181A19870
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A279B0 Offset: 0x1A26DB0 VA: 0x181A279B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.MoveNext
	|
	|-RVA: 0x1A2D600 Offset: 0x1A2CA00 VA: 0x181A2D600
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A26C10 Offset: 0x1A26010 VA: 0x181A26C10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x1A269C0 Offset: 0x1A25DC0 VA: 0x181A269C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1A2DA60 Offset: 0x1A2CE60 VA: 0x181A2DA60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1A26000 Offset: 0x1A25400 VA: 0x181A26000
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1A2FFF0 Offset: 0x1A2F3F0 VA: 0x181A2FFF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1A29690 Offset: 0x1A28A90 VA: 0x181A29690
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2E980 Offset: 0x1A2DD80 VA: 0x181A2E980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1A2BE20 Offset: 0x1A2B220 VA: 0x181A2BE20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A25AB0 Offset: 0x1A24EB0 VA: 0x181A25AB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1A30490 Offset: 0x1A2F890 VA: 0x181A30490
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A292C0 Offset: 0x1A286C0 VA: 0x181A292C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A30C00 Offset: 0x1A30000 VA: 0x181A30C00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A30E30 Offset: 0x1A30230 VA: 0x181A30E30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2B9C0 Offset: 0x1A2ADC0 VA: 0x181A2B9C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1A2EBE0 Offset: 0x1A2DFE0 VA: 0x181A2EBE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A30240 Offset: 0x1A2F640 VA: 0x181A30240
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A312B0 Offset: 0x1A306B0 VA: 0x181A312B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2CDF0 Offset: 0x1A2C1F0 VA: 0x181A2CDF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1A2E200 Offset: 0x1A2D600 VA: 0x181A2E200
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2E440 Offset: 0x1A2D840 VA: 0x181A2E440
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A2F7F0 Offset: 0x1A2EBF0 VA: 0x181A2F7F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2D020 Offset: 0x1A2C420 VA: 0x181A2D020
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1A2EE30 Offset: 0x1A2E230 VA: 0x181A2EE30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1A2F380 Offset: 0x1A2E780 VA: 0x181A2F380
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1A2B110 Offset: 0x1A2A510 VA: 0x181A2B110
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1A27E20 Offset: 0x1A27220 VA: 0x181A27E20
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1A306D0 Offset: 0x1A2FAD0 VA: 0x181A306D0
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.MoveNext
	|
	|-RVA: 0x1A2FDC0 Offset: 0x1A2F1C0 VA: 0x181A2FDC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A28D80 Offset: 0x1A28180 VA: 0x181A28D80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A29A70 Offset: 0x1A28E70 VA: 0x181A29A70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A27BF0 Offset: 0x1A26FF0 VA: 0x181A27BF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x1A2D250 Offset: 0x1A2C650 VA: 0x181A2D250
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A25630 Offset: 0x1A24A30 VA: 0x181A25630
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A31070 Offset: 0x1A30470 VA: 0x181A31070
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2A2F0 Offset: 0x1A296F0 VA: 0x181A2A2F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x1A2B790 Offset: 0x1A2AB90 VA: 0x181A2B790
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A271E0 Offset: 0x1A265E0 VA: 0x181A271E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x1A2C4F0 Offset: 0x1A2B8F0 VA: 0x181A2C4F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A26E50 Offset: 0x1A26250 VA: 0x181A26E50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x1A2C700 Offset: 0x1A2BB00 VA: 0x181A2C700
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1A2DCB0 Offset: 0x1A2D0B0 VA: 0x181A2DCB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x1A267A0 Offset: 0x1A25BA0 VA: 0x181A267A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2B350 Offset: 0x1A2A750 VA: 0x181A2B350
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A277A0 Offset: 0x1A26BA0 VA: 0x181A277A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2FA20 Offset: 0x1A2EE20 VA: 0x181A2FA20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2A820 Offset: 0x1A29C20 VA: 0x181A2A820
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1A273F0 Offset: 0x1A267F0 VA: 0x181A273F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A25870 Offset: 0x1A24C70 VA: 0x181A25870
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A263E0 Offset: 0x1A257E0 VA: 0x181A263E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2BC10 Offset: 0x1A2B010 VA: 0x181A2BC10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x1A289C0 Offset: 0x1A27DC0 VA: 0x181A289C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A281F0 Offset: 0x1A275F0 VA: 0x181A281F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.MoveNext
	|
	|-RVA: 0x1A2B580 Offset: 0x1A2A980 VA: 0x181A2B580
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A28610 Offset: 0x1A27A10 VA: 0x181A28610
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1A2F5D0 Offset: 0x1A2E9D0 VA: 0x181A2F5D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1A2ABF0 Offset: 0x1A29FF0 VA: 0x181A2ABF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x1A28400 Offset: 0x1A27800 VA: 0x181A28400
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1A2D840 Offset: 0x1A2CC40 VA: 0x181A2D840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A25E80 Offset: 0x1A25280 VA: 0x181A25E80
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A2E670 Offset: 0x1A2DA70 VA: 0x181A2E670
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A2C370 Offset: 0x1A2B770 VA: 0x181A2C370
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x1A2A680 Offset: 0x1A29A80 VA: 0x181A2A680
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A27620 Offset: 0x1A26A20 VA: 0x181A27620
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2E7F0 Offset: 0x1A2DBF0 VA: 0x181A2E7F0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A29FB0 Offset: 0x1A293B0 VA: 0x181A29FB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1A2E060 Offset: 0x1A2D460 VA: 0x181A2E060
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A28050 Offset: 0x1A27450 VA: 0x181A28050
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A29E10 Offset: 0x1A29210 VA: 0x181A29E10
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2F070 Offset: 0x1A2E470 VA: 0x181A2F070
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1A2CC50 Offset: 0x1A2C050 VA: 0x181A2CC50
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2A500 Offset: 0x1A29900 VA: 0x181A2A500
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x1A27060 Offset: 0x1A26460 VA: 0x181A27060
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A26620 Offset: 0x1A25A20 VA: 0x181A26620
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1A28BF0 Offset: 0x1A27FF0 VA: 0x181A28BF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1A30A80 Offset: 0x1A2FE80 VA: 0x181A30A80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1A2C920 Offset: 0x1A2BD20 VA: 0x181A2C920
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1A25490 Offset: 0x1A24890 VA: 0x181A25490
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A298F0 Offset: 0x1A28CF0 VA: 0x181A298F0
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A2C060 Offset: 0x1A2B460 VA: 0x181A2C060
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A28F90 Offset: 0x1A28390 VA: 0x181A28F90
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2AF80 Offset: 0x1A2A380 VA: 0x181A2AF80
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A29120 Offset: 0x1A28520 VA: 0x181A29120
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A26240 Offset: 0x1A25640 VA: 0x181A26240
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2CAB0 Offset: 0x1A2BEB0 VA: 0x181A2CAB0
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1A2F1F0 Offset: 0x1A2E5F0 VA: 0x181A2F1F0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2AA50 Offset: 0x1A29E50 VA: 0x181A2AA50
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2DEC0 Offset: 0x1A2D2C0 VA: 0x181A2DEC0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A294F0 Offset: 0x1A288F0 VA: 0x181A294F0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A29C90 Offset: 0x1A29090 VA: 0x181A29C90
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1A2A150 Offset: 0x1A29550 VA: 0x181A2A150
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2D480 Offset: 0x1A2C880 VA: 0x181A2D480
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x1A2FC40 Offset: 0x1A2F040 VA: 0x181A2FC40
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2C1E0 Offset: 0x1A2B5E0 VA: 0x181A2C1E0
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x1A25CF0 Offset: 0x1A250F0 VA: 0x181A25CF0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1A308F0 Offset: 0x1A2FCF0 VA: 0x181A308F0
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x1A2AE00 Offset: 0x1A2A200 VA: 0x181A2AE00
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1A28820 Offset: 0x1A27C20 VA: 0x181A28820
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BDF0 Offset: 0xC6B1F0 VA: 0x180C6BDF0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC6BF30 Offset: 0xC6B330 VA: 0x180C6BF30
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6C070 Offset: 0xC6B470 VA: 0x180C6C070
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BFD0 Offset: 0xC6B3D0 VA: 0x180C6BFD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC6BE90 Offset: 0xC6B290 VA: 0x180C6BE90
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D00D0 Offset: 0x19CF4D0 VA: 0x1819D00D0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Where
	*/

}

private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3204
{	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A5CC0 Offset: 0x16A50C0 VA: 0x1816A5CC0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, uint>..ctor
	|
	|-RVA: 0x16A5D50 Offset: 0x16A5150 VA: 0x1816A5D50
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A5E70 Offset: 0x16A5270 VA: 0x1816A5E70
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A5DE0 Offset: 0x16A51E0 VA: 0x1816A5DE0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A5F00 Offset: 0x16A5300 VA: 0x1816A5F00
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0BA0 Offset: 0x169FFA0 VA: 0x1816A0BA0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Clone
	|
	|-RVA: 0x16A0A60 Offset: 0x169FE60 VA: 0x1816A0A60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A0B00 Offset: 0x169FF00 VA: 0x1816A0B00
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A0C40 Offset: 0x16A0040 VA: 0x1816A0C40
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A0CE0 Offset: 0x16A00E0 VA: 0x1816A0CE0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A11C0 Offset: 0x16A05C0 VA: 0x1816A11C0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x16A1B50 Offset: 0x16A0F50 VA: 0x1816A1B50
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A12A0 Offset: 0x16A06A0 VA: 0x1816A12A0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4D30 Offset: 0x16A4130 VA: 0x1816A4D30
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x16A5AF0 Offset: 0x16A4EF0 VA: 0x1816A5AF0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x16A3F40 Offset: 0x16A3340 VA: 0x1816A3F40
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x16A2A00 Offset: 0x16A1E00 VA: 0x1816A2A00
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A41B0 Offset: 0x16A35B0 VA: 0x1816A41B0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A27A0 Offset: 0x16A1BA0 VA: 0x1816A27A0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4A10 Offset: 0x16A3E10 VA: 0x1816A4A10
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x16A13F0 Offset: 0x16A07F0 VA: 0x1816A13F0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x16A3900 Offset: 0x16A2D00 VA: 0x1816A3900
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x16A5880 Offset: 0x16A4C80 VA: 0x1816A5880
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x16A1E50 Offset: 0x16A1250 VA: 0x1816A1E50
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x16A4560 Offset: 0x16A3960 VA: 0x1816A4560
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A0D80 Offset: 0x16A0180 VA: 0x1816A0D80
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x16A5180 Offset: 0x16A4580 VA: 0x1816A5180
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x16A5760 Offset: 0x16A4B60 VA: 0x1816A5760
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x16A35F0 Offset: 0x16A29F0 VA: 0x1816A35F0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A5640 Offset: 0x16A4A40 VA: 0x1816A5640
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A3D20 Offset: 0x16A3120 VA: 0x1816A3D20
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A5080 Offset: 0x16A4480 VA: 0x1816A5080
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x16A30A0 Offset: 0x16A24A0 VA: 0x1816A30A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x16A3C10 Offset: 0x16A3010 VA: 0x1816A3C10
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x16A4E70 Offset: 0x16A4270 VA: 0x1816A4E70
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x16A59B0 Offset: 0x16A4DB0 VA: 0x1816A59B0
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x16A2130 Offset: 0x16A1530 VA: 0x1816A2130
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A1630 Offset: 0x16A0A30 VA: 0x1816A1630
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x16A31A0 Offset: 0x16A25A0 VA: 0x1816A31A0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x16A33C0 Offset: 0x16A27C0 VA: 0x1816A33C0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x16A4320 Offset: 0x16A3720 VA: 0x1816A4320
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x16A2E60 Offset: 0x16A2260 VA: 0x1816A2E60
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A0E80 Offset: 0x16A0280 VA: 0x1816A0E80
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A2470 Offset: 0x16A1870 VA: 0x1816A2470
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A1940 Offset: 0x16A0D40 VA: 0x1816A1940
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x16A1C30 Offset: 0x16A1030 VA: 0x1816A1C30
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x16A1F50 Offset: 0x16A1350 VA: 0x1816A1F50
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x16A2C50 Offset: 0x16A2050 VA: 0x1816A2C50
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x16A26B0 Offset: 0x16A1AB0 VA: 0x1816A26B0
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A3B30 Offset: 0x16A2F30 VA: 0x1816A3B30
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x16A4C40 Offset: 0x16A4040 VA: 0x1816A4C40
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x16A4670 Offset: 0x16A3A70 VA: 0x1816A4670
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x16A3710 Offset: 0x16A2B10 VA: 0x1816A3710
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A40B0 Offset: 0x16A34B0 VA: 0x1816A40B0
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A1840 Offset: 0x16A0C40 VA: 0x1816A1840
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4B50 Offset: 0x16A3F50 VA: 0x1816A4B50
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x16A3A50 Offset: 0x16A2E50 VA: 0x1816A3A50
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x16A2D70 Offset: 0x16A2170 VA: 0x1816A2D70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4930 Offset: 0x16A3D30 VA: 0x1816A4930
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x16A3810 Offset: 0x16A2C10 VA: 0x1816A3810
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x16A3E40 Offset: 0x16A3240 VA: 0x1816A3E40
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x16A10C0 Offset: 0x16A04C0 VA: 0x1816A10C0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A4F80 Offset: 0x16A4380 VA: 0x1816A4F80
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A1530 Offset: 0x16A0930 VA: 0x1816A1530
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A2B70 Offset: 0x16A1F70 VA: 0x1816A2B70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x16A4850 Offset: 0x16A3C50 VA: 0x1816A4850
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A2910 Offset: 0x16A1D10 VA: 0x1816A2910
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x16A4770 Offset: 0x16A3B70 VA: 0x1816A4770
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x16A53C0 Offset: 0x16A47C0 VA: 0x1816A53C0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x16A5290 Offset: 0x16A4690 VA: 0x1816A5290
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A2360 Offset: 0x16A1760 VA: 0x1816A2360
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x19CAD30 Offset: 0x19CA130 VA: 0x1819CAD30
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x19CBCE0 Offset: 0x19CB0E0 VA: 0x1819CBCE0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x19CCE40 Offset: 0x19CC240 VA: 0x1819CCE40
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19CB800 Offset: 0x19CAC00 VA: 0x1819CB800
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19CCD30 Offset: 0x19CC130 VA: 0x1819CCD30
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x19CD290 Offset: 0x19CC690 VA: 0x1819CD290
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x19CD080 Offset: 0x19CC480 VA: 0x1819CD080
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x19CB6D0 Offset: 0x19CAAD0 VA: 0x1819CB6D0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19CAB10 Offset: 0x19C9F10 VA: 0x1819CAB10
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x19CB1A0 Offset: 0x19CA5A0 VA: 0x1819CB1A0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x19CAE60 Offset: 0x19CA260 VA: 0x1819CAE60
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x19CC750 Offset: 0x19CBB50 VA: 0x1819CC750
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x19CB2C0 Offset: 0x19CA6C0 VA: 0x1819CB2C0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x19CC350 Offset: 0x19CB750 VA: 0x1819CC350
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19CBE20 Offset: 0x19CB220 VA: 0x1819CBE20
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19CB080 Offset: 0x19CA480 VA: 0x1819CB080
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x19CB3F0 Offset: 0x19CA7F0 VA: 0x1819CB3F0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x19CC050 Offset: 0x19CB450 VA: 0x1819CC050
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x19CC480 Offset: 0x19CB880 VA: 0x1819CC480
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x19CAA30 Offset: 0x19C9E30 VA: 0x1819CAA30
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x19CBA20 Offset: 0x19CAE20 VA: 0x1819CBA20
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19CBC00 Offset: 0x19CB000 VA: 0x1819CBC00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x19CC160 Offset: 0x19CB560 VA: 0x1819CC160
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x19CD190 Offset: 0x19CC590 VA: 0x1819CD190
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x19CCF80 Offset: 0x19CC380 VA: 0x1819CCF80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x19CC250 Offset: 0x19CB650 VA: 0x1819CC250
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19CBF50 Offset: 0x19CB350 VA: 0x1819CBF50
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19CBB10 Offset: 0x19CAF10 VA: 0x1819CBB10
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x19CB510 Offset: 0x19CA910 VA: 0x1819CB510
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x19CAF90 Offset: 0x19CA390 VA: 0x1819CAF90
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19CB940 Offset: 0x19CAD40 VA: 0x1819CB940
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x19CB5F0 Offset: 0x19CA9F0 VA: 0x1819CB5F0
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x19CC880 Offset: 0x19CBC80 VA: 0x1819CC880
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x19CCA50 Offset: 0x19CBE50 VA: 0x1819CCA50
	|-Enumerable.WhereSelectArrayIterator<object, Option>.MoveNext
	|
	|-RVA: 0x19CCC30 Offset: 0x19CC030 VA: 0x1819CCC30
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x19CC560 Offset: 0x19CB960 VA: 0x1819CC560
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19CAC30 Offset: 0x19CA030 VA: 0x1819CAC30
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19CCB50 Offset: 0x19CBF50 VA: 0x1819CCB50
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0x19CC660 Offset: 0x19CBA60 VA: 0x1819CC660
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x19CC970 Offset: 0x19CBD70 VA: 0x1819CC970
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BDF0 Offset: 0xC6B1F0 VA: 0x180C6BDF0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC6BF30 Offset: 0xC6B330 VA: 0x180C6BF30
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6C070 Offset: 0xC6B470 VA: 0x180C6C070
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BFD0 Offset: 0xC6B3D0 VA: 0x180C6BFD0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC6BE90 Offset: 0xC6B290 VA: 0x180C6BE90
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A5C40 Offset: 0x16A5040 VA: 0x1816A5C40
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<object, long>.Where
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|-Enumerable.WhereSelectArrayIterator<object, float>.Where
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.Where
	*/

}

private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3205
{	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A5CC0 Offset: 0x16A50C0 VA: 0x1816A5CC0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<object, bool>..ctor
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<object, long>..ctor
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|-Enumerable.WhereSelectListIterator<object, float>..ctor
	|-Enumerable.WhereSelectListIterator<object, uint>..ctor
	|
	|-RVA: 0x16A5D50 Offset: 0x16A5150 VA: 0x1816A5D50
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A5E70 Offset: 0x16A5270 VA: 0x1816A5E70
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<object, Option>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A5DE0 Offset: 0x16A51E0 VA: 0x1816A5DE0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A5F00 Offset: 0x16A5300 VA: 0x1816A5F00
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0BA0 Offset: 0x169FFA0 VA: 0x1816A0BA0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<object, bool>.Clone
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<object, long>.Clone
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|-Enumerable.WhereSelectListIterator<object, float>.Clone
	|-Enumerable.WhereSelectListIterator<object, uint>.Clone
	|
	|-RVA: 0x16A0A60 Offset: 0x169FE60 VA: 0x1816A0A60
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A0B00 Offset: 0x169FF00 VA: 0x1816A0B00
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<object, Option>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A0C40 Offset: 0x16A0040 VA: 0x1816A0C40
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A0CE0 Offset: 0x16A00E0 VA: 0x1816A0CE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176ABD0 Offset: 0x1769FD0 VA: 0x18176ABD0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x176D1D0 Offset: 0x176C5D0 VA: 0x18176D1D0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1769080 Offset: 0x1768480 VA: 0x181769080
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176B890 Offset: 0x176AC90 VA: 0x18176B890
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x1769340 Offset: 0x1768740 VA: 0x181769340
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x176FC80 Offset: 0x176F080 VA: 0x18176FC80
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x176A230 Offset: 0x1769630 VA: 0x18176A230
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x17700C0 Offset: 0x176F4C0 VA: 0x1817700C0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176E020 Offset: 0x176D420 VA: 0x18176E020
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176D870 Offset: 0x176CC70 VA: 0x18176D870
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x176E910 Offset: 0x176DD10 VA: 0x18176E910
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x17707B0 Offset: 0x176FBB0 VA: 0x1817707B0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x176BE10 Offset: 0x176B210 VA: 0x18176BE10
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x176BCE0 Offset: 0x176B0E0 VA: 0x18176BCE0
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x176B240 Offset: 0x176A640 VA: 0x18176B240
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1769C60 Offset: 0x1769060 VA: 0x181769C60
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x176ACF0 Offset: 0x176A0F0 VA: 0x18176ACF0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x176F360 Offset: 0x176E760 VA: 0x18176F360
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x176A7D0 Offset: 0x1769BD0 VA: 0x18176A7D0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x176B0F0 Offset: 0x176A4F0 VA: 0x18176B0F0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176DD90 Offset: 0x176D190 VA: 0x18176DD90
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176CE50 Offset: 0x176C250 VA: 0x18176CE50
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x176A100 Offset: 0x1769500 VA: 0x18176A100
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x176EBE0 Offset: 0x176DFE0 VA: 0x18176EBE0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x176CD20 Offset: 0x176C120 VA: 0x18176CD20
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x176CA90 Offset: 0x176BE90 VA: 0x18176CA90
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x176D0B0 Offset: 0x176C4B0 VA: 0x18176D0B0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x176DEE0 Offset: 0x176D2E0 VA: 0x18176DEE0
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1770640 Offset: 0x176FA40 VA: 0x181770640
	|-Enumerable.WhereSelectListIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x176A920 Offset: 0x1769D20 VA: 0x18176A920
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1768DE0 Offset: 0x17681E0 VA: 0x181768DE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x176C7F0 Offset: 0x176BBF0 VA: 0x18176C7F0
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x176B4A0 Offset: 0x176A8A0 VA: 0x18176B4A0
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x176AE30 Offset: 0x176A230 VA: 0x18176AE30
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x176F9C0 Offset: 0x176EDC0 VA: 0x18176F9C0
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x176BF90 Offset: 0x176B390 VA: 0x18176BF90
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176BA20 Offset: 0x176AE20 VA: 0x18176BA20
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176C250 Offset: 0x176B650 VA: 0x18176C250
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x176FE20 Offset: 0x176F220 VA: 0x18176FE20
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x176DA00 Offset: 0x176CE00 VA: 0x18176DA00
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x176D5A0 Offset: 0x176C9A0 VA: 0x18176D5A0
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1769FD0 Offset: 0x17693D0 VA: 0x181769FD0
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1769EB0 Offset: 0x17692B0 VA: 0x181769EB0
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1769760 Offset: 0x1768B60 VA: 0x181769760
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x176F880 Offset: 0x176EC80 VA: 0x18176F880
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x176F0E0 Offset: 0x176E4E0 VA: 0x18176F0E0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x176D2F0 Offset: 0x176C6F0 VA: 0x18176D2F0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176E7D0 Offset: 0x176DBD0 VA: 0x18176E7D0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176A6A0 Offset: 0x1769AA0 VA: 0x18176A6A0
	|-Enumerable.WhereSelectListIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x176F4B0 Offset: 0x176E8B0 VA: 0x18176F4B0
	|-Enumerable.WhereSelectListIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x176E1C0 Offset: 0x176D5C0 VA: 0x18176E1C0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17694E0 Offset: 0x17688E0 VA: 0x1817694E0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x176E410 Offset: 0x176D810 VA: 0x18176E410
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x176EAA0 Offset: 0x176DEA0 VA: 0x18176EAA0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x176B750 Offset: 0x176AB50 VA: 0x18176B750
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x176F220 Offset: 0x176E620 VA: 0x18176F220
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176F740 Offset: 0x176EB40 VA: 0x18176F740
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176B380 Offset: 0x176A780 VA: 0x18176B380
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1769220 Offset: 0x1768620 VA: 0x181769220
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x176CF80 Offset: 0x176C380 VA: 0x18176CF80
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x176E540 Offset: 0x176D940 VA: 0x18176E540
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x176C4F0 Offset: 0x176B8F0 VA: 0x18176C4F0
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x17703A0 Offset: 0x176F7A0 VA: 0x1817703A0
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x17699C0 Offset: 0x1768DC0 VA: 0x1817699C0
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1769890 Offset: 0x1768C90 VA: 0x181769890
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1769D90 Offset: 0x1769190 VA: 0x181769D90
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1768CB0 Offset: 0x17680B0 VA: 0x181768CB0
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x176EE60 Offset: 0x176E260 VA: 0x18176EE60
	|-Enumerable.WhereSelectListIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x176ED20 Offset: 0x176E120 VA: 0x18176ED20
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x176EFA0 Offset: 0x176E3A0 VA: 0x18176EFA0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1770260 Offset: 0x176F660 VA: 0x181770260
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176DC60 Offset: 0x176D060 VA: 0x18176DC60
	|-Enumerable.WhereSelectListIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x176E2F0 Offset: 0x176D6F0 VA: 0x18176E2F0
	|-Enumerable.WhereSelectListIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x176A3D0 Offset: 0x17697D0 VA: 0x18176A3D0
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1769600 Offset: 0x1768A00 VA: 0x181769600
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x176A540 Offset: 0x1769940 VA: 0x18176A540
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x176CBB0 Offset: 0x176BFB0 VA: 0x18176CBB0
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x176D700 Offset: 0x176CB00 VA: 0x18176D700
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x176F5D0 Offset: 0x176E9D0 VA: 0x18176F5D0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x176E660 Offset: 0x176DA60 VA: 0x18176E660
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176D430 Offset: 0x176C830 VA: 0x18176D430
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x178B030 Offset: 0x178A430 VA: 0x18178B030
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x17899E0 Offset: 0x1788DE0 VA: 0x1817899E0
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x178BE00 Offset: 0x178B200 VA: 0x18178BE00
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x178B2C0 Offset: 0x178A6C0 VA: 0x18178B2C0
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x178B590 Offset: 0x178A990 VA: 0x18178B590
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1789B50 Offset: 0x1788F50 VA: 0x181789B50
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x178BA20 Offset: 0x178AE20 VA: 0x18178BA20
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x17894B0 Offset: 0x17888B0 VA: 0x1817894B0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1789870 Offset: 0x1788C70 VA: 0x181789870
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x178A0E0 Offset: 0x17894E0 VA: 0x18178A0E0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1789F50 Offset: 0x1789350 VA: 0x181789F50
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x178A9A0 Offset: 0x1789DA0 VA: 0x18178A9A0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x178B890 Offset: 0x178AC90 VA: 0x18178B890
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x178C2F0 Offset: 0x178B6F0 VA: 0x18178C2F0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x178AB30 Offset: 0x1789F30 VA: 0x18178AB30
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1788C10 Offset: 0x1788010 VA: 0x181788C10
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x178B720 Offset: 0x178AB20 VA: 0x18178B720
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x178C5C0 Offset: 0x178B9C0 VA: 0x18178C5C0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x178C1B0 Offset: 0x178B5B0 VA: 0x18178C1B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x178B190 Offset: 0x178A590 VA: 0x18178B190
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1788AD0 Offset: 0x1787ED0 VA: 0x181788AD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1788D80 Offset: 0x1788180 VA: 0x181788D80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x178A390 Offset: 0x1789790 VA: 0x18178A390
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1789CD0 Offset: 0x17890D0 VA: 0x181789CD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1789120 Offset: 0x1788520 VA: 0x181789120
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x178C9A0 Offset: 0x178BDA0 VA: 0x18178C9A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x178A870 Offset: 0x1789C70 VA: 0x18178A870
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x178BCC0 Offset: 0x178B0C0 VA: 0x18178BCC0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1789270 Offset: 0x1788670 VA: 0x181789270
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x178ADE0 Offset: 0x178A1E0 VA: 0x18178ADE0
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1788FF0 Offset: 0x17883F0 VA: 0x181788FF0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1789750 Offset: 0x1788B50 VA: 0x181789750
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1789E20 Offset: 0x1789220 VA: 0x181789E20
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x178ACA0 Offset: 0x178A0A0 VA: 0x18178ACA0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x178B450 Offset: 0x178A850 VA: 0x18178B450
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x178C860 Offset: 0x178BC60 VA: 0x18178C860
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x178BF50 Offset: 0x178B350 VA: 0x18178BF50
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x178BB90 Offset: 0x178AF90 VA: 0x18178BB90
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x178C090 Offset: 0x178B490 VA: 0x18178C090
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x178A260 Offset: 0x1789660 VA: 0x18178A260
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1789630 Offset: 0x1788A30 VA: 0x181789630
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1788ED0 Offset: 0x17882D0 VA: 0x181788ED0
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x178AF00 Offset: 0x178A300 VA: 0x18178AF00
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x178C480 Offset: 0x178B880 VA: 0x18178C480
	|-Enumerable.WhereSelectListIterator<object, Option>.MoveNext
	|
	|-RVA: 0x178A730 Offset: 0x1789B30 VA: 0x18178A730
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x178CAD0 Offset: 0x178BED0 VA: 0x18178CAD0
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x178C720 Offset: 0x178BB20 VA: 0x18178C720
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1789390 Offset: 0x1788790 VA: 0x181789390
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0x178A600 Offset: 0x1789A00 VA: 0x18178A600
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x178A4E0 Offset: 0x17898E0 VA: 0x18178A4E0
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6BDF0 Offset: 0xC6B1F0 VA: 0x180C6BDF0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC6BF30 Offset: 0xC6B330 VA: 0x180C6BF30
	|-Enumerable.WhereSelectListIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC6C070 Offset: 0xC6B470 VA: 0x180C6C070
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC6BFD0 Offset: 0xC6B3D0 VA: 0x180C6BFD0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC6BE90 Offset: 0xC6B290 VA: 0x180C6BE90
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1770940 Offset: 0x176FD40 VA: 0x181770940
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectListIterator<Option, Option>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Friend, int>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Friend, long>.Where
	|-Enumerable.WhereSelectListIterator<Friend, object>.Where
	|-Enumerable.WhereSelectListIterator<Friend, float>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<object, Option>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<object, bool>.Where
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<object, long>.Where
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|-Enumerable.WhereSelectListIterator<object, float>.Where
	|-Enumerable.WhereSelectListIterator<object, uint>.Where
	|-Enumerable.WhereSelectListIterator<object, Resolution>.Where
	*/

}

private sealed class Enumerable.<>c__DisplayClass6_0<TSource> // TypeDefIndex: 3206
{	// Fields
	public Func<TSource, bool> predicate1; // 0x0
	public Func<TSource, bool> predicate2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>..ctor
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Option>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass6_0<bool>..ctor
	|-Enumerable.<>c__DisplayClass6_0<char>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<int>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass6_0<long>..ctor
	|-Enumerable.<>c__DisplayClass6_0<object>..ctor
	|-Enumerable.<>c__DisplayClass6_0<float>..ctor
	|-Enumerable.<>c__DisplayClass6_0<uint>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Resolution>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CombinePredicates>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19FD540 Offset: 0x19FC940 VA: 0x1819FD540
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD660 Offset: 0x19FCA60 VA: 0x1819FD660
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FDAF0 Offset: 0x19FCEF0 VA: 0x1819FDAF0
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Option>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FDA70 Offset: 0x19FCE70 VA: 0x1819FDA70
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD9F0 Offset: 0x19FCDF0 VA: 0x1819FD9F0
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD8C0 Offset: 0x19FCCC0 VA: 0x1819FD8C0
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD720 Offset: 0x19FCB20 VA: 0x1819FD720
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FDBA0 Offset: 0x19FCFA0 VA: 0x1819FDBA0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FDCD0 Offset: 0x19FD0D0 VA: 0x1819FDCD0
	|-Enumerable.<>c__DisplayClass6_0<bool>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD970 Offset: 0x19FCD70 VA: 0x1819FD970
	|-Enumerable.<>c__DisplayClass6_0<char>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD5E0 Offset: 0x19FC9E0 VA: 0x1819FD5E0
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FD840 Offset: 0x19FCC40 VA: 0x1819FD840
	|-Enumerable.<>c__DisplayClass6_0<long>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x19FDC50 Offset: 0x19FD050 VA: 0x1819FDC50
	|-Enumerable.<>c__DisplayClass6_0<float>.<CombinePredicates>b__0
	*/

}

private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 3207
{	// Fields
	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItemId, InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, uint, uint>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CombineSelectors>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448930 Offset: 0x1447D30 VA: 0x181448930
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447300 Offset: 0x1446700 VA: 0x181447300
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, uint, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE3D0 Offset: 0x19FD7D0 VA: 0x1819FE3D0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FDE20 Offset: 0x19FD220 VA: 0x1819FDE20
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE150 Offset: 0x19FD550 VA: 0x1819FE150
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FDF50 Offset: 0x19FD350 VA: 0x1819FDF50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FDD50 Offset: 0x19FD150 VA: 0x1819FDD50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE020 Offset: 0x19FD420 VA: 0x1819FE020
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE220 Offset: 0x19FD620 VA: 0x1819FE220
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE490 Offset: 0x19FD890 VA: 0x1819FE490
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE320 Offset: 0x19FD720 VA: 0x1819FE320
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FDEA0 Offset: 0x19FD2A0 VA: 0x1819FDEA0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE0A0 Offset: 0x19FD4A0 VA: 0x1819FE0A0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x19FE2A0 Offset: 0x19FD6A0 VA: 0x1819FE2A0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447DE0 Offset: 0x14471E0 VA: 0x181447DE0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x14471E0 Offset: 0x14465E0 VA: 0x1814471E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447250 Offset: 0x1446650 VA: 0x181447250
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14475C0 Offset: 0x14469C0 VA: 0x1814475C0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448030 Offset: 0x1447430 VA: 0x181448030
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449010 Offset: 0x1448410 VA: 0x181449010
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447B50 Offset: 0x1446F50 VA: 0x181447B50
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447980 Offset: 0x1446D80 VA: 0x181447980
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449620 Offset: 0x1448A20 VA: 0x181449620
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447FA0 Offset: 0x14473A0 VA: 0x181447FA0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448690 Offset: 0x1447A90 VA: 0x181448690
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448990 Offset: 0x1447D90 VA: 0x181448990
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447BC0 Offset: 0x1446FC0 VA: 0x181447BC0
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448180 Offset: 0x1447580 VA: 0x181448180
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449870 Offset: 0x1448C70 VA: 0x181449870
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448420 Offset: 0x1447820 VA: 0x181448420
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449200 Offset: 0x1448600 VA: 0x181449200
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14474C0 Offset: 0x14468C0 VA: 0x1814474C0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448C80 Offset: 0x1448080 VA: 0x181448C80
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449390 Offset: 0x1448790 VA: 0x181449390
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x144A020 Offset: 0x1449420 VA: 0x18144A020
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449080 Offset: 0x1448480 VA: 0x181449080
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14487B0 Offset: 0x1447BB0 VA: 0x1814487B0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449F30 Offset: 0x1449330 VA: 0x181449F30
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144A100 Offset: 0x1449500 VA: 0x18144A100
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448600 Offset: 0x1447A00 VA: 0x181448600
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x14473E0 Offset: 0x14467E0 VA: 0x1814473E0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItemId, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447A10 Offset: 0x1446E10 VA: 0x181447A10
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14480E0 Offset: 0x14474E0 VA: 0x1814480E0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Option, Option>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447AB0 Offset: 0x1446EB0 VA: 0x181447AB0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447E80 Offset: 0x1447280 VA: 0x181447E80
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449300 Offset: 0x1448700 VA: 0x181449300
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14488A0 Offset: 0x1447CA0 VA: 0x1814488A0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447870 Offset: 0x1446C70 VA: 0x181447870
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447670 Offset: 0x1446A70 VA: 0x181447670
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x14497F0 Offset: 0x1448BF0 VA: 0x1814497F0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449930 Offset: 0x1448D30 VA: 0x181449930
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448570 Offset: 0x1447970 VA: 0x181448570
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x14484E0 Offset: 0x14478E0 VA: 0x1814484E0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448B60 Offset: 0x1447F60 VA: 0x181448B60
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449160 Offset: 0x1448560 VA: 0x181449160
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449770 Offset: 0x1448B70 VA: 0x181449770
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x14477F0 Offset: 0x1446BF0 VA: 0x1814477F0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447C80 Offset: 0x1447080 VA: 0x181447C80
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449E70 Offset: 0x1449270 VA: 0x181449E70
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448310 Offset: 0x1447710 VA: 0x181448310
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448D80 Offset: 0x1448180 VA: 0x181448D80
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448E20 Offset: 0x1448220 VA: 0x181448E20
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447750 Offset: 0x1446B50 VA: 0x181447750
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448A00 Offset: 0x1447E00 VA: 0x181448A00
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448730 Offset: 0x1447B30 VA: 0x181448730
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448F80 Offset: 0x1448380 VA: 0x181448F80
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447900 Offset: 0x1446D00 VA: 0x181447900
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447130 Offset: 0x1446530 VA: 0x181447130
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448EC0 Offset: 0x14482C0 VA: 0x181448EC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448AA0 Offset: 0x1447EA0 VA: 0x181448AA0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x14496B0 Offset: 0x1448AB0 VA: 0x1814496B0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449CE0 Offset: 0x14490E0 VA: 0x181449CE0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447440 Offset: 0x1446840 VA: 0x181447440
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447F00 Offset: 0x1447300 VA: 0x181447F00
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449580 Offset: 0x1448980 VA: 0x181449580
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x14494E0 Offset: 0x14488E0 VA: 0x1814494E0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448270 Offset: 0x1447670 VA: 0x181448270
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449AE0 Offset: 0x1448EE0 VA: 0x181449AE0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447360 Offset: 0x1446760 VA: 0x181447360
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449B60 Offset: 0x1448F60 VA: 0x181449B60
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x14499C0 Offset: 0x1448DC0 VA: 0x1814499C0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449DE0 Offset: 0x14491E0 VA: 0x181449DE0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449450 Offset: 0x1448850 VA: 0x181449450
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449D60 Offset: 0x1449160 VA: 0x181449D60
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449C60 Offset: 0x1449060 VA: 0x181449C60
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x1447D40 Offset: 0x1447140 VA: 0x181447D40
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x14476D0 Offset: 0x1446AD0 VA: 0x1814476D0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449BE0 Offset: 0x1448FE0 VA: 0x181449BE0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144A1C0 Offset: 0x14495C0 VA: 0x18144A1C0
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x1449A50 Offset: 0x1448E50 VA: 0x181449A50
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x1448390 Offset: 0x1447790 VA: 0x181448390
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe>.<CombineSelectors>b__0
	*/

}

private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3208
{	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446240 Offset: 0x1445640 VA: 0x181446240
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>..ctor
	|
	|-RVA: 0x19E1A50 Offset: 0x19E0E50 VA: 0x1819E1A50
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<SelectManyIterator>d__17<object, byte>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E1700 Offset: 0x19E0B00 VA: 0x1819E1700
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0940 Offset: 0x19DFD40 VA: 0x1819E0940
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19E0660 Offset: 0x19DFA60 VA: 0x1819E0660
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19E0EE0 Offset: 0x19E02E0 VA: 0x1819E0EE0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.MoveNext
	|
	|-RVA: 0x19E0C10 Offset: 0x19E0010 VA: 0x1819E0C10
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E18C0 Offset: 0x19E0CC0 VA: 0x1819E18C0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally1
	|
	|-RVA: 0x19E1870 Offset: 0x19E0C70 VA: 0x1819E1870
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally1
	|
	|-RVA: 0x19E17D0 Offset: 0x19E0BD0 VA: 0x1819E17D0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally1
	|
	|-RVA: 0x19E1820 Offset: 0x19E0C20 VA: 0x1819E1820
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E1A00 Offset: 0x19E0E00 VA: 0x1819E1A00
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally2
	|
	|-RVA: 0x19E1960 Offset: 0x19E0D60 VA: 0x1819E1960
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally2
	|
	|-RVA: 0x19E1910 Offset: 0x19E0D10 VA: 0x1819E1910
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally2
	|
	|-RVA: 0x19E19B0 Offset: 0x19E0DB0 VA: 0x1819E19B0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x11222B0 Offset: 0x11216B0 VA: 0x1811222B0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E1570 Offset: 0x19E0970 VA: 0x1819E1570
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E1520 Offset: 0x19E0920 VA: 0x1819E1520
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E15C0 Offset: 0x19E09C0 VA: 0x1819E15C0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E14D0 Offset: 0x19E08D0 VA: 0x1819E14D0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E16B0 Offset: 0x19E0AB0 VA: 0x1819E16B0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19E1660 Offset: 0x19E0A60 VA: 0x1819E1660
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19E1610 Offset: 0x19E0A10 VA: 0x1819E1610
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E11A0 Offset: 0x19E05A0 VA: 0x1819E11A0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19E1260 Offset: 0x19E0660 VA: 0x1819E1260
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19E13E0 Offset: 0x19E07E0 VA: 0x1819E13E0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19E1320 Offset: 0x19E0720 VA: 0x1819E1320
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E14A0 Offset: 0x19E08A0 VA: 0x1819E14A0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3209
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3350 Offset: 0x19E2750 VA: 0x1819E3350
	|-Enumerable.<TakeIterator>d__25<Option>..ctor
	|-Enumerable.<TakeIterator>d__25<InventoryItem>..ctor
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<TakeIterator>d__25<double>..ctor
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<TakeIterator>d__25<Option>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<double>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E2520 Offset: 0x19E1920 VA: 0x1819E2520
	|-Enumerable.<TakeIterator>d__25<Option>.MoveNext
	|
	|-RVA: 0x19E2A80 Offset: 0x19E1E80 VA: 0x1819E2A80
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.MoveNext
	|
	|-RVA: 0x19E28C0 Offset: 0x19E1CC0 VA: 0x1819E28C0
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0x19E2700 Offset: 0x19E1B00 VA: 0x1819E2700
	|-Enumerable.<TakeIterator>d__25<double>.MoveNext
	|
	|-RVA: 0x19E2C60 Offset: 0x19E2060 VA: 0x1819E2C60
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3210 Offset: 0x19E2610 VA: 0x1819E3210
	|-Enumerable.<TakeIterator>d__25<Option>.<>m__Finally1
	|
	|-RVA: 0x19E32B0 Offset: 0x19E26B0 VA: 0x1819E32B0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.<>m__Finally1
	|
	|-RVA: 0x19E31C0 Offset: 0x19E25C0 VA: 0x1819E31C0
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0x19E3300 Offset: 0x19E2700 VA: 0x1819E3300
	|-Enumerable.<TakeIterator>d__25<double>.<>m__Finally1
	|
	|-RVA: 0x19E3260 Offset: 0x19E2660 VA: 0x1819E3260
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1768250 Offset: 0x1767650 VA: 0x181768250
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB37030 Offset: 0xB36430 VA: 0x180B37030
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3120 Offset: 0x19E2520 VA: 0x1819E3120
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E30D0 Offset: 0x19E24D0 VA: 0x1819E30D0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E3080 Offset: 0x19E2480 VA: 0x1819E3080
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E3030 Offset: 0x19E2430 VA: 0x1819E3030
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E3170 Offset: 0x19E2570 VA: 0x1819E3170
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1768740 Offset: 0x1767B40 VA: 0x181768740
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19E23E0 Offset: 0x19E17E0 VA: 0x1819E23E0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1768660 Offset: 0x1767A60 VA: 0x181768660
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E2ED0 Offset: 0x19E22D0 VA: 0x1819E2ED0
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19E2F80 Offset: 0x19E2380 VA: 0x1819E2F80
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19E2E20 Offset: 0x19E2220 VA: 0x1819E2E20
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1D10 Offset: 0x19C1110 VA: 0x1819C1D10
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<TakeWhileIterator>d__27<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3210
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	public Func<TSource, bool> <>3__predicate; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3390 Offset: 0x19E2790 VA: 0x1819E3390
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E35D0 Offset: 0x19E29D0 VA: 0x1819E35D0
	|-Enumerable.<TakeWhileIterator>d__27<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3580 Offset: 0x19E2980 VA: 0x1819E3580
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446AE0 Offset: 0x1445EE0 VA: 0x181446AE0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446C60 Offset: 0x1446060 VA: 0x181446C60
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<SkipIterator>d__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3211
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerator<TSource> <e>5__1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<SkipIterator>d__31<double>..ctor
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<double>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E1F40 Offset: 0x19E1340 VA: 0x1819E1F40
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0x19E1CF0 Offset: 0x19E10F0 VA: 0x1819E1CF0
	|-Enumerable.<SkipIterator>d__31<double>.MoveNext
	|
	|-RVA: 0x19E1A90 Offset: 0x19E0E90 VA: 0x1819E1A90
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E24D0 Offset: 0x19E18D0 VA: 0x1819E24D0
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0x19E2480 Offset: 0x19E1880 VA: 0x1819E2480
	|-Enumerable.<SkipIterator>d__31<double>.<>m__Finally1
	|
	|-RVA: 0x19E2430 Offset: 0x19E1830 VA: 0x1819E2430
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB37030 Offset: 0xB36430 VA: 0x180B37030
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E22F0 Offset: 0x19E16F0 VA: 0x1819E22F0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E2390 Offset: 0x19E1790 VA: 0x1819E2390
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E2340 Offset: 0x19E1740 VA: 0x1819E2340
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E23E0 Offset: 0x19E17E0 VA: 0x1819E23E0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1768660 Offset: 0x1767A60 VA: 0x181768660
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E2240 Offset: 0x19E1640 VA: 0x1819E2240
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19E2190 Offset: 0x19E1590 VA: 0x1819E2190
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C1D10 Offset: 0x19C1110 VA: 0x1819C1D10
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3212
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<ConcatIterator>d__59<long>..ctor
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446E20 Offset: 0x1446220 VA: 0x181446E20
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<long>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14462C0 Offset: 0x14456C0 VA: 0x1814462C0
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0x1446830 Offset: 0x1445C30 VA: 0x181446830
	|-Enumerable.<ConcatIterator>d__59<long>.MoveNext
	|
	|-RVA: 0x1446570 Offset: 0x1445970 VA: 0x181446570
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446FF0 Offset: 0x14463F0 VA: 0x181446FF0
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0x1446FA0 Offset: 0x14463A0 VA: 0x181446FA0
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally1
	|
	|-RVA: 0x1446F50 Offset: 0x1446350 VA: 0x181446F50
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1447090 Offset: 0x1446490 VA: 0x181447090
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0x14470E0 Offset: 0x14464E0 VA: 0x1814470E0
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally2
	|
	|-RVA: 0x1447040 Offset: 0x1446440 VA: 0x181447040
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446C90 Offset: 0x1446090 VA: 0x181446C90
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1446D30 Offset: 0x1446130 VA: 0x181446D30
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1446CE0 Offset: 0x14460E0 VA: 0x181446CE0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446D80 Offset: 0x1446180 VA: 0x181446D80
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1446DD0 Offset: 0x14461D0 VA: 0x181446DD0
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446BA0 Offset: 0x1445FA0 VA: 0x181446BA0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x1446AE0 Offset: 0x1445EE0 VA: 0x181446AE0
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446C60 Offset: 0x1446060 VA: 0x181446C60
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ZipIterator>d__65<TFirst, TSecond, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3213
{	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TFirst> first; // 0x0
	public IEnumerable<TFirst> <>3__first; // 0x0
	private IEnumerable<TSecond> second; // 0x0
	public IEnumerable<TSecond> <>3__second; // 0x0
	private Func<TFirst, TSecond, TResult> resultSelector; // 0x0
	public Func<TFirst, TSecond, TResult> <>3__resultSelector; // 0x0
	private IEnumerator<TFirst> <e1>5__1; // 0x0
	private IEnumerator<TSecond> <e2>5__2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<ZipIterator>d__65<object, long, object>..ctor
	|-Enumerable.<ZipIterator>d__65<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E1700 Offset: 0x19E0B00 VA: 0x1819E1700
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.IDisposable.Dispose
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E43F0 Offset: 0x19E37F0 VA: 0x1819E43F0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.MoveNext
	|
	|-RVA: 0x19E4110 Offset: 0x19E3510 VA: 0x1819E4110
	|-Enumerable.<ZipIterator>d__65<object, object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E4840 Offset: 0x19E3C40 VA: 0x1819E4840
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally1
	|
	|-RVA: 0x19E4890 Offset: 0x19E3C90 VA: 0x1819E4890
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E48E0 Offset: 0x19E3CE0 VA: 0x1819E48E0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally2
	|
	|-RVA: 0x19E4930 Offset: 0x19E3D30 VA: 0x1819E4930
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E47A0 Offset: 0x19E3BA0 VA: 0x1819E47A0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E47F0 Offset: 0x19E3BF0 VA: 0x1819E47F0
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E46D0 Offset: 0x19E3AD0 VA: 0x1819E46D0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E14A0 Offset: 0x19E08A0 VA: 0x1819E14A0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3214
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DECB0 Offset: 0x19DE0B0 VA: 0x1819DECB0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.IDisposable.Dispose
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DE550 Offset: 0x19DD950 VA: 0x1819DE550
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.MoveNext
	|
	|-RVA: 0x19DE300 Offset: 0x19DD700 VA: 0x1819DE300
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DEC60 Offset: 0x19DE060 VA: 0x1819DEC60
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.<>m__Finally1
	|
	|-RVA: 0x19DEC10 Offset: 0x19DE010 VA: 0x1819DEC10
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE7070 Offset: 0xDE6470 VA: 0x180DE7070
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DEAE0 Offset: 0x19DDEE0 VA: 0x1819DEAE0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DEB30 Offset: 0x19DDF30 VA: 0x1819DEB30
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DEB80 Offset: 0x19DDF80 VA: 0x1819DEB80
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DE920 Offset: 0x19DDD20 VA: 0x1819DE920
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19DE9F0 Offset: 0x19DDDF0 VA: 0x1819DE9F0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DEAB0 Offset: 0x19DDEB0 VA: 0x1819DEAB0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3215
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446E20 Offset: 0x1446220 VA: 0x181446E20
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E39C0 Offset: 0x19E2DC0 VA: 0x1819E39C0
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x19E3620 Offset: 0x19E2A20 VA: 0x1819E3620
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3FD0 Offset: 0x19E33D0 VA: 0x1819E3FD0
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x19E4020 Offset: 0x19E3420 VA: 0x1819E4020
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E40C0 Offset: 0x19E34C0 VA: 0x1819E40C0
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x19E4070 Offset: 0x19E3470 VA: 0x1819E4070
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445BF0 Offset: 0x1444FF0 VA: 0x181445BF0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3F30 Offset: 0x19E3330 VA: 0x1819E3F30
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E3EE0 Offset: 0x19E32E0 VA: 0x1819E3EE0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3F80 Offset: 0x19E3380 VA: 0x1819E3F80
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3E10 Offset: 0x19E3210 VA: 0x1819E3E10
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19E3D40 Offset: 0x19E3140 VA: 0x1819E3D40
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E14A0 Offset: 0x19E08A0 VA: 0x1819E14A0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3216
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<ExceptIterator>d__77<float>..ctor
	|
	|-RVA: 0x19DFFB0 Offset: 0x19DF3B0 VA: 0x1819DFFB0
	|-Enumerable.<ExceptIterator>d__77<Vector2>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<float>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DF190 Offset: 0x19DE590 VA: 0x1819DF190
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0x19DF620 Offset: 0x19DEA20 VA: 0x1819DF620
	|-Enumerable.<ExceptIterator>d__77<float>.MoveNext
	|
	|-RVA: 0x19DECF0 Offset: 0x19DE0F0 VA: 0x1819DECF0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DFF60 Offset: 0x19DF360 VA: 0x1819DFF60
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0x19DFF10 Offset: 0x19DF310 VA: 0x1819DFF10
	|-Enumerable.<ExceptIterator>d__77<float>.<>m__Finally1
	|
	|-RVA: 0x19DFEC0 Offset: 0x19DF2C0 VA: 0x1819DFEC0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xE866A0 Offset: 0xE85AA0 VA: 0x180E866A0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x19DFD10 Offset: 0x19DF110 VA: 0x1819DFD10
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DFD80 Offset: 0x19DF180 VA: 0x1819DFD80
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DFDD0 Offset: 0x19DF1D0 VA: 0x1819DFDD0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19DFD30 Offset: 0x19DF130 VA: 0x1819DFD30
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DFE20 Offset: 0x19DF220 VA: 0x1819DFE20
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19DFE70 Offset: 0x19DF270 VA: 0x1819DFE70
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DFC40 Offset: 0x19DF040 VA: 0x1819DFC40
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19DFB70 Offset: 0x19DEF70 VA: 0x1819DFB70
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19DFAA0 Offset: 0x19DEEA0 VA: 0x1819DFAA0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DEAB0 Offset: 0x19DDEB0 VA: 0x1819DEAB0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ReverseIterator>d__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3217
{	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Buffer<TSource> <buffer>5__1; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<ReverseIterator>d__79<char>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<ReverseIterator>d__79<long>..ctor
	|-Enumerable.<ReverseIterator>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-Enumerable.<ReverseIterator>d__79<char>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<long>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0350 Offset: 0x19DF750 VA: 0x1819E0350
	|-Enumerable.<ReverseIterator>d__79<char>.MoveNext
	|
	|-RVA: 0x19E0410 Offset: 0x19DF810 VA: 0x1819E0410
	|-Enumerable.<ReverseIterator>d__79<long>.MoveNext
	|
	|-RVA: 0x19E0290 Offset: 0x19DF690 VA: 0x1819E0290
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445BF0 Offset: 0x1444FF0 VA: 0x181445BF0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0570 Offset: 0x19DF970 VA: 0x1819E0570
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E0520 Offset: 0x19DF920 VA: 0x1819E0520
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19E04D0 Offset: 0x19DF8D0 VA: 0x1819E04D0
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0610 Offset: 0x19DFA10 VA: 0x1819E0610
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19E05C0 Offset: 0x19DF9C0 VA: 0x1819E05C0
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445B40 Offset: 0x1444F40 VA: 0x181445B40
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x1445A90 Offset: 0x1444E90 VA: 0x181445A90
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445C00 Offset: 0x1445000 VA: 0x181445C00
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3218
{	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DFFF0 Offset: 0x19DF3F0 VA: 0x1819DFFF0
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E0230 Offset: 0x19DF630 VA: 0x1819E0230
	|-Enumerable.<OfTypeIterator>d__97<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E01E0 Offset: 0x19DF5E0 VA: 0x1819E01E0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445A90 Offset: 0x1444E90 VA: 0x181445A90
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445C00 Offset: 0x1445000 VA: 0x181445C00
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3219
{	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446200 Offset: 0x1445600 VA: 0x181446200
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<byte>..ctor
	|-Enumerable.<CastIterator>d__99<short>..ctor
	|-Enumerable.<CastIterator>d__99<int>..ctor
	|
	|-RVA: 0x1446240 Offset: 0x1445640 VA: 0x181446240
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Enumerable.<CastIterator>d__99<bool>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<byte>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<short>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<int>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445820 Offset: 0x1444C20 VA: 0x181445820
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0x1444F50 Offset: 0x1444350 VA: 0x181444F50
	|-Enumerable.<CastIterator>d__99<byte>.MoveNext
	|
	|-RVA: 0x1445110 Offset: 0x1444510 VA: 0x181445110
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1445660 Offset: 0x1444A60 VA: 0x181445660
	|-Enumerable.<CastIterator>d__99<short>.MoveNext
	|
	|-RVA: 0x14452E0 Offset: 0x14446E0 VA: 0x1814452E0
	|-Enumerable.<CastIterator>d__99<int>.MoveNext
	|
	|-RVA: 0x14454A0 Offset: 0x14448A0 VA: 0x1814454A0
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14461A0 Offset: 0x14455A0 VA: 0x1814461A0
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0x1445FC0 Offset: 0x14453C0 VA: 0x181445FC0
	|-Enumerable.<CastIterator>d__99<byte>.<>m__Finally1
	|
	|-RVA: 0x1446080 Offset: 0x1445480 VA: 0x181446080
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x1446140 Offset: 0x1445540 VA: 0x181446140
	|-Enumerable.<CastIterator>d__99<short>.<>m__Finally1
	|
	|-RVA: 0x1446020 Offset: 0x1445420 VA: 0x181446020
	|-Enumerable.<CastIterator>d__99<int>.<>m__Finally1
	|
	|-RVA: 0x14460E0 Offset: 0x14454E0 VA: 0x1814460E0
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x1445BF0 Offset: 0x1444FF0 VA: 0x181445BF0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445CD0 Offset: 0x14450D0 VA: 0x181445CD0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1445D70 Offset: 0x1445170 VA: 0x181445D70
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1445C30 Offset: 0x1445030 VA: 0x181445C30
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1445D20 Offset: 0x1445120 VA: 0x181445D20
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1445C80 Offset: 0x1445080 VA: 0x181445C80
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1445DC0 Offset: 0x14451C0 VA: 0x181445DC0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445E10 Offset: 0x1445210 VA: 0x181445E10
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1445EB0 Offset: 0x14452B0 VA: 0x181445EB0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1445E60 Offset: 0x1445260 VA: 0x181445E60
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1445F00 Offset: 0x1445300 VA: 0x181445F00
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445B40 Offset: 0x1444F40 VA: 0x181445B40
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x14459E0 Offset: 0x1444DE0 VA: 0x1814459E0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x1445A90 Offset: 0x1444E90 VA: 0x181445A90
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445C00 Offset: 0x1445000 VA: 0x181445C00
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<RangeIterator>d__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator // TypeDefIndex: 3220
{	// Fields
	private int <>1__state; // 0x10
	private int <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	private int start; // 0x1C
	public int <>3__start; // 0x20
	private int <i>5__1; // 0x24
	private int count; // 0x28
	public int <>3__count; // 0x2C

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2227B70 Offset: 0x2226F70 VA: 0x182227B70
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x22279F0 Offset: 0x2226DF0 VA: 0x1822279F0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 6
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2227AD0 Offset: 0x2226ED0 VA: 0x182227AD0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2227B20 Offset: 0x2226F20 VA: 0x182227B20 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2227A30 Offset: 0x2226E30 VA: 0x182227A30 Slot: 4
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2227A30 Offset: 0x2226E30 VA: 0x182227A30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 3236
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17879D0 Offset: 0x1786DD0 VA: 0x1817879D0
	|-EnumerableSorter<Demos.DemoInfo>.Sort
	|
	|-RVA: 0x1787AB0 Offset: 0x1786EB0 VA: 0x181787AB0
	|-EnumerableSorter<ServerInfo>.Sort
	|
	|-RVA: 0x17880D0 Offset: 0x17874D0 VA: 0x1817880D0
	|-EnumerableSorter<Item>.Sort
	|
	|-RVA: 0x1787FF0 Offset: 0x17873F0 VA: 0x181787FF0
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x1787B90 Offset: 0x1786F90 VA: 0x181787B90
	|-EnumerableSorter<KeyValuePair<object, long>>.Sort
	|
	|-RVA: 0x1787F10 Offset: 0x1787310 VA: 0x181787F10
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x1787C70 Offset: 0x1787070 VA: 0x181787C70
	|-EnumerableSorter<double>.Sort
	|
	|-RVA: 0x1787D50 Offset: 0x1787150 VA: 0x181787D50
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x1787E30 Offset: 0x1787230 VA: 0x181787E30
	|-EnumerableSorter<Resolution>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17877B0 Offset: 0x1786BB0 VA: 0x1817877B0
	|-EnumerableSorter<Demos.DemoInfo>.QuickSort
	|-EnumerableSorter<ServerInfo>.QuickSort
	|-EnumerableSorter<Item>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, int>>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, long>>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, object>>.QuickSort
	|-EnumerableSorter<double>.QuickSort
	|-EnumerableSorter<object>.QuickSort
	|-EnumerableSorter<Resolution>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-EnumerableSorter<Demos.DemoInfo>..ctor
	|-EnumerableSorter<ServerInfo>..ctor
	|-EnumerableSorter<Item>..ctor
	|-EnumerableSorter<KeyValuePair<object, int>>..ctor
	|-EnumerableSorter<KeyValuePair<object, long>>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>>..ctor
	|-EnumerableSorter<double>..ctor
	|-EnumerableSorter<object>..ctor
	|-EnumerableSorter<Resolution>..ctor
	*/

}

internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 3237
{	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BAE0 Offset: 0x175AEE0 VA: 0x18175BAE0
	|-EnumerableSorter<Demos.DemoInfo, DateTime>..ctor
	|-EnumerableSorter<Demos.DemoInfo, object>..ctor
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>..ctor
	|-EnumerableSorter<ServerInfo, int>..ctor
	|-EnumerableSorter<ServerInfo, object>..ctor
	|-EnumerableSorter<ServerInfo, uint>..ctor
	|-EnumerableSorter<Item, DateTime>..ctor
	|-EnumerableSorter<KeyValuePair<object, int>, int>..ctor
	|-EnumerableSorter<KeyValuePair<object, long>, long>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>, long>..ctor
	|-EnumerableSorter<double, double>..ctor
	|-EnumerableSorter<object, bool>..ctor
	|-EnumerableSorter<object, DateTime>..ctor
	|-EnumerableSorter<object, DateTimeOffset>..ctor
	|-EnumerableSorter<object, Guid>..ctor
	|-EnumerableSorter<object, int>..ctor
	|-EnumerableSorter<object, Int32Enum>..ctor
	|-EnumerableSorter<object, object>..ctor
	|-EnumerableSorter<object, float>..ctor
	|-EnumerableSorter<object, uint>..ctor
	|-EnumerableSorter<Resolution, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17882C0 Offset: 0x17876C0 VA: 0x1817882C0
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.ComputeKeys
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x1788410 Offset: 0x1787810 VA: 0x181788410
	|-EnumerableSorter<Demos.DemoInfo, object>.ComputeKeys
	|
	|-RVA: 0x1788920 Offset: 0x1787D20 VA: 0x181788920
	|-EnumerableSorter<ServerInfo, int>.ComputeKeys
	|-EnumerableSorter<ServerInfo, uint>.ComputeKeys
	|
	|-RVA: 0x1788570 Offset: 0x1787970 VA: 0x181788570
	|-EnumerableSorter<ServerInfo, object>.ComputeKeys
	|
	|-RVA: 0x1788730 Offset: 0x1787B30 VA: 0x181788730
	|-EnumerableSorter<Item, DateTime>.ComputeKeys
	|
	|-RVA: 0x175B180 Offset: 0x175A580 VA: 0x18175B180
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x175B630 Offset: 0x175AA30 VA: 0x18175B630
	|-EnumerableSorter<KeyValuePair<object, long>, long>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.ComputeKeys
	|
	|-RVA: 0x175B510 Offset: 0x175A910 VA: 0x18175B510
	|-EnumerableSorter<double, double>.ComputeKeys
	|
	|-RVA: 0x175B8A0 Offset: 0x175ACA0 VA: 0x18175B8A0
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x175B9C0 Offset: 0x175ADC0 VA: 0x18175B9C0
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x175AF30 Offset: 0x175A330 VA: 0x18175AF30
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|-EnumerableSorter<object, Guid>.ComputeKeys
	|
	|-RVA: 0x175B2B0 Offset: 0x175A6B0 VA: 0x18175B2B0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x175B770 Offset: 0x175AB70 VA: 0x18175B770
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x175B060 Offset: 0x175A460 VA: 0x18175B060
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x175B3D0 Offset: 0x175A7D0 VA: 0x18175B3D0
	|-EnumerableSorter<Resolution, int>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17881B0 Offset: 0x17875B0 VA: 0x1817881B0
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.CompareKeys
	|-EnumerableSorter<Item, DateTime>.CompareKeys
	|
	|-RVA: 0x175A5B0 Offset: 0x17599B0 VA: 0x18175A5B0
	|-EnumerableSorter<Demos.DemoInfo, object>.CompareKeys
	|-EnumerableSorter<ServerInfo, object>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, long>, long>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.CompareKeys
	|
	|-RVA: 0x175AAE0 Offset: 0x1759EE0 VA: 0x18175AAE0
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x175AC50 Offset: 0x175A050 VA: 0x18175AC50
	|-EnumerableSorter<ServerInfo, int>.CompareKeys
	|-EnumerableSorter<ServerInfo, uint>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x175A850 Offset: 0x1759C50 VA: 0x18175A850
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<Resolution, int>.CompareKeys
	|
	|-RVA: 0x175A960 Offset: 0x1759D60 VA: 0x18175A960
	|-EnumerableSorter<double, double>.CompareKeys
	|
	|-RVA: 0x175A440 Offset: 0x1759840 VA: 0x18175A440
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x175A6C0 Offset: 0x1759AC0 VA: 0x18175A6C0
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|-EnumerableSorter<object, Guid>.CompareKeys
	|
	|-RVA: 0x175A2E0 Offset: 0x17596E0 VA: 0x18175A2E0
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x175ADB0 Offset: 0x175A1B0 VA: 0x18175ADB0
	|-EnumerableSorter<object, float>.CompareKeys
	*/

}

public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 5707
{	// Fields
	private string value; // 0x10

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Value() { }

}

internal static class EnumUtils // TypeDefIndex: 5954
{	// Fields
	private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x2B0AAC4

	// Methods

	// RVA: 0x1801610 Offset: 0x1800A10 VA: 0x181801610
	private static BidirectionalDictionary<string, string> InitializeEnumType(Type type) { }

	// RVA: 0x18012D0 Offset: 0x18006D0 VA: 0x1818012D0
	public static IList<object> GetValues(Type enumType) { }

	// RVA: 0x18019E0 Offset: 0x1800DE0 VA: 0x1818019E0
	public static object ParseEnumName(string enumText, bool isNullable, Type t) { }

	// RVA: 0x1801D70 Offset: 0x1801170 VA: 0x181801D70
	public static string ToEnumName(Type enumType, string enumText, bool camelCaseText) { }

	// RVA: 0x1801D00 Offset: 0x1801100 VA: 0x181801D00
	private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText) { }

	// RVA: 0x1801F60 Offset: 0x1801360 VA: 0x181801F60
	private static void .cctor() { }

}

private sealed class EnumUtils.<>c // TypeDefIndex: 5955
{	// Fields
	public static readonly EnumUtils.<>c <>9; // 0x0
	public static Func<EnumMemberAttribute, string> <>9__1_0; // 0x8
	public static Func<FieldInfo, bool> <>9__5_0; // 0x10

	// Methods

	// RVA: 0x1810320 Offset: 0x180F720 VA: 0x181810320
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a) { }

	// RVA: 0x180F9B0 Offset: 0x180EDB0 VA: 0x18180F9B0
	internal bool <GetValues>b__5_0(FieldInfo f) { }

}

private sealed class EnumUtils.<>c__2<T> // TypeDefIndex: 5956
{	// Fields
	public static readonly EnumUtils.<>c__2<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public void .ctor() { }

}

public class EnumListItemUI : MonoBehaviour // TypeDefIndex: 10794
{	// Fields
	public object Value; // 0x18
	public RustText TextValue; // 0x20
	private EnumListUI list; // 0x28

	// Methods

	// RVA: 0x8B5CF0 Offset: 0x8B50F0 VA: 0x1808B5CF0
	public void Init(object value, string valueText, EnumListUI list) { }

	// RVA: 0x8B5C70 Offset: 0x8B5070 VA: 0x1808B5C70
	public void Clicked() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class EnumListUI : MonoBehaviour // TypeDefIndex: 10795
{	// Fields
	public Transform PrefabItem; // 0x18
	public Transform Container; // 0x20
	private Action<object> clickedAction; // 0x28
	private CanvasScaler canvasScaler; // 0x30

	// Methods

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void Awake() { }

	// RVA: 0x8B5DC0 Offset: 0x8B51C0 VA: 0x1808B5DC0
	public void Show(List<object> values, Action<object> clicked) { }

	// RVA: 0x8B5D50 Offset: 0x8B5150 VA: 0x1808B5D50
	public void ItemClicked(object value) { }

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	public void Hide() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

