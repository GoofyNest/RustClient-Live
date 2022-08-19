internal static class CollectionUtils // TypeDefIndex: 5961
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12573F0 Offset: 0x12567F0 VA: 0x1812573F0
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCED900 Offset: 0xCECD00 VA: 0x180CED900
	|-CollectionUtils.AddRange<JsonProperty>
	|-CollectionUtils.AddRange<SerializationCallback>
	|-CollectionUtils.AddRange<SerializationErrorCallback>
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCED880 Offset: 0xCECC80 VA: 0x180CED880
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	// RVA: 0x17F9740 Offset: 0x17F8B40 VA: 0x1817F9740
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x17F9C50 Offset: 0x17F9050 VA: 0x1817F9C50
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x17F9A10 Offset: 0x17F8E10 VA: 0x1817F9A10
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1173660 Offset: 0x1172A60 VA: 0x181173660
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257440 Offset: 0x1256840 VA: 0x181257440
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11735D0 Offset: 0x11729D0 VA: 0x1811735D0
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	// RVA: 0x17F93E0 Offset: 0x17F87E0 VA: 0x1817F93E0
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x17F91C0 Offset: 0x17F85C0 VA: 0x1817F91C0
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x17F9900 Offset: 0x17F8D00 VA: 0x1817F9900
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x17F9D70 Offset: 0x17F9170 VA: 0x1817F9D70
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

