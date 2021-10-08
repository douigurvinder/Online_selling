using Online_selling.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_selling.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Class1 genre);
    }
}
