public sealed class Bitstream // TypeDefIndex: 7384
{	// Fields
	private const int BUFFER_INT_SIZE = 433;
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

	// Methods

	// RVA: 0x5F5400 Offset: 0x5F4800 VA: 0x1805F5400
	internal void .ctor(PushbackStream stream) { }

	// RVA: 0x5F4800 Offset: 0x5F3C00 VA: 0x1805F4800
	private void InitBlock() { }

	// RVA: 0x5F45C0 Offset: 0x5F39C0 VA: 0x1805F45C0
	internal void Close() { }

	// RVA: 0x5F4F20 Offset: 0x5F4320 VA: 0x1805F4F20
	internal Header ReadFrame() { }

	// RVA: 0x5F5100 Offset: 0x5F4500 VA: 0x1805F5100
	private Header ReadNextFrame() { }

	// RVA: 0x5F5360 Offset: 0x5F4760 VA: 0x1805F5360
	internal void UnreadFrame() { }

	// RVA: 0x5F45A0 Offset: 0x5F39A0 VA: 0x1805F45A0
	internal void CloseFrame() { }

	// RVA: 0x5F48F0 Offset: 0x5F3CF0 VA: 0x1805F48F0
	internal bool IsSyncCurrentPosition(int syncmode) { }

	// RVA: 0x5F4BD0 Offset: 0x5F3FD0 VA: 0x1805F4BD0
	internal BitstreamException NewBitstreamException(int errorcode) { }

	// RVA: 0x5F4C30 Offset: 0x5F4030 VA: 0x1805F4C30
	internal BitstreamException NewBitstreamException(int errorcode, Exception throwable) { }

	// RVA: 0x5F51B0 Offset: 0x5F45B0 VA: 0x1805F51B0
	internal int SyncHeader(sbyte syncmode) { }

	// RVA: 0x5F4AB0 Offset: 0x5F3EB0 VA: 0x1805F4AB0
	internal bool IsSyncMark(int headerstring, int syncmode, int word) { }

	// RVA: 0x5F5140 Offset: 0x5F4540 VA: 0x1805F5140
	internal void Read_frame_data(int bytesize) { }

	// RVA: 0x5F4CA0 Offset: 0x5F40A0 VA: 0x1805F4CA0
	internal void ParseFrame() { }

	// RVA: 0x5F4650 Offset: 0x5F3A50 VA: 0x1805F4650
	internal int GetBitsFromBuffer(int countBits) { }

	// RVA: 0x5F5190 Offset: 0x5F4590 VA: 0x1805F5190
	internal void SetSyncWord(int syncword0) { }

	// RVA: 0x5F5000 Offset: 0x5F4400 VA: 0x1805F5000
	private void ReadFully(sbyte[] b, int offs, int len) { }

	// RVA: 0x5F4E50 Offset: 0x5F4250 VA: 0x1805F4E50
	private int ReadBytes(sbyte[] b, int offs, int len) { }

}

