public interface SmallXmlParser.IContentHandler // TypeDefIndex: 25
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text);

}

public interface SmallXmlParser.IAttrList // TypeDefIndex: 26
{	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values();

}

internal interface IRegistryApi // TypeDefIndex: 100
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Flush(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Close(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] GetSubKeyNames(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IntPtr GetHandle(RegistryKey key);

}

internal interface ITupleInternal // TypeDefIndex: 134
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToString(StringBuilder sb);

}

public interface IAsyncResult // TypeDefIndex: 246
{	// Properties
	public abstract bool IsCompleted { get; }
	public abstract WaitHandle AsyncWaitHandle { get; }
	public abstract object AsyncState { get; }
	public abstract bool CompletedSynchronously { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract WaitHandle get_AsyncWaitHandle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_AsyncState();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_CompletedSynchronously();

}

public interface ICloneable // TypeDefIndex: 247
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Clone();

}

public interface IComparable // TypeDefIndex: 248
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object obj);

}

public interface IComparable<T> // TypeDefIndex: 249
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparable<object>.CompareTo
	*/

}

public interface IConvertible // TypeDefIndex: 250
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeCode GetTypeCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract char ToChar(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract sbyte ToSByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte ToByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short ToInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ushort ToUInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int ToInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract uint ToUInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long ToInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ulong ToUInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float ToSingle(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double ToDouble(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Decimal ToDecimal(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DateTime ToDateTime(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract object ToType(Type conversionType, IFormatProvider provider);

}

public interface ICustomFormatter // TypeDefIndex: 251
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string Format(string format, object arg, IFormatProvider formatProvider);

}

public interface IDisposable // TypeDefIndex: 252
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Dispose();

}

public interface IEquatable<T> // TypeDefIndex: 253
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEquatable<object>.Equals
	*/

}

public interface IFormatProvider // TypeDefIndex: 254
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetFormat(Type formatType);

}

public interface IFormattable // TypeDefIndex: 255
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToString(string format, IFormatProvider formatProvider);

}

public interface IProgress<T> // TypeDefIndex: 264
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Report(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProgress<object>.Report
	*/

}

public interface IServiceProvider // TypeDefIndex: 265
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetService(Type serviceType);

}

public struct UInt16 : IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort> // TypeDefIndex: 326
{	// Fields
	private ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;

	// Methods

	// RVA: 0x232900 Offset: 0x231D00 VA: 0x180232900 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F3340 Offset: 0x1F2740 VA: 0x1801F3340 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x2329D0 Offset: 0x231DD0 VA: 0x1802329D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F34B0 Offset: 0x1F28B0 VA: 0x1801F34B0 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232FF0 Offset: 0x2323F0 VA: 0x180232FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x233020 Offset: 0x232420 VA: 0x180233020 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x232FB0 Offset: 0x2323B0 VA: 0x180232FB0
	public string ToString(string format) { }

	// RVA: 0x233050 Offset: 0x232450 VA: 0x180233050 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x213FEB0 Offset: 0x213F2B0 VA: 0x18213FEB0
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x213FEE0 Offset: 0x213F2E0 VA: 0x18213FEE0
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x213FDC0 Offset: 0x213F1C0 VA: 0x18213FDC0
	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140130 Offset: 0x213F530 VA: 0x182140130
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x21400E0 Offset: 0x213F4E0 VA: 0x1821400E0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x232A60 Offset: 0x231E60 VA: 0x180232A60 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x232A70 Offset: 0x231E70 VA: 0x180232A70 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x232B30 Offset: 0x231F30 VA: 0x180232B30 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x232DA0 Offset: 0x2321A0 VA: 0x180232DA0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x232AD0 Offset: 0x231ED0 VA: 0x180232AD0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x232C80 Offset: 0x232080 VA: 0x180232C80 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x232CE0 Offset: 0x2320E0 VA: 0x180232CE0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x232EF0 Offset: 0x2322F0 VA: 0x180232EF0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x232D40 Offset: 0x232140 VA: 0x180232D40 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x232F50 Offset: 0x232350 VA: 0x180232F50 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x232E00 Offset: 0x232200 VA: 0x180232E00 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x232C20 Offset: 0x232020 VA: 0x180232C20 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x232BA0 Offset: 0x231FA0 VA: 0x180232BA0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x232B90 Offset: 0x231F90 VA: 0x180232B90 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x232E60 Offset: 0x232260 VA: 0x180232E60 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 327
{	// Fields
	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x233090 Offset: 0x232490 VA: 0x180233090 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233190 Offset: 0x232590 VA: 0x180233190 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x2331B0 Offset: 0x2325B0 VA: 0x1802331B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E4EF0 Offset: 0x1E42F0 VA: 0x1801E4EF0 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2337B0 Offset: 0x232BB0 VA: 0x1802337B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2337E0 Offset: 0x232BE0 VA: 0x1802337E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x233770 Offset: 0x232B70 VA: 0x180233770 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140340 Offset: 0x213F740 VA: 0x182140340
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140370 Offset: 0x213F770 VA: 0x182140370
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x21403A0 Offset: 0x213F7A0 VA: 0x1821403A0
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140560 Offset: 0x213F960 VA: 0x182140560
	public static bool TryParse(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x21405A0 Offset: 0x213F9A0 VA: 0x1821405A0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x233230 Offset: 0x232630 VA: 0x180233230 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x233240 Offset: 0x232640 VA: 0x180233240 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x233300 Offset: 0x232700 VA: 0x180233300 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x233560 Offset: 0x232960 VA: 0x180233560 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2332A0 Offset: 0x2326A0 VA: 0x1802332A0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x233440 Offset: 0x232840 VA: 0x180233440 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2336B0 Offset: 0x232AB0 VA: 0x1802336B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2334A0 Offset: 0x2328A0 VA: 0x1802334A0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x233500 Offset: 0x232900 VA: 0x180233500 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x233710 Offset: 0x232B10 VA: 0x180233710 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2335C0 Offset: 0x2329C0 VA: 0x1802335C0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2333E0 Offset: 0x2327E0 VA: 0x1802333E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x233370 Offset: 0x232770 VA: 0x180233370 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x233360 Offset: 0x232760 VA: 0x180233360 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233620 Offset: 0x232A20 VA: 0x180233620 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 328
{	// Fields
	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x233830 Offset: 0x232C30 VA: 0x180233830 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233810 Offset: 0x232C10 VA: 0x180233810 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x233930 Offset: 0x232D30 VA: 0x180233930 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F59E0 Offset: 0x1F4DE0 VA: 0x1801F59E0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x2339C0 Offset: 0x232DC0 VA: 0x1802339C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233F90 Offset: 0x233390 VA: 0x180233F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x233F60 Offset: 0x233360 VA: 0x180233F60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x233F20 Offset: 0x233320 VA: 0x180233F20
	public string ToString(string format) { }

	// RVA: 0x233FC0 Offset: 0x2333C0 VA: 0x180233FC0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140820 Offset: 0x213FC20 VA: 0x182140820
	public static ulong Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x21407A0 Offset: 0x213FBA0 VA: 0x1821407A0
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x21407D0 Offset: 0x213FBD0 VA: 0x1821407D0
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140A60 Offset: 0x213FE60 VA: 0x182140A60
	public static bool TryParse(string s, out ulong result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2140A00 Offset: 0x213FE00 VA: 0x182140A00
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x2339D0 Offset: 0x232DD0 VA: 0x1802339D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x2339E0 Offset: 0x232DE0 VA: 0x1802339E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x233AA0 Offset: 0x232EA0 VA: 0x180233AA0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x233D10 Offset: 0x233110 VA: 0x180233D10 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x233A40 Offset: 0x232E40 VA: 0x180233A40 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x233BF0 Offset: 0x232FF0 VA: 0x180233BF0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x233E60 Offset: 0x233260 VA: 0x180233E60 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x233C50 Offset: 0x233050 VA: 0x180233C50 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x233EC0 Offset: 0x2332C0 VA: 0x180233EC0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x233CB0 Offset: 0x2330B0 VA: 0x180233CB0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x233D70 Offset: 0x233170 VA: 0x180233D70 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x233B90 Offset: 0x232F90 VA: 0x180233B90 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x233B10 Offset: 0x232F10 VA: 0x180233B10 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x233B00 Offset: 0x232F00 VA: 0x180233B00 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233DD0 Offset: 0x2331D0 VA: 0x180233DD0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

internal enum UInt16Enum // TypeDefIndex: 365
{	// Fields
	public ushort value__; // 0x0

}

internal enum UInt32Enum // TypeDefIndex: 366
{	// Fields
	public uint value__; // 0x0

}

internal enum UInt64Enum // TypeDefIndex: 367
{	// Fields
	public ulong value__; // 0x0

}

internal interface IConsoleDriver // TypeDefIndex: 368
{	// Properties
	public abstract ConsoleColor BackgroundColor { get; set; }
	public abstract int BufferWidth { get; }
	public abstract int CursorLeft { set; }
	public abstract int CursorTop { get; set; }
	public abstract ConsoleColor ForegroundColor { get; set; }
	public abstract bool KeyAvailable { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConsoleColor get_BackgroundColor();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_BackgroundColor(ConsoleColor value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_BufferWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_CursorLeft(int value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_CursorTop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_CursorTop(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ConsoleColor get_ForegroundColor();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_ForegroundColor(ConsoleColor value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_KeyAvailable();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ConsoleKeyInfo ReadKey(bool intercept);

}

internal interface TypeName : IEquatable<TypeName> // TypeDefIndex: 405
{	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DisplayName();

}

internal interface TypeIdentifier : TypeName, IEquatable<TypeName> // TypeDefIndex: 406
{	// Properties
	public abstract string InternalName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalName();

}

internal interface ModifierSpec // TypeDefIndex: 411
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type Resolve(Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StringBuilder Append(StringBuilder sb);

}

public struct UIntPtr : ISerializable // TypeDefIndex: 416
{	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x234190 Offset: 0x233590 VA: 0x180234190
	public void .ctor(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(void* value) { }

	// RVA: 0x234000 Offset: 0x233400 VA: 0x180234000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234120 Offset: 0x233520 VA: 0x180234120 Slot: 3
	public override string ToString() { }

	// RVA: 0x234090 Offset: 0x233490 VA: 0x180234090 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static ulong op_Explicit(UIntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static UIntPtr op_Explicit(void* value) { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0
	public static int get_Size() { }

	// RVA: 0x2140B30 Offset: 0x213FF30 VA: 0x182140B30
	private static void .cctor() { }

}

internal interface IResourceGroveler // TypeDefIndex: 483
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark);

}

public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 484
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();

}

public interface ICustomAttributeProvider // TypeDefIndex: 527
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);

}

public interface IReflectableType // TypeDefIndex: 530
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeInfo GetTypeInfo();

}

internal interface IAsyncLocal // TypeDefIndex: 775
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);

}

internal interface IThreadPoolWorkItem // TypeDefIndex: 805
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);

}

internal interface ITaskCompletionAction // TypeDefIndex: 867
{
// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 867
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

}

public interface IPermission : ISecurityEncodable // TypeDefIndex: 899
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);

}

public interface ISecurityEncodable // TypeDefIndex: 900
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityElement ToXml();

}

internal interface Tokenizer.ITokenReader // TypeDefIndex: 923
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read();

}

public interface IIdentity // TypeDefIndex: 928
{	// Properties
	public abstract string AuthenticationType { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AuthenticationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

}

public interface ICryptoTransform : IDisposable // TypeDefIndex: 967
{	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);

}

internal interface INativeCertificateHelper // TypeDefIndex: 1016
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(X509Certificate cert);

}

public interface IDeserializationCallback // TypeDefIndex: 1029
{
// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IDeserializationCallback // TypeDefIndex: 1029
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeserialization(object sender);

}

public interface IFormatterConverter // TypeDefIndex: 1030
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);

}

public interface IObjectReference // TypeDefIndex: 1031
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetRealObject(StreamingContext context);

}

public interface ISerializable // TypeDefIndex: 1032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);

}

public interface ISerializationSurrogate // TypeDefIndex: 1033
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);

}

public interface ISurrogateSelector // TypeDefIndex: 1034
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);

}

public interface ISafeSerializationData // TypeDefIndex: 1046
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CompleteDeserialization(object deserialized);

}

public interface IChannelInfo // TypeDefIndex: 1130
{	// Properties
	public abstract object[] ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] get_ChannelData();

}

public interface IEnvoyInfo // TypeDefIndex: 1131
{	// Properties
	public abstract IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink get_EnvoySinks();

}

public interface IRemotingTypeInfo // TypeDefIndex: 1132
{	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);

}

public interface ITrackingHandler // TypeDefIndex: 1157
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);

}

public interface ILease // TypeDefIndex: 1163
{	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime);

}

public interface ISponsor // TypeDefIndex: 1164
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan Renewal(ILease lease);

}

public interface IContextAttribute // TypeDefIndex: 1178
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);

}

public interface IContextProperty // TypeDefIndex: 1179
{	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);

}

public interface IContributeClientContextSink // TypeDefIndex: 1180
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);

}

public interface IContributeDynamicSink // TypeDefIndex: 1181
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDynamicMessageSink GetDynamicSink();

}

public interface IContributeEnvoySink // TypeDefIndex: 1182
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeObjectSink // TypeDefIndex: 1183
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeServerContextSink // TypeDefIndex: 1184
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);

}

public interface IDynamicMessageSink // TypeDefIndex: 1185
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);

}

public interface IDynamicProperty // TypeDefIndex: 1186
{	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

}

public interface IChannel // TypeDefIndex: 1194
{	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();

}

public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
{
// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);

}

public interface IChannelSender : IChannel // TypeDefIndex: 1197
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);

}

public interface IClientChannelSinkProvider // TypeDefIndex: 1198
{	// Properties
	public abstract IClientChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IClientChannelSinkProvider value);

}

public interface ISecurableChannel // TypeDefIndex: 1199
{	// Properties
	public abstract bool IsSecured { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_IsSecured(bool value);

}

public interface IServerChannelSinkProvider // TypeDefIndex: 1200
{	// Properties
	public abstract IServerChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IServerChannelSinkProvider value);

}

public interface IActivator // TypeDefIndex: 1206
{	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);

}

public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1207
{	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties();

}

internal interface IInternalMessage // TypeDefIndex: 1239
{	// Properties
	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Identity get_TargetIdentity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TargetIdentity(Identity value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Uri(string value);

}

public interface IMessage // TypeDefIndex: 1240
{	// Properties
	public abstract IDictionary Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary get_Properties();

}

public interface IMessageSink // TypeDefIndex: 1242
{
// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IMessageSink // TypeDefIndex: 1242
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);

}

public interface IMethodMessage : IMessage // TypeDefIndex: 1244
{
// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IMethodMessage : IMessage // TypeDefIndex: 1244
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum);

}

public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 1245
{	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();

}

public interface IAsyncStateMachine // TypeDefIndex: 1283
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);

}

public interface INotifyCompletion // TypeDefIndex: 1284
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCompleted(Action continuation);

}

public interface ICriticalNotifyCompletion : INotifyCompletion // TypeDefIndex: 1285
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UnsafeOnCompleted(Action continuation);

}

public interface ICustomMarshaler // TypeDefIndex: 1349
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();

}

public interface ICollection : IEnumerable // TypeDefIndex: 1397
{	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

}

public interface IComparer // TypeDefIndex: 1398
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(object x, object y);

}

public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1399
{	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object key);

}

public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1400
{	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();

}

public interface IEnumerable // TypeDefIndex: 1401
{	// Methods

	[DispIdAttribute] // RVA: 0xE91B0 Offset: 0xE85B0 VA: 0x1800E91B0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator GetEnumerator();

}

public interface IEnumerator // TypeDefIndex: 1402
{	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();

}

public interface IEqualityComparer // TypeDefIndex: 1403
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object x, object y);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(object obj);

}

public interface IHashCodeProvider // TypeDefIndex: 1404
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetHashCode(object obj);

}

public interface IList : ICollection, IEnumerable // TypeDefIndex: 1405
{	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);

}

public interface IStructuralComparable // TypeDefIndex: 1406
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object other, IComparer comparer);

}

public interface IStructuralEquatable // TypeDefIndex: 1407
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object other, IEqualityComparer comparer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(IEqualityComparer comparer);

}

public interface ICollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1478
{	// Properties
	public abstract int Count { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CopyTo(T[] array, int arrayIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Remove
	*/

}

public interface IComparer<T> // TypeDefIndex: 1479
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparer<object>.Compare
	*/

}

public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1480
{	// Properties
	public abstract TValue Item { get; set; }
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.TryGetValue
	*/

}

public interface IEnumerable<T> : IEnumerable // TypeDefIndex: 1481
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator<T> GetEnumerator();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerable<object>.GetEnumerator
	*/

}

public interface IEnumerator<T> : IDisposable, IEnumerator // TypeDefIndex: 1482
{	// Properties
	public abstract T Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Current();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerator<object>.get_Current
	*/

}

public interface IEqualityComparer<T> // TypeDefIndex: 1483
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.GetHashCode
	*/

}

public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1484
{	// Properties
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int IndexOf(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Insert(int index, T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.RemoveAt
	*/

}

public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1485
{	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyCollection<object>.get_Count
	*/

}

public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1486
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<object, object>.TryGetValue
	*/

}

public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1487
{	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/

}

internal sealed class UInt16TypeInfo : TraceLoggingTypeInfo<ushort> // TypeDefIndex: 1536
{	// Methods

	// RVA: 0x10E4EC0 Offset: 0x10E42C0 VA: 0x1810E4EC0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E4E60 Offset: 0x10E4260 VA: 0x1810E4E60 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort value) { }

	// RVA: 0x10E4F50 Offset: 0x10E4350 VA: 0x1810E4F50
	public void .ctor() { }

}

internal sealed class UInt32TypeInfo : TraceLoggingTypeInfo<uint> // TypeDefIndex: 1538
{	// Methods

	// RVA: 0x10E5140 Offset: 0x10E4540 VA: 0x1810E5140 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E50E0 Offset: 0x10E44E0 VA: 0x1810E50E0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint value) { }

	// RVA: 0x10E51D0 Offset: 0x10E45D0 VA: 0x1810E51D0
	public void .ctor() { }

}

internal sealed class UInt64TypeInfo : TraceLoggingTypeInfo<ulong> // TypeDefIndex: 1540
{	// Methods

	// RVA: 0x10E5410 Offset: 0x10E4810 VA: 0x1810E5410 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E53B0 Offset: 0x10E47B0 VA: 0x1810E53B0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong value) { }

	// RVA: 0x10E54F0 Offset: 0x10E48F0 VA: 0x1810E54F0
	public void .ctor() { }

}

internal sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr> // TypeDefIndex: 1542
{	// Methods

	// RVA: 0x10E57D0 Offset: 0x10E4BD0 VA: 0x1810E57D0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E5740 Offset: 0x10E4B40 VA: 0x1810E5740 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value) { }

	// RVA: 0x10E58E0 Offset: 0x10E4CE0 VA: 0x1810E58E0
	public void .ctor() { }

}

internal sealed class UInt16ArrayTypeInfo : TraceLoggingTypeInfo<ushort[]> // TypeDefIndex: 1550
{	// Methods

	// RVA: 0x10E4D90 Offset: 0x10E4190 VA: 0x1810E4D90 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E4D10 Offset: 0x10E4110 VA: 0x1810E4D10 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort[] value) { }

	// RVA: 0x10E4E20 Offset: 0x10E4220 VA: 0x1810E4E20
	public void .ctor() { }

}

internal sealed class UInt32ArrayTypeInfo : TraceLoggingTypeInfo<uint[]> // TypeDefIndex: 1552
{	// Methods

	// RVA: 0x10E5010 Offset: 0x10E4410 VA: 0x1810E5010 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E4F90 Offset: 0x10E4390 VA: 0x1810E4F90 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint[] value) { }

	// RVA: 0x10E50A0 Offset: 0x10E44A0 VA: 0x1810E50A0
	public void .ctor() { }

}

internal sealed class UInt64ArrayTypeInfo : TraceLoggingTypeInfo<ulong[]> // TypeDefIndex: 1554
{	// Methods

	// RVA: 0x10E5290 Offset: 0x10E4690 VA: 0x1810E5290 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E5210 Offset: 0x10E4610 VA: 0x1810E5210 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong[] value) { }

	// RVA: 0x10E5370 Offset: 0x10E4770 VA: 0x1810E5370
	public void .ctor() { }

}

internal sealed class UIntPtrArrayTypeInfo : TraceLoggingTypeInfo<UIntPtr[]> // TypeDefIndex: 1556
{	// Methods

	// RVA: 0x10E55F0 Offset: 0x10E49F0 VA: 0x1810E55F0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E5530 Offset: 0x10E4930 VA: 0x1810E5530 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr[] value) { }

	// RVA: 0x10E5700 Offset: 0x10E4B00 VA: 0x1810E5700
	public void .ctor() { }

}

public interface ICertificateValidator // TypeDefIndex: 1738
{	// Properties
	public abstract MonoTlsSettings Settings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoTlsSettings get_Settings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509CertificateCollection certificates);

}

internal interface ICertificateValidator2 : ICertificateValidator // TypeDefIndex: 1739
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509Certificate leaf, X509Chain chain);

}

