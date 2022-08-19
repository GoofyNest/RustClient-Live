public abstract class Encoder // TypeDefIndex: 444
{	// Fields
	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x18A9C50 Offset: 0x18A9050 VA: 0x1818A9C50
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public EncoderFallback get_Fallback() { }

	// RVA: 0x18A9CB0 Offset: 0x18A90B0 VA: 0x1818A9CB0
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17C5ED0 Offset: 0x17C52D0 VA: 0x1817C5ED0
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A9B80 Offset: 0x18A8F80 VA: 0x1818A9B80 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x18A97E0 Offset: 0x18A8BE0 VA: 0x1818A97E0 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x18A9950 Offset: 0x18A8D50 VA: 0x1818A9950 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A9470 Offset: 0x18A8870 VA: 0x1818A9470 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A9230 Offset: 0x18A8630 VA: 0x1818A9230 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x18A9180 Offset: 0x18A8580 VA: 0x1818A9180 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18A91D0 Offset: 0x18A85D0 VA: 0x1818A91D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18A9220 Offset: 0x18A8620 VA: 0x1818A9220 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x18A8D10 Offset: 0x18A8110 VA: 0x1818A8D10 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x18A8E20 Offset: 0x18A8220 VA: 0x1818A8E20 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public override int get_Remaining() { }

}

public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 449
{	// Fields
	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98

	// Methods

	// RVA: 0x190E670 Offset: 0x190DA70 VA: 0x18190E670
	public void .ctor() { }

	// RVA: 0x15A2AB0 Offset: 0x15A1EB0 VA: 0x1815A2AB0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190E6D0 Offset: 0x190DAD0 VA: 0x18190E6D0
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x190E3F0 Offset: 0x190D7F0 VA: 0x18190E3F0
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

}

public abstract class EncoderFallback // TypeDefIndex: 450
{	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static EncoderFallback replacementFallback; // 0x0
	private static EncoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x190E8D0 Offset: 0x190DCD0 VA: 0x18190E8D0
	private static object get_InternalSyncObject() { }

