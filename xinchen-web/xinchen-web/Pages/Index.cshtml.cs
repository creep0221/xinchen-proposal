using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System;
using xinchen_web.Models;
using xinchen_web.Services;

namespace xinchen_web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MongoSvc mongoSvc;

        public IndexModel(ILogger<IndexModel> logger, MongoSvc mongoSvc)
        {
            _logger = logger;
            this.mongoSvc = mongoSvc;
        }

        public void OnGet()
        {
            //var mongoClient = new MongoClient("mongodb+srv://xinchen:Ep0zMZZcn4tcFKth@cluster0.1ndntna.mongodb.net/?retryWrites=true&w=majority");
            //var mongoDatabase = mongoClient.GetDatabase("xinchen");

            //var collection = mongoDatabase.GetCollection<User>(
            //    "User");

            //try
            //{
            //    var username = "admin";
            //    var filter = Builders<User>.Filter.Eq(x => x.Account, username);
            //    var test =mongoSvc.Get<User>(filter).ToList();
            //    var t = collection.Find<User>(x => x.Account == username).ToList();
            //}
            //catch (Exception ex) { throw ex; }
            
        }
    }
}