internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 4183
{
	private long _current; 
	private long _seed; 
	private long _step; 

	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }


	internal override object get_Current() { }

	internal override void set_Current(object value) { }

	internal override Type get_DataType() { }

	internal override long get_Seed() { }

	internal override void set_Seed(long value) { }

	internal override long get_Step() { }

	internal override void set_Step(long value) { }

	internal override void MoveAfter() { }

	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	internal override void SetCurrentAndIncrement(object value) { }

	private bool BoundaryCheck(BigInteger value) { }

	public void .ctor() { }

}

