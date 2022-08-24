public sealed class MetricTimeSpan : ITimeSpan, IComparable, IComparable<MetricTimeSpan>, IEquatable<MetricTimeSpan> // TypeDefIndex: 7492
{
	private readonly TimeSpan _timeSpan; 

public long TotalMicroseconds { get; }
public int Hours { get; }
public int Minutes { get; }
public int Seconds { get; }
public int Milliseconds { get; }


public void .ctor() { }

public void .ctor(long totalMicroseconds) { }

public void .ctor(TimeSpan timeSpan) { }

public void .ctor(int hours, int minutes, int seconds, int milliseconds) { }

public long get_TotalMicroseconds() { }

public int get_Hours() { }

public int get_Minutes() { }

public int get_Seconds() { }

public int get_Milliseconds() { }

public static TimeSpan op_Implicit(MetricTimeSpan timeSpan) { }

public static bool op_Equality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

public static bool op_Inequality(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

public static MetricTimeSpan op_Addition(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

public static MetricTimeSpan op_Subtraction(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

public static bool op_LessThan(MetricTimeSpan timeSpan1, MetricTimeSpan timeSpan2) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

public ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode) { }

public ITimeSpan Clone() { }

public int CompareTo(object other) { }

public int CompareTo(MetricTimeSpan other) { }

public bool Equals(MetricTimeSpan other) { }

}