public interface IMonoSslStream : IDisposable // TypeDefIndex: 1742
{	// Properties
	public abstract bool IsAuthenticated { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; }
	public abstract AuthenticatedStream AuthenticatedStream { get; }
	public abstract int ReadTimeout { get; }
	public abstract int WriteTimeout { get; }
	public abstract X509Certificate InternalLocalCertificate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void EndAuthenticateAsServer(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int EndRead(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void EndWrite(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsAuthenticated();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract AuthenticatedStream get_AuthenticatedStream();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_ReadTimeout();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_WriteTimeout();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract X509Certificate get_InternalLocalCertificate();

}

internal interface IDtdInfo // TypeDefIndex: 1844
{	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlQualifiedName get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InternalDtdSubset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_HasDefaultAttributes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDtdEntityInfo LookupEntity(string name);

}

internal interface IDtdAttributeListInfo // TypeDefIndex: 1845
{	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();

}

internal interface IDtdAttributeInfo // TypeDefIndex: 1846
{	// Properties
	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_LinePosition();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNonCDataType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsXmlAttribute();

}

internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 1847
{	// Properties
	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DefaultValueExpanded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_DefaultValueTyped();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ValueLineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_ValueLinePosition();

}

internal interface IDtdEntityInfo // TypeDefIndex: 1848
{	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();

}

internal interface IDtdParser // TypeDefIndex: 1849
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);

}

internal interface IDtdParserAdapter // TypeDefIndex: 1850
{	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Uri get_BaseUri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract char[] get_ParsingBuffer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ParsingBufferLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CurrentPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPosition(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_LineNo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LineStartPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsEof();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_EntityStackLength();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsEntityEolNormalized();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ReadData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnNewLine(int pos);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ParsePI(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ParseComment(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool PushExternalSubset(string systemId, string publicId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Throw(Exception e);

}

internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 1851
{	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();

}

internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1852
{	// Properties
	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_V1CompatibilityMode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Normalization();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Namespaces();

}

internal interface IValidationEventHandling // TypeDefIndex: 1854
{	// Properties
	public abstract object EventHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_EventHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity);

}

public interface IXmlLineInfo // TypeDefIndex: 1985
{	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();

}

public interface IXmlNamespaceResolver // TypeDefIndex: 1988
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string LookupNamespace(string prefix);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string LookupPrefix(string namespaceName);

}

public interface IXmlSerializable // TypeDefIndex: 2054
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);

}

public interface IXmlTextParser // TypeDefIndex: 2055
{	// Properties
	public abstract bool Normalized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Normalized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Normalized(bool value);

}

public interface IXmlSchemaInfo // TypeDefIndex: 2258
{	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();

}

public interface IChangeTracking // TypeDefIndex: 2711
{
// Namespace: System.ComponentModel
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 2710

// Namespace: System.ComponentModel
public interface IChangeTracking // TypeDefIndex: 2711
	// Properties
	public abstract bool IsChanged { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AcceptChanges();

}

public interface IComponent : IDisposable // TypeDefIndex: 2712
{	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();

}

public interface IContainer : IDisposable // TypeDefIndex: 2713
{	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Remove(IComponent component);

}

public interface ICustomTypeDescriptor // TypeDefIndex: 2714
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetPropertyOwner(PropertyDescriptor pd);

}

public interface IExtenderProvider // TypeDefIndex: 2715
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanExtend(object extendee);

}

public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 2716
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RejectChanges();

}

public interface ISite : IServiceProvider // TypeDefIndex: 2717
{	// Properties
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Name();

}

public interface ISynchronizeInvoke // TypeDefIndex: 2718
{	// Properties
	public abstract bool InvokeRequired { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_InvokeRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);

}

public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
{
// Namespace: 
private sealed class TypeDescriptor.TypeDescriptorInterface // TypeDefIndex: 2768

// Namespace: System.ComponentModel
public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173C120 Offset: 0x173B520 VA: 0x18173C120 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173C010 Offset: 0x173B410 VA: 0x18173C010 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173BFB0 Offset: 0x173B3B0 VA: 0x18173BFB0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173C090 Offset: 0x173B490 VA: 0x18173C090 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 2770
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173C2E0 Offset: 0x173B6E0 VA: 0x18173C2E0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173C1E0 Offset: 0x173B5E0 VA: 0x18173C1E0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173C180 Offset: 0x173B580 VA: 0x18173C180 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173C260 Offset: 0x173B660 VA: 0x18173C260 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 2771
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173C4B0 Offset: 0x173B8B0 VA: 0x18173C4B0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173C340 Offset: 0x173B740 VA: 0x18173C340 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173C3C0 Offset: 0x173B7C0 VA: 0x18173C3C0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173C420 Offset: 0x173B820 VA: 0x18173C420 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public interface IComponentChangeService // TypeDefIndex: 2780
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnComponentChanging(object component, MemberDescriptor member);

}

public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
{
// Namespace: System.ComponentModel.Design
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
	// Properties
	public abstract IComponent RootComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_RootComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDesigner GetDesigner(IComponent component);

}

public interface IDictionaryService // TypeDefIndex: 2783
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object key, object value);

}

public interface IExtenderListService // TypeDefIndex: 2784
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExtenderProvider[] GetExtenderProviders();

}

public interface ITypeDescriptorFilterService // TypeDefIndex: 2786
{
// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 2786
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);

}

internal interface IFileWatcher // TypeDefIndex: 2849
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartDispatching(FileSystemWatcher fsw);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopDispatching(FileSystemWatcher fsw);

}

public interface IAuthenticationModule // TypeDefIndex: 2879
{	// Properties
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_AuthenticationType();

}

public interface ICertificatePolicy // TypeDefIndex: 2880
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);

}

public interface ICredentials // TypeDefIndex: 2881
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(Uri uri, string authType);

}

public interface IWebRequestCreate // TypeDefIndex: 2885
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebRequest Create(Uri uri);

}

internal interface ICloseEx // TypeDefIndex: 2918
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseEx(CloseExState closeState);

}

public interface IWebProxy // TypeDefIndex: 2952
{	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();

}

internal interface IWebConnectionState // TypeDefIndex: 3013
{	// Properties
	public abstract WebConnectionGroup Group { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebConnectionGroup get_Group();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TrySetBusy();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetIdle();

}

public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3224
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<object>.CreateOrderedEnumerable<object>
	*/

}

public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3225
{	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<object, object>.get_Key
	*/

}

public interface IJob // TypeDefIndex: 3298
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute();

}

public interface IJobParallelFor // TypeDefIndex: 3302
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index);

}

public interface ILogger : ILogHandler // TypeDefIndex: 3456
{	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_logEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogFormat(LogType logType, string format, object[] args);

}

public interface ILogHandler // TypeDefIndex: 3457
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);

}

internal interface IPlayerEditorConnectionNative // TypeDefIndex: 3474
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();

}

public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
{
// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0xC8CC0 Offset: 0xC80C0 VA: 0x1800C8CC0
[AttributeUsageAttribute] // RVA: 0xC8CC0 Offset: 0xC80C0 VA: 0x1800C8CC0
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 3547

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDeserialize();

}

public interface IJobParallelForTransform // TypeDefIndex: 3585
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index, TransformAccess transform);

}

public interface INotificationReceiver // TypeDefIndex: 3862
{
// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface INotificationReceiver // TypeDefIndex: 3862
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);

}

public interface IPlayableBehaviour // TypeDefIndex: 3863
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);

}

public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 3896
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TickRealtimeProbes();

}

internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
{
// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 3937

// Namespace: UnityEngine
internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
	// Properties
	public abstract IntPtr ptr { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_ptr(IntPtr value);

}

public struct UICharInfo // TypeDefIndex: 3956
{	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8

}

public struct UILineInfo // TypeDefIndex: 3957
{	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC

}

public struct UIVertex // TypeDefIndex: 3958
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv0; // 0x2C
	public Vector2 uv1; // 0x34
	public Vector2 uv2; // 0x3C
	public Vector2 uv3; // 0x44
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x2307500 Offset: 0x2306900 VA: 0x182307500
	private static void .cctor() { }

}

public interface IEnlistmentNotification // TypeDefIndex: 3978
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rollback(Enlistment enlistment);

}

public interface IPromotableSinglePhaseNotification // TypeDefIndex: 3979
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rollback(SinglePhaseEnlistment singlePhaseEnlistment);

}

internal interface IFilter // TypeDefIndex: 4262
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);

}

public interface IDataReader : IDisposable, IDataRecord // TypeDefIndex: 4269
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DataTable GetSchemaTable();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Read();

}

public interface IDataRecord // TypeDefIndex: 4270
{	// Properties
	public abstract int FieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Item(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetDataTypeName(int i);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type GetFieldType(int i);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetValues(object[] values);

}

public interface IDbDataAdapter // TypeDefIndex: 4272
{
// Namespace: System.Data
public interface IDbDataAdapter // TypeDefIndex: 4272
	// Properties
	public abstract IDbCommand SelectCommand { get; }
	public abstract IDbCommand InsertCommand { get; set; }
	public abstract IDbCommand UpdateCommand { get; set; }
	public abstract IDbCommand DeleteCommand { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDbCommand get_SelectCommand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDbCommand get_InsertCommand();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_InsertCommand(IDbCommand value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IDbCommand get_UpdateCommand();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_UpdateCommand(IDbCommand value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDbCommand get_DeleteCommand();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_DeleteCommand(IDbCommand value);

}

public interface INullable // TypeDefIndex: 4336
{	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();

}

internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 4433
{	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x123D040 Offset: 0x123C440 VA: 0x18123D040
	public void .ctor(DataColumn column) { }

	// RVA: 0x123BF80 Offset: 0x123B380 VA: 0x18123BF80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123C820 Offset: 0x123BC20 VA: 0x18123C820 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123C700 Offset: 0x123BB00 VA: 0x18123C700 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123C980 Offset: 0x123BD80 VA: 0x18123C980 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123CBF0 Offset: 0x123BFF0 VA: 0x18123CBF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123CCB0 Offset: 0x123C0B0 VA: 0x18123CCB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123CEF0 Offset: 0x123C2F0 VA: 0x18123CEF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123CD70 Offset: 0x123C170 VA: 0x18123CD70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123CA60 Offset: 0x123BE60 VA: 0x18123CA60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123C900 Offset: 0x123BD00 VA: 0x18123C900 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123CC70 Offset: 0x123C070 VA: 0x18123CC70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123CAD0 Offset: 0x123BED0 VA: 0x18123CAD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123CE50 Offset: 0x123C250 VA: 0x18123CE50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 4434
{	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x123E1B0 Offset: 0x123D5B0 VA: 0x18123E1B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123D130 Offset: 0x123C530 VA: 0x18123D130 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123D9B0 Offset: 0x123CDB0 VA: 0x18123D9B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123D890 Offset: 0x123CC90 VA: 0x18123D890 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123DB10 Offset: 0x123CF10 VA: 0x18123DB10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123DD70 Offset: 0x123D170 VA: 0x18123DD70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123DE30 Offset: 0x123D230 VA: 0x18123DE30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123E070 Offset: 0x123D470 VA: 0x18123E070 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123DEF0 Offset: 0x123D2F0 VA: 0x18123DEF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123DBE0 Offset: 0x123CFE0 VA: 0x18123DBE0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123DA90 Offset: 0x123CE90 VA: 0x18123DA90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123DDF0 Offset: 0x123D1F0 VA: 0x18123DDF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123DC50 Offset: 0x123D050 VA: 0x18123DC50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123DFD0 Offset: 0x123D3D0 VA: 0x18123DFD0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 4435
{	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x123F3F0 Offset: 0x123E7F0 VA: 0x18123F3F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x123E2A0 Offset: 0x123D6A0 VA: 0x18123E2A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x123EB80 Offset: 0x123DF80 VA: 0x18123EB80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x123EA60 Offset: 0x123DE60 VA: 0x18123EA60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x123ED30 Offset: 0x123E130 VA: 0x18123ED30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x123EFA0 Offset: 0x123E3A0 VA: 0x18123EFA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x123F060 Offset: 0x123E460 VA: 0x18123F060 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x123F2A0 Offset: 0x123E6A0 VA: 0x18123F2A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x123F120 Offset: 0x123E520 VA: 0x18123F120 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x123EE10 Offset: 0x123E210 VA: 0x18123EE10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x123ECB0 Offset: 0x123E0B0 VA: 0x18123ECB0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x123F020 Offset: 0x123E420 VA: 0x18123F020 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x123EE80 Offset: 0x123E280 VA: 0x18123EE80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x123F200 Offset: 0x123E600 VA: 0x18123F200 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

public interface IJobParticleSystem // TypeDefIndex: 4546
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(ParticleSystemJobData jobData);

}

public interface IFocusRing // TypeDefIndex: 4588
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);

}

public interface ITransform // TypeDefIndex: 4593
{	// Properties
	public abstract Matrix4x4 matrix { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Matrix4x4 get_matrix();

}

public interface IPanel : IDisposable // TypeDefIndex: 4599
{	// Properties
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	public abstract FocusController focusController { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement get_visualTree();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract EventDispatcher get_dispatcher();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ContextType get_contextType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract FocusController get_focusController();

}

internal static class UIElementsRuntimeUtility // TypeDefIndex: 4608
{	// Fields
	private static EventDispatcher s_RuntimeDispatcher; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static List<Panel> panelsIteration; // 0x10
	internal static readonly string s_RepaintProfilerMarkerName; // 0x18
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECFEE0 Offset: 0xECF2E0 VA: 0x180ECFEE0
	public static void RepaintOverlayPanels() { }

	// RVA: 0xED0340 Offset: 0xECF740 VA: 0x180ED0340
	private static void .cctor() { }

}

internal static class UIElementsUtility // TypeDefIndex: 4609
{	// Fields
	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static readonly string s_RepaintProfilerMarkerName; // 0x28
	internal static readonly string s_EventProfilerMarkerName; // 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x40

	// Methods

	// RVA: 0xED1DD0 Offset: 0xED11D0 VA: 0x180ED1DD0
	private static void .cctor() { }

	// RVA: 0xED1970 Offset: 0xED0D70 VA: 0x180ED1970
	internal static void MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0xED1BF0 Offset: 0xED0FF0 VA: 0x180ED1BF0
	private static void TakeCapture() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void ReleaseCapture() { }

	// RVA: 0xED1A40 Offset: 0xED0E40 VA: 0x180ED1A40
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0xED1B70 Offset: 0xED0F70 VA: 0x180ED1B70
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0xED06C0 Offset: 0xECFAC0 VA: 0x180ED06C0
	private static void CleanupRoots() { }

	// RVA: 0xED1450 Offset: 0xED0850 VA: 0x180ED1450
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0xED0440 Offset: 0xECF840 VA: 0x180ED0440
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0xED1510 Offset: 0xED0910 VA: 0x180ED1510
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0xED0E40 Offset: 0xED0240 VA: 0x180ED0E40
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0xED0760 Offset: 0xECFB60 VA: 0x180ED0760
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0xED0EC0 Offset: 0xED02C0 VA: 0x180ED0EC0
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0xED1750 Offset: 0xED0B50 VA: 0x180ED1750
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0xED18C0 Offset: 0xED0CC0 VA: 0x180ED18C0
	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }

}

internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 4620
{	// Properties
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProfilerMarker get_profilerMarker();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

}

public interface IEventHandler // TypeDefIndex: 4649
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendEvent(EventBase e);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void HandleEvent(EventBase evt);

}

internal interface IEventDispatchingStrategy // TypeDefIndex: 4657
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanDispatchEvent(EventBase evt);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DispatchEvent(EventBase evt, IPanel panel);

}

public interface IMouseEvent // TypeDefIndex: 4668
{	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract int clickCount { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventModifiers get_modifiers();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2 get_mouseDelta();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_clickCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_button();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_pressedButtons();

}

internal interface IMouseEventInternal // TypeDefIndex: 4669
{	// Properties
	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderMouse { get; set; }
	public abstract IPointerEvent sourcePointerEvent { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_triggeredByOS();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_triggeredByOS(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_recomputeTopElementUnderMouse();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_recomputeTopElementUnderMouse(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPointerEvent get_sourcePointerEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_sourcePointerEvent(IPointerEvent value);

}

public interface IPointerEvent // TypeDefIndex: 4689
{	// Properties
	public abstract int pointerId { get; }
	public abstract string pointerType { get; }
	public abstract bool isPrimary { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }
	public abstract Vector3 position { get; }
	public abstract Vector3 localPosition { get; }
	public abstract Vector3 deltaPosition { get; }
	public abstract float deltaTime { get; }
	public abstract int clickCount { get; }
	public abstract float pressure { get; }
	public abstract float tangentialPressure { get; }
	public abstract float altitudeAngle { get; }
	public abstract float azimuthAngle { get; }
	public abstract float twist { get; }
	public abstract Vector2 radius { get; }
	public abstract Vector2 radiusVariance { get; }
	public abstract EventModifiers modifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_pointerId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_pointerType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isPrimary();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_button();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_pressedButtons();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector3 get_localPosition();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector3 get_deltaPosition();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_deltaTime();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_clickCount();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_pressure();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_tangentialPressure();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_altitudeAngle();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_azimuthAngle();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_twist();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Vector2 get_radius();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector2 get_radiusVariance();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract EventModifiers get_modifiers();

}

internal interface IPointerEventInternal // TypeDefIndex: 4690
{	// Properties
	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderPointer { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_triggeredByOS();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_triggeredByOS(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_recomputeTopElementUnderPointer();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_recomputeTopElementUnderPointer(bool value);

}

public interface IResolvedStyle // TypeDefIndex: 4707
{	// Properties
	public abstract Visibility visibility { get; }
	public abstract DisplayStyle display { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Visibility get_visibility();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DisplayStyle get_display();

}

internal interface IStyleValue<T> // TypeDefIndex: 4716
{	// Properties
	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StyleKeyword get_keyword();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_keyword
	*/

}

public interface ICanvasRaycastFilter // TypeDefIndex: 4730
{
// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 4730
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);

}

public static class UISystemProfilerApi // TypeDefIndex: 4738
{	// Methods

	// RVA: 0x2305160 Offset: 0x2304560 VA: 0x182305160
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x23051A0 Offset: 0x23045A0 VA: 0x1823051A0
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x2305110 Offset: 0x2304510 VA: 0x182305110
	public static void AddMarker(string name, Object obj) { }

}

public enum UISystemProfilerApi.SampleType // TypeDefIndex: 4739
{	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;

}

public interface IImmutableStack<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 4797
{	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IImmutableStack<T> Push(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IImmutableStack<T> Pop();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract T Peek();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Peek
	*/

}

public interface ILinkedListNode<T> // TypeDefIndex: 4803
{	// Properties
	public abstract T next { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_next();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.get_next
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_next(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.set_next
	*/

}

public interface IMinHeapNode<T> // TypeDefIndex: 4805
{	// Properties
	public abstract T child { get; set; }
	public abstract int order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_child();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_child
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_child(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.set_child
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_order();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_order
	*/

}

public interface Pool.IPooled // TypeDefIndex: 4836
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EnterPool();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LeavePool();

}

public interface Pool.ICollection // TypeDefIndex: 4837
{	// Properties
	public abstract long ItemsInStack { get; }
	public abstract long ItemsInUse { get; }
	public abstract long ItemsCreated { get; }
	public abstract long ItemsTaken { get; }
	public abstract long ItemsSpilled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_ItemsInStack();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract long get_ItemsInUse();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract long get_ItemsCreated();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long get_ItemsTaken();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_ItemsSpilled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Add(object obj);

}

internal interface ISQLiteSchemaExtensions // TypeDefIndex: 4857
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BuildTempSchema(SqliteConnection cnn);

}

public interface ICanvasElement // TypeDefIndex: 4909
{	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();

}

public interface IClipper // TypeDefIndex: 4914
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();

}

public interface IClippable // TypeDefIndex: 4915
{	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

}

public interface DefaultControls.IFactoryControls // TypeDefIndex: 4918
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);

}

internal interface IGraphicEnabledDisabled // TypeDefIndex: 4935
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();

}

public interface IMask // TypeDefIndex: 4936
{	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();

}

public interface IMaskable // TypeDefIndex: 4937
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();

}

public interface ILayoutElement // TypeDefIndex: 4971
{	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();

}

public interface ILayoutController // TypeDefIndex: 4972
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();

}

public interface ILayoutIgnorer // TypeDefIndex: 4975
{
// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 4974

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 4975
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();

}

public interface IMaterialModifier // TypeDefIndex: 4988
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);

}

public interface IVertexModifier // TypeDefIndex: 5032
{	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7FC70 Offset: 0x7F070 VA: 0x18007FC70
	[ObsoleteAttribute] // RVA: 0x7FC70 Offset: 0x7F070 VA: 0x18007FC70
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);

}

public interface IMeshModifier // TypeDefIndex: 5033
{	// Methods

	[ObsoleteAttribute] // RVA: 0x7FD90 Offset: 0x7F190 VA: 0x18007FD90
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);

}

internal interface ITweenValue // TypeDefIndex: 5038
{	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();

}

public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054
{
// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);

}

public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 5055
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);

}

public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 5056
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);

}

public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 5057
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);

}

public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 5058
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);

}

public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 5059
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);

}

public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 5060
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);

}

public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 5061
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);

}

public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 5062
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);

}

public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 5063
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);

}

public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 5064
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);

}

public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 5065
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);

}

public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 5066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);

}

public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 5067
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);

}

public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 5068
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);

}

public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 5069
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);

}

public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 5070
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);

}

public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 5095
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x10C9CC0 Offset: 0x10C90C0 VA: 0x1810C9CC0 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x10C9CD0 Offset: 0x10C90D0 VA: 0x1810C9CD0 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

internal interface ICallbackData // TypeDefIndex: 5102
{	// Properties
	public abstract CallbackType CallbackType { get; }
	public abstract int DataSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CallbackType get_CallbackType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_DataSize();

}

public interface IConnectionManager // TypeDefIndex: 5180
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnecting(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnected(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel);

}

public interface ISocketManager // TypeDefIndex: 5181
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnecting(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnected(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel);

}

internal interface ICommandCenterListener // TypeDefIndex: 5633
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCommandCenterUpdated();

}

