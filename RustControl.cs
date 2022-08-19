public class RustControl : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 7017
{	// Fields
	protected static bool IsDragging; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleAsset _styles; // 0x18
	public RustWrapper FormField; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public RustControl.State CurrentState; // 0x28

	// Properties
	public virtual StyleAsset Styles { get; set; }
	public RectTransform rectTransform { get; }
	public virtual bool IsDisabled { get; }
	public virtual bool IsPressed { get; }
	public virtual bool IsHovered { get; }
	public virtual StyleAsset.Group CurrentStyleCollection { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 19
	public virtual StyleAsset get_Styles() { }

	// RVA: 0xFC6A60 Offset: 0xFC5E60 VA: 0x180FC6A60 Slot: 20
	public virtual void set_Styles(StyleAsset value) { }

	// RVA: 0xFC6770 Offset: 0xFC5B70 VA: 0x180FC6770 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xFC6A00 Offset: 0xFC5E00 VA: 0x180FC6A00
	public RectTransform get_rectTransform() { }

	// RVA: 0xFC67A0 Offset: 0xFC5BA0 VA: 0x180FC67A0 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xFC67C0 Offset: 0xFC5BC0 VA: 0x180FC67C0 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xFC67E0 Offset: 0xFC5BE0 VA: 0x180FC67E0 Slot: 23
	public virtual void SetDisabled(bool value) { }

	// RVA: 0xFC6840 Offset: 0xFC5C40 VA: 0x180FC6840 Slot: 24
	public virtual void SetPressed(bool value) { }

	// RVA: 0xFC69D0 Offset: 0xFC5DD0 VA: 0x180FC69D0 Slot: 25
	public virtual bool get_IsDisabled() { }

	// RVA: 0xFC69F0 Offset: 0xFC5DF0 VA: 0x180FC69F0 Slot: 26
	public virtual bool get_IsPressed() { }

	// RVA: 0xFC69E0 Offset: 0xFC5DE0 VA: 0x180FC69E0 Slot: 27
	public virtual bool get_IsHovered() { }

	// RVA: 0xFC68A0 Offset: 0xFC5CA0 VA: 0x180FC68A0 Slot: 28
	public virtual StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFC66C0 Offset: 0xFC5AC0 VA: 0x180FC66C0 Slot: 29
	public virtual void ApplyStyles() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 30
	protected virtual void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public enum RustControl.State // TypeDefIndex: 7018
{	// Fields
	public int value__; // 0x0
	public const RustControl.State Normal = 1;
	public const RustControl.State Hovered = 2;
	public const RustControl.State Pressed = 4;
	public const RustControl.State Active = 8;
	public const RustControl.State Disabled = 16;

}

