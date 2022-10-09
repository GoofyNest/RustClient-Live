public class VitalNote : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 13022
{
	public VitalNote.Vital VitalType; 
	public FloatConditions showIf; 
	public TextMeshProUGUI valueText; 
	private float lastValue; 
	private float lastPrintedValue; 
	protected bool show; 

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

public enum VitalNote.Vital // TypeDefIndex: 13023
{
	public int value__; 
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

