public class AbandonedMutexException : SystemException // TypeDefIndex: 773
{

[ComVisibleAttribute] 
[Serializable]
public class AbandonedMutexException : SystemException 
	private int m_MutexIndex; 
	private Mutex m_Mutex; 


public void .ctor() { }

public void .ctor(int location, WaitHandle handle) { }

private void SetupException(int location, WaitHandle handle) { }

protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

