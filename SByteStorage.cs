internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4410
{
	private sbyte[] _values; 


	public void .ctor(DataColumn column) { }

	public override object Aggregate(int[] records, AggregateType kind) { }

	public override int Compare(int recordNo1, int recordNo2) { }

	public override int CompareValueTo(int recordNo, object value) { }

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

