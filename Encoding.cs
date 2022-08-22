public abstract class Encoder // TypeDefIndex: 444
{	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }


	internal void SerializeEncoder(SerializationInfo info) { }

	protected void .ctor() { }

	public EncoderFallback get_Fallback() { }

	public EncoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual void Reset() { }

	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	public override int MaxCharCount { get; }


	public void .ctor() { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	public override int Remaining { get; }


	public void .ctor() { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override int get_Remaining() { }

}

public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 449
{	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98


	public void .ctor() { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, char charUnknown, int index) { }

	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

}

public abstract class EncoderFallback // TypeDefIndex: 450
{	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static EncoderFallback replacementFallback; // 0x0
	private static EncoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	private static object InternalSyncObject { get; }
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }


	private static object get_InternalSyncObject() { }

	public static EncoderFallback get_ReplacementFallback() { }

	public static EncoderFallback get_ExceptionFallback() { }

	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	public abstract int get_MaxCharCount();

	protected void .ctor() { }

}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 451
{	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C
	private const int iMaxRecursion = 250;

	public abstract int Remaining { get; }


	public abstract bool Fallback(char charUnknown, int index);

	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	public abstract char GetNextChar();

	public abstract bool MovePrevious();

	public abstract int get_Remaining();

	public virtual void Reset() { }

	internal void InternalReset() { }

	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	internal char InternalGetNextChar() { }

	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	internal void ThrowLastCharRecursive(int charRecursive) { }

	protected void .ctor() { }

}

internal class EncoderNLS : Encoder, ISerializable // TypeDefIndex: 452
{	internal char charLeftOver; // 0x20
	protected Encoding m_encoding; // 0x28
	protected bool m_mustFlush; // 0x30
	internal bool m_throwOnOverflow; // 0x31
	internal int m_charsUsed; // 0x34

	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }


	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(Encoding encoding) { }

	internal void .ctor() { }

	public override void Reset() { }

	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	public override int GetByteCount(char* chars, int count, bool flush) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	public Encoding get_Encoding() { }

	public bool get_MustFlush() { }

	internal virtual bool get_HasState() { }

	internal void ClearMustFlush() { }

}

