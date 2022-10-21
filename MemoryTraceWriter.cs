public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5983
{
	private readonly Queue<string> _traceMessages; 
	[CompilerGeneratedAttribute] 
	private TraceLevel <LevelFilter>k__BackingField; 

	public TraceLevel LevelFilter { get; set; }


	[CompilerGeneratedAttribute] 
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_LevelFilter(TraceLevel value) { }

	public void .ctor() { }

	public void Trace(TraceLevel level, string message, Exception ex) { }

	public override string ToString() { }

}

