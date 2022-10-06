public sealed class OnAchievementsUnlockedCallback : MulticastDelegate // TypeDefIndex: 9909
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnAchievementsUnlockedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnAchievementsUnlockedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnAchievementsUnlockedCallbackInfo data, IAsyncResult result) { }

}

