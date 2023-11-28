






namespace gregslist_sql.Repositories
{
    public class ArbysRepository
    {

        private readonly IDbConnection _db;

        public ArbysRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Arby CreateArby(Arby arbyData)
        {
            string sql = @"
            INSERT INTO arbys (name, numberOfMeats, calories)
            VALUES (@Name, @NumberOfMeats, @Calories);

            SELECT * FROM arbys WHERE id = LAST_INSERT_ID();";

            Arby arby = _db.Query<Arby>(sql, arbyData).FirstOrDefault();
            return arby;
        }

        internal void DestroyArby(int arbyId)
        {
            string sql = "DELETE FROM arbys WHERE id = @arbyId;";

            _db.Execute(sql, new { arbyId });
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

        internal void UpdateArby(Arby originalArby)
        {
            string sql = @"
            UPDATE arbys SET 
            name = @Name,
            calories = @Calories,
            numberOfMeats = @NumberOfMeats
            ;";

            _db.Execute(sql, originalArby);
        }
    }
}