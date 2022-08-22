public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{	public AudioClip audioClip; // 0x18
	public int lengthInBars; // 0x20
	public int lengthInBarsWithTail; // 0x24
	public List<float> fadeInPoints; // 0x28


	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	public void .ctor() { }

}

