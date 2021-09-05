using Microsoft.AspNetCore.Mvc;
using Bookish.Services;
using Bookish.Models;

namespace Bookish.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var membersTable = _memberService.GenerateMemberList();
            return View(membersTable);
        }

        [HttpPost]
        public IActionResult Create(MemberRequestModel member)
        {
            _memberService.AddNewMember(member);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModifyMember(MemberViewModel member)
        {
            _memberService.EditMember(member);
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _memberService.Delete(id);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult MemberPage(int id)
        {
            var member = _memberService.GetIndividualMember(id);
            return View(member);
        }
    }
}