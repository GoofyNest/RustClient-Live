public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{	// Fields
	private bool initialized; // 0x18
	public Material[] Default; // 0x20
	public Material[] Override; // 0x28
	public Renderer Renderer; // 0x30

	// Methods

	// RVA: 0x1B9F8C0 Offset: 0x1B9ECC0 VA: 0x181B9F8C0
	public static void ReplaceRecursive(GameObject go, Material mat) { }

	// RVA: 0x1B9FAC0 Offset: 0x1B9EEC0 VA: 0x181B9FAC0
	public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

	// RVA: 0x1B9F6F0 Offset: 0x1B9EAF0 VA: 0x181B9F6F0
	public static void Prepare(GameObject go) { }

	// RVA: 0x1B9F640 Offset: 0x1B9EA40 VA: 0x181B9F640
	private static bool MaterialsContainAny(Material[] source, Material[] find) { }

	// RVA: 0x1BA0360 Offset: 0x1B9F760 VA: 0x181BA0360
	public static void Reset(GameObject go) { }

	// RVA: 0x1B9F570 Offset: 0x1B9E970 VA: 0x181B9F570
	private void Init() { }

	// RVA: 0x1B9FE60 Offset: 0x1B9F260 VA: 0x181B9FE60
	private void Replace(Material mat) { }

	// RVA: 0x1BA01F0 Offset: 0x1B9F5F0 VA: 0x181BA01F0
	private void Replace(Material find, Material replace) { }

	// RVA: 0x1B9FF80 Offset: 0x1B9F380 VA: 0x181B9FF80
	private void Replace(Material[] find, Material[] replace) { }

	// RVA: 0x1BA0520 Offset: 0x1B9F920 VA: 0x181BA0520
	private void Revert() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

