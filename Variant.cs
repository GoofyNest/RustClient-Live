internal struct Variant // TypeDefIndex: 418
{	public short vt; // 0x0
	public ushort wReserved1; // 0x2
	public ushort wReserved2; // 0x4
	public ushort wReserved3; // 0x6
	public long llVal; // 0x8
	public int lVal; // 0x8
	public byte bVal; // 0x8
	public short iVal; // 0x8
	public float fltVal; // 0x8
	public double dblVal; // 0x8
	public short boolVal; // 0x8
	public IntPtr bstrVal; // 0x8
	public sbyte cVal; // 0x8
	public ushort uiVal; // 0x8
	public uint ulVal; // 0x8
	public ulong ullVal; // 0x8
	public int intVal; // 0x8
	public uint uintVal; // 0x8
	public IntPtr pdispVal; // 0x8
	public BRECORD bRecord; // 0x8


	public void Clear() { }

}

public abstract class Variant : IConvertible // TypeDefIndex: 11584
{	protected static readonly IFormatProvider FormatProvider; // 0x1F320

	public virtual Variant Item { get; set; }
	public virtual Variant Item { get; set; }


	public void Make<T>(out T item) { }
	/* GenericInstMethod :
	|
	|-Variant.Make<object>
	*/

	public T Make<T>() { }
	/* GenericInstMethod :
	|
	|-Variant.Make<object>
	*/

	public string ToJSON() { }

	public virtual TypeCode GetTypeCode() { }

	public virtual object ToType(Type conversionType, IFormatProvider provider) { }

	public virtual DateTime ToDateTime(IFormatProvider provider) { }

	public virtual bool ToBoolean(IFormatProvider provider) { }

	public virtual byte ToByte(IFormatProvider provider) { }

	public virtual char ToChar(IFormatProvider provider) { }

	public virtual Decimal ToDecimal(IFormatProvider provider) { }

	public virtual double ToDouble(IFormatProvider provider) { }

	public virtual short ToInt16(IFormatProvider provider) { }

	public virtual int ToInt32(IFormatProvider provider) { }

	public virtual long ToInt64(IFormatProvider provider) { }

	public virtual sbyte ToSByte(IFormatProvider provider) { }

	public virtual float ToSingle(IFormatProvider provider) { }

	public virtual string ToString(IFormatProvider provider) { }

	public virtual ushort ToUInt16(IFormatProvider provider) { }

	public virtual uint ToUInt32(IFormatProvider provider) { }

	public virtual ulong ToUInt64(IFormatProvider provider) { }

	public override string ToString() { }

	public virtual Variant get_Item(string key) { }

	public virtual void set_Item(string key, Variant value) { }

	public virtual Variant get_Item(int index) { }

	public virtual void set_Item(int index, Variant value) { }

	public static bool op_Implicit(Variant variant) { }

	public static float op_Implicit(Variant variant) { }

	public static double op_Implicit(Variant variant) { }

	public static ushort op_Implicit(Variant variant) { }

	public static short op_Implicit(Variant variant) { }

	public static uint op_Implicit(Variant variant) { }

	public static int op_Implicit(Variant variant) { }

	public static ulong op_Implicit(Variant variant) { }

	public static long op_Implicit(Variant variant) { }

	public static Decimal op_Implicit(Variant variant) { }

	public static string op_Implicit(Variant variant) { }

	public static Guid op_Implicit(Variant variant) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

