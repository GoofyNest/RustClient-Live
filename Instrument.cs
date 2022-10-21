public class InstrumentRecording : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<InstrumentRecordingNote> notes; 
	public int forInstrument; 


	public static void ResetToPool(InstrumentRecording instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InstrumentRecording instance) { }

	public InstrumentRecording Copy() { }

	public static InstrumentRecording Deserialize(Stream stream) { }

	public static InstrumentRecording DeserializeLengthDelimited(Stream stream) { }

	public static InstrumentRecording DeserializeLength(Stream stream, int length) { }

	public static InstrumentRecording Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecording previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InstrumentRecording Deserialize(byte[] buffer, InstrumentRecording instance, bool isDelta = False) { }

	public static InstrumentRecording Deserialize(Stream stream, InstrumentRecording instance, bool isDelta) { }

	public static InstrumentRecording DeserializeLengthDelimited(Stream stream, InstrumentRecording instance, bool isDelta) { }

	public static InstrumentRecording DeserializeLength(Stream stream, int length, InstrumentRecording instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InstrumentRecording instance, InstrumentRecording previous) { }

	public static void Serialize(Stream stream, InstrumentRecording instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InstrumentRecording instance) { }

	public static void SerializeLengthDelimited(Stream stream, InstrumentRecording instance) { }

	public void .ctor() { }

}

public class InstrumentRecordingNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float startTime; 
	public float duration; 
	public int note; 
	public int octave; 
	public float velocity; 
	public int noteType; 
	public bool shouldPlay; 
	public bool hasPlayed; 


	public static void ResetToPool(InstrumentRecordingNote instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InstrumentRecordingNote instance) { }

	public InstrumentRecordingNote Copy() { }

	public static InstrumentRecordingNote Deserialize(Stream stream) { }

	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream) { }

	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length) { }

	public static InstrumentRecordingNote Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecordingNote previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InstrumentRecordingNote Deserialize(byte[] buffer, InstrumentRecordingNote instance, bool isDelta = False) { }

	public static InstrumentRecordingNote Deserialize(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length, InstrumentRecordingNote instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InstrumentRecordingNote instance, InstrumentRecordingNote previous) { }

	public static void Serialize(Stream stream, InstrumentRecordingNote instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InstrumentRecordingNote instance) { }

	public static void SerializeLengthDelimited(Stream stream, InstrumentRecordingNote instance) { }

	public void .ctor() { }

}

public class InstrumentMidiBindings : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<InstrumentMidiBinding> bindings; 
	public uint forInstrument; 


	public static void ResetToPool(InstrumentMidiBindings instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InstrumentMidiBindings instance) { }

	public InstrumentMidiBindings Copy() { }

	public static InstrumentMidiBindings Deserialize(Stream stream) { }

	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream) { }

	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length) { }

	public static InstrumentMidiBindings Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBindings previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InstrumentMidiBindings Deserialize(byte[] buffer, InstrumentMidiBindings instance, bool isDelta = False) { }

	public static InstrumentMidiBindings Deserialize(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length, InstrumentMidiBindings instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InstrumentMidiBindings instance, InstrumentMidiBindings previous) { }

	public static void Serialize(Stream stream, InstrumentMidiBindings instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InstrumentMidiBindings instance) { }

	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBindings instance) { }

	public void .ctor() { }

}

public class InstrumentMidiBinding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int noteFrom; 
	public int note; 
	public int noteOctave; 
	public int noteType; 


	public static void ResetToPool(InstrumentMidiBinding instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InstrumentMidiBinding instance) { }

	public InstrumentMidiBinding Copy() { }

	public static InstrumentMidiBinding Deserialize(Stream stream) { }

	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream) { }

	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length) { }

	public static InstrumentMidiBinding Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBinding previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InstrumentMidiBinding Deserialize(byte[] buffer, InstrumentMidiBinding instance, bool isDelta = False) { }

	public static InstrumentMidiBinding Deserialize(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length, InstrumentMidiBinding instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InstrumentMidiBinding instance, InstrumentMidiBinding previous) { }

	public static void Serialize(Stream stream, InstrumentMidiBinding instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InstrumentMidiBinding instance) { }

	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBinding instance) { }

	public void .ctor() { }

}

