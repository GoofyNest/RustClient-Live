public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 11043
{	public CanvasGroup group; // 0x18
	public TextMeshProUGUI text; // 0x20
	public DamageType damageType; // 0x28
	public bool selectedItem; // 0x2C
	public bool displayBaseProtection; // 0x2D


	private void OnEnable() { }

	private void OnDisable() { }

	public void OnClothingChanged() { }

	public void UpdateFromItem(Item item) { }

	public float GetProtectionForArea(HitArea area) { }

	public void UpdateFromArea(HitArea area) { }

	public void SetValue(float val) { }

	public void .ctor() { }

}

