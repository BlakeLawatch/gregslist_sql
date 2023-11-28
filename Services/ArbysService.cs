
using Microsoft.AspNetCore.Http.HttpResults;

namespace gregslist_sql.Services
{
    public class ArbysService
    {

        private readonly ArbysRepository _repository;

        public ArbysService(ArbysRepository repository)
        {
            _repository = repository;
        }

        internal Arby GetArbyById(int arbyId)
        {
            Arby arby = _repository.GetArbyById(arbyId);

            if (arby == null)
            {
                throw new Exception($"Invalid Arby ID: {arbyId}");
            }
            return arby;
        }

        internal List<Arby> GetArbys()
        {
            List<Arby> arbys = _repository.GetArbys();
            return arbys;

        }
    }
}