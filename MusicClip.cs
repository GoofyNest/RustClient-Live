public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{	// Fields
	public AudioClip audioClip; // 0x18
	public int lengthInBars; // 0x20
	public int lengthInBarsWithTail; // 0x24
	public List<float> fadeInPoints; // 0x28

	// Methods

	// RVA: 0x7BBCC0 Offset: 0x7BB0C0 VA: 0x1807BBCC0
	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	// RVA: 0x7BBE10 Offset: 0x7BB210 VA: 0x1807BBE10
	public void .ctor() { }

}

