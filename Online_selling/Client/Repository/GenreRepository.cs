using Online_selling.Client.Htpp;
using Online_selling.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_selling.Client.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/genres";

        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateGenre (Class1 genre)
        {

            var response = await httpService.Post(url, genre);
            if (!response.Success) 
            {
                throw new ApplicationException(await response.GetBody());
            }

        }



    }
}
