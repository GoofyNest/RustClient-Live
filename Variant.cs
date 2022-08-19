internal struct Variant // TypeDefIndex: 418
{	// Fields
	public short vt; // 0x0
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

	// Methods

	// RVA: 0x234540 Offset: 0x233940 VA: 0x180234540
	public void Clear() { }

}

public abstract class Variant : IConvertible // TypeDefIndex: 11584
{	// Fields
	protected static readonly IFormatProvider FormatProvider; // 0x1F320

	// Properties
	public virtual Variant Item { get; set; }
	public virtual Variant Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Make<T>(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F25B0 Offset: 0x5F19B0 VA: 0x1805F25B0
	|-Variant.Make<object>
	*/

	// RVA: -1 Offset: -1
	public T Make<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1500 Offset: 0x14C0900 VA: 0x1814C1500
	|-Variant.Make<object>
	*/

	// RVA: 0x8551A0 Offset: 0x8545A0 VA: 0x1808551A0
	public string ToJSON() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 21
	public virtual TypeCode GetTypeCode() { }

	// RVA: 0x855430 Offset: 0x854830 VA: 0x180855430 Slot: 22
	public virtual object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x854EA0 Offset: 0x8542A0 VA: 0x180854EA0 Slot: 23
	public virtual DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x854D20 Offset: 0x854120 VA: 0x180854D20 Slot: 24
	public virtual bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x854DA0 Offset: 0x8541A0 VA: 0x180854DA0 Slot: 25
	public virtual byte ToByte(IFormatProvider provider) { }

	// RVA: 0x854E20 Offset: 0x854220 VA: 0x180854E20 Slot: 26
	public virtual char ToChar(IFormatProvider provider) { }

	// RVA: 0x854F20 Offset: 0x854320 VA: 0x180854F20 Slot: 27
	public virtual Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x854FA0 Offset: 0x8543A0 VA: 0x180854FA0 Slot: 28
	public virtual double ToDouble(IFormatProvider provider) { }

	// RVA: 0x855020 Offset: 0x854420 VA: 0x180855020 Slot: 29
	public virtual short ToInt16(IFormatProvider provider) { }

	// RVA: 0x8550A0 Offset: 0x8544A0 VA: 0x1808550A0 Slot: 30
	public virtual int ToInt32(IFormatProvider provider) { }

	// RVA: 0x855120 Offset: 0x854520 VA: 0x180855120 Slot: 31
	public virtual long ToInt64(IFormatProvider provider) { }

	// RVA: 0x855240 Offset: 0x854640 VA: 0x180855240 Slot: 32
	public virtual sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x8552C0 Offset: 0x8546C0 VA: 0x1808552C0 Slot: 33
	public virtual float ToSingle(IFormatProvider provider) { }

	// RVA: 0x8553B0 Offset: 0x8547B0 VA: 0x1808553B0 Slot: 34
	public virtual string ToString(IFormatProvider provider) { }

	// RVA: 0x855570 Offset: 0x854970 VA: 0x180855570 Slot: 35
	public virtual ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x8555F0 Offset: 0x8549F0 VA: 0x1808555F0 Slot: 36
	public virtual uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x855670 Offset: 0x854A70 VA: 0x180855670 Slot: 37
	public virtual ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x855340 Offset: 0x854740 VA: 0x180855340 Slot: 3
	public override string ToString() { }

	// RVA: 0x8557A0 Offset: 0x854BA0 VA: 0x1808557A0 Slot: 38
	public virtual Variant get_Item(string key) { }

	// RVA: 0x855E30 Offset: 0x855230 VA: 0x180855E30 Slot: 39
	public virtual void set_Item(string key, Variant value) { }

	// RVA: 0x855750 Offset: 0x854B50 VA: 0x180855750 Slot: 40
	public virtual Variant get_Item(int index) { }

	// RVA: 0x855E80 Offset: 0x855280 VA: 0x180855E80 Slot: 41
	public virtual void set_Item(int index, Variant value) { }

	// RVA: 0x855A70 Offset: 0x854E70 VA: 0x180855A70
	public static bool op_Implicit(Variant variant) { }

	// RVA: 0x855DB0 Offset: 0x8551B0 VA: 0x180855DB0
	public static float op_Implicit(Variant variant) { }

	// RVA: 0x855970 Offset: 0x854D70 VA: 0x180855970
	public static double op_Implicit(Variant variant) { }

	// RVA: 0x855870 Offset: 0x854C70 VA: 0x180855870
	public static ushort op_Implicit(Variant variant) { }

	// RVA: 0x855CB0 Offset: 0x8550B0 VA: 0x180855CB0
	public static short op_Implicit(Variant variant) { }

	// RVA: 0x855D30 Offset: 0x855130 VA: 0x180855D30
	public static uint op_Implicit(Variant variant) { }

	// RVA: 0x8558F0 Offset: 0x854CF0 VA: 0x1808558F0
	public static int op_Implicit(Variant variant) { }

	// RVA: 0x855B90 Offset: 0x854F90 VA: 0x180855B90
	public static ulong op_Implicit(Variant variant) { }

	// RVA: 0x8559F0 Offset: 0x854DF0 VA: 0x1808559F0
	public static long op_Implicit(Variant variant) { }

	// RVA: 0x855AF0 Offset: 0x854EF0 VA: 0x180855AF0
	public static Decimal op_Implicit(Variant variant) { }

	// RVA: 0x8557F0 Offset: 0x854BF0 VA: 0x1808557F0
	public static string op_Implicit(Variant variant) { }

	// RVA: 0x855C10 Offset: 0x855010 VA: 0x180855C10
	public static Guid op_Implicit(Variant variant) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x8556F0 Offset: 0x854AF0 VA: 0x1808556F0
	private static void .cctor() { }

}

