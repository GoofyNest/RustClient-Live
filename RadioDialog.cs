public class RadioDialog : UIDialog // TypeDefIndex: 10905
{	public RustInput IpInput; // 0x30
	public GameObjectRef FavouritePrefab; // 0x38
	public Transform FavouritesContainer; // 0x40
	public GameObject HasCassetteRoot; // 0x48
	public static RadioDialog Instance; // 0x0
	private BoomBox currentBox; // 0x50
	private List<FavouriteRadioStation> spawnedFavourites; // 0x58
	private string selectedUrl; // 0x60


	public void SetBoomBox(BoomBox box) { }

	public void OnURLChanged(string newUrl) { }

	public void OnClickedConfirm() { }

	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	private void ClearFavourites() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class RadioDialog.<>c__DisplayClass12_0 // TypeDefIndex: 10906
{	public KeyValuePair<string, string> favourite; // 0x10
	public RadioDialog <>4__this; // 0x20


	public void .ctor() { }

	internal void <PopulateFavouritesFromList>b__0(string s) { }

}

