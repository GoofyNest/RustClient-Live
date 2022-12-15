public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{
	public bool ShouldPool;
	private bool _disposed;
	public Vector3 spin;


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

public class SpinnerWheel : Signage // TypeDefIndex: 10175
{
	private Option __menuOption_Menu_LockSpin;
	private Option __menuOption_Menu_Spin;
	private Option __menuOption_Menu_UnlockSpin;
	public Transform wheel;
	public float velocity;
	public Quaternion targetRotation;
	[HeaderAttribute]
	public SoundDefinition spinLoopSoundDef;
	public SoundDefinition spinStartSoundDef;
	public SoundDefinition spinAccentSoundDef;
	public SoundDefinition spinStopSoundDef;
	public float minTimeBetweenSpinAccentSounds;
	public float spinAccentAngleDelta;
	private Sound spinSound;
	private SoundModulation.Modulator spinSoundGain;
	private float angleRotated;
	private float lastSpinSound;
	private float clientSpinSpeed;

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

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_UnlockSpin(BasePlayer player) { }

	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_LockSpin(BasePlayer player) { }

	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

