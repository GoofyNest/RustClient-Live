internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4368
{
	private BigInteger[] _values; 


	internal void .ctor(DataColumn column) { }

	public override object Aggregate(int[] records, AggregateType kind) { }

	public override int Compare(int recordNo1, int recordNo2) { }

	public override int CompareValueTo(int recordNo, object value) { }

	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	public override object ConvertValue(object value) { }

	public override void Copy(int recordNo1, int recordNo2) { }

	public override object Get(int record) { }

	public override void Set(int record, object value) { }

	public override void SetCapacity(int capacity) { }

	public override object ConvertXmlToObject(string s) { }

	public override string ConvertObjectToXml(object value) { }

	protected override object GetEmptyStorage(int recordCount) { }

	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	protected override void SetStorage(object store, BitArray nullbits) { }

}

