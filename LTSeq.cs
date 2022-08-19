public class LTSeq // TypeDefIndex: 5574
{	// Fields
	public LTSeq previous; // 0x10
	public LTSeq current; // 0x18
	public LTDescr tween; // 0x20
	public float totalDelay; // 0x28
	public float timeScale; // 0x2C
	private int debugIter; // 0x30
	public uint counter; // 0x34
	public bool toggle; // 0x38
	private uint _id; // 0x3C

	// Properties
	public int id { get; }

	// Methods

	// RVA: 0x21A58D0 Offset: 0x21A4CD0 VA: 0x1821A58D0
	public int get_id() { }

	// RVA: 0x21A59D0 Offset: 0x21A4DD0 VA: 0x1821A59D0
	public void reset() { }

	// RVA: 0x21A58E0 Offset: 0x21A4CE0 VA: 0x1821A58E0
	public void init(uint id, uint global_counter) { }

	// RVA: 0x21A4F80 Offset: 0x21A4380 VA: 0x1821A4F80
	private LTSeq addOn() { }

	// RVA: 0x21A5050 Offset: 0x21A4450 VA: 0x1821A5050
	private float addPreviousDelays() { }

	// RVA: 0x21A58A0 Offset: 0x21A4CA0 VA: 0x1821A58A0
	public LTSeq append(float delay) { }

	// RVA: 0x21A5090 Offset: 0x21A4490 VA: 0x1821A5090
	public LTSeq append(Action callback) { }

	// RVA: 0x21A5260 Offset: 0x21A4660 VA: 0x1821A5260
	public LTSeq append(Action<object> callback, object obj) { }

	// RVA: 0x21A54F0 Offset: 0x21A48F0 VA: 0x1821A54F0
	public LTSeq append(GameObject gameObject, Action callback) { }

	// RVA: 0x21A56B0 Offset: 0x21A4AB0 VA: 0x1821A56B0
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	// RVA: 0x21A5460 Offset: 0x21A4860 VA: 0x1821A5460
	public LTSeq append(LTDescr tween) { }

	// RVA: 0x21A5950 Offset: 0x21A4D50 VA: 0x1821A5950
	public LTSeq insert(LTDescr tween) { }

	// RVA: 0x21A5AE0 Offset: 0x21A4EE0 VA: 0x1821A5AE0
	public LTSeq setScale(float timeScale) { }

	// RVA: 0x21A5A20 Offset: 0x21A4E20 VA: 0x1821A5A20
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	// RVA: 0x21A5A10 Offset: 0x21A4E10 VA: 0x1821A5A10
	public LTSeq reverse() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

