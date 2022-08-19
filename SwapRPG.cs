public class SwapRPG : MonoBehaviour // TypeDefIndex: 11444
{	// Fields
	public GameObject[] rpgModels; // 0x18
	private string curAmmoType; // 0x20

	// Methods

	// RVA: 0x7A4960 Offset: 0x7A3D60 VA: 0x1807A4960
	public void SelectRPGType(int iType) { }

	// RVA: 0x7A4A10 Offset: 0x7A3E10 VA: 0x1807A4A10
	public void UpdateAmmoType(ItemDefinition ammoType) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0x7A4B10 Offset: 0x7A3F10 VA: 0x1807A4B10
	public void .ctor() { }

}

public enum SwapRPG.RPGType // TypeDefIndex: 11445
{	// Fields
	public int value__; // 0x0
	public const SwapRPG.RPGType One = 0;
	public const SwapRPG.RPGType Two = 1;
	public const SwapRPG.RPGType Three = 2;
	public const SwapRPG.RPGType Four = 3;

}

