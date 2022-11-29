internal abstract class AutoIncrementValue // TypeDefIndex: 4187
{
	[CompilerGeneratedAttribute] 
	private bool <Auto>k__BackingField; 

	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }


	[CompilerGeneratedAttribute] 
	internal bool get_Auto() { }

	[CompilerGeneratedAttribute] 
	internal void set_Auto(bool value) { }

	internal abstract object get_Current();

	internal abstract void set_Current(object value);

	internal abstract long get_Seed();

	internal abstract void set_Seed(long value);

	internal abstract long get_Step();

	internal abstract void set_Step(long value);

	internal abstract Type get_DataType();

	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	internal abstract void SetCurrentAndIncrement(object value);

	internal abstract void MoveAfter();

	internal AutoIncrementValue Clone() { }

	protected void .ctor() { }

}

