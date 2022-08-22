public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6337
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 spin; // 0x14


	public static void ResetToPool(SpinnerWheel instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SpinnerWheel instance) { }

	public SpinnerWheel Copy() { }

	public static SpinnerWheel Deserialize(Stream stream) { }

	public static SpinnerWheel DeserializeLengthDelimited(Stream stream) { }

	public static SpinnerWheel DeserializeLength(Stream stream, int length) { }

	public static SpinnerWheel Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SpinnerWheel previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SpinnerWheel Deserialize(byte[] buffer, SpinnerWheel instance, bool isDelta = False) { }

	public static SpinnerWheel Deserialize(Stream stream, SpinnerWheel instance, bool isDelta) { }

	public static SpinnerWheel DeserializeLengthDelimited(Stream stream, SpinnerWheel instance, bool isDelta) { }

	public static SpinnerWheel DeserializeLength(Stream stream, int length, SpinnerWheel instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SpinnerWheel instance, SpinnerWheel previous) { }

	public static void Serialize(Stream stream, SpinnerWheel instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SpinnerWheel instance) { }

	public static void SerializeLengthDelimited(Stream stream, SpinnerWheel instance) { }

	public void .ctor() { }

}

public class SpinnerWheel : Signage // TypeDefIndex: 8452
{	private Option __menuOption_Menu_LockSpin; // 0x3D0
	private Option __menuOption_Menu_Spin; // 0x428
	private Option __menuOption_Menu_UnlockSpin; // 0x480
	public Transform wheel; // 0x4D8
	public float velocity; // 0x4E0
	public Quaternion targetRotation; // 0x4E4
	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
	public SoundDefinition spinLoopSoundDef; // 0x4F8
	public SoundDefinition spinStartSoundDef; // 0x500
	public SoundDefinition spinAccentSoundDef; // 0x508
	public SoundDefinition spinStopSoundDef; // 0x510
	public float minTimeBetweenSpinAccentSounds; // 0x518
	public float spinAccentAngleDelta; // 0x51C
	private Sound spinSound; // 0x520
	private SoundModulation.Modulator spinSoundGain; // 0x528
	private float angleRotated; // 0x530
	private float lastSpinSound; // 0x534
	private float clientSpinSpeed; // 0x538

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual bool AllowPlayerSpins() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public virtual float GetMaxSpinSpeed() { }

	public virtual void Update_Server() { }

	public void Update_Client() { }

	private void UpdateSound() { }

	public void Update() { }

	public bool AnyoneSpin() { }

	[BaseEntity.Menu] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.Description] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.Icon] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Description] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Icon] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	public void Menu_UnlockSpin(BasePlayer player) { }

	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.Description] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.Icon] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	public void Menu_LockSpin(BasePlayer player) { }

	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

