public abstract class Decoder // TypeDefIndex: 433
{
	internal DecoderFallback m_fallback; 
	internal DecoderFallbackBuffer m_fallbackBuffer; 

	[ComVisibleAttribute] 
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] 
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }


	internal void SerializeDecoder(SerializationInfo info) { }

	protected void .ctor() { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] 
	public virtual void Reset() { }

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] 
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[ComVisibleAttribute] 
	[CLSCompliantAttribute] 
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] 
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliantAttribute] 
	[ComVisibleAttribute] 
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

public class Decoder // TypeDefIndex: 7396
{
	private static readonly Decoder.Params DecoderDefaultParams; 
	private Equalizer _Equalizer; 
	private SynthesisFilter _LeftChannelFilter; 
	private SynthesisFilter _RightChannelFilter; 
	private bool _IsInitialized; 
	private LayerIDecoder _L1Decoder; 
	private LayerIIDecoder _L2Decoder; 
	private LayerIIIDecoder _L3Decoder; 
	private ABuffer _Output; 
	private int _OutputChannels; 
	private int _OutputFrequency; 

	internal static Decoder.Params DefaultParams { get; }
	internal virtual ABuffer OutputBuffer { set; }


	internal void .ctor(Decoder.Params params0) { }

	internal static Decoder.Params get_DefaultParams() { }

	internal virtual void set_OutputBuffer(ABuffer value) { }

	private void InitBlock() { }

	internal virtual ABuffer DecodeFrame(Header header, Bitstream stream) { }

	protected virtual DecoderException NewDecoderException(int errorcode, Exception throwable) { }

	protected virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer) { }

	private void Initialize(Header header) { }

	private static void .cctor() { }

}

public class Decoder.Params : ICloneable // TypeDefIndex: 7397
{
	private OutputChannels _OutputChannels; 
	private readonly Equalizer _Equalizer; 

	internal virtual Equalizer InitialEqualizerSettings { get; }


	internal virtual Equalizer get_InitialEqualizerSettings() { }

	public object Clone() { }

	public void .ctor() { }

}

public sealed class Decoder : IDisposable // TypeDefIndex: 13318
{
	private const string whiteSpace = " \t\n\r";
	private const string wordBreak = " \t\n\r{}[],:\"";
	private StringReader json; 

	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Decoder.Token NextToken { get; }


	private void .ctor(string jsonString) { }

	public static Variant Decode(string jsonString) { }

	public void Dispose() { }

	private ProxyObject DecodeObject() { }

	private ProxyArray DecodeArray() { }

	private Variant DecodeValue() { }

	private Variant DecodeByToken(Decoder.Token token) { }

	private Variant DecodeString() { }

	private Variant DecodeNumber() { }

	private void ConsumeWhiteSpace() { }

	private char get_PeekChar() { }

	private char get_NextChar() { }

	private string get_NextWord() { }

	private Decoder.Token get_NextToken() { }

}

private enum Decoder.Token // TypeDefIndex: 13319
{
	public int value__; 
	public const Decoder.Token None = 0;
	public const Decoder.Token OpenBrace = 1;
	public const Decoder.Token CloseBrace = 2;
	public const Decoder.Token OpenBracket = 3;
	public const Decoder.Token CloseBracket = 4;
	public const Decoder.Token Colon = 5;
	public const Decoder.Token Comma = 6;
	public const Decoder.Token String = 7;
	public const Decoder.Token Number = 8;
	public const Decoder.Token True = 9;
	public const Decoder.Token False = 10;
	public const Decoder.Token Null = 11;

}

