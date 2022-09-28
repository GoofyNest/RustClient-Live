internal struct StatInternal : IGettable<Stat>, ISettable<Stat>, IDisposable // TypeDefIndex: 8403
{
	private int m_ApiVersion; 
	private IntPtr m_Name; 
	private long m_StartTime; 
	private long m_EndTime; 
	private int m_Value; 

	public Utf8String Name { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }
	public int Value { get; set; }


	public Utf8String get_Name() { }

	public void set_Name(Utf8String value) { }

	public Nullable<DateTimeOffset> get_StartTime() { }

	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	public Nullable<DateTimeOffset> get_EndTime() { }

	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	public int get_Value() { }

	public void set_Value(int value) { }

	public void Set(ref Stat other) { }

	public void Set(ref Nullable<Stat> other) { }

	public void Dispose() { }

	public void Get(out Stat output) { }

}

