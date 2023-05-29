using Data;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TCCG.Models
{
    public class JsonContext : DataContext
    {
        public readonly string DataPath;

        private static readonly JsonSerializerOptions _jsonOptions =
        new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IncludeFields = true
        }
    ;

        public JsonContext(string path)
        {
            DataPath = path;
        }   

        public override async Task Load()
        {
            using (FileStream sr = File.OpenRead(DataPath))
            {
                Database = await JsonSerializer.DeserializeAsync<DataHolder>(sr, _jsonOptions);
            }
        }

        public override async Task Save()
        {
            using (FileStream sr = File.OpenWrite(DataPath))
            {
                await JsonSerializer.SerializeAsync(sr, Database, _jsonOptions);
            }
        }
    }
}
