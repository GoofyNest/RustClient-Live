public class RadioDialog : UIDialog // TypeDefIndex: 10905
{	// Fields
	public RustInput IpInput; // 0x30
	public GameObjectRef FavouritePrefab; // 0x38
	public Transform FavouritesContainer; // 0x40
	public GameObject HasCassetteRoot; // 0x48
	public static RadioDialog Instance; // 0x0
	private BoomBox currentBox; // 0x50
	private List<FavouriteRadioStation> spawnedFavourites; // 0x58
	private string selectedUrl; // 0x60

	// Methods

	// RVA: 0x6A2310 Offset: 0x6A1710 VA: 0x1806A2310
	public void SetBoomBox(BoomBox box) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnURLChanged(string newUrl) { }

	// RVA: 0x6A1FC0 Offset: 0x6A13C0 VA: 0x1806A1FC0
	public void OnClickedConfirm() { }

	// RVA: 0x6A2480 Offset: 0x6A1880 VA: 0x1806A2480
	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	// RVA: 0x6A2030 Offset: 0x6A1430 VA: 0x1806A2030
	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	// RVA: 0x6A1E20 Offset: 0x6A1220 VA: 0x1806A1E20
	private void ClearFavourites() { }

	// RVA: 0x6A24D0 Offset: 0x6A18D0 VA: 0x1806A24D0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class RadioDialog.<>c__DisplayClass12_0 // TypeDefIndex: 10906
{	// Fields
	public KeyValuePair<string, string> favourite; // 0x10
	public RadioDialog <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6AC8A0 Offset: 0x6ABCA0 VA: 0x1806AC8A0
	internal void <PopulateFavouritesFromList>b__0(string s) { }

}

