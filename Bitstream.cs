public sealed class Bitstream // TypeDefIndex: 7385
{
	private const int BUFFER_INT_SIZE = 433;
	internal const sbyte INITIAL_SYNC = 0;
	internal const sbyte STRICT_SYNC = 1;
	private readonly int[] _Bitmask; 
	private readonly PushbackStream _SourceStream; 
	private int _BitIndex; 
	private Crc16[] _CRC; 
	private sbyte[] _FrameBytes; 
	private int[] _FrameBuffer; 
	private int _FrameSize; 
	private Header _Header; 
	private bool _SingleChMode; 
	private sbyte[] _SyncBuffer; 
	private int _SyncWord; 
	private int _WordPointer; 


	internal void .ctor(PushbackStream stream) { }

	private void InitBlock() { }

	internal void Close() { }

	internal Header ReadFrame() { }

	private Header ReadNextFrame() { }

	internal void UnreadFrame() { }

	internal void CloseFrame() { }

	internal bool IsSyncCurrentPosition(int syncmode) { }

	internal BitstreamException NewBitstreamException(int errorcode) { }

	internal BitstreamException NewBitstreamException(int errorcode, Exception throwable) { }

	internal int SyncHeader(sbyte syncmode) { }

	internal bool IsSyncMark(int headerstring, int syncmode, int word) { }

	internal void Read_frame_data(int bytesize) { }

	internal void ParseFrame() { }

	internal int GetBitsFromBuffer(int countBits) { }

	internal void SetSyncWord(int syncword0) { }

	private void ReadFully(sbyte[] b, int offs, int len) { }

	private int ReadBytes(sbyte[] b, int offs, int len) { }

}

