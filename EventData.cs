public class EventDataAttribute : Attribute // TypeDefIndex: 1515
{	// Fields
	private EventLevel level; // 0x10
	private EventOpcode opcode; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventKeywords <Keywords>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventTags <Tags>k__BackingField; // 0x28

	// Properties
	public string Name { get; }
	internal EventLevel Level { get; }
	internal EventOpcode Opcode { get; }
	internal EventKeywords Keywords { get; }
	internal EventTags Tags { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Name() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal EventLevel get_Level() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	internal EventOpcode get_Opcode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal EventKeywords get_Keywords() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal EventTags get_Tags() { }

}

public class AxisEventData : BaseEventData // TypeDefIndex: 5046
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10B06D0 Offset: 0x10AFAD0 VA: 0x1810B06D0
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE87960 Offset: 0xE86D60 VA: 0x180E87960
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x10B0630 Offset: 0x10AFA30 VA: 0x1810B0630
	public void .ctor(EventSystem eventSystem) { }

}

public abstract class AbstractEventData // TypeDefIndex: 5047
{	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x10AFE70 Offset: 0x10AF270 VA: 0x1810AFE70 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x101B920 Offset: 0x101AD20 VA: 0x18101B920 Slot: 5
	public virtual void Use() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class BaseEventData : AbstractEventData // TypeDefIndex: 5048
{	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0xE51D90 Offset: 0xE51190 VA: 0x180E51D90
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0xE51DB0 Offset: 0xE511B0 VA: 0x180E51DB0
	public GameObject get_selectedObject() { }

	// RVA: 0x10B0720 Offset: 0x10AFB20 VA: 0x1810B0720
	public void set_selectedObject(GameObject value) { }

}

public class PointerEventData : BaseEventData // TypeDefIndex: 5049
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0x90
	public List<GameObject> hovered; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <eligibleForClick>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <pointerId>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <position>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <delta>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <pressPosition>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <worldPosition>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <worldNormal>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <clickTime>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <clickCount>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 <scrollDelta>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <useDragThreshold>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <dragging>k__BackingField; // 0x129
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PointerEventData.InputButton <button>k__BackingField; // 0x12C

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x85980 Offset: 0x84D80 VA: 0x180085980
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x85A40 Offset: 0x84E40 VA: 0x180085A40
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2C30 Offset: 0x10C2030 VA: 0x1810C2C30
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2E20 Offset: 0x10C2220 VA: 0x1810C2E20
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2C60 Offset: 0x10C2060 VA: 0x1810C2C60
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2E60 Offset: 0x10C2260 VA: 0x1810C2E60
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2B80 Offset: 0x10C1F80 VA: 0x1810C2B80
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2E10 Offset: 0x10C2210 VA: 0x1810C2E10
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074C90 Offset: 0x1074090 VA: 0x181074C90
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DD0 Offset: 0x10741D0 VA: 0x181074DD0
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2CA0 Offset: 0x10C20A0 VA: 0x1810C2CA0
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2F40 Offset: 0x10C2340 VA: 0x1810C2F40
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2B50 Offset: 0x10C1F50 VA: 0x1810C2B50
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2DF0 Offset: 0x10C21F0 VA: 0x1810C2DF0
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2D60 Offset: 0x10C2160 VA: 0x1810C2D60
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2F50 Offset: 0x10C2350 VA: 0x1810C2F50
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2DC0 Offset: 0x10C21C0 VA: 0x1810C2DC0
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2FA0 Offset: 0x10C23A0 VA: 0x1810C2FA0
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2DA0 Offset: 0x10C21A0 VA: 0x1810C2DA0
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2F80 Offset: 0x10C2380 VA: 0x1810C2F80
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2B40 Offset: 0x10C1F40 VA: 0x1810C2B40
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2DE0 Offset: 0x10C21E0 VA: 0x1810C2DE0
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D70 Offset: 0x1074170 VA: 0x181074D70
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F10 Offset: 0x1074310 VA: 0x181074F10
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2D80 Offset: 0x10C2180 VA: 0x1810C2D80
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2F60 Offset: 0x10C2360 VA: 0x1810C2F60
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE61350 Offset: 0xE60750 VA: 0x180E61350
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2F70 Offset: 0x10C2370 VA: 0x1810C2F70
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2B70 Offset: 0x10C1F70 VA: 0x1810C2B70
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10C2E00 Offset: 0x10C2200 VA: 0x1810C2E00
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62520 Offset: 0xC61920 VA: 0x180C62520
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F40 Offset: 0x1074340 VA: 0x181074F40
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x10C29D0 Offset: 0x10C1DD0 VA: 0x1810C29D0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x10C26A0 Offset: 0x10C1AA0 VA: 0x1810C26A0
	public bool IsPointerMoving() { }

