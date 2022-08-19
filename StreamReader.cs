public class StreamReader : TextReader // TypeDefIndex: 646
{	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x162B1D0 Offset: 0x162A5D0 VA: 0x18162B1D0
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x1629700 Offset: 0x1628B00 VA: 0x181629700
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x162B170 Offset: 0x162A570 VA: 0x18162B170
	internal void .ctor() { }

	// RVA: 0x162AB80 Offset: 0x1629F80 VA: 0x18162AB80
	public void .ctor(Stream stream) { }

	// RVA: 0x162AC10 Offset: 0x162A010 VA: 0x18162AC10
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x162AED0 Offset: 0x162A2D0 VA: 0x18162AED0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x162ACB0 Offset: 0x162A0B0 VA: 0x18162ACB0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x162AE40 Offset: 0x162A240 VA: 0x18162AE40
	public void .ctor(string path) { }

	// RVA: 0x162AA20 Offset: 0x1629E20 VA: 0x18162AA20
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x162AAF0 Offset: 0x1629EF0 VA: 0x18162AAF0
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x162AAC0 Offset: 0x1629EC0 VA: 0x18162AAC0
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x162AF60 Offset: 0x162A360 VA: 0x18162AF60
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x1629C70 Offset: 0x1629070 VA: 0x181629C70
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1629DC0 Offset: 0x16291C0 VA: 0x181629DC0
	internal void Init(Stream stream) { }

	// RVA: 0x1629790 Offset: 0x1628B90 VA: 0x181629790 Slot: 7
	public override void Close() { }

	// RVA: 0x1629B60 Offset: 0x1628F60 VA: 0x181629B60 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x162B1E0 Offset: 0x162A5E0 VA: 0x18162B1E0
	internal bool get_LeaveOpen() { }

	// RVA: 0x1629EE0 Offset: 0x16292E0 VA: 0x181629EE0 Slot: 9
	public override int Peek() { }

	// RVA: 0x16297F0 Offset: 0x1628BF0 VA: 0x1816297F0
	internal bool DataAvailable() { }

	// RVA: 0x162A660 Offset: 0x1629A60 VA: 0x18162A660 Slot: 10
	public override int Read() { }

	// RVA: 0x162A6F0 Offset: 0x1629AF0 VA: 0x18162A6F0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x162A580 Offset: 0x1629980 VA: 0x18162A580 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x16297B0 Offset: 0x1628BB0 VA: 0x1816297B0
	private void CompressBuffer(int n) { }

	// RVA: 0x1629800 Offset: 0x1628C00 VA: 0x181629800
	private void DetectEncoding() { }

	// RVA: 0x1629DE0 Offset: 0x16291E0 VA: 0x181629DE0
	private bool IsPreamble() { }

	// RVA: 0x162A1C0 Offset: 0x16295C0 VA: 0x18162A1C0 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x1629F70 Offset: 0x1629370 VA: 0x181629F70
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x162A370 Offset: 0x1629770 VA: 0x18162A370 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x162A910 Offset: 0x1629D10 VA: 0x18162A910
	private static void .cctor() { }

}

private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 647
{	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x1623CB0 Offset: 0x16230B0 VA: 0x181623CB0
	internal void .ctor() { }

	// RVA: 0x1623D80 Offset: 0x1623180 VA: 0x181623D80 Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x1623DE0 Offset: 0x16231E0 VA: 0x181623DE0 Slot: 14
	public override Encoding get_CurrentEncoding() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 9
	public override int Peek() { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 10
	public override int Read() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1623C70 Offset: 0x1623070 VA: 0x181623C70 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 16
	internal override int ReadBuffer() { }

}

