public class SleepingBagMapMarker : MonoBehaviour // TypeDefIndex: 10960
{	public Image MapIcon; // 0x18
	public Image SleepingBagIcon; // 0x20
	public Sprite SleepingBagSprite; // 0x28
	public Sprite BedSprite; // 0x30
	public Sprite BeachTowelSprite; // 0x38
	public Sprite CamperSprite; // 0x40
	public Tooltip MarkerTooltip; // 0x48
	public GameObject LockRoot; // 0x50
	public TextMeshProUGUI LockTime; // 0x58
	public GameObject OccupiedRoot; // 0x60
	public Image CircleRim; // 0x68
	public Image CircleFill; // 0x70
	private RespawnInformation.SpawnOptions cachedSpawnInfo; // 0x78
	private float releaseTime; // 0x80

	private float timerSeconds { get; }
	private string friendlyName { get; }


	private float get_timerSeconds() { }

	private string get_friendlyName() { }

	public void Populate(RespawnInformation.SpawnOptions spawnInfo, UIDeathScreen.RespawnColourScheme colourScheme) { }

	public void Update() { }

	public void OnClicked() { }

	public void .ctor() { }

}

