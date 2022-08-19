public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6337
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 spin; // 0x14

	// Methods

	// RVA: 0x1DB39D0 Offset: 0x1DB2DD0 VA: 0x181DB39D0
	public static void ResetToPool(SpinnerWheel instance) { }

	// RVA: 0x1DB3A50 Offset: 0x1DB2E50 VA: 0x181DB3A50
	public void ResetToPool() { }

	// RVA: 0x1DB38A0 Offset: 0x1DB2CA0 VA: 0x181DB38A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB2EF0 Offset: 0x1DB22F0 VA: 0x181DB2EF0
	public void CopyTo(SpinnerWheel instance) { }

	// RVA: 0x1DB2F20 Offset: 0x1DB2320 VA: 0x181DB2F20
	public SpinnerWheel Copy() { }

	// RVA: 0x1DB3820 Offset: 0x1DB2C20 VA: 0x181DB3820
	public static SpinnerWheel Deserialize(Stream stream) { }

	// RVA: 0x1DB31B0 Offset: 0x1DB25B0 VA: 0x181DB31B0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB3420 Offset: 0x1DB2820 VA: 0x181DB3420
	public static SpinnerWheel DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB3700 Offset: 0x1DB2B00 VA: 0x181DB3700
	public static SpinnerWheel Deserialize(byte[] buffer) { }

	// RVA: 0x1DB3990 Offset: 0x1DB2D90 VA: 0x181DB3990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB4050 Offset: 0x1DB3450 VA: 0x181DB4050 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB4070 Offset: 0x1DB3470 VA: 0x181DB4070 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SpinnerWheel previous) { }

	// RVA: 0x1DB39B0 Offset: 0x1DB2DB0 VA: 0x181DB39B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB34B0 Offset: 0x1DB28B0 VA: 0x181DB34B0
	public static SpinnerWheel Deserialize(byte[] buffer, SpinnerWheel instance, bool isDelta = False) { }

	// RVA: 0x1DB35B0 Offset: 0x1DB29B0 VA: 0x181DB35B0
	public static SpinnerWheel Deserialize(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB2F90 Offset: 0x1DB2390 VA: 0x181DB2F90
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB3230 Offset: 0x1DB2630 VA: 0x181DB3230
	public static SpinnerWheel DeserializeLength(Stream stream, int length, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB3AD0 Offset: 0x1DB2ED0 VA: 0x181DB3AD0
	public static void SerializeDelta(Stream stream, SpinnerWheel instance, SpinnerWheel previous) { }

	// RVA: 0x1DB3ED0 Offset: 0x1DB32D0 VA: 0x181DB3ED0
	public static void Serialize(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1DB4040 Offset: 0x1DB3440 VA: 0x181DB4040
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB4050 Offset: 0x1DB3450 VA: 0x181DB4050
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB3DC0 Offset: 0x1DB31C0 VA: 0x181DB3DC0
	public static byte[] SerializeToBytes(SpinnerWheel instance) { }

	// RVA: 0x1DB3D10 Offset: 0x1DB3110 VA: 0x181DB3D10
	public static void SerializeLengthDelimited(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SpinnerWheel : Signage // TypeDefIndex: 8452
{	// Fields
	private Option __menuOption_Menu_LockSpin; // 0x3D0
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA7A900 Offset: 0xA79D00 VA: 0x180A7A900 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA7BDE0 Offset: 0xA7B1E0 VA: 0x180A7BDE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA7B440 Offset: 0xA7A840 VA: 0x180A7B440 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 173
	public virtual bool AllowPlayerSpins() { }

	// RVA: 0xA7B150 Offset: 0xA7A550 VA: 0x180A7B150 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7A8F0 Offset: 0xA79CF0 VA: 0x180A7A8F0 Slot: 174
	public virtual float GetMaxSpinSpeed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 175
	public virtual void Update_Server() { }

	// RVA: 0xA7BA10 Offset: 0xA7AE10 VA: 0x180A7BA10
	public void Update_Client() { }

	// RVA: 0xA7B530 Offset: 0xA7A930 VA: 0x180A7B530
	private void UpdateSound() { }

	// RVA: 0xA7BCF0 Offset: 0xA7B0F0 VA: 0x180A7BCF0
	public void Update() { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0
	public bool AnyoneSpin() { }

	[BaseEntity.Menu] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.Description] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.Icon] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CBA0 Offset: 0x8BFA0 VA: 0x18008CBA0
	// RVA: 0xA7B350 Offset: 0xA7A750 VA: 0x180A7B350
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0xA7B2E0 Offset: 0xA7A6E0 VA: 0x180A7B2E0
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Description] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Icon] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	// RVA: 0xA7B3F0 Offset: 0xA7A7F0 VA: 0x180A7B3F0
	public void Menu_UnlockSpin(BasePlayer player) { }

	// RVA: 0xA7B390 Offset: 0xA7A790 VA: 0x180A7B390
	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.Description] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.Icon] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CFF0 Offset: 0x8C3F0 VA: 0x18008CFF0
	// RVA: 0xA7B290 Offset: 0xA7A690 VA: 0x180A7B290
	public void Menu_LockSpin(BasePlayer player) { }

	// RVA: 0xA7B230 Offset: 0xA7A630 VA: 0x180A7B230
	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	// RVA: 0xA7BD40 Offset: 0xA7B140 VA: 0x180A7BD40
	public void .ctor() { }

}

