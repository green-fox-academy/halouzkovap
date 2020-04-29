using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Reddit.Entities;
using Reddit.Servises;
using Reddit.ViewModel;
using System.Threading.Tasks;

namespace Reddit.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly UserManager<UserReddit> userManager;

        public PostController(IPostService postService, UserManager<UserReddit> userManager)
        {
            this.postService = postService;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize]

        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePost(CreatePostViewModel model)
        {

            if (ModelState.IsValid)
            {
                var currentUser = await userManager.FindByNameAsync(User.Identity.Name);
                var NewModel = new Post
                {
                    Titel = model.Titel,
                    PostUrl = model.PostUrl
                };
                NewModel.UserReddit = currentUser;

                postService.CreatePost(NewModel);

            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public IActionResult UserPost()
        {
            var username = User.Identity.Name;

            var posts = postService.GetPostByUsername(username);
            return View(posts);
        }
    }
}