	// RVA: 0x10C26D0 Offset: 0x10C1AD0 VA: 0x1810C26D0
	public bool IsScrolling() { }

	// RVA: 0x10C2B90 Offset: 0x10C1F90 VA: 0x1810C2B90
	public Camera get_enterEventCamera() { }

	// RVA: 0x10C2CC0 Offset: 0x10C20C0 VA: 0x1810C2CC0
	public Camera get_pressEventCamera() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public GameObject get_pointerPress() { }

	// RVA: 0x10C2EA0 Offset: 0x10C22A0 VA: 0x1810C2EA0
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x10C2700 Offset: 0x10C1B00 VA: 0x1810C2700 Slot: 3
	public override string ToString() { }

}

public enum PointerEventData.InputButton // TypeDefIndex: 5050
{	// Fields
	public int value__; // 0x0
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;

}

public enum PointerEventData.FramePressState // TypeDefIndex: 5051
{	// Fields
	public int value__; // 0x0
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;

}

public class TimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6543
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float duration; // 0x14
	public float durationMax; // 0x18

	// Methods

	// RVA: 0x1EE9C10 Offset: 0x1EE9010 VA: 0x181EE9C10
	public static void ResetToPool(TimerAIEventData instance) { }

	// RVA: 0x1EE9C90 Offset: 0x1EE9090 VA: 0x181EE9C90
	public void ResetToPool() { }

	// RVA: 0x1EE9970 Offset: 0x1EE8D70 VA: 0x181EE9970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(TimerAIEventData instance) { }

	// RVA: 0x1EE8B70 Offset: 0x1EE7F70 VA: 0x181EE8B70
	public TimerAIEventData Copy() { }

	// RVA: 0x1EE9170 Offset: 0x1EE8570 VA: 0x181EE9170
	public static TimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EE8BE0 Offset: 0x1EE7FE0 VA: 0x181EE8BE0
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE8EB0 Offset: 0x1EE82B0 VA: 0x181EE8EB0
	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE9330 Offset: 0x1EE8730 VA: 0x181EE9330
	public static TimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EE9A70 Offset: 0x1EE8E70 VA: 0x181EE9A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEA160 Offset: 0x1EE9560 VA: 0x181EEA160 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEA180 Offset: 0x1EE9580 VA: 0x181EEA180 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	// RVA: 0x1EE9BF0 Offset: 0x1EE8FF0 VA: 0x181EE9BF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE95A0 Offset: 0x1EE89A0 VA: 0x181EE95A0
	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EE97F0 Offset: 0x1EE8BF0 VA: 0x181EE97F0
	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE8C60 Offset: 0x1EE8060 VA: 0x181EE8C60
	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE8F40 Offset: 0x1EE8340 VA: 0x181EE8F40
	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE9D10 Offset: 0x1EE9110 VA: 0x181EE9D10
	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	// RVA: 0x1EEA050 Offset: 0x1EE9450 VA: 0x181EEA050
	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x1EEA150 Offset: 0x1EE9550 VA: 0x181EEA150
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEA160 Offset: 0x1EE9560 VA: 0x181EEA160
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE9F40 Offset: 0x1EE9340 VA: 0x181EE9F40
	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	// RVA: 0x1EE9E90 Offset: 0x1EE9290 VA: 0x181EE9E90
	public static void SerializeLengthDelimited(Stream stream, TimerAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class HealthBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6545
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float healthFraction; // 0x14

	// Methods

	// RVA: 0x1D5ED60 Offset: 0x1D5E160 VA: 0x181D5ED60
	public static void ResetToPool(HealthBelowAIEventData instance) { }

	// RVA: 0x1D5EDE0 Offset: 0x1D5E1E0 VA: 0x181D5EDE0
	public void ResetToPool() { }

	// RVA: 0x1D5EC30 Offset: 0x1D5E030 VA: 0x181D5EC30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(HealthBelowAIEventData instance) { }

	// RVA: 0x1D5E2A0 Offset: 0x1D5D6A0 VA: 0x181D5E2A0
	public HealthBelowAIEventData Copy() { }

	// RVA: 0x1D5E840 Offset: 0x1D5DC40 VA: 0x181D5E840
	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1D5E310 Offset: 0x1D5D710 VA: 0x181D5E310
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5E5B0 Offset: 0x1D5D9B0 VA: 0x181D5E5B0
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5EA10 Offset: 0x1D5DE10 VA: 0x181D5EA10
	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1D5ED20 Offset: 0x1D5E120 VA: 0x181D5ED20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5F230 Offset: 0x1D5E630 VA: 0x181D5F230 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5F250 Offset: 0x1D5E650 VA: 0x181D5F250 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	// RVA: 0x1D5ED40 Offset: 0x1D5E140 VA: 0x181D5ED40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5EB30 Offset: 0x1D5DF30 VA: 0x181D5EB30
	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1D5E8C0 Offset: 0x1D5DCC0 VA: 0x181D5E8C0
	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D5E390 Offset: 0x1D5D790 VA: 0x181D5E390
	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D5E640 Offset: 0x1D5DA40 VA: 0x181D5E640
	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x1D5EE60 Offset: 0x1D5E260 VA: 0x181D5EE60
	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	// RVA: 0x1D5F140 Offset: 0x1D5E540 VA: 0x181D5F140
	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x1D5F220 Offset: 0x1D5E620 VA: 0x181D5F220
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5F230 Offset: 0x1D5E630 VA: 0x181D5F230
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5F030 Offset: 0x1D5E430 VA: 0x181D5F030
	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	// RVA: 0x1D5EF80 Offset: 0x1D5E380 VA: 0x181D5EF80
	public static void SerializeLengthDelimited(Stream stream, HealthBelowAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class InRangeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C00680 Offset: 0x1BFFA80 VA: 0x181C00680
	public static void ResetToPool(InRangeAIEventData instance) { }

	// RVA: 0x1C00700 Offset: 0x1BFFB00 VA: 0x181C00700
	public void ResetToPool() { }

	// RVA: 0x1C00550 Offset: 0x1BFF950 VA: 0x181C00550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(InRangeAIEventData instance) { }

	// RVA: 0x1BFFBC0 Offset: 0x1BFEFC0 VA: 0x181BFFBC0
	public InRangeAIEventData Copy() { }

	// RVA: 0x1C00160 Offset: 0x1BFF560 VA: 0x181C00160
	public static InRangeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BFFC30 Offset: 0x1BFF030 VA: 0x181BFFC30
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C000D0 Offset: 0x1BFF4D0 VA: 0x181C000D0
	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C00430 Offset: 0x1BFF830 VA: 0x181C00430
	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C00640 Offset: 0x1BFFA40 VA: 0x181C00640
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C00B50 Offset: 0x1BFFF50 VA: 0x181C00B50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C00B70 Offset: 0x1BFFF70 VA: 0x181C00B70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	// RVA: 0x1C00660 Offset: 0x1BFFA60 VA: 0x181C00660 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C001E0 Offset: 0x1BFF5E0 VA: 0x181C001E0
	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C002E0 Offset: 0x1BFF6E0 VA: 0x181C002E0
	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFFCB0 Offset: 0x1BFF0B0 VA: 0x181BFFCB0
	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1BFFED0 Offset: 0x1BFF2D0 VA: 0x181BFFED0
	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C00780 Offset: 0x1BFFB80 VA: 0x181C00780
	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	// RVA: 0x1C00A60 Offset: 0x1BFFE60 VA: 0x181C00A60
	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x1C00B40 Offset: 0x1BFFF40 VA: 0x181C00B40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C00B50 Offset: 0x1BFFF50 VA: 0x181C00B50
	public void ToProto(Stream stream) { }

	// RVA: 0x1C00950 Offset: 0x1BFFD50 VA: 0x181C00950
	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	// RVA: 0x1C008A0 Offset: 0x1BFFCA0 VA: 0x181C008A0
	public static void SerializeLengthDelimited(Stream stream, InRangeAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class HungerAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1BF9D30 Offset: 0x1BF9130 VA: 0x181BF9D30
	public static void ResetToPool(HungerAboveAIEventData instance) { }

	// RVA: 0x1BF9DB0 Offset: 0x1BF91B0 VA: 0x181BF9DB0
	public void ResetToPool() { }

	// RVA: 0x1BF9C00 Offset: 0x1BF9000 VA: 0x181BF9C00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(HungerAboveAIEventData instance) { }

	// RVA: 0x1BF9270 Offset: 0x1BF8670 VA: 0x181BF9270
	public HungerAboveAIEventData Copy() { }

	// RVA: 0x1BF9810 Offset: 0x1BF8C10 VA: 0x181BF9810
	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1BF92E0 Offset: 0x1BF86E0 VA: 0x181BF92E0
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF9580 Offset: 0x1BF8980 VA: 0x181BF9580
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF9AE0 Offset: 0x1BF8EE0 VA: 0x181BF9AE0
	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1BF9CF0 Offset: 0x1BF90F0 VA: 0x181BF9CF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFA200 Offset: 0x1BF9600 VA: 0x181BFA200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFA220 Offset: 0x1BF9620 VA: 0x181BFA220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	// RVA: 0x1BF9D10 Offset: 0x1BF9110 VA: 0x181BF9D10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF99E0 Offset: 0x1BF8DE0 VA: 0x181BF99E0
	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1BF9890 Offset: 0x1BF8C90 VA: 0x181BF9890
	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BF9360 Offset: 0x1BF8760 VA: 0x181BF9360
	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BF9610 Offset: 0x1BF8A10 VA: 0x181BF9610
	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1BF9E30 Offset: 0x1BF9230 VA: 0x181BF9E30
	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	// RVA: 0x1BFA110 Offset: 0x1BF9510 VA: 0x181BFA110
	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x1BFA1F0 Offset: 0x1BF95F0 VA: 0x181BFA1F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFA200 Offset: 0x1BF9600 VA: 0x181BFA200
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFA000 Offset: 0x1BF9400 VA: 0x181BFA000
	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	// RVA: 0x1BF9F50 Offset: 0x1BF9350 VA: 0x181BF9F50
	public static void SerializeLengthDelimited(Stream stream, HungerAboveAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class TirednessAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EEADD0 Offset: 0x1EEA1D0 VA: 0x181EEADD0
	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEAE50 Offset: 0x1EEA250 VA: 0x181EEAE50
	public void ResetToPool() { }

	// RVA: 0x1EEACA0 Offset: 0x1EEA0A0 VA: 0x181EEACA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEA310 Offset: 0x1EE9710 VA: 0x181EEA310
	public TirednessAboveAIEventData Copy() { }

	// RVA: 0x1EEAA00 Offset: 0x1EE9E00 VA: 0x181EEAA00
	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EEA5A0 Offset: 0x1EE99A0 VA: 0x181EEA5A0
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEA820 Offset: 0x1EE9C20 VA: 0x181EEA820
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEAA80 Offset: 0x1EE9E80 VA: 0x181EEAA80
	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EEAD90 Offset: 0x1EEA190 VA: 0x181EEAD90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEB2A0 Offset: 0x1EEA6A0 VA: 0x181EEB2A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEB2C0 Offset: 0x1EEA6C0 VA: 0x181EEB2C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EEADB0 Offset: 0x1EEA1B0 VA: 0x181EEADB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEABA0 Offset: 0x1EE9FA0 VA: 0x181EEABA0
	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EEA8B0 Offset: 0x1EE9CB0 VA: 0x181EEA8B0
	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEA380 Offset: 0x1EE9780 VA: 0x181EEA380
	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEA620 Offset: 0x1EE9A20 VA: 0x181EEA620
	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	// RVA: 0x1EEAED0 Offset: 0x1EEA2D0 VA: 0x181EEAED0
	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	// RVA: 0x1EEB1B0 Offset: 0x1EEA5B0 VA: 0x181EEB1B0
	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEB290 Offset: 0x1EEA690 VA: 0x181EEB290
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEB2A0 Offset: 0x1EEA6A0 VA: 0x181EEB2A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEB0A0 Offset: 0x1EEA4A0 VA: 0x181EEB0A0
	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	// RVA: 0x1EEAFF0 Offset: 0x1EEA3F0 VA: 0x181EEAFF0
	public static void SerializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AmmoBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x200ED90 Offset: 0x200E190 VA: 0x18200ED90
	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	// RVA: 0x200ED10 Offset: 0x200E110 VA: 0x18200ED10
	public void ResetToPool() { }

	// RVA: 0x200EC50 Offset: 0x200E050 VA: 0x18200EC50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(AmmoBelowAIEventData instance) { }

	// RVA: 0x200E2C0 Offset: 0x200D6C0 VA: 0x18200E2C0
	public AmmoBelowAIEventData Copy() { }

	// RVA: 0x200EA80 Offset: 0x200DE80 VA: 0x18200EA80
	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	// RVA: 0x200E330 Offset: 0x200D730 VA: 0x18200E330
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200E7D0 Offset: 0x200DBD0 VA: 0x18200E7D0
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200E960 Offset: 0x200DD60 VA: 0x18200E960
	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x200ECD0 Offset: 0x200E0D0 VA: 0x18200ECD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200F1E0 Offset: 0x200E5E0 VA: 0x18200F1E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200F200 Offset: 0x200E600 VA: 0x18200F200 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	// RVA: 0x200ECF0 Offset: 0x200E0F0 VA: 0x18200ECF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200E860 Offset: 0x200DC60 VA: 0x18200E860
	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	// RVA: 0x200EB00 Offset: 0x200DF00 VA: 0x18200EB00
	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x200E3B0 Offset: 0x200D7B0 VA: 0x18200E3B0
	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x200E5D0 Offset: 0x200D9D0 VA: 0x18200E5D0
	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	// RVA: 0x200EE10 Offset: 0x200E210 VA: 0x18200EE10
	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	// RVA: 0x200F0F0 Offset: 0x200E4F0 VA: 0x18200F0F0
	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x200F1D0 Offset: 0x200E5D0 VA: 0x18200F1D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x200F1E0 Offset: 0x200E5E0 VA: 0x18200F1E0
	public void ToProto(Stream stream) { }

	// RVA: 0x200EFE0 Offset: 0x200E3E0 VA: 0x18200EFE0
	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	// RVA: 0x200EF30 Offset: 0x200E330 VA: 0x18200EF30
	public static void SerializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ThreatDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EE74D0 Offset: 0x1EE68D0 VA: 0x181EE74D0
	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EE7450 Offset: 0x1EE6850 VA: 0x181EE7450
	public void ResetToPool() { }

	// RVA: 0x1EE7320 Offset: 0x1EE6720 VA: 0x181EE7320 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EE6990 Offset: 0x1EE5D90 VA: 0x181EE6990
	public ThreatDetectedAIEventData Copy() { }

	// RVA: 0x1EE72A0 Offset: 0x1EE66A0 VA: 0x181EE72A0
	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EE6A00 Offset: 0x1EE5E00 VA: 0x181EE6A00
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE6CA0 Offset: 0x1EE60A0 VA: 0x181EE6CA0
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE7030 Offset: 0x1EE6430 VA: 0x181EE7030
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EE7410 Offset: 0x1EE6810 VA: 0x181EE7410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE7920 Offset: 0x1EE6D20 VA: 0x181EE7920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE7940 Offset: 0x1EE6D40 VA: 0x181EE7940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EE7430 Offset: 0x1EE6830 VA: 0x181EE7430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE6330 VA: 0x181EE6F30
	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EE7150 Offset: 0x1EE6550 VA: 0x181EE7150
	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE6A80 Offset: 0x1EE5E80 VA: 0x181EE6A80
	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE6D30 Offset: 0x1EE6130 VA: 0x181EE6D30
	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE7550 Offset: 0x1EE6950 VA: 0x181EE7550
	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	// RVA: 0x1EE7830 Offset: 0x1EE6C30 VA: 0x181EE7830
	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EE7910 Offset: 0x1EE6D10 VA: 0x181EE7910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE7920 Offset: 0x1EE6D20 VA: 0x181EE7920
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE7720 Offset: 0x1EE6B20 VA: 0x181EE7720
	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	// RVA: 0x1EE7670 Offset: 0x1EE6A70 VA: 0x181EE7670
	public static void SerializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class TargetDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1DC2530 Offset: 0x1DC1930 VA: 0x181DC2530
	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC24B0 Offset: 0x1DC18B0 VA: 0x181DC24B0
	public void ResetToPool() { }

	// RVA: 0x1DC2380 Offset: 0x1DC1780 VA: 0x181DC2380 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC19F0 Offset: 0x1DC0DF0 VA: 0x181DC19F0
	public TargetDetectedAIEventData Copy() { }

	// RVA: 0x1DC1F90 Offset: 0x1DC1390 VA: 0x181DC1F90
	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1DC1A60 Offset: 0x1DC0E60 VA: 0x181DC1A60
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC1D00 Offset: 0x1DC1100 VA: 0x181DC1D00
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC2110 Offset: 0x1DC1510 VA: 0x181DC2110
	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1DC2470 Offset: 0x1DC1870 VA: 0x181DC2470
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC2980 Offset: 0x1DC1D80 VA: 0x181DC2980 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC29A0 Offset: 0x1DC1DA0 VA: 0x181DC29A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC2490 Offset: 0x1DC1890 VA: 0x181DC2490 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC2010 Offset: 0x1DC1410 VA: 0x181DC2010
	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1DC2230 Offset: 0x1DC1630 VA: 0x181DC2230
	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC1AE0 Offset: 0x1DC0EE0 VA: 0x181DC1AE0
	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC1D90 Offset: 0x1DC1190 VA: 0x181DC1D90
	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1DC25B0 Offset: 0x1DC19B0 VA: 0x181DC25B0
	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	// RVA: 0x1DC2890 Offset: 0x1DC1C90 VA: 0x181DC2890
	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC2970 Offset: 0x1DC1D70 VA: 0x181DC2970
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC2980 Offset: 0x1DC1D80 VA: 0x181DC2980
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC2780 Offset: 0x1DC1B80 VA: 0x181DC2780
	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	// RVA: 0x1DC26D0 Offset: 0x1DC1AD0 VA: 0x181DC26D0
	public static void SerializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ChanceAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6552
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x20A3FA0 Offset: 0x20A33A0 VA: 0x1820A3FA0
	public static void ResetToPool(ChanceAIEventData instance) { }

	// RVA: 0x20A4020 Offset: 0x20A3420 VA: 0x1820A4020
	public void ResetToPool() { }

	// RVA: 0x20A3E70 Offset: 0x20A3270 VA: 0x1820A3E70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ChanceAIEventData instance) { }

	// RVA: 0x20A34E0 Offset: 0x20A28E0 VA: 0x1820A34E0
	public ChanceAIEventData Copy() { }

	// RVA: 0x20A3CA0 Offset: 0x20A30A0 VA: 0x1820A3CA0
	public static ChanceAIEventData Deserialize(Stream stream) { }

	// RVA: 0x20A3770 Offset: 0x20A2B70 VA: 0x1820A3770
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A37F0 Offset: 0x20A2BF0 VA: 0x1820A37F0
	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A3A80 Offset: 0x20A2E80 VA: 0x1820A3A80
	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x20A3F60 Offset: 0x20A3360 VA: 0x1820A3F60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A4470 Offset: 0x20A3870 VA: 0x1820A4470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A4490 Offset: 0x20A3890 VA: 0x1820A4490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	// RVA: 0x20A3F80 Offset: 0x20A3380 VA: 0x1820A3F80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A3BA0 Offset: 0x20A2FA0 VA: 0x1820A3BA0
	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	// RVA: 0x20A3D20 Offset: 0x20A3120 VA: 0x1820A3D20
	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A3550 Offset: 0x20A2950 VA: 0x1820A3550
	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A3880 Offset: 0x20A2C80 VA: 0x1820A3880
	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	// RVA: 0x20A40A0 Offset: 0x20A34A0 VA: 0x1820A40A0
	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	// RVA: 0x20A4380 Offset: 0x20A3780 VA: 0x1820A4380
	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x20A4460 Offset: 0x20A3860 VA: 0x1820A4460
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A4470 Offset: 0x20A3870 VA: 0x1820A4470
	public void ToProto(Stream stream) { }

	// RVA: 0x20A4270 Offset: 0x20A3670 VA: 0x1820A4270
	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	// RVA: 0x20A41C0 Offset: 0x20A35C0 VA: 0x1820A41C0
	public static void SerializeLengthDelimited(Stream stream, ChanceAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class TimeSinceThreatAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6553
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1EE85C0 Offset: 0x1EE79C0 VA: 0x181EE85C0
	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EE8540 Offset: 0x1EE7940 VA: 0x181EE8540
	public void ResetToPool() { }

	// RVA: 0x1EE8410 Offset: 0x1EE7810 VA: 0x181EE8410 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EE7A80 Offset: 0x1EE6E80 VA: 0x181EE7A80
	public TimeSinceThreatAIEventData Copy() { }

	// RVA: 0x1EE8120 Offset: 0x1EE7520 VA: 0x181EE8120
	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EE7AF0 Offset: 0x1EE6EF0 VA: 0x181EE7AF0
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE7D90 Offset: 0x1EE7190 VA: 0x181EE7D90
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE81A0 Offset: 0x1EE75A0 VA: 0x181EE81A0
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EE8500 Offset: 0x1EE7900 VA: 0x181EE8500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE8A10 Offset: 0x1EE7E10 VA: 0x181EE8A10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE8A30 Offset: 0x1EE7E30 VA: 0x181EE8A30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EE8520 Offset: 0x1EE7920 VA: 0x181EE8520 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE8020 Offset: 0x1EE7420 VA: 0x181EE8020
	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EE82C0 Offset: 0x1EE76C0 VA: 0x181EE82C0
	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE7B70 Offset: 0x1EE6F70 VA: 0x181EE7B70
	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE7E20 Offset: 0x1EE7220 VA: 0x181EE7E20
	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	// RVA: 0x1EE8640 Offset: 0x1EE7A40 VA: 0x181EE8640
	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	// RVA: 0x1EE8920 Offset: 0x1EE7D20 VA: 0x181EE8920
	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EE8A00 Offset: 0x1EE7E00 VA: 0x181EE8A00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE8A10 Offset: 0x1EE7E10 VA: 0x181EE8A10
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE8810 Offset: 0x1EE7C10 VA: 0x181EE8810
	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	// RVA: 0x1EE8760 Offset: 0x1EE7B60 VA: 0x181EE8760
	public static void SerializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AggressionTimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6554
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x200DDB0 Offset: 0x200D1B0 VA: 0x18200DDB0
	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	// RVA: 0x200DE30 Offset: 0x200D230 VA: 0x18200DE30
	public void ResetToPool() { }

	// RVA: 0x200DCF0 Offset: 0x200D0F0 VA: 0x18200DCF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(AggressionTimerAIEventData instance) { }

	// RVA: 0x200D360 Offset: 0x200C760 VA: 0x18200D360
	public AggressionTimerAIEventData Copy() { }

	// RVA: 0x200DC70 Offset: 0x200D070 VA: 0x18200DC70
	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	// RVA: 0x200D5F0 Offset: 0x200C9F0 VA: 0x18200D5F0
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200D670 Offset: 0x200CA70 VA: 0x18200D670
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200DB50 Offset: 0x200CF50 VA: 0x18200DB50
	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x200DD70 Offset: 0x200D170 VA: 0x18200DD70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200E280 Offset: 0x200D680 VA: 0x18200E280 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200E2A0 Offset: 0x200D6A0 VA: 0x18200E2A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	// RVA: 0x200DD90 Offset: 0x200D190 VA: 0x18200DD90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200D900 Offset: 0x200CD00 VA: 0x18200D900
	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	// RVA: 0x200DA00 Offset: 0x200CE00 VA: 0x18200DA00
	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x200D3D0 Offset: 0x200C7D0 VA: 0x18200D3D0
	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x200D700 Offset: 0x200CB00 VA: 0x18200D700
	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	// RVA: 0x200DEB0 Offset: 0x200D2B0 VA: 0x18200DEB0
	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	// RVA: 0x200E190 Offset: 0x200D590 VA: 0x18200E190
	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x200E270 Offset: 0x200D670 VA: 0x18200E270
	public byte[] ToProtoBytes() { }

	// RVA: 0x200E280 Offset: 0x200D680 VA: 0x18200E280
	public void ToProto(Stream stream) { }

	// RVA: 0x200E080 Offset: 0x200D480 VA: 0x18200E080
	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	// RVA: 0x200DFD0 Offset: 0x200D3D0 VA: 0x18200DFD0
	public static void SerializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class InRangeOfHomeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6556
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1C017F0 Offset: 0x1C00BF0 VA: 0x181C017F0
	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C01770 Offset: 0x1C00B70 VA: 0x181C01770
	public void ResetToPool() { }

	// RVA: 0x1C01640 Offset: 0x1C00A40 VA: 0x181C01640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C00CB0 Offset: 0x1C000B0 VA: 0x181C00CB0
	public InRangeOfHomeAIEventData Copy() { }

	// RVA: 0x1C01250 Offset: 0x1C00650 VA: 0x181C01250
	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1C00F40 Offset: 0x1C00340 VA: 0x181C00F40
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C00FC0 Offset: 0x1C003C0 VA: 0x181C00FC0
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C01520 Offset: 0x1C00920 VA: 0x181C01520
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1C01730 Offset: 0x1C00B30 VA: 0x181C01730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C01C40 Offset: 0x1C01040 VA: 0x181C01C40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C01C60 Offset: 0x1C01060 VA: 0x181C01C60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C01750 Offset: 0x1C00B50 VA: 0x181C01750 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C012D0 Offset: 0x1C006D0 VA: 0x181C012D0
	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1C013D0 Offset: 0x1C007D0 VA: 0x181C013D0
	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C00D20 Offset: 0x1C00120 VA: 0x181C00D20
	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C01050 Offset: 0x1C00450 VA: 0x181C01050
	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	// RVA: 0x1C01870 Offset: 0x1C00C70 VA: 0x181C01870
	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	// RVA: 0x1C01B50 Offset: 0x1C00F50 VA: 0x181C01B50
	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C01C30 Offset: 0x1C01030 VA: 0x181C01C30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C01C40 Offset: 0x1C01040 VA: 0x181C01C40
	public void ToProto(Stream stream) { }

	// RVA: 0x1C01A40 Offset: 0x1C00E40 VA: 0x181C01A40
	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	// RVA: 0x1C01990 Offset: 0x1C00D90 VA: 0x181C01990
	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

internal struct ColorEventData // TypeDefIndex: 7701
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Value>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ColorEventFrame <Frame>k__BackingField; // 0x4

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE5D0 Offset: 0xBD9D0 VA: 0x1800BE5D0
	public float Value { get; set; }
	[JsonPropertyAttribute] // RVA: 0xBE750 Offset: 0xBDB50 VA: 0x1800BE750
	public ColorEventFrame Frame { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280
	public void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236C00 Offset: 0x236000 VA: 0x180236C00
	public ColorEventFrame get_Frame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236C20 Offset: 0x236020 VA: 0x180236C20
	public void set_Frame(ColorEventFrame value) { }

}

internal struct EmptyEventData // TypeDefIndex: 7704
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Value>k__BackingField; // 0x0

	// Properties
	[JsonPropertyAttribute] // RVA: 0xBE5D0 Offset: 0xBD9D0 VA: 0x1800BE5D0
	public int Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_Value(int value) { }

}

