public class CP932 : MonoEncoding // TypeDefIndex: 7797
{	// Fields
	private const int SHIFTJIS_CODE_PAGE = 932;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x2247110 Offset: 0x2246510 VA: 0x182247110
	public void .ctor() { }

	// RVA: 0x2246470 Offset: 0x2245870 VA: 0x182246470 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2246680 Offset: 0x2245A80 VA: 0x182246680 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2246D20 Offset: 0x2246120 VA: 0x182246D20 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2246E80 Offset: 0x2246280 VA: 0x182246E80 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2247010 Offset: 0x2246410 VA: 0x182247010 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2247090 Offset: 0x2246490 VA: 0x182247090 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2246F70 Offset: 0x2246370 VA: 0x182246F70 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x2247120 Offset: 0x2246520 VA: 0x182247120 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2247150 Offset: 0x2246550 VA: 0x182247150 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2247180 Offset: 0x2246580 VA: 0x182247180 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x22471B0 Offset: 0x22465B0 VA: 0x1822471B0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x22471E0 Offset: 0x22465E0 VA: 0x1822471E0 Slot: 11
	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7798
{	// Fields
	private JISConvert convert; // 0x28
	private int last_byte_count; // 0x30
	private int last_byte_chars; // 0x34

	// Methods

	// RVA: 0x2246420 Offset: 0x2245820 VA: 0x182246420
	public void .ctor(JISConvert convert) { }

	// RVA: 0x2245F60 Offset: 0x2245360 VA: 0x182245F60 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2245E80 Offset: 0x2245280 VA: 0x182245E80 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x2246020 Offset: 0x2245420 VA: 0x182246020 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2246050 Offset: 0x2245450 VA: 0x182246050 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7800
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2244880 Offset: 0x2243C80 VA: 0x182244880
	public void .ctor() { }

	// RVA: 0x22448B0 Offset: 0x2243CB0 VA: 0x1822448B0 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7801
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x22448E0 Offset: 0x2243CE0 VA: 0x1822448E0
	public void .ctor() { }

	// RVA: 0x2244910 Offset: 0x2243D10 VA: 0x182244910 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7802
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2244940 Offset: 0x2243D40 VA: 0x182244940
	public void .ctor() { }

	// RVA: 0x2244970 Offset: 0x2243D70 VA: 0x182244970 Slot: 8
	public override string get_EncodingName() { }

}

public class CP51932 : MonoEncoding // TypeDefIndex: 7808
{	// Fields
	private const int EUC_JP_CODE_PAGE = 51932;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2245C90 Offset: 0x2245090 VA: 0x182245C90
	public void .ctor() { }

