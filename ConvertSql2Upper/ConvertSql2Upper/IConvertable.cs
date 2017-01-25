


namespace ConvertSql2Upper
{
    public interface IKeywordsConvertible
    {
        string[] Keywords { get; set; }
        string Convert( string source);
    }
}