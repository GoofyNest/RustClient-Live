public class VitalNote : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11281
{	// Fields
	public VitalNote.Vital VitalType; // 0x18
	public FloatConditions showIf; // 0x20
	public TextMeshProUGUI valueText; // 0x28
	private float lastValue; // 0x30
	private float lastPrintedValue; // 0x34
	protected bool show; // 0x38

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x7DFAE0 Offset: 0x7DEEE0 VA: 0x1807DFAE0
	private void Awake() { }

	// RVA: 0x7E0DA0 Offset: 0x7E01A0 VA: 0x1807E0DA0 Slot: 4
	public void Refresh() { }

	// RVA: 0x7E10F0 Offset: 0x7E04F0 VA: 0x1807E10F0
	private void UpdateShow(float value, string format) { }

	// RVA: 0x7DFB10 Offset: 0x7DEF10 VA: 0x1807DFB10
	private void Hide() { }

	// RVA: 0x7E06C0 Offset: 0x7DFAC0 VA: 0x1807E06C0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x7E0D50 Offset: 0x7E0150 VA: 0x1807E0D50
	private void ClientConnected() { }

	// RVA: 0x7667C0 Offset: 0x765BC0 VA: 0x1807667C0 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x7E12D0 Offset: 0x7E06D0 VA: 0x1807E12D0
	public void .ctor() { }

}

public enum VitalNote.Vital // TypeDefIndex: 11282
{	// Fields
	public int value__; // 0x0
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

