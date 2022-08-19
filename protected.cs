protected internal struct EventSource.EventData // TypeDefIndex: 1581
{	// Fields
	internal long m_Ptr; // 0x0
	internal int m_Size; // 0x8
	internal int m_Reserved; // 0xC

	// Properties
	public IntPtr DataPointer { get; set; }
	public int Size { set; }

	// Methods

	// RVA: 0x19F3C0 Offset: 0x19E7C0 VA: 0x18019F3C0
	public IntPtr get_DataPointer() { }

	// RVA: 0x19F3D0 Offset: 0x19E7D0 VA: 0x18019F3D0
	public void set_DataPointer(IntPtr value) { }

	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	public void set_Size(int value) { }

	// RVA: 0x19F330 Offset: 0x19E730 VA: 0x18019F330
	internal void SetMetadata(byte* pointer, int size, int reserved) { }

}

protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 2098
{	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Properties
	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }

	// Methods

	// RVA: 0x1682BC0 Offset: 0x1681FC0 VA: 0x181682BC0
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object get_Collection() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal object get_Id() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public object get_CollectionItems() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_CollectionItems(object value) { }

}

protected class XmlSerializationReader.Fixup // TypeDefIndex: 2099
{	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Properties
	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }

	// Methods

	// RVA: 0x1682C70 Offset: 0x1682070 VA: 0x181682C70
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string[] get_Ids() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public object get_Source() { }

}

protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2752
{	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x172EC60 Offset: 0x172E060 VA: 0x18172EC60
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x172ECC0 Offset: 0x172E0C0 VA: 0x18172ECC0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 4922
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text m_Text; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Toggle m_Toggle; // 0x30

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Text get_text() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_text(Text value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Image get_image() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_image(Image value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public RectTransform get_rectTransform() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public Toggle get_toggle() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_toggle(Toggle value) { }

	// RVA: 0x15E5470 Offset: 0x15E4870 VA: 0x1815E5470 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x15E53E0 Offset: 0x15E47E0 VA: 0x1815E53E0 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

protected enum InputField.EditState // TypeDefIndex: 4954
{	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;

}

protected enum Selectable.SelectionState // TypeDefIndex: 5005
{	// Fields
	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;

}

protected class PointerInputModule.ButtonState // TypeDefIndex: 5082
{	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

protected class PointerInputModule.MouseState // TypeDefIndex: 5083
{	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x10C1120 Offset: 0x10C0520 VA: 0x1810C1120
	public bool AnyPressesThisFrame() { }

	// RVA: 0x10C11E0 Offset: 0x10C05E0 VA: 0x1810C11E0
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x10C12A0 Offset: 0x10C06A0 VA: 0x1810C12A0
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x10C13F0 Offset: 0x10C07F0 VA: 0x1810C13F0
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x10C1450 Offset: 0x10C0850 VA: 0x1810C1450
	public void .ctor() { }

}

protected internal enum JsonReader.State // TypeDefIndex: 5903
{	// Fields
	public int value__; // 0x0
	public const JsonReader.State Start = 0;
	public const JsonReader.State Complete = 1;
	public const JsonReader.State Property = 2;
	public const JsonReader.State ObjectStart = 3;
	public const JsonReader.State Object = 4;
	public const JsonReader.State ArrayStart = 5;
	public const JsonReader.State Array = 6;
	public const JsonReader.State Closed = 7;
	public const JsonReader.State PostValue = 8;
	public const JsonReader.State ConstructorStart = 9;
	public const JsonReader.State Constructor = 10;
	public const JsonReader.State Error = 11;
	public const JsonReader.State Finished = 12;

}

protected enum TMP_InputField.EditState // TypeDefIndex: 6794
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;

}

protected struct TMP_Text.UnicodeChar // TypeDefIndex: 6838
{	// Fields
	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8

}

protected static class AnimalAnimation.Params // TypeDefIndex: 9114
{	// Fields
	public static int WalkSpeed; // 0x0
	public static int Sleeping; // 0x4

	// Methods

	// RVA: 0x83A460 Offset: 0x839860 VA: 0x18083A460
	private static void .cctor() { }

}

protected class ViewShake.ShakeParameters // TypeDefIndex: 9252
{	// Fields
	public float endTime; // 0x10
	public float duration; // 0x14
	public float amplitude; // 0x18
	public float frequency; // 0x1C
	public float nextShake; // 0x20
	public float angle; // 0x24
	public Vector3 offset; // 0x28
	public bool infinite; // 0x34

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

protected struct BaseFootstepEffect.GroundInfo // TypeDefIndex: 9327
{	// Fields
	public string surface; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14

	// Methods

	// RVA: 0xFB450 Offset: 0xFA850 VA: 0x1800FB450
	public GameObject SpawnDecal(string effectType) { }

	// RVA: 0xFB630 Offset: 0xFAA30 VA: 0x1800FB630
	public GameObject SpawnEffect(string effectType) { }

	// RVA: 0xFB540 Offset: 0xFA940 VA: 0x1800FB540
	public GameObject SpawnDisplacement(string effectType) { }

}

protected enum VehicleChassisVisuals.ExtensionMode<T> // TypeDefIndex: 9783
{	// Fields
	public int value__; // 0x0
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMinExtension = 0;
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMaxExtension = 1;

}

