public class EventDataAttribute : Attribute // TypeDefIndex: 1515
{
	private EventLevel level; 
	private EventOpcode opcode; 
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventKeywords <Keywords>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventTags <Tags>k__BackingField; 

	public string Name { get; }
	internal EventLevel Level { get; }
	internal EventOpcode Opcode { get; }
	internal EventKeywords Keywords { get; }
	internal EventTags Tags { get; }


	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	internal EventLevel get_Level() { }

	internal EventOpcode get_Opcode() { }

	[CompilerGeneratedAttribute] 
	internal EventKeywords get_Keywords() { }

	[CompilerGeneratedAttribute] 
	internal EventTags get_Tags() { }

}

public class AxisEventData : BaseEventData // TypeDefIndex: 5047
{
	[CompilerGeneratedAttribute] 
	private Vector2 <moveVector>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MoveDirection <moveDir>k__BackingField; 

	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }


	[CompilerGeneratedAttribute] 
	public Vector2 get_moveVector() { }

	[CompilerGeneratedAttribute] 
	public void set_moveVector(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public MoveDirection get_moveDir() { }

	[CompilerGeneratedAttribute] 
	public void set_moveDir(MoveDirection value) { }

	public void .ctor(EventSystem eventSystem) { }

}

public abstract class AbstractEventData // TypeDefIndex: 5048
{
	protected bool m_Used; 

	public virtual bool used { get; }


	public virtual void Reset() { }

	public virtual void Use() { }

	public virtual bool get_used() { }

	protected void .ctor() { }

}

public class BaseEventData : AbstractEventData // TypeDefIndex: 5049
{
	private readonly EventSystem m_EventSystem; 

	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }


	public void .ctor(EventSystem eventSystem) { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_selectedObject() { }

	public void set_selectedObject(GameObject value) { }

}

public class PointerEventData : BaseEventData // TypeDefIndex: 5050
{
	[CompilerGeneratedAttribute] 
	private GameObject <pointerEnter>k__BackingField; 
	private GameObject m_PointerPress; 
	[CompilerGeneratedAttribute] 
	private GameObject <lastPress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private GameObject <rawPointerPress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private GameObject <pointerDrag>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private RaycastResult <pointerCurrentRaycast>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private RaycastResult <pointerPressRaycast>k__BackingField; 
	public List<GameObject> hovered; 
	[CompilerGeneratedAttribute] 
	private bool <eligibleForClick>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <pointerId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector2 <position>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector2 <delta>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector2 <pressPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <worldPosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <worldNormal>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <clickTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <clickCount>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector2 <scrollDelta>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <useDragThreshold>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <dragging>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PointerEventData.InputButton <button>k__BackingField; 

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
	[ObsoleteAttribute] 
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] 
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


	[CompilerGeneratedAttribute] 
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] 
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] 
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] 
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] 
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] 
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] 
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] 
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] 
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] 
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] 
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] 
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] 
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] 
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] 
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] 
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] 
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] 
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] 
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] 
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] 
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] 
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] 
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] 
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] 
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] 
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] 
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] 
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] 
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] 
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] 
	public void set_button(PointerEventData.InputButton value) { }

	public void .ctor(EventSystem eventSystem) { }

	public bool IsPointerMoving() { }

	public bool IsScrolling() { }

	public Camera get_enterEventCamera() { }

	public Camera get_pressEventCamera() { }

	public GameObject get_pointerPress() { }

	public void set_pointerPress(GameObject value) { }

	public override string ToString() { }

}

public enum PointerEventData.InputButton // TypeDefIndex: 5051
{
	public int value__; 
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;

}

public enum PointerEventData.FramePressState // TypeDefIndex: 5052
{
	public int value__; 
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;

}

