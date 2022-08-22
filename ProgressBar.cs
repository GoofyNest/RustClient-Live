public class ProgressBar : UIBehaviour // TypeDefIndex: 11204
{	public static ProgressBar Instance; // 0x0
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


	protected override void Start() { }

	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	public void UpdateProgressBar() { }

	public void PlayOpenSound() { }

	public void PlayCancelSound() { }

	public void Close(bool success = False) { }

	private void Update() { }

	public void .ctor() { }

}

