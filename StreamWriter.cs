public class StreamWriter : TextWriter // TypeDefIndex: 648
{	public static readonly StreamWriter Null; // 0x0
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

	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }


	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static Encoding get_UTF8NoBOM() { }

	internal void .ctor() { }

	public void .ctor(Stream stream) { }

	public void .ctor(Stream stream, Encoding encoding) { }

	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	public void .ctor(string path) { }

	public void .ctor(string path, bool append) { }

	public void .ctor(string path, bool append, Encoding encoding) { }

	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	private void Flush(bool flushStream, bool flushEncoder) { }

	public virtual void set_AutoFlush(bool value) { }

	public virtual Stream get_BaseStream() { }

	internal bool get_LeaveOpen() { }

	public override Encoding get_Encoding() { }

	public override void Write(char value) { }

	public override void Write(char[] buffer) { }

	public override void Write(char[] buffer, int index, int count) { }

	public override void Write(string value) { }

	private static void .cctor() { }

}