public class TimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float duration; 
	public float durationMax; 


	public static void ResetToPool(TimerAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TimerAIEventData instance) { }

	public TimerAIEventData Copy() { }

	public static TimerAIEventData Deserialize(Stream stream) { }

	public static TimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static TimerAIEventData DeserializeLength(Stream stream, int length) { }

	public static TimerAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TimerAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TimerAIEventData Deserialize(byte[] buffer, TimerAIEventData instance, bool isDelta = False) { }

	public static TimerAIEventData Deserialize(Stream stream, TimerAIEventData instance, bool isDelta) { }

	public static TimerAIEventData DeserializeLengthDelimited(Stream stream, TimerAIEventData instance, bool isDelta) { }

	public static TimerAIEventData DeserializeLength(Stream stream, int length, TimerAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TimerAIEventData instance, TimerAIEventData previous) { }

	public static void Serialize(Stream stream, TimerAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TimerAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, TimerAIEventData instance) { }

	public void .ctor() { }

}

public class HealthBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float healthFraction; 


	public static void ResetToPool(HealthBelowAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(HealthBelowAIEventData instance) { }

	public HealthBelowAIEventData Copy() { }

	public static HealthBelowAIEventData Deserialize(Stream stream) { }

	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length) { }

	public static HealthBelowAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, HealthBelowAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static HealthBelowAIEventData Deserialize(byte[] buffer, HealthBelowAIEventData instance, bool isDelta = False) { }

	public static HealthBelowAIEventData Deserialize(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	public static HealthBelowAIEventData DeserializeLengthDelimited(Stream stream, HealthBelowAIEventData instance, bool isDelta) { }

	public static HealthBelowAIEventData DeserializeLength(Stream stream, int length, HealthBelowAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, HealthBelowAIEventData instance, HealthBelowAIEventData previous) { }

	public static void Serialize(Stream stream, HealthBelowAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(HealthBelowAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, HealthBelowAIEventData instance) { }

	public void .ctor() { }

}

public class InRangeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float range; 


	public static void ResetToPool(InRangeAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InRangeAIEventData instance) { }

	public InRangeAIEventData Copy() { }

	public static InRangeAIEventData Deserialize(Stream stream) { }

	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static InRangeAIEventData DeserializeLength(Stream stream, int length) { }

	public static InRangeAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InRangeAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InRangeAIEventData Deserialize(byte[] buffer, InRangeAIEventData instance, bool isDelta = False) { }

	public static InRangeAIEventData Deserialize(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	public static InRangeAIEventData DeserializeLengthDelimited(Stream stream, InRangeAIEventData instance, bool isDelta) { }

	public static InRangeAIEventData DeserializeLength(Stream stream, int length, InRangeAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InRangeAIEventData instance, InRangeAIEventData previous) { }

	public static void Serialize(Stream stream, InRangeAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InRangeAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, InRangeAIEventData instance) { }

	public void .ctor() { }

}

public class HungerAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(HungerAboveAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(HungerAboveAIEventData instance) { }

	public HungerAboveAIEventData Copy() { }

	public static HungerAboveAIEventData Deserialize(Stream stream) { }

	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length) { }

	public static HungerAboveAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, HungerAboveAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static HungerAboveAIEventData Deserialize(byte[] buffer, HungerAboveAIEventData instance, bool isDelta = False) { }

	public static HungerAboveAIEventData Deserialize(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	public static HungerAboveAIEventData DeserializeLengthDelimited(Stream stream, HungerAboveAIEventData instance, bool isDelta) { }

	public static HungerAboveAIEventData DeserializeLength(Stream stream, int length, HungerAboveAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, HungerAboveAIEventData instance, HungerAboveAIEventData previous) { }

	public static void Serialize(Stream stream, HungerAboveAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(HungerAboveAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, HungerAboveAIEventData instance) { }

	public void .ctor() { }

}

public class TirednessAboveAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(TirednessAboveAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TirednessAboveAIEventData instance) { }

	public TirednessAboveAIEventData Copy() { }

	public static TirednessAboveAIEventData Deserialize(Stream stream) { }

	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length) { }

	public static TirednessAboveAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TirednessAboveAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TirednessAboveAIEventData Deserialize(byte[] buffer, TirednessAboveAIEventData instance, bool isDelta = False) { }

	public static TirednessAboveAIEventData Deserialize(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	public static TirednessAboveAIEventData DeserializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance, bool isDelta) { }

	public static TirednessAboveAIEventData DeserializeLength(Stream stream, int length, TirednessAboveAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TirednessAboveAIEventData instance, TirednessAboveAIEventData previous) { }

	public static void Serialize(Stream stream, TirednessAboveAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TirednessAboveAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, TirednessAboveAIEventData instance) { }

	public void .ctor() { }

}

