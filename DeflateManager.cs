internal sealed class DeflateManager // TypeDefIndex: 6984
{
	private static readonly int MEM_LEVEL_MAX;
	private static readonly int MEM_LEVEL_DEFAULT;
	private DeflateManager.CompressFunc DeflateFunction;
	private static readonly string[] _ErrorMessage;
	private static readonly int PRESET_DICT;
	private static readonly int INIT_STATE;
	private static readonly int BUSY_STATE;
	private static readonly int FINISH_STATE;
	private static readonly int Z_DEFLATED;
	private static readonly int STORED_BLOCK;
	private static readonly int STATIC_TREES;
	private static readonly int DYN_TREES;
	private static readonly int Z_BINARY;
	private static readonly int Z_ASCII;
	private static readonly int Z_UNKNOWN;
	private static readonly int Buf_size;
	private static readonly int MIN_MATCH;
	private static readonly int MAX_MATCH;
	private static readonly int MIN_LOOKAHEAD;
	private static readonly int HEAP_SIZE;
	private static readonly int END_BLOCK;
	internal ZlibCodec _codec;
	internal int status;
	internal byte[] pending;
	internal int nextPending;
	internal int pendingCount;
	internal sbyte data_type;
	internal int last_flush;
	internal int w_size;
	internal int w_bits;
	internal int w_mask;
	internal byte[] window;
	internal int window_size;
	internal short[] prev;
	internal short[] head;
	internal int ins_h;
	internal int hash_size;
	internal int hash_bits;
	internal int hash_mask;
	internal int hash_shift;
	internal int block_start;
	private DeflateManager.Config config;
	internal int match_length;
	internal int prev_match;
	internal int match_available;
	internal int strstart;
	internal int match_start;
	internal int lookahead;
	internal int prev_length;
	internal CompressionLevel compressionLevel;
	internal CompressionStrategy compressionStrategy;
	internal short[] dyn_ltree;
	internal short[] dyn_dtree;
	internal short[] bl_tree;
	internal Tree treeLiterals;
	internal Tree treeDistances;
	internal Tree treeBitLengths;
	internal short[] bl_count;
	internal int[] heap;
	internal int heap_len;
	internal int heap_max;
	internal sbyte[] depth;
	internal int _lengthOffset;
	internal int lit_bufsize;
	internal int last_lit;
	internal int _distanceOffset;
	internal int opt_len;
	internal int static_len;
	internal int matches;
	internal int last_eob_len;
	internal short bi_buf;
	internal int bi_valid;
	private bool Rfc1950BytesEmitted;
	private bool _WantRfc1950HeaderBytes;

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

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6985
{

	public void .ctor(object object, IntPtr method) { }

	public virtual BlockState Invoke(FlushType flush) { }

	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	public virtual BlockState EndInvoke(IAsyncResult result) { }

}

internal class DeflateManager.Config // TypeDefIndex: 6986
{
	internal int GoodLength;
	internal int MaxLazy;
	internal int NiceLength;
	internal int MaxChainLength;
	internal DeflateFlavor Flavor;
	private static readonly DeflateManager.Config[] Table;


	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	private static void .cctor() { }

}

