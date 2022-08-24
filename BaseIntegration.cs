public abstract class BaseIntegration // TypeDefIndex: 6177
{
public abstract string PublicKey { get; }
public virtual string Bucket { get; }
public virtual string UserId { get; }
public virtual string UserName { get; }
public virtual string ServerAddress { get; }
public virtual string ServerName { get; }
public virtual string LevelName { get; }
public virtual int MinutesPlayed { get; }
public virtual Auth Auth { get; }
public virtual bool RestrictEditorFunctionality { get; }
public virtual bool LocalApi { get; }
public virtual string ApiUrl { get; }
public virtual bool DebugOutput { get; }


public abstract string get_PublicKey();

public virtual string get_Bucket() { }

public virtual void OnManifestFile(Manifest manifest) { }

public virtual void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

public virtual string get_UserId() { }

public virtual string get_UserName() { }

public virtual string get_ServerAddress() { }

public virtual string get_ServerName() { }

public virtual string get_LevelName() { }

public virtual int get_MinutesPlayed() { }

public virtual Auth get_Auth() { }

public virtual bool get_RestrictEditorFunctionality() { }

public virtual bool get_LocalApi() { }

public virtual string get_ApiUrl() { }

public virtual bool get_DebugOutput() { }

public virtual bool ShouldReportException(string message, string stackTrace, LogType type) { }

protected void .ctor() { }

}