	// RVA: 0x2245800 Offset: 0x2244C00 VA: 0x182245800 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x2245760 Offset: 0x2244B60 VA: 0x182245760 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22458B0 Offset: 0x2244CB0 VA: 0x1822458B0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2245970 Offset: 0x2244D70 VA: 0x182245970 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2245A10 Offset: 0x2244E10 VA: 0x182245A10 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2245B90 Offset: 0x2244F90 VA: 0x182245B90 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2245C10 Offset: 0x2245010 VA: 0x182245C10 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2245B30 Offset: 0x2244F30 VA: 0x182245B30 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x2245AD0 Offset: 0x2244ED0 VA: 0x182245AD0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x2245CB0 Offset: 0x22450B0 VA: 0x182245CB0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2245CE0 Offset: 0x22450E0 VA: 0x182245CE0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2245D10 Offset: 0x2245110 VA: 0x182245D10 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x2245D40 Offset: 0x2245140 VA: 0x182245D40 Slot: 10
	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7809
{	// Methods

	// RVA: 0x2245750 Offset: 0x2244B50 VA: 0x182245750
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x2245140 Offset: 0x2244540 VA: 0x182245140 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x2245350 Offset: 0x2244750 VA: 0x182245350 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7810
{	// Fields
	private int last_count; // 0x28
	private int last_bytes; // 0x2C

	// Methods

	// RVA: 0x2245110 Offset: 0x2244510 VA: 0x182245110
	public void .ctor() { }

	// RVA: 0xE483C0 Offset: 0xE477C0 VA: 0x180E483C0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22449A0 Offset: 0x2243DA0 VA: 0x1822449A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x18A7B20 Offset: 0x18A6F20 VA: 0x1818A7B20 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2244BE0 Offset: 0x2243FE0 VA: 0x182244BE0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	// RVA: 0x22450A0 Offset: 0x22444A0 VA: 0x1822450A0
	private Exception Insufficient() { }

}

internal class CP936 : DbcsEncoding // TypeDefIndex: 7812
{	// Fields
	private const int GB2312_CODE_PAGE = 936;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2247C60 Offset: 0x2247060 VA: 0x182247C60
	public void .ctor() { }

	// RVA: 0x2247B80 Offset: 0x2246F80 VA: 0x182247B80 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x22477E0 Offset: 0x2246BE0 VA: 0x1822477E0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22478D0 Offset: 0x2246CD0 VA: 0x1822478D0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2247AA0 Offset: 0x2246EA0 VA: 0x182247AA0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2247B10 Offset: 0x2246F10 VA: 0x182247B10 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2247BE0 Offset: 0x2246FE0 VA: 0x182247BE0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x2247C70 Offset: 0x2247070 VA: 0x182247C70 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2247CA0 Offset: 0x22470A0 VA: 0x182247CA0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2247CD0 Offset: 0x22470D0 VA: 0x182247CD0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x2247D00 Offset: 0x2247100 VA: 0x182247D00 Slot: 10
	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7813
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_bytes; // 0x2C

	// Methods

	// RVA: 0x159B530 Offset: 0x159A930 VA: 0x18159B530
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x22471F0 Offset: 0x22465F0 VA: 0x1822471F0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22472B0 Offset: 0x22466B0 VA: 0x1822472B0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x2247380 Offset: 0x2246780 VA: 0x182247380 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2247590 Offset: 0x2246990 VA: 0x182247590 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

internal class CP949 : KoreanEncoding // TypeDefIndex: 7815
{	// Fields
	private const int UHC_CODE_PAGE = 949;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2247D30 Offset: 0x2247130 VA: 0x182247D30
	public void .ctor() { }

	// RVA: 0x2247D60 Offset: 0x2247160 VA: 0x182247D60 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2247D90 Offset: 0x2247190 VA: 0x182247D90 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2247DC0 Offset: 0x22471C0 VA: 0x182247DC0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2247DF0 Offset: 0x22471F0 VA: 0x182247DF0 Slot: 10
	public override string get_WebName() { }

}

internal class CP51949 : KoreanEncoding // TypeDefIndex: 7816
{	// Fields
	private const int EUCKR_CODE_PAGE = 51949;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2245D70 Offset: 0x2245170 VA: 0x182245D70
	public void .ctor() { }

	// RVA: 0x2245DA0 Offset: 0x22451A0 VA: 0x182245DA0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2245DD0 Offset: 0x22451D0 VA: 0x182245DD0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2245E00 Offset: 0x2245200 VA: 0x182245E00 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x2245E30 Offset: 0x2245230 VA: 0x182245E30 Slot: 10
	public override string get_WebName() { }

}

internal class CP950 : DbcsEncoding // TypeDefIndex: 7821
{	// Fields
	private const int BIG5_CODE_PAGE = 950;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x2248740 Offset: 0x2247B40 VA: 0x182248740
	public void .ctor() { }

	// RVA: 0x2248660 Offset: 0x2247A60 VA: 0x182248660 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x2248570 Offset: 0x2247970 VA: 0x182248570 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x22478D0 Offset: 0x2246CD0 VA: 0x1822478D0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2247B10 Offset: 0x2246F10 VA: 0x182247B10 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22486C0 Offset: 0x2247AC0 VA: 0x1822486C0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x2248750 Offset: 0x2247B50 VA: 0x182248750 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2248780 Offset: 0x2247B80 VA: 0x182248780 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x22487B0 Offset: 0x2247BB0 VA: 0x1822487B0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x22487E0 Offset: 0x2247BE0 VA: 0x1822487E0 Slot: 10
	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7822
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_conv; // 0x2C

	// Methods

	// RVA: 0x159B530 Offset: 0x159A930 VA: 0x18159B530
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x2247E20 Offset: 0x2247220 VA: 0x182247E20 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2247F60 Offset: 0x2247360 VA: 0x182247F60 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x22480B0 Offset: 0x22474B0 VA: 0x1822480B0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x22482F0 Offset: 0x22476F0 VA: 0x1822482F0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7829
{	// Methods

	// RVA: 0x2245E60 Offset: 0x2245260 VA: 0x182245E60
	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7840
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x22FFFF0 Offset: 0x22FF3F0 VA: 0x1822FFFF0
	public void .ctor() { }

	// RVA: 0x22FFF80 Offset: 0x22FF380 VA: 0x1822FFF80
	private static void .cctor() { }

	// RVA: 0x22FFB20 Offset: 0x22FEF20 VA: 0x1822FFB20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7842
{	// Fields
	private static readonly char[] ToChars; // 0x1B70

	// Methods

	// RVA: 0x2300530 Offset: 0x22FF930 VA: 0x182300530
	public void .ctor() { }

	// RVA: 0x23004C0 Offset: 0x22FF8C0 VA: 0x1823004C0
	private static void .cctor() { }

	// RVA: 0x23000B0 Offset: 0x22FF4B0 VA: 0x1823000B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7844
{	// Fields
	private static readonly char[] ToChars; // 0x1B90

	// Methods

	// RVA: 0x2301090 Offset: 0x2300490 VA: 0x182301090
	public void .ctor() { }

	// RVA: 0x2301020 Offset: 0x2300420 VA: 0x182301020
	private static void .cctor() { }

	// RVA: 0x23005E0 Offset: 0x22FF9E0 VA: 0x1823005E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7846
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x2301B70 Offset: 0x2300F70 VA: 0x182301B70
	public void .ctor() { }

	// RVA: 0x2301B00 Offset: 0x2300F00 VA: 0x182301B00
	private static void .cctor() { }

	// RVA: 0x2301140 Offset: 0x2300540 VA: 0x182301140 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7848
{	// Fields
	private static readonly char[] ToChars; // 0x1B90

	// Methods

	// RVA: 0x2301EA0 Offset: 0x23012A0 VA: 0x182301EA0
	public void .ctor() { }

	// RVA: 0x2301E30 Offset: 0x2301230 VA: 0x182301E30
	private static void .cctor() { }

	// RVA: 0x2301C20 Offset: 0x2301020 VA: 0x182301C20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7850
{	// Fields
	private static readonly char[] ToChars; // 0x1BB0

	// Methods

	// RVA: 0x23021D0 Offset: 0x23015D0 VA: 0x1823021D0
	public void .ctor() { }

	// RVA: 0x2302160 Offset: 0x2301560 VA: 0x182302160
	private static void .cctor() { }

	// RVA: 0x2301F50 Offset: 0x2301350 VA: 0x182301F50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7852
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x23022F0 Offset: 0x23016F0 VA: 0x1823022F0
	public void .ctor() { }

	// RVA: 0x2302280 Offset: 0x2301680 VA: 0x182302280
	private static void .cctor() { }

	// RVA: 0x2301C20 Offset: 0x2301020 VA: 0x182301C20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7858
{	// Fields
	private static readonly char[] ToChars; // 0x1BB0

	// Methods

	// RVA: 0x22EC0B0 Offset: 0x22EB4B0 VA: 0x1822EC0B0
	public void .ctor() { }

	// RVA: 0x22EC040 Offset: 0x22EB440 VA: 0x1822EC040
	private static void .cctor() { }

	// RVA: 0x22EBB00 Offset: 0x22EAF00 VA: 0x1822EBB00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7860
{	// Fields
	private static readonly char[] ToChars; // 0x1BDC

	// Methods

	// RVA: 0x22EC960 Offset: 0x22EBD60 VA: 0x1822EC960
	public void .ctor() { }

	// RVA: 0x22EC8F0 Offset: 0x22EBCF0 VA: 0x1822EC8F0
	private static void .cctor() { }

	// RVA: 0x22EC170 Offset: 0x22EB570 VA: 0x1822EC170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7862
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x22ECF10 Offset: 0x22EC310 VA: 0x1822ECF10
	public void .ctor() { }

	// RVA: 0x22ECEA0 Offset: 0x22EC2A0 VA: 0x1822ECEA0
	private static void .cctor() { }

	// RVA: 0x22ECA20 Offset: 0x22EBE20 VA: 0x1822ECA20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7864
{	// Fields
	private static readonly char[] ToChars; // 0x1BE0

	// Methods

	// RVA: 0x22ED740 Offset: 0x22ECB40 VA: 0x1822ED740
	public void .ctor() { }

	// RVA: 0x22ED6D0 Offset: 0x22ECAD0 VA: 0x1822ED6D0
	private static void .cctor() { }

	// RVA: 0x22ECFC0 Offset: 0x22EC3C0 VA: 0x1822ECFC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7866
{	// Fields
	private static readonly char[] ToChars; // 0x1C00

	// Methods

	// RVA: 0x22EE050 Offset: 0x22ED450 VA: 0x1822EE050
	public void .ctor() { }

	// RVA: 0x22EDFE0 Offset: 0x22ED3E0 VA: 0x1822EDFE0
	private static void .cctor() { }

	// RVA: 0x22ED7F0 Offset: 0x22ECBF0 VA: 0x1822ED7F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7868
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x22EE6F0 Offset: 0x22EDAF0 VA: 0x1822EE6F0
	public void .ctor() { }

	// RVA: 0x22EE680 Offset: 0x22EDA80 VA: 0x1822EE680
	private static void .cctor() { }

	// RVA: 0x22EE100 Offset: 0x22ED500 VA: 0x1822EE100 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7870
{	// Fields
	private static readonly char[] ToChars; // 0x1C00

	// Methods

	// RVA: 0x22EEA10 Offset: 0x22EDE10 VA: 0x1822EEA10
	public void .ctor() { }

	// RVA: 0x22EE9A0 Offset: 0x22EDDA0 VA: 0x1822EE9A0
	private static void .cctor() { }

	// RVA: 0x22EE7A0 Offset: 0x22EDBA0 VA: 0x1822EE7A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7873
{	// Methods

	// RVA: 0x22EEAC0 Offset: 0x22EDEC0 VA: 0x1822EEAC0
	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7874
{	// Methods

	// RVA: 0x22EEB40 Offset: 0x22EDF40 VA: 0x1822EEB40
	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7875
{	// Methods

	// RVA: 0x22EEBC0 Offset: 0x22EDFC0 VA: 0x1822EEBC0
	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7876
{	// Methods

	// RVA: 0x22EEC40 Offset: 0x22EE040 VA: 0x1822EEC40
	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7877
{	// Methods

	// RVA: 0x22EECC0 Offset: 0x22EE0C0 VA: 0x1822EECC0
	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7878
{	// Methods

	// RVA: 0x22EED40 Offset: 0x22EE140 VA: 0x1822EED40
	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7879
{	// Methods

	// RVA: 0x22EEDC0 Offset: 0x22EE1C0 VA: 0x1822EEDC0
	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7880
{	// Methods

	// RVA: 0x22EEE40 Offset: 0x22EE240 VA: 0x1822EEE40
	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7881
{	// Methods

	// RVA: 0x22EEEC0 Offset: 0x22EE2C0 VA: 0x1822EEEC0
	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7882
{	// Methods

	// RVA: 0x22EEF40 Offset: 0x22EE340 VA: 0x1822EEF40
	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7893
{	// Fields
	private static readonly char[] ToChars; // 0x1C28

	// Methods

	// RVA: 0x22EF300 Offset: 0x22EE700 VA: 0x1822EF300
	public void .ctor() { }

	// RVA: 0x22EF290 Offset: 0x22EE690 VA: 0x1822EF290
	private static void .cctor() { }

	// RVA: 0x22EEFC0 Offset: 0x22EE3C0 VA: 0x1822EEFC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7899
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x22E5A80 Offset: 0x22E4E80 VA: 0x1822E5A80
	public void .ctor() { }

	// RVA: 0x22E5A10 Offset: 0x22E4E10 VA: 0x1822E5A10
	private static void .cctor() { }

	// RVA: 0x22E5090 Offset: 0x22E4490 VA: 0x1822E5090 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7901
{	// Fields
	private static readonly char[] ToChars; // 0x1C30

	// Methods

	// RVA: 0x2182550 Offset: 0x2181950 VA: 0x182182550
	public void .ctor() { }

	// RVA: 0x21824E0 Offset: 0x21818E0 VA: 0x1821824E0
	private static void .cctor() { }

	// RVA: 0x21817F0 Offset: 0x2180BF0 VA: 0x1821817F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7903
{	// Fields
	private static readonly char[] ToChars; // 0x1C55

	// Methods

	// RVA: 0x22E66A0 Offset: 0x22E5AA0 VA: 0x1822E66A0
	public void .ctor() { }

	// RVA: 0x22E6630 Offset: 0x22E5A30 VA: 0x1822E6630
	private static void .cctor() { }

	// RVA: 0x22E5B30 Offset: 0x22E4F30 VA: 0x1822E5B30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7905
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x22E7500 Offset: 0x22E6900 VA: 0x1822E7500
	public void .ctor() { }

	// RVA: 0x22E7490 Offset: 0x22E6890 VA: 0x1822E7490
	private static void .cctor() { }

	// RVA: 0x22E6750 Offset: 0x22E5B50 VA: 0x1822E6750 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7907
{	// Fields
	private static readonly char[] ToChars; // 0x1C60

	// Methods

	// RVA: 0x22E80A0 Offset: 0x22E74A0 VA: 0x1822E80A0
	public void .ctor() { }

	// RVA: 0x22E8030 Offset: 0x22E7430 VA: 0x1822E8030
	private static void .cctor() { }

	// RVA: 0x22E75B0 Offset: 0x22E69B0 VA: 0x1822E75B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7909
{	// Fields
	private static readonly char[] ToChars; // 0x1C85

	// Methods

	// RVA: 0x2183300 Offset: 0x2182700 VA: 0x182183300
	public void .ctor() { }

	// RVA: 0x2183290 Offset: 0x2182690 VA: 0x182183290
	private static void .cctor() { }

	// RVA: 0x2182600 Offset: 0x2181A00 VA: 0x182182600 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7911
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x21840C0 Offset: 0x21834C0 VA: 0x1821840C0
	public void .ctor() { }

	// RVA: 0x2184050 Offset: 0x2183450 VA: 0x182184050
	private static void .cctor() { }

	// RVA: 0x21833B0 Offset: 0x21827B0 VA: 0x1821833B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7913
{	// Fields
	private static readonly char[] ToChars; // 0x1C90

	// Methods

	// RVA: 0x2184E80 Offset: 0x2184280 VA: 0x182184E80
	public void .ctor() { }

	// RVA: 0x2184E10 Offset: 0x2184210 VA: 0x182184E10
	private static void .cctor() { }

	// RVA: 0x2184170 Offset: 0x2183570 VA: 0x182184170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7915
{	// Fields
	private static readonly char[] ToChars; // 0x1CBC

	// Methods

	// RVA: 0x2185C40 Offset: 0x2185040 VA: 0x182185C40
	public void .ctor() { }

	// RVA: 0x2185BD0 Offset: 0x2184FD0 VA: 0x182185BD0
	private static void .cctor() { }

	// RVA: 0x2184F30 Offset: 0x2184330 VA: 0x182184F30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7917
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x2186A00 Offset: 0x2185E00 VA: 0x182186A00
	public void .ctor() { }

	// RVA: 0x2186990 Offset: 0x2185D90 VA: 0x182186990
	private static void .cctor() { }

	// RVA: 0x2185CF0 Offset: 0x21850F0 VA: 0x182185CF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7919
{	// Fields
	private static readonly char[] ToChars; // 0x1CC0

	// Methods

	// RVA: 0x21877C0 Offset: 0x2186BC0 VA: 0x1821877C0
	public void .ctor() { }

	// RVA: 0x2187750 Offset: 0x2186B50 VA: 0x182187750
	private static void .cctor() { }

	// RVA: 0x2186AB0 Offset: 0x2185EB0 VA: 0x182186AB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7921
{	// Fields
	private static readonly char[] ToChars; // 0x1CE0

	// Methods

	// RVA: 0x2188580 Offset: 0x2187980 VA: 0x182188580
	public void .ctor() { }

	// RVA: 0x2188510 Offset: 0x2187910 VA: 0x182188510
	private static void .cctor() { }

	// RVA: 0x2187870 Offset: 0x2186C70 VA: 0x182187870 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7923
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x2189340 Offset: 0x2188740 VA: 0x182189340
	public void .ctor() { }

	// RVA: 0x21892D0 Offset: 0x21886D0 VA: 0x1821892D0
	private static void .cctor() { }

	// RVA: 0x2188630 Offset: 0x2187A30 VA: 0x182188630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7925
{	// Fields
	private static readonly char[] ToChars; // 0x1CE0

	// Methods

	// RVA: 0x218A100 Offset: 0x2189500 VA: 0x18218A100
	public void .ctor() { }

	// RVA: 0x218A090 Offset: 0x2189490 VA: 0x18218A090
	private static void .cctor() { }

	// RVA: 0x21893F0 Offset: 0x21887F0 VA: 0x1821893F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7927
{	// Fields
	private static readonly char[] ToChars; // 0x1D16

	// Methods

	// RVA: 0x218AEC0 Offset: 0x218A2C0 VA: 0x18218AEC0
	public void .ctor() { }

	// RVA: 0x218AE50 Offset: 0x218A250 VA: 0x18218AE50
	private static void .cctor() { }

	// RVA: 0x218A1B0 Offset: 0x21895B0 VA: 0x18218A1B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7929
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x218BC80 Offset: 0x218B080 VA: 0x18218BC80
	public void .ctor() { }

	// RVA: 0x218BC10 Offset: 0x218B010 VA: 0x18218BC10
	private static void .cctor() { }

	// RVA: 0x218AF70 Offset: 0x218A370 VA: 0x18218AF70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7931
{	// Fields
	private static readonly char[] ToChars; // 0x1D2C

	// Methods

	// RVA: 0x218CA40 Offset: 0x218BE40 VA: 0x18218CA40
	public void .ctor() { }

	// RVA: 0x218C9D0 Offset: 0x218BDD0 VA: 0x18218C9D0
	private static void .cctor() { }

	// RVA: 0x218BD30 Offset: 0x218B130 VA: 0x18218BD30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7933
{	// Fields
	private static readonly char[] ToChars; // 0x1D4C

	// Methods

	// RVA: 0x218D800 Offset: 0x218CC00 VA: 0x18218D800
	public void .ctor() { }

	// RVA: 0x218D790 Offset: 0x218CB90 VA: 0x18218D790
	private static void .cctor() { }

	// RVA: 0x218CAF0 Offset: 0x218BEF0 VA: 0x18218CAF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7935
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x218E5C0 Offset: 0x218D9C0 VA: 0x18218E5C0
	public void .ctor() { }

	// RVA: 0x218E550 Offset: 0x218D950 VA: 0x18218E550
	private static void .cctor() { }

	// RVA: 0x218D8B0 Offset: 0x218CCB0 VA: 0x18218D8B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7937
{	// Fields
	private static readonly char[] ToChars; // 0x1D70

	// Methods

	// RVA: 0x218F380 Offset: 0x218E780 VA: 0x18218F380
	public void .ctor() { }

	// RVA: 0x218F310 Offset: 0x218E710 VA: 0x18218F310
	private static void .cctor() { }

	// RVA: 0x218E670 Offset: 0x218DA70 VA: 0x18218E670 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7939
{	// Fields
	private static readonly char[] ToChars; // 0x1D90

	// Methods

	// RVA: 0x2190140 Offset: 0x218F540 VA: 0x182190140
	public void .ctor() { }

	// RVA: 0x21900D0 Offset: 0x218F4D0 VA: 0x1821900D0
	private static void .cctor() { }

	// RVA: 0x218F430 Offset: 0x218E830 VA: 0x18218F430 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7941
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA98

	// Methods

	// RVA: 0x2190F00 Offset: 0x2190300 VA: 0x182190F00
	public void .ctor() { }

	// RVA: 0x2190E90 Offset: 0x2190290 VA: 0x182190E90
	private static void .cctor() { }

	// RVA: 0x21901F0 Offset: 0x218F5F0 VA: 0x1821901F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7943
{	// Fields
	private static readonly char[] ToChars; // 0x1D90

	// Methods

	// RVA: 0x2191890 Offset: 0x2190C90 VA: 0x182191890
	public void .ctor() { }

	// RVA: 0x2191820 Offset: 0x2190C20 VA: 0x182191820
	private static void .cctor() { }

	// RVA: 0x2190FB0 Offset: 0x21903B0 VA: 0x182190FB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7945
{	// Fields
	private static readonly char[] ToChars; // 0x1DDF

	// Methods

	// RVA: 0x2192650 Offset: 0x2191A50 VA: 0x182192650
	public void .ctor() { }

	// RVA: 0x21925E0 Offset: 0x21919E0 VA: 0x1821925E0
	private static void .cctor() { }

	// RVA: 0x2191940 Offset: 0x2190D40 VA: 0x182191940 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7947
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA90

	// Methods

	// RVA: 0x2193470 Offset: 0x2192870 VA: 0x182193470
	public void .ctor() { }

	// RVA: 0x2193400 Offset: 0x2192800 VA: 0x182193400
	private static void .cctor() { }

	// RVA: 0x2192700 Offset: 0x2191B00 VA: 0x182192700 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7949
{	// Fields
	private static readonly char[] ToChars; // 0x1DE0

	// Methods

	// RVA: 0x2193F10 Offset: 0x2193310 VA: 0x182193F10
	public void .ctor() { }

	// RVA: 0x2193EA0 Offset: 0x21932A0 VA: 0x182193EA0
	private static void .cctor() { }

	// RVA: 0x2193520 Offset: 0x2192920 VA: 0x182193520 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7951
{	// Fields
	private static readonly char[] ToChars; // 0x1E2C

	// Methods

	// RVA: 0x2194CD0 Offset: 0x21940D0 VA: 0x182194CD0
	public void .ctor() { }

	// RVA: 0x2194C60 Offset: 0x2194060 VA: 0x182194C60
	private static void .cctor() { }

	// RVA: 0x2193FC0 Offset: 0x21933C0 VA: 0x182193FC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7953
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AA90

	// Methods

	// RVA: 0x2195970 Offset: 0x2194D70 VA: 0x182195970
	public void .ctor() { }

	// RVA: 0x2195900 Offset: 0x2194D00 VA: 0x182195900
	private static void .cctor() { }

	// RVA: 0x2194D80 Offset: 0x2194180 VA: 0x182194D80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7955
{	// Fields
	private static readonly char[] ToChars; // 0x1E30

	// Methods

	// RVA: 0x2196730 Offset: 0x2195B30 VA: 0x182196730
	public void .ctor() { }

	// RVA: 0x21966C0 Offset: 0x2195AC0 VA: 0x1821966C0
	private static void .cctor() { }

	// RVA: 0x2195A20 Offset: 0x2194E20 VA: 0x182195A20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7957
{	// Fields
	private static readonly char[] ToChars; // 0x1E76

	// Methods

	// RVA: 0x21974F0 Offset: 0x21968F0 VA: 0x1821974F0
	public void .ctor() { }

	// RVA: 0x2197480 Offset: 0x2196880 VA: 0x182197480
	private static void .cctor() { }

	// RVA: 0x21967E0 Offset: 0x2195BE0 VA: 0x1821967E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7959
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AAB8

	// Methods

	// RVA: 0x2197B70 Offset: 0x2196F70 VA: 0x182197B70
	public void .ctor() { }

	// RVA: 0x2197B00 Offset: 0x2196F00 VA: 0x182197B00
	private static void .cctor() { }

	// RVA: 0x21975A0 Offset: 0x21969A0 VA: 0x1821975A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7961
{	// Fields
	private static readonly char[] ToChars; // 0x1E80

	// Methods

	// RVA: 0x21989D0 Offset: 0x2197DD0 VA: 0x1821989D0
	public void .ctor() { }

	// RVA: 0x2198960 Offset: 0x2197D60 VA: 0x182198960
	private static void .cctor() { }

	// RVA: 0x2197C30 Offset: 0x2197030 VA: 0x182197C30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7963
{	// Fields
	private static readonly char[] ToChars; // 0x1EE5

	// Methods

	// RVA: 0x2199770 Offset: 0x2198B70 VA: 0x182199770
	public void .ctor() { }

	// RVA: 0x2199700 Offset: 0x2198B00 VA: 0x182199700
	private static void .cctor() { }

	// RVA: 0x2198A80 Offset: 0x2197E80 VA: 0x182198A80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7965
{	// Fields
	private static readonly char[] ToChars; // 0x2B0ABE8

	// Methods

	// RVA: 0x219A550 Offset: 0x2199950 VA: 0x18219A550
	public void .ctor() { }

	// RVA: 0x219A4E0 Offset: 0x21998E0 VA: 0x18219A4E0
	private static void .cctor() { }

	// RVA: 0x2199820 Offset: 0x2198C20 VA: 0x182199820 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7967
{	// Fields
	private static readonly char[] ToChars; // 0x1EF0

	// Methods

	// RVA: 0x219B3A0 Offset: 0x219A7A0 VA: 0x18219B3A0
	public void .ctor() { }

	// RVA: 0x219B330 Offset: 0x219A730 VA: 0x18219B330
	private static void .cctor() { }

	// RVA: 0x219A600 Offset: 0x2199A00 VA: 0x18219A600 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7969
{	// Fields
	private static readonly char[] ToChars; // 0x1F3C

	// Methods

	// RVA: 0x219C0D0 Offset: 0x219B4D0 VA: 0x18219C0D0
	public void .ctor() { }

	// RVA: 0x219C060 Offset: 0x219B460 VA: 0x18219C060
	private static void .cctor() { }

	// RVA: 0x219B450 Offset: 0x219A850 VA: 0x18219B450 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7971
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AC40

	// Methods

	// RVA: 0x22E4FE0 Offset: 0x22E43E0 VA: 0x1822E4FE0
	public void .ctor() { }

	// RVA: 0x22E4F70 Offset: 0x22E4370 VA: 0x1822E4F70
	private static void .cctor() { }

	// RVA: 0x22E4280 Offset: 0x22E3680 VA: 0x1822E4280 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7977
{	// Fields
	private static readonly char[] ToChars; // 0x1F40

	// Methods

	// RVA: 0x227E3B0 Offset: 0x227D7B0 VA: 0x18227E3B0
	public void .ctor() { }

	// RVA: 0x227E340 Offset: 0x227D740 VA: 0x18227E340
	private static void .cctor() { }

	// RVA: 0x227D980 Offset: 0x227CD80 VA: 0x18227D980 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7979
{	// Fields
	private static readonly char[] ToChars; // 0x1FA0

	// Methods

	// RVA: 0x227EE40 Offset: 0x227E240 VA: 0x18227EE40
	public void .ctor() { }

	// RVA: 0x227EDD0 Offset: 0x227E1D0 VA: 0x18227EDD0
	private static void .cctor() { }

	// RVA: 0x227E460 Offset: 0x227D860 VA: 0x18227E460 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7981
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AC04

	// Methods

	// RVA: 0x227F640 Offset: 0x227EA40 VA: 0x18227F640
	public void .ctor() { }

	// RVA: 0x227F5D0 Offset: 0x227E9D0 VA: 0x18227F5D0
	private static void .cctor() { }

	// RVA: 0x227EEF0 Offset: 0x227E2F0 VA: 0x18227EEF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7983
{	// Fields
	private static readonly char[] ToChars; // 0x1FA0

	// Methods

	// RVA: 0x227FB80 Offset: 0x227EF80 VA: 0x18227FB80
	public void .ctor() { }

	// RVA: 0x227FB10 Offset: 0x227EF10 VA: 0x18227FB10
	private static void .cctor() { }

	// RVA: 0x227F700 Offset: 0x227EB00 VA: 0x18227F700 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7985
{	// Fields
	private static readonly char[] ToChars; // 0x2005

	// Methods

	// RVA: 0x2280090 Offset: 0x227F490 VA: 0x182280090
	public void .ctor() { }

	// RVA: 0x2280020 Offset: 0x227F420 VA: 0x182280020
	private static void .cctor() { }

	// RVA: 0x227FC40 Offset: 0x227F040 VA: 0x18227FC40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7987
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AAB0

	// Methods

	// RVA: 0x2280C80 Offset: 0x2280080 VA: 0x182280C80
	public void .ctor() { }

	// RVA: 0x2280C10 Offset: 0x2280010 VA: 0x182280C10
	private static void .cctor() { }

	// RVA: 0x2280150 Offset: 0x227F550 VA: 0x182280150 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7989
{	// Fields
	private static readonly char[] ToChars; // 0x2010

	// Methods

	// RVA: 0x2281140 Offset: 0x2280540 VA: 0x182281140
	public void .ctor() { }

	// RVA: 0x22810D0 Offset: 0x22804D0 VA: 0x1822810D0
	private static void .cctor() { }

	// RVA: 0x2280D30 Offset: 0x2280130 VA: 0x182280D30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7991
{	// Fields
	private static readonly char[] ToChars; // 0x2061

	// Methods

	// RVA: 0x22814C0 Offset: 0x22808C0 VA: 0x1822814C0
	public void .ctor() { }

	// RVA: 0x2281450 Offset: 0x2280850 VA: 0x182281450
	private static void .cctor() { }

	// RVA: 0x22811F0 Offset: 0x22805F0 VA: 0x1822811F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7993
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AAA0

	// Methods

	// RVA: 0x2281820 Offset: 0x2280C20 VA: 0x182281820
	public void .ctor() { }

	// RVA: 0x22817B0 Offset: 0x2280BB0 VA: 0x1822817B0
	private static void .cctor() { }

	// RVA: 0x2281570 Offset: 0x2280970 VA: 0x182281570 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7995
{	// Fields
	private static readonly char[] ToChars; // 0x2070

	// Methods

	// RVA: 0x2282FC0 Offset: 0x22823C0 VA: 0x182282FC0
	public void .ctor() { }

	// RVA: 0x2282F50 Offset: 0x2282350 VA: 0x182282F50
	private static void .cctor() { }

	// RVA: 0x22818D0 Offset: 0x2280CD0 VA: 0x1822818D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7997
{	// Fields
	private static readonly char[] ToChars; // 0x20D7

	// Methods

	// RVA: 0x2283E10 Offset: 0x2283210 VA: 0x182283E10
	public void .ctor() { }

	// RVA: 0x2283DA0 Offset: 0x22831A0 VA: 0x182283DA0
	private static void .cctor() { }

	// RVA: 0x2283070 Offset: 0x2282470 VA: 0x182283070 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7999
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AAA0

	// Methods

	// RVA: 0x2284C70 Offset: 0x2284070 VA: 0x182284C70
	public void .ctor() { }

	// RVA: 0x2284C00 Offset: 0x2284000 VA: 0x182284C00
	private static void .cctor() { }

	// RVA: 0x2283EC0 Offset: 0x22832C0 VA: 0x182283EC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 8001
{	// Fields
	private static readonly char[] ToChars; // 0x20E0

	// Methods

	// RVA: 0x2285AD0 Offset: 0x2284ED0 VA: 0x182285AD0
	public void .ctor() { }

	// RVA: 0x2285A60 Offset: 0x2284E60 VA: 0x182285A60
	private static void .cctor() { }

	// RVA: 0x2284D20 Offset: 0x2284120 VA: 0x182284D20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 8003
{	// Fields
	private static readonly char[] ToChars; // 0x210A

	// Methods

	// RVA: 0x2286920 Offset: 0x2285D20 VA: 0x182286920
	public void .ctor() { }

	// RVA: 0x22868B0 Offset: 0x2285CB0 VA: 0x1822868B0
	private static void .cctor() { }

	// RVA: 0x2285B80 Offset: 0x2284F80 VA: 0x182285B80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 8005
{	// Fields
	private static readonly char[] ToChars; // 0x2B0AAC4

	// Methods

	// RVA: 0x2287780 Offset: 0x2286B80 VA: 0x182287780
	public void .ctor() { }

	// RVA: 0x2287710 Offset: 0x2286B10 VA: 0x182287710
	private static void .cctor() { }

	// RVA: 0x22869D0 Offset: 0x2285DD0 VA: 0x1822869D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

