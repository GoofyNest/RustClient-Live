public class SleepingBagMapMarker : MonoBehaviour // TypeDefIndex: 12737
{
	public Image MapIcon;
	public Image SleepingBagIcon;
	public Sprite SleepingBagSprite;
	public Sprite BedSprite;
	public Sprite BeachTowelSprite;
	public Sprite CamperSprite;
	public Tooltip MarkerTooltip;
	public GameObject LockRoot;
	public TextMeshProUGUI LockTime;
	public GameObject OccupiedRoot;
	public Image CircleRim;
	public Image CircleFill;
	private RespawnInformation.SpawnOptions cachedSpawnInfo;
	private float releaseTime;

	private float timerSeconds { get; }
	private string friendlyName { get; }


	private float get_timerSeconds() { }

	private string get_friendlyName() { }

	public void Populate(RespawnInformation.SpawnOptions spawnInfo, UIDeathScreen.RespawnColourScheme colourScheme) { }

	public void Update() { }

	public void OnClicked() { }

	public void .ctor() { }

}

