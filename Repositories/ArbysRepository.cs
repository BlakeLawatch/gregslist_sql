

namespace gregslist_sql.Repositories
{
    public class ArbysRepository
    {

        private readonly IDbConnection _db;

        public ArbysRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Arby GetArbyById(int arbyId)
        {
            string sql = "SELECT * FROM arbys WHERE id = @arbyId";

            Arby arby = _db.Query<Arby>(sql, new { arbyId }).FirstOrDefault();
            return arby;
        }

        internal List<Arby> GetArbys()
        {
            string sql = "SELECT * FROM arbys;";

            List<Arby> arbys = _db.Query<Arby>(sql).ToList();
            return arbys;
        }
    }
}