public enum ReadState // TypeDefIndex: 1865
{
	public int value__; 
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;

}

internal enum ReadState // TypeDefIndex: 3026
{
	public int value__; 
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;

}

