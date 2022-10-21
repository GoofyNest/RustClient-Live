public class LTSeq // TypeDefIndex: 5579
{
	public LTSeq previous; 
	public LTSeq current; 
	public LTDescr tween; 
	public float totalDelay; 
	public float timeScale; 
	private int debugIter; 
	public uint counter; 
	public bool toggle; 
	private uint _id; 

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

