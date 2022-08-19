public class Timeline : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7040
{	// Fields
	public int StartTime; // 0x30
	public int EndTime; // 0x34
	public int CurrentPosition; // 0x38
	public TimeRuler TimeRuler; // 0x40
	public RectTransform IndicatorCurrent; // 0x48
	public UnityEvent OnStartScrub; // 0x50
	public UnityEvent OnEndScrub; // 0x58
	public Timeline.ScrubEvent OnScrubToTime; // 0x60
	public List<TimelineMarker> Markers; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimelineMarker <SelectedMarker>k__BackingField; // 0x70

	// Properties
	public TimelineMarker SelectedMarker { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public TimelineMarker get_SelectedMarker() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_SelectedMarker(TimelineMarker value) { }

	// RVA: 0xFD10B0 Offset: 0xFD04B0 VA: 0x180FD10B0
	internal void SelectMarker(TimelineMarker marker) { }

	// RVA: 0xFD0710 Offset: 0xFCFB10 VA: 0x180FD0710
	internal void DragMarker(TimelineMarker marker, PointerEventData eventData) { }

	// RVA: 0xFD0680 Offset: 0xFCFA80 VA: 0x180FD0680
	internal void DeleteMarker(TimelineMarker timelineMarker) { }

	// RVA: 0xFD05F0 Offset: 0xFCF9F0 VA: 0x180FD05F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD0EC0 Offset: 0xFD02C0 VA: 0x180FD0EC0
	public void Rebuild() { }

	// RVA: 0xFD04E0 Offset: 0xFCF8E0 VA: 0x180FD04E0
	public void AddMarker(TimelineMarker marker) { }

	// RVA: 0xFD1260 Offset: 0xFD0660 VA: 0x180FD1260
	public void SetCurrentPosition(int pos) { }

	// RVA: 0xFD0B10 Offset: 0xFCFF10 VA: 0x180FD0B10
	public float GetX(int time) { }

	// RVA: 0xFD0A00 Offset: 0xFCFE00 VA: 0x180FD0A00
	public int GetTime(float x) { }

	// RVA: 0xFD0E60 Offset: 0xFD0260 VA: 0x180FD0E60 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFD0E90 Offset: 0xFD0290 VA: 0x180FD0E90 Slot: 32
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xFD1010 Offset: 0xFD0410 VA: 0x180FD1010
	public void Scrubbed(int time) { }

	// RVA: 0xFD0BC0 Offset: 0xFCFFC0 VA: 0x180FD0BC0 Slot: 33
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xFD1300 Offset: 0xFD0700 VA: 0x180FD1300
	public void .ctor() { }

}

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7041
{	// Methods

	// RVA: 0xFCEAD0 Offset: 0xFCDED0 VA: 0x180FCEAD0
	public void .ctor() { }

}

