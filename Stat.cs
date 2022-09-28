public struct Stat // TypeDefIndex: 5560
{
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private SteamId <UserId>k__BackingField; 

	public string Name { get; set; }
	internal SteamId UserId { set; }


	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	internal void set_Name(string value) { }

	[CompilerGeneratedAttribute] 
	internal void set_UserId(SteamId value) { }

	public void .ctor(string name) { }

	public double GetGlobalFloat() { }

	public long GetGlobalInt() { }

}

public struct Stat // TypeDefIndex: 8402
{
	[CompilerGeneratedAttribute] 
	private Utf8String <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <EndTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Value>k__BackingField; 

	public Utf8String Name { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }
	public int Value { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGeneratedAttribute] 
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_EndTime() { }

	[CompilerGeneratedAttribute] 
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public int get_Value() { }

	[CompilerGeneratedAttribute] 
	public void set_Value(int value) { }

	internal void Set(ref StatInternal other) { }

}

