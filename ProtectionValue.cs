public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 11043
{	// Fields
	public CanvasGroup group; // 0x18
	public TextMeshProUGUI text; // 0x20
	public DamageType damageType; // 0x28
	public bool selectedItem; // 0x2C
	public bool displayBaseProtection; // 0x2D

	// Methods

	// RVA: 0x699CE0 Offset: 0x6990E0 VA: 0x180699CE0
	private void OnEnable() { }

	// RVA: 0x699C30 Offset: 0x699030 VA: 0x180699C30
	private void OnDisable() { }

	// RVA: 0x699A40 Offset: 0x698E40 VA: 0x180699A40 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x69A2D0 Offset: 0x6996D0 VA: 0x18069A2D0
	public void UpdateFromItem(Item item) { }

	// RVA: 0x699690 Offset: 0x698A90 VA: 0x180699690
	public float GetProtectionForArea(HitArea area) { }

	// RVA: 0x699F20 Offset: 0x699320 VA: 0x180699F20
	public void UpdateFromArea(HitArea area) { }

	// RVA: 0x699D60 Offset: 0x699160 VA: 0x180699D60
	public void SetValue(float val) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

