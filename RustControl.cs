public class RustControl : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 7017
{	protected static bool IsDragging; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleAsset _styles; // 0x18
	public RustWrapper FormField; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public RustControl.State CurrentState; // 0x28

	public virtual StyleAsset Styles { get; set; }
	public RectTransform rectTransform { get; }
	public virtual bool IsDisabled { get; }
	public virtual bool IsPressed { get; }
	public virtual bool IsHovered { get; }
	public virtual StyleAsset.Group CurrentStyleCollection { get; }


	public virtual StyleAsset get_Styles() { }

	public virtual void set_Styles(StyleAsset value) { }

	protected override void OnEnable() { }

	public RectTransform get_rectTransform() { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void SetDisabled(bool value) { }

	public virtual void SetPressed(bool value) { }

	public virtual bool get_IsDisabled() { }

	public virtual bool get_IsPressed() { }

	public virtual bool get_IsHovered() { }

	public virtual StyleAsset.Group get_CurrentStyleCollection() { }

	public virtual void ApplyStyles() { }

	protected virtual void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum RustControl.State // TypeDefIndex: 7018
{	public int value__; // 0x0
	public const RustControl.State Normal = 1;
	public const RustControl.State Hovered = 2;
	public const RustControl.State Pressed = 4;
	public const RustControl.State Active = 8;
	public const RustControl.State Disabled = 16;

}

