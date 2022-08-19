public class TechTreeSelectedNodeUI : MonoBehaviour // TypeDefIndex: 10916
{	// Fields
	public RustText selectedTitle; // 0x18
	public RawImage selectedIcon; // 0x20
	public RustText selectedDescription; // 0x28
	public RustText costText; // 0x30
	public RustText craftingCostText; // 0x38
	public GameObject costObject; // 0x40
	public GameObject cantAffordObject; // 0x48
	public GameObject unlockedObject; // 0x50
	public GameObject unlockButton; // 0x58
	public GameObject noPathObject; // 0x60
	public TechTreeDialog dialog; // 0x68
	public Color ColorAfford; // 0x70
	public Color ColorCantAfford; // 0x80
	public GameObject totalRequiredRoot; // 0x90
	public RustText totalRequiredText; // 0x98
	public ItemInformationPanel[] informationPanels; // 0xA0
	private List<TechTreeData.NodeInstance> preReqNodes; // 0xA8
	private int preReqCost; // 0xB0

	// Methods

	// RVA: 0x7AD730 Offset: 0x7ACB30 VA: 0x1807AD730
	public void Start() { }

	// RVA: 0x7AD730 Offset: 0x7ACB30 VA: 0x1807AD730
	public void HideIP() { }

	// RVA: 0x7AD7B0 Offset: 0x7ACBB0 VA: 0x1807AD7B0
	public void TryUnlock() { }

	// RVA: 0x7ACC80 Offset: 0x7AC080 VA: 0x1807ACC80
	public void DoSelection(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AD7D0 Offset: 0x7ACBD0 VA: 0x1807AD7D0
	public void .ctor() { }

}

