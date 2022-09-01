internal class HeaderInfo // TypeDefIndex: 2915
{
	internal readonly bool IsRequestRestricted; 
	internal readonly bool IsResponseRestricted; 
	internal readonly HeaderParser Parser; 
	internal readonly string HeaderName; 
	internal readonly bool AllowMultiValues; 


	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

internal abstract class HeaderInfo // TypeDefIndex: 5770
{
	public bool AllowsMany; 
	public readonly HttpHeaderKind HeaderKind; 
	public readonly string Name; 
	[CompilerGeneratedAttribute] 
	private Func<object, string> <CustomToString>k__BackingField; 

	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }


	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
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

	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
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

	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGeneratedAttribute] 
	public Func<object, string> get_CustomToString() { }

	[CompilerGeneratedAttribute] 
	private void set_CustomToString(Func<object, string> value) { }

	public virtual string get_Separator() { }

	public abstract void AddToCollection(object collection, object value);

	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	public abstract List<string> ToStringCollection(object collection);

	public abstract bool TryParse(string value, out object result);

}

private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 5771
{
	private readonly TryParseDelegate<T> parser; 


	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	*/

	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	*/

	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	*/

	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	*/

	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	*/

}

private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 5772
{
	private readonly int minimalCount; 
	private readonly string separator; 
	private readonly TryParseListDelegate<T> parser; 

	public override string Separator { get; }


	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	*/

	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	*/

	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	*/

}

