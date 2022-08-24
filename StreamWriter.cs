public class StreamWriter : TextWriter // TypeDefIndex: 648
{
	public static readonly StreamWriter Null; 
	private Stream stream; 
	private Encoding encoding; 
	private Encoder encoder; 
	private byte[] byteBuffer; 
	private char[] charBuffer; 
	private int charPos; 
	private int charLen; 
	private bool autoFlush; 
	private bool haveWrittenPreamble; 
	private bool closable; 
	private Task _asyncWriteTask; 
	private static Encoding _UTF8NoBOM; 

internal static Encoding UTF8NoBOM { get; }
public virtual bool AutoFlush { set; }
public virtual Stream BaseStream { get; }
internal bool LeaveOpen { get; }
public override Encoding Encoding { get; }


private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] 
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

