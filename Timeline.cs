public class Timeline : RustControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 7041
{
	public int StartTime; 
	public int EndTime; 
	public int CurrentPosition; 
	public TimeRuler TimeRuler; 
	public RectTransform IndicatorCurrent; 
	public UnityEvent OnStartScrub; 
	public UnityEvent OnEndScrub; 
	public Timeline.ScrubEvent OnScrubToTime; 
	public List<TimelineMarker> Markers; 
	[CompilerGeneratedAttribute] 
	private TimelineMarker <SelectedMarker>k__BackingField; 

	public TimelineMarker SelectedMarker { get; set; }


	[CompilerGeneratedAttribute] 
	public TimelineMarker get_SelectedMarker() { }

	[CompilerGeneratedAttribute] 
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

public class Timeline.ScrubEvent : UnityEvent<float> // TypeDefIndex: 7042
{

	public void .ctor() { }

}

