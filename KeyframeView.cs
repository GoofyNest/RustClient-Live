public class KeyframeView : MonoBehaviour // TypeDefIndex: 10865
{	public ScrollRect Scroller; // 0x18
	public GameObjectRef KeyframePrefab; // 0x20
	public RectTransform KeyframeRoot; // 0x28
	public Transform CurrentPositionIndicator; // 0x30
	public bool LockScrollToCurrentPosition; // 0x38
	public RustText TrackName; // 0x40
	private List<KeyframeWidget> spawnedWidgets; // 0x48


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

public struct KeyframeView.UIKeyframeValue // TypeDefIndex: 10866
{	public float time; // 0x0
	public string visibleValue; // 0x8
	public object backingKeyframe; // 0x10
	public KeyframeView.UIKeyframeValue.KeyframeValueType type; // 0x18

}

public enum KeyframeView.UIKeyframeValue.KeyframeValueType // TypeDefIndex: 10867
{	public int value__; // 0x0
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Vector3 = 0;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Quaternion = 1;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Float = 2;

}

