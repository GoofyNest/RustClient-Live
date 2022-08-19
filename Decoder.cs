public abstract class Decoder // TypeDefIndex: 433
{	// Fields
	internal DecoderFallback m_fallback; // 0x10
	internal DecoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x18A8C40 Offset: 0x18A8040 VA: 0x1818A8C40
	internal void SerializeDecoder(SerializationInfo info) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public DecoderFallback get_Fallback() { }

	// RVA: 0x18A8CA0 Offset: 0x18A80A0 VA: 0x1818A8CA0
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17C5ED0 Offset: 0x17C52D0 VA: 0x1817C5ED0
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A8B70 Offset: 0x18A7F70 VA: 0x1818A8B70 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A8900 Offset: 0x18A7D00 VA: 0x1818A8900 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A87B0 Offset: 0x18A7BB0 VA: 0x1818A87B0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x18A8B50 Offset: 0x18A7F50 VA: 0x1818A8B50 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	[ComVisibleAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x18A8920 Offset: 0x18A7D20 VA: 0x1818A8920 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18A8440 Offset: 0x18A7840 VA: 0x1818A8440 Slot: 11
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	[CLSCompliantAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x18A8200 Offset: 0x18A7600 VA: 0x1818A8200 Slot: 12
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

public class Decoder // TypeDefIndex: 7388
{	// Fields
	private static readonly Decoder.Params DecoderDefaultParams; // 0x0
	private Equalizer _Equalizer; // 0x10
	private SynthesisFilter _LeftChannelFilter; // 0x18
	private SynthesisFilter _RightChannelFilter; // 0x20
	private bool _IsInitialized; // 0x28
	private LayerIDecoder _L1Decoder; // 0x30
	private LayerIIDecoder _L2Decoder; // 0x38
	private LayerIIIDecoder _L3Decoder; // 0x40
	private ABuffer _Output; // 0x48
	private int _OutputChannels; // 0x50
	private int _OutputFrequency; // 0x54

	// Properties
	internal static Decoder.Params DefaultParams { get; }
	internal virtual ABuffer OutputBuffer { set; }

	// Methods

	// RVA: 0x5F6E50 Offset: 0x5F6250 VA: 0x1805F6E50
	internal void .ctor(Decoder.Params params0) { }

	// RVA: 0x5F6F90 Offset: 0x5F6390 VA: 0x1805F6F90
	internal static Decoder.Params get_DefaultParams() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 4
	internal virtual void set_OutputBuffer(ABuffer value) { }

	// RVA: 0x5F68D0 Offset: 0x5F5CD0 VA: 0x1805F68D0
	private void InitBlock() { }

	// RVA: 0x5F6640 Offset: 0x5F5A40 VA: 0x1805F6640 Slot: 5
	internal virtual ABuffer DecodeFrame(Header header, Bitstream stream) { }

	// RVA: 0x5F6AF0 Offset: 0x5F5EF0 VA: 0x1805F6AF0 Slot: 6
	protected virtual DecoderException NewDecoderException(int errorcode, Exception throwable) { }

	// RVA: 0x5F6BC0 Offset: 0x5F5FC0 VA: 0x1805F6BC0 Slot: 7
	protected virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer) { }

	// RVA: 0x5F6970 Offset: 0x5F5D70 VA: 0x1805F6970
	private void Initialize(Header header) { }

	// RVA: 0x5F6DF0 Offset: 0x5F61F0 VA: 0x1805F6DF0
	private static void .cctor() { }

}

public class Decoder.Params : ICloneable // TypeDefIndex: 7389
{	// Fields
	private OutputChannels _OutputChannels; // 0x10
	private readonly Equalizer _Equalizer; // 0x18

	// Properties
	internal virtual Equalizer InitialEqualizerSettings { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	internal virtual Equalizer get_InitialEqualizerSettings() { }

	// RVA: 0x68C7E0 Offset: 0x68BBE0 VA: 0x18068C7E0 Slot: 4
	public object Clone() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public sealed class Decoder : IDisposable // TypeDefIndex: 11564
{	// Fields
	private const string whiteSpace = " \t\n\r";
	private const string wordBreak = " \t\n\r{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Decoder.Token NextToken { get; }

	// Methods

	// RVA: 0x83BA30 Offset: 0x83AE30 VA: 0x18083BA30
	private void .ctor(string jsonString) { }

	// RVA: 0x83B8B0 Offset: 0x83ACB0 VA: 0x18083B8B0
	public static Variant Decode(string jsonString) { }

	// RVA: 0x83B9F0 Offset: 0x83ADF0 VA: 0x18083B9F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x83B2F0 Offset: 0x83A6F0 VA: 0x18083B2F0
	private ProxyObject DecodeObject() { }

	// RVA: 0x83AEF0 Offset: 0x83A2F0 VA: 0x18083AEF0
	private ProxyArray DecodeArray() { }

	// RVA: 0x83B880 Offset: 0x83AC80 VA: 0x18083B880
	private Variant DecodeValue() { }

	// RVA: 0x83B020 Offset: 0x83A420 VA: 0x18083B020
	private Variant DecodeByToken(Decoder.Token token) { }

	// RVA: 0x83B550 Offset: 0x83A950 VA: 0x18083B550
	private Variant DecodeString() { }

	// RVA: 0x83B290 Offset: 0x83A690 VA: 0x18083B290
	private Variant DecodeNumber() { }

	// RVA: 0x83AE40 Offset: 0x83A240 VA: 0x18083AE40
	private void ConsumeWhiteSpace() { }

	// RVA: 0x83BEC0 Offset: 0x83B2C0 VA: 0x18083BEC0
	private char get_PeekChar() { }

	// RVA: 0x83BAB0 Offset: 0x83AEB0 VA: 0x18083BAB0
	private char get_NextChar() { }

	// RVA: 0x83BDD0 Offset: 0x83B1D0 VA: 0x18083BDD0
	private string get_NextWord() { }

	// RVA: 0x83BB30 Offset: 0x83AF30 VA: 0x18083BB30
	private Decoder.Token get_NextToken() { }

}

private enum Decoder.Token // TypeDefIndex: 11565
{	// Fields
	public int value__; // 0x0
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

