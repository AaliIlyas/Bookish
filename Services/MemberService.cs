using Bookish.DbModels;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Services
{
    public class MemberService
    {
        public static List<MemberViewModel> GenerateMemberList()
        {
            var context = new LibraryContext();
            var membersTable = context.Members.Select(member => ConvertToMemberViewModel(member)).ToList();

            return membersTable;
        }

        public static MemberViewModel ConvertToMemberViewModel(MemberDbModel member)
        {
            var memberToView = new MemberViewModel
            {
                Id = member.Id,
                Name = member.Name,
                Address = member.Address,
                PhoneNumber = member.PhoneNumber,
            };

            return memberToView;
        }
    }
}
