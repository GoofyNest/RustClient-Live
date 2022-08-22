public class AbandonedMutexException : SystemException // TypeDefIndex: 773
{
[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 773
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90


	public void .ctor() { }

	public void .ctor(int location, WaitHandle handle) { }

	private void SetupException(int location, WaitHandle handle) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