public sealed class InstrumentNameEvent : BaseTextEvent // TypeDefIndex: 7545
{

	public void .ctor() { }

	public void .ctor(string instrumentName) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

public class InstrumentTool : HeldEntity // TypeDefIndex: 10295
{
	public InstrumentKeyController KeyController; 
	public SoundDefinition DeploySound; 
	public Vector2 PitchClamp; 
	public bool UseAnimationSlotEvents; 
	public Transform MuzzleT; 
	public bool UsableByAutoTurrets; 
	private InstrumentViewmodel instrumentView; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ClampPitch(ref float pitch) { }

	public override void OnInput() { }

	public override float GetMovementMultiplier() { }

	protected virtual void LateUpdate() { }

	public override void OnDeployed() { }

	private void OnAnimationSlotSet(InstrumentKeyController.AnimationSlot slot) { }

	public override void OnHolstered() { }

	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected virtual void RemotePlayerDeploy(BasePlayer player) { }

	protected virtual void RemotePlayerHolster(BasePlayer player) { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ResetState() { }

	[BaseEntity.RPC_Client] 
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	public override bool IsInstrument() { }

	public void .ctor() { }

}

public class InstrumentStateBehaviour : StateMachineBehaviour // TypeDefIndex: 10453
{
	private static readonly int[] targetState; 
	private static readonly int[] states; 
	public int ignoreIndex; 
	private float lastCrossfade; 
	public float AnimatorCrossfadeDuration; 


	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class InstrumentViewmodel : MonoBehaviour // TypeDefIndex: 10454
{
	public Animator ViewAnimator; 
	public bool UpdateA; 
	public bool UpdateB; 
	public bool UpdateC; 
	public bool UpdateD; 
	public bool UpdateE; 
	public bool UpdateF; 
	public bool UpdateG; 
	public bool UpdateRecentlyPlayed; 
	public bool UpdatePlayedNoteTrigger; 
	public bool UseTriggers; 
	private readonly int note_a; 
	private readonly int note_b; 
	private readonly int note_c; 
	private readonly int note_d; 
	private readonly int note_e; 
	private readonly int note_f; 
	private readonly int note_g; 
	private readonly int recentlyPlayedHash; 
	private readonly int playedNoteHash; 


	public void UpdateSlots(InstrumentKeyController.AnimationSlot currentSlot, bool recentlyPlayed, bool playedNoteThisFrame) { }

	private void UpdateState(int param, bool state) { }

	public void .ctor() { }

}

public class InstrumentToolGuitar : InstrumentTool // TypeDefIndex: 11188
{
	public Transform InUseAligner; 
	public Transform DeployAligner; 
	public string DeployBone; 
	private Transform handBoneTarget; 
	private static readonly int deployHash; 


	protected override void LateUpdate() { }

	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	public override void OnReliableEvent(string name) { }

	public void DeployBegin() { }

	public void DeployComplete() { }

	public override void OnSpawnedForWorkshopPreview() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class InstrumentDebugInput : MonoBehaviour // TypeDefIndex: 11270
{

public interface IIdealSlotEntity

public class InstrumentDebugInput : MonoBehaviour
	public InstrumentKeyController KeyController; 
	public InstrumentKeyController.KeySet Note; 
	public float Frequency; 
	public float StopAfter; 
	public SoundDefinition OverrideDefinition; 


	public void .ctor() { }

}

public class InstrumentIKController : MonoBehaviour // TypeDefIndex: 11271
{
	public Vector3 HitRotationVector; 
	public Transform[] LeftHandIkTargets; 
	public Transform[] LeftHandIKTargetHitRotations; 
	public Transform[] RightHandIkTargets; 
	public Transform[] RightHandIKTargetHitRotations; 
	public Transform[] RightFootIkTargets; 
	public AnimationCurve HandHeightCurve; 
	public float HandHeightMultiplier; 
	public float HandMoveLerpSpeed; 
	public bool DebugHitRotation; 
	public AnimationCurve HandHitCurve; 
	public float NoteHitTime; 
	[HeaderAttribute] 
	public float BodyLookWeight; 
	public float HeadLookWeight; 
	public float LookWeightLimit; 
	public bool HoldHandsAtPlay; 
	private int currentLeftHandTarget; 
	private float leftHandTargetNoteTime; 
	private int currentRightHandTarget; 
	private float rightHandTargetNoteTime; 
	private int currentRightFootTarget; 
	private float rightFootTargetNoteTime; 
	private Vector3 leftHandIkPos; 
	private Vector3 rightHandIkPos; 
	private Vector3 rightFootIkPos; 
	private Transform iKWorkerTransform; 
	private Transform rotationWorker; 
	private float totalHandAnimTime; 
	private float lastSetLeftHandTime; 
	private float lastSetRightHandTime; 
	private float lastSetRightFootTime; 


