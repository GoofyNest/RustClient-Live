public struct LogMessage // TypeDefIndex: 9044
{
	[CompilerGeneratedAttribute] 
	private Utf8String <Category>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LogLevel <Level>k__BackingField; 

	public Utf8String Category { get; set; }
	public Utf8String Message { get; set; }
	public LogLevel Level { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_Category() { }

	[CompilerGeneratedAttribute] 
	public void set_Category(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Message() { }

	[CompilerGeneratedAttribute] 
	public void set_Message(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public LogLevel get_Level() { }

	[CompilerGeneratedAttribute] 
	public void set_Level(LogLevel value) { }

	internal void Set(ref LogMessageInternal other) { }

}

