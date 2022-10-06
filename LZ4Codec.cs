public static class LZ4Codec // TypeDefIndex: 6880
{

public static class LZ4Codec
	private static readonly int[] DECODER_TABLE_32; 
	private static readonly int[] DECODER_TABLE_64; 
	private static readonly int[] DEBRUIJN_TABLE_32; 
	private static readonly int[] DEBRUIJN_TABLE_64; 


	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	private static void BlockCopy(byte* src, byte* dst, int len) { }

	private static void BlockFill(byte* dst, int len, byte val) { }

	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 6881
{
	public byte* src_base; 
	public byte* nextToUpdate; 
	public int[] hashTable; 
	public ushort[] chainTable; 


	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 7014
{

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256

private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152

internal class <Module>

public static class LZ4Codec
	private static readonly int[] DECODER_TABLE_32; 
	private static readonly int[] DECODER_TABLE_64; 
	private static readonly int[] DEBRUIJN_TABLE_32; 
	private static readonly int[] DEBRUIJN_TABLE_64; 


	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	internal static ushort Peek2(byte[] buffer, int offset) { }

	internal static uint Peek4(byte[] buffer, int offset) { }

	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	private static void Copy4(byte[] buf, int src, int dst) { }

	private static void Copy8(byte[] buf, int src, int dst) { }

	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 7015
{
	public byte[] src; 
	public int src_base; 
	public int src_end; 
	public int src_LASTLITERALS; 
	public byte[] dst; 
	public int dst_base; 
	public int dst_len; 
	public int dst_end; 
	public int[] hashTable; 
	public ushort[] chainTable; 
	public int nextToUpdate; 


	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 7022
{
	private static readonly ILZ4Service Encoder; 
	private static readonly ILZ4Service EncoderHC; 
	private static readonly ILZ4Service Decoder; 
	private static ILZ4Service _service_MM32; 
	private static ILZ4Service _service_MM64; 
	private static ILZ4Service _service_CC32; 
	private static ILZ4Service _service_CC64; 
	private static ILZ4Service _service_N32; 
	private static ILZ4Service _service_N64; 
	private static ILZ4Service _service_S32; 
	private static ILZ4Service _service_S64; 


	private static bool Has2010Runtime() { }

	private static void InitializeLZ4mm() { }

	private static void InitializeLZ4cc() { }

	private static void InitializeLZ4n() { }

	private static void InitializeLZ4s() { }

	private static void .cctor() { }

	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	private static ILZ4Service AutoTest(ILZ4Service service) { }

	private static void Try(Action method) { }

	private static T Try<T>(Func<T> method, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-LZ4Codec.Try<bool>
	|
	|-LZ4Codec.Try<object>
	*/

	private static ILZ4Service TryService<T>() { }
	/* GenericInstMethod :
	|
	|-LZ4Codec.TryService<Safe32LZ4Service>
	|-LZ4Codec.TryService<Safe64LZ4Service>
	|-LZ4Codec.TryService<Unsafe32LZ4Service>
	|-LZ4Codec.TryService<Unsafe64LZ4Service>
	|-LZ4Codec.TryService<object>
	*/

	public static int MaximumOutputLength(int inputLength) { }

	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

