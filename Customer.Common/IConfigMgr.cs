namespace Customer.Common
{
    public interface IConfigMgr
    {
        T Get<T>(string key);
    }
}