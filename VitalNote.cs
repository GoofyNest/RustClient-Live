public class VitalNote : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11281
{	public VitalNote.Vital VitalType; // 0x18
	public FloatConditions showIf; // 0x20
	public TextMeshProUGUI valueText; // 0x28
	private float lastValue; // 0x30
	private float lastPrintedValue; // 0x34
	protected bool show; // 0x38

	public bool IsActive { get; }


	private void Awake() { }

	public void Refresh() { }

	private void UpdateShow(float value, string format) { }

	private void Hide() { }

	protected virtual void Show() { }

	private void ClientConnected() { }

	public bool get_IsActive() { }

	public void .ctor() { }

}

public enum VitalNote.Vital // TypeDefIndex: 11282
{	public int value__; // 0x0
	public const VitalNote.Vital Comfort = 0;
	public const VitalNote.Vital Radiation = 1;
	public const VitalNote.Vital Poison = 2;
	public const VitalNote.Vital Cold = 3;
	public const VitalNote.Vital Bleeding = 4;
	public const VitalNote.Vital Hot = 5;
	public const VitalNote.Vital Oxygen = 6;
	public const VitalNote.Vital Wet = 7;
	public const VitalNote.Vital Hygiene = 8;
	public const VitalNote.Vital Starving = 9;
	public const VitalNote.Vital Dehydration = 10;

}

