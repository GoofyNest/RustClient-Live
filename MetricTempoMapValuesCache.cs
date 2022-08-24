internal sealed class MetricTempoMapValuesCache : ITempoMapValuesCache // TypeDefIndex: 7495
{
	[CompilerGeneratedAttribute] 
	private MetricTempoMapValuesCache.AccumulatedMicroseconds[] <Microseconds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private double <DefaultMicrosecondsPerTick>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private double <DefaultTicksPerMicrosecond>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly IEnumerable<TempoMapLine> <InvalidateOnLines>k__BackingField; 

public MetricTempoMapValuesCache.AccumulatedMicroseconds[] Microseconds { get; set; }
public double DefaultMicrosecondsPerTick { get; set; }
public double DefaultTicksPerMicrosecond { get; set; }
public IEnumerable<TempoMapLine> InvalidateOnLines { get; }


	[CompilerGeneratedAttribute] 
public MetricTempoMapValuesCache.AccumulatedMicroseconds[] get_Microseconds() { }

	[CompilerGeneratedAttribute] 
private void set_Microseconds(MetricTempoMapValuesCache.AccumulatedMicroseconds[] value) { }

	[CompilerGeneratedAttribute] 
public double get_DefaultMicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] 
private void set_DefaultMicrosecondsPerTick(double value) { }

	[CompilerGeneratedAttribute] 
public double get_DefaultTicksPerMicrosecond() { }

	[CompilerGeneratedAttribute] 
private void set_DefaultTicksPerMicrosecond(double value) { }

private static double GetMicroseconds(long time, Tempo tempo, short ticksPerQuarterNote) { }

	[CompilerGeneratedAttribute] 
public IEnumerable<TempoMapLine> get_InvalidateOnLines() { }

public void Invalidate(TempoMap tempoMap) { }

public void .ctor() { }

}

internal sealed class MetricTempoMapValuesCache.AccumulatedMicroseconds // TypeDefIndex: 7496
{
	[CompilerGeneratedAttribute] 
	private readonly long <Time>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly double <Microseconds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly double <MicrosecondsPerTick>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly double <TicksPerMicrosecond>k__BackingField; 

public long Time { get; }
public double Microseconds { get; }
public double MicrosecondsPerTick { get; }
public double TicksPerMicrosecond { get; }


public void .ctor(long time, double microseconds, double microsecondsPerTick) { }

	[CompilerGeneratedAttribute] 
public long get_Time() { }

	[CompilerGeneratedAttribute] 
public double get_Microseconds() { }

	[CompilerGeneratedAttribute] 
public double get_MicrosecondsPerTick() { }

	[CompilerGeneratedAttribute] 
public double get_TicksPerMicrosecond() { }

}

