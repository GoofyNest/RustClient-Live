public static class Convert // TypeDefIndex: 196
{	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x1452970 Offset: 0x1451D70 VA: 0x181452970
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x14529E0 Offset: 0x1451DE0 VA: 0x1814529E0
	public static bool IsDBNull(object value) { }

	// RVA: 0x144FBB0 Offset: 0x144EFB0 VA: 0x18144FBB0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x1451150 Offset: 0x1450550 VA: 0x181451150
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x1450E20 Offset: 0x1450220 VA: 0x181450E20
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x1450010 Offset: 0x144F410 VA: 0x181450010
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1453550 Offset: 0x1452950 VA: 0x181453550
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453660 Offset: 0x1452A60 VA: 0x181453660
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x1453660 Offset: 0x1452A60 VA: 0x181453660
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1453490 Offset: 0x1452890 VA: 0x181453490
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453490 Offset: 0x1452890 VA: 0x181453490
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x14534C0 Offset: 0x14528C0 VA: 0x1814534C0
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14534C0 Offset: 0x14528C0 VA: 0x1814534C0
	public static bool ToBoolean(uint value) { }

	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1453600 Offset: 0x1452A00 VA: 0x181453600
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1453670 Offset: 0x1452A70 VA: 0x181453670
	public static bool ToBoolean(float value) { }

	// RVA: 0x14534A0 Offset: 0x14528A0 VA: 0x1814534A0
	public static bool ToBoolean(double value) { }

	// RVA: 0x14534D0 Offset: 0x14528D0 VA: 0x1814534D0
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x1454100 Offset: 0x1453500 VA: 0x181454100
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453F80 Offset: 0x1453380 VA: 0x181453F80
	public static char ToChar(sbyte value) { }

	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static char ToChar(byte value) { }

	// RVA: 0x14541B0 Offset: 0x14535B0 VA: 0x1814541B0
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static char ToChar(ushort value) { }

	// RVA: 0x1454000 Offset: 0x1453400 VA: 0x181454000
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453F00 Offset: 0x1453300 VA: 0x181453F00
	public static char ToChar(uint value) { }

	// RVA: 0x1454080 Offset: 0x1453480 VA: 0x181454080
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14542F0 Offset: 0x14536F0 VA: 0x1814542F0
	public static char ToChar(ulong value) { }

	// RVA: 0x1454230 Offset: 0x1453630 VA: 0x181454230
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14564E0 Offset: 0x14558E0 VA: 0x1814564E0
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453660 Offset: 0x1452A60 VA: 0x181453660
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14563D0 Offset: 0x14557D0 VA: 0x1814563D0
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456870 Offset: 0x1455C70 VA: 0x181456870
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456980 Offset: 0x1455D80 VA: 0x181456980
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14566F0 Offset: 0x1455AF0 VA: 0x1814566F0
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14567F0 Offset: 0x1455BF0 VA: 0x1814567F0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456670 Offset: 0x1455A70 VA: 0x181456670
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456450 Offset: 0x1455850 VA: 0x181456450
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456770 Offset: 0x1455B70 VA: 0x181456770
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456A10 Offset: 0x1455E10 VA: 0x181456A10
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456590 Offset: 0x1455990 VA: 0x181456590
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14568F0 Offset: 0x1455CF0 VA: 0x1814568F0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456970 Offset: 0x1455D70 VA: 0x181456970
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x1453960 Offset: 0x1452D60 VA: 0x181453960
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x1453660 Offset: 0x1452A60 VA: 0x181453660
	public static byte ToByte(bool value) { }

	// RVA: 0x1453E10 Offset: 0x1453210 VA: 0x181453E10
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453A10 Offset: 0x1452E10 VA: 0x181453A10
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1453680 Offset: 0x1452A80 VA: 0x181453680
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453700 Offset: 0x1452B00 VA: 0x181453700
	public static byte ToByte(ushort value) { }

	// RVA: 0x1453D70 Offset: 0x1453170 VA: 0x181453D70
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453780 Offset: 0x1452B80 VA: 0x181453780
	public static byte ToByte(uint value) { }

	// RVA: 0x1453800 Offset: 0x1452C00 VA: 0x181453800
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1453BE0 Offset: 0x1452FE0 VA: 0x181453BE0
	public static byte ToByte(ulong value) { }

	// RVA: 0x1453C60 Offset: 0x1453060 VA: 0x181453C60
	public static byte ToByte(float value) { }

	// RVA: 0x1453A90 Offset: 0x1452E90 VA: 0x181453A90
	public static byte ToByte(double value) { }

	// RVA: 0x1453B60 Offset: 0x1452F60 VA: 0x181453B60
	public static byte ToByte(Decimal value) { }

	// RVA: 0x1453E90 Offset: 0x1453290 VA: 0x181453E90
	public static byte ToByte(string value) { }

	// RVA: 0x1453DF0 Offset: 0x14531F0 VA: 0x181453DF0
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x1455420 Offset: 0x1454820 VA: 0x181455420
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x1455740 Offset: 0x1454B40 VA: 0x181455740
	public static short ToInt16(bool value) { }

	// RVA: 0x14554D0 Offset: 0x14548D0 VA: 0x1814554D0
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455270 Offset: 0x1454670 VA: 0x181455270
	public static short ToInt16(sbyte value) { }

	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455280 Offset: 0x1454680 VA: 0x181455280
	public static short ToInt16(ushort value) { }

	// RVA: 0x1455060 Offset: 0x1454460 VA: 0x181455060
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455750 Offset: 0x1454B50 VA: 0x181455750
	public static short ToInt16(uint value) { }

	// RVA: 0x14551C0 Offset: 0x14545C0 VA: 0x1814551C0
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14555D0 Offset: 0x14549D0 VA: 0x1814555D0
	public static short ToInt16(ulong value) { }

	// RVA: 0x1455300 Offset: 0x1454700 VA: 0x181455300
	public static short ToInt16(float value) { }

	// RVA: 0x14550E0 Offset: 0x14544E0 VA: 0x1814550E0
	public static short ToInt16(double value) { }

	// RVA: 0x1455550 Offset: 0x1454950 VA: 0x181455550
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1455250 Offset: 0x1454650 VA: 0x181455250
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14574E0 Offset: 0x14568E0 VA: 0x1814574E0
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455740 Offset: 0x1454B40 VA: 0x181455740
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14572C0 Offset: 0x14566C0 VA: 0x1814572C0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457340 Offset: 0x1456740 VA: 0x181457340
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14573C0 Offset: 0x14567C0 VA: 0x1814573C0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457240 Offset: 0x1456640 VA: 0x181457240
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457440 Offset: 0x1456840 VA: 0x181457440
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457660 Offset: 0x1456A60 VA: 0x181457660
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457130 Offset: 0x1456530 VA: 0x181457130
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457590 Offset: 0x1456990 VA: 0x181457590
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14570B0 Offset: 0x14564B0 VA: 0x1814570B0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14574C0 Offset: 0x14568C0 VA: 0x1814574C0
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x1455D30 Offset: 0x1455130 VA: 0x181455D30
	public static int ToInt32(object value) { }

	// RVA: 0x1455A60 Offset: 0x1454E60 VA: 0x181455A60
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x14558E0 Offset: 0x1454CE0 VA: 0x1814558E0
	public static int ToInt32(bool value) { }

	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static int ToInt32(char value) { }

	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static int ToInt32(byte value) { }

	// RVA: 0x1455D00 Offset: 0x1455100 VA: 0x181455D00
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455C20 Offset: 0x1455020 VA: 0x181455C20
	public static int ToInt32(uint value) { }

	// RVA: 0x14559D0 Offset: 0x1454DD0 VA: 0x1814559D0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455950 Offset: 0x1454D50 VA: 0x181455950
	public static int ToInt32(ulong value) { }

	// RVA: 0x1455CA0 Offset: 0x14550A0 VA: 0x181455CA0
	public static int ToInt32(float value) { }

	// RVA: 0x14557D0 Offset: 0x1454BD0 VA: 0x1814557D0
	public static int ToInt32(double value) { }

	// RVA: 0x14558F0 Offset: 0x1454CF0 VA: 0x1814558F0
	public static int ToInt32(Decimal value) { }

	// RVA: 0x1455BB0 Offset: 0x1454FB0 VA: 0x181455BB0
	public static int ToInt32(string value) { }

	// RVA: 0x1455D10 Offset: 0x1455110 VA: 0x181455D10
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14578E0 Offset: 0x1456CE0 VA: 0x1814578E0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457B00 Offset: 0x1456F00 VA: 0x181457B00
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14558E0 Offset: 0x1454CE0 VA: 0x1814558E0
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457980 Offset: 0x1456D80 VA: 0x181457980
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457C80 Offset: 0x1457080 VA: 0x181457C80
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457A80 Offset: 0x1456E80 VA: 0x181457A80
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457D20 Offset: 0x1457120 VA: 0x181457D20
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457A00 Offset: 0x1456E00 VA: 0x181457A00
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457DA0 Offset: 0x14571A0 VA: 0x181457DA0
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457BB0 Offset: 0x1456FB0 VA: 0x181457BB0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14577C0 Offset: 0x1456BC0 VA: 0x1814577C0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457D00 Offset: 0x1457100 VA: 0x181457D00
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x1455E90 Offset: 0x1455290 VA: 0x181455E90
	public static long ToInt64(object value) { }

	// RVA: 0x1456210 Offset: 0x1455610 VA: 0x181456210
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x14562C0 Offset: 0x14556C0 VA: 0x1814562C0
	public static long ToInt64(bool value) { }

	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14562D0 Offset: 0x14556D0 VA: 0x1814562D0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static long ToInt64(byte value) { }

	// RVA: 0x1455DD0 Offset: 0x14551D0 VA: 0x181455DD0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static long ToInt64(ushort value) { }

	// RVA: 0x1455F30 Offset: 0x1455330 VA: 0x181455F30
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1455DE0 Offset: 0x14551E0 VA: 0x181455DE0
	public static long ToInt64(ulong value) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static long ToInt64(long value) { }

	// RVA: 0x1456040 Offset: 0x1455440 VA: 0x181456040
	public static long ToInt64(float value) { }

	// RVA: 0x1455F40 Offset: 0x1455340 VA: 0x181455F40
	public static long ToInt64(double value) { }

	// RVA: 0x1455FC0 Offset: 0x14553C0 VA: 0x181455FC0
	public static long ToInt64(Decimal value) { }

	// RVA: 0x14561A0 Offset: 0x14555A0 VA: 0x1814561A0
	public static long ToInt64(string value) { }

	// RVA: 0x1455E70 Offset: 0x1455270 VA: 0x181455E70
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1458210 Offset: 0x1457610 VA: 0x181458210
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14558E0 Offset: 0x1454CE0 VA: 0x1814558E0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457EB0 Offset: 0x14572B0 VA: 0x181457EB0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14580F0 Offset: 0x14574F0 VA: 0x1814580F0
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x136B180 Offset: 0x136A580 VA: 0x18136B180
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457F30 Offset: 0x1457330 VA: 0x181457F30
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14583A0 Offset: 0x14577A0 VA: 0x1814583A0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14582C0 Offset: 0x14576C0 VA: 0x1814582C0
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1458170 Offset: 0x1457570 VA: 0x181458170
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457FB0 Offset: 0x14573B0 VA: 0x181457FB0
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1458030 Offset: 0x1457430 VA: 0x181458030
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x1456C30 Offset: 0x1456030 VA: 0x181456C30
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456B90 Offset: 0x1455F90 VA: 0x181456B90
	public static float ToSingle(sbyte value) { }

	// RVA: 0x1456B30 Offset: 0x1455F30 VA: 0x181456B30
	public static float ToSingle(byte value) { }

	// RVA: 0x1456B50 Offset: 0x1455F50 VA: 0x181456B50
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456D10 Offset: 0x1456110 VA: 0x181456D10
	public static float ToSingle(ushort value) { }

	// RVA: 0x1456B60 Offset: 0x1455F60 VA: 0x181456B60
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456BA0 Offset: 0x1455FA0 VA: 0x181456BA0
	public static float ToSingle(uint value) { }

	// RVA: 0x1456B40 Offset: 0x1455F40 VA: 0x181456B40
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1456CE0 Offset: 0x14560E0 VA: 0x181456CE0
	public static float ToSingle(ulong value) { }

	// RVA: 0x1456C20 Offset: 0x1456020 VA: 0x181456C20
	public static float ToSingle(double value) { }

	// RVA: 0x1456BC0 Offset: 0x1455FC0 VA: 0x181456BC0
	public static float ToSingle(Decimal value) { }

	// RVA: 0x1456B70 Offset: 0x1455F70 VA: 0x181456B70
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x1456BB0 Offset: 0x1455FB0 VA: 0x181456BB0
	public static float ToSingle(bool value) { }

	// RVA: 0x1454F30 Offset: 0x1454330 VA: 0x181454F30
	public static double ToDouble(object value) { }

	// RVA: 0x1454D70 Offset: 0x1454170 VA: 0x181454D70
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454E50 Offset: 0x1454250 VA: 0x181454E50
	public static double ToDouble(sbyte value) { }

	// RVA: 0x1455050 Offset: 0x1454450 VA: 0x181455050
	public static double ToDouble(byte value) { }

	// RVA: 0x1454F10 Offset: 0x1454310 VA: 0x181454F10
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454E60 Offset: 0x1454260 VA: 0x181454E60
	public static double ToDouble(ushort value) { }

	// RVA: 0x1454FD0 Offset: 0x14543D0 VA: 0x181454FD0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454F20 Offset: 0x1454320 VA: 0x181454F20
	public static double ToDouble(uint value) { }

	// RVA: 0x1454E70 Offset: 0x1454270 VA: 0x181454E70
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454E20 Offset: 0x1454220 VA: 0x181454E20
	public static double ToDouble(ulong value) { }

	// RVA: 0x1454E80 Offset: 0x1454280 VA: 0x181454E80
	public static double ToDouble(float value) { }

	// RVA: 0x1454FE0 Offset: 0x14543E0 VA: 0x181454FE0
	public static double ToDouble(Decimal value) { }

	// RVA: 0x1454E90 Offset: 0x1454290 VA: 0x181454E90
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x1455040 Offset: 0x1454440 VA: 0x181455040
	public static double ToDouble(bool value) { }

	// RVA: 0x1454630 Offset: 0x1453A30 VA: 0x181454630
	public static Decimal ToDecimal(object value) { }

	// RVA: 0x14549C0 Offset: 0x1453DC0 VA: 0x1814549C0
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14547A0 Offset: 0x1453BA0 VA: 0x1814547A0
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1454550 Offset: 0x1453950 VA: 0x181454550
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x1454B40 Offset: 0x1453F40 VA: 0x181454B40
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454D00 Offset: 0x1454100 VA: 0x181454D00
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x1454810 Offset: 0x1453C10 VA: 0x181454810
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14545C0 Offset: 0x14539C0 VA: 0x1814545C0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x1454BB0 Offset: 0x1453FB0 VA: 0x181454BB0
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1454950 Offset: 0x1453D50 VA: 0x181454950
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x14544E0 Offset: 0x14538E0 VA: 0x1814544E0
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x1454C90 Offset: 0x1454090 VA: 0x181454C90
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x1454880 Offset: 0x1453C80 VA: 0x181454880
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x1454C20 Offset: 0x1454020 VA: 0x181454C20
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x1454370 Offset: 0x1453770 VA: 0x181454370
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x1454450 Offset: 0x1453850 VA: 0x181454450
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x1456EB0 Offset: 0x14562B0 VA: 0x181456EB0
	public static string ToString(object value) { }

	// RVA: 0x1456D40 Offset: 0x1456140 VA: 0x181456D40
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x1456E90 Offset: 0x1456290 VA: 0x181456E90
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x1456D20 Offset: 0x1456120 VA: 0x181456D20
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x1453880 Offset: 0x1452C80 VA: 0x181453880
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14562E0 Offset: 0x14556E0 VA: 0x1814562E0
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x1455650 Offset: 0x1454A50 VA: 0x181455650
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x14576E0 Offset: 0x1456AE0 VA: 0x1814576E0
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x1455B10 Offset: 0x1454F10 VA: 0x181455B10
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1457840 Offset: 0x1456C40 VA: 0x181457840
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x1456100 Offset: 0x1455500 VA: 0x181456100
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1458050 Offset: 0x1457450 VA: 0x181458050
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x1457010 Offset: 0x1456410 VA: 0x181457010
	public static string ToString(int value, int toBase) { }

	// RVA: 0x1453300 Offset: 0x1452700 VA: 0x181453300
	public static string ToBase64String(byte[] inArray) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1453250 Offset: 0x1452650 VA: 0x181453250
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options) { }

	// RVA: 0x14531D0 Offset: 0x14525D0 VA: 0x1814531D0
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1452EE0 Offset: 0x14522E0 VA: 0x181452EE0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x1452A80 Offset: 0x1451E80 VA: 0x181452A80
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1452B10 Offset: 0x1451F10 VA: 0x181452B10
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1450EB0 Offset: 0x14502B0 VA: 0x181450EB0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x14533A0 Offset: 0x14527A0 VA: 0x1814533A0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x14524E0 Offset: 0x14518E0 VA: 0x1814524E0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x1452170 Offset: 0x1451570 VA: 0x181452170
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x1452310 Offset: 0x1451710 VA: 0x181452310
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1452670 Offset: 0x1451A70 VA: 0x181452670
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x1452590 Offset: 0x1451990 VA: 0x181452590
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x1458420 Offset: 0x1457820 VA: 0x181458420
	private static void .cctor() { }

}

