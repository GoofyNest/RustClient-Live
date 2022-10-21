public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 13195
{
	public GameObject[] arrowModels; 
	private string curAmmoType; 
	private bool wasHidden; 


	public void SelectArrowType(int iType) { }

	public void HideAllArrowHeads() { }

	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	private void Cleanup() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void .ctor() { }

}

public enum SwapArrows.ArrowType // TypeDefIndex: 13196
{
	public int value__; 
	public const SwapArrows.ArrowType One = 0;
	public const SwapArrows.ArrowType Two = 1;
	public const SwapArrows.ArrowType Three = 2;
	public const SwapArrows.ArrowType Four = 3;

}

