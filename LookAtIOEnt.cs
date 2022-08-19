public class LookAtIOEnt : MonoBehaviour // TypeDefIndex: 11077
{	// Fields
	public Text objectTitle; // 0x18
	public RectTransform slotToolTip; // 0x20
	public Text slotTitle; // 0x28
	public Text slotConnection; // 0x30
	public Text slotPower; // 0x38
	public Text powerText; // 0x40
	public Text passthroughText; // 0x48
	public Text chargeLeftText; // 0x50
	public Text capacityText; // 0x58
	public Text maxOutputText; // 0x60
	public Text activeOutputText; // 0x68
	public IOEntityUISlotEntry[] inputEntries; // 0x70
	public IOEntityUISlotEntry[] outputEntries; // 0x78
	public Color NoPowerColor; // 0x80
	public GameObject GravityWarning; // 0x90
	public CanvasGroup group; // 0x98
	public LookAtIOEnt.HandleSet[] handleSets; // 0xA0
	public RectTransform clearNotification; // 0xA8
	public CanvasGroup wireInfoGroup; // 0xB0
	public Text wireLengthText; // 0xB8
	public Text wireClipsText; // 0xC0
	public Text errorReasonTextTooFar; // 0xC8
	public Text errorReasonTextNoSurface; // 0xD0
	public Text errorShortCircuit; // 0xD8
	public RawImage ConnectionTypeIcon; // 0xE0
	public Texture ElectricSprite; // 0xE8
	public Texture FluidSprite; // 0xF0
	private IOEntity lastLooking; // 0xF8
	private float nextUpdatetime; // 0x100
	public GameObject activeHandle; // 0x108
	private MaterialSwap activeHandleMaterialSwap; // 0x110
	public GameObject pluggedHandle; // 0x118
	public List<GameObject> inputHandles; // 0x120
	public List<GameObject> outputHandles; // 0x128
	private static int selectedIndex; // 0x0
	private static bool selectedWasInput; // 0x4
	private bool wiretoolWasPendingInput; // 0x130
	private bool wiretoolWasPendingOutput; // 0x131
	private bool wireToolWasPendingRoot; // 0x132
	private IOEntity.IOType wireToolWasType; // 0x134

	// Methods

	// RVA: 0x5006B0 Offset: 0x4FFAB0 VA: 0x1805006B0
	private void Update() { }

	// RVA: 0x4FCCA0 Offset: 0x4FC0A0 VA: 0x1804FCCA0
	public void ClearHandles() { }

	// RVA: 0x4FD160 Offset: 0x4FC560 VA: 0x1804FD160
	public void SetupHandles(IOEntity ent, bool showInputs = True, bool showOutputs = True) { }

	// RVA: 0x4FD040 Offset: 0x4FC440 VA: 0x1804FD040
	public static int GetSelectedIndex() { }

	// RVA: 0x4FD0A0 Offset: 0x4FC4A0 VA: 0x1804FD0A0
	public static bool SelectedIsInput() { }

	// RVA: 0x4FDE60 Offset: 0x4FD260 VA: 0x1804FDE60
	public void UpdateClearing() { }

	// RVA: 0x500360 Offset: 0x4FF760 VA: 0x180500360
	public void UpdateWireInfo() { }

	// RVA: 0x4FF210 Offset: 0x4FE610 VA: 0x1804FF210
	public void UpdateLookingHandle(bool includeInputs, bool includeOutputs) { }

	// RVA: 0x4FCE70 Offset: 0x4FC270 VA: 0x1804FCE70
	public Vector3 GetSelectedHandleWorldPosition() { }

	// RVA: 0x4FCD60 Offset: 0x4FC160 VA: 0x1804FCD60
	public IOEntity.IOType GetSelectedHandleType() { }

	// RVA: 0x4FF850 Offset: 0x4FEC50 VA: 0x1804FF850
	public void UpdateLookingUI() { }

	// RVA: 0x4FE100 Offset: 0x4FD500 VA: 0x1804FE100
	public bool UpdateLookingAtIOEnt() { }

	// RVA: 0x4FCCC0 Offset: 0x4FC0C0 VA: 0x1804FCCC0
	private LookAtIOEnt.HandleSet GetHandles(IOEntity.IOType forType) { }

	// RVA: 0x500970 Offset: 0x4FFD70 VA: 0x180500970
	public void .ctor() { }

	// RVA: 0x500920 Offset: 0x4FFD20 VA: 0x180500920
	private static void .cctor() { }

}

public struct LookAtIOEnt.HandleSet // TypeDefIndex: 11078
{	// Fields
	public IOEntity.IOType ForIO; // 0x0
	public GameObjectRef handlePrefab; // 0x8
	public GameObjectRef handleOccupiedPrefab; // 0x10
	public GameObjectRef selectedHandlePrefab; // 0x18
	public GameObjectRef pluggedHandlePrefab; // 0x20

}

