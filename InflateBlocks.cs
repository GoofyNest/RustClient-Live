internal sealed class InflateBlocks // TypeDefIndex: 6979
{
	internal static readonly int[] border; 
	private InflateBlocks.InflateBlockMode mode; 
	internal int left; 
	internal int table; 
	internal int index; 
	internal int[] blens; 
	internal int[] bb; 
	internal int[] tb; 
	internal InflateCodes codes; 
	internal int last; 
	internal ZlibCodec _codec; 
	internal int bitk; 
	internal int bitb; 
	internal int[] hufts; 
	internal byte[] window; 
	internal int end; 
	internal int readAt; 
	internal int writeAt; 
	internal object checkfn; 
	internal uint check; 
	internal InfTree inftree; 


	internal void .ctor(ZlibCodec codec, object checkfn, int w) { }

	internal uint Reset() { }

	internal int Process(int r) { }

	internal void Free() { }

	internal int Flush(int r) { }

	private static void .cctor() { }

}

private enum InflateBlocks.InflateBlockMode // TypeDefIndex: 6980
{
	public int value__; 
	public const InflateBlocks.InflateBlockMode TYPE = 0;
	public const InflateBlocks.InflateBlockMode LENS = 1;
	public const InflateBlocks.InflateBlockMode STORED = 2;
	public const InflateBlocks.InflateBlockMode TABLE = 3;
	public const InflateBlocks.InflateBlockMode BTREE = 4;
	public const InflateBlocks.InflateBlockMode DTREE = 5;
	public const InflateBlocks.InflateBlockMode CODES = 6;
	public const InflateBlocks.InflateBlockMode DRY = 7;
	public const InflateBlocks.InflateBlockMode DONE = 8;
	public const InflateBlocks.InflateBlockMode BAD = 9;

}

