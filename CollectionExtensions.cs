public static class CollectionExtensions // TypeDefIndex: 1442
{
[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public static class CollectionExtensions // TypeDefIndex: 1442

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/

}

internal static class CollectionExtensions // TypeDefIndex: 5760
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-CollectionExtensions.SequenceEqual<NameValueHeaderValue>
	|-CollectionExtensions.SequenceEqual<RangeItemHeaderValue>
	|-CollectionExtensions.SequenceEqual<object>
	|-CollectionExtensions.SequenceEqual<string>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string ToString<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-CollectionExtensions.ToString<NameValueHeaderValue>
	|-CollectionExtensions.ToString<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-CollectionExtensions.ToStringBuilder<NameValueHeaderValue>
	|-CollectionExtensions.ToStringBuilder<object>
	|-CollectionExtensions.ToStringBuilder<string>
	*/

}

