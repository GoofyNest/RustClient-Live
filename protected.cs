protected internal struct EventSource.EventData // TypeDefIndex: 1581
{
	internal long m_Ptr;
	internal int m_Size;
	internal int m_Reserved;

	public IntPtr DataPointer { get; set; }
	public int Size { set; }


	public IntPtr get_DataPointer() { }

	public void set_DataPointer(IntPtr value) { }

	public void set_Size(int value) { }

	internal void SetMetadata(byte* pointer, int size, int reserved) { }

}

protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 2098
{
	private XmlSerializationCollectionFixupCallback callback;
	private object collection;
	private object collectionItems;
	private string id;

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
{
	private object source;
	private string[] ids;
	private XmlSerializationFixupCallback callback;

	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }


	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	public XmlSerializationFixupCallback get_Callback() { }

	public string[] get_Ids() { }

	public object get_Source() { }

}

protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2752
{
	private Type componentType;
	private Type propertyType;

	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	public override bool ShouldSerializeValue(object component) { }

}

protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 4928
{
	[SerializeField]
	private Text m_Text;
	[SerializeField]
	private Image m_Image;
	[SerializeField]
	private RectTransform m_RectTransform;
	[SerializeField]
	private Toggle m_Toggle;

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

protected enum InputField.EditState // TypeDefIndex: 4960
{
	public int value__;
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;

}

protected enum Selectable.SelectionState // TypeDefIndex: 5011
{
	public int value__;
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;

}

protected class PointerInputModule.ButtonState // TypeDefIndex: 5088
{
	private PointerEventData.InputButton m_Button;
	private PointerInputModule.MouseButtonEventData m_EventData;

	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }


	public PointerInputModule.MouseButtonEventData get_eventData() { }

	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	public PointerEventData.InputButton get_button() { }

	public void set_button(PointerEventData.InputButton value) { }

	public void .ctor() { }

}

protected class PointerInputModule.MouseState // TypeDefIndex: 5089
{
	private List<PointerInputModule.ButtonState> m_TrackedButtons;


	public bool AnyPressesThisFrame() { }

	public bool AnyReleasesThisFrame() { }

	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	public void .ctor() { }

}

protected internal enum JsonReader.State // TypeDefIndex: 5912
{
	public int value__;
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

protected enum TMP_InputField.EditState // TypeDefIndex: 6738
{
	public int value__;
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;

}

protected struct TMP_Text.UnicodeChar // TypeDefIndex: 6782
{
	public int unicode;
	public int stringIndex;
	public int length;

}

protected static class AnimalAnimation.Params // TypeDefIndex: 10853
{
	public static int WalkSpeed;
	public static int Sleeping;
	public static int IdleOffset;


	private static void .cctor() { }

}

protected class ViewShake.ShakeParameters // TypeDefIndex: 10997
{
	public float endTime;
	public float duration;
	public float amplitude;
	public float frequency;
	public float nextShake;
	public float angle;
	public Vector3 offset;
	public bool infinite;


	public void .ctor() { }

}

protected struct BaseFootstepEffect.GroundInfo // TypeDefIndex: 11077
{
	public string surface;
	public Vector3 position;
	public Quaternion rotation;


	public GameObject SpawnDecal(string effectType) { }

	public GameObject SpawnEffect(string effectType) { }

	public GameObject SpawnDisplacement(string effectType) { }

}

protected enum VehicleChassisVisuals.ExtensionMode<T> // TypeDefIndex: 11536
{
	public int value__;
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMinExtension = 0;
	public const VehicleChassisVisuals.ExtensionMode<T> RestingIsMaxExtension = 1;

}