public interface IAchievement // TypeDefIndex: 5686
{	// Properties
	public abstract string Key { get; }
	public abstract bool IsUnlocked { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsUnlocked();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Unlock();

}

public interface IAuthTicket : IDisposable // TypeDefIndex: 5687
{	// Properties
	public abstract string Token { get; }
	public abstract byte[] Data { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Token();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_Data();

}

public interface IDownloadableContent // TypeDefIndex: 5688
{	// Properties
	public abstract int AppId { get; }
	public abstract bool IsInstalled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_AppId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsInstalled();

}

public interface IPlatformHooks // TypeDefIndex: 5689
{	// Properties
	public abstract uint SteamAppId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint get_SteamAppId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Abort();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnItemDefinitionsChanged();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnInventoryChanged(IPlayerInventory inventory);

}

public interface IPlatformService // TypeDefIndex: 5690
{	// Properties
	public abstract bool IsValid { get; }
	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract string Country { get; }
	public abstract string Language { get; }
	public abstract string Version { get; }
	public abstract string Branch { get; }
	public abstract IEnumerable<IPlayerInfo> Friends { get; }
	public abstract IReadOnlyList<ServerInfo> FavoriteServers { get; }
	public abstract uint OptimalSampleRate { get; }
	public abstract bool VoiceRecord { get; set; }
	public abstract bool HasVoiceData { get; }
	public abstract IReadOnlyList<IPlayerItemDefinition> ItemDefinitions { get; }
	public abstract IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(IPlatformHooks hooks);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ulong get_UserId();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Country();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Language();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Branch();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IAuthTicket GetAuthSessionTicket();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Task<IAuthTicket> GetAuthSessionTicketAsync();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IEnumerable<IPlayerInfo> get_Friends();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IPlayerInfo GetPlayerInformation(ulong userId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Texture2D GetAvatarTexture(ulong userId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IServerQuery CreateServerQuery(ServerQuerySet querySet);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IServerQuery CreateServerQuery(IEnumerable<string> endpoints);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AddServerToHistory(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void RemoveServerFromHistory(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IReadOnlyList<ServerInfo> get_FavoriteServers();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void AddServerToFavorites(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void RemoveServerFromFavorites(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string FilterChat(ulong userId, string message);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string FilterName(ulong userId, string name);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string FilterGeneric(string text);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract uint get_OptimalSampleRate();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool get_VoiceRecord();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_VoiceRecord(bool value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool get_HasVoiceData();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract byte[] GetCompressedVoiceData();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int DecompressVoiceData(byte[] data, MemoryStream outputStream);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void RefreshItemDefinitions();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IPlayerItemDefinition GetItemDefinition(int definitionId);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IReadOnlyList<IPlayerItem> get_Items();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void RefreshItems();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract Task<IPlayerInventory> RefreshAndGetItems();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract string FormatPrice(int price);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IDownloadableContent GetDownloadableContent(int appId);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IWorkshopContent GetWorkshopContent(ulong workshopId);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void ClearRichPresence();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string GetRichPresence(string key);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void SetRichPresence(string key, string value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IAchievement GetAchievement(string key);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract void RequestCurrentStats();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract long GetGlobalStatInt(string key);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract long GetPlayerStatInt(string key);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void SetPlayerStatInt(string key, long value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract double GetGlobalStatFloat(string key);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract double GetPlayerStatFloat(string key);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void SetPlayerStatFloat(string key, double value);

}

public interface IPlayerInfo // TypeDefIndex: 5691
{	// Properties
	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract bool IsOnline { get; }
	public abstract bool IsMe { get; }
	public abstract bool IsFriend { get; }
	public abstract bool IsPlayingThisGame { get; }
	public abstract string ServerEndpoint { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ulong get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsOnline();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsMe();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsFriend();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsPlayingThisGame();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_ServerEndpoint();

}

public interface IPlayerInventory : IDisposable // TypeDefIndex: 5692
{	// Properties
	public abstract IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool BelongsTo(ulong userId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IReadOnlyList<IPlayerItem> get_Items();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte[] Serialize();

}

public interface IPlayerItem // TypeDefIndex: 5693
{	// Properties
	public abstract int DefinitionId { get; }
	public abstract int Quantity { get; }
	public abstract DateTimeOffset Acquired { get; }
	public abstract ulong WorkshopId { get; }
	public abstract string ItemShortName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DefinitionId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Quantity();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DateTimeOffset get_Acquired();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ItemShortName();

}

public interface IPlayerItemDefinition : IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5694
{	// Properties
	public abstract int DefinitionId { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string Type { get; }
	public abstract string IconUrl { get; }
	public abstract int LocalPrice { get; }
	public abstract string LocalPriceFormatted { get; }
	public abstract string PriceCategory { get; }
	public abstract bool IsGenerator { get; }
	public abstract bool IsMarketable { get; }
	public abstract string StoreTags { get; }
	public abstract string ItemShortName { get; }
	public abstract ulong WorkshopId { get; }
	public abstract ulong WorkshopDownload { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DefinitionId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Type();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_IconUrl();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_LocalPrice();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_LocalPriceFormatted();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PriceCategory();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsGenerator();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsMarketable();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_StoreTags();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_ItemShortName();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ulong get_WorkshopDownload();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<PlayerItemRecipe> GetRecipesContainingThis();

}

public interface IServerQuery : IDisposable // TypeDefIndex: 5696
{	// Properties
	public abstract ServerQuerySet QuerySet { get; }
	public abstract IReadOnlyList<ServerInfo> Servers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ServerQuerySet get_QuerySet();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IReadOnlyList<ServerInfo> get_Servers();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OnServerFound(Action<ServerInfo> value);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OnServerFound(Action<ServerInfo> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddFilter(string key, string value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Task RunQueryAsync(double timeoutInSeconds);

}

public interface IWorkshopContent // TypeDefIndex: 5697
{	// Properties
	public abstract ulong WorkshopId { get; }
	public abstract string Title { get; }
	public abstract string Description { get; }
	public abstract IEnumerable<string> Tags { get; }
	public abstract string Url { get; }
	public abstract string PreviewImageUrl { get; }
	public abstract ulong OwnerId { get; }
	public abstract IPlayerInfo Owner { get; }
	public abstract bool IsInstalled { get; }
	public abstract bool IsDownloadPending { get; }
	public abstract bool IsDownloading { get; }
	public abstract string Directory { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Title();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<string> get_Tags();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Url();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_PreviewImageUrl();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ulong get_OwnerId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IPlayerInfo get_Owner();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsInstalled();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsDownloadPending();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsDownloading();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Directory();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool Download();

}

public interface IArrayPool<T> // TypeDefIndex: 5871
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Return
	*/

}

public interface IJsonLineInfo // TypeDefIndex: 5883
{	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();

}

internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5947
{	// Properties
	public abstract object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();

}

internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5950
{	// Properties
	public abstract object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();

}

public interface ITraceWriter // TypeDefIndex: 5976
{
// Namespace: Newtonsoft.Json.Serialization
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface ITraceWriter // TypeDefIndex: 5976
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);

}

public interface IContractResolver // TypeDefIndex: 6003
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract JsonContract ResolveContract(Type type);

}

public interface IValueProvider // TypeDefIndex: 6004
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(object target, object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);

}

public interface IReferenceResolver // TypeDefIndex: 6017
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ResolveReference(object context, string reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetReference(object context, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsReferenced(object context, object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddReference(object context, string reference, object value);

}

internal interface IXmlDocument : IXmlNode // TypeDefIndex: 6116
{	// Properties
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();

}

internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 6117
{	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; }
	public abstract string Standalone { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Standalone();

}

internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 6118
{	// Properties
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();

}

internal interface IXmlElement : IXmlNode // TypeDefIndex: 6119
{	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();

}

internal interface IXmlNode // TypeDefIndex: 6120
{	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract List<IXmlNode> ChildNodes { get; }
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object get_WrappedNode();

}

public interface IProto // TypeDefIndex: 6279
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void WriteToStream(Stream stream);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadFromStream(Stream stream, int size, bool isDelta = False);

}

public interface ICustomMaterialReplacer // TypeDefIndex: 6573
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Replace(Material[] find, Material[] replace);

}

public interface IPrefabPreProcess // TypeDefIndex: 6578
{
// Namespace: 
public interface IServerComponent // TypeDefIndex: 6576

// Namespace: 
public interface IClientComponent // TypeDefIndex: 6577

// Namespace: 
public interface IPrefabPreProcess // TypeDefIndex: 6578
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabPostProcess // TypeDefIndex: 6579
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabProcessor // TypeDefIndex: 6580
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RemoveComponent(Component component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void NominateForDeletion(GameObject obj);

}

public interface IServerComponentEx // TypeDefIndex: 6581
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreServerComponentCull(IPrefabProcessor p);

}

public interface IClientComponentEx // TypeDefIndex: 6582
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreClientComponentCull(IPrefabProcessor p);

}

public interface IPropRenderNotify // TypeDefIndex: 6583
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreRender();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PostRender();

}

public interface IEntity // TypeDefIndex: 6622
{	// Properties
	public abstract bool IsDestroyed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDestroyed();

}

public interface INetworkCryptocraphy // TypeDefIndex: 6678
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsEnabledIncoming(Connection connection);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsEnabledOutgoing(Connection connection);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Encrypt(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Decrypt(Connection connection, MemoryStream stream, int offset);

}

public interface IDemoHeader // TypeDefIndex: 6681
{	// Properties
	public abstract long Length { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Length(long value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Write(BinaryWriter writer);

}

public interface IClientCallback // TypeDefIndex: 6686
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkMessage(Message message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnClientDisconnected(string reason);

}

public interface NetworkHandler // TypeDefIndex: 6699
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkSubscribersEnter(List<Connection> connections);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnNetworkSubscribersLeave(List<Connection> connections);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnNetworkGroupChange();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnNetworkGroupLeave(Group group);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnNetworkGroupEnter(Group group);

}

public interface IServerCallback // TypeDefIndex: 6702
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkMessage(Message message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool OnUnconnectedMessage(int type, NetRead read, uint ip, int port);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(string reason, Connection connection);

}

public interface Provider // TypeDefIndex: 6706
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGroupAdded(Group group);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsInside(Group group, Vector3 vPos);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Group GetGroup(Vector3 vPos);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetVisibleFromFar(Group group, List<Group> groups);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetVisibleFromNear(Group group, List<Group> groups);

}

public interface ILocalize // TypeDefIndex: 6720
{	// Properties
	public abstract string LanguageToken { get; }
	public abstract string LanguageEnglish { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LanguageToken();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LanguageEnglish();

}

internal interface ITweenValue // TypeDefIndex: 6749
{	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();

}

public interface ITextElement // TypeDefIndex: 6825
{	// Properties
	public abstract Material sharedMaterial { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material get_sharedMaterial();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Rebuild(CanvasUpdate update);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInstanceID();

}

public interface ConsoleSystem.IConsoleCommand // TypeDefIndex: 6882
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Call(ConsoleSystem.Arg arg);

}

public interface ConsoleSystem.IConsoleButton // TypeDefIndex: 6883
{	// Properties
	public abstract bool IsPressed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsPressed();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IsPressed(bool value);

}

public interface IHandler : IDisposable // TypeDefIndex: 6909
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Receive(Span<byte> newData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract MemoryBuffer CreateHandshake();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MemoryBuffer FrameText(string text);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MemoryBuffer FrameClose(ushort code);

}

public interface ISocket // TypeDefIndex: 6910
{	// Properties
	public abstract bool Connected { get; }
	public abstract IPAddress RemoteIpAddress { get; }
	public abstract int RemotePort { get; }
	public abstract Stream Stream { get; }
	public abstract bool NoDelay { set; }
	public abstract EndPoint LocalEndPoint { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Connected();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IPAddress get_RemoteIpAddress();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_RemotePort();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Stream get_Stream();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_NoDelay(bool value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EndPoint get_LocalEndPoint();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Bind(EndPoint ipLocal);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Listen(int backlog);

}

public interface IWebSocketConnection // TypeDefIndex: 6912
{	// Properties
	public abstract Action OnOpen { set; }
	public abstract Action OnClose { get; set; }
	public abstract Action<string> OnMessage { get; set; }
	public abstract BinaryDataHandler OnBinary { get; }
	public abstract BinaryDataHandler OnPing { get; }
	public abstract BinaryDataHandler OnPong { get; }
	public abstract Action<Exception> OnError { set; }
	public abstract IWebSocketConnectionInfo ConnectionInfo { get; }
	public abstract bool IsAvailable { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_OnOpen(Action value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Action get_OnClose();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_OnClose(Action value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Action<string> get_OnMessage();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_OnMessage(Action<string> value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract BinaryDataHandler get_OnBinary();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract BinaryDataHandler get_OnPing();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BinaryDataHandler get_OnPong();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_OnError(Action<Exception> value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Send(string message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IWebSocketConnectionInfo get_ConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_IsAvailable();

}

public interface IWebSocketConnectionInfo // TypeDefIndex: 6913
{	// Properties
	public abstract string Path { get; }
	public abstract IPAddress ClientIpAddress { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Path();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IPAddress get_ClientIpAddress();

}

internal interface ILZ4Service // TypeDefIndex: 6985
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength);

}

public interface IAutoLayout // TypeDefIndex: 7001
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoLayout();

}

public static class UIBehaviourEx // TypeDefIndex: 7003
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD43C0 Offset: 0xFD37C0 VA: 0x180FD43C0
	public static void SetParent(UIBehaviour self, Transform parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD42F0 Offset: 0xFD36F0 VA: 0x180FD42F0
	public static void SetParent(UIBehaviour self, Canvas parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD42F0 Offset: 0xFD36F0 VA: 0x180FD42F0
	public static void SetParent(UIBehaviour self, UIBehaviour parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD41B0 Offset: 0xFD35B0 VA: 0x180FD41B0
	public static void SetParentRootCanvas(UIBehaviour self, Transform tx) { }

}

public interface IValueTaskSource // TypeDefIndex: 7089
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token);

}

public interface IValueTaskSource<TResult> // TypeDefIndex: 7090
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetResult
	*/

}

private interface NativeClient.INativeModule // TypeDefIndex: 7160
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IntPtr Create();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Destroy(IntPtr Instance);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ConnectionReset(IntPtr Instance);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, int MessageLength);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IntPtr NetProtect(IntPtr Instance);

}

public interface INetProtect // TypeDefIndex: 7164
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

}

public interface IFrameDecoder // TypeDefIndex: 7399
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DecodeFrame();

}

public interface ILengthedObject : ITimedObject // TypeDefIndex: 7436
{	// Properties
	public abstract long Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Length();

}

internal interface ITempoMapValuesCache // TypeDefIndex: 7450
{	// Properties
	public abstract IEnumerable<TempoMapLine> InvalidateOnLines { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<TempoMapLine> get_InvalidateOnLines();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Invalidate(TempoMap tempoMap);

}

public interface ITimedObject // TypeDefIndex: 7463
{	// Properties
	public abstract long Time { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Time();

}

internal interface ITimeSpanConverter // TypeDefIndex: 7472
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap);

}

public interface ITimeSpan : IComparable // TypeDefIndex: 7482
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ITimeSpan Clone();

}

internal interface IEventReader // TypeDefIndex: 7554
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte);

}

public interface IRgbService // TypeDefIndex: 7677
{	// Properties
	public abstract bool IsConnected { get; }
	public abstract Vector3 ColorCorrection { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsConnected();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_ColorCorrection();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_ColorCorrection(Vector3 value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ValueTask Start();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ValueTask Stop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ValueTask Update();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StaticColor(Color color);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PulseColor(Color color, float duration);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Event(RgbEventType type);

}

public interface IImageEffect // TypeDefIndex: 8029
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRenderImage(RenderTexture source, RenderTexture destination);

}

public interface IRemoteControllable // TypeDefIndex: 8682
{	// Properties
	public abstract bool RequiresMouse { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform GetEyes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract BaseEntity GetEnt();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Occupied();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateIdentifier(string newID, bool clientSend = False);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetIdentifier();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RCSetup();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RCShutdown();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool CanControl();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_RequiresMouse();

}

public interface IVendingMachineInterface // TypeDefIndex: 8733
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BuyButtonClicked(int index, int multiplier);

}

public class UIMarketSearch : MonoBehaviour // TypeDefIndex: 8803
{	// Fields
	public GameObjectRef StoreEntryRef; // 0x18
	public RectTransform StoreRoot; // 0x20
	public UIMarketTerminal Terminal; // 0x28

	// Methods

	// RVA: 0x4E9F00 Offset: 0x4E9300 VA: 0x1804E9F00
	public void UpdateFilter(string filter) { }

	// RVA: 0x4E9C00 Offset: 0x4E9000 VA: 0x1804E9C00
	private void FilterSellOrders(VendingMachine machine, string filter, List<VendingMachine.SellOrder> orders) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E9E40 Offset: 0x4E9240 VA: 0x1804E9E40
	private void <UpdateFilter>g__CreateStoreEntry|3_0(VendingMachineMapMarker marker, List<VendingMachine.SellOrder> matchingOrders) { }

}

public class UIMarketSearchOrderEntry : MonoBehaviour // TypeDefIndex: 8804
{	// Fields
	public RustText ItemName; // 0x18
	public GameObject OutOfStockRoot; // 0x20
	public GameObject BpRoot; // 0x28

	// Methods

	// RVA: 0x4E9790 Offset: 0x4E8B90 VA: 0x1804E9790
	public void Populate(VendingMachine.SellOrder order) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMarketSearchStore : MonoBehaviour // TypeDefIndex: 8805
{	// Fields
	public RustText StoreName; // 0x18
	public List<UIMarketSearchOrderEntry> Entries; // 0x20
	private VendingMachineMapMarker cachedMarker; // 0x28
	private UIMarketTerminal cachedTerminal; // 0x30

	// Methods

	// RVA: 0x4E9A40 Offset: 0x4E8E40 VA: 0x1804E9A40
	public void Populate(VendingMachineMapMarker machine, List<VendingMachine.SellOrder> matchingEntries, UIMarketTerminal terminal) { }

	// RVA: 0x4E98C0 Offset: 0x4E8CC0 VA: 0x1804E98C0
	public void OnCLickedGoTo() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMarketTerminal : UIDialog, IVendingMachineInterface // TypeDefIndex: 8806
{	// Fields
	public static readonly Translate.Phrase PendingDeliveryPluralPhrase; // 0x0
	public static readonly Translate.Phrase PendingDeliverySingularPhrase; // 0x8
	public Canvas canvas; // 0x30
	public MapView mapView; // 0x38
	public RectTransform shopDetailsPanel; // 0x40
	public float shopDetailsMargin; // 0x48
	public float easeDuration; // 0x4C
	public LeanTweenType easeType; // 0x50
	public RustText shopName; // 0x58
	public GameObject shopOrderingPanel; // 0x60
	public RectTransform sellOrderContainer; // 0x68
	public GameObjectRef sellOrderPrefab; // 0x70
	public VirtualItemIcon deliveryFeeIcon; // 0x78
	public GameObject deliveryFeeCantAffordIndicator; // 0x80
	public GameObject inventoryFullIndicator; // 0x88
	public GameObject notEligiblePanel; // 0x90
	public GameObject pendingDeliveryPanel; // 0x98
	public RustText pendingDeliveryLabel; // 0xA0
	public RectTransform itemNoticesContainer; // 0xA8
	public GameObjectRef itemRemovedPrefab; // 0xB0
	public GameObjectRef itemPendingPrefab; // 0xB8
	public GameObjectRef itemAddedPrefab; // 0xC0
	public CanvasGroup gettingStartedTip; // 0xC8
	public SoundDefinition buyItemSoundDef; // 0xD0
	public SoundDefinition buttonPressSoundDef; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MarketTerminal <currentTerminal>k__BackingField; // 0xE0
	private uint _currentVendingMachine; // 0xE8
	private HashSet<uint> _eligibleVendingMachines; // 0xF0
	private List<SellOrderEntry> _shopEntries; // 0xF8
	private Action<SellOrderEntry, int> _onShopEntryAmountChangedCached; // 0x100

	// Properties
	public MarketTerminal currentTerminal { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public MarketTerminal get_currentTerminal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	private void set_currentTerminal(MarketTerminal value) { }

	// RVA: 0x4EB540 Offset: 0x4EA940 VA: 0x1804EB540
	public void Setup(MarketTerminal terminal, List<uint> eligibleVendingMachineIds) { }

	// RVA: 0x4EAFF0 Offset: 0x4EA3F0 VA: 0x1804EAFF0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4EA980 Offset: 0x4E9D80 VA: 0x1804EA980 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4EAFD0 Offset: 0x4EA3D0 VA: 0x1804EAFD0
	public void OnVendingMachineClicked(UIMapVendingMachineMarker marker) { }

	// RVA: 0x4EB300 Offset: 0x4EA700 VA: 0x1804EB300
	public void SelectVendingMachine(VendingMachine vmData) { }

	// RVA: 0x4EAB30 Offset: 0x4E9F30 VA: 0x1804EAB30
	public void HideVendingMachine(bool immediate = False) { }

	// RVA: 0x4EA4D0 Offset: 0x4E98D0 VA: 0x1804EA4D0 Slot: 10
	public void BuyButtonClicked(int index, int multiplier) { }

	// RVA: 0x4EA2D0 Offset: 0x4E96D0 VA: 0x1804EA2D0
	public void AddItemNotice(int itemDefId, int quantity, bool isPending) { }

	// RVA: 0x4EB8D0 Offset: 0x4EACD0 VA: 0x1804EB8D0
	public void UpdateShopDetails(VendingMachine vmData) { }

	// RVA: 0x4EAE50 Offset: 0x4EA250 VA: 0x1804EAE50
	private void OnShopEntryAmountChanged(SellOrderEntry changedEntry, int newAmount) { }

	// RVA: 0x4EB660 Offset: 0x4EAA60 VA: 0x1804EB660
	public void UpdateIndicators() { }

	// RVA: 0x4EA750 Offset: 0x4E9B50 VA: 0x1804EA750
	private bool CanAffordCurrentOrder() { }

	// RVA: 0x4EAD60 Offset: 0x4EA160 VA: 0x1804EAD60
	public static bool IsOpen(out UIMarketTerminal marketTerminal) { }

	// RVA: 0x4EBCD0 Offset: 0x4EB0D0 VA: 0x1804EBCD0
	public void .ctor() { }

	// RVA: 0x4EBC20 Offset: 0x4EB020 VA: 0x1804EBC20
	private static void .cctor() { }

}

private sealed class UIMarketTerminal.<>c // TypeDefIndex: 8807
{	// Fields
	public static readonly UIMarketTerminal.<>c <>9; // 0x0
	public static Predicate<SellOrderEntry> <>9__44_0; // 0x8

	// Methods

	// RVA: 0x9DEC20 Offset: 0x9DE020 VA: 0x1809DEC20
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9DEBC0 Offset: 0x9DDFC0 VA: 0x1809DEBC0
	internal bool <CanAffordCurrentOrder>b__44_0(SellOrderEntry e) { }

}

public class UITwitchTrophy : UIDialog // TypeDefIndex: 8819
{	// Fields
	public HttpImage EventImage; // 0x30
	public RustText EventName; // 0x38
	public RustText WinningTeamName; // 0x40
	public RectTransform TeamMembersRoot; // 0x48
	public GameObject TeamMemberNamePrefab; // 0x50
	public GameObject MissingDataOverlay; // 0x58

	// Methods

	// RVA: 0x9E3240 Offset: 0x9E2640 VA: 0x1809E3240 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

private class UITwitchTrophy.TrophyPage // TypeDefIndex: 8820
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <EventTitle>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Logo>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <WinningTeam>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<string> <TeamMembers>k__BackingField; // 0x28

	// Properties
	public string EventTitle { get; set; }
	public string Logo { get; set; }
	public string WinningTeam { get; set; }
	public List<string> TeamMembers { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_EventTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_EventTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Logo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Logo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_WinningTeam() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_WinningTeam(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public List<string> get_TeamMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_TeamMembers(List<string> value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public interface IConversationProvider // TypeDefIndex: 8848
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ResponsePressed(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EndConversation(bool fromServer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DoAction(string actionString);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 GetConversationWorldOrigin();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ProviderBusy();

}

public interface IThinker // TypeDefIndex: 8932
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TryThink();

}

public interface ISoundBudgetedUpdate // TypeDefIndex: 8996
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoUpdate();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSyncedToParent();

}

public interface ILerpInfo // TypeDefIndex: 9219
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetExtrapolationTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetInterpolationDelay();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float GetInterpolationSmoothing();

}

public interface IPosLerpTarget : ILerpInfo // TypeDefIndex: 9220
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetInterpolationInertia();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 GetNetworkPosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Quaternion GetNetworkRotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetNetworkPosition(Vector3 pos);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetNetworkRotation(Quaternion rot);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LerpIdleDisable();

}

internal interface IRagdollInhert // TypeDefIndex: 9226
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform RagdollInhertTransform();

}

public interface IEffectRecycle // TypeDefIndex: 9335
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Recycle();

}

public interface IEffect // TypeDefIndex: 9336
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetupEffect(Effect effect);

}

public interface IAnimationEventReceiver // TypeDefIndex: 9349
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAnimationEvent(string eventName);

}

public interface IAIEventListener // TypeDefIndex: 9399
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EventTriggeredStateChange(int newStateContainerID, int sourceEventID);

}

internal interface IAIDesign // TypeDefIndex: 9426
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanPlayerDesignAI(BasePlayer player);

}

public interface IPet // TypeDefIndex: 9431
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsPet();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetPetOwner(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsOwnedBy(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray);

}

public interface ICassettePlayer // TypeDefIndex: 9437
{	// Properties
	public abstract BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract BaseEntity get_ToBaseEntity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLoadedWithCassette(Cassette c);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCensorRecordingsChanged();

}

public interface IAudioConnectionSource // TypeDefIndex: 9443
{	// Properties
	public abstract float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SpeakerConnected(ConnectedSpeaker speaker);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SpeakerDisconnected(ConnectedSpeaker repeater);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AudioSource GetSource();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_VolumeVisualisationMultiplier();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float GetFakeInput();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IOEntity ToEntity();

}

public interface IServerFileReceiver // TypeDefIndex: 9457
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data);

}

public interface IFlagNotify // TypeDefIndex: 9495
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnFlagToggled(bool state);

}

public interface IImageReceiver // TypeDefIndex: 9512
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnImageLoaded(Texture2D texture);

}

public interface ISignage // TypeDefIndex: 9517
{	// Properties
	public abstract Vector2i TextureSize { get; }
	public abstract int TextureCount { get; }
	public abstract uint NetworkID { get; }
	public abstract FileStorage.Type FileType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanUpdateSign(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float Distance(Vector3 position);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2i get_TextureSize();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_TextureCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint[] GetTextureCRCs();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract uint get_NetworkID();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract FileStorage.Type get_FileType();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile);

}

public interface IItemContainerEntity // TypeDefIndex: 9547
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetMoveToContainerIndex(BasePlayer player, Item item);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetMoveToSlotIndex(BasePlayer player, Item item);

}

public interface IVehicleLockUser // TypeDefIndex: 9742
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool PlayerHasUnlockPermission(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule);

}

public interface ITrainCollidable // TypeDefIndex: 9763
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool EqualNetID(BaseNetworkable other);

}

public interface VehicleChassisVisuals.IClientWheelUser<T> // TypeDefIndex: 9781
{	// Properties
	public abstract Vector3 Velocity { get; }
	public abstract float DriveWheelVelocity { get; }
	public abstract float SteerAngle { get; }
	public abstract float MaxSteerAngle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_Velocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_Velocity
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_DriveWheelVelocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_DriveWheelVelocity
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_SteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_SteerAngle
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_MaxSteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_MaxSteerAngle
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float GetThrottleInput();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.GetThrottleInput
	*/

}

public interface IEngineControllerUser : IEntity // TypeDefIndex: 9785
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasFlag(BaseEntity.Flags f);

}

public interface IRFObject // TypeDefIndex: 9812
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ClientSetFrequency(int newFreq);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetFrequency();

}

public interface IInstanceDataReceiver // TypeDefIndex: 9903
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ReceiveInstanceData(Item.InstanceData data);

}

