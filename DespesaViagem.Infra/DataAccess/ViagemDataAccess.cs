using DespesaViagem.Infra.Models.Viagem;
using MongoDB.Driver;

namespace DespesaViagem.Infra.Database
{
    public class ViagemDataAccess
    {
        private const string ConnectionString = "mongodb://localhost:37017/DespesaViagem"; //A123456! root
        private const string DatabaseName = "DespesaViagem";
        private const string CollectionName = "Viagens";


        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);            
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<Viagem>> GetAllViagens()
        {
            var viagensCollection = ConnectToMongo<Viagem>(CollectionName);
            var results = await viagensCollection.FindAsync(_ => true);
            return results.ToList();
        }

        public Task CriarViagem(Viagem viagem)
        {
            var viagensCollection = ConnectToMongo<Viagem>(CollectionName);
            return viagensCollection.InsertOneAsync(viagem);
        }       
    }
}
