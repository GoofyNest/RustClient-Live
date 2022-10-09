public abstract class Encoder // TypeDefIndex: 444
{
	internal EncoderFallback m_fallback; 
	internal EncoderFallbackBuffer m_fallbackBuffer; 

	[ComVisibleAttribute] 
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] 
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }


	internal void SerializeEncoder(SerializationInfo info) { }

	protected void .ctor() { }

	public EncoderFallback get_Fallback() { }

	public EncoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] 
	public virtual void Reset() { }

	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] 
	[ComVisibleAttribute] 
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] 
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{
	public override int MaxCharCount { get; }


	public void .ctor() { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override int get_MaxCharCount() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{
	public override int Remaining { get; }


	public void .ctor() { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override int get_Remaining() { }

}

public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 449
{
	private char charUnknown; 
	private char charUnknownHigh; 
	private char charUnknownLow; 
	private int index; 


	public void .ctor() { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, char charUnknown, int index) { }

	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

}

public abstract class EncoderFallback // TypeDefIndex: 450
{
	internal bool bIsMicrosoftBestFitFallback; 
	private static EncoderFallback replacementFallback; 
	private static EncoderFallback exceptionFallback; 
	private static object s_InternalSyncObject; 

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
{
	internal char* charStart; 
	internal char* charEnd; 
	internal EncoderNLS encoder; 
	internal bool setEncoder; 
	internal bool bUsedEncoder; 
	internal bool bFallingBack; 
	internal int iRecursionCount; 
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
{
	internal char charLeftOver; 
	protected Encoding m_encoding; 
	protected bool m_mustFlush; 
	internal bool m_throwOnOverflow; 
	internal int m_charsUsed; 

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
{
	private string strDefault; 

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
{
	private string strDefault; 
	private int fallbackCount; 
	private int fallbackIndex; 

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
{
	private static Encoding defaultEncoding; 
	private static Encoding unicodeEncoding; 
	private static Encoding bigEndianUnicode; 
	private static Encoding utf7Encoding; 
	private static Encoding utf8Encoding; 
	private static Encoding utf32Encoding; 
	private static Encoding asciiEncoding; 
	private static Encoding latin1Encoding; 
	private static Hashtable encodings; 
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
	internal int m_codePage; 
	internal CodePageDataItem dataItem; 
	internal bool m_deserializedFromEverett; 
	[OptionalFieldAttribute] 
	private bool m_isReadOnly; 
	[OptionalFieldAttribute] 
	internal EncoderFallback encoderFallback; 
	[OptionalFieldAttribute] 
	internal DecoderFallback decoderFallback; 
	private static object s_InternalSyncObject; 

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
	[ComVisibleAttribute] 
	public virtual bool IsSingleByte { get; }
	[ComVisibleAttribute] 
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] 
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] 
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

	[OnDeserializingAttribute] 
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] 
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] 
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

	[ComVisibleAttribute] 
	public virtual object Clone() { }

	public bool get_IsReadOnly() { }

	public static Encoding get_ASCII() { }

	private static Encoding get_Latin1() { }

	public virtual int GetByteCount(string s) { }

	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetByteCount(char* chars, int count) { }

	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	public virtual byte[] GetBytes(char[] chars) { }

	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	public virtual byte[] GetBytes(string s) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetCharCount(byte* bytes, int count) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public string GetString(byte* bytes, int byteCount) { }

	public virtual int get_CodePage() { }

	[ComVisibleAttribute] 
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
{
	private Encoding m_encoding; 
	private bool m_hasInitializedEncoding; 
	internal char charLeftOver; 


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
{
	private Encoding m_encoding; 
	private bool m_hasInitializedEncoding; 


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
{
	private char* chars; 
	private char* charStart; 
	private char* charEnd; 
	private int charCountResult; 
	private Encoding enc; 
	private DecoderNLS decoder; 
	private byte* byteStart; 
	private byte* byteEnd; 
	private byte* bytes; 
	private DecoderFallbackBuffer fallbackBuffer; 

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
{
	private byte* bytes; 
	private byte* byteStart; 
	private byte* byteEnd; 
	private char* chars; 
	private char* charStart; 
	private char* charEnd; 
	private int byteCountResult; 
	private Encoding enc; 
	private EncoderNLS encoder; 
	internal EncoderFallbackBuffer fallbackBuffer; 

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
{
	private static object s_InternalSyncObject; 
	private static EncodingProvider[] s_providers; 


	public abstract Encoding GetEncoding(string name);

	public abstract Encoding GetEncoding(int codepage);

	internal static Encoding GetEncodingFromProvider(int codepage) { }

	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	private static void .cctor() { }

}

internal static class EncodingHelper // TypeDefIndex: 479
{
	private static Encoding utf8EncodingWithoutMarkers; 
	private static readonly object lockobj; 
	private static Assembly i18nAssembly; 
	private static bool i18nDisabled; 

	internal static Encoding UTF8Unmarked { get; }


	internal static Encoding get_UTF8Unmarked() { }

	internal static string InternalCodePage(ref int code_page) { }

	internal static Encoding GetDefaultEncoding() { }

	internal static object InvokeI18N(string name, object[] args) { }

	private static void .cctor() { }

}

internal static class EncodingTable // TypeDefIndex: 736
{
	internal static InternalEncodingDataItem[] encodingDataPtr; 
	internal static InternalCodePageDataItem[] codePageDataPtr; 
	private static int lastEncodingItem; 
	private static Hashtable hashByName; 
	private static Hashtable hashByCodePage; 


	private static int GetNumEncodingItems() { }

	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	private static void .cctor() { }

	private static int internalGetCodePageFromName(string name) { }

	internal static int GetCodePageFromName(string name) { }

	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7806
{

	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7814
{

	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7818
{

	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7821
{

	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7826
{

	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7827
{

	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7830
{

	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7835
{

	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7848
{

	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7850
{

	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7852
{

	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7854
{

	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7856
{

	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7858
{

	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7860
{

	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7866
{

	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7868
{

	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7870
{

	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7872
{

	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7874
{

	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7876
{

	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7878
{

	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7890
{

	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7891
{

	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7892
{

	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7893
{

	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7894
{

	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7895
{

	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7896
{

	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7897
{

	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7898
{

	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7899
{

	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7901
{

	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7907
{

	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7909
{

	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7911
{

	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7913
{

	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7915
{

	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7917
{

	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7919
{

	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7921
{

	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7923
{

	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7925
{

	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7927
{

	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7929
{

	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7931
{

	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7933
{

	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7935
{

	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7937
{

	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7939
{

	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7941
{

	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7943
{

	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7945
{

	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7947
{

	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7949
{

	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7951
{

	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7953
{

	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7955
{

	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7957
{

	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7959
{

	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7961
{

	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7963
{

	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7965
{

	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7967
{

	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7969
{

	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7971
{

	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7973
{

	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7975
{

	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7977
{

	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7979
{

	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7985
{

	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7987
{

	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7989
{

	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7991
{

	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7993
{

	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7995
{

	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7997
{

	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7999
{

	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 8001
{

	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 8003
{

	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 8005
{

	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8007
{

	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8009
{

	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8011
{

	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8013
{

	public void .ctor() { }

}

public sealed class Encoder // TypeDefIndex: 13308
{
	private static readonly Type includeAttrType; 
	private static readonly Type excludeAttrType; 
	private static readonly Type typeHintAttrType; 
	private readonly StringBuilder builder; 
	private readonly EncodeOptions options; 
	private int indent; 

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

