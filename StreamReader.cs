public class StreamReader : TextReader // TypeDefIndex: 646
{
	public static readonly StreamReader Null;
	private Stream stream;
	private Encoding encoding;
	private Decoder decoder;
	private byte[] byteBuffer;
	private char[] charBuffer;
	private byte[] _preamble;
	private int charPos;
	private int charLen;
	private int byteLen;
	private int bytePos;
	private int _maxCharsPerBuffer;
	private bool _detectEncoding;
	private bool _checkPreamble;
	private bool _isBlocked;
	private bool _closable;
	private Task _asyncReadTask;

	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }


	internal static int get_DefaultBufferSize() { }

	private void CheckAsyncTaskInProgress() { }

	internal void .ctor() { }

	public void .ctor(Stream stream) { }

	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	public void .ctor(Stream stream, Encoding encoding) { }

	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	public void .ctor(string path) { }

	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	public void .ctor(string path, Encoding encoding) { }

	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	internal void Init(Stream stream) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public virtual Encoding get_CurrentEncoding() { }

	public virtual Stream get_BaseStream() { }

	internal bool get_LeaveOpen() { }

	public override int Peek() { }

	internal bool DataAvailable() { }

	public override int Read() { }

	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	public override string ReadToEnd() { }

	private void CompressBuffer(int n) { }

	private void DetectEncoding() { }

	private bool IsPreamble() { }

	internal virtual int ReadBuffer() { }

	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	public override string ReadLine() { }

	private static void .cctor() { }

}

private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 647
{
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }


	internal void .ctor() { }

	public override Stream get_BaseStream() { }

	public override Encoding get_CurrentEncoding() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(char[] buffer, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

	internal override int ReadBuffer() { }

}

