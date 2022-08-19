public class StreamWriter : TextWriter // TypeDefIndex: 648
{	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x162B1F0 Offset: 0x162A5F0 VA: 0x18162B1F0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x162C420 Offset: 0x162B820 VA: 0x18162C420
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x162BD90 Offset: 0x162B190 VA: 0x18162BD90
	internal void .ctor() { }

	// RVA: 0x162C140 Offset: 0x162B540 VA: 0x18162C140
	public void .ctor(Stream stream) { }

	// RVA: 0x162C3E0 Offset: 0x162B7E0 VA: 0x18162C3E0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x162C250 Offset: 0x162B650 VA: 0x18162C250
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x162C1C0 Offset: 0x162B5C0 VA: 0x18162C1C0
	public void .ctor(string path) { }

	// RVA: 0x162BE20 Offset: 0x162B220 VA: 0x18162BE20
	public void .ctor(string path, bool append) { }

	// RVA: 0x162BDF0 Offset: 0x162B1F0 VA: 0x18162BDF0
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x162BD60 Offset: 0x162B160 VA: 0x18162BD60
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x162BEC0 Offset: 0x162B2C0 VA: 0x18162BEC0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x162B6F0 Offset: 0x162AAF0 VA: 0x18162B6F0
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x162B2F0 Offset: 0x162A6F0 VA: 0x18162B2F0
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x162B280 Offset: 0x162A680 VA: 0x18162B280 Slot: 8
	public override void Close() { }

	// RVA: 0x162B3B0 Offset: 0x162A7B0 VA: 0x18162B3B0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x162B540 Offset: 0x162A940 VA: 0x18162B540 Slot: 10
	public override void Flush() { }

	// RVA: 0x162B570 Offset: 0x162A970 VA: 0x18162B570
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x162C530 Offset: 0x162B930 VA: 0x18162C530 Slot: 23
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 24
	public virtual Stream get_BaseStream() { }

	// RVA: 0x162C410 Offset: 0x162B810 VA: 0x18162C410
	internal bool get_LeaveOpen() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x162BC00 Offset: 0x162B000 VA: 0x18162BC00 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x162B850 Offset: 0x162AC50 VA: 0x18162B850 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x162B920 Offset: 0x162AD20 VA: 0x18162B920 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x162BB30 Offset: 0x162AF30 VA: 0x18162BB30 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x162BC80 Offset: 0x162B080 VA: 0x18162BC80
	private static void .cctor() { }

}

