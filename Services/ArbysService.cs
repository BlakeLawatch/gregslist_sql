
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

        internal Arby CreateArby(Arby arbyData)
        {
            Arby arby = _repository.CreateArby(arbyData);
            return arby;
        }

        internal Arby DestroyArby(int arbyId)
        {
            Arby arby = GetArbyById(arbyId);
            _repository.DestroyArby(arbyId);

            if (arby == null)
            {
                throw new Exception($"No Arby with the ID: {arbyId}");
            }
            return arby;
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

        internal Arby UpdateArby(int arbyId, Arby arbyData)
        {
            Arby originalArby = GetArbyById(arbyId);

            originalArby.Name = arbyData.Name ?? originalArby.Name;
            originalArby.numberOfMeats = arbyData.numberOfMeats ?? originalArby.numberOfMeats;
            originalArby.calories = arbyData.calories ?? originalArby.calories;

            _repository.UpdateArby(originalArby);
            return originalArby;
        }
    }
}