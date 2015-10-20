namespace ReniumLeague.Entity.Mongo
{
    using System.Linq;
    using MongoDB.Driver;
    using System.Configuration;

    internal class MongoRepository
    {
        private const string DatabaseHost = "mongodb://127.0.0.1";
        private const string DatabaseName = "RheniumLeague";

        private MongoDatabase GetDatabase(string name, string fromHost)
        {
            var mongoClient = new MongoClient(fromHost);
            var server = mongoClient.GetServer();
            return server.GetDatabase(name);
        }

        public IQueryable<ReniumLeague.Entity.Mongo.Models.Team> GetAllTeams()
        {
            var db = this.GetDatabase(this.DatabaseName, this.DatabaseHost);
            var teams = db.GetCollection<ReniumLeague.Entity.Mongo.Models.Team>("Teams");
            IQueryable<ReniumLeague.Entity.Mongo.Models.Team> allTeams = teams.FindAll().Select(x => new ReniumLeague.Entity.Mongo.Models.Team()
            {
                Name = x.Name
            }).AsQueryable();
            return allTeams;
        }

        public IQueryable<ReniumLeague.Entity.Mongo.Models.Stadium> GetAllProducts()
        {
            var db = this.GetDatabase(this.DatabaseName, this.DatabaseHost);
            var stadiums = db.GetCollection<ReniumLeague.Entity.Mongo.Models.Stadium>("Stadiums");
            IQueryable<ReniumLeague.Entity.Mongo.Models.Stadium> allStadiums = stadiums.FindAll().Select(x => new Stadium()
            {
                Name = x.Name,
                Capacity = x.Capacity
            }).AsQueryable();

            return allStadiums;
        }
    }
}
