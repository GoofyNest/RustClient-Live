internal sealed class DeflateManager // TypeDefIndex: 6942
{	private static readonly int MEM_LEVEL_MAX; // 0x0
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

	internal bool WantRfc1950HeaderBytes { get; set; }


	internal void .ctor() { }

	private void _InitializeLazyMatch() { }

	private void _InitializeTreeData() { }

	internal void _InitializeBlocks() { }

	internal void pqdownheap(short[] tree, int k) { }

	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	internal void scan_tree(short[] tree, int max_code) { }

	internal int build_bl_tree() { }

	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	internal void send_tree(short[] tree, int max_code) { }

	private void put_bytes(byte[] p, int start, int len) { }

	internal void send_code(int c, short[] tree) { }

	internal void send_bits(int value, int length) { }

	internal void _tr_align() { }

	internal bool _tr_tally(int dist, int lc) { }

	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	internal void set_data_type() { }

	internal void bi_flush() { }

	internal void bi_windup() { }

	internal void copy_block(int buf, int len, bool header) { }

	internal void flush_block_only(bool eof) { }

	internal BlockState DeflateNone(FlushType flush) { }

	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	private void _fillWindow() { }

	internal BlockState DeflateFast(FlushType flush) { }

	internal BlockState DeflateSlow(FlushType flush) { }

	internal int longest_match(int cur_match) { }

	internal bool get_WantRfc1950HeaderBytes() { }

	internal void set_WantRfc1950HeaderBytes(bool value) { }

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	internal void Reset() { }

	private void SetDeflater() { }

	internal int Deflate(FlushType flush) { }

	private static void .cctor() { }

}

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6943
{
	public void .ctor(object object, IntPtr method) { }

	public virtual BlockState Invoke(FlushType flush) { }

	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	public virtual BlockState EndInvoke(IAsyncResult result) { }

}

internal class DeflateManager.Config // TypeDefIndex: 6944
{	internal int GoodLength; // 0x10
	internal int MaxLazy; // 0x14
	internal int NiceLength; // 0x18
	internal int MaxChainLength; // 0x1C
	internal DeflateFlavor Flavor; // 0x20
	private static readonly DeflateManager.Config[] Table; // 0x0


	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	private static void .cctor() { }

}

