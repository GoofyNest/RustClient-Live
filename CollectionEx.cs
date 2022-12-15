public static class CollectionEx // TypeDefIndex: 13159
{

	[ExtensionAttribute]
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-CollectionEx.IsNullOrEmpty<BaseEntity>
	|-CollectionEx.IsNullOrEmpty<object>
	|-CollectionEx.IsNullOrEmpty<GameObject>
	|-CollectionEx.IsNullOrEmpty<LOD>
	|-CollectionEx.IsNullOrEmpty<Material>
	*/

	[ExtensionAttribute]
	public static bool IsEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-CollectionEx.IsEmpty<object>
	*/

}

