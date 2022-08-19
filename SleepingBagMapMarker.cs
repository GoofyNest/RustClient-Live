public class SleepingBagMapMarker : MonoBehaviour // TypeDefIndex: 10960
{	// Fields
	public Image MapIcon; // 0x18
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

	// Properties
	private float timerSeconds { get; }
	private string friendlyName { get; }

	// Methods

	// RVA: 0x5C2420 Offset: 0x5C1820 VA: 0x1805C2420
	private float get_timerSeconds() { }

	// RVA: 0x5C23B0 Offset: 0x5C17B0 VA: 0x1805C23B0
	private string get_friendlyName() { }

	// RVA: 0x5C2030 Offset: 0x5C1430 VA: 0x1805C2030
	public void Populate(RespawnInformation.SpawnOptions spawnInfo, UIDeathScreen.RespawnColourScheme colourScheme) { }

	// RVA: 0x5C2200 Offset: 0x5C1600 VA: 0x1805C2200
	public void Update() { }

	// RVA: 0x5C1EE0 Offset: 0x5C12E0 VA: 0x1805C1EE0
	public void OnClicked() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

