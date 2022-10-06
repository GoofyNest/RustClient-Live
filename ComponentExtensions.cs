public static class ComponentExtensions // TypeDefIndex: 6227
{

	[ExtensionAttribute] 
	public static T Duplicate<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.Duplicate<RustText>
	|-ComponentExtensions.Duplicate<object>
	*/

	[ExtensionAttribute] 
	public static T[] Duplicate<T>(T obj, int amount, bool includeOriginalInArray = False) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.Duplicate<ESPPlayerInfo>
	|-ComponentExtensions.Duplicate<object>
	*/

	[ExtensionAttribute] 
	public static void SetActive<T>(T obj, bool active) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.SetActive<MapView>
	|-ComponentExtensions.SetActive<HttpImage>
	|-ComponentExtensions.SetActive<RustImageButton>
	|-ComponentExtensions.SetActive<RustLayout>
	|-ComponentExtensions.SetActive<RustText>
	|-ComponentExtensions.SetActive<ServerBrowserTag>
	|-ComponentExtensions.SetActive<object>
	|-ComponentExtensions.SetActive<RectTransform>
	|-ComponentExtensions.SetActive<Image>
	|-ComponentExtensions.SetActive<RawImage>
	|-ComponentExtensions.SetActive<ScrollRect>
	|-ComponentExtensions.SetActive<Text>
	*/

	[ExtensionAttribute] 
	public static Vector2 WorldToRectTransform<T>(T obj, Vector2 worldPos) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.WorldToRectTransform<object>
	*/

	[ExtensionAttribute] 
	public static Rect GetWorldRect<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.GetWorldRect<object>
	*/

	[ExtensionAttribute] 
	public static bool GetComponent<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.GetComponent<object, object>
	*/

	[ExtensionAttribute] 
	public static bool GetComponentInParent<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.GetComponentInParent<object, object>
	*/

	[ExtensionAttribute] 
	public static bool GetComponentInChildren<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-ComponentExtensions.GetComponentInChildren<object, object>
	*/

}

