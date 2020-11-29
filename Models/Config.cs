namespace Foodcom.Models
{
    public class Config
    {
        public int Id { get; set; }

        public string Key { get; set; }
        
        public string Setting { get; set; }

        public static Config Make(string key, string setting)
        {
            return new Config
            {
                Key = key,
                Setting = setting,
            };
        }
    }
}