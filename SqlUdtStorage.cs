internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4430
{
	private object[] _values; 
	private readonly bool _implementsIXmlSerializable; 
	private readonly bool _implementsIComparable; 
	private static readonly Dictionary<Type, object> s_typeToNull; 


public void .ctor(DataColumn column, Type type) { }

private void .ctor(DataColumn column, Type type, object nullValue) { }

internal static object GetStaticNullForUdtType(Type type) { }

public override bool IsNull(int record) { }

public override object Aggregate(int[] records, AggregateType kind) { }

public override int Compare(int recordNo1, int recordNo2) { }

public override int CompareValueTo(int recordNo1, object value) { }

public override void Copy(int recordNo1, int recordNo2) { }

public override object Get(int recordNo) { }

public override void Set(int recordNo, object value) { }

public override void SetCapacity(int capacity) { }

public override object ConvertXmlToObject(string s) { }

public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

public override string ConvertObjectToXml(object value) { }

public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

protected override object GetEmptyStorage(int recordCount) { }

protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

protected override void SetStorage(object store, BitArray nullbits) { }

private static void .cctor() { }

}

