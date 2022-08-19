public class VitalNoteOxygen : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11283
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float refreshTime; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextMeshProUGUI valueText; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Animator animator; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image airIcon; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform airIconTr; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image backgroundImage; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color baseColour; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color badColour; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image iconImage; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color iconBaseColour; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color iconBadColour; // 0x80
	protected bool show; // 0x90
	private TimeSince timeSinceLastRefresh; // 0x94

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x7E0760 Offset: 0x7DFB60 VA: 0x1807E0760 Slot: 4
	public void Refresh() { }

	// RVA: 0x7E0710 Offset: 0x7DFB10 VA: 0x1807E0710
	private void Hide() { }

	// RVA: 0x7E0CE0 Offset: 0x7E00E0 VA: 0x1807E0CE0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x7667C0 Offset: 0x765BC0 VA: 0x1807667C0 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x7E0D30 Offset: 0x7E0130 VA: 0x1807E0D30
	public void .ctor() { }

}

