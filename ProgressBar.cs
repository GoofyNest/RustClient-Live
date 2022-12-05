public class ProgressBar : UIBehaviour // TypeDefIndex: 13001
{
	public static ProgressBar Instance;
	private Action<BasePlayer> action;
	private float timeFinished;
	private float timeCounter;
	public GameObject scaleTarget;
	public Image progressField;
	public Image iconField;
	public Text leftField;
	public Text rightField;
	public SoundDefinition clipOpen;
	public SoundDefinition clipCancel;
	public bool IsOpen;
	private bool isClosing;
	private CanvasGroup canvasGroup;


	protected override void Start() { }

	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	public void UpdateProgressBar() { }

	public void PlayOpenSound() { }

	public void PlayCancelSound() { }

	public void Close(bool success = False) { }

	private void Update() { }

	public void .ctor() { }

}