public class AmmoBelowAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(AmmoBelowAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AmmoBelowAIEventData instance) { }

	public AmmoBelowAIEventData Copy() { }

	public static AmmoBelowAIEventData Deserialize(Stream stream) { }

	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length) { }

	public static AmmoBelowAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AmmoBelowAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AmmoBelowAIEventData Deserialize(byte[] buffer, AmmoBelowAIEventData instance, bool isDelta = False) { }

	public static AmmoBelowAIEventData Deserialize(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	public static AmmoBelowAIEventData DeserializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance, bool isDelta) { }

	public static AmmoBelowAIEventData DeserializeLength(Stream stream, int length, AmmoBelowAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AmmoBelowAIEventData instance, AmmoBelowAIEventData previous) { }

	public static void Serialize(Stream stream, AmmoBelowAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AmmoBelowAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, AmmoBelowAIEventData instance) { }

	public void .ctor() { }

}

public class ThreatDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float range; 


	public static void ResetToPool(ThreatDetectedAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ThreatDetectedAIEventData instance) { }

	public ThreatDetectedAIEventData Copy() { }

	public static ThreatDetectedAIEventData Deserialize(Stream stream) { }

	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	public static ThreatDetectedAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ThreatDetectedAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ThreatDetectedAIEventData Deserialize(byte[] buffer, ThreatDetectedAIEventData instance, bool isDelta = False) { }

	public static ThreatDetectedAIEventData Deserialize(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	public static ThreatDetectedAIEventData DeserializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance, bool isDelta) { }

	public static ThreatDetectedAIEventData DeserializeLength(Stream stream, int length, ThreatDetectedAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ThreatDetectedAIEventData instance, ThreatDetectedAIEventData previous) { }

	public static void Serialize(Stream stream, ThreatDetectedAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ThreatDetectedAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, ThreatDetectedAIEventData instance) { }

	public void .ctor() { }

}

public class TargetDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6552
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float range; 


	public static void ResetToPool(TargetDetectedAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TargetDetectedAIEventData instance) { }

	public TargetDetectedAIEventData Copy() { }

	public static TargetDetectedAIEventData Deserialize(Stream stream) { }

	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	public static TargetDetectedAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TargetDetectedAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TargetDetectedAIEventData Deserialize(byte[] buffer, TargetDetectedAIEventData instance, bool isDelta = False) { }

	public static TargetDetectedAIEventData Deserialize(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	public static TargetDetectedAIEventData DeserializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance, bool isDelta) { }

	public static TargetDetectedAIEventData DeserializeLength(Stream stream, int length, TargetDetectedAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TargetDetectedAIEventData instance, TargetDetectedAIEventData previous) { }

	public static void Serialize(Stream stream, TargetDetectedAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TargetDetectedAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, TargetDetectedAIEventData instance) { }

	public void .ctor() { }

}

public class ChanceAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6553
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(ChanceAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ChanceAIEventData instance) { }

	public ChanceAIEventData Copy() { }

	public static ChanceAIEventData Deserialize(Stream stream) { }

	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static ChanceAIEventData DeserializeLength(Stream stream, int length) { }

	public static ChanceAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ChanceAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ChanceAIEventData Deserialize(byte[] buffer, ChanceAIEventData instance, bool isDelta = False) { }

	public static ChanceAIEventData Deserialize(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	public static ChanceAIEventData DeserializeLengthDelimited(Stream stream, ChanceAIEventData instance, bool isDelta) { }

	public static ChanceAIEventData DeserializeLength(Stream stream, int length, ChanceAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ChanceAIEventData instance, ChanceAIEventData previous) { }

	public static void Serialize(Stream stream, ChanceAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ChanceAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, ChanceAIEventData instance) { }

	public void .ctor() { }

}

