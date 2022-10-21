public class SleepingBagButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 12970
{
	public GameObject TimeLockRoot; 
	public GameObject LockRoot; 
	public GameObject OccupiedRoot; 
	public Button ClickButton; 
	public TextMeshProUGUI BagName; 
	public TextMeshProUGUI LockTime; 
	public Image Icon; 
	public Sprite SleepingBagSprite; 
	public Sprite BedSprite; 
	public Sprite BeachTowelSprite; 
	public Sprite CamperSprite; 
	public Image CircleRim; 
	public Image CircleFill; 
	public Image Background; 
	public GameObject DeleteButton; 
	internal RespawnInformation.SpawnOptions spawnOption; 
	internal float releaseTime; 

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

