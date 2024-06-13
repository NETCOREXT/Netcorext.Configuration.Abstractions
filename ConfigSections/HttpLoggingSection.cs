namespace Netcorext.Configuration.ConfigSections;

public class HttpLoggingSection
{
    public virtual HttpLoggingFields LoggingFields { get; set; } = HttpLoggingFields.RequestPropertiesAndHeaders | HttpLoggingFields.ResponsePropertiesAndHeaders;
    public virtual ISet<string> RequestHeaders { get; set; } = new HashSet<string>();
    public virtual ISet<string> ResponseHeaders { get; set; } = new HashSet<string>();
    public virtual int RequestBodyLogLimit { get; set; } = 32 * 1024;
    public virtual int ResponseBodyLogLimit { get; set; } = 32 * 1024;
    public virtual bool CombineLogs { get; set; }

    [Flags]
    public enum HttpLoggingFields : long
    {
        None = 0,
        RequestPath = 1,
        RequestQuery = 2,
        RequestProtocol = 4,
        RequestMethod = 8,
        RequestScheme = 16,                                                                // 0x0000000000000010
        ResponseStatusCode = 32,                                                           // 0x0000000000000020
        RequestHeaders = 64,                                                               // 0x0000000000000040
        ResponseHeaders = 128,                                                             // 0x0000000000000080
        RequestTrailers = 256,                                                             // 0x0000000000000100
        ResponseTrailers = 512,                                                            // 0x0000000000000200
        RequestBody = 1024,                                                                // 0x0000000000000400
        ResponseBody = 2048,                                                               // 0x0000000000000800
        RequestProperties = RequestScheme | RequestMethod | RequestProtocol | RequestPath, // 0x000000000000001D
        RequestPropertiesAndHeaders = RequestProperties | RequestHeaders,                  // 0x000000000000005D
        ResponsePropertiesAndHeaders = ResponseHeaders | ResponseStatusCode,               // 0x00000000000000A0
        Request = RequestPropertiesAndHeaders | RequestBody,                               // 0x000000000000045D
        Response = ResponsePropertiesAndHeaders | ResponseBody,                            // 0x00000000000008A0
        All = Response | Request                                                           // 0x0000000000000CFD
    }
}
