public class ReadingSettings // TypeDefIndex: 7617
{
	private UnexpectedTrackChunksCountPolicy _unexpectedTrackChunksCountPolicy;
	private ExtraTrackChunkPolicy _extraTrackChunkPolicy;
	private UnknownChunkIdPolicy _unknownChunkIdPolicy;
	private MissedEndOfTrackPolicy _missedEndOfTrackPolicy;
	private SilentNoteOnPolicy _silentNoteOnPolicy;
	private InvalidChunkSizePolicy _invalidChunkSizePolicy;
	private UnknownFileFormatPolicy _unknownFileFormatPolicy;
	private UnknownChannelEventPolicy _unknownChannelEventPolicy;
	private InvalidChannelEventParameterValuePolicy _invalidChannelEventParameterValuePolicy;
	private InvalidMetaEventParameterValuePolicy _invalidMetaEventParameterValuePolicy;
	private InvalidSystemCommonEventParameterValuePolicy _invalidSystemCommonEventParameterValuePolicy;
	private NotEnoughBytesPolicy _notEnoughBytesPolicy;
	private NoHeaderChunkPolicy _noHeaderChunkPolicy;
	private ZeroLengthDataPolicy _zeroLengthDataPolicy;
	private EndOfTrackStoringPolicy _endOfTrackStoringPolicy;
	[CompilerGeneratedAttribute]
	private UnknownChannelEventCallback <UnknownChannelEventCallback>k__BackingField;
	[CompilerGeneratedAttribute]
	private ChunkTypesCollection <CustomChunkTypes>k__BackingField;
	[CompilerGeneratedAttribute]
	private EventTypesCollection <CustomMetaEventTypes>k__BackingField;
	[CompilerGeneratedAttribute]
	private Encoding <TextEncoding>k__BackingField;
	[CompilerGeneratedAttribute]
	private DecodeTextCallback <DecodeTextCallback>k__BackingField;
	[CompilerGeneratedAttribute]
	private ReaderSettings <ReaderSettings>k__BackingField;

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

	[CompilerGeneratedAttribute]
	public UnknownChannelEventCallback get_UnknownChannelEventCallback() { }

	public InvalidChannelEventParameterValuePolicy get_InvalidChannelEventParameterValuePolicy() { }

	public InvalidMetaEventParameterValuePolicy get_InvalidMetaEventParameterValuePolicy() { }

	public InvalidSystemCommonEventParameterValuePolicy get_InvalidSystemCommonEventParameterValuePolicy() { }

	public NotEnoughBytesPolicy get_NotEnoughBytesPolicy() { }

	public NoHeaderChunkPolicy get_NoHeaderChunkPolicy() { }

	[CompilerGeneratedAttribute]
	public ChunkTypesCollection get_CustomChunkTypes() { }

	[CompilerGeneratedAttribute]
	public EventTypesCollection get_CustomMetaEventTypes() { }

	[CompilerGeneratedAttribute]
	public Encoding get_TextEncoding() { }

	[CompilerGeneratedAttribute]
	public DecodeTextCallback get_DecodeTextCallback() { }

	public ZeroLengthDataPolicy get_ZeroLengthDataPolicy() { }

	public EndOfTrackStoringPolicy get_EndOfTrackStoringPolicy() { }

	[CompilerGeneratedAttribute]
	public ReaderSettings get_ReaderSettings() { }

	[CompilerGeneratedAttribute]
	public void set_ReaderSettings(ReaderSettings value) { }

	public void .ctor() { }

}

