public class OvenItemIcon : MonoBehaviour // TypeDefIndex: 12766
{
	public ItemIcon ItemIcon; 
	public RustText ItemLabel; 
	public RustText MaterialLabel; 
	public OvenSlotType SlotType; 
	public Translate.Phrase EmptyPhrase; 
	public List<OvenItemIcon.OvenSlotConfig> SlotConfigs; 
	public float DisabledAlphaScale; 
	public CanvasGroup CanvasGroup; 
	private Item _item; 


	private void Start() { }

	private void Update() { }

	private void UpdateLabels() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private bool <Start>b__10_0(OvenItemIcon.OvenSlotConfig x) { }

}

public class OvenItemIcon.OvenSlotConfig // TypeDefIndex: 12767
{
	public OvenSlotType Type; 
	public Sprite BackgroundImage; 
	public Translate.Phrase SlotPhrase; 


	public void .ctor() { }

}

