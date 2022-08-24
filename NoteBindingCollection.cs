public class NoteBindingCollection : ScriptableObject // TypeDefIndex: 9560
{
	public NoteBindingCollection.NoteData[] BaseBindings; 
	public float MinimumNoteTime; 
	public float MaximumNoteLength; 
	public bool AllowAutoplay; 
	public float AutoplayLoopDelay; 
	public string NotePlayedStatName; 
	public string KeyMidiMapShortname; 
	public bool AllowSustain; 
	public bool AllowFullKeyboardInput; 
	public string InstrumentShortName; 
	public InstrumentKeyController.InstrumentType NotePlayType; 
	public int MaxConcurrentNotes; 
	public bool LoopSounds; 
	public float SoundFadeInTime; 
	public float minimumSoundFadeOutTime; 
	public InstrumentKeyController.KeySet PrimaryClickNote; 
	public InstrumentKeyController.KeySet SecondaryClickNote; 
	public bool RunInstrumentAnimationController; 
	public bool PlayRepeatAnimations; 
	public float AnimationDeadTime; 
	public float AnimationResetDelay; 
	public float RecentlyPlayedThreshold; 
	[RangeAttribute] 
	public float CrossfadeNormalizedAnimationTarget; 
	public float AnimationCrossfadeDuration; 
	public float CrossfadePlayerSpeedMulti; 
	public int DefaultOctave; 
	public int ShiftedOctave; 


public bool FindNoteData(Notes note, int octave, InstrumentKeyController.NoteType type, out NoteBindingCollection.NoteData data, out int noteIndex) { }

public bool FindNoteDataIndex(Notes note, int octave, InstrumentKeyController.NoteType type, out int noteIndex) { }

public void .ctor() { }

}

public struct NoteBindingCollection.NoteData // TypeDefIndex: 9561
{
	public SoundDefinition NoteSound; 
	public SoundDefinition NoteStartSound; 
	public Notes Note; 
	public InstrumentKeyController.NoteType Type; 
	public int MidiNoteNumber; 
	public int NoteOctave; 
	[InstrumentIKTargetAttribute] 
	public InstrumentKeyController.IKNoteTarget NoteIKTarget; 
	public InstrumentKeyController.AnimationSlot AnimationSlot; 
	public int NoteSoundPositionTarget; 


public string ToNoteString() { }

}