public class TimeSinceThreatAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6554
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(TimeSinceThreatAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TimeSinceThreatAIEventData instance) { }

	public TimeSinceThreatAIEventData Copy() { }

	public static TimeSinceThreatAIEventData Deserialize(Stream stream) { }

	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length) { }

	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TimeSinceThreatAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TimeSinceThreatAIEventData Deserialize(byte[] buffer, TimeSinceThreatAIEventData instance, bool isDelta = False) { }

	public static TimeSinceThreatAIEventData Deserialize(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	public static TimeSinceThreatAIEventData DeserializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance, bool isDelta) { }

	public static TimeSinceThreatAIEventData DeserializeLength(Stream stream, int length, TimeSinceThreatAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TimeSinceThreatAIEventData instance, TimeSinceThreatAIEventData previous) { }

	public static void Serialize(Stream stream, TimeSinceThreatAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TimeSinceThreatAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, TimeSinceThreatAIEventData instance) { }

	public void .ctor() { }

}

public class AggressionTimerAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float value; 


	public static void ResetToPool(AggressionTimerAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AggressionTimerAIEventData instance) { }

	public AggressionTimerAIEventData Copy() { }

	public static AggressionTimerAIEventData Deserialize(Stream stream) { }

	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length) { }

	public static AggressionTimerAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AggressionTimerAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AggressionTimerAIEventData Deserialize(byte[] buffer, AggressionTimerAIEventData instance, bool isDelta = False) { }

	public static AggressionTimerAIEventData Deserialize(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	public static AggressionTimerAIEventData DeserializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance, bool isDelta) { }

	public static AggressionTimerAIEventData DeserializeLength(Stream stream, int length, AggressionTimerAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AggressionTimerAIEventData instance, AggressionTimerAIEventData previous) { }

	public static void Serialize(Stream stream, AggressionTimerAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AggressionTimerAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, AggressionTimerAIEventData instance) { }

	public void .ctor() { }

}

public class InRangeOfHomeAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6557
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float range; 


	public static void ResetToPool(InRangeOfHomeAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InRangeOfHomeAIEventData instance) { }

	public InRangeOfHomeAIEventData Copy() { }

	public static InRangeOfHomeAIEventData Deserialize(Stream stream) { }

	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length) { }

	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InRangeOfHomeAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InRangeOfHomeAIEventData Deserialize(byte[] buffer, InRangeOfHomeAIEventData instance, bool isDelta = False) { }

	public static InRangeOfHomeAIEventData Deserialize(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	public static InRangeOfHomeAIEventData DeserializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance, bool isDelta) { }

	public static InRangeOfHomeAIEventData DeserializeLength(Stream stream, int length, InRangeOfHomeAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InRangeOfHomeAIEventData instance, InRangeOfHomeAIEventData previous) { }

	public static void Serialize(Stream stream, InRangeOfHomeAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InRangeOfHomeAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, InRangeOfHomeAIEventData instance) { }

	public void .ctor() { }

}

internal struct ColorEventData // TypeDefIndex: 7702
{
	[CompilerGeneratedAttribute] 
	private float <Value>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ColorEventFrame <Frame>k__BackingField; 

	[JsonPropertyAttribute] 
	public float Value { get; set; }
	[JsonPropertyAttribute] 
	public ColorEventFrame Frame { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Value() { }

	[CompilerGeneratedAttribute] 
	public void set_Value(float value) { }

	[CompilerGeneratedAttribute] 
	public ColorEventFrame get_Frame() { }

	[CompilerGeneratedAttribute] 
	public void set_Frame(ColorEventFrame value) { }

}

internal struct EmptyEventData // TypeDefIndex: 7705
{
	[CompilerGeneratedAttribute] 
	private int <Value>k__BackingField; 

	[JsonPropertyAttribute] 
	public int Value { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_Value() { }

	[CompilerGeneratedAttribute] 
	public void set_Value(int value) { }

}

