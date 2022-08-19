public class AbandonedMutexException : SystemException // TypeDefIndex: 773
{
// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 773
	// Fields
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90

	// Methods

	// RVA: 0x14899D0 Offset: 0x1488DD0 VA: 0x1814899D0
	public void .ctor() { }

	// RVA: 0x14898E0 Offset: 0x1488CE0 VA: 0x1814898E0
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x1489870 Offset: 0x1488C70 VA: 0x181489870
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x14899A0 Offset: 0x1488DA0 VA: 0x1814899A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

