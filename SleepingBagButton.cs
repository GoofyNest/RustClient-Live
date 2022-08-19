public class SleepingBagButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11216
{	// Fields
	public GameObject TimeLockRoot; // 0x18
	public GameObject LockRoot; // 0x20
	public GameObject OccupiedRoot; // 0x28
	public Button ClickButton; // 0x30
	public TextMeshProUGUI BagName; // 0x38
	public TextMeshProUGUI LockTime; // 0x40
	public Image Icon; // 0x48
	public Sprite SleepingBagSprite; // 0x50
	public Sprite BedSprite; // 0x58
	public Sprite BeachTowelSprite; // 0x60
	public Sprite CamperSprite; // 0x68
	public Image CircleRim; // 0x70
	public Image CircleFill; // 0x78
	public Image Background; // 0x80
	public GameObject DeleteButton; // 0x88
	internal RespawnInformation.SpawnOptions spawnOption; // 0x90
	internal float releaseTime; // 0x98

	// Properties
	public float timerSeconds { get; }
	public string friendlyName { get; }

	// Methods

	// RVA: 0x5C1210 Offset: 0x5C0610 VA: 0x1805C1210
	public float get_timerSeconds() { }

	// RVA: 0x5C11A0 Offset: 0x5C05A0 VA: 0x1805C11A0
	public string get_friendlyName() { }

	// RVA: 0x5C0C00 Offset: 0x5C0000 VA: 0x1805C0C00
	private void OnEnable() { }

	// RVA: 0x5C0DB0 Offset: 0x5C01B0 VA: 0x1805C0DB0
	public void Setup(RespawnInformation.SpawnOptions option, UIDeathScreen.RespawnColourScheme colourScheme) { }

	// RVA: 0x5C0F90 Offset: 0x5C0390 VA: 0x1805C0F90
	private void UpdateButtonState(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x5C1060 Offset: 0x5C0460 VA: 0x1805C1060
	public void Update() { }

	// RVA: 0x5C0AD0 Offset: 0x5BFED0 VA: 0x1805C0AD0
	public void DoSpawn() { }

	// RVA: 0x5C09A0 Offset: 0x5BFDA0 VA: 0x1805C09A0
	public void DeleteBag() { }

	// RVA: 0x5C0C90 Offset: 0x5C0090 VA: 0x1805C0C90 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x5C0D20 Offset: 0x5C0120 VA: 0x1805C0D20 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

