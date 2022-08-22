public class SleepingBagButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11216
{	public GameObject TimeLockRoot; // 0x18
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

	public float timerSeconds { get; }
	public string friendlyName { get; }


	public float get_timerSeconds() { }

	public string get_friendlyName() { }

	private void OnEnable() { }

	public void Setup(RespawnInformation.SpawnOptions option, UIDeathScreen.RespawnColourScheme colourScheme) { }

	private void UpdateButtonState(RespawnInformation.SpawnOptions option) { }

	public void Update() { }

	public void DoSpawn() { }

	public void DeleteBag() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void .ctor() { }

}

