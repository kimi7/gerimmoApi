using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gerimmoApi.Models;

namespace gerimmoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerPropertyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<OwnerProperty>> Get()
        {
            
            using (var db = new ApplicationDbContext())
            {
                var ownerProperty = new List<OwnerProperty>{
                    new OwnerProperty{
                        //Id=1,
                        Name="Charmand 2 pièce à La Défense",
                        Description="Magnifique T2 Idéalement situé pour vos séjours..."
                    },
                    new OwnerProperty{
                        //Id=2,
                        Name="3 pièce dans immeule Haussmanien à St-Lazare",
                        Description="Bla bla..."
                    },
                    new OwnerProperty{
                        //Id=3,
                        Name="Studio proche des Champs Elysés",
                        Description="Bla bla..."
                    }
                };
                db.OwnerProperties.AddRange(ownerProperty);
                db.SaveChanges();

                ownerProperty = db.OwnerProperties
                    .OrderBy(b => b.Id)
                    .ToList();
                return ownerProperty;

            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        // // GET api/values
        // [HttpGet]
        // public ActionResult<IEnumerable<OwnerProperty>> GetTest()
        // {
        //     // using (var db = new ApplicationDbContext())
        //     // {
        //     //     var ownerProperty = db.OwnerProperties
        //     //         .OrderBy(b => b.Id)
        //     //         .ToList();
        //     //     return ownerProperty;
        //     // }

        //     return new List<OwnerProperty>{
        //         new OwnerProperty{
        //             Id=1,
        //             Name="Charmand 2 pièce à La Défense",
        //             Description="Magnifique T2 Idéalement situé pour vos séjours..."
        //         },
        //         new OwnerProperty{
        //             Id=2,
        //             Name="3 pièce dans immeule Haussmanien à St-Lazare",
        //             Description="Bla bla..."
        //         },
        //         new OwnerProperty{
        //             Id=3,
        //             Name="Studio proche des Champs Elysés",
        //             Description="Bla bla..."
        //         }
        //     };
        // }

        // // GET api/values
        // [HttpGet]
        // public bool InitDemo()
        // {
        //     using (var db = new ApplicationDbContext())
        //     {
        //         var ownerProperty = new List<OwnerProperty>{
        //             new OwnerProperty{
        //                 Id=1,
        //                 Name="Charmand 2 pièce à La Défense",
        //                 Description="Magnifique T2 Idéalement situé pour vos séjours..."
        //             },
        //             new OwnerProperty{
        //                 Id=2,
        //                 Name="3 pièce dans immeule Haussmanien à St-Lazare",
        //                 Description="Bla bla..."
        //             },
        //             new OwnerProperty{
        //                 Id=3,
        //                 Name="Studio proche des Champs Elysés",
        //                 Description="Bla bla..."
        //             }
        //         };
        //         db.OwnerProperties.AddRange(ownerProperty);
        //         db.SaveChanges();
        //     }
        //     return true;
        // }

    }
}