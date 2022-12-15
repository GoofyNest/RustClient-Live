public class LookAtIOEnt : MonoBehaviour // TypeDefIndex: 12879
{
	public Text objectTitle;
	public RectTransform slotToolTip;
	public Text slotTitle;
	public Text slotConnection;
	public Text slotPower;
	public Text powerText;
	public Text passthroughText;
	public Text chargeLeftText;
	public Text capacityText;
	public Text maxOutputText;
	public Text activeOutputText;
	public IOEntityUISlotEntry[] inputEntries;
	public IOEntityUISlotEntry[] outputEntries;
	public Color NoPowerColor;
	public GameObject GravityWarning;
	public CanvasGroup group;
	public LookAtIOEnt.HandleSet[] handleSets;
	public RectTransform clearNotification;
	public CanvasGroup wireInfoGroup;
	public Text wireLengthText;
	public Text wireClipsText;
	public Text errorReasonTextTooFar;
	public Text errorReasonTextNoSurface;
	public Text errorShortCircuit;
	public RawImage ConnectionTypeIcon;
	public Texture ElectricSprite;
	public Texture FluidSprite;
	private IOEntity lastLooking;
	private float nextUpdatetime;
	public GameObject activeHandle;
	private MaterialSwap activeHandleMaterialSwap;
	public GameObject pluggedHandle;
	public List<GameObject> inputHandles;
	public List<GameObject> outputHandles;
	private static int selectedIndex;
	private static bool selectedWasInput;
	private bool wiretoolWasPendingInput;
	private bool wiretoolWasPendingOutput;
	private bool wireToolWasPendingRoot;
	private IOEntity.IOType wireToolWasType;


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

public struct LookAtIOEnt.HandleSet // TypeDefIndex: 12880
{
	public IOEntity.IOType ForIO;
	public GameObjectRef handlePrefab;
	public GameObjectRef handleOccupiedPrefab;
	public GameObjectRef selectedHandlePrefab;
	public GameObjectRef pluggedHandlePrefab;

}

