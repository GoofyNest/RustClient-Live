public class LookAtIOEnt : MonoBehaviour // TypeDefIndex: 11077
{	public Text objectTitle; // 0x18
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


	private void Update() { }

	public void ClearHandles() { }

	public void SetupHandles(IOEntity ent, bool showInputs = True, bool showOutputs = True) { }

	public static int GetSelectedIndex() { }

	public static bool SelectedIsInput() { }

	public void UpdateClearing() { }

	public void UpdateWireInfo() { }

	public void UpdateLookingHandle(bool includeInputs, bool includeOutputs) { }

	public Vector3 GetSelectedHandleWorldPosition() { }

	public IOEntity.IOType GetSelectedHandleType() { }

	public void UpdateLookingUI() { }

	public bool UpdateLookingAtIOEnt() { }

	private LookAtIOEnt.HandleSet GetHandles(IOEntity.IOType forType) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct LookAtIOEnt.HandleSet // TypeDefIndex: 11078
{	public IOEntity.IOType ForIO; // 0x0
	public GameObjectRef handlePrefab; // 0x8
	public GameObjectRef handleOccupiedPrefab; // 0x10
	public GameObjectRef selectedHandlePrefab; // 0x18
	public GameObjectRef pluggedHandlePrefab; // 0x20

}

