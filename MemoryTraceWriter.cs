public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5978
{	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TraceLevel <LevelFilter>k__BackingField; // 0x18

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x1805480 Offset: 0x1804880 VA: 0x181805480
	public void .ctor() { }

	// RVA: 0x18052D0 Offset: 0x18046D0 VA: 0x1818052D0 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x1805150 Offset: 0x1804550 VA: 0x181805150 Slot: 3
	public override string ToString() { }

}