public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 453
{	private string strDefault; // 0x18

	public string DefaultString { get; }
	public override int MaxCharCount { get; }


	public void .ctor() { }

	public void .ctor(string replacement) { }

	public string get_DefaultString() { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 454
{	private string strDefault; // 0x30
	private int fallbackCount; // 0x38
	private int fallbackIndex; // 0x3C

	public override int Remaining { get; }


	public void .ctor(EncoderReplacementFallback fallback) { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override int get_Remaining() { }

	public override void Reset() { }

}

public abstract class Encoding : ICloneable // TypeDefIndex: 455
{	private static Encoding defaultEncoding; // 0x0
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


	protected void .ctor() { }

	protected void .ctor(int codePage) { }

	internal virtual void SetDefaultFallbacks() { }

	internal void OnDeserializing() { }

	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnSerializing(StreamingContext ctx) { }

	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	private static object get_InternalSyncObject() { }

	public static Encoding GetEncoding(int codepage) { }

	public static Encoding GetEncoding(string name) { }

	public virtual byte[] GetPreamble() { }

	private void GetDataItem() { }

	public virtual string get_BodyName() { }

	public virtual string get_EncodingName() { }

	public virtual string get_HeaderName() { }

	public virtual string get_WebName() { }

	public virtual int get_WindowsCodePage() { }

	public virtual bool get_IsBrowserDisplay() { }

	public virtual bool get_IsBrowserSave() { }

	public virtual bool get_IsMailNewsDisplay() { }

	public virtual bool get_IsMailNewsSave() { }

	public virtual bool get_IsSingleByte() { }

	public EncoderFallback get_EncoderFallback() { }

	public void set_EncoderFallback(EncoderFallback value) { }

	public DecoderFallback get_DecoderFallback() { }

	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual object Clone() { }

	public bool get_IsReadOnly() { }

	public static Encoding get_ASCII() { }

	private static Encoding get_Latin1() { }

	public virtual int GetByteCount(string s) { }

	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	public virtual int GetByteCount(char* chars, int count) { }

	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	public virtual byte[] GetBytes(char[] chars) { }

	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	public virtual byte[] GetBytes(string s) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	public virtual int GetCharCount(byte* bytes, int count) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	public string GetString(byte* bytes, int byteCount) { }

	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	public virtual Decoder GetDecoder() { }

	private static Encoding CreateDefaultEncoding() { }

	internal void setReadOnly(bool value = True) { }

	public static Encoding get_Default() { }

	public virtual Encoder GetEncoder() { }

	public abstract int GetMaxByteCount(int charCount);

	public abstract int GetMaxCharCount(int byteCount);

	public virtual string GetString(byte[] bytes) { }

	public virtual string GetString(byte[] bytes, int index, int count) { }

	public static Encoding get_Unicode() { }

	public static Encoding get_BigEndianUnicode() { }

	public static Encoding get_UTF7() { }

	public static Encoding get_UTF8() { }

	public static Encoding get_UTF32() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	internal void ThrowBytesOverflow() { }

	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	internal void ThrowCharsOverflow() { }

	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A


	public void .ctor(Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public object GetRealObject(StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	public override int GetByteCount(char* chars, int count, bool flush) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28


	public void .ctor(Encoding encoding) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public object GetRealObject(StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

}

internal class Encoding.EncodingCharBuffer // TypeDefIndex: 458
{	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }


	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	internal bool AddChar(char ch, int numBytes) { }

	internal bool AddChar(char ch) { }

	internal void AdjustBytes(int count) { }

	internal bool get_MoreData() { }

	internal byte GetNextByte() { }

	internal int get_BytesUsed() { }

	internal bool Fallback(byte fallbackByte) { }

	internal bool Fallback(byte[] byteBuffer) { }

	internal int get_Count() { }

}

internal class Encoding.EncodingByteBuffer // TypeDefIndex: 459
{	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }


	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	internal bool AddByte(byte b, int moreBytesExpected) { }

	internal bool AddByte(byte b1) { }

	internal bool AddByte(byte b1, byte b2) { }

	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	internal void MovePrevious(bool bThrow) { }

	internal bool get_MoreData() { }

	internal char GetNextChar() { }

	internal int get_CharsUsed() { }

	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{
	protected void .ctor(int codePage) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override string GetString(byte[] bytes, int index, int count) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

}

public abstract class EncodingProvider // TypeDefIndex: 461
{	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8


	public abstract Encoding GetEncoding(string name);

	public abstract Encoding GetEncoding(int codepage);

	internal static Encoding GetEncodingFromProvider(int codepage) { }

	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	private static void .cctor() { }

}

internal static class EncodingHelper // TypeDefIndex: 479
{	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	internal static Encoding UTF8Unmarked { get; }


	internal static Encoding get_UTF8Unmarked() { }

	internal static string InternalCodePage(ref int code_page) { }

	internal static Encoding GetDefaultEncoding() { }

	internal static object InvokeI18N(string name, object[] args) { }

	private static void .cctor() { }

}

internal static class EncodingTable // TypeDefIndex: 736
{	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Hashtable hashByName; // 0x18
	private static Hashtable hashByCodePage; // 0x20


	private static int GetNumEncodingItems() { }

	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	private static void .cctor() { }

	private static int internalGetCodePageFromName(string name) { }

	internal static int GetCodePageFromName(string name) { }

	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7799
{
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{
	public void .ctor() { }

}

public sealed class Encoder // TypeDefIndex: 11567
{	private static readonly Type includeAttrType; // 0x0
	private static readonly Type excludeAttrType; // 0x8
	private static readonly Type typeHintAttrType; // 0x10
	private readonly StringBuilder builder; // 0x10
	private readonly EncodeOptions options; // 0x18
	private int indent; // 0x1C

	private bool PrettyPrintEnabled { get; }
	private bool TypeHintsEnabled { get; }
	private bool IncludePublicPropertiesEnabled { get; }
	private bool EnforceHierarchyOrderEnabled { get; }


	private void .ctor(EncodeOptions options) { }

	public static string Encode(object obj) { }

	public static string Encode(object obj, EncodeOptions options) { }

	private bool get_PrettyPrintEnabled() { }

	private bool get_TypeHintsEnabled() { }

	private bool get_IncludePublicPropertiesEnabled() { }

	private bool get_EnforceHierarchyOrderEnabled() { }

	private void EncodeValue(object value, bool forceTypeHint) { }

	private IEnumerable<FieldInfo> GetFieldsForType(Type type) { }

	private IEnumerable<PropertyInfo> GetPropertiesForType(Type type) { }

	private void EncodeObject(object value, bool forceTypeHint) { }

	private void EncodeProxyArray(ProxyArray value) { }

	private void EncodeProxyObject(ProxyObject value) { }

	private void EncodeDictionary(IDictionary value, bool forceTypeHint) { }

	private void EncodeList(IList value, bool forceTypeHint) { }

	private void EncodeArray(Array value, bool forceTypeHint) { }

	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint) { }

	private void EncodeString(string value) { }

	private void AppendIndent() { }

	private void AppendOpenBrace() { }

	private void AppendCloseBrace() { }

	private void AppendOpenBracket() { }

	private void AppendCloseBracket() { }

	private void AppendComma(bool firstItem) { }

	private void AppendColon() { }

	private static void .cctor() { }

}

