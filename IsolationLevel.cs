public enum IsolationLevel // TypeDefIndex: 3984
{

public enum IsolationLevel
	public int value__; 
	public const IsolationLevel Serializable = 0;
	public const IsolationLevel RepeatableRead = 1;
	public const IsolationLevel ReadCommitted = 2;
	public const IsolationLevel ReadUncommitted = 3;
	public const IsolationLevel Snapshot = 4;
	public const IsolationLevel Chaos = 5;
	public const IsolationLevel Unspecified = 6;

}

public enum IsolationLevel // TypeDefIndex: 4276
{
	public int value__; 
	public const IsolationLevel Unspecified = -1;
	public const IsolationLevel Chaos = 16;
	public const IsolationLevel ReadUncommitted = 256;
	public const IsolationLevel ReadCommitted = 4096;
	public const IsolationLevel RepeatableRead = 65536;
	public const IsolationLevel Serializable = 1048576;
	public const IsolationLevel Snapshot = 16777216;

}

