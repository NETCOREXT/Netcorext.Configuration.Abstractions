namespace Netcorext.Configuration.ConfigSections;

public class OAuthSection
{
    public const string AUTHORIZATION_CODE = "authorization_code";
    public const string CLIENT_CREDENTIALS = "client_credentials";
    public const string REFRESH_TOKEN = "refresh_token";
    public const string PASSWORD = "password";
    public const string IMPLICIT = "implicit";
    public const string PKCE = "pkce";
    public const string DEVICE_CODE = "urn:ietf:params:oauth:grant-type:device_code";
    public const string TOKEN_TYPE = "Bearer";

    public string GrantType { get; set; } = CLIENT_CREDENTIALS;
    public string AuthUrl { get; set; }
    public string AccessTokenUrl { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Scope { get; set; }
    public string TokenType { get; set; } = TOKEN_TYPE;
    public string AccessToken { get; set; }
}