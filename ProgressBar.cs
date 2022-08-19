public class ProgressBar : UIBehaviour // TypeDefIndex: 11204
{	// Fields
	public static ProgressBar Instance; // 0x0
	private Action<BasePlayer> action; // 0x18
	private float timeFinished; // 0x20
	private float timeCounter; // 0x24
	public GameObject scaleTarget; // 0x28
	public Image progressField; // 0x30
	public Image iconField; // 0x38
	public Text leftField; // 0x40
	public Text rightField; // 0x48
	public SoundDefinition clipOpen; // 0x50
	public SoundDefinition clipCancel; // 0x58
	public bool IsOpen; // 0x60
	private bool isClosing; // 0x61
	private CanvasGroup canvasGroup; // 0x68

	// Methods

	// RVA: 0x692290 Offset: 0x691690 VA: 0x180692290 Slot: 6
	protected override void Start() { }

	// RVA: 0x691F20 Offset: 0x691320 VA: 0x180691F20
	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	// RVA: 0x692370 Offset: 0x691770 VA: 0x180692370
	public void UpdateProgressBar() { }

	// RVA: 0x692250 Offset: 0x691650 VA: 0x180692250
	public void PlayOpenSound() { }

	// RVA: 0x692210 Offset: 0x691610 VA: 0x180692210
	public void PlayCancelSound() { }

	// RVA: 0x691D20 Offset: 0x691120 VA: 0x180691D20
	public void Close(bool success = False) { }

	// RVA: 0x692470 Offset: 0x691870 VA: 0x180692470
	private void Update() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

