using Microsoft.AspNetCore.Mvc;
using Bookish.Services;

namespace Bookish.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult All()
        {
            var membersTable = _memberService.GenerateMemberList();

            return View(membersTable);
        }
    }
}