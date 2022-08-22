public class LTSeq // TypeDefIndex: 5574
{	public LTSeq previous; // 0x10
	public LTSeq current; // 0x18
	public LTDescr tween; // 0x20
	public float totalDelay; // 0x28
	public float timeScale; // 0x2C
	private int debugIter; // 0x30
	public uint counter; // 0x34
	public bool toggle; // 0x38
	private uint _id; // 0x3C

	public int id { get; }


	public int get_id() { }

	public void reset() { }

	public void init(uint id, uint global_counter) { }

	private LTSeq addOn() { }

	private float addPreviousDelays() { }

	public LTSeq append(float delay) { }

	public LTSeq append(Action callback) { }

	public LTSeq append(Action<object> callback, object obj) { }

	public LTSeq append(GameObject gameObject, Action callback) { }

	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	public LTSeq append(LTDescr tween) { }

	public LTSeq insert(LTDescr tween) { }

	public LTSeq setScale(float timeScale) { }

	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	public LTSeq reverse() { }

	public void .ctor() { }

}

