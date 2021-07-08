using Bookish.DbModels;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Services
{
    public interface IMemberService
    {
        List<MemberViewModel> GenerateMemberList();
    }

    public class MemberService : IMemberService
    {
        private readonly LibraryContext _context;

        public MemberService(LibraryContext context)
        {
            _context = context;
        }

        public List<MemberViewModel> GenerateMemberList()
        {
            var membersTable = _context.Members.Select(member => new MemberViewModel(member)).ToList();

            return membersTable;
        }
    }
}
