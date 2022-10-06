internal struct StatThresholdsInternal : IGettable<StatThresholds>, ISettable<StatThresholds>, IDisposable // TypeDefIndex: 9938
{
	private int m_ApiVersion; 
	private IntPtr m_Name; 
	private int m_Threshold; 

	public Utf8String Name { get; set; }
	public int Threshold { get; set; }


	public Utf8String get_Name() { }

	public void set_Name(Utf8String value) { }

	public int get_Threshold() { }

	public void set_Threshold(int value) { }

	public void Set(ref StatThresholds other) { }

	public void Set(ref Nullable<StatThresholds> other) { }

	public void Dispose() { }

	public void Get(out StatThresholds output) { }

}

