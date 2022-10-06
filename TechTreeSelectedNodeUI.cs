public class TechTreeSelectedNodeUI : MonoBehaviour // TypeDefIndex: 12635
{
	public RustText selectedTitle; 
	public RawImage selectedIcon; 
	public RustText selectedDescription; 
	public RustText costText; 
	public RustText craftingCostText; 
	public GameObject costObject; 
	public GameObject cantAffordObject; 
	public GameObject unlockedObject; 
	public GameObject unlockButton; 
	public GameObject noPathObject; 
	public TechTreeDialog dialog; 
	public Color ColorAfford; 
	public Color ColorCantAfford; 
	public GameObject totalRequiredRoot; 
	public RustText totalRequiredText; 
	public ItemInformationPanel[] informationPanels; 
	private List<TechTreeData.NodeInstance> preReqNodes; 
	private int preReqCost; 


	public void Start() { }

	public void HideIP() { }

	public void TryUnlock() { }

	public void DoSelection(TechTreeData.NodeInstance node) { }

	public void .ctor() { }

}

