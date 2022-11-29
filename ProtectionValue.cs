public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 12818
{
	public CanvasGroup group; 
	public TextMeshProUGUI text; 
	public DamageType damageType; 
	public bool selectedItem; 
	public bool displayBaseProtection; 


	private void OnEnable() { }

	private void OnDisable() { }

	public void OnClothingChanged() { }

	public void UpdateFromItem(Item item) { }

	public float GetProtectionForArea(HitArea area) { }

	public void UpdateFromArea(HitArea area) { }

	public void SetValue(float val) { }

	public void .ctor() { }

}

