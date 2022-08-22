public class Timeline : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7040
{	public int StartTime; // 0x30
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

	public TimelineMarker SelectedMarker { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TimelineMarker get_SelectedMarker() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_SelectedMarker(TimelineMarker value) { }

	internal void SelectMarker(TimelineMarker marker) { }

	internal void DragMarker(TimelineMarker marker, PointerEventData eventData) { }

	internal void DeleteMarker(TimelineMarker timelineMarker) { }

	protected override void Awake() { }

	public void Rebuild() { }

	public void AddMarker(TimelineMarker marker) { }

	public void SetCurrentPosition(int pos) { }

	public float GetX(int time) { }

	public int GetTime(float x) { }

	public void OnPointerDown(PointerEventData eventData) { }

	public void OnPointerUp(PointerEventData eventData) { }

	public void Scrubbed(int time) { }

	public void OnDrag(PointerEventData eventData) { }

	public void .ctor() { }

}

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7041
{
	public void .ctor() { }

}