	public void HoldHandsUpdate(InstrumentKeyController key) { }

	public void UpdateIK(BasePlayer forPlayer) { }

	private Vector3 GetHandHeight(float noteTime) { }

	private Vector3 GetWorldSpaceIkTarget(int target, InstrumentKeyController.IKType type, Vector3 localOffset) { }

	private Transform GetHandTransform(int target, InstrumentKeyController.IKType type) { }

	private Transform GetHandRotationTransform(int target, InstrumentKeyController.IKType type) { }

	public void SetIkTarget(InstrumentKeyController.IKType type, int target) { }

	public void .ctor() { }

}

public class InstrumentIKTargetAttribute : PropertyAttribute // TypeDefIndex: 11272
{

	public void .ctor() { }

}

public class InstrumentKeyController : MonoBehaviour // TypeDefIndex: 11273
{
	public static readonly int PlayingNoteParam; 
	public static readonly int AnimationSlot1; 
	public static readonly int AnimationSlot2; 
	public static readonly int AnimationSlot3; 
	public static readonly int AnimationSlot4; 
	public static readonly int AnimationSlot5; 
	public static readonly int AnimationSlot6; 
	public static readonly int AnimationSlot7; 
	private float lastAnimationSlotTime; 
	public Action<InstrumentKeyController.AnimationSlot> OnAnimationSlotSet; 
	private Nullable<InstrumentKeyController.AnimationSlot> setSlot; 
	[CompilerGeneratedAttribute] 
	private MicrophoneStandIOEntity <currentReceiver>k__BackingField; 
	private bool sustain; 
	private int lastMidiFrame; 
	private int midiNotesThisFrame; 
	private InstrumentRecording activeRecording; 
	private string recordingFileName; 
	private float recordingStartTime; 
	private List<InstrumentRecordingNote> activeNotes; 
	private InstrumentRecording playingRecording; 
	private float playbackElapsedTime; 
	private List<int> stoppedNotes; 
	public const float DEFAULT_NOTE_VELOCITY = 1;
	public NoteBindingCollection Bindings; 
	public InstrumentKeyController.NoteBinding[] NoteBindings; 
	public Transform[] NoteSoundPositions; 
	public InstrumentIKController IKController; 
	public Transform LeftHandProp; 
	public Transform RightHandProp; 
	public Animator InstrumentAnimator; 
	public BaseEntity RPCHandler; 
	public uint overrideAchievementId; 
	private const string ALL_INSTRUMENTS_ACHIEVEMENT_NAME = "PLAY_ALL_INSTRUMENTS";
	private const int INSTRUMENT_ACHIEVEMENT_COUNT = 11;
	private static HashSet<uint> playedInstruments; 
	private InstrumentKeyController.NoteBinding workerBinding; 
	private BasePlayer midiPlayer; 
	private bool playedFirstNote; 
	private float teamAchievementCheck; 
	private static bool awardedFullCollectionAchievement; 
	public TimeSince TimeInUse; 
	private bool subscribedToMidi; 
	private InstrumentMidiBindings activeMidiBindings; 
	private bool hasSetupBindings; 
	private string autoplayPrefString; 
	private string autoplayDefaultName; 
	[CompilerGeneratedAttribute] 
	private bool <FullKeyboardMode>k__BackingField; 
	private List<int> activeMidiNotes; 
	[CompilerGeneratedAttribute] 
	private InstrumentKeyController.AnimationSlot <CurrentAnimation>k__BackingField; 
	private BasePlayer OwnerPlayer; 
	[CompilerGeneratedAttribute] 
	private bool <PlayedNoteThisFrame>k__BackingField; 

