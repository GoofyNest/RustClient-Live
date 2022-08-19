public class SwapArrows : MonoBehaviour, IClientComponent // TypeDefIndex: 11441
{	// Fields
	public GameObject[] arrowModels; // 0x18
	private string curAmmoType; // 0x20
	private bool wasHidden; // 0x28

	// Methods

	// RVA: 0x7A4550 Offset: 0x7A3950 VA: 0x1807A4550
	public void SelectArrowType(int iType) { }

	// RVA: 0x7A4470 Offset: 0x7A3870 VA: 0x1807A4470
	public void HideAllArrowHeads() { }

	// RVA: 0x7A4610 Offset: 0x7A3A10 VA: 0x1807A4610
	public void UpdateAmmoType(ItemDefinition ammoType, bool hidden = False) { }

	// RVA: 0x7A43D0 Offset: 0x7A37D0 VA: 0x1807A43D0
	private void Cleanup() { }

	// RVA: 0x7A44D0 Offset: 0x7A38D0 VA: 0x1807A44D0
	public void OnDisable() { }

	// RVA: 0x7A4540 Offset: 0x7A3940 VA: 0x1807A4540
	public void OnEnable() { }

	// RVA: 0x7A47C0 Offset: 0x7A3BC0 VA: 0x1807A47C0
	public void .ctor() { }

}

public enum SwapArrows.ArrowType // TypeDefIndex: 11442
{	// Fields
	public int value__; // 0x0
	public const SwapArrows.ArrowType One = 0;
	public const SwapArrows.ArrowType Two = 1;
	public const SwapArrows.ArrowType Three = 2;
	public const SwapArrows.ArrowType Four = 3;

}