public interface IOnParentDestroying // TypeDefIndex: 9904
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnParentDestroying();

}

public interface IOnParentSpawning // TypeDefIndex: 9906
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnParentSpawning();

}

public interface IOnPostNetworkUpdate // TypeDefIndex: 9908
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPostNetworkUpdate(BaseEntity entity);

}

public interface IOnSendNetworkUpdate // TypeDefIndex: 9910
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSendNetworkUpdate(BaseEntity entity);

}

public interface ILOD // TypeDefIndex: 9927
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ChangeLOD();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RefreshLOD();

}

public interface INotifyLOD // TypeDefIndex: 9944
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Show();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Hide();

}

public interface ISpawnGroup // TypeDefIndex: 9999
{	// Properties
	public abstract int currentPopulation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Fill();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SpawnInitial();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SpawnRepeating();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_currentPopulation();

}

public interface ISpawnPointUser // TypeDefIndex: 10000
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ObjectSpawned(SpawnPointInstance instance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ObjectRetired(SpawnPointInstance instance);

}

public interface TriggerHurtNotChild.IHurtTriggerUser // TypeDefIndex: 10027
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract BasePlayer GetPlayerDamageInitiator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetPlayerDamageMultiplier();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnHurtTriggerOccupant(BaseEntity hurtEntity, DamageType damageType, float damageTotal);

}

public interface INotifyTrigger // TypeDefIndex: 10032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnObjects(TriggerNotify trigger);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEmpty();

}

public interface INotifyEntityTrigger // TypeDefIndex: 10034
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEntityEnter(BaseEntity ent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEntityLeave(BaseEntity ent);

}

public interface IItemUpdate // TypeDefIndex: 10108
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemUpdate(Item item);

}

public interface IItemSetup // TypeDefIndex: 10109
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemSetup(Item item);

}

public interface IAirSupply // TypeDefIndex: 10160
{	// Properties
	public abstract ItemModGiveOxygen.AirSupplyType AirType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ItemModGiveOxygen.AirSupplyType get_AirType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetAirTimeRemaining();

}

public interface IMissionProvider // TypeDefIndex: 10212
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint ProviderID();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 ProviderPosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BaseEntity Entity();

}

public class UIAIDesignerScreen : SingletonComponent<UIAIDesignerScreen>, IUIScreen // TypeDefIndex: 10816
{	// Fields
	public GameObject SaveEntityButton; // 0x18
	public GameObject SaveServerButton; // 0x20
	public GameObject SaveDefaultButton; // 0x28
	public RustInput InputAIDescription; // 0x30
	public RustText TextDefaultStateContainer; // 0x38
	public Transform PrefabAddNewStateButton; // 0x40
	public Transform StateContainer; // 0x48
	public Transform PrefabState; // 0x50
	public EnumListUI PopupList; // 0x58
	public static EnumListUI EnumList; // 0x0
	public NeedsCursor needsCursor; // 0x60
	protected CanvasGroup canvasGroup; // 0x68
	public GameObject RootPanel; // 0x70
	private bool visible; // 0x78
	public AIDesign DesignProto; // 0x80
	private Transform addNewStateButton; // 0x88

	// Methods

	// RVA: 0x4D2BD0 Offset: 0x4D1FD0 VA: 0x1804D2BD0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D3F40 Offset: 0x4D3340 VA: 0x1804D3F40
	public void Init(AIDesign design) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C7C0 Offset: 0x7BBC0 VA: 0x18007C7C0
	// RVA: 0x4D4990 Offset: 0x4D3D90 VA: 0x1804D4990
	private IEnumerator SetInitialStateContainer(int id) { }

	// RVA: 0x4D4A10 Offset: 0x4D3E10 VA: 0x1804D4A10 Slot: 8
	public void SetVisible(bool flag) { }

	// RVA: 0x4D2C60 Offset: 0x4D2060 VA: 0x1804D2C60
	public void ClearStates() { }

	// RVA: 0x4D2A00 Offset: 0x4D1E00 VA: 0x1804D2A00
	private void AddNewStateButton() { }

	// RVA: 0x4D3640 Offset: 0x4D2A40 VA: 0x1804D3640
	public List<AIState> GetAvailableStates() { }

	// RVA: 0x4D3A60 Offset: 0x4D2E60 VA: 0x1804D3A60
	public List<int> GetStateContainerIDs() { }

	// RVA: 0x4D3CE0 Offset: 0x4D30E0 VA: 0x1804D3CE0
	private BaseStateUI GetStateContainer(int id) { }

	// RVA: 0x4D37B0 Offset: 0x4D2BB0 VA: 0x1804D37B0
	public int GetNextStateContainerID() { }

	// RVA: 0x4D2AD0 Offset: 0x4D1ED0 VA: 0x1804D2AD0
	public BaseStateUI AddState(AIState state, int stateContainerID) { }

	// RVA: 0x4D2F50 Offset: 0x4D2350 VA: 0x1804D2F50
	public void DeleteState(BaseStateUI state) { }

	// RVA: 0x4D33C0 Offset: 0x4D27C0 VA: 0x1804D33C0
	public void DuplicateState(BaseStateUI state) { }

	// RVA: 0x4D4190 Offset: 0x4D3590 VA: 0x1804D4190
	public void OnDebugStateChanged(int previousStateContainerID, int newStateContainerID, int triggerEventID) { }

	// RVA: 0x4D42D0 Offset: 0x4D36D0 VA: 0x1804D42D0
	public void OnSetDefaultStateClicked() { }

	// RVA: 0x4D48F0 Offset: 0x4D3CF0 VA: 0x1804D48F0
	public void SetDefaultStateClicked(object value) { }

	// RVA: 0x4D48B0 Offset: 0x4D3CB0 VA: 0x1804D48B0
	private void SetDefaultOutputStateContainer(int id) { }

	// RVA: 0x4D3440 Offset: 0x4D2840 VA: 0x1804D3440
	public void Exit() { }

	// RVA: 0x4D2C50 Offset: 0x4D2050 VA: 0x1804D2C50
	public void ClearClicked() { }

	// RVA: 0x4D2E50 Offset: 0x4D2250 VA: 0x1804D2E50
	private void Clear() { }

	// RVA: 0x4D42A0 Offset: 0x4D36A0 VA: 0x1804D42A0
	public void OnSaveClicked() { }

	// RVA: 0x4D42A0 Offset: 0x4D36A0 VA: 0x1804D42A0
	public void OnSaveEntityClicked() { }

	// RVA: 0x4D42C0 Offset: 0x4D36C0 VA: 0x1804D42C0
	public void OnSaveServerWideClicked() { }

	// RVA: 0x4D42B0 Offset: 0x4D36B0 VA: 0x1804D42B0
	public void OnSaveDefaultClicked() { }

	// RVA: 0x4D44B0 Offset: 0x4D38B0 VA: 0x1804D44B0
	public void Save(AIDesignScope scope) { }

	// RVA: 0x4D4CE0 Offset: 0x4D40E0 VA: 0x1804D4CE0
	public void ToggleFade() { }

	// RVA: 0x4D4D30 Offset: 0x4D4130 VA: 0x1804D4D30
	public void .ctor() { }

}

