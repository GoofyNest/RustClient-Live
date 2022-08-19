public static class LZ4Codec // TypeDefIndex: 6711
{
// Namespace: LZ4pn
public static class LZ4Codec // TypeDefIndex: 6711
	// Fields
	private static readonly int[] DECODER_TABLE_32; // 0x0
	private static readonly int[] DECODER_TABLE_64; // 0x8
	private static readonly int[] DEBRUIJN_TABLE_32; // 0x10
	private static readonly int[] DEBRUIJN_TABLE_64; // 0x18

	// Methods

	// RVA: 0x22CC000 Offset: 0x22CB400 VA: 0x1822CC000
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x22CBF20 Offset: 0x22CB320 VA: 0x1822CBF20
	private static void BlockCopy(byte* src, byte* dst, int len) { }

	// RVA: 0x22CBF90 Offset: 0x22CB390 VA: 0x1822CBF90
	private static void BlockFill(byte* dst, int len, byte val) { }

	// RVA: 0x22CCD40 Offset: 0x22CC140 VA: 0x1822CCD40
	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22CCE90 Offset: 0x22CC290 VA: 0x1822CCE90
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22CC4E0 Offset: 0x22CB8E0 VA: 0x1822CC4E0
	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22CC190 Offset: 0x22CB590 VA: 0x1822CC190
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22CD800 Offset: 0x22CCC00 VA: 0x1822CD800
	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22CD4A0 Offset: 0x22CC8A0 VA: 0x1822CD4A0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22CC960 Offset: 0x22CBD60 VA: 0x1822CC960
	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22CC610 Offset: 0x22CBA10 VA: 0x1822CC610
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22CDB80 Offset: 0x22CCF80 VA: 0x1822CDB80
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	// RVA: 0x22D12C0 Offset: 0x22D06C0 VA: 0x1822D12C0
	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22CCA90 Offset: 0x22CBE90 VA: 0x1822CCA90
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1360 Offset: 0x22D0760 VA: 0x1822D1360
	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22CD1F0 Offset: 0x22CC5F0 VA: 0x1822CD1F0
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22CF820 Offset: 0x22CEC20 VA: 0x1822CF820
	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22CEB50 Offset: 0x22CDF50 VA: 0x1822CEB50
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D17D0 Offset: 0x22D0BD0 VA: 0x1822D17D0
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D1F40 Offset: 0x22D1340 VA: 0x1822D1F40
	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22CEA90 Offset: 0x22CDE90 VA: 0x1822CEA90
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22CD950 Offset: 0x22CCD50 VA: 0x1822CD950
	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22CDCA0 Offset: 0x22CD0A0 VA: 0x1822CDCA0
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22CE2A0 Offset: 0x22CD6A0 VA: 0x1822CE2A0
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D1400 Offset: 0x22D0800 VA: 0x1822D1400
	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	// RVA: 0x22D0520 Offset: 0x22CF920 VA: 0x1822D0520
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22CFE80 Offset: 0x22CF280 VA: 0x1822CFE80
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22CF1A0 Offset: 0x22CE5A0 VA: 0x1822CF1A0
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D1B40 Offset: 0x22D0F40 VA: 0x1822D1B40
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D2310 Offset: 0x22D1710 VA: 0x1822D2310
	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22CEA90 Offset: 0x22CDE90 VA: 0x1822CEA90
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22CDA50 Offset: 0x22CCE50 VA: 0x1822CDA50
	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22CDFA0 Offset: 0x22CD3A0 VA: 0x1822CDFA0
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22CE680 Offset: 0x22CDA80 VA: 0x1822CE680
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D15F0 Offset: 0x22D09F0 VA: 0x1822D15F0
	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	// RVA: 0x22D0BF0 Offset: 0x22CFFF0 VA: 0x1822D0BF0
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D2760 Offset: 0x22D1B60 VA: 0x1822D2760
	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 6712
{	// Fields
	public byte* src_base; // 0x10
	public byte* nextToUpdate; // 0x18
	public int[] hashTable; // 0x20
	public ushort[] chainTable; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 6981
{
// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 // TypeDefIndex: 6970

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 // TypeDefIndex: 6971

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 // TypeDefIndex: 6972

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 // TypeDefIndex: 6973

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 // TypeDefIndex: 6974

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 // TypeDefIndex: 6975

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 // TypeDefIndex: 6976

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 // TypeDefIndex: 6977

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6978

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 // TypeDefIndex: 6979

// Namespace: 
internal class <Module> // TypeDefIndex: 6980

// Namespace: LZ4ps
public static class LZ4Codec // TypeDefIndex: 6981
	// Fields
	private static readonly int[] DECODER_TABLE_32; // 0x0
	private static readonly int[] DECODER_TABLE_64; // 0x8
	private static readonly int[] DEBRUIJN_TABLE_32; // 0x10
	private static readonly int[] DEBRUIJN_TABLE_64; // 0x18

	// Methods

	// RVA: 0x224EF40 Offset: 0x224E340 VA: 0x18224EF40
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x2259E00 Offset: 0x2259200 VA: 0x182259E00
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x2259DA0 Offset: 0x22591A0 VA: 0x182259DA0
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x11FD490 Offset: 0x11FC890 VA: 0x1811FD490
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x225AC60 Offset: 0x225A060 VA: 0x18225AC60
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x225ADF0 Offset: 0x225A1F0 VA: 0x18225ADF0
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2250700 Offset: 0x224FB00 VA: 0x182250700
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x22507A0 Offset: 0x224FBA0 VA: 0x1822507A0
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x224F0D0 Offset: 0x224E4D0 VA: 0x18224F0D0
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x224F210 Offset: 0x224E610 VA: 0x18224F210
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x224EAC0 Offset: 0x224DEC0 VA: 0x18224EAC0
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x225AA50 Offset: 0x2259E50 VA: 0x18225AA50
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x2259E60 Offset: 0x2259260 VA: 0x182259E60
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x224FD80 Offset: 0x224F180 VA: 0x18224FD80
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22502A0 Offset: 0x224F6A0 VA: 0x1822502A0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x224F480 Offset: 0x224E880 VA: 0x18224F480
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x224F760 Offset: 0x224EB60 VA: 0x18224F760
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2250EF0 Offset: 0x22502F0 VA: 0x182250EF0
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	// RVA: 0x22571F0 Offset: 0x22565F0 VA: 0x1822571F0
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x224FB10 Offset: 0x224EF10 VA: 0x18224FB10
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2257290 Offset: 0x2256690 VA: 0x182257290
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2250030 Offset: 0x224F430 VA: 0x182250030
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22544F0 Offset: 0x22538F0 VA: 0x1822544F0
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22526F0 Offset: 0x2251AF0 VA: 0x1822526F0
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257E70 Offset: 0x2257270 VA: 0x182257E70
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x2258D90 Offset: 0x2258190 VA: 0x182258D90
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22523B0 Offset: 0x22517B0 VA: 0x1822523B0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2250B40 Offset: 0x224FF40 VA: 0x182250B40
	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2251040 Offset: 0x2250440 VA: 0x182251040
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	// RVA: 0x2251A40 Offset: 0x2250E40 VA: 0x182251A40
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x2257330 Offset: 0x2256730 VA: 0x182257330
	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	// RVA: 0x2256440 Offset: 0x2255840 VA: 0x182256440
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x2255470 Offset: 0x2254870 VA: 0x182255470
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22535D0 Offset: 0x22529D0 VA: 0x1822535D0
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22585D0 Offset: 0x22579D0 VA: 0x1822585D0
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x2259560 Offset: 0x2258960 VA: 0x182259560
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2252550 Offset: 0x2251950 VA: 0x182252550
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2250CF0 Offset: 0x22500F0 VA: 0x182250CF0
	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2251540 Offset: 0x2250940 VA: 0x182251540
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	// RVA: 0x2251ED0 Offset: 0x22512D0 VA: 0x182251ED0
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x22578D0 Offset: 0x2256CD0 VA: 0x1822578D0
	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	// RVA: 0x2256B30 Offset: 0x2255F30 VA: 0x182256B30
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x225B120 Offset: 0x225A520 VA: 0x18225B120
	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 6982
{	// Fields
	public byte[] src; // 0x10
	public int src_base; // 0x18
	public int src_end; // 0x1C
	public int src_LASTLITERALS; // 0x20
	public byte[] dst; // 0x28
	public int dst_base; // 0x30
	public int dst_len; // 0x34
	public int dst_end; // 0x38
	public int[] hashTable; // 0x40
	public ushort[] chainTable; // 0x48
	public int nextToUpdate; // 0x50

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 6989
{	// Fields
	private static readonly ILZ4Service Encoder; // 0x0
	private static readonly ILZ4Service EncoderHC; // 0x8
	private static readonly ILZ4Service Decoder; // 0x10
	private static ILZ4Service _service_MM32; // 0x18
	private static ILZ4Service _service_MM64; // 0x20
	private static ILZ4Service _service_CC32; // 0x28
	private static ILZ4Service _service_CC64; // 0x30
	private static ILZ4Service _service_N32; // 0x38
	private static ILZ4Service _service_N64; // 0x40
	private static ILZ4Service _service_S32; // 0x48
	private static ILZ4Service _service_S64; // 0x50

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool Has2010Runtime() { }

	// RVA: 0x2250970 Offset: 0x224FD70 VA: 0x182250970
	private static void InitializeLZ4mm() { }

	// RVA: 0x22508E0 Offset: 0x224FCE0 VA: 0x1822508E0
	private static void InitializeLZ4cc() { }

	// RVA: 0x2250A00 Offset: 0x224FE00 VA: 0x182250A00
	private static void InitializeLZ4n() { }

	// RVA: 0x2250AA0 Offset: 0x224FEA0 VA: 0x182250AA0
	private static void InitializeLZ4s() { }

	// RVA: 0x225B250 Offset: 0x225A650 VA: 0x18225B250
	private static void .cctor() { }

	// RVA: 0x225A0C0 Offset: 0x22594C0 VA: 0x18225A0C0
	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	// RVA: 0x224E690 Offset: 0x224DA90 VA: 0x18224E690
	private static ILZ4Service AutoTest(ILZ4Service service) { }

	// RVA: 0x225A9F0 Offset: 0x2259DF0 VA: 0x18225A9F0
	private static void Try(Action method) { }

	// RVA: -1 Offset: -1
	private static T Try<T>(Func<T> method, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EAAC0 Offset: 0x5E9EC0 VA: 0x1805EAAC0
	|-LZ4Codec.Try<bool>
	|
	|-RVA: 0x5EAB40 Offset: 0x5E9F40 VA: 0x1805EAB40
	|-LZ4Codec.Try<object>
	*/

	// RVA: -1 Offset: -1
	private static ILZ4Service TryService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257D10 Offset: 0x1257110 VA: 0x181257D10
	|-LZ4Codec.TryService<Safe32LZ4Service>
	|-LZ4Codec.TryService<Safe64LZ4Service>
	|-LZ4Codec.TryService<Unsafe32LZ4Service>
	|-LZ4Codec.TryService<Unsafe64LZ4Service>
	|-LZ4Codec.TryService<object>
	*/

	// RVA: 0x2259D80 Offset: 0x2259180 VA: 0x182259D80
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x2250640 Offset: 0x224FA40 VA: 0x182250640
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2250550 Offset: 0x224F950 VA: 0x182250550
	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x224FA40 Offset: 0x224EE40 VA: 0x18224FA40
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

