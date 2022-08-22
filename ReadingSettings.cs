public class ReadingSettings // TypeDefIndex: 7601
{	private UnexpectedTrackChunksCountPolicy _unexpectedTrackChunksCountPolicy; // 0x10
	private ExtraTrackChunkPolicy _extraTrackChunkPolicy; // 0x14
	private UnknownChunkIdPolicy _unknownChunkIdPolicy; // 0x15
	private MissedEndOfTrackPolicy _missedEndOfTrackPolicy; // 0x16
	private SilentNoteOnPolicy _silentNoteOnPolicy; // 0x17
	private InvalidChunkSizePolicy _invalidChunkSizePolicy; // 0x18
	private UnknownFileFormatPolicy _unknownFileFormatPolicy; // 0x1C
	private UnknownChannelEventPolicy _unknownChannelEventPolicy; // 0x20
	private InvalidChannelEventParameterValuePolicy _invalidChannelEventParameterValuePolicy; // 0x24
	private InvalidMetaEventParameterValuePolicy _invalidMetaEventParameterValuePolicy; // 0x28
	private InvalidSystemCommonEventParameterValuePolicy _invalidSystemCommonEventParameterValuePolicy; // 0x2C
	private NotEnoughBytesPolicy _notEnoughBytesPolicy; // 0x30
	private NoHeaderChunkPolicy _noHeaderChunkPolicy; // 0x34
	private ZeroLengthDataPolicy _zeroLengthDataPolicy; // 0x38
	private EndOfTrackStoringPolicy _endOfTrackStoringPolicy; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnknownChannelEventCallback <UnknownChannelEventCallback>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ChunkTypesCollection <CustomChunkTypes>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventTypesCollection <CustomMetaEventTypes>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Encoding <TextEncoding>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DecodeTextCallback <DecodeTextCallback>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ReaderSettings <ReaderSettings>k__BackingField; // 0x68

	public UnexpectedTrackChunksCountPolicy UnexpectedTrackChunksCountPolicy { get; }
	public ExtraTrackChunkPolicy ExtraTrackChunkPolicy { get; }
	public UnknownChunkIdPolicy UnknownChunkIdPolicy { get; }
	public MissedEndOfTrackPolicy MissedEndOfTrackPolicy { get; }
	public SilentNoteOnPolicy SilentNoteOnPolicy { get; }
	public InvalidChunkSizePolicy InvalidChunkSizePolicy { get; }
	public UnknownFileFormatPolicy UnknownFileFormatPolicy { get; }
	public UnknownChannelEventPolicy UnknownChannelEventPolicy { get; }
	public UnknownChannelEventCallback UnknownChannelEventCallback { get; }
	public InvalidChannelEventParameterValuePolicy InvalidChannelEventParameterValuePolicy { get; }
	public InvalidMetaEventParameterValuePolicy InvalidMetaEventParameterValuePolicy { get; }
	public InvalidSystemCommonEventParameterValuePolicy InvalidSystemCommonEventParameterValuePolicy { get; }
	public NotEnoughBytesPolicy NotEnoughBytesPolicy { get; }
	public NoHeaderChunkPolicy NoHeaderChunkPolicy { get; }
	public ChunkTypesCollection CustomChunkTypes { get; }
	public EventTypesCollection CustomMetaEventTypes { get; }
	public Encoding TextEncoding { get; }
	public DecodeTextCallback DecodeTextCallback { get; }
	public ZeroLengthDataPolicy ZeroLengthDataPolicy { get; }
	public EndOfTrackStoringPolicy EndOfTrackStoringPolicy { get; }
	public ReaderSettings ReaderSettings { get; set; }


	public UnexpectedTrackChunksCountPolicy get_UnexpectedTrackChunksCountPolicy() { }

	public ExtraTrackChunkPolicy get_ExtraTrackChunkPolicy() { }

	public UnknownChunkIdPolicy get_UnknownChunkIdPolicy() { }

	public MissedEndOfTrackPolicy get_MissedEndOfTrackPolicy() { }

	public SilentNoteOnPolicy get_SilentNoteOnPolicy() { }

	public InvalidChunkSizePolicy get_InvalidChunkSizePolicy() { }

	public UnknownFileFormatPolicy get_UnknownFileFormatPolicy() { }

	public UnknownChannelEventPolicy get_UnknownChannelEventPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public UnknownChannelEventCallback get_UnknownChannelEventCallback() { }

	public InvalidChannelEventParameterValuePolicy get_InvalidChannelEventParameterValuePolicy() { }

	public InvalidMetaEventParameterValuePolicy get_InvalidMetaEventParameterValuePolicy() { }

	public InvalidSystemCommonEventParameterValuePolicy get_InvalidSystemCommonEventParameterValuePolicy() { }

	public NotEnoughBytesPolicy get_NotEnoughBytesPolicy() { }

	public NoHeaderChunkPolicy get_NoHeaderChunkPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ChunkTypesCollection get_CustomChunkTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EventTypesCollection get_CustomMetaEventTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Encoding get_TextEncoding() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DecodeTextCallback get_DecodeTextCallback() { }

	public ZeroLengthDataPolicy get_ZeroLengthDataPolicy() { }

	public EndOfTrackStoringPolicy get_EndOfTrackStoringPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ReaderSettings get_ReaderSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ReaderSettings(ReaderSettings value) { }

	public void .ctor() { }

}

