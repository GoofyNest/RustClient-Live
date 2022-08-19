internal sealed class DeflateManager // TypeDefIndex: 6942
{	// Fields
	private static readonly int MEM_LEVEL_MAX; // 0x0
	private static readonly int MEM_LEVEL_DEFAULT; // 0x4
	private DeflateManager.CompressFunc DeflateFunction; // 0x10
	private static readonly string[] _ErrorMessage; // 0x8
	private static readonly int PRESET_DICT; // 0x10
	private static readonly int INIT_STATE; // 0x14
	private static readonly int BUSY_STATE; // 0x18
	private static readonly int FINISH_STATE; // 0x1C
	private static readonly int Z_DEFLATED; // 0x20
	private static readonly int STORED_BLOCK; // 0x24
	private static readonly int STATIC_TREES; // 0x28
	private static readonly int DYN_TREES; // 0x2C
	private static readonly int Z_BINARY; // 0x30
	private static readonly int Z_ASCII; // 0x34
	private static readonly int Z_UNKNOWN; // 0x38
	private static readonly int Buf_size; // 0x3C
	private static readonly int MIN_MATCH; // 0x40
	private static readonly int MAX_MATCH; // 0x44
	private static readonly int MIN_LOOKAHEAD; // 0x48
	private static readonly int HEAP_SIZE; // 0x4C
	private static readonly int END_BLOCK; // 0x50
	internal ZlibCodec _codec; // 0x18
	internal int status; // 0x20
	internal byte[] pending; // 0x28
	internal int nextPending; // 0x30
	internal int pendingCount; // 0x34
	internal sbyte data_type; // 0x38
	internal int last_flush; // 0x3C
	internal int w_size; // 0x40
	internal int w_bits; // 0x44
	internal int w_mask; // 0x48
	internal byte[] window; // 0x50
	internal int window_size; // 0x58
	internal short[] prev; // 0x60
	internal short[] head; // 0x68
	internal int ins_h; // 0x70
	internal int hash_size; // 0x74
	internal int hash_bits; // 0x78
	internal int hash_mask; // 0x7C
	internal int hash_shift; // 0x80
	internal int block_start; // 0x84
	private DeflateManager.Config config; // 0x88
	internal int match_length; // 0x90
	internal int prev_match; // 0x94
	internal int match_available; // 0x98
	internal int strstart; // 0x9C
	internal int match_start; // 0xA0
	internal int lookahead; // 0xA4
	internal int prev_length; // 0xA8
	internal CompressionLevel compressionLevel; // 0xAC
	internal CompressionStrategy compressionStrategy; // 0xB0
	internal short[] dyn_ltree; // 0xB8
	internal short[] dyn_dtree; // 0xC0
	internal short[] bl_tree; // 0xC8
	internal Tree treeLiterals; // 0xD0
	internal Tree treeDistances; // 0xD8
	internal Tree treeBitLengths; // 0xE0
	internal short[] bl_count; // 0xE8
	internal int[] heap; // 0xF0
	internal int heap_len; // 0xF8
	internal int heap_max; // 0xFC
	internal sbyte[] depth; // 0x100
	internal int _lengthOffset; // 0x108
	internal int lit_bufsize; // 0x10C
	internal int last_lit; // 0x110
	internal int _distanceOffset; // 0x114
	internal int opt_len; // 0x118
	internal int static_len; // 0x11C
	internal int matches; // 0x120
	internal int last_eob_len; // 0x124
	internal short bi_buf; // 0x128
	internal int bi_valid; // 0x12C
	private bool Rfc1950BytesEmitted; // 0x130
	private bool _WantRfc1950HeaderBytes; // 0x131

	// Properties
	internal bool WantRfc1950HeaderBytes { get; set; }

	// Methods

	// RVA: 0x21C58E0 Offset: 0x21C4CE0 VA: 0x1821C58E0
	internal void .ctor() { }

	// RVA: 0x21C4E80 Offset: 0x21C4280 VA: 0x1821C4E80
	private void _InitializeLazyMatch() { }

	// RVA: 0x21C5090 Offset: 0x21C4490 VA: 0x1821C5090
	private void _InitializeTreeData() { }

	// RVA: 0x21C4C60 Offset: 0x21C4060 VA: 0x1821C4C60
	internal void _InitializeBlocks() { }

	// RVA: 0x21C7780 Offset: 0x21C6B80 VA: 0x1821C7780
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x21C5200 Offset: 0x21C4600 VA: 0x1821C5200
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x21C7A20 Offset: 0x21C6E20 VA: 0x1821C7A20
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x21C6D80 Offset: 0x21C6180 VA: 0x1821C6D80
	internal int build_bl_tree() { }

	// RVA: 0x21C7D60 Offset: 0x21C7160 VA: 0x1821C7D60
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x21C8610 Offset: 0x21C7A10 VA: 0x1821C8610
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x21C79D0 Offset: 0x21C6DD0 VA: 0x1821C79D0
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x21C8080 Offset: 0x21C7480 VA: 0x1821C8080
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x21C7EE0 Offset: 0x21C72E0 VA: 0x1821C7EE0
	internal void send_bits(int value, int length) { }

	// RVA: 0x21C5EE0 Offset: 0x21C52E0 VA: 0x1821C5EE0
	internal void _tr_align() { }

	// RVA: 0x21C67D0 Offset: 0x21C5BD0 VA: 0x1821C67D0
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x21C80F0 Offset: 0x21C74F0 VA: 0x1821C80F0
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x21C8A90 Offset: 0x21C7E90 VA: 0x1821C8A90
	internal void set_data_type() { }

	// RVA: 0x21C6B80 Offset: 0x21C5F80 VA: 0x1821C6B80
	internal void bi_flush() { }

	// RVA: 0x21C6C80 Offset: 0x21C6080 VA: 0x1821C6C80
	internal void bi_windup() { }

	// RVA: 0x21C6F10 Offset: 0x21C6310 VA: 0x1821C6F10
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x21C7070 Offset: 0x21C6470 VA: 0x1821C7070
	internal void flush_block_only(bool eof) { }

	// RVA: 0x21C31E0 Offset: 0x21C25E0 VA: 0x1821C31E0
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x21C6610 Offset: 0x21C5A10 VA: 0x1821C6610
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21C6110 Offset: 0x21C5510 VA: 0x1821C6110
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21C5B20 Offset: 0x21C4F20 VA: 0x1821C5B20
	private void _fillWindow() { }

	// RVA: 0x21C2B30 Offset: 0x21C1F30 VA: 0x1821C2B30
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x21C3410 Offset: 0x21C2810 VA: 0x1821C3410
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x21C70E0 Offset: 0x21C64E0 VA: 0x1821C70E0
	internal int longest_match(int cur_match) { }

	// RVA: 0x21C70D0 Offset: 0x21C64D0 VA: 0x1821C70D0
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x21C8A80 Offset: 0x21C7E80 VA: 0x1821C8A80
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x21C4850 Offset: 0x21C3C50 VA: 0x1821C4850
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x21C4570 Offset: 0x21C3970 VA: 0x1821C4570
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x21C4900 Offset: 0x21C3D00 VA: 0x1821C4900
	internal void Reset() { }

	// RVA: 0x21C4B90 Offset: 0x21C3F90 VA: 0x1821C4B90
	private void SetDeflater() { }

	// RVA: 0x21C3C10 Offset: 0x21C3010 VA: 0x1821C3C10
	internal int Deflate(FlushType flush) { }

	// RVA: 0x21C52C0 Offset: 0x21C46C0 VA: 0x1821C52C0
	private static void .cctor() { }

}

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6943
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19F5610 Offset: 0x19F4A10 VA: 0x1819F5610 Slot: 12
	public virtual BlockState Invoke(FlushType flush) { }

	// RVA: 0x21C23E0 Offset: 0x21C17E0 VA: 0x1821C23E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual BlockState EndInvoke(IAsyncResult result) { }

}

internal class DeflateManager.Config // TypeDefIndex: 6944
{	// Fields
	internal int GoodLength; // 0x10
	internal int MaxLazy; // 0x14
	internal int NiceLength; // 0x18
	internal int MaxChainLength; // 0x1C
	internal DeflateFlavor Flavor; // 0x20
	private static readonly DeflateManager.Config[] Table; // 0x0

	// Methods

	// RVA: 0x21C2AD0 Offset: 0x21C1ED0 VA: 0x1821C2AD0
	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	// RVA: 0x21C2460 Offset: 0x21C1860 VA: 0x1821C2460
	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	// RVA: 0x21C24F0 Offset: 0x21C18F0 VA: 0x1821C24F0
	private static void .cctor() { }

}