private sealed class UIAIDesignerScreen.<SetInitialStateContainer>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10817
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UIAIDesignerScreen <>4__this; // 0x20
	public int id; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4D2040 Offset: 0x4D1440 VA: 0x1804D2040 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D21D0 Offset: 0x4D15D0 VA: 0x1804D21D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class UIChat : PriorityListComponent<UIChat> // TypeDefIndex: 10829
{	// Fields
	public GameObject inputArea; // 0x18
	public GameObject chatArea; // 0x20
	public TMP_InputField inputField; // 0x28
	public TextMeshProUGUI channelLabel; // 0x30
	public ScrollRect scrollRect; // 0x38
	public CanvasGroup canvasGroup; // 0x40
	public GameObjectRef chatItemPlayer; // 0x48
	public GameObject userPopup; // 0x50
	public static bool isOpen; // 0x0
	private Chat.ChatChannel activeChannel; // 0x58
	private UIChatPopup popup; // 0x60

	// Methods

	// RVA: 0x4D9A60 Offset: 0x4D8E60 VA: 0x1804D9A60
	protected void Awake() { }

	// RVA: 0x4DB050 Offset: 0x4DA450 VA: 0x1804DB050
	public static void Open() { }

	// RVA: 0x4DAFA0 Offset: 0x4DA3A0 VA: 0x1804DAFA0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4DAC10 Offset: 0x4DA010 VA: 0x1804DAC10
	public void FocusInput() { }

	// RVA: 0x4DB600 Offset: 0x4DAA00 VA: 0x1804DB600
	public void SetChannel(Chat.ChatChannel channel, bool autoSwitched = False) { }

	// RVA: 0x4DB4A0 Offset: 0x4DA8A0 VA: 0x1804DB4A0
	private void SetChannelLabel(Chat.ChatChannel channel) { }

	// RVA: 0x4DBB60 Offset: 0x4DAF60 VA: 0x1804DBB60
	public void SubmitText() { }

	// RVA: 0x4DA0E0 Offset: 0x4D94E0 VA: 0x1804DA0E0
	public bool ClickedInsideTransformOrChild(Transform t) { }

	// RVA: 0x4D9C60 Offset: 0x4D9060 VA: 0x1804D9C60
	public void Cancel() { }

	// RVA: 0x4DC060 Offset: 0x4DB460 VA: 0x1804DC060
	private void TrimMessages() { }

	// RVA: 0x4DA030 Offset: 0x4D9430 VA: 0x1804DA030
	private void ClearText() { }

	// RVA: 0x4D9F40 Offset: 0x4D9340 VA: 0x1804D9F40
	public void ClearChat() { }

	// RVA: 0x4DC170 Offset: 0x4DB570 VA: 0x1804DC170
	public void Update() { }

	// RVA: 0x4DA3B0 Offset: 0x4D97B0 VA: 0x1804DA3B0
	private void CycleActiveChatChannel() { }

	// RVA: 0x4D9890 Offset: 0x4D8C90 VA: 0x1804D9890
	public static void Add(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DACC0 Offset: 0x4DA0C0 VA: 0x1804DACC0
	private void InternalAdd(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DAFC0 Offset: 0x4DA3C0 VA: 0x1804DAFC0
	public static void OnMessageClicked(ChatEntry entry) { }

	// RVA: 0x4DB8B0 Offset: 0x4DACB0 VA: 0x1804DB8B0
	public void ShowUserMenu(ChatEntry entry) { }

	// RVA: 0x4DB010 Offset: 0x4DA410 VA: 0x1804DB010
	public void OpenMuteList() { }

	// RVA: 0x4DC200 Offset: 0x4DB600 VA: 0x1804DC200
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4DC140 Offset: 0x4DB540 VA: 0x1804DC140
	private void <Cancel>b__19_0() { }

}

public class UIChatPopup : MonoBehaviour // TypeDefIndex: 10830
{	// Fields
	public TextMeshProUGUI TextToggleMute; // 0x18
	public TextMeshProUGUI TextToggleGlobalMute; // 0x20
	public Button MuteButton; // 0x28
	public Button ReportButton; // 0x30
	public GameObject InviteToTeamButton; // 0x38
	private ulong steamID; // 0x40
	private string text; // 0x48

	// Methods

	// RVA: 0x4D8E30 Offset: 0x4D8230 VA: 0x1804D8E30
	public void Init(ChatEntry entry) { }

	// RVA: 0x4D9800 Offset: 0x4D8C00 VA: 0x1804D9800
	private void Update() { }

	// RVA: 0x4D9640 Offset: 0x4D8A40 VA: 0x1804D9640
	public void OnToggleMuteGlobalClicked() { }

	// RVA: 0x4D9530 Offset: 0x4D8930 VA: 0x1804D9530
	public void OnToggleMuteClicked() { }

	// RVA: 0x4D9220 Offset: 0x4D8620 VA: 0x1804D9220
	public void OnInviteToTeamClicked() { }

	// RVA: 0x4D9750 Offset: 0x4D8B50 VA: 0x1804D9750
	public void OnViewSteamProfileClicked() { }

	// RVA: 0x4D9150 Offset: 0x4D8550 VA: 0x1804D9150
	public void OnCopyTextClicked() { }

	// RVA: 0x4D8FB0 Offset: 0x4D83B0 VA: 0x1804D8FB0
	public void OnClearChatClicked() { }

	// RVA: 0x4D93B0 Offset: 0x4D87B0 VA: 0x1804D93B0
	public void OnReportClicked() { }

	// RVA: 0x4D8DC0 Offset: 0x4D81C0 VA: 0x1804D8DC0
	public void Hide() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public interface CardTableUI.ICardGameSubUI // TypeDefIndex: 10878
{	// Properties
	public abstract int DynamicBetAmount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DynamicBetAmount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateInGameUI(CardTableUI ui, CardGameController game);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateInGameUI_NoPlayer(CardTableUI ui);

}

public class UIColorPickerButton : MonoBehaviour // TypeDefIndex: 10889
{	// Fields
	public Image Image; // 0x18
	public Color Color; // 0x20

	// Methods

	// RVA: 0x4DC240 Offset: 0x4DB640 VA: 0x1804DC240
	public void .ctor() { }

}

public class UIFireworkDesignItem : MonoBehaviour // TypeDefIndex: 10890
{	// Fields
	public static readonly Translate.Phrase EmptyPhrase; // 0x0
	public static readonly Translate.Phrase UntitledPhrase; // 0x8
	public RustText Title; // 0x18
	public RustButton LoadButton; // 0x20
	public RustButton SaveButton; // 0x28
	public RustButton EraseButton; // 0x30
	public UIFireworkDesigner Designer; // 0x38
	public int Index; // 0x40
	private PatternFirework.SavedDesign _saved; // 0x48

	// Properties
	private string Key { get; }

	// Methods

	// RVA: 0x4E1700 Offset: 0x4E0B00 VA: 0x1804E1700
	private string get_Key() { }

	// RVA: 0x4E1270 Offset: 0x4E0670 VA: 0x1804E1270
	public void OnEnable() { }

	// RVA: 0x4E1230 Offset: 0x4E0630 VA: 0x1804E1230
	public void OnDisable() { }

	// RVA: 0x4E11A0 Offset: 0x4E05A0 VA: 0x1804E11A0
	public void Load() { }

	// RVA: 0x4E1390 Offset: 0x4E0790 VA: 0x1804E1390
	public void Save() { }

	// RVA: 0x4E0FF0 Offset: 0x4E03F0 VA: 0x1804E0FF0
	public void Erase() { }

	// RVA: 0x4E1550 Offset: 0x4E0950 VA: 0x1804E1550
	private void UpdateState() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x4E1650 Offset: 0x4E0A50 VA: 0x1804E1650
	private static void .cctor() { }

}

public class UIFireworkDesigner : UIDialog // TypeDefIndex: 10891
{	// Fields
	public RustInput Title; // 0x30
	public RustText StarsPlaced; // 0x38
	public RectTransform Canvas; // 0x40
	public RectTransform InnerCanvas; // 0x48
	public GameObject StarPrefab; // 0x50
	public UIFireworkDesigner.Tools Tool; // 0x58
	public Color SelectedColor; // 0x5C
	private PatternFirework _firework; // 0x70
	private Dictionary<int, UIFireworkStar> _stars; // 0x78

	// Methods

	// RVA: 0x4E20F0 Offset: 0x4E14F0 VA: 0x1804E20F0
	public void Initialize(PatternFirework firework) { }

	// RVA: 0x4E26F0 Offset: 0x4E1AF0 VA: 0x1804E26F0
	public void Save() { }

	// RVA: 0x4E2760 Offset: 0x4E1B60 VA: 0x1804E2760
	public void SelectPlacer() { }

	// RVA: 0x4E2770 Offset: 0x4E1B70 VA: 0x1804E2770
	public void SelectRemover() { }

	// RVA: 0x4E2740 Offset: 0x4E1B40 VA: 0x1804E2740
	public void SelectColor(UIColorPickerButton colorButton) { }

	// RVA: 0x4E1810 Offset: 0x4E0C10 VA: 0x1804E1810
	public void ClearCanvas() { }

	// RVA: 0x4E2250 Offset: 0x4E1650 VA: 0x1804E2250
	private void PlaceStar(Vector2 localPosition, Color color) { }

	// RVA: 0x4E2200 Offset: 0x4E1600 VA: 0x1804E2200
	public void PlaceStar() { }

	// RVA: 0x4E2570 Offset: 0x4E1970 VA: 0x1804E2570
	public void RemoveStar(UIFireworkStar star) { }

	// RVA: 0x4E2780 Offset: 0x4E1B80 VA: 0x1804E2780
	private void UpdateStarsPlacedCount() { }

	// RVA: 0x4E1C50 Offset: 0x4E1050 VA: 0x1804E1C50
	public Vector2 GetMousePositionOnCanvas() { }

	// RVA: 0x4E1760 Offset: 0x4E0B60 VA: 0x1804E1760
	private Nullable<int> ChooseIndex() { }

	// RVA: 0x4E1EE0 Offset: 0x4E12E0 VA: 0x1804E1EE0
	public void Import(PatternFirework.Design design) { }

	// RVA: 0x4E1990 Offset: 0x4E0D90 VA: 0x1804E1990
	public PatternFirework.Design Export() { }

	// RVA: 0x4E1DC0 Offset: 0x4E11C0 VA: 0x1804E1DC0
	private Vector2 GetScaledPositionOnCanvas(Vector2 localPosition) { }

	// RVA: 0x4E28F0 Offset: 0x4E1CF0 VA: 0x1804E28F0
	public void .ctor() { }

}

public enum UIFireworkDesigner.Tools // TypeDefIndex: 10892
{	// Fields
	public int value__; // 0x0
	public const UIFireworkDesigner.Tools Placer = 0;
	public const UIFireworkDesigner.Tools Remover = 1;

}

public class UIFireworkStar : EventTrigger // TypeDefIndex: 10893
{	// Fields
	public Image Image; // 0x20
	public RustText Text; // 0x28
	private UIFireworkDesigner _designer; // 0x30
	public int Index; // 0x38
	public Color Color; // 0x3C

	// Methods

	// RVA: 0x4E2960 Offset: 0x4E1D60 VA: 0x1804E2960
	public void Initialize(UIFireworkDesigner designer, int index, Color color) { }

	// RVA: 0x4E2D40 Offset: 0x4E2140 VA: 0x1804E2D40
	private void SetColor(Color color) { }

	// RVA: 0x4E2B50 Offset: 0x4E1F50 VA: 0x1804E2B50 Slot: 27
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4E2A70 Offset: 0x4E1E70 VA: 0x1804E2A70 Slot: 23
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class UIDialog : ListComponent<UIDialog> // TypeDefIndex: 10919
{	// Fields
	public SoundDefinition openSoundDef; // 0x18
	public SoundDefinition closeSoundDef; // 0x20
	public bool isClosing; // 0x28

	// Properties
	public static bool isOpen { get; }

	// Methods

	// RVA: 0x4E0BF0 Offset: 0x4DFFF0 VA: 0x1804E0BF0
	public static bool get_isOpen() { }

	// RVA: 0x4E0AF0 Offset: 0x4DFEF0 VA: 0x1804E0AF0 Slot: 8
	public virtual void OpenDialog() { }

	// RVA: 0x4E0A10 Offset: 0x4DFE10 VA: 0x1804E0A10 Slot: 9
	public virtual void CloseDialog() { }

	// RVA: -1 Offset: -1
	public static T Spawn<T>(string prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0E80 Offset: 0x14C0280 VA: 0x1814C0E80
	|-UIDialog.Spawn<ChangeSignText>
	|-UIDialog.Spawn<MLRSUIDialog>
	|-UIDialog.Spawn<MuteListController>
	|-UIDialog.Spawn<ReportBug>
	|-UIDialog.Spawn<ReportPlayer>
	|-UIDialog.Spawn<object>
	|-UIDialog.Spawn<UIMarketTerminal>
	|-UIDialog.Spawn<UITwitchTrophy>
	*/

	// RVA: 0x4E0B90 Offset: 0x4DFF90 VA: 0x1804E0B90
	public void .ctor() { }

}

public class UIMapExplosion : MonoBehaviour // TypeDefIndex: 10962
{	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMapGenericRadius : MonoBehaviour // TypeDefIndex: 10963
{	// Fields
	public Image radialImage; // 0x18
	public Image outlineImage; // 0x20
	public float radius; // 0x28
	public CanvasGroup fade; // 0x30
	public RectTransform rect; // 0x38

	// Methods

	// RVA: 0x4E8090 Offset: 0x4E7490 VA: 0x1804E8090
	public void UpdateColors(Color col, Color col2, float totalAlpha) { }

	// RVA: 0x4E7FB0 Offset: 0x4E73B0 VA: 0x1804E7FB0
	public void SetRadius(float newRadius, bool force = False) { }

	// RVA: 0x4E8120 Offset: 0x4E7520 VA: 0x1804E8120
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMapVendingMachineMarker : MonoBehaviour // TypeDefIndex: 10964
{	// Fields
	public Color inStock; // 0x18
	public Color outOfStock; // 0x28
	public Image colorBackground; // 0x38
	public string displayName; // 0x40
	public Tooltip toolTip; // 0x48
	public RustButton button; // 0x50
	public bool isInStock; // 0x58
	public EntityRef<VendingMachine> vendingMachine; // 0x60
	public VendingMachine vendingMachineData; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<UIMapVendingMachineMarker> onClicked; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E9630 Offset: 0x4E8A30 VA: 0x1804E9630
	public static void add_onClicked(Action<UIMapVendingMachineMarker> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E96E0 Offset: 0x4E8AE0 VA: 0x1804E96E0
	public static void remove_onClicked(Action<UIMapVendingMachineMarker> value) { }

	// RVA: 0x4E8C00 Offset: 0x4E8000 VA: 0x1804E8C00
	public void SetOutOfStock(bool stock) { }

	// RVA: 0x4E8C60 Offset: 0x4E8060 VA: 0x1804E8C60
	public void UpdateInfo(VendingMachine vendingMachineData) { }

	// RVA: 0x4E8B60 Offset: 0x4E7F60 VA: 0x1804E8B60
	public void Clicked() { }

	// RVA: 0x4E8BC0 Offset: 0x4E7FC0 VA: 0x1804E8BC0
	public static void RemoveAllHandlers() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMapVendingMachineMarkerCluster : MonoBehaviour // TypeDefIndex: 10965
{	// Fields
	public List<UIMapVendingMachineMarker> markers; // 0x18
	public GameObject OpenRoot; // 0x20
	public TextMeshProUGUI CountText; // 0x28
	public static UIMapVendingMachineMarkerCluster currentlyOpen; // 0x0
	private bool open; // 0x30

	// Methods

	// RVA: 0x4E8460 Offset: 0x4E7860 VA: 0x1804E8460
	private void OnEnable() { }

	// RVA: 0x4E8890 Offset: 0x4E7C90 VA: 0x1804E8890
	public void UpdateDisplay(List<VendingMachine> vendingMachines, List<bool> outOfStock) { }

	// RVA: 0x4E8270 Offset: 0x4E7670 VA: 0x1804E8270
	private UIMapVendingMachineMarker GetLine() { }

	// RVA: 0x4E8510 Offset: 0x4E7910 VA: 0x1804E8510
	public void ToggleOpen() { }

	// RVA: 0x4E8AF0 Offset: 0x4E7EF0 VA: 0x1804E8AF0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E8860 Offset: 0x4E7C60 VA: 0x1804E8860
	private void <ToggleOpen>b__8_0() { }

}

public class UIPaintBox : MonoBehaviour // TypeDefIndex: 10966
{	// Fields
	public UIPaintBox.OnBrushChanged onBrushChanged; // 0x18
	public Brush brush; // 0x20

	// Methods

	// RVA: 0x9DF400 Offset: 0x9DE800 VA: 0x1809DF400
	public void UpdateBrushSize(int size) { }

	// RVA: 0x9DF540 Offset: 0x9DE940 VA: 0x1809DF540
	public void UpdateBrushTexture(Texture2D tex) { }

	// RVA: 0x9DF360 Offset: 0x9DE760 VA: 0x1809DF360
	public void UpdateBrushColor(Color col) { }

	// RVA: 0x9DF300 Offset: 0x9DE700 VA: 0x1809DF300
	public void UpdateBrushAlpha(float a) { }

	// RVA: 0x9DF3E0 Offset: 0x9DE7E0 VA: 0x1809DF3E0
	public void UpdateBrushEraser(bool b) { }

	// RVA: 0x9DF2B0 Offset: 0x9DE6B0 VA: 0x1809DF2B0
	private void OnChanged() { }

	// RVA: 0x9DF5A0 Offset: 0x9DE9A0 VA: 0x1809DF5A0
	public void .ctor() { }

}

public class UIPaintBox.OnBrushChanged : UnityEvent<Brush> // TypeDefIndex: 10967
{	// Methods

	// RVA: 0x9DCD00 Offset: 0x9DC100 VA: 0x1809DCD00
	public void .ctor() { }

}

public class UIBuffs : SingletonComponent<UIBuffs> // TypeDefIndex: 10970
{	// Fields
	public bool Enabled; // 0x18
	public Transform PrefabBuffIcon; // 0x20

	// Methods

	// RVA: 0x4D86C0 Offset: 0x4D7AC0 VA: 0x1804D86C0
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4D8880 Offset: 0x4D7C80 VA: 0x1804D8880
	private void RemoveAll() { }

	// RVA: 0x4D8A80 Offset: 0x4D7E80 VA: 0x1804D8A80
	public void .ctor() { }

}

public class UIBuffsIcon : SingletonComponent<UIBuffsIcon>, IPointerEnterHandler, IEventSystemHandler // TypeDefIndex: 10971
{	// Fields
	public TextMeshProUGUI Text; // 0x18
	public Tooltip ToolTip; // 0x20
	public CanvasGroup Group; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string Buffs; // 0x30

	// Methods

	// RVA: 0x4D7F60 Offset: 0x4D7360 VA: 0x1804D7F60 Slot: 9
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x4D7F70 Offset: 0x4D7370 VA: 0x1804D7F70
	private void Refresh() { }

	// RVA: 0x4D8140 Offset: 0x4D7540 VA: 0x1804D8140
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4D8660 Offset: 0x4D7A60 VA: 0x1804D8660
	public void .ctor() { }

}

public class UICompass : MonoBehaviour // TypeDefIndex: 10972
{	// Fields
	public RawImage compassStrip; // 0x18
	public CanvasGroup compassGroup; // 0x20
	public CompassMapMarker CompassMarker; // 0x28
	public CompassMapMarker TeamLeaderCompassMarker; // 0x30
	public List<CompassMissionMarker> MissionMarkers; // 0x38
	private bool compassToggle; // 0x40
	private Material compassStripMaterial; // 0x48
	private Material compassStripMaterialInst; // 0x50

	// Properties
	private static BasePlayer LocalPlayerEntity { get; }

	// Methods

	// RVA: 0x4DD1E0 Offset: 0x4DC5E0 VA: 0x1804DD1E0
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x4DCE30 Offset: 0x4DC230 VA: 0x1804DCE30
	private void OnEnable() { }

	// RVA: 0x4DC520 Offset: 0x4DB920 VA: 0x1804DC520
	public void CompassUpdate() { }

	// RVA: 0x4DD060 Offset: 0x4DC460 VA: 0x1804DD060
	private void UpdateCompassMarker(Vector3 rot, CompassMapMarker marker, MapNote forNote) { }

	// RVA: 0x4DCF20 Offset: 0x4DC320 VA: 0x1804DCF20
	private void UpdateCompassMarker(Vector3 rot, CompassMissionMarker marker, BaseMission.MissionInstance mission) { }

	// RVA: 0x4DC270 Offset: 0x4DB670 VA: 0x1804DC270
	private void CalculateCompassPosition(Vector3 worldPosition, Vector3 eyeRot, out bool show, out float xPos) { }

	// RVA: 0x4DCDD0 Offset: 0x4DC1D0 VA: 0x1804DCDD0
	private void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIFadeOut : MonoBehaviour // TypeDefIndex: 10973
{	// Fields
	public float secondsToFadeOut; // 0x18
	public bool destroyOnFaded; // 0x1C
	public CanvasGroup targetGroup; // 0x20
	public float fadeDelay; // 0x28
	private float timeStarted; // 0x2C

	// Methods

	// RVA: 0x4E0E80 Offset: 0x4E0280 VA: 0x1804E0E80
	private void Start() { }

	// RVA: 0x4E0EA0 Offset: 0x4E02A0 VA: 0x1804E0EA0
	private void Update() { }

	// RVA: 0x4E0FD0 Offset: 0x4E03D0 VA: 0x1804E0FD0
	public void .ctor() { }

}

public class UIFishing : SingletonComponent<UIFishing> // TypeDefIndex: 10974
{	// Fields
	public Slider TensionLine; // 0x18
	public Image FillImage; // 0x20
	public Gradient FillGradient; // 0x28
	private float lerpedValue; // 0x30

	// Methods

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void Start() { }

	// RVA: 0x4E2DC0 Offset: 0x4E21C0 VA: 0x1804E2DC0
	public void Toggle(bool state) { }

	// RVA: 0x4E2D80 Offset: 0x4E2180 VA: 0x1804E2D80
	public void ForceSetValue(float value) { }

	// RVA: 0x4E2E60 Offset: 0x4E2260 VA: 0x1804E2E60
	public void UpdateInfo(float tension) { }

	// RVA: 0x4E2F70 Offset: 0x4E2370 VA: 0x1804E2F70
	public void .ctor() { }

}

public class UIHUD : SingletonComponent<UIHUD>, IUIScreen // TypeDefIndex: 10975
{	// Fields
	public UIChat chatPanel; // 0x18
	public HudElement Hunger; // 0x20
	public HudElement Thirst; // 0x28
	public HudElement Health; // 0x30
	public HudElement PendingHealth; // 0x38
	public HudElement VehicleHealth; // 0x40
	public HudElement AnimalStamina; // 0x48
	public HudElement AnimalStaminaMax; // 0x50
	public RectTransform vitalsRect; // 0x58
	public Canvas healthCanvas; // 0x60
	public UICompass CompassWidget; // 0x68
	public GameObject KeyboardCaptureMode; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CanvasGroup <canvasGroup>k__BackingField; // 0x78
	private bool visible; // 0x80

	// Properties
	public CanvasGroup canvasGroup { get; set; }
	private bool shouldShowHud { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public CanvasGroup get_canvasGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	private void set_canvasGroup(CanvasGroup value) { }

	// RVA: 0x4E4450 Offset: 0x4E3850 VA: 0x1804E4450 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E4B10 Offset: 0x4E3F10 VA: 0x1804E4B10
	private void Update() { }

	// RVA: 0x4E4590 Offset: 0x4E3990 VA: 0x1804E4590
	private void UpdateVitals() { }

	// RVA: 0x4E4ED0 Offset: 0x4E42D0 VA: 0x1804E4ED0
	private bool get_shouldShowHud() { }

	// RVA: 0x4E44F0 Offset: 0x4E38F0 VA: 0x1804E44F0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E4E60 Offset: 0x4E4260 VA: 0x1804E4E60
	public void .ctor() { }

}

public class UIRecordingInfo : SingletonComponent<UIRecordingInfo> // TypeDefIndex: 10976
{	// Fields
	public RustText CountdownText; // 0x18
	public Slider TapeProgressSlider; // 0x20
	public GameObject CountdownRoot; // 0x28
	public GameObject RecordingRoot; // 0x30
	public Transform Spinner; // 0x38
	public float SpinSpeed; // 0x40
	public Image CassetteImage; // 0x48
	private RecorderTool cachedRecorder; // 0x50

	// Methods

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void Start() { }

	// RVA: 0x9E1C80 Offset: 0x9E1080 VA: 0x1809E1C80
	public void StartRecording(RecorderTool forRecorder) { }

	// RVA: 0x9E1CF0 Offset: 0x9E10F0 VA: 0x1809E1CF0
	public void StopRecording() { }

	// RVA: 0x9E1D40 Offset: 0x9E1140 VA: 0x1809E1D40
	private void Update() { }

	// RVA: 0x9E1C60 Offset: 0x9E1060 VA: 0x1809E1C60
	public void OnEscape() { }

	// RVA: 0x9E1FB0 Offset: 0x9E13B0 VA: 0x1809E1FB0
	public void .ctor() { }

}

public class UIUnderlay : SingletonComponent<UIUnderlay> // TypeDefIndex: 10977
{	// Fields
	public GameObject damageDirectional; // 0x18
	public GameObject waterDirectional; // 0x20

	// Methods

	// RVA: 0x9E3A30 Offset: 0x9E2E30 VA: 0x1809E3A30
	public void DirectionalDamage(Vector3 pos, DamageType dmgType, float damageTotal) { }

	// RVA: 0x9E3540 Offset: 0x9E2940 VA: 0x1809E3540
	public void DirectionalDamage_OLD(Vector3 pos, DamageType dmgType) { }

	// RVA: 0x9E3E10 Offset: 0x9E3210 VA: 0x1809E3E10
	private GameObject GetDamageTypePrefab(DamageType dmgType) { }

	// RVA: 0x9E3FF0 Offset: 0x9E33F0 VA: 0x1809E3FF0
	private Vector2 RectProjectEdge(Rect r, Vector2 v) { }

	// RVA: 0x9E41A0 Offset: 0x9E35A0 VA: 0x1809E41A0
	public void .ctor() { }

}

public class UIBlueprints : ListComponent<UIBlueprints> // TypeDefIndex: 10994
{	// Fields
	public GameObjectRef buttonPrefab; // 0x18
	public ScrollRect scrollRect; // 0x20
	public CanvasGroup ScrollRectCanvasGroup; // 0x28
	public InputField searchField; // 0x30
	public GameObject searchFieldPlaceholder; // 0x38
	public GameObject listAvailable; // 0x40
	public GameObject listLocked; // 0x48
	public GameObject Categories; // 0x50
	public VerticalLayoutGroup CategoryVerticalLayoutGroup; // 0x58
	public BlueprintCategoryButton FavouriteCategoryButton; // 0x60
	public bool needsResort; // 0x68
	private ItemCategory category; // 0x6C
	private List<BlueprintButton> buttons; // 0x70
	private BlueprintCategoryButton[] categoryButtons; // 0x78
	private static ItemCategory[] miscInclusive; // 0x0

	// Methods

	// RVA: 0x4D5EA0 Offset: 0x4D52A0 VA: 0x1804D5EA0
	public void ChangeCategory(string strCategory) { }

	// RVA: 0x4D7CB0 Offset: 0x4D70B0 VA: 0x1804D7CB0
	private void UpdateFlash() { }

	// RVA: 0x4D7020 Offset: 0x4D6420 VA: 0x1804D7020
	private void RetireChildren(GameObject go) { }

	// RVA: 0x4D6E00 Offset: 0x4D6200 VA: 0x1804D6E00 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4D6C00 Offset: 0x4D6000 VA: 0x1804D6C00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4D63E0 Offset: 0x4D57E0 VA: 0x1804D63E0
	public static IEnumerable<ItemBlueprint> GetForCategory(ItemCategory category) { }

	// RVA: 0x4D6390 Offset: 0x4D5790 VA: 0x1804D6390
	public static IEnumerable<ItemBlueprint> GetCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D5FE0 Offset: 0x4D53E0 VA: 0x1804D5FE0
	public static int CountCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D6040 Offset: 0x4D5440 VA: 0x1804D6040
	public static int CountForCategory(ItemCategory category, bool onlyUnlocked = True) { }

	// RVA: 0x4D7410 Offset: 0x4D6810 VA: 0x1804D7410
	public void UpdateBlueprintList() { }

	// RVA: 0x4D6320 Offset: 0x4D5720 VA: 0x1804D6320
	private BlueprintCategoryButton[] GetCategoryButtons() { }

	// RVA: 0x4D7790 Offset: 0x4D6B90 VA: 0x1804D7790
	private void UpdateBlueprints(IEnumerable<ItemBlueprint> list) { }

	// RVA: 0x4D6E40 Offset: 0x4D6240 VA: 0x1804D6E40
	public static void Refresh() { }

	// RVA: 0x4D70F0 Offset: 0x4D64F0 VA: 0x1804D70F0
	public void Search(string search) { }

	// RVA: 0x4D5CA0 Offset: 0x4D50A0 VA: 0x1804D5CA0
	public static void BounceFavouriteCategories() { }

	// RVA: 0x4D5E80 Offset: 0x4D5280 VA: 0x1804D5E80
	public void BounceFavouriteCategory() { }

	// RVA: 0x4D7EC0 Offset: 0x4D72C0 VA: 0x1804D7EC0
	public void .ctor() { }

	// RVA: 0x4D7E40 Offset: 0x4D7240 VA: 0x1804D7E40
	private static void .cctor() { }

}

private sealed class UIBlueprints.<>c__DisplayClass20_0 // TypeDefIndex: 10995
{	// Fields
	public ItemCategory category; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4D2450 Offset: 0x4D1850 VA: 0x1804D2450
	internal bool <GetForCategory>b__3(ItemBlueprint x) { }

	// RVA: 0x4D2560 Offset: 0x4D1960 VA: 0x1804D2560
	internal bool <GetForCategory>b__6(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c // TypeDefIndex: 10996
{	// Fields
	public static readonly UIBlueprints.<>c <>9; // 0x0
	public static Func<ItemBlueprint, bool> <>9__20_0; // 0x8
	public static Func<ItemBlueprint, bool> <>9__20_1; // 0x10
	public static Func<ItemBlueprint, int> <>9__20_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__20_4; // 0x20
	public static Func<ItemBlueprint, Rarity> <>9__20_5; // 0x28
	public static Func<ItemBlueprint, bool> <>9__20_7; // 0x30
	public static Func<ItemBlueprint, Rarity> <>9__20_8; // 0x38

	// Methods

	// RVA: 0x4D29A0 Offset: 0x4D1DA0 VA: 0x1804D29A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4D2240 Offset: 0x4D1640 VA: 0x1804D2240
	internal bool <GetForCategory>b__20_0(ItemBlueprint x) { }

	// RVA: 0x4D22B0 Offset: 0x4D16B0 VA: 0x1804D22B0
	internal bool <GetForCategory>b__20_1(ItemBlueprint x) { }

	// RVA: 0x4D2310 Offset: 0x4D1710 VA: 0x1804D2310
	internal int <GetForCategory>b__20_2(ItemBlueprint y) { }

	// RVA: 0x4D2370 Offset: 0x4D1770 VA: 0x1804D2370
	internal bool <GetForCategory>b__20_4(ItemBlueprint x) { }

	// RVA: 0x4D23D0 Offset: 0x4D17D0 VA: 0x1804D23D0
	internal Rarity <GetForCategory>b__20_5(ItemBlueprint x) { }

	// RVA: 0x4D23F0 Offset: 0x4D17F0 VA: 0x1804D23F0
	internal bool <GetForCategory>b__20_7(ItemBlueprint x) { }

	// RVA: 0x4D23D0 Offset: 0x4D17D0 VA: 0x1804D23D0
	internal Rarity <GetForCategory>b__20_8(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c__DisplayClass28_0 // TypeDefIndex: 10997
{	// Fields
	public string search; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4D2600 Offset: 0x4D1A00 VA: 0x1804D2600
	internal bool <Search>b__0(ItemBlueprint x) { }

}

public interface LootPanel.IHasLootPanel // TypeDefIndex: 11026
{	// Properties
	public abstract Translate.Phrase LootPanelTitle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Translate.Phrase get_LootPanelTitle();

}

public class UIBelt : SingletonComponent<UIBelt> // TypeDefIndex: 11051
{	// Fields
	public List<ItemIcon> ItemIcons; // 0x18

	// Methods

	// RVA: 0x4D51C0 Offset: 0x4D45C0 VA: 0x1804D51C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D5300 Offset: 0x4D4700 VA: 0x1804D5300
	public ItemIcon GetItemIconAtSlot(int slot) { }

	// RVA: 0x4D5370 Offset: 0x4D4770 VA: 0x1804D5370
	public void .ctor() { }

}

private sealed class UIBelt.<>c // TypeDefIndex: 11052
{	// Fields
	public static readonly UIBelt.<>c <>9; // 0x0
	public static Func<ItemIcon, int> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x4D28E0 Offset: 0x4D1CE0 VA: 0x1804D28E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4D2220 Offset: 0x4D1620 VA: 0x1804D2220
	internal int <Awake>b__1_0(ItemIcon s) { }

}

public class UIContacts : SingletonComponent<UIContacts> // TypeDefIndex: 11053
{	// Fields
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public ContactsPanel contactsPanel; // 0x18
	private GameObject Inset; // 0x20
	private float returnX; // 0x28
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private ItemIcon[] inventoryItemIcons; // 0x30

	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x4DDE50 Offset: 0x4DD250 VA: 0x1804DDE50
	public static void togglecontacts() { }

	// RVA: 0x4DD280 Offset: 0x4DC680 VA: 0x1804DD280 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4DD7A0 Offset: 0x4DCBA0 VA: 0x1804DD7A0
	public static void Open() { }

	// RVA: 0x4DDC50 Offset: 0x4DD050 VA: 0x1804DDC50
	public static void Toggle() { }

	// RVA: 0x4DD4A0 Offset: 0x4DC8A0 VA: 0x1804DD4A0
	public static void Close() { }

	// RVA: 0x4DDD60 Offset: 0x4DD160 VA: 0x1804DDD60
	private void Update() { }

	// RVA: 0x4DDA30 Offset: 0x4DCE30 VA: 0x1804DDA30
	private bool ShouldShow() { }

	// RVA: 0x4DD730 Offset: 0x4DCB30 VA: 0x1804DD730
	public void ContactsPressed() { }

	// RVA: 0x4DDDF0 Offset: 0x4DD1F0 VA: 0x1804DDDF0
	public void .ctor() { }

}

public class UICrafting : SingletonComponent<UICrafting> // TypeDefIndex: 11054
{	// Fields
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private GameObject Inset; // 0x18
	private float returnX; // 0x20

	// Methods

	// RVA: 0x4DE740 Offset: 0x4DDB40 VA: 0x1804DE740 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4DED30 Offset: 0x4DE130 VA: 0x1804DED30
	public static void Open() { }

	// RVA: 0x4DF210 Offset: 0x4DE610 VA: 0x1804DF210
	public static void Toggle() { }

	// RVA: 0x4DE960 Offset: 0x4DDD60 VA: 0x1804DE960
	public static void Close() { }

	// RVA: 0x4DF320 Offset: 0x4DE720 VA: 0x1804DF320
	private void Update() { }

	// RVA: 0x4DEFB0 Offset: 0x4DE3B0 VA: 0x1804DEFB0
	private bool ShouldShow() { }

	// RVA: 0x4DF3B0 Offset: 0x4DE7B0 VA: 0x1804DF3B0
	public void .ctor() { }

}

public class UIIntegerEntry : MonoBehaviour // TypeDefIndex: 11055
{	// Fields
	public InputField textEntry; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action textChanged; // 0x20

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E5C80 Offset: 0x4E5080 VA: 0x1804E5C80
	public void add_textChanged(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E5D20 Offset: 0x4E5120 VA: 0x1804E5D20
	public void remove_textChanged(Action value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4F30 VA: 0x1804E5B30
	public void OnAmountTextChanged() { }

	// RVA: 0x4E5C00 Offset: 0x4E5000 VA: 0x1804E5C00
	public void SetAmount(int amount) { }

	// RVA: 0x4E5AF0 Offset: 0x4E4EF0 VA: 0x1804E5AF0
	public int GetIntAmount() { }

	// RVA: 0x4E5B50 Offset: 0x4E4F50 VA: 0x1804E5B50
	public void PlusMinus(int delta) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIInventory : SingletonComponent<UIInventory> // TypeDefIndex: 11056
{	// Fields
	public TextMeshProUGUI PlayerName; // 0x18
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public VerticalLayoutGroup rightContents; // 0x20
	public GameObject QuickCraft; // 0x28
	public Transform InventoryIconContainer; // 0x30
	public ContactsPanel contactsPanel; // 0x38
	private static uint currentQuickLootContainerID; // 0x8
	private GameObject Inset; // 0x40
	private float returnX; // 0x48
	private static CanvasGroup canvasGroup; // 0x10
	private static GraphicRaycaster graphicRaycster; // 0x18
	private ItemIcon[] inventoryItemIcons; // 0x50
	public UnderwearSkinPicker underwearSkinPicker; // 0x58
	private static TimeSince lastCloseSoundPlay; // 0x20

	// Methods

	// RVA: 0x4E5DC0 Offset: 0x4E51C0 VA: 0x1804E5DC0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E6A20 Offset: 0x4E5E20 VA: 0x1804E6A20
	public static void Open(bool selectHeldItem = True) { }

	// RVA: 0x4E78D0 Offset: 0x4E6CD0 VA: 0x1804E78D0
	public static void ToggleInventory() { }

	// RVA: 0x4E6170 Offset: 0x4E5570 VA: 0x1804E6170
	public static void Close() { }

	// RVA: 0x4E7030 Offset: 0x4E6430 VA: 0x1804E7030
	private static void PlayCloseSound() { }

	// RVA: 0x4E6960 Offset: 0x4E5D60 VA: 0x1804E6960
	public static void OpenLoot(string lootType) { }

	// RVA: 0x4E6030 Offset: 0x4E5430 VA: 0x1804E6030
	public static bool CanQuickLootItem(Item item, ItemContainerSource containerSource) { }

	// RVA: 0x4E7AF0 Offset: 0x4E6EF0 VA: 0x1804E7AF0
	private void Update() { }

	// RVA: 0x4E7670 Offset: 0x4E6A70 VA: 0x1804E7670
	private bool ShouldShow() { }

	// RVA: 0x4E6140 Offset: 0x4E5540 VA: 0x1804E6140
	public void CloseUnderwearPicker() { }

	// RVA: 0x4E7A50 Offset: 0x4E6E50 VA: 0x1804E7A50
	public void ToggleUnderwearPicker() { }

	// RVA: 0x4E68F0 Offset: 0x4E5CF0 VA: 0x1804E68F0
	public void ContactsPressed() { }

	// RVA: 0x4E7E00 Offset: 0x4E7200 VA: 0x1804E7E00
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public interface IContainerSounds // TypeDefIndex: 11057
{	// Properties
	public abstract SoundDefinition OpenSound { get; }
	public abstract SoundDefinition CloseSound { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SoundDefinition get_OpenSound();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract SoundDefinition get_CloseSound();

}

public class UIMixingTableItem : MonoBehaviour // TypeDefIndex: 11058
{	// Fields
	public Image ItemIcon; // 0x18
	public Tooltip ItemTooltip; // 0x20
	public RustText TextItemNameAndQuantity; // 0x28
	public UIMixingTableItemIngredient[] Ingredients; // 0x30

	// Methods

	// RVA: 0x9DF0B0 Offset: 0x9DE4B0 VA: 0x1809DF0B0
	public void Init(Recipe recipe) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIMixingTableItemIngredient : MonoBehaviour // TypeDefIndex: 11059
{	// Fields
	public Image ItemIcon; // 0x18
	public Text ItemCount; // 0x20
	public Tooltip ToolTip; // 0x28

	// Methods

	// RVA: 0x9DEF60 Offset: 0x9DE360 VA: 0x1809DEF60
	public void Init(Recipe.RecipeIngredient ingredient) { }

	// RVA: 0x9DEF10 Offset: 0x9DE310 VA: 0x1809DEF10
	public void InitBlank() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public interface VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 11065
{	// Properties
	public abstract int SocketsTaken { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_SocketsTaken();

}

public class UIPaintableImage : MonoBehaviour // TypeDefIndex: 11186
{	// Fields
	public RawImage image; // 0x18
	public int texSize; // 0x20
	public Color clearColor; // 0x24
	public FilterMode filterMode; // 0x34
	public bool mipmaps; // 0x38
	public int imageNumber; // 0x3C
	public uint imageHash; // 0x40
	public bool isLocked; // 0x44
	public bool isLoading; // 0x45
	public bool isBlank; // 0x46
	public bool needsApply; // 0x47
	internal Texture2D texture; // 0x48

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x9E06E0 Offset: 0x9DFAE0 VA: 0x1809E06E0
	public RectTransform get_rectTransform() { }

	// RVA: 0x9E0450 Offset: 0x9DF850 VA: 0x1809E0450
	private void Start() { }

	// RVA: 0x9E0600 Offset: 0x9DFA00 VA: 0x1809E0600
	private void Update() { }

	// RVA: 0x9E02A0 Offset: 0x9DF6A0 VA: 0x1809E02A0
	public void SetupTexture() { }

	// RVA: 0x9DF6C0 Offset: 0x9DEAC0 VA: 0x1809DF6C0
	public void Clear() { }

	// RVA: 0x9E01C0 Offset: 0x9DF5C0 VA: 0x1809E01C0
	private void OnDestroy() { }

	// RVA: 0x9DF630 Offset: 0x9DEA30 VA: 0x1809DF630
	public void ClearTexture() { }

	// RVA: 0x9E0180 Offset: 0x9DF580 VA: 0x1809E0180
	public void FromData(byte[] data) { }

	// RVA: 0x9E0540 Offset: 0x9DF940 VA: 0x1809E0540
	public byte[] ToPng(BaseEntity ent) { }

	// RVA: 0x9E0470 Offset: 0x9DF870 VA: 0x1809E0470
	public byte[] ToJpg(BaseEntity ent, int quality) { }

	// RVA: 0x9DF6D0 Offset: 0x9DEAD0 VA: 0x1809DF6D0
	public void DrawTexture(Vector2 pos, Vector2 size, Texture2D brush, Color textureColor, UIPaintableImage.DrawMode mode) { }

	// RVA: 0x9E0690 Offset: 0x9DFA90 VA: 0x1809E0690
	public void .ctor() { }

}

public enum UIPaintableImage.DrawMode // TypeDefIndex: 11187
{	// Fields
	public int value__; // 0x0
	public const UIPaintableImage.DrawMode AlphaBlended = 0;
	public const UIPaintableImage.DrawMode Additive = 1;
	public const UIPaintableImage.DrawMode Lighten = 2;
	public const UIPaintableImage.DrawMode Erase = 3;

}

public class UIParticle : BaseMonoBehaviour // TypeDefIndex: 11188
{	// Fields
	public Vector2 LifeTime; // 0x18
	public Vector2 Gravity; // 0x20
	public Vector2 InitialX; // 0x28
	public Vector2 InitialY; // 0x30
	public Vector2 InitialScale; // 0x38
	public Vector2 InitialDelay; // 0x40
	public Vector2 ScaleVelocity; // 0x48
	public Gradient InitialColor; // 0x50
	private float lifetime; // 0x58
	private float gravity; // 0x5C
	private Vector2 velocity; // 0x60
	private float scaleVelocity; // 0x68

	// Methods

	// RVA: 0x9E0740 Offset: 0x9DFB40 VA: 0x1809E0740
	public static void Add(UIParticle particleSource, RectTransform spawnPosition, RectTransform particleCanvas) { }

	// RVA: 0x9E0AD0 Offset: 0x9DFED0 VA: 0x1809E0AD0
	private void Start() { }

	// RVA: 0x9E0D60 Offset: 0x9E0160 VA: 0x1809E0D60
	private void Update() { }

	// RVA: 0x9E0A70 Offset: 0x9DFE70 VA: 0x1809E0A70
	private void Die() { }

	// RVA: 0x9E1090 Offset: 0x9E0490 VA: 0x1809E1090
	public void .ctor() { }

}

public static class UISound // TypeDefIndex: 11195
{	// Fields
	private static AudioSource source; // 0x2B0AAB0

	// Methods

	// RVA: 0x9E3030 Offset: 0x9E2430 VA: 0x1809E3030
	private static AudioSource GetAudioSource() { }

	// RVA: 0x9E3150 Offset: 0x9E2550 VA: 0x1809E3150
	public static void Play(AudioClip clip, float volume = 1) { }

}

public class UIPlayerPreviewControls : SingletonComponent<UIPlayerPreviewControls>, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11200
{	// Fields
	public float RotationSpeed; // 0x18
	public float RotationLerpSpeed; // 0x1C
	public float RotationStopLerpSpeed; // 0x20
	private bool rotating; // 0x24
	private bool pointerInControlArea; // 0x25
	private float rotationVelocity; // 0x28
	private float horizRotationPerc; // 0x2C
	private float startingRotation; // 0x30
	private Vector3 dragInputPos; // 0x34
	private Vector3 currentDragInputPos; // 0x40
	private Vector3 rotation; // 0x4C
	private Transform previewModel; // 0x58
	private CanvasGroup canvasGroup; // 0x60
	private bool showInventoryPlayer; // 0x68

	// Methods

	// RVA: 0x9E1380 Offset: 0x9E0780 VA: 0x1809E1380 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9E1720 Offset: 0x9E0B20 VA: 0x1809E1720 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x9E1730 Offset: 0x9E0B30 VA: 0x1809E1730 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x9E18D0 Offset: 0x9E0CD0 VA: 0x1809E18D0
	private void Update() { }

	// RVA: 0x9E1810 Offset: 0x9E0C10 VA: 0x1809E1810
	private void ToggleDisplay() { }

	// RVA: 0x9E1130 Offset: 0x9E0530 VA: 0x1809E1130
	private void ApplyRotation() { }

	// RVA: 0x9E1540 Offset: 0x9E0940 VA: 0x1809E1540
	private void HandleRotationControl() { }

	// RVA: 0x9E1740 Offset: 0x9E0B40 VA: 0x1809E1740
	public void ResetToDefault() { }

	// RVA: 0x9E1410 Offset: 0x9E0810 VA: 0x1809E1410
	private Transform GetPlayerModel() { }

	// RVA: 0x9E1A00 Offset: 0x9E0E00 VA: 0x1809E1A00
	public void .ctor() { }

}

public class UIInvertedMaskImage : Image // TypeDefIndex: 11203
{	// Fields
	private Material cachedMaterial; // 0x100

	// Properties
	public override Material materialForRendering { get; }

	// Methods

	// RVA: 0x4E7EC0 Offset: 0x4E72C0 VA: 0x1804E7EC0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x4E7E60 Offset: 0x4E7260 VA: 0x1804E7E60
	public void .ctor() { }

}

public class UIAutoPanelCloser : MonoBehaviour // TypeDefIndex: 11241
{	// Fields
	public UIDialog Dialog; // 0x18

	// Methods

	// RVA: 0x4D4D90 Offset: 0x4D4190 VA: 0x1804D4D90
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIBackgroundBlur : ListComponent<UIBackgroundBlur>, IClientComponent // TypeDefIndex: 11242
{	// Fields
	public float amount; // 0x18

	// Properties
	public static float currentMax { get; }

	// Methods

	// RVA: 0x4D5020 Offset: 0x4D4420 VA: 0x1804D5020
	public static float get_currentMax() { }

	// RVA: 0x4D4FC0 Offset: 0x4D43C0 VA: 0x1804D4FC0
	public void .ctor() { }

}

public class UIBlackoutOverlay : MonoBehaviour // TypeDefIndex: 11243
{	// Fields
	public CanvasGroup group; // 0x18
	public static Dictionary<UIBlackoutOverlay.blackoutType, UIBlackoutOverlay> instances; // 0x0
	public UIBlackoutOverlay.blackoutType overlayType; // 0x20
	private Vector3 initialPosition; // 0x24
	private float myAlpha; // 0x30

	// Methods

	// RVA: 0x4D53D0 Offset: 0x4D47D0 VA: 0x1804D53D0
	public static void AddOverlay(UIBlackoutOverlay.blackoutType type, UIBlackoutOverlay overlay) { }

	// RVA: 0x4D5630 Offset: 0x4D4A30 VA: 0x1804D5630
	public static UIBlackoutOverlay Get(UIBlackoutOverlay.blackoutType type) { }

	// RVA: 0x4D5710 Offset: 0x4D4B10 VA: 0x1804D5710
	public static void HideAll() { }

	// RVA: 0x4D5490 Offset: 0x4D4890 VA: 0x1804D5490
	private void Awake() { }

	// RVA: 0x4D5870 Offset: 0x4D4C70 VA: 0x1804D5870
	public void ResetPosition() { }

	// RVA: 0x4D5A00 Offset: 0x4D4E00 VA: 0x1804D5A00
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 GetPosition() { }

	// RVA: 0x4D5AA0 Offset: 0x4D4EA0 VA: 0x1804D5AA0
	public void Update() { }

	// RVA: 0x4D5950 Offset: 0x4D4D50 VA: 0x1804D5950
	public void SetAlpha(float alpha) { }

	// RVA: 0x4D55A0 Offset: 0x4D49A0 VA: 0x1804D55A0
	public float GetAlpha() { }

	// RVA: 0x4D5C20 Offset: 0x4D5020 VA: 0x1804D5C20
	public void .ctor() { }

}

public enum UIBlackoutOverlay.blackoutType // TypeDefIndex: 11244
{	// Fields
	public int value__; // 0x0
	public const UIBlackoutOverlay.blackoutType FULLBLACK = 0;
	public const UIBlackoutOverlay.blackoutType BINOCULAR = 1;
	public const UIBlackoutOverlay.blackoutType SCOPE = 2;
	public const UIBlackoutOverlay.blackoutType HELMETSLIT = 3;
	public const UIBlackoutOverlay.blackoutType SNORKELGOGGLE = 4;
	public const UIBlackoutOverlay.blackoutType NVG = 5;
	public const UIBlackoutOverlay.blackoutType FULLWHITE = 6;
	public const UIBlackoutOverlay.blackoutType SUNGLASSES = 7;
	public const UIBlackoutOverlay.blackoutType NONE = 64;

}

public class UICameraOverlay : SingletonComponent<UICameraOverlay> // TypeDefIndex: 11245
{	// Fields
	public static readonly Translate.Phrase FocusOffText; // 0x0
	public static readonly Translate.Phrase FocusAutoText; // 0x8
	public static readonly Translate.Phrase FocusManualText; // 0x10
	public CanvasGroup CanvasGroup; // 0x18
	public RustText FocusModeLabel; // 0x20

	// Methods

	// RVA: 0x4D8C30 Offset: 0x4D8030 VA: 0x1804D8C30
	public void Show() { }

	// RVA: 0x4D8AE0 Offset: 0x4D7EE0 VA: 0x1804D8AE0
	public void Hide() { }

	// RVA: 0x4D8B10 Offset: 0x4D7F10 VA: 0x1804D8B10
	public void SetFocusMode(CameraFocusMode mode) { }

	// RVA: 0x4D8D60 Offset: 0x4D8160 VA: 0x1804D8D60
	public void .ctor() { }

	// RVA: 0x4D8C60 Offset: 0x4D8060 VA: 0x1804D8C60
	private static void .cctor() { }

}

public class UIConversationScreen : SingletonComponent<UIConversationScreen>, IUIScreen // TypeDefIndex: 11246
{	// Fields
	public NeedsCursor needsCursor; // 0x18
	public RectTransform conversationPanel; // 0x20
	public RustText conversationSpeechBody; // 0x28
	public RustText conversationProviderName; // 0x30
	public RustButton[] responseButtons; // 0x38
	public RectTransform letterBoxTop; // 0x40
	public RectTransform letterBoxBottom; // 0x48
	protected CanvasGroup canvasGroup; // 0x50
	private int currentlyDisplayedSpeechIndex; // 0x58
	private bool visible; // 0x5C
	private LayoutGroup[] layoutGroups; // 0x60
	private bool wasTalking; // 0x68

	// Methods

	// RVA: 0x4DDF70 Offset: 0x4DD370 VA: 0x1804DDF70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4DE4D0 Offset: 0x4DD8D0 VA: 0x1804DE4D0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4DDFF0 Offset: 0x4DD3F0 VA: 0x1804DDFF0
	public void Exit() { }

	// RVA: 0x4DE000 Offset: 0x4DD400 VA: 0x1804DE000
	public void FastForward() { }

	// RVA: 0x4DE6D0 Offset: 0x4DDAD0 VA: 0x1804DE6D0
	public void Update() { }

	// RVA: 0x4DE010 Offset: 0x4DD410 VA: 0x1804DE010
	public void Refresh(bool force = False) { }

	// RVA: 0x4DE410 Offset: 0x4DD810 VA: 0x1804DE410
	public void ResponsePressed(int responseIndex) { }

	// RVA: 0x4DE6E0 Offset: 0x4DDAE0 VA: 0x1804DE6E0
	public void .ctor() { }

}

public class UIDeathScreen : SingletonComponent<UIDeathScreen>, IUIScreen // TypeDefIndex: 11247
{	// Fields
	public LifeInfographic previousLifeInfographic; // 0x18
	public Animator screenAnimator; // 0x20
	public bool fadeIn; // 0x28
	public Button ReportCheatButton; // 0x30
	public MapView View; // 0x38
	public List<SleepingBagButton> sleepingBagButtons; // 0x40
	public UIDeathScreen.RespawnColourScheme[] RespawnColourSchemes; // 0x48
	public GameObject RespawnScrollGradient; // 0x50
	public ScrollRect RespawnScrollRect; // 0x58
	public ExpandedLifeStats ExpandedStats; // 0x60
	public CanvasGroup StreamerModeContainer; // 0x68
	protected CanvasGroup canvasGroup; // 0x70
	protected GraphicRaycaster graphicRaycaster; // 0x78
	protected NeedsCursor needsCursor; // 0x80
	private bool visible; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RespawnInformation <currentRespawnInfo>k__BackingField; // 0x90

	// Properties
	public RespawnInformation currentRespawnInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public RespawnInformation get_currentRespawnInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	private void set_currentRespawnInfo(RespawnInformation value) { }

	// RVA: 0x4DF410 Offset: 0x4DE810 VA: 0x1804DF410 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4DFAC0 Offset: 0x4DEEC0 VA: 0x1804DFAC0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4DF720 Offset: 0x4DEB20 VA: 0x1804DF720
	private void OnEnable() { }

	// RVA: 0x4DF890 Offset: 0x4DEC90 VA: 0x1804DF890
	public void OnRespawn() { }

	// RVA: 0x4E02F0 Offset: 0x4DF6F0 VA: 0x1804E02F0
	private void UpdateRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4E05A0 Offset: 0x4DF9A0 VA: 0x1804E05A0
	private void UpdateRespawnOptions(List<RespawnInformation.SpawnOptions> spawnOptions) { }

	// RVA: 0x4DF640 Offset: 0x4DEA40 VA: 0x1804DF640
	private SleepingBagButton GetSleepingBagButton() { }

	// RVA: 0x4DF920 Offset: 0x4DED20 VA: 0x1804DF920
	public void PopulateDeathInfo() { }

	// RVA: 0x4DF430 Offset: 0x4DE830 VA: 0x1804DF430
	public void EnableInteraction() { }

	// RVA: 0x4DF7B0 Offset: 0x4DEBB0 VA: 0x1804DF7B0
	public static void OnRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4DF940 Offset: 0x4DED40 VA: 0x1804DF940
	public void ReportCheater() { }

	// RVA: 0x4DF4D0 Offset: 0x4DE8D0 VA: 0x1804DF4D0
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x4DF460 Offset: 0x4DE860 VA: 0x1804DF460
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(int index) { }

	// RVA: 0x4E0200 Offset: 0x4DF600 VA: 0x1804E0200
	public void UpdateBottomScrollGradient() { }

	// RVA: 0x4E0960 Offset: 0x4DFD60 VA: 0x1804E0960
	public void .ctor() { }

}

public struct UIDeathScreen.RespawnColourScheme // TypeDefIndex: 11248
{	// Fields
	public Color BackgroundColour; // 0x0
	public Color CircleRimColour; // 0x10
	public Color CircleFillColour; // 0x20

}

public class UIEscapeCapture : ListComponent<UIEscapeCapture> // TypeDefIndex: 11249
{	// Fields
	public UnityEvent onEscape; // 0x18

	// Methods

	// RVA: 0x4E0C70 Offset: 0x4E0070 VA: 0x1804E0C70
	public static bool EscapePressed() { }

	// RVA: 0x4E0DF0 Offset: 0x4E01F0 VA: 0x1804E0DF0
	public void .ctor() { }

}

public class UIFogOverlay : MonoBehaviour // TypeDefIndex: 11250
{	// Fields
	public static UIFogOverlay Instance; // 0x0
	public CanvasGroup group; // 0x18
	public Color baseColor; // 0x20
	public Image overlayImage; // 0x30

	// Methods

	// RVA: 0x4E3040 Offset: 0x4E2440 VA: 0x1804E3040
	public static void SetAlpha(float alpha) { }

	// RVA: 0x4E2FD0 Offset: 0x4E23D0 VA: 0x1804E2FD0
	public void OnEnable() { }

	// RVA: 0x4E30A0 Offset: 0x4E24A0 VA: 0x1804E30A0
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIGene : MonoBehaviour // TypeDefIndex: 11251
{	// Fields
	public GameObject Child; // 0x18
	public Color PositiveColour; // 0x20
	public Color NegativeColour; // 0x30
	public Color PositiveTextColour; // 0x40
	public Color NegativeTextColour; // 0x50
	public Image ImageBG; // 0x60
	public Text TextGene; // 0x68

	// Methods

	// RVA: 0x4E37E0 Offset: 0x4E2BE0 VA: 0x1804E37E0
	public void Init(GrowableGene gene) { }

	// RVA: 0x4E36F0 Offset: 0x4E2AF0 VA: 0x1804E36F0
	public void InitPrevious(GrowableGene gene) { }

	// RVA: 0x4E36C0 Offset: 0x4E2AC0 VA: 0x1804E36C0
	public void Hide() { }

	// RVA: 0x4E38E0 Offset: 0x4E2CE0 VA: 0x1804E38E0
	public void Show() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIGenesDisplay : MonoBehaviour // TypeDefIndex: 11252
{	// Fields
	public UIGene[] GeneUI; // 0x18
	public Text[] TextLinks; // 0x20
	public Text[] TextDiagLinks; // 0x28

	// Methods

	// RVA: 0x4E4040 Offset: 0x4E3440 VA: 0x1804E4040
	public void Init(GrowableGenes genes) { }

	// RVA: 0x4E3910 Offset: 0x4E2D10 VA: 0x1804E3910
	public void InitDualRow(GrowableGenes genes, bool firstRow) { }

	// RVA: 0x4E3930 Offset: 0x4E2D30 VA: 0x1804E3930
	private void InitFirstRow(GrowableGenes genes) { }

	// RVA: 0x4E3C70 Offset: 0x4E3070 VA: 0x1804E3C70
	private void InitSecondRow(GrowableGenes genes) { }

	// RVA: 0x4E4230 Offset: 0x4E3630 VA: 0x1804E4230
	private void ShowDiagLink(int index, float rotation, GrowableGene nextGene) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIIngame : SingletonComponent<UIIngame> // TypeDefIndex: 11253
{	// Methods

	// RVA: 0x4E57A0 Offset: 0x4E4BA0 VA: 0x1804E57A0
	private void Update() { }

	// RVA: 0x4E51F0 Offset: 0x4E45F0 VA: 0x1804E51F0
	private IUIScreen DetermineActiveUI() { }

	// RVA: 0x4E5A90 Offset: 0x4E4E90 VA: 0x1804E5A90
	public void .ctor() { }

}

public class UIPrefab : MonoBehaviour // TypeDefIndex: 11254
{	// Fields
	public GameObject prefabSource; // 0x18
	internal GameObject createdGameObject; // 0x20

	// Methods

	// RVA: 0x9E1A70 Offset: 0x9E0E70 VA: 0x1809E1A70
	private void Awake() { }

	// RVA: 0x9E1BB0 Offset: 0x9E0FB0 VA: 0x1809E1BB0
	public void SetVisible(bool visible) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public abstract class UIRoot : MonoBehaviour // TypeDefIndex: 11255
{	// Fields
	private GraphicRaycaster[] graphicRaycasters; // 0x18
	public Canvas overlayCanvas; // 0x20

	// Methods

	// RVA: 0x9E2420 Offset: 0x9E1820 VA: 0x1809E2420
	private void ToggleRaycasters(bool state) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9E23D0 Offset: 0x9E17D0 VA: 0x1809E23D0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210
	protected void Update() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void Refresh();

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class UIRootPixel : UIRoot // TypeDefIndex: 11256
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected override void Refresh() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIRootScaled : UIRoot // TypeDefIndex: 11257
{	// Fields
	private static UIRootScaled Instance; // 0x0
	public bool OverrideReference; // 0x28
	public Vector2 TargetReference; // 0x2C
	public CanvasScaler scaler; // 0x38

	// Properties
	public static Canvas DragOverlayCanvas { get; }

	// Methods

	// RVA: 0x9E2360 Offset: 0x9E1760 VA: 0x1809E2360
	public static Canvas get_DragOverlayCanvas() { }

	// RVA: 0x9E2010 Offset: 0x9E1410 VA: 0x1809E2010 Slot: 4
	protected override void Awake() { }

	// RVA: 0x9E2070 Offset: 0x9E1470 VA: 0x1809E2070 Slot: 6
	protected override void Refresh() { }

	// RVA: 0x9E2310 Offset: 0x9E1710 VA: 0x1809E2310
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class UIScale : MonoBehaviour, IClientComponent // TypeDefIndex: 11258
{	// Fields
	public CanvasScaler scaler; // 0x18

	// Methods

	// RVA: 0x9E24D0 Offset: 0x9E18D0 VA: 0x1809E24D0
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIScalerOverride : MonoBehaviour // TypeDefIndex: 11259
{	// Fields
	public AnimationCurve scaleCurve; // 0x18
	private CanvasScaler rootScaler; // 0x20
	private Canvas rootCanvas; // 0x28
	private Vector3 defaultScale; // 0x30

	// Methods

	// RVA: 0x9E2670 Offset: 0x9E1A70 VA: 0x1809E2670
	private void Start() { }

	// RVA: 0x9E2720 Offset: 0x9E1B20 VA: 0x1809E2720
	private void Update() { }

	// RVA: 0x9E28B0 Offset: 0x9E1CB0 VA: 0x1809E28B0
	public void .ctor() { }

}

public class UIScopeOverlay : MonoBehaviour // TypeDefIndex: 11260
{	// Fields
	public CanvasGroup group; // 0x18
	public static UIScopeOverlay instance; // 0x0
	public Image scopeImage; // 0x20
	private Vector3 initialPosition; // 0x28

	// Methods

	// RVA: 0x9E2C90 Offset: 0x9E2090 VA: 0x1809E2C90
	public void SetScopeMaterial(Material newMat) { }

	// RVA: 0x9E2950 Offset: 0x9E1D50 VA: 0x1809E2950
	private void Awake() { }

	// RVA: 0x9E2BF0 Offset: 0x9E1FF0 VA: 0x1809E2BF0
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 GetPosition() { }

	// RVA: 0x9E2A60 Offset: 0x9E1E60 VA: 0x1809E2A60
	public void SetAlpha(float alpha) { }

	// RVA: 0x9E29D0 Offset: 0x9E1DD0 VA: 0x1809E29D0
	public float GetAlpha() { }

	// RVA: 0x9E2CC0 Offset: 0x9E20C0 VA: 0x1809E2CC0
	public void .ctor() { }

}

public interface IUIScreen // TypeDefIndex: 11261
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetVisible(bool b);

}

public class UISleepingScreen : SingletonComponent<UISleepingScreen>, IUIScreen // TypeDefIndex: 11262
{	// Fields
	protected CanvasGroup canvasGroup; // 0x18
	private bool visible; // 0x20

	// Methods

	// RVA: 0x9E2D30 Offset: 0x9E2130 VA: 0x1809E2D30 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9E2D90 Offset: 0x9E2190 VA: 0x1809E2D90 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x9E2E50 Offset: 0x9E2250 VA: 0x1809E2E50
	public void .ctor() { }

}

public class UISoundPlayer : MonoBehaviour // TypeDefIndex: 11263
{	// Methods

	// RVA: 0x9E2EF0 Offset: 0x9E22F0 VA: 0x1809E2EF0
	public void PlaySound(AudioClip clip) { }

	// RVA: 0x9E2EB0 Offset: 0x9E22B0 VA: 0x1809E2EB0
	public void PlaySoundDef(SoundDefinition sound) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIVoiceIcon : MonoBehaviour // TypeDefIndex: 11264
{	// Fields
	public Text nameText; // 0x18
	public RawImage avatar; // 0x20

	// Methods

	// RVA: 0x9E4200 Offset: 0x9E3600 VA: 0x1809E4200
	public void Setup(ulong steamid, string name) { }

	// RVA: 0x9E4330 Offset: 0x9E3730 VA: 0x1809E4330
	public void UpdateVolume(float volume) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UIWounded : MonoBehaviour // TypeDefIndex: 11265
{	// Fields
	public CanvasGroup group; // 0x18

	// Methods

	// RVA: 0x9E4640 Offset: 0x9E3A40 VA: 0x1809E4640
	private void Update() { }

	// RVA: 0x9E44A0 Offset: 0x9E38A0 VA: 0x1809E44A0
	private bool ShouldShow() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class UI_LocalVoice : PriorityListComponent<UI_LocalVoice> // TypeDefIndex: 11266
{	// Fields
	public CanvasGroup voiceCanvas; // 0x18
	public CanvasGroup levelImage; // 0x20

	// Methods

	// RVA: 0x9E4810 Offset: 0x9E3C10 VA: 0x1809E4810 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x9E4880 Offset: 0x9E3C80 VA: 0x1809E4880
	public void SetRecording(bool b) { }

	// RVA: 0x9E4860 Offset: 0x9E3C60 VA: 0x1809E4860
	public void SetLevel(float f) { }

	// RVA: 0x9E48B0 Offset: 0x9E3CB0 VA: 0x1809E48B0
	public void .ctor() { }

}

public interface IDraggable // TypeDefIndex: 11268
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetDragData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetDragType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Sprite GetDragSprite();

}

public interface IVitalNotice // TypeDefIndex: 11277
{	// Properties
	public abstract bool IsActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Refresh();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsActive();

}

public interface IInventoryChanged // TypeDefIndex: 11374
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInventoryChanged();

}

public interface IViewModeChanged // TypeDefIndex: 11375
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnViewModeChanged();

}

public interface IClothingChanged // TypeDefIndex: 11376
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnClothingChanged();

}

public interface IViewModelUpdated // TypeDefIndex: 11377
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnViewModelUpdated();

}

public interface IBlueprintsChanged // TypeDefIndex: 11378
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBlueprintsChanged();

}

public interface IItemAmountChanged // TypeDefIndex: 11379
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemAmountChanged();

}

public interface IItemIconChanged // TypeDefIndex: 11380
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemIconChanged();

}

public interface IProvider // TypeDefIndex: 11671
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Info GetMenuInformation(GameObject primaryObject, BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<Option> GetMenuItems(BasePlayer player);

}

public static class UIEx // TypeDefIndex: 11706
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1122F40 Offset: 0x1122340 VA: 0x181122F40
	public static Vector2 Unpivot(RectTransform rect, Vector2 localPos) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1122BE0 Offset: 0x1121FE0 VA: 0x181122BE0
	public static void CenterOnPosition(ScrollRect scrollrect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1122EF0 Offset: 0x11222F0 VA: 0x181122EF0
	public static void RebuildHackUnity2019(Image image) { }

}

public class UICircle : UIPrimitiveBase // TypeDefIndex: 11712
{	// Fields
	[TooltipAttribute] // RVA: 0xD9530 Offset: 0xD8930 VA: 0x1800D9530
	public bool ArcInvert; // 0xF0
	[TooltipAttribute] // RVA: 0xD9620 Offset: 0xD8A20 VA: 0x1800D9620
	[RangeAttribute] // RVA: 0xD9620 Offset: 0xD8A20 VA: 0x1800D9620
	public float Arc; // 0xF4
	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF8
	[TooltipAttribute] // RVA: 0xD99A0 Offset: 0xD8DA0 VA: 0x1800D99A0
	[RangeAttribute] // RVA: 0xD99A0 Offset: 0xD8DA0 VA: 0x1800D99A0
	public int ArcRotation; // 0xFC
	[TooltipAttribute] // RVA: 0xD9B90 Offset: 0xD8F90 VA: 0x1800D9B90
	[RangeAttribute] // RVA: 0xD9B90 Offset: 0xD8F90 VA: 0x1800D9B90
	public float Progress; // 0x100
	private float _progress; // 0x104
	public Color ProgressColor; // 0x108
	public bool Fill; // 0x118
	public float Thickness; // 0x11C
	public int Padding; // 0x120
	private List<int> indices; // 0x128
	private List<UIVertex> vertices; // 0x130
	private Vector2 uvCenter; // 0x138

	// Methods

	// RVA: 0x11E3030 Offset: 0x11E2430 VA: 0x1811E3030 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E3C70 Offset: 0x11E3070 VA: 0x1811E3C70
	public void SetProgress(float progress) { }

	// RVA: 0x112DD60 Offset: 0x112D160 VA: 0x18112DD60
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E3C10 Offset: 0x11E3010 VA: 0x1811E3C10
	public void SetInvertArc(bool invert) { }

	// RVA: 0x11E3BD0 Offset: 0x11E2FD0 VA: 0x1811E3BD0
	public void SetArcRotation(int rotation) { }

	// RVA: 0x11E3BF0 Offset: 0x11E2FF0 VA: 0x1811E3BF0
	public void SetFill(bool fill) { }

	// RVA: 0x112DD80 Offset: 0x112D180 VA: 0x18112DD80
	public void SetBaseColor(Color color) { }

	// RVA: 0x112DDC0 Offset: 0x112D1C0 VA: 0x18112DDC0
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E3C50 Offset: 0x11E3050 VA: 0x1811E3C50
	public void SetProgressColor(Color color) { }

	// RVA: 0x11E3CB0 Offset: 0x11E30B0 VA: 0x1811E3CB0
	public void UpdateProgressAlpha(float value) { }

	// RVA: 0x11E3C30 Offset: 0x11E3030 VA: 0x1811E3C30
	public void SetPadding(int padding) { }

	// RVA: 0x11E3C90 Offset: 0x11E3090 VA: 0x1811E3C90
	public void SetThickness(int thickness) { }

	// RVA: 0x11E3CD0 Offset: 0x11E30D0 VA: 0x1811E3CD0
	public void .ctor() { }

}

public class UICircleSimple : UIPrimitiveBase // TypeDefIndex: 11713
{	// Fields
	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF0
	public bool Fill; // 0xF4
	public float Thickness; // 0xF8
	public bool ThicknessIsOutside; // 0xFC
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108
	private Vector2 uvCenter; // 0x110

	// Methods

	// RVA: 0x11E2350 Offset: 0x11E1750 VA: 0x1811E2350 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E2EC0 Offset: 0x11E22C0 VA: 0x1811E2EC0
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E2EE0 Offset: 0x11E22E0 VA: 0x1811E2EE0
	public void SetFill(bool fill) { }

	// RVA: 0x112DD80 Offset: 0x112D180 VA: 0x18112DD80
	public void SetBaseColor(Color color) { }

	// RVA: 0x112DDC0 Offset: 0x112D1C0 VA: 0x18112DDC0
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E2F00 Offset: 0x11E2300 VA: 0x1811E2F00
	public void SetThickness(int thickness) { }

	// RVA: 0x11E2F20 Offset: 0x11E2320 VA: 0x1811E2F20
	public void .ctor() { }

}

public class UICornerCut : UIPrimitiveBase // TypeDefIndex: 11714
{	// Fields
	public Vector2 cornerSize; // 0xF0
	[HeaderAttribute] // RVA: 0xD9F70 Offset: 0xD9370 VA: 0x1800D9F70
	[SerializeField] // RVA: 0xD9F70 Offset: 0xD9370 VA: 0x1800D9F70
	private bool m_cutUL; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutUR; // 0xF9
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutLL; // 0xFA
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutLR; // 0xFB
	[TooltipAttribute] // RVA: 0xDA130 Offset: 0xD9530 VA: 0x1800DA130
	[SerializeField] // RVA: 0xDA130 Offset: 0xD9530 VA: 0x1800DA130
	private bool m_makeColumns; // 0xFC
	[HeaderAttribute] // RVA: 0xDA330 Offset: 0xD9730 VA: 0x1800DA330
	[SerializeField] // RVA: 0xDA330 Offset: 0xD9730 VA: 0x1800DA330
	private bool m_useColorUp; // 0xFD
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color32 m_colorUp; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_useColorDown; // 0x104
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color32 m_colorDown; // 0x108

	// Properties
	public bool CutUL { get; set; }
	public bool CutUR { get; set; }
	public bool CutLL { get; set; }
	public bool CutLR { get; set; }
	public bool MakeColumns { get; set; }
	public bool UseColorUp { get; set; }
	public Color32 ColorUp { get; set; }
	public bool UseColorDown { get; set; }
	public Color32 ColorDown { get; set; }

	// Methods

	// RVA: 0x11E4AF0 Offset: 0x11E3EF0 VA: 0x1811E4AF0
	public bool get_CutUL() { }

	// RVA: 0x11E4B50 Offset: 0x11E3F50 VA: 0x1811E4B50
	public void set_CutUL(bool value) { }

	// RVA: 0x11E4B00 Offset: 0x11E3F00 VA: 0x1811E4B00
	public bool get_CutUR() { }

	// RVA: 0x11E4B70 Offset: 0x11E3F70 VA: 0x1811E4B70
	public void set_CutUR(bool value) { }

	// RVA: 0x11E4AD0 Offset: 0x11E3ED0 VA: 0x1811E4AD0
	public bool get_CutLL() { }

	// RVA: 0x11E4B10 Offset: 0x11E3F10 VA: 0x1811E4B10
	public void set_CutLL(bool value) { }

	// RVA: 0x11E4AE0 Offset: 0x11E3EE0 VA: 0x1811E4AE0
	public bool get_CutLR() { }

	// RVA: 0x11E4B30 Offset: 0x11E3F30 VA: 0x1811E4B30
	public void set_CutLR(bool value) { }

	// RVA: 0x1126D70 Offset: 0x1126170 VA: 0x181126D70
	public bool get_MakeColumns() { }

	// RVA: 0x1126E20 Offset: 0x1126220 VA: 0x181126E20
	public void set_MakeColumns(bool value) { }

	// RVA: 0x1126D50 Offset: 0x1126150 VA: 0x181126D50
	public bool get_UseColorUp() { }

	// RVA: 0x11E4BA0 Offset: 0x11E3FA0 VA: 0x1811E4BA0
	public void set_UseColorUp(bool value) { }

	// RVA: 0xC53140 Offset: 0xC52540 VA: 0x180C53140
	public Color32 get_ColorUp() { }

	// RVA: 0xC53290 Offset: 0xC52690 VA: 0x180C53290
	public void set_ColorUp(Color32 value) { }

	// RVA: 0x1129B30 Offset: 0x1128F30 VA: 0x181129B30
	public bool get_UseColorDown() { }

	// RVA: 0x11E4B90 Offset: 0x11E3F90 VA: 0x1811E4B90
	public void set_UseColorDown(bool value) { }

	// RVA: 0x94E6E0 Offset: 0x94DAE0 VA: 0x18094E6E0
	public Color32 get_ColorDown() { }

	// RVA: 0x94E880 Offset: 0x94DC80 VA: 0x18094E880
	public void set_ColorDown(Color32 value) { }

	// RVA: 0x11E4270 Offset: 0x11E3670 VA: 0x1811E4270 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E3F60 Offset: 0x11E3360 VA: 0x1811E3F60
	private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E3E30 Offset: 0x11E3230 VA: 0x1811E3E30
	private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E40F0 Offset: 0x11E34F0 VA: 0x1811E40F0
	private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E4A40 Offset: 0x11E3E40 VA: 0x1811E4A40
	public void .ctor() { }

}

public class UIGoldenRatioRenderer : UILineRenderer // TypeDefIndex: 11715
{	// Fields
	private readonly List<Vector2> _points; // 0x118
	private readonly List<Rect> _rects; // 0x120
	private int canvasWidth; // 0x128
	private int canvasHeight; // 0x12C
	public float lineThickness2; // 0x130

	// Methods

	// RVA: 0x1123780 Offset: 0x1122B80 VA: 0x181123780
	private void DrawSpiral(VertexHelper vh) { }

	// RVA: 0x1123000 Offset: 0x1122400 VA: 0x181123000
	private void DrawPhiRectangles(VertexHelper vh, List<Vector2> points, float x, float y, float width, float height, UIGoldenRatioRenderer.Orientations orientation) { }

	// RVA: 0x1123C30 Offset: 0x1123030 VA: 0x181123C30 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11232C0 Offset: 0x11226C0 VA: 0x1811232C0
	private void DrawRect(VertexHelper vh, Rect rect) { }

	// RVA: 0x11240A0 Offset: 0x11234A0 VA: 0x1811240A0
	public void .ctor() { }

}

private enum UIGoldenRatioRenderer.Orientations // TypeDefIndex: 11716
{	// Fields
	public int value__; // 0x0
	public const UIGoldenRatioRenderer.Orientations Left = 0;
	public const UIGoldenRatioRenderer.Orientations Top = 1;
	public const UIGoldenRatioRenderer.Orientations Right = 2;
	public const UIGoldenRatioRenderer.Orientations Bottom = 3;

}

public class UIGridRenderer : UILineRenderer // TypeDefIndex: 11717
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_GridColumns; // 0x118
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_GridRows; // 0x11C

	// Properties
	public int GridColumns { get; set; }
	public int GridRows { get; set; }

	// Methods

	// RVA: 0x90CEB0 Offset: 0x90C2B0 VA: 0x18090CEB0
	public int get_GridColumns() { }

	// RVA: 0x1124740 Offset: 0x1123B40 VA: 0x181124740
	public void set_GridColumns(int value) { }

	// RVA: 0x1074D70 Offset: 0x1074170 VA: 0x181074D70
	public int get_GridRows() { }

	// RVA: 0x1124760 Offset: 0x1123B60 VA: 0x181124760
	public void set_GridRows(int value) { }

	// RVA: 0x11241A0 Offset: 0x11235A0 VA: 0x1811241A0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11246C0 Offset: 0x1123AC0 VA: 0x1811246C0
	public void .ctor() { }

}

public class UILineRenderer : UIPrimitiveBase // TypeDefIndex: 11718
{	// Fields
	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	[TooltipAttribute] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	internal Vector2[] m_points; // 0xF0
	[SerializeField] // RVA: 0xDAC00 Offset: 0xDA000 VA: 0x1800DAC00
	[TooltipAttribute] // RVA: 0xDAC00 Offset: 0xDA000 VA: 0x1800DAC00
	internal List<Vector2[]> m_segments; // 0xF8
	[SerializeField] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	[TooltipAttribute] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	internal float lineThickness; // 0x100
	[SerializeField] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	[TooltipAttribute] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	internal bool relativeSize; // 0x104
	[SerializeField] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	[TooltipAttribute] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	internal bool lineList; // 0x105
	[SerializeField] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	[TooltipAttribute] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	internal bool lineCaps; // 0x106
	[SerializeField] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	[TooltipAttribute] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	internal int bezierSegmentsPerCurve; // 0x108
	[TooltipAttribute] // RVA: 0xDB5F0 Offset: 0xDA9F0 VA: 0x1800DB5F0
	public UILineRenderer.JoinType LineJoins; // 0x10C
	[TooltipAttribute] // RVA: 0xDB820 Offset: 0xDAC20 VA: 0x1800DB820
	public UILineRenderer.BezierType BezierMode; // 0x110
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool drivenExternally; // 0x114

	// Properties
	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public Vector2[] Points { get; set; }
	public List<Vector2[]> Segments { get; set; }

	// Methods

	// RVA: 0x7FEF50 Offset: 0x7FE350 VA: 0x1807FEF50
	public float get_LineThickness() { }

	// RVA: 0x1129B80 Offset: 0x1128F80 VA: 0x181129B80
	public void set_LineThickness(float value) { }

	// RVA: 0x1129B30 Offset: 0x1128F30 VA: 0x181129B30
	public bool get_RelativeSize() { }

	// RVA: 0x1129BA0 Offset: 0x1128FA0 VA: 0x181129BA0
	public void set_RelativeSize(bool value) { }

	// RVA: 0x1129B20 Offset: 0x1128F20 VA: 0x181129B20
	public bool get_LineList() { }

	// RVA: 0x1129B60 Offset: 0x1128F60 VA: 0x181129B60
	public void set_LineList(bool value) { }

	// RVA: 0x1129B10 Offset: 0x1128F10 VA: 0x181129B10
	public bool get_LineCaps() { }

	// RVA: 0x1129B40 Offset: 0x1128F40 VA: 0x181129B40
	public void set_LineCaps(bool value) { }

	// RVA: 0x94E6E0 Offset: 0x94DAE0 VA: 0x18094E6E0
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0x94E880 Offset: 0x94DC80 VA: 0x18094E880
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public Vector2[] get_Points() { }

	// RVA: 0x1126DE0 Offset: 0x11261E0 VA: 0x181126DE0
	public void set_Points(Vector2[] value) { }

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public List<Vector2[]> get_Segments() { }

	// RVA: 0x1129BC0 Offset: 0x1128FC0 VA: 0x181129BC0
	public void set_Segments(List<Vector2[]> value) { }

	// RVA: 0x1128700 Offset: 0x1127B00 VA: 0x181128700
	private void PopulateMesh(VertexHelper vh, Vector2[] pointsToDraw) { }

	// RVA: 0x11285C0 Offset: 0x11279C0 VA: 0x1811285C0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1126E40 Offset: 0x1126240 VA: 0x181126E40
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type) { }

	// RVA: 0x1127010 Offset: 0x1126410 VA: 0x181127010
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type, UIVertex[] previousVert) { }

	// RVA: 0x1127680 Offset: 0x1126A80 VA: 0x181127680 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x11299C0 Offset: 0x1128DC0 VA: 0x1811299C0 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x1128480 Offset: 0x1127880 VA: 0x181128480
	private int GetSegmentPointCount() { }

	// RVA: 0x1128220 Offset: 0x1127620 VA: 0x181128220
	public Vector2 GetPosition(int index, int segmentIndex = 0) { }

	// RVA: 0x1128180 Offset: 0x1127580 VA: 0x181128180
	public Vector2 GetPositionBySegment(int index, int segment) { }

	// RVA: 0x1128060 Offset: 0x1127460 VA: 0x181128060
	public Vector2 GetClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x1129AA0 Offset: 0x1128EA0 VA: 0x181129AA0
	public void .ctor() { }

}

private enum UILineRenderer.SegmentType // TypeDefIndex: 11719
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.SegmentType Start = 0;
	public const UILineRenderer.SegmentType Middle = 1;
	public const UILineRenderer.SegmentType End = 2;
	public const UILineRenderer.SegmentType Full = 3;

}

public enum UILineRenderer.JoinType // TypeDefIndex: 11720
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.JoinType Bevel = 0;
	public const UILineRenderer.JoinType Miter = 1;

}

public enum UILineRenderer.BezierType // TypeDefIndex: 11721
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.BezierType None = 0;
	public const UILineRenderer.BezierType Quick = 1;
	public const UILineRenderer.BezierType Basic = 2;
	public const UILineRenderer.BezierType Improved = 3;
	public const UILineRenderer.BezierType Catenary = 4;

}

public class UILineRendererList : UIPrimitiveBase // TypeDefIndex: 11722
{	// Fields
	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	[TooltipAttribute] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	internal List<Vector2> m_points; // 0xF0
	[SerializeField] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	[TooltipAttribute] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	internal float lineThickness; // 0xF8
	[SerializeField] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	[TooltipAttribute] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	internal bool relativeSize; // 0xFC
	[SerializeField] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	[TooltipAttribute] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	internal bool lineList; // 0xFD
	[SerializeField] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	[TooltipAttribute] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	internal bool lineCaps; // 0xFE
	[SerializeField] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	[TooltipAttribute] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	internal int bezierSegmentsPerCurve; // 0x100
	[TooltipAttribute] // RVA: 0xDB5F0 Offset: 0xDA9F0 VA: 0x1800DB5F0
	public UILineRendererList.JoinType LineJoins; // 0x104
	[TooltipAttribute] // RVA: 0xDB820 Offset: 0xDAC20 VA: 0x1800DB820
	public UILineRendererList.BezierType BezierMode; // 0x108
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool drivenExternally; // 0x10C

	// Properties
	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public List<Vector2> Points { get; set; }

	// Methods

	// RVA: 0x1126D60 Offset: 0x1126160 VA: 0x181126D60
	public float get_LineThickness() { }

	// RVA: 0x1126DC0 Offset: 0x11261C0 VA: 0x181126DC0
	public void set_LineThickness(float value) { }

	// RVA: 0x1126D70 Offset: 0x1126170 VA: 0x181126D70
	public bool get_RelativeSize() { }

	// RVA: 0x1126E20 Offset: 0x1126220 VA: 0x181126E20
	public void set_RelativeSize(bool value) { }

	// RVA: 0x1126D50 Offset: 0x1126150 VA: 0x181126D50
	public bool get_LineList() { }

	// RVA: 0x1126DA0 Offset: 0x11261A0 VA: 0x181126DA0
	public void set_LineList(bool value) { }

	// RVA: 0x1126D40 Offset: 0x1126140 VA: 0x181126D40
	public bool get_LineCaps() { }

	// RVA: 0x1126D80 Offset: 0x1126180 VA: 0x181126D80
	public void set_LineCaps(bool value) { }

	// RVA: 0xC53140 Offset: 0xC52540 VA: 0x180C53140
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0xC53290 Offset: 0xC52690 VA: 0x180C53290
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public List<Vector2> get_Points() { }

	// RVA: 0x1126DE0 Offset: 0x11261E0 VA: 0x181126DE0
	public void set_Points(List<Vector2> value) { }

	// RVA: 0x1124780 Offset: 0x1123B80 VA: 0x181124780
	public void AddPoint(Vector2 pointToAdd) { }

	// RVA: 0x1126B80 Offset: 0x1125F80 VA: 0x181126B80
	public void RemovePoint(Vector2 pointToRemove) { }

	// RVA: 0x11247F0 Offset: 0x1123BF0 VA: 0x1811247F0
	public void ClearPoints() { }

	// RVA: 0x11259D0 Offset: 0x1124DD0 VA: 0x1811259D0
	private void PopulateMesh(VertexHelper vh, List<Vector2> pointsToDraw) { }

	// RVA: 0x1125940 Offset: 0x1124D40 VA: 0x181125940 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1124850 Offset: 0x1123C50 VA: 0x181124850
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x1124A10 Offset: 0x1123E10 VA: 0x181124A10
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x1124F60 Offset: 0x1124360 VA: 0x181124F60 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x1126BF0 Offset: 0x1125FF0 VA: 0x181126BF0 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x1126CD0 Offset: 0x11260D0 VA: 0x181126CD0
	public void .ctor() { }

}

private enum UILineRendererList.SegmentType // TypeDefIndex: 11723
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.SegmentType Start = 0;
	public const UILineRendererList.SegmentType Middle = 1;
	public const UILineRendererList.SegmentType End = 2;
	public const UILineRendererList.SegmentType Full = 3;

}

public enum UILineRendererList.JoinType // TypeDefIndex: 11724
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.JoinType Bevel = 0;
	public const UILineRendererList.JoinType Miter = 1;

}

public enum UILineRendererList.BezierType // TypeDefIndex: 11725
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.BezierType None = 0;
	public const UILineRendererList.BezierType Quick = 1;
	public const UILineRendererList.BezierType Basic = 2;
	public const UILineRendererList.BezierType Improved = 3;
	public const UILineRendererList.BezierType Catenary = 4;

}

public class UILineTextureRenderer : UIPrimitiveBase // TypeDefIndex: 11726
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Rect m_UVRect; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2[] m_points; // 0x100
	public float LineThickness; // 0x108
	public bool UseMargins; // 0x10C
	public Vector2 Margin; // 0x110
	public bool relativeSize; // 0x118

	// Properties
	public Rect uvRect { get; set; }
	public Vector2[] Points { get; set; }

	// Methods

	// RVA: 0x112B0C0 Offset: 0x112A4C0 VA: 0x18112B0C0
	public Rect get_uvRect() { }

	// RVA: 0x112B110 Offset: 0x112A510 VA: 0x18112B110
	public void set_uvRect(Rect value) { }

	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public Vector2[] get_Points() { }

	// RVA: 0x112B0D0 Offset: 0x112A4D0 VA: 0x18112B0D0
	public void set_Points(Vector2[] value) { }

	// RVA: 0x1129C00 Offset: 0x1129000 VA: 0x181129C00 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112AEC0 Offset: 0x112A2C0 VA: 0x18112AEC0
	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) { }

	// RVA: 0x112B020 Offset: 0x112A420 VA: 0x18112B020
	public void .ctor() { }

}

public class UIPolygon : UIPrimitiveBase // TypeDefIndex: 11727
{	// Fields
	public bool fill; // 0xF0
	public float thickness; // 0xF4
	[RangeAttribute] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	public int sides; // 0xF8
	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float rotation; // 0xFC
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float[] VerticesDistances; // 0x100
	private float size; // 0x108

	// Methods

	// RVA: 0x112B180 Offset: 0x112A580 VA: 0x18112B180
	public void DrawPolygon(int _sides) { }

	// RVA: 0x112B2A0 Offset: 0x112A6A0 VA: 0x18112B2A0
	public void DrawPolygon(int _sides, float[] _VerticesDistances) { }

	// RVA: 0x112B250 Offset: 0x112A650 VA: 0x18112B250
	public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation) { }

	// RVA: 0x112BA10 Offset: 0x112AE10 VA: 0x18112BA10
	private void Update() { }

	// RVA: 0x112B2F0 Offset: 0x112A6F0 VA: 0x18112B2F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112BBD0 Offset: 0x112AFD0 VA: 0x18112BBD0
	public void .ctor() { }

}

public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 11730
{	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	private List<Vector2> outputList; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_Sprite; // 0xD0
	private Sprite m_OverrideSprite; // 0xD8
	internal float m_EventAlphaThreshold; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolutionMode m_improveResolution; // 0xE4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_Resolution; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_useNativeSize; // 0xEC

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	protected Sprite activeSprite { get; }
	public float eventAlphaThreshold { get; set; }
	public ResolutionMode ImproveResolution { get; set; }
	public float Resoloution { get; set; }
	public bool UseNativeSize { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public Sprite get_sprite() { }

	// RVA: 0x112D660 Offset: 0x112CA60 VA: 0x18112D660
	public void set_sprite(Sprite value) { }

	// RVA: 0x112D280 Offset: 0x112C680 VA: 0x18112D280
	public Sprite get_overrideSprite() { }

	// RVA: 0x112D5E0 Offset: 0x112C9E0 VA: 0x18112D5E0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x112CC30 Offset: 0x112C030 VA: 0x18112CC30
	protected Sprite get_activeSprite() { }

	// RVA: 0x112CDC0 Offset: 0x112C1C0 VA: 0x18112CDC0
	public float get_eventAlphaThreshold() { }

	// RVA: 0x112D5C0 Offset: 0x112C9C0 VA: 0x18112D5C0
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x1074C90 Offset: 0x1074090 VA: 0x181074C90
	public ResolutionMode get_ImproveResolution() { }

	// RVA: 0x112D560 Offset: 0x112C960 VA: 0x18112D560
	public void set_ImproveResolution(ResolutionMode value) { }

	// RVA: 0x112CC10 Offset: 0x112C010 VA: 0x18112CC10
	public float get_Resoloution() { }

	// RVA: 0x112D580 Offset: 0x112C980 VA: 0x18112D580
	public void set_Resoloution(float value) { }

	// RVA: 0x112CC20 Offset: 0x112C020 VA: 0x18112CC20
	public bool get_UseNativeSize() { }

	// RVA: 0x112D5A0 Offset: 0x112C9A0 VA: 0x18112D5A0
	public void set_UseNativeSize(bool value) { }

	// RVA: 0x112CB90 Offset: 0x112BF90 VA: 0x18112CB90
	protected void .ctor() { }

	// RVA: 0x112CCC0 Offset: 0x112C0C0 VA: 0x18112CCC0
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x112CE90 Offset: 0x112C290 VA: 0x18112CE90 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x112CDD0 Offset: 0x112C1D0 VA: 0x18112CDD0
	public bool get_hasBorder() { }

	// RVA: 0x112D290 Offset: 0x112C690 VA: 0x18112D290
	public float get_pixelsPerUnit() { }

	// RVA: 0x112D030 Offset: 0x112C430 VA: 0x18112D030 Slot: 32
	public override Material get_material() { }

	// RVA: 0x112D5D0 Offset: 0x112C9D0 VA: 0x18112D5D0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x112C930 Offset: 0x112BD30 VA: 0x18112C930
	protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs) { }

	// RVA: 0x112BDA0 Offset: 0x112B1A0 VA: 0x18112BDA0
	protected Vector2[] IncreaseResolution(Vector2[] input) { }

	// RVA: 0x112BE30 Offset: 0x112B230 VA: 0x18112BE30
	protected List<Vector2> IncreaseResolution(List<Vector2> input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 73
	protected virtual void GeneratedUVs() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 74
	protected virtual void ResolutionToNativeSize(float distance) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 75
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 76
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 77
	public virtual float get_minWidth() { }

	// RVA: 0x112D480 Offset: 0x112C880 VA: 0x18112D480 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 79
	public virtual float get_flexibleWidth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 80
	public virtual float get_minHeight() { }

	// RVA: 0x112D3A0 Offset: 0x112C7A0 VA: 0x18112D3A0 Slot: 81
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 82
	public virtual float get_flexibleHeight() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 83
	public virtual int get_layoutPriority() { }

	// RVA: 0x112C400 Offset: 0x112B800 VA: 0x18112C400 Slot: 84
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x112C870 Offset: 0x112BC70 VA: 0x18112C870
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x112BC60 Offset: 0x112B060 VA: 0x18112BC60
	private Vector4 GetAdjustedBorders(Vector4 border, Rect rect) { }

	// RVA: 0x112C900 Offset: 0x112BD00 VA: 0x18112C900 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class UIRing : UIPrimitiveBase // TypeDefIndex: 11731
{	// Fields
	public float innerRadius; // 0xF0
	public float outerRadius; // 0xF4
	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF8
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108

	// Methods

	// RVA: 0x112D6E0 Offset: 0x112CAE0 VA: 0x18112D6E0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112DD60 Offset: 0x112D160 VA: 0x18112DD60
	public void SetArcSteps(int steps) { }

	// RVA: 0x112DD80 Offset: 0x112D180 VA: 0x18112DD80
	public void SetBaseColor(Color color) { }

	// RVA: 0x112DDC0 Offset: 0x112D1C0 VA: 0x18112DDC0
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x112DE40 Offset: 0x112D240 VA: 0x18112DE40
	public void .ctor() { }

}

internal interface IAmbientOcclusionMethod // TypeDefIndex: 11757
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DepthTextureMode GetCameraFlags();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RenderAfterOpaque(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RenderAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CompositeAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();

}

public class UI : ConsoleSystem // TypeDefIndex: 11967
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool showinventoryplayer; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool autoswitchchannel; // 0x1

	// Methods

	// RVA: 0x36C1B0 Offset: 0x36B5B0 VA: 0x18036C1B0
	public void .ctor() { }

	// RVA: 0x36C160 Offset: 0x36B560 VA: 0x18036C160
	private static void .cctor() { }

}

public interface VirtualScroll.IDataSource // TypeDefIndex: 11998
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetItemCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetItemData(int i, GameObject obj);

}

public interface IGenericLerpTarget<T> : ILerpInfo // TypeDefIndex: 12115
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetFrom(T snapshot);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.SetFrom
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T GetCurrentState();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.GetCurrentState
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DebugInterpolationState(Interpolator.Segment<T> segment, List<T> entries);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.DebugInterpolationState
	*/

}

public interface ISnapshot<T> // TypeDefIndex: 12117
{	// Properties
	public abstract float Time { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_Time();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.get_Time
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Time(float value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.set_Time
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void MatchValuesTo(T entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.MatchValuesTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Lerp(T prev, T next, float delta);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.Lerp
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T GetNew();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.GetNew
	*/

}