	// RVA: 0x190E960 Offset: 0x190DD60 VA: 0x18190E960
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x190E710 Offset: 0x190DB10 VA: 0x18190E710
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 451
{	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C
	private const int iMaxRecursion = 250;

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x190E300 Offset: 0x190D700 VA: 0x18190E300 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x190E2E0 Offset: 0x190D6E0 VA: 0x18190E2E0
	internal void InternalReset() { }

	// RVA: 0x190E2A0 Offset: 0x190D6A0 VA: 0x18190E2A0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x190E260 Offset: 0x190D660 VA: 0x18190E260
	internal char InternalGetNextChar() { }

	// RVA: 0x190E0A0 Offset: 0x190D4A0 VA: 0x18190E0A0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x190E330 Offset: 0x190D730 VA: 0x18190E330
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

internal class EncoderNLS : Encoder, ISerializable // TypeDefIndex: 452
{	// Fields
	internal char charLeftOver; // 0x20
	protected Encoding m_encoding; // 0x28
	protected bool m_mustFlush; // 0x30
	internal bool m_throwOnOverflow; // 0x31
	internal int m_charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x190F820 Offset: 0x190EC20 VA: 0x18190F820
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190F6F0 Offset: 0x190EAF0 VA: 0x18190F6F0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190F7B0 Offset: 0x190EBB0 VA: 0x18190F7B0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x190F8E0 Offset: 0x190ECE0 VA: 0x18190F8E0
	internal void .ctor() { }

	// RVA: 0x190F6C0 Offset: 0x190EAC0 VA: 0x18190F6C0 Slot: 4
	public override void Reset() { }

	// RVA: 0x190F020 Offset: 0x190E420 VA: 0x18190F020 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x190F1D0 Offset: 0x190E5D0 VA: 0x18190F1D0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x190F2F0 Offset: 0x190E6F0 VA: 0x18190F2F0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x190F570 Offset: 0x190E970 VA: 0x18190F570 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x190EB40 Offset: 0x190DF40 VA: 0x18190EB40 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x190EE50 Offset: 0x190E250 VA: 0x18190EE50 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Encoding get_Encoding() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_MustFlush() { }

	// RVA: 0x190F920 Offset: 0x190ED20 VA: 0x18190F920 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0xF5AC10 Offset: 0xF5A010 VA: 0x180F5AC10
	internal void ClearMustFlush() { }

}

public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 453
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x190FF60 Offset: 0x190F360 VA: 0x18190FF60
	public void .ctor() { }

	// RVA: 0x190FFA0 Offset: 0x190F3A0 VA: 0x18190FFA0
	public void .ctor(string replacement) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_DefaultString() { }

	// RVA: 0x190FE70 Offset: 0x190F270 VA: 0x18190FE70 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18A81E0 Offset: 0x18A75E0 VA: 0x1818A81E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x190FEF0 Offset: 0x190F2F0 VA: 0x18190FEF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE1200 Offset: 0xAE0600 VA: 0x180AE1200 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 454
{	// Fields
	private string strDefault; // 0x30
	private int fallbackCount; // 0x38
	private int fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x190FE00 Offset: 0x190F200 VA: 0x18190FE00
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x190FBF0 Offset: 0x190EFF0 VA: 0x18190FBF0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x190F930 Offset: 0x190ED30 VA: 0x18190F930 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x190FD70 Offset: 0x190F170 VA: 0x18190FD70 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x190FDC0 Offset: 0x190F1C0 VA: 0x18190FDC0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x190FE60 Offset: 0x190F260 VA: 0x18190FE60 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x190FDE0 Offset: 0x190F1E0 VA: 0x18190FDE0 Slot: 9
	public override void Reset() { }

}

public abstract class Encoding : ICloneable // TypeDefIndex: 455
{	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	private const int MIMECONTF_MAILNEWS = 1;
	private const int MIMECONTF_BROWSER = 2;
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;
	private const int MIMECONTF_SAVABLE_BROWSER = 512;
	private const int CodePageDefault = 0;
	private const int CodePageNoOEM = 1;
	private const int CodePageNoMac = 2;
	private const int CodePageNoThread = 3;
	private const int CodePageNoSymbol = 42;
	private const int CodePageUnicode = 1200;
	private const int CodePageBigEndian = 1201;
	private const int CodePageWindows1252 = 1252;
	private const int CodePageMacGB2312 = 10008;
	private const int CodePageGB2312 = 20936;
	private const int CodePageMacKorean = 10003;
	private const int CodePageDLLKorean = 20949;
	private const int ISO2022JP = 50220;
	private const int ISO2022JPESC = 50221;
	private const int ISO2022JPSISO = 50222;
	private const int ISOKorean = 50225;
	private const int ISOSimplifiedCN = 50227;
	private const int EUCJP = 51932;
	private const int ChineseHZ = 52936;
	private const int DuplicateEUCCN = 51936;
	private const int EUCCN = 936;
	private const int EUCKR = 51949;
	internal const int CodePageASCII = 20127;
	internal const int ISO_8859_1 = 28591;
	private const int ISCIIAssemese = 57006;
	private const int ISCIIBengali = 57003;
	private const int ISCIIDevanagari = 57002;
	private const int ISCIIGujarathi = 57010;
	private const int ISCIIKannada = 57008;
	private const int ISCIIMalayalam = 57009;
	private const int ISCIIOriya = 57007;
	private const int ISCIIPanjabi = 57011;
	private const int ISCIITamil = 57004;
	private const int ISCIITelugu = 57005;
	private const int GB18030 = 54936;
	private const int ISO_8859_8I = 38598;
	private const int ISO_8859_8_Visual = 28598;
	private const int ENC50229 = 50229;
	private const int CodePageUTF7 = 65000;
	private const int CodePageUTF8 = 65001;
	private const int CodePageUTF32 = 12000;
	private const int CodePageUTF32BE = 12001;
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string BodyName { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	public virtual int WindowsCodePage { get; }
	public virtual bool IsBrowserDisplay { get; }
	public virtual bool IsBrowserSave { get; }
	public virtual bool IsMailNewsDisplay { get; }
	public virtual bool IsMailNewsSave { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual bool IsSingleByte { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x1915B10 Offset: 0x1914F10 VA: 0x181915B10
	protected void .ctor() { }

	// RVA: 0x1915A80 Offset: 0x1914E80 VA: 0x181915A80
	protected void .ctor(int codePage) { }

	// RVA: 0x1915690 Offset: 0x1914A90 VA: 0x181915690 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x1915540 Offset: 0x1914940 VA: 0x181915540
	internal void OnDeserializing() { }

	// RVA: 0x19154F0 Offset: 0x19148F0 VA: 0x1819154F0
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1915540 Offset: 0x1914940 VA: 0x181915540
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19154F0 Offset: 0x19148F0 VA: 0x1819154F0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1912FC0 Offset: 0x19123C0 VA: 0x181912FC0
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1915580 Offset: 0x1914980 VA: 0x181915580
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1915E10 Offset: 0x1915210 VA: 0x181915E10
	private static object get_InternalSyncObject() { }

	// RVA: 0x1914220 Offset: 0x1913620 VA: 0x181914220
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x19150D0 Offset: 0x19144D0 VA: 0x1819150D0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x19152C0 Offset: 0x19146C0 VA: 0x1819152C0 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1914020 Offset: 0x1913420 VA: 0x181914020
	private void GetDataItem() { }

	// RVA: 0x1915CB0 Offset: 0x19150B0 VA: 0x181915CB0 Slot: 7
	public virtual string get_BodyName() { }

	// RVA: 0x1915DC0 Offset: 0x19151C0 VA: 0x181915DC0 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x1915DD0 Offset: 0x19151D0 VA: 0x181915DD0 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x19163B0 Offset: 0x19157B0 VA: 0x1819163B0 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x19163F0 Offset: 0x19157F0 VA: 0x1819163F0 Slot: 11
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x1915EA0 Offset: 0x19152A0 VA: 0x181915EA0 Slot: 12
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x1915EE0 Offset: 0x19152E0 VA: 0x181915EE0 Slot: 13
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x1915F20 Offset: 0x1915320 VA: 0x181915F20 Slot: 14
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x1915F60 Offset: 0x1915360 VA: 0x181915F60 Slot: 15
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 16
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x1916500 Offset: 0x1915900 VA: 0x181916500
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x1916440 Offset: 0x1915840 VA: 0x181916440
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1912ED0 Offset: 0x19122D0 VA: 0x181912ED0 Slot: 17
	public virtual object Clone() { }

	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public bool get_IsReadOnly() { }

	// RVA: 0x1915B70 Offset: 0x1914F70 VA: 0x181915B70
	public static Encoding get_ASCII() { }

	// RVA: 0x1915FA0 Offset: 0x19153A0 VA: 0x181915FA0
	private static Encoding get_Latin1() { }

	// RVA: 0x1913430 Offset: 0x1912830 VA: 0x181913430 Slot: 18
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x19134E0 Offset: 0x19128E0 VA: 0x1819134E0 Slot: 20
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1271AB0 Offset: 0x1270EB0 VA: 0x181271AB0 Slot: 21
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1913AF0 Offset: 0x1912EF0 VA: 0x181913AF0 Slot: 22
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1913A20 Offset: 0x1912E20 VA: 0x181913A20 Slot: 23
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1913850 Offset: 0x1912C50 VA: 0x181913850 Slot: 25
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1913940 Offset: 0x1912D40 VA: 0x181913940 Slot: 26
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1913A00 Offset: 0x1912E00 VA: 0x181913A00 Slot: 27
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1913630 Offset: 0x1912A30 VA: 0x181913630 Slot: 28
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1913BA0 Offset: 0x1912FA0 VA: 0x181913BA0 Slot: 30
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1913CF0 Offset: 0x19130F0 VA: 0x181913CF0 Slot: 31
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1913D10 Offset: 0x1913110 VA: 0x181913D10 Slot: 32
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x1913DE0 Offset: 0x19131E0 VA: 0x181913DE0 Slot: 34
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1914000 Offset: 0x1913400 VA: 0x181914000 Slot: 35
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x1915320 Offset: 0x1914720 VA: 0x181915320
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 36
	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 37
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x1914140 Offset: 0x1913540 VA: 0x181914140 Slot: 38
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1912F60 Offset: 0x1912360 VA: 0x181912F60
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x139E1C0 Offset: 0x139D5C0 VA: 0x18139E1C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x1915CF0 Offset: 0x19150F0 VA: 0x181915CF0
	public static Encoding get_Default() { }

	// RVA: 0x19141B0 Offset: 0x19135B0 VA: 0x1819141B0 Slot: 39
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x1915410 Offset: 0x1914810 VA: 0x181915410 Slot: 42
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x19154C0 Offset: 0x19148C0 VA: 0x1819154C0 Slot: 43
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1916310 Offset: 0x1915710 VA: 0x181916310
	public static Encoding get_Unicode() { }

	// RVA: 0x1915C10 Offset: 0x1915010 VA: 0x181915C10
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x1916140 Offset: 0x1915540 VA: 0x181916140
	public static Encoding get_UTF7() { }

	// RVA: 0x1916230 Offset: 0x1915630 VA: 0x181916230
	public static Encoding get_UTF8() { }

	// RVA: 0x1916080 Offset: 0x1915480 VA: 0x181916080
	public static Encoding get_UTF32() { }

	// RVA: 0x1913280 Offset: 0x1912680 VA: 0x181913280 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1915250 Offset: 0x1914650 VA: 0x181915250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19133D0 Offset: 0x19127D0 VA: 0x1819133D0 Slot: 44
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1913370 Offset: 0x1912770 VA: 0x181913370 Slot: 45
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x19157E0 Offset: 0x1914BE0 VA: 0x1819157E0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x1915750 Offset: 0x1914B50 VA: 0x181915750
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x1915980 Offset: 0x1914D80 VA: 0x181915980
	internal void ThrowCharsOverflow() { }

	// RVA: 0x19158E0 Offset: 0x1914CE0 VA: 0x1819158E0
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x190DBE0 Offset: 0x190CFE0 VA: 0x18190DBE0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x190DE50 Offset: 0x190D250 VA: 0x18190DE50
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190DCE0 Offset: 0x190D0E0 VA: 0x18190DCE0 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x190DDC0 Offset: 0x190D1C0 VA: 0x18190DDC0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190DC20 Offset: 0x190D020 VA: 0x18190DC20 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x190DC50 Offset: 0x190D050 VA: 0x18190DC50 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x190DC80 Offset: 0x190D080 VA: 0x18190DC80 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x190DCB0 Offset: 0x190D0B0 VA: 0x18190DCB0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x190DBE0 Offset: 0x190CFE0 VA: 0x18190DBE0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x190D9E0 Offset: 0x190CDE0 VA: 0x18190D9E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190D8E0 Offset: 0x190CCE0 VA: 0x18190D8E0 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x190D950 Offset: 0x190CD50 VA: 0x18190D950 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE483C0 Offset: 0xE477C0 VA: 0x180E483C0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x190D850 Offset: 0x190CC50 VA: 0x18190D850 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x190D820 Offset: 0x190CC20 VA: 0x18190D820 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18A7B20 Offset: 0x18A6F20 VA: 0x1818A7B20 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x190D8B0 Offset: 0x190CCB0 VA: 0x18190D8B0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x190D880 Offset: 0x190CC80 VA: 0x18190D880 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

}

internal class Encoding.EncodingCharBuffer // TypeDefIndex: 458
{	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1910E70 Offset: 0x1910270 VA: 0x181910E70
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1910AB0 Offset: 0x190FEB0 VA: 0x181910AB0
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x1910B90 Offset: 0x190FF90 VA: 0x181910B90
	internal bool AddChar(char ch) { }

	// RVA: 0x1910C70 Offset: 0x1910070 VA: 0x181910C70
	internal void AdjustBytes(int count) { }

	// RVA: 0x1910F80 Offset: 0x1910380 VA: 0x181910F80
	internal bool get_MoreData() { }

	// RVA: 0x1910E50 Offset: 0x1910250 VA: 0x181910E50
	internal byte GetNextByte() { }

	// RVA: 0x1910F70 Offset: 0x1910370 VA: 0x181910F70
	internal int get_BytesUsed() { }

	// RVA: 0x1910DD0 Offset: 0x19101D0 VA: 0x181910DD0
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x1910C80 Offset: 0x1910080 VA: 0x181910C80
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal int get_Count() { }

}

internal class Encoding.EncodingByteBuffer // TypeDefIndex: 459
{	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x19107A0 Offset: 0x190FBA0 VA: 0x1819107A0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x1910530 Offset: 0x190F930 VA: 0x181910530
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x1910470 Offset: 0x190F870 VA: 0x181910470
	internal bool AddByte(byte b1) { }

	// RVA: 0x1910480 Offset: 0x190F880 VA: 0x181910480
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x19104D0 Offset: 0x190F8D0 VA: 0x1819104D0
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x19106B0 Offset: 0x190FAB0 VA: 0x1819106B0
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x1910A60 Offset: 0x190FE60 VA: 0x181910A60
	internal bool get_MoreData() { }

	// RVA: 0x1910640 Offset: 0x190FA40 VA: 0x181910640
	internal char GetNextChar() { }

	// RVA: 0x1910A40 Offset: 0x190FE40 VA: 0x181910A40
	internal int get_CharsUsed() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{	// Methods

	// RVA: 0x1912C40 Offset: 0x1912040 VA: 0x181912C40
	protected void .ctor(int codePage) { }

	// RVA: 0x1911BF0 Offset: 0x1910FF0 VA: 0x181911BF0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1911B50 Offset: 0x1910F50 VA: 0x181911B50 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x1911A50 Offset: 0x1910E50 VA: 0x181911A50 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1912120 Offset: 0x1911520 VA: 0x181912120 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1911D80 Offset: 0x1911180 VA: 0x181911D80 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1911FE0 Offset: 0x19113E0 VA: 0x181911FE0 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1912380 Offset: 0x1911780 VA: 0x181912380 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1912510 Offset: 0x1911910 VA: 0x181912510 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1912750 Offset: 0x1911B50 VA: 0x181912750 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1912610 Offset: 0x1911A10 VA: 0x181912610 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1912AB0 Offset: 0x1911EB0 VA: 0x181912AB0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19129B0 Offset: 0x1911DB0 VA: 0x1819129B0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1912A10 Offset: 0x1911E10 VA: 0x181912A10 Slot: 39
	public override Encoder GetEncoder() { }

}

public abstract class EncodingProvider // TypeDefIndex: 461
{	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x1912D60 Offset: 0x1912160 VA: 0x181912D60
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x1912C50 Offset: 0x1912050 VA: 0x181912C50
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x1912E70 Offset: 0x1912270 VA: 0x181912E70
	private static void .cctor() { }

}

internal static class EncodingHelper // TypeDefIndex: 479
{	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x19117F0 Offset: 0x1910BF0 VA: 0x1819117F0
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1911230 Offset: 0x1910630 VA: 0x181911230
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1910F90 Offset: 0x1910390 VA: 0x181910F90
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1911240 Offset: 0x1910640 VA: 0x181911240
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1911790 Offset: 0x1910B90 VA: 0x181911790
	private static void .cctor() { }

}

internal static class EncodingTable // TypeDefIndex: 736
{	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Hashtable hashByName; // 0x18
	private static Hashtable hashByCodePage; // 0x20

	// Methods

	// RVA: 0x16E2B40 Offset: 0x16E1F40 VA: 0x1816E2B40
	private static int GetNumEncodingItems() { }

	// RVA: 0x16E2750 Offset: 0x16E1B50 VA: 0x1816E2750
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x16E2BB0 Offset: 0x16E1FB0 VA: 0x1816E2BB0
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x16E2BE0 Offset: 0x16E1FE0 VA: 0x1816E2BE0
	private static void .cctor() { }

	// RVA: 0x16EC810 Offset: 0x16EBC10 VA: 0x1816EC810
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x16E29C0 Offset: 0x16E1DC0 VA: 0x1816E29C0
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x16E2790 Offset: 0x16E1B90 VA: 0x1816E2790
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7799
{	// Methods

	// RVA: 0x2247110 Offset: 0x2246510 VA: 0x182247110
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{	// Methods

	// RVA: 0x2244880 Offset: 0x2243C80 VA: 0x182244880
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{	// Methods

	// RVA: 0x2245C90 Offset: 0x2245090 VA: 0x182245C90
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{	// Methods

	// RVA: 0x2247C60 Offset: 0x2247060 VA: 0x182247C60
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{	// Methods

	// RVA: 0x2247D30 Offset: 0x2247130 VA: 0x182247D30
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{	// Methods

	// RVA: 0x2245D70 Offset: 0x2245170 VA: 0x182245D70
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{	// Methods

	// RVA: 0x2248740 Offset: 0x2247B40 VA: 0x182248740
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{	// Methods

	// RVA: 0x2245E60 Offset: 0x2245260 VA: 0x182245E60
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{	// Methods

	// RVA: 0x23026B0 Offset: 0x2301AB0 VA: 0x1823026B0
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{	// Methods

	// RVA: 0x23027B0 Offset: 0x2301BB0 VA: 0x1823027B0
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{	// Methods

	// RVA: 0x23028B0 Offset: 0x2301CB0 VA: 0x1823028B0
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{	// Methods

	// RVA: 0x23023B0 Offset: 0x23017B0 VA: 0x1823023B0
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{	// Methods

	// RVA: 0x23024B0 Offset: 0x23018B0 VA: 0x1823024B0
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{	// Methods

	// RVA: 0x23025B0 Offset: 0x23019B0 VA: 0x1823025B0
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{	// Methods

	// RVA: 0x23029B0 Offset: 0x2301DB0 VA: 0x1823029B0
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{	// Methods

	// RVA: 0x22EF7B0 Offset: 0x22EEBB0 VA: 0x1822EF7B0
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{	// Methods

	// RVA: 0x22EF8B0 Offset: 0x22EECB0 VA: 0x1822EF8B0
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{	// Methods

	// RVA: 0x22EF9B0 Offset: 0x22EEDB0 VA: 0x1822EF9B0
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{	// Methods

	// RVA: 0x22EF5B0 Offset: 0x22EE9B0 VA: 0x1822EF5B0
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{	// Methods

	// RVA: 0x22EF6B0 Offset: 0x22EEAB0 VA: 0x1822EF6B0
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{	// Methods

	// RVA: 0x22EF3B0 Offset: 0x22EE7B0 VA: 0x1822EF3B0
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{	// Methods

	// RVA: 0x22EF4B0 Offset: 0x22EE8B0 VA: 0x1822EF4B0
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{	// Methods

	// RVA: 0x22EEAC0 Offset: 0x22EDEC0 VA: 0x1822EEAC0
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{	// Methods

	// RVA: 0x22EEB40 Offset: 0x22EDF40 VA: 0x1822EEB40
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{	// Methods

	// RVA: 0x22EEBC0 Offset: 0x22EDFC0 VA: 0x1822EEBC0
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{	// Methods

	// RVA: 0x22EEC40 Offset: 0x22EE040 VA: 0x1822EEC40
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{	// Methods

	// RVA: 0x22EECC0 Offset: 0x22EE0C0 VA: 0x1822EECC0
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{	// Methods

	// RVA: 0x22EED40 Offset: 0x22EE140 VA: 0x1822EED40
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{	// Methods

	// RVA: 0x22EEDC0 Offset: 0x22EE1C0 VA: 0x1822EEDC0
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{	// Methods

	// RVA: 0x22EEE40 Offset: 0x22EE240 VA: 0x1822EEE40
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{	// Methods

	// RVA: 0x22EEEC0 Offset: 0x22EE2C0 VA: 0x1822EEEC0
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{	// Methods

	// RVA: 0x22EEF40 Offset: 0x22EE340 VA: 0x1822EEF40
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{	// Methods

	// RVA: 0x22EFAB0 Offset: 0x22EEEB0 VA: 0x1822EFAB0
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{	// Methods

	// RVA: 0x22E8DF0 Offset: 0x22E81F0 VA: 0x1822E8DF0
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{	// Methods

	// RVA: 0x22E8450 Offset: 0x22E7850 VA: 0x1822E8450
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{	// Methods

	// RVA: 0x22E8EF0 Offset: 0x22E82F0 VA: 0x1822E8EF0
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{	// Methods

	// RVA: 0x22E8FF0 Offset: 0x22E83F0 VA: 0x1822E8FF0
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{	// Methods

	// RVA: 0x22E9150 Offset: 0x22E8550 VA: 0x1822E9150
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{	// Methods

	// RVA: 0x22E84B0 Offset: 0x22E78B0 VA: 0x1822E84B0
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{	// Methods

	// RVA: 0x22E8210 Offset: 0x22E7610 VA: 0x1822E8210
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{	// Methods

	// RVA: 0x22E8270 Offset: 0x22E7670 VA: 0x1822E8270
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{	// Methods

	// RVA: 0x22E82D0 Offset: 0x22E76D0 VA: 0x1822E82D0
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{	// Methods

	// RVA: 0x22E8330 Offset: 0x22E7730 VA: 0x1822E8330
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{	// Methods

	// RVA: 0x22E8510 Offset: 0x22E7910 VA: 0x1822E8510
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{	// Methods

	// RVA: 0x22E8570 Offset: 0x22E7970 VA: 0x1822E8570
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{	// Methods

	// RVA: 0x22E85D0 Offset: 0x22E79D0 VA: 0x1822E85D0
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{	// Methods

	// RVA: 0x22E8630 Offset: 0x22E7A30 VA: 0x1822E8630
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{	// Methods

	// RVA: 0x22E8690 Offset: 0x22E7A90 VA: 0x1822E8690
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{	// Methods

	// RVA: 0x22E86F0 Offset: 0x22E7AF0 VA: 0x1822E86F0
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{	// Methods

	// RVA: 0x22E8750 Offset: 0x22E7B50 VA: 0x1822E8750
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{	// Methods

	// RVA: 0x22E87B0 Offset: 0x22E7BB0 VA: 0x1822E87B0
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{	// Methods

	// RVA: 0x22E8810 Offset: 0x22E7C10 VA: 0x1822E8810
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{	// Methods

	// RVA: 0x22E8870 Offset: 0x22E7C70 VA: 0x1822E8870
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{	// Methods

	// RVA: 0x22E88D0 Offset: 0x22E7CD0 VA: 0x1822E88D0
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{	// Methods

	// RVA: 0x22E8930 Offset: 0x22E7D30 VA: 0x1822E8930
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{	// Methods

	// RVA: 0x22E8990 Offset: 0x22E7D90 VA: 0x1822E8990
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{	// Methods

	// RVA: 0x22E89F0 Offset: 0x22E7DF0 VA: 0x1822E89F0
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{	// Methods

	// RVA: 0x22E8A50 Offset: 0x22E7E50 VA: 0x1822E8A50
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{	// Methods

	// RVA: 0x22E8AB0 Offset: 0x22E7EB0 VA: 0x1822E8AB0
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{	// Methods

	// RVA: 0x22E90F0 Offset: 0x22E84F0 VA: 0x1822E90F0
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{	// Methods

	// RVA: 0x22E83F0 Offset: 0x22E77F0 VA: 0x1822E83F0
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{	// Methods

	// RVA: 0x22E8390 Offset: 0x22E7790 VA: 0x1822E8390
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{	// Methods

	// RVA: 0x22E8B10 Offset: 0x22E7F10 VA: 0x1822E8B10
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{	// Methods

	// RVA: 0x22E8150 Offset: 0x22E7550 VA: 0x1822E8150
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{	// Methods

	// RVA: 0x22E8B70 Offset: 0x22E7F70 VA: 0x1822E8B70
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{	// Methods

	// RVA: 0x22E8BD0 Offset: 0x22E7FD0 VA: 0x1822E8BD0
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{	// Methods

	// RVA: 0x22E8C30 Offset: 0x22E8030 VA: 0x1822E8C30
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{	// Methods

	// RVA: 0x22E81B0 Offset: 0x22E75B0 VA: 0x1822E81B0
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{	// Methods

	// RVA: 0x22E8C90 Offset: 0x22E8090 VA: 0x1822E8C90
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{	// Methods

	// RVA: 0x22E8CF0 Offset: 0x22E80F0 VA: 0x1822E8CF0
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{	// Methods

	// RVA: 0x2288240 Offset: 0x2287640 VA: 0x182288240
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{	// Methods

	// RVA: 0x2288640 Offset: 0x2287A40 VA: 0x182288640
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{	// Methods

	// RVA: 0x2288340 Offset: 0x2287740 VA: 0x182288340
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{	// Methods

	// RVA: 0x2288440 Offset: 0x2287840 VA: 0x182288440
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{	// Methods

	// RVA: 0x2288540 Offset: 0x2287940 VA: 0x182288540
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{	// Methods

	// RVA: 0x2287F40 Offset: 0x2287340 VA: 0x182287F40
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{	// Methods

	// RVA: 0x2288040 Offset: 0x2287440 VA: 0x182288040
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{	// Methods

	// RVA: 0x2288140 Offset: 0x2287540 VA: 0x182288140
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{	// Methods

	// RVA: 0x2287E40 Offset: 0x2287240 VA: 0x182287E40
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{	// Methods

	// RVA: 0x2287840 Offset: 0x2286C40 VA: 0x182287840
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{	// Methods

	// RVA: 0x2287940 Offset: 0x2286D40 VA: 0x182287940
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{	// Methods

	// RVA: 0x2287A40 Offset: 0x2286E40 VA: 0x182287A40
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{	// Methods

	// RVA: 0x2287B40 Offset: 0x2286F40 VA: 0x182287B40
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{	// Methods

	// RVA: 0x2287C40 Offset: 0x2287040 VA: 0x182287C40
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{	// Methods

	// RVA: 0x2287D40 Offset: 0x2287140 VA: 0x182287D40
	public void .ctor() { }

}

public sealed class Encoder // TypeDefIndex: 11567
{	// Fields
	private static readonly Type includeAttrType; // 0x0
	private static readonly Type excludeAttrType; // 0x8
	private static readonly Type typeHintAttrType; // 0x10
	private readonly StringBuilder builder; // 0x10
	private readonly EncodeOptions options; // 0x18
	private int indent; // 0x1C

	// Properties
	private bool PrettyPrintEnabled { get; }
	private bool TypeHintsEnabled { get; }
	private bool IncludePublicPropertiesEnabled { get; }
	private bool EnforceHierarchyOrderEnabled { get; }

	// Methods

	// RVA: 0x83ECE0 Offset: 0x83E0E0 VA: 0x18083ECE0
	private void .ctor(EncodeOptions options) { }

	// RVA: 0x83E8D0 Offset: 0x83DCD0 VA: 0x18083E8D0
	public static string Encode(object obj) { }

	// RVA: 0x83E7F0 Offset: 0x83DBF0 VA: 0x18083E7F0
	public static string Encode(object obj, EncodeOptions options) { }

	// RVA: 0x83ED80 Offset: 0x83E180 VA: 0x18083ED80
	private bool get_PrettyPrintEnabled() { }

	// RVA: 0x83ED90 Offset: 0x83E190 VA: 0x18083ED90
	private bool get_TypeHintsEnabled() { }

	// RVA: 0x83ED70 Offset: 0x83E170 VA: 0x18083ED70
	private bool get_IncludePublicPropertiesEnabled() { }

	// RVA: 0x83ED60 Offset: 0x83E160 VA: 0x18083ED60
	private bool get_EnforceHierarchyOrderEnabled() { }

	// RVA: 0x83E1E0 Offset: 0x83D5E0 VA: 0x18083E1E0
	private void EncodeValue(object value, bool forceTypeHint) { }

	// RVA: 0x83E930 Offset: 0x83DD30 VA: 0x18083E930
	private IEnumerable<FieldInfo> GetFieldsForType(Type type) { }

	// RVA: 0x83EAA0 Offset: 0x83DEA0 VA: 0x18083EAA0
	private IEnumerable<PropertyInfo> GetPropertiesForType(Type type) { }

	// RVA: 0x83CCF0 Offset: 0x83C0F0 VA: 0x18083CCF0
	private void EncodeObject(object value, bool forceTypeHint) { }

	// RVA: 0x83D880 Offset: 0x83CC80 VA: 0x18083D880
	private void EncodeProxyArray(ProxyArray value) { }

	// RVA: 0x83DB90 Offset: 0x83CF90 VA: 0x18083DB90
	private void EncodeProxyObject(ProxyObject value) { }

	// RVA: 0x83C5C0 Offset: 0x83B9C0 VA: 0x18083C5C0
	private void EncodeDictionary(IDictionary value, bool forceTypeHint) { }

	// RVA: 0x83C9E0 Offset: 0x83BDE0 VA: 0x18083C9E0
	private void EncodeList(IList value, bool forceTypeHint) { }

	// RVA: 0x83C500 Offset: 0x83B900 VA: 0x18083C500
	private void EncodeArray(Array value, bool forceTypeHint) { }

	// RVA: 0x83C200 Offset: 0x83B600 VA: 0x18083C200
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint) { }

	// RVA: 0x83DEF0 Offset: 0x83D2F0 VA: 0x18083DEF0
	private void EncodeString(string value) { }

	// RVA: 0x83C110 Offset: 0x83B510 VA: 0x18083C110
	private void AppendIndent() { }

	// RVA: 0x83C160 Offset: 0x83B560 VA: 0x18083C160
	private void AppendOpenBrace() { }

	// RVA: 0x83BF40 Offset: 0x83B340 VA: 0x18083BF40
	private void AppendCloseBrace() { }

	// RVA: 0x83C1B0 Offset: 0x83B5B0 VA: 0x18083C1B0
	private void AppendOpenBracket() { }

	// RVA: 0x83BFC0 Offset: 0x83B3C0 VA: 0x18083BFC0
	private void AppendCloseBracket() { }

	// RVA: 0x83C090 Offset: 0x83B490 VA: 0x18083C090
	private void AppendComma(bool firstItem) { }

	// RVA: 0x83C040 Offset: 0x83B440 VA: 0x18083C040
	private void AppendColon() { }

	// RVA: 0x83EC10 Offset: 0x83E010 VA: 0x18083EC10
	private static void .cctor() { }

}

