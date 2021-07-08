using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.DbModels;

namespace Bookish.Controllers
{
    public class MembersController : Controller
    {
        private readonly ILogger<MembersController> _logger;

        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }

        public IActionResult All()
        {
            var context = new LibraryContext();
            var membersTable = context.Members.Select(member => ConvertToMemberViewModel(member)).ToList();

            return View(membersTable);
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
