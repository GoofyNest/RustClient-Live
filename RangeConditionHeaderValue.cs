public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5808
{
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <Date>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EntityTagHeaderValue <EntityTag>k__BackingField; 

	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }


	public void .ctor(DateTimeOffset date) { }

	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] 
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] 
	private void set_EntityTag(EntityTagHeaderValue value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	public override string ToString() { }

}

