public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 11441
{	public GameObject[] arrowModels; // 0x18
	private string curAmmoType; // 0x20
	private bool wasHidden; // 0x28


	public void SelectArrowType(int iType) { }

	public void HideAllArrowHeads() { }

	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	private void Cleanup() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void .ctor() { }

}

public enum SwapArrows.ArrowType // TypeDefIndex: 11442
{	public int value__; // 0x0
	public const SwapArrows.ArrowType One = 0;
	public const SwapArrows.ArrowType Two = 1;
	public const SwapArrows.ArrowType Three = 2;
	public const SwapArrows.ArrowType Four = 3;

}

