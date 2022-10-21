public abstract class ByteEncoding : MonoEncoding // TypeDefIndex: 7378
{
	protected char[] toChars; 
	protected string encodingName; 
	protected string bodyName; 
	protected string headerName; 
	protected string webName; 
	protected bool isBrowserDisplay; 
	protected bool isBrowserSave; 
	protected bool isMailNewsDisplay; 
	protected bool isMailNewsSave; 
	protected int windowsCodePage; 
	private static byte[] isNormalized; 
	private static byte[] isNormalizedComputed; 
	private static byte[] normalization_bytes; 

	public override bool IsSingleByte { get; }
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }


	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	public override bool get_IsSingleByte() { }

	public override int GetByteCount(string s) { }

	public override int GetByteCountImpl(char* chars, int count) { }

	protected abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);

	protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override string GetString(byte[] bytes, int index, int count) { }

	public override string GetString(byte[] bytes) { }

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

