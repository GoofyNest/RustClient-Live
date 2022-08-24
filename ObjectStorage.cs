internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4406
{
	private static readonly object s_defaultValue; 
	private object[] _values; 
	private readonly bool _implementsIXmlSerializable; 
	private static readonly object s_tempAssemblyCacheLock; 
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; 
	private static readonly XmlSerializerFactory s_serializerFactory; 


internal void .ctor(DataColumn column, Type type) { }

public override object Aggregate(int[] records, AggregateType kind) { }

public override int Compare(int recordNo1, int recordNo2) { }

public override int CompareValueTo(int recordNo1, object value) { }

private int CompareTo(object valueNo1, object valueNo2) { }

private int CompareWithFamilies(object valueNo1, object valueNo2) { }

public override void Copy(int recordNo1, int recordNo2) { }

public override object Get(int recordNo) { }

private ObjectStorage.Families GetFamily(Type dataType) { }

public override bool IsNull(int record) { }

public override void Set(int recordNo, object value) { }

public override void SetCapacity(int capacity) { }

public override object ConvertXmlToObject(string s) { }

public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

public override string ConvertObjectToXml(object value) { }

public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

protected override object GetEmptyStorage(int recordCount) { }

protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

protected override void SetStorage(object store, BitArray nullbits) { }

internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

internal static XmlSerializer GetXmlSerializer(Type type) { }

internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

private static void .cctor() { }

}

private enum ObjectStorage.Families // TypeDefIndex: 4407
{
	public int value__; 
public const ObjectStorage.Families DATETIME = 0;
public const ObjectStorage.Families NUMBER = 1;
public const ObjectStorage.Families STRING = 2;
public const ObjectStorage.Families BOOLEAN = 3;
public const ObjectStorage.Families ARRAY = 4;

}

private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 4408
{
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; 


private void .ctor() { }

public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

private static void .cctor() { }

}

