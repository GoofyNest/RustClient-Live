public class KeyframeView : MonoBehaviour // TypeDefIndex: 10865
{	// Fields
	public ScrollRect Scroller; // 0x18
	public GameObjectRef KeyframePrefab; // 0x20
	public RectTransform KeyframeRoot; // 0x28
	public Transform CurrentPositionIndicator; // 0x30
	public bool LockScrollToCurrentPosition; // 0x38
	public RustText TrackName; // 0x40
	private List<KeyframeWidget> spawnedWidgets; // 0x48

	// Methods

	// RVA: 0x6B74A0 Offset: 0x6B68A0 VA: 0x1806B74A0
	public void Populate(DemoShotVectorTrack track, float trackLength) { }

	// RVA: 0x6B7570 Offset: 0x6B6970 VA: 0x1806B7570
	public void Populate(DemoShotFloatTrack track, float trackLength) { }

	// RVA: 0x6B7640 Offset: 0x6B6A40 VA: 0x1806B7640
	public void Populate(DemoShotQuaternionTrack track, float trackLength) { }

	// RVA: 0x6B7710 Offset: 0x6B6B10 VA: 0x1806B7710
	public void SetTrackName(string text) { }

	// RVA: 0x6B7740 Offset: 0x6B6B40 VA: 0x1806B7740
	private void Update() { }

	// RVA: 0x6B7730 Offset: 0x6B6B30 VA: 0x1806B7730
	public static float TimeToXPos(float time) { }

	// RVA: 0x6B6FD0 Offset: 0x6B63D0 VA: 0x1806B6FD0
	private void ApplyTimelineLength(float trackDuration) { }

	// RVA: 0x6B7000 Offset: 0x6B6400 VA: 0x1806B7000
	private void CleanupMarkers() { }

	// RVA: 0x6B71A0 Offset: 0x6B65A0 VA: 0x1806B71A0
	private void PopulateMarkers(List<KeyframeView.UIKeyframeValue> toDisplay) { }

	// RVA: 0x6B7880 Offset: 0x6B6C80 VA: 0x1806B7880
	public void .ctor() { }

}

public struct KeyframeView.UIKeyframeValue // TypeDefIndex: 10866
{	// Fields
	public float time; // 0x0
	public string visibleValue; // 0x8
	public object backingKeyframe; // 0x10
	public KeyframeView.UIKeyframeValue.KeyframeValueType type; // 0x18

}

public enum KeyframeView.UIKeyframeValue.KeyframeValueType // TypeDefIndex: 10867
{	// Fields
	public int value__; // 0x0
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Vector3 = 0;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Quaternion = 1;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Float = 2;

}

