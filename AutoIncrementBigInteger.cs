internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 4187
{
	private BigInteger _current; 
	private long _seed; 
	private BigInteger _step; 

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

