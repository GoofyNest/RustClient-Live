public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 5811
{
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <Date>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TimeSpan> <Delta>k__BackingField; 

	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }


	public void .ctor(DateTimeOffset date) { }

	public void .ctor(TimeSpan delta) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] 
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGeneratedAttribute] 
	private void set_Delta(Nullable<TimeSpan> value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	public override string ToString() { }

}

