public class ReadingSettings // TypeDefIndex: 7601
{	// Fields
	private UnexpectedTrackChunksCountPolicy _unexpectedTrackChunksCountPolicy; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public UnexpectedTrackChunksCountPolicy get_UnexpectedTrackChunksCountPolicy() { }

	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	public ExtraTrackChunkPolicy get_ExtraTrackChunkPolicy() { }

	// RVA: 0x139FE10 Offset: 0x139F210 VA: 0x18139FE10
	public UnknownChunkIdPolicy get_UnknownChunkIdPolicy() { }

	// RVA: 0x139FDF0 Offset: 0x139F1F0 VA: 0x18139FDF0
	public MissedEndOfTrackPolicy get_MissedEndOfTrackPolicy() { }

	// RVA: 0x139FE00 Offset: 0x139F200 VA: 0x18139FE00
	public SilentNoteOnPolicy get_SilentNoteOnPolicy() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public InvalidChunkSizePolicy get_InvalidChunkSizePolicy() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public UnknownFileFormatPolicy get_UnknownFileFormatPolicy() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public UnknownChannelEventPolicy get_UnknownChannelEventPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public UnknownChannelEventCallback get_UnknownChannelEventCallback() { }

	// RVA: 0x7723F0 Offset: 0x7717F0 VA: 0x1807723F0
	public InvalidChannelEventParameterValuePolicy get_InvalidChannelEventParameterValuePolicy() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public InvalidMetaEventParameterValuePolicy get_InvalidMetaEventParameterValuePolicy() { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public InvalidSystemCommonEventParameterValuePolicy get_InvalidSystemCommonEventParameterValuePolicy() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public NotEnoughBytesPolicy get_NotEnoughBytesPolicy() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public NoHeaderChunkPolicy get_NoHeaderChunkPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public ChunkTypesCollection get_CustomChunkTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public EventTypesCollection get_CustomMetaEventTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Encoding get_TextEncoding() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public DecodeTextCallback get_DecodeTextCallback() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public ZeroLengthDataPolicy get_ZeroLengthDataPolicy() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public EndOfTrackStoringPolicy get_EndOfTrackStoringPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public ReaderSettings get_ReaderSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_ReaderSettings(ReaderSettings value) { }

	// RVA: 0x139FD50 Offset: 0x139F150 VA: 0x18139FD50
	public void .ctor() { }

}

