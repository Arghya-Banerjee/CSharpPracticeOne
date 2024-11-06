using System.Web.Htt;
public sealed class GlobalSettings
    {
    //static GlobalSettings() { }
    #region [Singleton Implementation]
    private static readonly GlobalSettings instance = new GlobalSettings();

    static GlobalSettings()
    {
    }

    private GlobalSettings()
    {
    }

    public static GlobalSettings Instance
    {
        get
        {
            return instance;
        }
    }
    #endregion [Singleton Implementation]

    public static UserSec oUserMaster
    {
        get
        {
            HttpContext httpContext = Microsoft.AspNetCore.Http.HttpContext;
            if (HttpContext.Current.Session["oUserMaster"] != null)
                return HttpContext.Current.Session["oUserMaster"] as UserSec;
            else
                return new UserSec();
        }
        set
        {
            HttpContext.Current.Session["oUserMaster"] = value;
        }
    }
}

