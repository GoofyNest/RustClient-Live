internal class HeaderInfo // TypeDefIndex: 2915
{	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x1335FB0 Offset: 0x13353B0 VA: 0x181335FB0
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

internal abstract class HeaderInfo // TypeDefIndex: 5769
{	// Fields
	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	// Properties
	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }

	// Methods

	// RVA: 0x1083530 Offset: 0x1082930 VA: 0x181083530
	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FF10 Offset: 0xE7F310 VA: 0x180E7FF10
	|-HeaderInfo.CreateSingle<byte[]>
	|-HeaderInfo.CreateSingle<DateTimeOffset>
	|-HeaderInfo.CreateSingle<int>
	|-HeaderInfo.CreateSingle<long>
	|-HeaderInfo.CreateSingle<AuthenticationHeaderValue>
	|-HeaderInfo.CreateSingle<CacheControlHeaderValue>
	|-HeaderInfo.CreateSingle<ContentDispositionHeaderValue>
	|-HeaderInfo.CreateSingle<ContentRangeHeaderValue>
	|-HeaderInfo.CreateSingle<EntityTagHeaderValue>
	|-HeaderInfo.CreateSingle<MediaTypeHeaderValue>
	|-HeaderInfo.CreateSingle<RangeConditionHeaderValue>
	|-HeaderInfo.CreateSingle<RangeHeaderValue>
	|-HeaderInfo.CreateSingle<RetryConditionHeaderValue>
	|-HeaderInfo.CreateSingle<object>
	|-HeaderInfo.CreateSingle<string>
	|-HeaderInfo.CreateSingle<TimeSpan>
	|-HeaderInfo.CreateSingle<Uri>
	*/

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FE70 Offset: 0xE7F270 VA: 0x180E7FE70
	|-HeaderInfo.CreateMulti<AuthenticationHeaderValue>
	|-HeaderInfo.CreateMulti<EntityTagHeaderValue>
	|-HeaderInfo.CreateMulti<MediaTypeWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<NameValueHeaderValue>
	|-HeaderInfo.CreateMulti<NameValueWithParametersHeaderValue>
	|-HeaderInfo.CreateMulti<ProductHeaderValue>
	|-HeaderInfo.CreateMulti<ProductInfoHeaderValue>
	|-HeaderInfo.CreateMulti<StringWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<TransferCodingHeaderValue>
	|-HeaderInfo.CreateMulti<TransferCodingWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<ViaHeaderValue>
	|-HeaderInfo.CreateMulti<WarningHeaderValue>
	|-HeaderInfo.CreateMulti<object>
	|-HeaderInfo.CreateMulti<string>
	*/

	// RVA: 0x1083510 Offset: 0x1082910 VA: 0x181083510
	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Func<object, string> get_CustomToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_CustomToString(Func<object, string> value) { }

	// RVA: 0x1083580 Offset: 0x1082980 VA: 0x181083580 Slot: 4
	public virtual string get_Separator() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddToCollection(object collection, object value);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract List<string> ToStringCollection(object collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryParse(string value, out object result);

}

private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 5770
{	// Fields
	private readonly TryParseDelegate<T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EC20 Offset: 0x175E020 VA: 0x18175EC20
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175D7D0 Offset: 0x175CBD0 VA: 0x18175D7D0
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175D900 Offset: 0x175CD00 VA: 0x18175D900
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175E680 Offset: 0x175DA80 VA: 0x18175E680
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-RVA: 0x175E000 Offset: 0x175D400 VA: 0x18175E000
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-RVA: 0x175E340 Offset: 0x175D740 VA: 0x18175E340
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-RVA: 0x175DCC0 Offset: 0x175D0C0 VA: 0x18175DCC0
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-RVA: 0x175D980 Offset: 0x175CD80 VA: 0x18175D980
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EA60 Offset: 0x175DE60 VA: 0x18175EA60
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-RVA: 0x175E9C0 Offset: 0x175DDC0 VA: 0x18175E9C0
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-RVA: 0x175EB10 Offset: 0x175DF10 VA: 0x18175EB10
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-RVA: 0x175EBC0 Offset: 0x175DFC0 VA: 0x18175EBC0
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	*/

}

private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 5771
{	// Fields
	private readonly int minimalCount; // 0x0
	private readonly string separator; // 0x0
	private readonly TryParseListDelegate<T> parser; // 0x0

	// Properties
	public override string Separator { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1759C90 Offset: 0x1759090 VA: 0x181759C90
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1759C10 Offset: 0x1759010 VA: 0x181759C10
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	*/

}

