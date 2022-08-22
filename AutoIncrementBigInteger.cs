internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 4184
{	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

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

