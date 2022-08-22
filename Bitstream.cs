public sealed class Bitstream // TypeDefIndex: 7384
{	private const int BUFFER_INT_SIZE = 433;
	internal const sbyte INITIAL_SYNC = 0;
	internal const sbyte STRICT_SYNC = 1;
	private readonly int[] _Bitmask; // 0x10
	private readonly PushbackStream _SourceStream; // 0x18
	private int _BitIndex; // 0x20
	private Crc16[] _CRC; // 0x28
	private sbyte[] _FrameBytes; // 0x30
	private int[] _FrameBuffer; // 0x38
	private int _FrameSize; // 0x40
	private Header _Header; // 0x48
	private bool _SingleChMode; // 0x50
	private sbyte[] _SyncBuffer; // 0x58
	private int _SyncWord; // 0x60
	private int _WordPointer; // 0x64


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