	public MicrophoneStandIOEntity currentReceiver { get; set; }
	public bool FullKeyboardMode { get; set; }
	public InstrumentKeyController.AnimationSlot CurrentAnimation { get; set; }
	public bool RecentlyPlayedNote { get; }
	private bool HeldByLocalPlayer { get; }
	private bool IsPlaying { get; }
	private int CurrentlyPlayingNotes { get; }
	public bool PlayedNoteThisFrame { get; set; }


	private void DisableProps() { }

	private void UpdateHeldProps(BasePlayer forPlayer) { }

	private void RunInstrumentAnimation(BasePlayer forPlayer) { }

	private void SetAnimationSlot(InstrumentKeyController.AnimationSlot slot, PlayerModel forPlayer) { }

	private int GetAnimationSlotHash(InstrumentKeyController.AnimationSlot slot) { }

	[CompilerGeneratedAttribute] 
	public MicrophoneStandIOEntity get_currentReceiver() { }

	[CompilerGeneratedAttribute] 
	private void set_currentReceiver(MicrophoneStandIOEntity value) { }

	public bool SetCurrentReceiver(MicrophoneStandIOEntity receiver) { }

	public void ClearReceiver() { }

	public void SubscribeToMidi(BasePlayer forPlayer) { }

	public void UpdateMidiBindings() { }

	public void UnsubscribeFromMidi() { }

	public void ResetState() { }

	private void PlayNoteViaMIDI(int noteIndex, float velocity) { }

	private void StopNoteViaMIDI(int noteIndex) { }

	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	private void NoteOffDelegate(MidiChannel channel, int note) { }

	private void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue) { }

	private bool ApplyMidiRebinding(int inNote, out int index) { }

	private void ConvertMidiNoteToIndex(int note, out int index) { }

	public void StartRecording(string fileName) { }

	public void StopRecording() { }

	private void RecordNoteStart(Notes note, int octave, float velocity, InstrumentKeyController.NoteType type, bool hold) { }

	private void RecordNoteStop(Notes note, int octave, InstrumentKeyController.NoteType type) { }

	public void PlayRecording(InstrumentRecording recording) { }

	private void UpdatePlayingRecording(BasePlayer forPlayer) { }

	private void StopPlayingRecording() { }

	[CompilerGeneratedAttribute] 
	public bool get_FullKeyboardMode() { }

	[CompilerGeneratedAttribute] 
	private void set_FullKeyboardMode(bool value) { }

	[CompilerGeneratedAttribute] 
	public InstrumentKeyController.AnimationSlot get_CurrentAnimation() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentAnimation(InstrumentKeyController.AnimationSlot value) { }

	public bool get_RecentlyPlayedNote() { }

	private bool get_HeldByLocalPlayer() { }

	private bool get_IsPlaying() { }

	private int get_CurrentlyPlayingNotes() { }

	public void SetFullKeyboardMode(bool state) { }

	public void OnInput(BasePlayer player) { }

	private void OnDisable() { }

	public void InUseUpdate(BasePlayer forPlayer) { }

	public void LateUpdateInstrument(BasePlayer forPlayer) { }

	public void PlayNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	public bool PlayNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, bool isLocal) { }

	public bool StopNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	public void StopNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	public void StopAllNotes(bool blockUntilRelease) { }

	public void StopOldestNote(bool blockUntilRelease, bool isVoiceStealing = False) { }

	public void OnClientBeginUse(BasePlayer player) { }

	public void SetupBindings() { }

	public void OnClientEndUse(BasePlayer player) { }

	public void OnEnable() { }

	private GameObject GetNoteSoundPosition(int index) { }

	[CompilerGeneratedAttribute] 
	public bool get_PlayedNoteThisFrame() { }

