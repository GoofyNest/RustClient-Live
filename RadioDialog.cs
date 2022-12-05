public class RadioDialog : UIDialog // TypeDefIndex: 12681
{
	public RustInput IpInput;
	public GameObjectRef FavouritePrefab;
	public Transform FavouritesContainer;
	public GameObject HasCassetteRoot;
	public static RadioDialog Instance;
	private BoomBox currentBox;
	private List<FavouriteRadioStation> spawnedFavourites;
	private string selectedUrl;


	public void SetBoomBox(BoomBox box) { }

	public void OnURLChanged(string newUrl) { }

	public void OnClickedConfirm() { }

	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	private void ClearFavourites() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class RadioDialog.<>c__DisplayClass12_0 // TypeDefIndex: 12682
{
	public KeyValuePair<string, string> favourite;
	public RadioDialog <>4__this;


	public void .ctor() { }

	internal void <PopulateFavouritesFromList>

}

