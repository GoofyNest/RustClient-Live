public class CP932 : MonoEncoding // TypeDefIndex: 7770
{
	private const int SHIFTJIS_CODE_PAGE = 932;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }


	public void .ctor() { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override Decoder GetDecoder() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override bool get_IsBrowserDisplay() { }

	public override bool get_IsBrowserSave() { }

	public override bool get_IsMailNewsDisplay() { }

	public override bool get_IsMailNewsSave() { }

	public override string get_WebName() { }

	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7771
{
	private JISConvert convert; 
	private int last_byte_count; 
	private int last_byte_chars; 


	public void .ctor(JISConvert convert) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7773
{
	public override string EncodingName { get; }


	public void .ctor() { }

	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7774
{
	public override string EncodingName { get; }


	public void .ctor() { }

	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7775
{
	public override string EncodingName { get; }


	public void .ctor() { }

	public override string get_EncodingName() { }

}

public class CP51932 : MonoEncoding // TypeDefIndex: 7781
{
	private const int EUC_JP_CODE_PAGE = 51932;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }


	public void .ctor() { }

	public override int GetByteCount(char[] chars, int index, int length) { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override Encoder GetEncoder() { }

	public override Decoder GetDecoder() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override bool get_IsBrowserDisplay() { }

	public override bool get_IsBrowserSave() { }

	public override bool get_IsMailNewsDisplay() { }

	public override bool get_IsMailNewsSave() { }

	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7782
{

	public void .ctor(MonoEncoding encoding) { }

	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7783
{
	private int last_count; 
	private int last_bytes; 


	public void .ctor() { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	private Exception Insufficient() { }

}

internal class CP936 : DbcsEncoding // TypeDefIndex: 7785
{
	private const int GB2312_CODE_PAGE = 936;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }


	public void .ctor() { }

	internal override DbcsConvert GetConvert() { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override Decoder GetDecoder() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override bool get_IsBrowserDisplay() { }

	public override bool get_IsBrowserSave() { }

	public override bool get_IsMailNewsDisplay() { }

	public override bool get_IsMailNewsSave() { }

	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7786
{
	private int last_byte_count; 
	private int last_byte_bytes; 


	public void .ctor(DbcsConvert convert) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

internal class CP949 : KoreanEncoding // TypeDefIndex: 7788
{
	private const int UHC_CODE_PAGE = 949;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }


	public void .ctor() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override string get_WebName() { }

}

internal class CP51949 : KoreanEncoding // TypeDefIndex: 7789
{
	private const int EUCKR_CODE_PAGE = 51949;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }


	public void .ctor() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override string get_WebName() { }

}

internal class CP950 : DbcsEncoding // TypeDefIndex: 7794
{
	private const int BIG5_CODE_PAGE = 950;

	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }


	public void .ctor() { }

	internal override DbcsConvert GetConvert() { }

	public override int GetByteCountImpl(char* chars, int count) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override Decoder GetDecoder() { }

	public override string get_BodyName() { }

	public override string get_EncodingName() { }

	public override string get_HeaderName() { }

	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7795
{
	private int last_byte_count; 
	private int last_byte_conv; 


	public void .ctor(DbcsConvert convert) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7802
{

	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7813
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7815
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7817
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7819
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7821
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7823
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7825
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7831
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7833
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7835
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7837
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7839
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7841
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7843
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7846
{

	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7847
{

	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7848
{

	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7849
{

	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7850
{

	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7851
{

	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7852
{

	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7853
{

	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7854
{

	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7855
{

	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7866
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7872
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7874
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7876
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7878
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7880
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7882
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7884
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7886
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7888
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7890
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7892
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7894
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7896
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7898
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7900
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7902
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7904
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7906
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7908
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7910
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7912
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7914
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7916
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7918
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7920
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7922
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7924
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7926
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7928
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7930
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7932
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7934
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7936
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7938
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7940
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7942
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7944
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7950
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7952
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7954
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7956
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7958
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7960
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7962
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7964
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7966
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7968
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7970
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7972
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 7974
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 7976
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 7978
{
	private static readonly char[] ToChars; 


	public void .ctor() { }

	private static void .cctor() { }

	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

