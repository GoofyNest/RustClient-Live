protected internal struct EventSource.EventData // TypeDefIndex: 1581
{	internal long m_Ptr; // 0x0
	internal int m_Size; // 0x8
	internal int m_Reserved; // 0xC

	public IntPtr DataPointer { get; set; }
	public int Size { set; }


	public IntPtr get_DataPointer() { }

	public void set_DataPointer(IntPtr value) { }

	public void set_Size(int value) { }

	internal void SetMetadata(byte* pointer, int size, int reserved) { }

}

protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 2098
{	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }


	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	public XmlSerializationCollectionFixupCallback get_Callback() { }

	public object get_Collection() { }

	internal object get_Id() { }

	public object get_CollectionItems() { }

	internal void set_CollectionItems(object value) { }

}

protected class XmlSerializationReader.Fixup // TypeDefIndex: 2099
{	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }


	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	public XmlSerializationFixupCallback get_Callback() { }

	public string[] get_Ids() { }

	public object get_Source() { }

}

protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2752
{	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	public override bool ShouldSerializeValue(object component) { }

}

protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 4922
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text m_Text; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Toggle m_Toggle; // 0x30

	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }


	public Text get_text() { }

	public void set_text(Text value) { }

	public Image get_image() { }

	public void set_image(Image value) { }

	public RectTransform get_rectTransform() { }

	public void set_rectTransform(RectTransform value) { }

	public Toggle get_toggle() { }

	public void set_toggle(Toggle value) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnCancel(BaseEventData eventData) { }

	public void .ctor() { }

}

protected enum InputField.EditState // TypeDefIndex: 4954
{	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;

}

protected enum Selectable.SelectionState // TypeDefIndex: 5005
{	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;

}

protected class PointerInputModule.ButtonState // TypeDefIndex: 5082
{	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }


	public PointerInputModule.MouseButtonEventData get_eventData() { }

	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	public PointerEventData.InputButton get_button() { }

	public void set_button(PointerEventData.InputButton value) { }

	public void .ctor() { }

}

protected class PointerInputModule.MouseState // TypeDefIndex: 5083
{	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10


	public bool AnyPressesThisFrame() { }

	public bool AnyReleasesThisFrame() { }

	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	public void .ctor() { }

}

protected internal enum JsonReader.State // TypeDefIndex: 5903
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;

}

protected struct TMP_Text.UnicodeChar // TypeDefIndex: 6838
{	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8

}

protected static class AnimalAnimation.Params // TypeDefIndex: 9114
{	public static int WalkSpeed; // 0x0
	public static int Sleeping; // 0x4


	private static void .cctor() { }

}

protected class ViewShake.ShakeParameters // TypeDefIndex: 9252
{	public float endTime; // 0x10
	public float duration; // 0x14
	public float amplitude; // 0x18
	public float frequency; // 0x1C
	public float nextShake; // 0x20
	public float angle; // 0x24
	public Vector3 offset; // 0x28
	public bool infinite; // 0x34


	public void .ctor() { }

}

protected struct BaseFootstepEffect.GroundInfo // TypeDefIndex: 9327
{	public string surface; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14


	public GameObject SpawnDecal(string effectType) { }

	public GameObject SpawnEffect(string effectType) { }

	public GameObject SpawnDisplacement(string effectType) { }

}

protected enum VehicleChassisVisuals.ExtensionMode<T> // TypeDefIndex: 9783
{	public int value__; // 0x0
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMinExtension = 0;
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMaxExtension = 1;

}

