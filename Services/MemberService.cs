using Microsoft.EntityFrameworkCore;
using Bookish.DbModels;
using Bookish.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bookish.Services
{
    public interface IMemberService
    {
        List<MemberViewModel> GenerateMemberList();
        void AddNewMember(MemberRequestModel newMember);
        MemberViewModel GetIndividualMember(int id);
        void EditMember(MemberViewModel member);
        void Delete(int id);
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
            var membersTable = _context.Members.Select(member => new MemberViewModel(member, false)).ToList();

            return membersTable;
        }

        public MemberViewModel GetIndividualMember(int id)
        {
            var member = _context.Members
                .Include(m => m.CheckedOutBooks)
                .ThenInclude(b => b.Book)
                .Single(m => m.Id == id);

            return new MemberViewModel(member, true);
        }

        public void AddNewMember(MemberRequestModel newMember)
        {
            var member = new MemberDbModel
            {
                Name = newMember.Name,
                Address = newMember.Address,
                PhoneNumber = newMember.PhoneNumber
            };

            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void EditMember(MemberViewModel memberViewModel)
        {
            var member = _context.Members.Single(m => m.Id == memberViewModel.Id);

            member.Name = memberViewModel.Name;
            member.Address = memberViewModel.Address;
            member.PhoneNumber = memberViewModel.PhoneNumber;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var member = _context.Members.Find(id);
            _context.Members.Remove(member);
            _context.SaveChanges();
        }
    }
}
