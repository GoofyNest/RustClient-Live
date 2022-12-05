public class KeyframeView : MonoBehaviour // TypeDefIndex: 12634
{
	public ScrollRect Scroller;
	public GameObjectRef KeyframePrefab;
	public RectTransform KeyframeRoot;
	public Transform CurrentPositionIndicator;
	public bool LockScrollToCurrentPosition;
	public RustText TrackName;
	private List<KeyframeWidget> spawnedWidgets;


	public void Populate(DemoShotVectorTrack track, float trackLength) { }

	public void Populate(DemoShotFloatTrack track, float trackLength) { }

	public void Populate(DemoShotQuaternionTrack track, float trackLength) { }

	public void SetTrackName(string text) { }

	private void Update() { }

	public static float TimeToXPos(float time) { }

	private void ApplyTimelineLength(float trackDuration) { }

	private void CleanupMarkers() { }

	private void PopulateMarkers(List<KeyframeView.UIKeyframeValue> toDisplay) { }

	public void .ctor() { }

}

public struct KeyframeView.UIKeyframeValue // TypeDefIndex: 12635
{
	public float time;
	public string visibleValue;
	public object backingKeyframe;
	public KeyframeView.UIKeyframeValue.KeyframeValueType type;

}

public enum KeyframeView.UIKeyframeValue.KeyframeValueType // TypeDefIndex: 12636
{
	public int value__;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Vector3 = 0;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Quaternion = 1;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Float = 2;

}