	[CompilerGeneratedAttribute] 
	private void set_PlayedNoteThisFrame(bool value) { }

	public void OnPlayerPlayedNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, BasePlayer player) { }

	private void LoadPlayedInstruments() { }

	private void SavePlayedInstruments() { }

	public void OnPlayerStoppedNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <SetFullKeyboardMode>b__98_0() { }

}

public struct InstrumentKeyController.NoteBinding // TypeDefIndex: 11274
{
	private Sound playingSound; 
	private float startedPlayingNote; 
	private float minimumNoteTime; 
	private float minimumSoundFadeOutTime; 
	private bool lastNoteState; 
	private bool blockUntilRelease; 
	public bool MidiOn; 
	public bool MouseOn; 

	public bool Playing { get; }
	public float PlayingDuration { get; }
	public bool RecentlyPlayedNote { get; }


	public bool get_Playing() { }

	public float get_PlayingDuration() { }

	public bool get_RecentlyPlayedNote() { }

	private bool ButtonIsDown(Notes note, InstrumentKeyController.NoteType type) { }

	private bool ButtonJustPressed(Notes note, InstrumentKeyController.NoteType type) { }

	public void Update(BasePlayer player, InstrumentKeyController keyController, int octave, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	public bool PlaySound(bool isLocal, float velocity, InstrumentKeyController keyController, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	public static void SetupSound(bool isLocal, float velocity, NoteBindingCollection noteCollection, Sound forSound) { }

	public bool StopPlayingNote(InstrumentKeyController keyController, bool blockUntilKeyRelease = False, bool isVoiceStealing = False) { }

	public void BlockKeyUntilRelease() { }

	private Sound CreateSound(InstrumentKeyController keyController, NoteBindingCollection.NoteData data) { }

}

public enum InstrumentKeyController.IKType // TypeDefIndex: 11275
{
	public int value__; 
	public const InstrumentKeyController.IKType LeftHand = 0;
	public const InstrumentKeyController.IKType RightHand = 1;
	public const InstrumentKeyController.IKType RightFoot = 2;

}

public enum InstrumentKeyController.NoteType // TypeDefIndex: 11276
{
	public int value__; 
	public const InstrumentKeyController.NoteType Regular = 0;
	public const InstrumentKeyController.NoteType Sharp = 1;

}

public enum InstrumentKeyController.InstrumentType // TypeDefIndex: 11277
{
	public int value__; 
	public const InstrumentKeyController.InstrumentType Note = 0;
	public const InstrumentKeyController.InstrumentType Hold = 1;

}

public enum InstrumentKeyController.AnimationSlot // TypeDefIndex: 11278
{
	public int value__; 
	public const InstrumentKeyController.AnimationSlot None = 0;
	public const InstrumentKeyController.AnimationSlot One = 1;
	public const InstrumentKeyController.AnimationSlot Two = 2;
	public const InstrumentKeyController.AnimationSlot Three = 3;
	public const InstrumentKeyController.AnimationSlot Four = 4;
	public const InstrumentKeyController.AnimationSlot Five = 5;
	public const InstrumentKeyController.AnimationSlot Six = 6;
	public const InstrumentKeyController.AnimationSlot Seven = 7;

}

public struct InstrumentKeyController.KeySet // TypeDefIndex: 11279
{
	public Notes Note; 
	public InstrumentKeyController.NoteType NoteType; 
	public int OctaveShift; 


	public override string ToString() { }

}

public struct InstrumentKeyController.NoteOverride // TypeDefIndex: 11280
{
	public bool Override; 
	public InstrumentKeyController.KeySet Note; 

}

public struct InstrumentKeyController.IKNoteTarget // TypeDefIndex: 11281
{
	public InstrumentKeyController.IKType TargetType; 
	public int IkIndex; 

}

public abstract class InstrumentTip : BaseTip // TypeDefIndex: 13359
{
	public InstrumentKeyController Instrument { get; }


	public InstrumentKeyController get_Instrument() { }

	public bool IsKeypadHostingMusicBinds() { }

	protected void .ctor() { }

}

