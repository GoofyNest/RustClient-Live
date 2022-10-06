internal sealed class InflateManager // TypeDefIndex: 6983
{
	private InflateManager.InflateManagerMode mode; 
	internal ZlibCodec _codec; 
	internal int method; 
	internal uint computedCheck; 
	internal uint expectedCheck; 
	internal int marker; 
	private bool _handleRfc1950HeaderBytes; 
	internal int wbits; 
	internal InflateBlocks blocks; 
	private static readonly byte[] mark; 

	internal bool HandleRfc1950HeaderBytes { get; }


	internal bool get_HandleRfc1950HeaderBytes() { }

	public void .ctor(bool expectRfc1950HeaderBytes) { }

	internal int Reset() { }

	internal int End() { }

	internal int Initialize(ZlibCodec codec, int w) { }

	internal int Inflate(FlushType flush) { }

	private static void .cctor() { }

}

private enum InflateManager.InflateManagerMode // TypeDefIndex: 6984
{
	public int value__; 
	public const InflateManager.InflateManagerMode METHOD = 0;
	public const InflateManager.InflateManagerMode FLAG = 1;
	public const InflateManager.InflateManagerMode DICT4 = 2;
	public const InflateManager.InflateManagerMode DICT3 = 3;
	public const InflateManager.InflateManagerMode DICT2 = 4;
	public const InflateManager.InflateManagerMode DICT1 = 5;
	public const InflateManager.InflateManagerMode DICT0 = 6;
	public const InflateManager.InflateManagerMode BLOCKS = 7;
	public const InflateManager.InflateManagerMode CHECK4 = 8;
	public const InflateManager.InflateManagerMode CHECK3 = 9;
	public const InflateManager.InflateManagerMode CHECK2 = 10;
	public const InflateManager.InflateManagerMode CHECK1 = 11;
	public const InflateManager.InflateManagerMode DONE = 12;
	public const InflateManager.InflateManagerMode BAD = 13;

}

