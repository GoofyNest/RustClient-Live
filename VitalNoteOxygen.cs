public class VitalNoteOxygen : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 13080
{
	[SerializeField]
	private float refreshTime;
	[SerializeField]
	private TextMeshProUGUI valueText;
	[SerializeField]
	private Animator animator;
	[SerializeField]
	private Image airIcon;
	[SerializeField]
	private RectTransform airIconTr;
	[SerializeField]
	private Image backgroundImage;
	[SerializeField]
	private Color baseColour;
	[SerializeField]
	private Color badColour;
	[SerializeField]
	private Image iconImage;
	[SerializeField]
	private Color iconBaseColour;
	[SerializeField]
	private Color iconBadColour;
	protected bool show;
	private TimeSince timeSinceLastRefresh;

	public bool IsActive { get; }


	public void Refresh() { }

	private void Hide() { }

	protected virtual void Show() { }

	public bool get_IsActive() { }

	public void .ctor() { }

}

