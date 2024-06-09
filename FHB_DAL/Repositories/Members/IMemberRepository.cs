using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Members
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
        Member GetMemberByName(string name);
    }
}
