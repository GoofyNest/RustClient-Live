public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 5768
{
	private string unit; 
	[CompilerGeneratedAttribute] 
	private Nullable<long> <From>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<long> <Length>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<long> <To>k__BackingField; 

	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }


	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	public Nullable<long> get_From() { }

	[CompilerGeneratedAttribute] 
	private void set_From(Nullable<long> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<long> get_Length() { }

	[CompilerGeneratedAttribute] 
	private void set_Length(Nullable<long> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<long> get_To() { }

	[CompilerGeneratedAttribute] 
	private void set_To(Nullable<long> value) { }

	public string get_Unit() { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	public override string ToString() { }

}

